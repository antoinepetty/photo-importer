namespace WindowsFormsApp1
{
    partial class ImportForm
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
            this.sourceFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.import = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sourceText = new System.Windows.Forms.TextBox();
            this.destinationText = new System.Windows.Forms.TextBox();
            this.sourceBrowse = new System.Windows.Forms.Button();
            this.destBrowse = new System.Windows.Forms.Button();
            this.importDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.destinationFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // sourceFolderBrowserDialog
            // 
            this.sourceFolderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 151);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(469, 23);
            this.progressBar.TabIndex = 0;
            // 
            // import
            // 
            this.import.Location = new System.Drawing.Point(406, 122);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(75, 23);
            this.import.TabIndex = 1;
            this.import.Text = "Import";
            this.import.UseVisualStyleBackColor = true;
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination";
            // 
            // sourceText
            // 
            this.sourceText.Location = new System.Drawing.Point(12, 25);
            this.sourceText.Name = "sourceText";
            this.sourceText.Size = new System.Drawing.Size(388, 20);
            this.sourceText.TabIndex = 4;
            // 
            // destinationText
            // 
            this.destinationText.Location = new System.Drawing.Point(12, 64);
            this.destinationText.Name = "destinationText";
            this.destinationText.Size = new System.Drawing.Size(388, 20);
            this.destinationText.TabIndex = 5;
            // 
            // sourceBrowse
            // 
            this.sourceBrowse.Location = new System.Drawing.Point(406, 23);
            this.sourceBrowse.Name = "sourceBrowse";
            this.sourceBrowse.Size = new System.Drawing.Size(75, 23);
            this.sourceBrowse.TabIndex = 6;
            this.sourceBrowse.Text = "Browse";
            this.sourceBrowse.UseVisualStyleBackColor = true;
            this.sourceBrowse.Click += new System.EventHandler(this.sourceBrowse_Click);
            // 
            // destBrowse
            // 
            this.destBrowse.Location = new System.Drawing.Point(406, 62);
            this.destBrowse.Name = "destBrowse";
            this.destBrowse.Size = new System.Drawing.Size(75, 23);
            this.destBrowse.TabIndex = 7;
            this.destBrowse.Text = "Browse";
            this.destBrowse.UseVisualStyleBackColor = true;
            this.destBrowse.Click += new System.EventHandler(this.destBrowse_Click);
            // 
            // importDatePicker
            // 
            this.importDatePicker.Location = new System.Drawing.Point(12, 103);
            this.importDatePicker.Name = "importDatePicker";
            this.importDatePicker.Size = new System.Drawing.Size(130, 20);
            this.importDatePicker.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Earliest import date";
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 186);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.importDatePicker);
            this.Controls.Add(this.destBrowse);
            this.Controls.Add(this.sourceBrowse);
            this.Controls.Add(this.destinationText);
            this.Controls.Add(this.sourceText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.import);
            this.Controls.Add(this.progressBar);
            this.Name = "ImportForm";
            this.Text = "AP Photo Importer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog sourceFolderBrowserDialog;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button import;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sourceText;
        private System.Windows.Forms.TextBox destinationText;
        private System.Windows.Forms.Button sourceBrowse;
        private System.Windows.Forms.Button destBrowse;
        private System.Windows.Forms.DateTimePicker importDatePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog destinationFolderBrowserDialog;
    }
}

