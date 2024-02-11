namespace MNDBProject
{
    partial class BorrowMoviesForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BorrowButton = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.MovieInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(778, 163);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BorrowButton
            // 
            this.BorrowButton.Location = new System.Drawing.Point(13, 237);
            this.BorrowButton.Name = "BorrowButton";
            this.BorrowButton.Size = new System.Drawing.Size(93, 38);
            this.BorrowButton.TabIndex = 1;
            this.BorrowButton.Text = "Wypożycz";
            this.BorrowButton.UseVisualStyleBackColor = true;
            this.BorrowButton.Click += new System.EventHandler(this.BorrowButton_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(12, 9);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(204, 16);
            this.InfoLabel.TabIndex = 2;
            this.InfoLabel.Text = "Wybierz klienta do wypożyczenia";
            // 
            // MovieInfo
            // 
            this.MovieInfo.AutoSize = true;
            this.MovieInfo.Location = new System.Drawing.Point(238, 9);
            this.MovieInfo.Name = "MovieInfo";
            this.MovieInfo.Size = new System.Drawing.Size(120, 16);
            this.MovieInfo.TabIndex = 3;
            this.MovieInfo.Text = "Wypożyczany film: ";
            // 
            // BorrowMoviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 287);
            this.Controls.Add(this.MovieInfo);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.BorrowButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BorrowMoviesForm";
            this.Text = "BorrowMoviesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BorrowButton;
        private System.Windows.Forms.Label InfoLabel;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label MovieInfo;
    }
}