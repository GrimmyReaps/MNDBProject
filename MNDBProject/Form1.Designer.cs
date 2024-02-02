﻿namespace MNDBProject
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
            this.SortingType = new System.Windows.Forms.GroupBox();
            this.ByDateAdded = new System.Windows.Forms.RadioButton();
            this.ById = new System.Windows.Forms.RadioButton();
            this.ByName = new System.Windows.Forms.RadioButton();
            this.SortingDirection = new System.Windows.Forms.GroupBox();
            this.Descending = new System.Windows.Forms.RadioButton();
            this.Ascending = new System.Windows.Forms.RadioButton();
            this.AddClient = new System.Windows.Forms.Button();
            this.DeleteClient = new System.Windows.Forms.Button();
            this.ModifyClient = new System.Windows.Forms.Button();
            this.DeleteMovie = new System.Windows.Forms.Button();
            this.AddMovie = new System.Windows.Forms.Button();
            this.ModifyMovie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SortingType.SuspendLayout();
            this.SortingDirection.SuspendLayout();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(863, 370);
            this.Close.Margin = new System.Windows.Forms.Padding(2);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(68, 28);
            this.Close.TabIndex = 0;
            this.Close.Text = "Zamknij";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.button1_Click);
            // 
            // DebugLabel
            // 
            this.DebugLabel.AutoSize = true;
            this.DebugLabel.Location = new System.Drawing.Point(809, 7);
            this.DebugLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DebugLabel.Name = "DebugLabel";
            this.DebugLabel.Size = new System.Drawing.Size(104, 15);
            this.DebugLabel.TabIndex = 2;
            this.DebugLabel.Text = "Empty Sadge T_T";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 7);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(761, 387);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // ShowClients
            // 
            this.ShowClients.Location = new System.Drawing.Point(863, 328);
            this.ShowClients.Margin = new System.Windows.Forms.Padding(2);
            this.ShowClients.Name = "ShowClients";
            this.ShowClients.Size = new System.Drawing.Size(68, 37);
            this.ShowClients.TabIndex = 4;
            this.ShowClients.Text = "Wyświetl Klientów";
            this.ShowClients.UseVisualStyleBackColor = true;
            this.ShowClients.Click += new System.EventHandler(this.button2_Click);
            // 
            // ShowMovies
            // 
            this.ShowMovies.Enabled = false;
            this.ShowMovies.Location = new System.Drawing.Point(863, 286);
            this.ShowMovies.Margin = new System.Windows.Forms.Padding(2);
            this.ShowMovies.Name = "ShowMovies";
            this.ShowMovies.Size = new System.Drawing.Size(68, 37);
            this.ShowMovies.TabIndex = 5;
            this.ShowMovies.Text = "Wyświetl Filmy";
            this.ShowMovies.UseVisualStyleBackColor = true;
            this.ShowMovies.Click += new System.EventHandler(this.ShowMovies_Click);
            // 
            // SortingType
            // 
            this.SortingType.Controls.Add(this.ByDateAdded);
            this.SortingType.Controls.Add(this.ById);
            this.SortingType.Controls.Add(this.ByName);
            this.SortingType.Location = new System.Drawing.Point(775, 23);
            this.SortingType.Margin = new System.Windows.Forms.Padding(2);
            this.SortingType.Name = "SortingType";
            this.SortingType.Padding = new System.Windows.Forms.Padding(2);
            this.SortingType.Size = new System.Drawing.Size(122, 81);
            this.SortingType.TabIndex = 6;
            this.SortingType.TabStop = false;
            this.SortingType.Text = "Sortowanie";
            // 
            // ByDateAdded
            // 
            this.ByDateAdded.AutoSize = true;
            this.ByDateAdded.Location = new System.Drawing.Point(0, 60);
            this.ByDateAdded.Margin = new System.Windows.Forms.Padding(2);
            this.ByDateAdded.Name = "ByDateAdded";
            this.ByDateAdded.Size = new System.Drawing.Size(128, 19);
            this.ByDateAdded.TabIndex = 2;
            this.ByDateAdded.TabStop = true;
            this.ByDateAdded.Text = "Po Dacie Dodania";
            this.ByDateAdded.UseVisualStyleBackColor = true;
            this.ByDateAdded.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ByDateAdded_MouseClick);
            // 
            // ById
            // 
            this.ById.Checked = true;
            this.ById.Location = new System.Drawing.Point(0, 36);
            this.ById.Margin = new System.Windows.Forms.Padding(2);
            this.ById.Name = "ById";
            this.ById.Size = new System.Drawing.Size(78, 20);
            this.ById.TabIndex = 1;
            this.ById.TabStop = true;
            this.ById.Text = "Po Id";
            this.ById.UseVisualStyleBackColor = true;
            this.ById.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ById_MouseClick);
            // 
            // ByName
            // 
            this.ByName.AutoSize = true;
            this.ByName.Location = new System.Drawing.Point(0, 17);
            this.ByName.Margin = new System.Windows.Forms.Padding(2);
            this.ByName.Name = "ByName";
            this.ByName.Size = new System.Drawing.Size(87, 19);
            this.ByName.TabIndex = 0;
            this.ByName.TabStop = true;
            this.ByName.Text = "Po Nazwie";
            this.ByName.UseVisualStyleBackColor = true;
            this.ByName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ByName_MouseClick);
            // 
            // SortingDirection
            // 
            this.SortingDirection.Controls.Add(this.Descending);
            this.SortingDirection.Controls.Add(this.Ascending);
            this.SortingDirection.Location = new System.Drawing.Point(776, 110);
            this.SortingDirection.Margin = new System.Windows.Forms.Padding(2);
            this.SortingDirection.Name = "SortingDirection";
            this.SortingDirection.Padding = new System.Windows.Forms.Padding(2);
            this.SortingDirection.Size = new System.Drawing.Size(68, 60);
            this.SortingDirection.TabIndex = 7;
            this.SortingDirection.TabStop = false;
            this.SortingDirection.Text = "Kolejność";
            // 
            // Descending
            // 
            this.Descending.AutoSize = true;
            this.Descending.Location = new System.Drawing.Point(5, 40);
            this.Descending.Margin = new System.Windows.Forms.Padding(2);
            this.Descending.Name = "Descending";
            this.Descending.Size = new System.Drawing.Size(79, 19);
            this.Descending.TabIndex = 1;
            this.Descending.Text = "Malejąco";
            this.Descending.UseVisualStyleBackColor = true;
            // 
            // Ascending
            // 
            this.Ascending.AutoSize = true;
            this.Ascending.Checked = true;
            this.Ascending.Location = new System.Drawing.Point(5, 18);
            this.Ascending.Margin = new System.Windows.Forms.Padding(2);
            this.Ascending.Name = "Ascending";
            this.Ascending.Size = new System.Drawing.Size(77, 19);
            this.Ascending.TabIndex = 0;
            this.Ascending.TabStop = true;
            this.Ascending.Text = "Rosnąco";
            this.Ascending.UseVisualStyleBackColor = true;
            // 
            // AddClient
            // 
            this.AddClient.Enabled = false;
            this.AddClient.Location = new System.Drawing.Point(781, 357);
            this.AddClient.Name = "AddClient";
            this.AddClient.Size = new System.Drawing.Size(75, 39);
            this.AddClient.TabIndex = 8;
            this.AddClient.Text = "Dodaj klienta";
            this.AddClient.UseVisualStyleBackColor = true;
            // 
            // DeleteClient
            // 
            this.DeleteClient.Enabled = false;
            this.DeleteClient.Location = new System.Drawing.Point(781, 313);
            this.DeleteClient.Name = "DeleteClient";
            this.DeleteClient.Size = new System.Drawing.Size(75, 38);
            this.DeleteClient.TabIndex = 9;
            this.DeleteClient.Text = "Usuń klienta";
            this.DeleteClient.UseVisualStyleBackColor = true;
            // 
            // ModifyClient
            // 
            this.ModifyClient.Location = new System.Drawing.Point(781, 255);
            this.ModifyClient.Name = "ModifyClient";
            this.ModifyClient.Size = new System.Drawing.Size(75, 54);
            this.ModifyClient.TabIndex = 10;
            this.ModifyClient.Text = "Modyfikuj dane klienta";
            this.ModifyClient.UseVisualStyleBackColor = true;
            // 
            // DeleteMovie
            // 
            this.DeleteMovie.Location = new System.Drawing.Point(862, 255);
            this.DeleteMovie.Name = "DeleteMovie";
            this.DeleteMovie.Size = new System.Drawing.Size(68, 26);
            this.DeleteMovie.TabIndex = 11;
            this.DeleteMovie.Text = "Usuń film";
            this.DeleteMovie.UseVisualStyleBackColor = true;
            // 
            // AddMovie
            // 
            this.AddMovie.Location = new System.Drawing.Point(862, 211);
            this.AddMovie.Name = "AddMovie";
            this.AddMovie.Size = new System.Drawing.Size(67, 38);
            this.AddMovie.TabIndex = 12;
            this.AddMovie.Text = "Dodaj film";
            this.AddMovie.UseVisualStyleBackColor = true;
            // 
            // ModifyMovie
            // 
            this.ModifyMovie.Location = new System.Drawing.Point(781, 211);
            this.ModifyMovie.Name = "ModifyMovie";
            this.ModifyMovie.Size = new System.Drawing.Size(75, 38);
            this.ModifyMovie.TabIndex = 13;
            this.ModifyMovie.Text = "Modyfikuj opis filmu";
            this.ModifyMovie.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 404);
            this.Controls.Add(this.ModifyMovie);
            this.Controls.Add(this.AddMovie);
            this.Controls.Add(this.DeleteMovie);
            this.Controls.Add(this.ModifyClient);
            this.Controls.Add(this.DeleteClient);
            this.Controls.Add(this.AddClient);
            this.Controls.Add(this.SortingDirection);
            this.Controls.Add(this.SortingType);
            this.Controls.Add(this.ShowMovies);
            this.Controls.Add(this.ShowClients);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DebugLabel);
            this.Controls.Add(this.Close);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.SortingType.ResumeLayout(false);
            this.SortingType.PerformLayout();
            this.SortingDirection.ResumeLayout(false);
            this.SortingDirection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label DebugLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ShowClients;
        private System.Windows.Forms.Button ShowMovies;
        private System.Windows.Forms.GroupBox SortingType;
        private System.Windows.Forms.RadioButton ByName;
        private System.Windows.Forms.RadioButton ById;
        private System.Windows.Forms.RadioButton ByDateAdded;
        private System.Windows.Forms.GroupBox SortingDirection;
        private System.Windows.Forms.RadioButton Descending;
        private System.Windows.Forms.RadioButton Ascending;
        private System.Windows.Forms.Button AddClient;
        private System.Windows.Forms.Button DeleteClient;
        private System.Windows.Forms.Button ModifyClient;
        private System.Windows.Forms.Button DeleteMovie;
        private System.Windows.Forms.Button AddMovie;
        private System.Windows.Forms.Button ModifyMovie;
    }
}

