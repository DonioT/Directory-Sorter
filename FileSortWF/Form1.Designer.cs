namespace FileSortWF
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DirectoryButton = new System.Windows.Forms.Button();
            this.DirectoryTextBox = new System.Windows.Forms.TextBox();
            this.DestinationButton = new System.Windows.Forms.Button();
            this.DestinationTextBox = new System.Windows.Forms.TextBox();
            this.SortOptionCheckBoxes = new System.Windows.Forms.CheckedListBox();
            this.SortOptionsCheckboxLabel = new System.Windows.Forms.Label();
            this.SortButton = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.DirectoryLabel = new System.Windows.Forms.Label();
            this.DestinationLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.CurrentSortLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DirectoryButton
            // 
            this.DirectoryButton.Image = ((System.Drawing.Image)(resources.GetObject("DirectoryButton.Image")));
            this.DirectoryButton.Location = new System.Drawing.Point(33, 79);
            this.DirectoryButton.Name = "DirectoryButton";
            this.DirectoryButton.Size = new System.Drawing.Size(40, 40);
            this.DirectoryButton.TabIndex = 0;
            this.DirectoryButton.UseVisualStyleBackColor = true;
            this.DirectoryButton.Click += new System.EventHandler(this.Directory_Click);
            // 
            // DirectoryTextBox
            // 
            this.DirectoryTextBox.Location = new System.Drawing.Point(103, 90);
            this.DirectoryTextBox.Name = "DirectoryTextBox";
            this.DirectoryTextBox.Size = new System.Drawing.Size(270, 20);
            this.DirectoryTextBox.TabIndex = 1;
            // 
            // DestinationButton
            // 
            this.DestinationButton.Image = ((System.Drawing.Image)(resources.GetObject("DestinationButton.Image")));
            this.DestinationButton.Location = new System.Drawing.Point(33, 142);
            this.DestinationButton.Name = "DestinationButton";
            this.DestinationButton.Size = new System.Drawing.Size(40, 41);
            this.DestinationButton.TabIndex = 2;
            this.DestinationButton.UseVisualStyleBackColor = true;
            this.DestinationButton.Click += new System.EventHandler(this.DestinationButton_Click);
            // 
            // DestinationTextBox
            // 
            this.DestinationTextBox.Location = new System.Drawing.Point(103, 153);
            this.DestinationTextBox.Name = "DestinationTextBox";
            this.DestinationTextBox.Size = new System.Drawing.Size(270, 20);
            this.DestinationTextBox.TabIndex = 3;
            // 
            // SortOptionCheckBoxes
            // 
            this.SortOptionCheckBoxes.CheckOnClick = true;
            this.SortOptionCheckBoxes.FormattingEnabled = true;
            this.SortOptionCheckBoxes.Items.AddRange(new object[] {
            "Music",
            "Media",
            "Applications",
            "Documents",
            "Images",
            "CompressedFiles"});
            this.SortOptionCheckBoxes.Location = new System.Drawing.Point(33, 226);
            this.SortOptionCheckBoxes.Name = "SortOptionCheckBoxes";
            this.SortOptionCheckBoxes.Size = new System.Drawing.Size(109, 109);
            this.SortOptionCheckBoxes.TabIndex = 4;
            // 
            // SortOptionsCheckboxLabel
            // 
            this.SortOptionsCheckboxLabel.AutoSize = true;
            this.SortOptionsCheckboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SortOptionsCheckboxLabel.Location = new System.Drawing.Point(29, 199);
            this.SortOptionsCheckboxLabel.Name = "SortOptionsCheckboxLabel";
            this.SortOptionsCheckboxLabel.Size = new System.Drawing.Size(113, 24);
            this.SortOptionsCheckboxLabel.TabIndex = 5;
            this.SortOptionsCheckboxLabel.Text = "Sort Options";
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(287, 225);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(85, 30);
            this.SortButton.TabIndex = 6;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(103, 12);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(270, 36);
            this.ProgressBar.TabIndex = 7;
            // 
            // DirectoryLabel
            // 
            this.DirectoryLabel.AutoSize = true;
            this.DirectoryLabel.Location = new System.Drawing.Point(100, 74);
            this.DirectoryLabel.Name = "DirectoryLabel";
            this.DirectoryLabel.Size = new System.Drawing.Size(87, 13);
            this.DirectoryLabel.TabIndex = 8;
            this.DirectoryLabel.Text = "Directory To Sort";
            // 
            // DestinationLabel
            // 
            this.DestinationLabel.AutoSize = true;
            this.DestinationLabel.Location = new System.Drawing.Point(100, 137);
            this.DestinationLabel.Name = "DestinationLabel";
            this.DestinationLabel.Size = new System.Drawing.Size(60, 13);
            this.DestinationLabel.TabIndex = 9;
            this.DestinationLabel.Text = "Destination";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(150, 232);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 10;
            // 
            // CurrentSortLabel
            // 
            this.CurrentSortLabel.AutoSize = true;
            this.CurrentSortLabel.Location = new System.Drawing.Point(169, 51);
            this.CurrentSortLabel.Name = "CurrentSortLabel";
            this.CurrentSortLabel.Size = new System.Drawing.Size(0, 13);
            this.CurrentSortLabel.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 359);
            this.Controls.Add(this.CurrentSortLabel);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.DestinationLabel);
            this.Controls.Add(this.DirectoryLabel);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.SortOptionsCheckboxLabel);
            this.Controls.Add(this.SortOptionCheckBoxes);
            this.Controls.Add(this.DestinationTextBox);
            this.Controls.Add(this.DestinationButton);
            this.Controls.Add(this.DirectoryTextBox);
            this.Controls.Add(this.DirectoryButton);
            this.Name = "Form1";
            this.Text = "File Sorter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DirectoryButton;
        private System.Windows.Forms.TextBox DirectoryTextBox;
        private System.Windows.Forms.Button DestinationButton;
        private System.Windows.Forms.TextBox DestinationTextBox;
        private System.Windows.Forms.CheckedListBox SortOptionCheckBoxes;
        private System.Windows.Forms.Label SortOptionsCheckboxLabel;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label DestinationLabel;
        private System.Windows.Forms.Label DirectoryLabel;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label CurrentSortLabel;
    }
}

