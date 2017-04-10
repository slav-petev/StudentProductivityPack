using EnvDTE;
using EnvDTE80;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProductivityPack.Builders
{
    public class SolutionBuilder
    {
        private readonly Solution2 _solution;
        private string _solutionPath;

        public SolutionBuilder(Solution2 solution)
        {
            _solution = solution;
        }

        public SolutionBuilder CreateSolution(string solutionFolder, string solutionName)
        {
            _solutionPath = solutionFolder;
            _solution.Create(solutionFolder, solutionName);
            return this;
        }

        //TODO Slav Add other project types and languages
        public SolutionBuilder AddProjects(IEnumerable<string> projectNames)
        {
            var cSharpConsoleProjectTemplatePath = _solution.GetProjectTemplate(
                "ConsoleApplication.zip", "CSharp");

            foreach (var projectName in projectNames)
            {
                var projectPath = Path.Combine(_solutionPath, projectName);

                _solution.AddFromTemplate(cSharpConsoleProjectTemplatePath,
                    projectPath, projectName, false);
            }

            return this;
        }
    }
}
