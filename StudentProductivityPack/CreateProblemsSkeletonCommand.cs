//------------------------------------------------------------------------------
// <copyright file="CreateProblemsSkeleton.cs" company="Company">
//     Copyright (c) Company.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel.Design;
using System.Globalization;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using EnvDTE;
using EnvDTE80;
using StudentProductivityPack.Builders;
using System.IO;
using StudentProductivityPack.Wizards;
using System.Windows.Forms;

namespace StudentProductivityPack
{
    /// <summary>
    /// Command handler
    /// </summary>
    internal sealed class CreateProblemsSkeletonCommand
    {
        /// <summary>
        /// Command ID.
        /// </summary>
        public const int CommandId = 0x0100;

        /// <summary>
        /// Command menu group (command set GUID).
        /// </summary>
        public static readonly Guid CommandSet = new Guid("cabaec7a-4f03-45c1-8970-1b267b79294e");

        /// <summary>
        /// VS Package that provides this command, not null.
        /// </summary>
        private readonly Package package;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProblemsSkeletonCommand"/> class.
        /// Adds our command handlers for menu (commands must exist in the command table file)
        /// </summary>
        /// <param name="package">Owner package, not null.</param>
        private CreateProblemsSkeletonCommand(Package package)
        {
            if (package == null)
            {
                throw new ArgumentNullException("package");
            }

            this.package = package;

            OleMenuCommandService commandService = this.ServiceProvider.GetService(typeof(IMenuCommandService)) as OleMenuCommandService;
            if (commandService != null)
            {
                var menuCommandID = new CommandID(CommandSet, CommandId);
                var menuItem = new MenuCommand(this.CreateSolutionSkeletonClicked, menuCommandID);
                commandService.AddCommand(menuItem);
            }
        }
        
        public static CreateProblemsSkeletonCommand Instance
        {
            get;
            private set;
        }

        private IServiceProvider ServiceProvider
        {
            get
            {
                return this.package;
            }
        }

        public static void Initialize(Package package)
        {
            Instance = new CreateProblemsSkeletonCommand(package);
        }

        private void CreateSolutionSkeletonClicked(object sender, EventArgs e)
        {
            var dte2 = Package.GetGlobalService(typeof(DTE)) as DTE2;
            var defaultSolutionName = "Solution1";
            var defaultProjectsFolder = dte2.Properties["Environment", "ProjectsAndSolution"]
               .Item("ProjectsLocation").Value.ToString();

            var solutionGeneratorWizard = new SolutionWizard(defaultSolutionName,
                defaultProjectsFolder);
            solutionGeneratorWizard.ShowDialog();
            if (solutionGeneratorWizard.DialogResult != DialogResult.OK)
                return;

            var solutionName = solutionGeneratorWizard.SolutionName;
            var solutionFolder = solutionGeneratorWizard.SolutionFolder;
            var projectNames = solutionGeneratorWizard.ProjectNames;
 
            var solution2 = dte2.Solution as Solution2;
            
            var solutionBuilder = new SolutionBuilder(solution2);
            solutionBuilder
                .CreateSolution(solutionFolder, solutionName)
                .AddProjects(projectNames);
        }
    }
}
