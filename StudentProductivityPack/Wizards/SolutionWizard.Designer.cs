namespace StudentProductivityPack.Wizards
{
    partial class SolutionWizard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolutionWizard));
            this.lblSolutionName = new System.Windows.Forms.Label();
            this.lblSolutionFolder = new System.Windows.Forms.Label();
            this.dlgSolutionFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.btnOpenFolderDialog = new System.Windows.Forms.Button();
            this.tbxSolutionName = new System.Windows.Forms.TextBox();
            this.lblProjectNames = new System.Windows.Forms.Label();
            this.tbxProjectNames = new System.Windows.Forms.TextBox();
            this.btnGenerateSkeleton = new System.Windows.Forms.Button();
            this.btnCancelSkeletonGeneration = new System.Windows.Forms.Button();
            this.lblSolutionFolderValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSolutionName
            // 
            this.lblSolutionName.AutoSize = true;
            this.lblSolutionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolutionName.Location = new System.Drawing.Point(13, 18);
            this.lblSolutionName.Name = "lblSolutionName";
            this.lblSolutionName.Size = new System.Drawing.Size(178, 29);
            this.lblSolutionName.TabIndex = 0;
            this.lblSolutionName.Text = "Solution Name:";
            // 
            // lblSolutionFolder
            // 
            this.lblSolutionFolder.AutoSize = true;
            this.lblSolutionFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolutionFolder.Location = new System.Drawing.Point(12, 95);
            this.lblSolutionFolder.Name = "lblSolutionFolder";
            this.lblSolutionFolder.Size = new System.Drawing.Size(184, 29);
            this.lblSolutionFolder.TabIndex = 1;
            this.lblSolutionFolder.Text = "Solution Folder:";
            // 
            // btnOpenFolderDialog
            // 
            this.btnOpenFolderDialog.Location = new System.Drawing.Point(11, 176);
            this.btnOpenFolderDialog.Name = "btnOpenFolderDialog";
            this.btnOpenFolderDialog.Size = new System.Drawing.Size(194, 37);
            this.btnOpenFolderDialog.TabIndex = 2;
            this.btnOpenFolderDialog.Text = "Choose Solution Folder";
            this.btnOpenFolderDialog.UseVisualStyleBackColor = true;
            this.btnOpenFolderDialog.Click += new System.EventHandler(this.btnChooseSolutionFolderDialog_Click);
            // 
            // tbxSolutionName
            // 
            this.tbxSolutionName.Location = new System.Drawing.Point(12, 61);
            this.tbxSolutionName.Name = "tbxSolutionName";
            this.tbxSolutionName.Size = new System.Drawing.Size(193, 22);
            this.tbxSolutionName.TabIndex = 3;
            // 
            // lblProjectNames
            // 
            this.lblProjectNames.AutoSize = true;
            this.lblProjectNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectNames.Location = new System.Drawing.Point(12, 232);
            this.lblProjectNames.Name = "lblProjectNames";
            this.lblProjectNames.Size = new System.Drawing.Size(458, 29);
            this.lblProjectNames.TabIndex = 4;
            this.lblProjectNames.Text = "Enter Project names separated by space: ";
            // 
            // tbxProjectNames
            // 
            this.tbxProjectNames.Location = new System.Drawing.Point(12, 275);
            this.tbxProjectNames.Multiline = true;
            this.tbxProjectNames.Name = "tbxProjectNames";
            this.tbxProjectNames.Size = new System.Drawing.Size(435, 123);
            this.tbxProjectNames.TabIndex = 5;
            // 
            // btnGenerateSkeleton
            // 
            this.btnGenerateSkeleton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGenerateSkeleton.Location = new System.Drawing.Point(12, 415);
            this.btnGenerateSkeleton.Name = "btnGenerateSkeleton";
            this.btnGenerateSkeleton.Size = new System.Drawing.Size(155, 34);
            this.btnGenerateSkeleton.TabIndex = 6;
            this.btnGenerateSkeleton.Text = "Go";
            this.btnGenerateSkeleton.UseVisualStyleBackColor = true;
            // 
            // btnCancelSkeletonGeneration
            // 
            this.btnCancelSkeletonGeneration.Location = new System.Drawing.Point(187, 415);
            this.btnCancelSkeletonGeneration.Name = "btnCancelSkeletonGeneration";
            this.btnCancelSkeletonGeneration.Size = new System.Drawing.Size(155, 34);
            this.btnCancelSkeletonGeneration.TabIndex = 7;
            this.btnCancelSkeletonGeneration.Text = "Cancel";
            this.btnCancelSkeletonGeneration.UseVisualStyleBackColor = true;
            this.btnCancelSkeletonGeneration.Click += new System.EventHandler(this.btnCancelSkeletonGeneration_Click);
            // 
            // lblSolutionFolderValue
            // 
            this.lblSolutionFolderValue.AutoEllipsis = true;
            this.lblSolutionFolderValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolutionFolderValue.Location = new System.Drawing.Point(12, 134);
            this.lblSolutionFolderValue.Name = "lblSolutionFolderValue";
            this.lblSolutionFolderValue.Size = new System.Drawing.Size(435, 29);
            this.lblSolutionFolderValue.TabIndex = 8;
            // 
            // SolutionWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 461);
            this.Controls.Add(this.lblSolutionFolderValue);
            this.Controls.Add(this.btnCancelSkeletonGeneration);
            this.Controls.Add(this.btnGenerateSkeleton);
            this.Controls.Add(this.tbxProjectNames);
            this.Controls.Add(this.lblProjectNames);
            this.Controls.Add(this.tbxSolutionName);
            this.Controls.Add(this.btnOpenFolderDialog);
            this.Controls.Add(this.lblSolutionFolder);
            this.Controls.Add(this.lblSolutionName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SolutionWizard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solution Creation Wizard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SolutionSkeleton_FormClosing);
            this.Load += new System.EventHandler(this.SolutionSkeleton_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSolutionName;
        private System.Windows.Forms.Label lblSolutionFolder;
        private System.Windows.Forms.FolderBrowserDialog dlgSolutionFolder;
        private System.Windows.Forms.Button btnOpenFolderDialog;
        private System.Windows.Forms.TextBox tbxSolutionName;
        private System.Windows.Forms.Label lblProjectNames;
        private System.Windows.Forms.TextBox tbxProjectNames;
        private System.Windows.Forms.Button btnGenerateSkeleton;
        private System.Windows.Forms.Button btnCancelSkeletonGeneration;
        private System.Windows.Forms.Label lblSolutionFolderValue;
    }
}