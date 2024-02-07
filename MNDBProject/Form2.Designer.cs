namespace MNDBProject
{
    partial class Form2
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
            this.movieTitleTextBox = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DirectorLabel = new System.Windows.Forms.Label();
            this.directorTextBox = new System.Windows.Forms.TextBox();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.gradeTextBox = new System.Windows.Forms.TextBox();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // movieTitleTextBox
            // 
            this.movieTitleTextBox.Location = new System.Drawing.Point(12, 28);
            this.movieTitleTextBox.Name = "movieTitleTextBox";
            this.movieTitleTextBox.Size = new System.Drawing.Size(161, 22);
            this.movieTitleTextBox.TabIndex = 0;
            // 
            // OK
            // 
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Location = new System.Drawing.Point(13, 348);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(88, 28);
            this.OK.TabIndex = 1;
            this.OK.Text = "Dodaj film";
            this.OK.UseVisualStyleBackColor = true;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(12, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(39, 16);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Tytuł";
            // 
            // DirectorLabel
            // 
            this.DirectorLabel.AutoSize = true;
            this.DirectorLabel.Location = new System.Drawing.Point(12, 53);
            this.DirectorLabel.Name = "DirectorLabel";
            this.DirectorLabel.Size = new System.Drawing.Size(57, 16);
            this.DirectorLabel.TabIndex = 3;
            this.DirectorLabel.Text = "Reżyser";
            // 
            // directorTextBox
            // 
            this.directorTextBox.Location = new System.Drawing.Point(12, 73);
            this.directorTextBox.Name = "directorTextBox";
            this.directorTextBox.Size = new System.Drawing.Size(161, 22);
            this.directorTextBox.TabIndex = 4;
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(12, 102);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(158, 16);
            this.lengthLabel.TabIndex = 5;
            this.lengthLabel.Text = "Długość filmu w minutach";
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(15, 122);
            this.lengthTextBox.MaxLength = 4;
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(100, 22);
            this.lengthTextBox.TabIndex = 6;
            // 
            // gradeTextBox
            // 
            this.gradeTextBox.Location = new System.Drawing.Point(12, 166);
            this.gradeTextBox.MaxLength = 3;
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.Size = new System.Drawing.Size(100, 22);
            this.gradeTextBox.TabIndex = 7;
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Location = new System.Drawing.Point(12, 147);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(47, 16);
            this.gradeLabel.TabIndex = 8;
            this.gradeLabel.Text = "Ocena";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 388);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.gradeTextBox);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.directorTextBox);
            this.Controls.Add(this.DirectorLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.movieTitleTextBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox movieTitleTextBox;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label DirectorLabel;
        private System.Windows.Forms.TextBox directorTextBox;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.TextBox gradeTextBox;
        private System.Windows.Forms.Label gradeLabel;
    }
}