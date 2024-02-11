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
            this.BorrowMovie = new System.Windows.Forms.Button();
            this.ShowBorrowings = new System.Windows.Forms.Button();
            this.ReturnMovieButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SortingType.SuspendLayout();
            this.SortingDirection.SuspendLayout();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(1151, 455);
            this.Close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1015, 476);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // ShowClients
            // 
            this.ShowClients.Location = new System.Drawing.Point(1151, 404);
            this.ShowClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.ShowMovies.Location = new System.Drawing.Point(1151, 352);
            this.ShowMovies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowMovies.Name = "ShowMovies";
            this.ShowMovies.Size = new System.Drawing.Size(91, 46);
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
            this.SortingType.Location = new System.Drawing.Point(1033, 28);
            this.SortingType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SortingType.Name = "SortingType";
            this.SortingType.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SortingType.Size = new System.Drawing.Size(163, 100);
            this.SortingType.TabIndex = 6;
            this.SortingType.TabStop = false;
            this.SortingType.Text = "Sortowanie";
            // 
            // ByDateAdded
            // 
            this.ByDateAdded.AutoSize = true;
            this.ByDateAdded.Location = new System.Drawing.Point(0, 74);
            this.ByDateAdded.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ByDateAdded.Name = "ByDateAdded";
            this.ByDateAdded.Size = new System.Drawing.Size(139, 20);
            this.ByDateAdded.TabIndex = 2;
            this.ByDateAdded.TabStop = true;
            this.ByDateAdded.Text = "Po Dacie Dodania";
            this.ByDateAdded.UseVisualStyleBackColor = true;
            this.ByDateAdded.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ByDateAdded_MouseClick);
            // 
            // ById
            // 
            this.ById.Checked = true;
            this.ById.Location = new System.Drawing.Point(0, 44);
            this.ById.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ById.Name = "ById";
            this.ById.Size = new System.Drawing.Size(104, 25);
            this.ById.TabIndex = 1;
            this.ById.TabStop = true;
            this.ById.Text = "Po Id";
            this.ById.UseVisualStyleBackColor = true;
            this.ById.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ById_MouseClick);
            // 
            // ByName
            // 
            this.ByName.AutoSize = true;
            this.ByName.Location = new System.Drawing.Point(0, 21);
            this.ByName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ByName.Name = "ByName";
            this.ByName.Size = new System.Drawing.Size(92, 20);
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
            this.SortingDirection.Location = new System.Drawing.Point(1035, 135);
            this.SortingDirection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SortingDirection.Name = "SortingDirection";
            this.SortingDirection.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SortingDirection.Size = new System.Drawing.Size(91, 74);
            this.SortingDirection.TabIndex = 7;
            this.SortingDirection.TabStop = false;
            this.SortingDirection.Text = "Kolejność";
            // 
            // Descending
            // 
            this.Descending.AutoSize = true;
            this.Descending.Location = new System.Drawing.Point(7, 49);
            this.Descending.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Descending.Name = "Descending";
            this.Descending.Size = new System.Drawing.Size(84, 20);
            this.Descending.TabIndex = 1;
            this.Descending.Text = "Malejąco";
            this.Descending.UseVisualStyleBackColor = true;
            // 
            // Ascending
            // 
            this.Ascending.AutoSize = true;
            this.Ascending.Checked = true;
            this.Ascending.Location = new System.Drawing.Point(7, 22);
            this.Ascending.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ascending.Name = "Ascending";
            this.Ascending.Size = new System.Drawing.Size(83, 20);
            this.Ascending.TabIndex = 0;
            this.Ascending.TabStop = true;
            this.Ascending.Text = "Rosnąco";
            this.Ascending.UseVisualStyleBackColor = true;
            // 
            // AddClient
            // 
            this.AddClient.Enabled = false;
            this.AddClient.Location = new System.Drawing.Point(1041, 439);
            this.AddClient.Margin = new System.Windows.Forms.Padding(4);
            this.AddClient.Name = "AddClient";
            this.AddClient.Size = new System.Drawing.Size(100, 48);
            this.AddClient.TabIndex = 8;
            this.AddClient.Text = "Dodaj klienta";
            this.AddClient.UseVisualStyleBackColor = true;
            this.AddClient.Click += new System.EventHandler(this.AddClient_Click);
            // 
            // DeleteClient
            // 
            this.DeleteClient.Enabled = false;
            this.DeleteClient.Location = new System.Drawing.Point(1041, 385);
            this.DeleteClient.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteClient.Name = "DeleteClient";
            this.DeleteClient.Size = new System.Drawing.Size(100, 47);
            this.DeleteClient.TabIndex = 9;
            this.DeleteClient.Text = "Usuń klienta";
            this.DeleteClient.UseVisualStyleBackColor = true;
            this.DeleteClient.Click += new System.EventHandler(this.DeleteClient_Click);
            // 
            // ModifyClient
            // 
            this.ModifyClient.Enabled = false;
            this.ModifyClient.Location = new System.Drawing.Point(1041, 314);
            this.ModifyClient.Margin = new System.Windows.Forms.Padding(4);
            this.ModifyClient.Name = "ModifyClient";
            this.ModifyClient.Size = new System.Drawing.Size(100, 66);
            this.ModifyClient.TabIndex = 10;
            this.ModifyClient.Text = "Modyfikuj dane klienta";
            this.ModifyClient.UseVisualStyleBackColor = true;
            this.ModifyClient.Click += new System.EventHandler(this.ModifyClient_Click);
            // 
            // DeleteMovie
            // 
            this.DeleteMovie.Location = new System.Drawing.Point(1149, 314);
            this.DeleteMovie.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteMovie.Name = "DeleteMovie";
            this.DeleteMovie.Size = new System.Drawing.Size(91, 32);
            this.DeleteMovie.TabIndex = 11;
            this.DeleteMovie.Text = "Usuń film";
            this.DeleteMovie.UseVisualStyleBackColor = true;
            this.DeleteMovie.Click += new System.EventHandler(this.DeleteMovie_Click);
            // 
            // AddMovie
            // 
            this.AddMovie.Location = new System.Drawing.Point(1149, 260);
            this.AddMovie.Margin = new System.Windows.Forms.Padding(4);
            this.AddMovie.Name = "AddMovie";
            this.AddMovie.Size = new System.Drawing.Size(89, 47);
            this.AddMovie.TabIndex = 12;
            this.AddMovie.Text = "Dodaj film";
            this.AddMovie.UseVisualStyleBackColor = true;
            this.AddMovie.Click += new System.EventHandler(this.AddMovie_Click);
            // 
            // ModifyMovie
            // 
            this.ModifyMovie.Location = new System.Drawing.Point(1041, 260);
            this.ModifyMovie.Margin = new System.Windows.Forms.Padding(4);
            this.ModifyMovie.Name = "ModifyMovie";
            this.ModifyMovie.Size = new System.Drawing.Size(100, 47);
            this.ModifyMovie.TabIndex = 13;
            this.ModifyMovie.Text = "Modyfikuj opis filmu";
            this.ModifyMovie.UseVisualStyleBackColor = true;
            this.ModifyMovie.Click += new System.EventHandler(this.ModifyMovie_Click);
            // 
            // BorrowMovie
            // 
            this.BorrowMovie.Location = new System.Drawing.Point(1151, 209);
            this.BorrowMovie.Name = "BorrowMovie";
            this.BorrowMovie.Size = new System.Drawing.Size(86, 44);
            this.BorrowMovie.TabIndex = 14;
            this.BorrowMovie.Text = "Wypożycz film";
            this.BorrowMovie.UseVisualStyleBackColor = true;
            this.BorrowMovie.Click += new System.EventHandler(this.BorrowMovie_Click);
            // 
            // ShowBorrowings
            // 
            this.ShowBorrowings.Location = new System.Drawing.Point(1042, 209);
            this.ShowBorrowings.Name = "ShowBorrowings";
            this.ShowBorrowings.Size = new System.Drawing.Size(99, 43);
            this.ShowBorrowings.TabIndex = 15;
            this.ShowBorrowings.Text = "Pokaż wypożyczenia";
            this.ShowBorrowings.UseVisualStyleBackColor = true;
            this.ShowBorrowings.Click += new System.EventHandler(this.ShowBorrowings_Click);
            // 
            // ReturnMovieButton
            // 
            this.ReturnMovieButton.Enabled = false;
            this.ReturnMovieButton.Location = new System.Drawing.Point(1151, 157);
            this.ReturnMovieButton.Name = "ReturnMovieButton";
            this.ReturnMovieButton.Size = new System.Drawing.Size(86, 46);
            this.ReturnMovieButton.TabIndex = 16;
            this.ReturnMovieButton.Text = "Zwróć film";
            this.ReturnMovieButton.UseVisualStyleBackColor = true;
            this.ReturnMovieButton.Click += new System.EventHandler(this.ReturnMovieButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 497);
            this.Controls.Add(this.ReturnMovieButton);
            this.Controls.Add(this.ShowBorrowings);
            this.Controls.Add(this.BorrowMovie);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button BorrowMovie;
        private System.Windows.Forms.Button ShowBorrowings;
        private System.Windows.Forms.Button ReturnMovieButton;
    }
}

