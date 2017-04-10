using StudentProductivityPack.Common;
using StudentProductivityPack.Factories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentProductivityPack.Wizards
{
    public partial class SolutionWizard : Form
    {
        public string SolutionName { get; set; }
        public string SolutionFolder { get; private set; }
        public IEnumerable<string> ProjectNames { get; private set; }

        public SolutionWizard(string defaultSolutionName, string defaultSolutionFolder)
        {
            InitializeComponent();
            this.SolutionName = defaultSolutionName;
            this.SolutionFolder = defaultSolutionFolder;
        }

        private void SolutionSkeleton_Load(object sender, EventArgs e)
        {
            tbxSolutionName.Text = this.SolutionName;
            lblSolutionFolderValue.Text = this.SolutionFolder;
            this.ActiveControl = tbxSolutionName;
        }

        private void btnCancelSkeletonGeneration_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChooseSolutionFolderDialog_Click(object sender, EventArgs e)
        {
            var solutionFolderDialogResult = dlgSolutionFolder.ShowDialog();
            if (solutionFolderDialogResult != DialogResult.OK)
                return;

            this.SolutionFolder = dlgSolutionFolder.SelectedPath;
            lblSolutionFolderValue.Text = dlgSolutionFolder.SelectedPath;
        }

        private void SolutionSkeleton_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.None)
            {
                if (string.IsNullOrWhiteSpace(tbxSolutionName.Text))
                {
                    DialogBoxFactory.ShowErrorDialog(
                        Messages.Error.CANNOT_CREATE_SOLUTION_TITLE,
                        Messages.Error.SOLUTION_MUST_HAVE_NAME);
                    e.Cancel = true;
                    this.ActiveControl = tbxSolutionName;
                    return;
                }
                if (string.IsNullOrWhiteSpace(this.SolutionFolder))
                {
                    DialogBoxFactory.ShowErrorDialog(
                        Messages.Error.CANNOT_CREATE_SOLUTION_TITLE,
                        Messages.Error.SOLUTION_MUST_HAVE_FOLDER);
                    e.Cancel = true;
                    this.ActiveControl = btnOpenFolderDialog;
                    return;
                }
                if (string.IsNullOrWhiteSpace(tbxProjectNames.Text))
                {
                    var userChoice = DialogBoxFactory.ShowWarningDialog(
                        Messages.Warning.EMPTY_SOLUTION_CREATION_TITLE,
                        Messages.Warning.EMPTY_SOLUTION_CREATION_MESSAGE);
                    if (userChoice == DialogResult.No)
                    {
                        e.Cancel = true;
                        this.ActiveControl = tbxProjectNames;
                        return;
                    }
                }

                this.SolutionName = tbxSolutionName.Text;
                this.SolutionFolder = dlgSolutionFolder.SelectedPath;
                this.ProjectNames = tbxProjectNames.Text.Split(new[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries); 
            }
        }
    }
}
