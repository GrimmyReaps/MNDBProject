namespace MNDBProject
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
            this.Close = new System.Windows.Forms.Button();
            this.DebugLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ShowClients = new System.Windows.Forms.Button();
            this.ShowMovies = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(1105, 451);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(91, 34);
            this.Close.TabIndex = 0;
            this.Close.Text = "Zamknij";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.button1_Click);
            // 
            // DebugLabel
            // 
            this.DebugLabel.AutoSize = true;
            this.DebugLabel.Location = new System.Drawing.Point(1079, 9);
            this.DebugLabel.Name = "DebugLabel";
            this.DebugLabel.Size = new System.Drawing.Size(117, 16);
            this.DebugLabel.TabIndex = 2;
            this.DebugLabel.Text = "Empty Sadge T_T";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1015, 476);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // ShowClients
            // 
            this.ShowClients.Location = new System.Drawing.Point(1105, 399);
            this.ShowClients.Name = "ShowClients";
            this.ShowClients.Size = new System.Drawing.Size(91, 46);
            this.ShowClients.TabIndex = 4;
            this.ShowClients.Text = "Wyświetl Klientów";
            this.ShowClients.UseVisualStyleBackColor = true;
            this.ShowClients.Click += new System.EventHandler(this.button2_Click);
            // 
            // ShowMovies
            // 
            this.ShowMovies.Enabled = false;
            this.ShowMovies.Location = new System.Drawing.Point(1105, 347);
            this.ShowMovies.Name = "ShowMovies";
            this.ShowMovies.Size = new System.Drawing.Size(91, 46);
            this.ShowMovies.TabIndex = 5;
            this.ShowMovies.Text = "Wyświetl Filmy";
            this.ShowMovies.UseVisualStyleBackColor = true;
            this.ShowMovies.Click += new System.EventHandler(this.ShowMovies_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 497);
            this.Controls.Add(this.ShowMovies);
            this.Controls.Add(this.ShowClients);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DebugLabel);
            this.Controls.Add(this.Close);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label DebugLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ShowClients;
        private System.Windows.Forms.Button ShowMovies;
    }
}

