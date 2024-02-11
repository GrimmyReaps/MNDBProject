using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System.Text.RegularExpressions;

namespace MNDBProject
{
    public partial class Form1 : Form
    {
        //Connect to Atlas
        readonly MongoClient dbClient = new MongoClient("mongodb://localhost:27017");

        int RowIdx;

        public Form1()
        {
            //Enter the Database 
            var mongoDatabase = dbClient.GetDatabase("Wypozyczalnia");
            //Choose the Collection
            var mongoCollection = mongoDatabase.GetCollection<Movies>(Movies.MoviesDBName);
            //var document = mongoCollection.Find(new BsonDocument()).FirstOrDefault();
            //Find all Movies
            var filter = Builders<Movies>.Filter.Empty;
            var MoviesFound = mongoCollection.Find(filter).ToList();

            InitializeComponent();

            DebugLabel.Enabled = false;
            DebugLabel.Visible = false;

            dataGridView1.ReadOnly = true;

            // Concatenate array elements into a single string for display
            var moviesForDisplay = MoviesFound.Select(movie => new
            {
                movie.Id,
                movie.Tytul,
                Gatunek = string.Join(", ", movie.Gatunek),
                movie.Rezyser,
                movie.CzasTrwania,
                movie.Ocena,
                movie.Opis,
                Aktorzy = string.Join(", ", movie.Aktorzy),
                movie.DataDodania
            }).ToList();

            //Show Data
            dataGridView1.DataSource = moviesForDisplay;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            //label1.Text = document.Aktorzy[0] + ", " + document.Aktorzy[1] + ", " + document.Aktorzy[2];
            //var dbList = dbClient.ListDatabases().ToList();

            //Console.WriteLine("The list of databases on this server is: ");
            //foreach (var db in dbList)
            //{
            //    Console.WriteLine(db);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //DebugLabel.Visible = true;
            DebugLabel.Text = dataGridView1.CurrentCell.RowIndex.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Clear the GridView
            ClearGView();

            //Like in setup
            var mongoDatabase = dbClient.GetDatabase("Wypozyczalnia");
            var mongoCollection = mongoDatabase.GetCollection<Clients>(Clients.ClientsDBName);
            var filter = Builders<Clients>.Filter.Empty;
            var ClientsFound = mongoCollection.Find(filter).ToList();

            //Show Data
            dataGridView1.DataSource = ClientsFound;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            ShowClients.Enabled = false;
            ShowMovies.Enabled = true;
            SortingType.Enabled = false;
            SortingDirection.Enabled = false;
            AddClient.Enabled = true;
            DeleteClient.Enabled = true;
            ModifyClient.Enabled = true;
            AddMovie.Enabled = false;
            ModifyMovie.Enabled = false;
            DeleteMovie.Enabled = false;
        }

        private void ShowMovies_Click(object sender, EventArgs e)
        {
            //Clear the GridView
            ClearGView();

            //Like in setup
            var mongoDatabase = dbClient.GetDatabase("Wypozyczalnia");
            var mongoCollection = mongoDatabase.GetCollection<Movies>(Movies.MoviesDBName);
            var filter = Builders<Movies>.Filter.Empty;
            var MoviesFound = mongoCollection.Find(filter).ToList();

            // Concatenate array elements into a single string for display
            var moviesForDisplay = MoviesFound.Select(movie => new
            {
                movie.Id,
                movie.Tytul,
                Gatunek = string.Join(", ", movie.Gatunek),
                movie.Rezyser,
                movie.CzasTrwania,
                movie.Ocena,
                movie.Opis,
                Aktorzy = string.Join(", ", movie.Aktorzy),
                movie.DataDodania
            }).ToList();

            //Show Data
            dataGridView1.DataSource = moviesForDisplay;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            ShowClients.Enabled = true;
            ShowMovies.Enabled = false;
            SortingType.Enabled = true;
            SortingDirection.Enabled = true;
            AddClient.Enabled = false;
            DeleteClient.Enabled = false;
            ModifyClient.Enabled = false;
            AddMovie.Enabled = true;
            ModifyMovie.Enabled = true;
            DeleteMovie.Enabled = true;
        }

        private void ByDateAdded_MouseClick(object sender, MouseEventArgs e)
        {
            //Clear the GridView
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            //Like in setup
            var mongoDatabase = dbClient.GetDatabase("Wypozyczalnia");
            var mongoCollection = mongoDatabase.GetCollection<Movies>(Movies.MoviesDBName);

            if (Ascending.Checked == true)
            {
                var sortFilter = Builders<Movies>.Sort.Ascending(f => f.DataDodania);
                var matchFilter = Builders<Movies>.Filter.Empty;
                var pipeline = new EmptyPipelineDefinition<Movies>().Match(matchFilter).Sort(sortFilter);
                var MoviesFound = mongoCollection.Aggregate(pipeline).ToList();

                //Console.WriteLine(MoviesFound);

                //Show Data
                dataGridView1.DataSource = MoviesFound;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
            else if (Descending.Checked == true)
            {
                var sortFilter = Builders<Movies>.Sort.Descending(f => f.DataDodania);
                var matchFilter = Builders<Movies>.Filter.Empty;
                var pipeline = new EmptyPipelineDefinition<Movies>().Match(matchFilter).Sort(sortFilter);
                var MoviesFound = mongoCollection.Aggregate(pipeline).ToList();

                //Console.WriteLine(MoviesFound);

                //Show Data
                dataGridView1.DataSource = MoviesFound;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
        }

        private void ById_MouseClick(object sender, MouseEventArgs e)
        {
            //Clear the GridView
            ClearGView();

            //Like in setup
            var mongoDatabase = dbClient.GetDatabase("Wypozyczalnia");
            var mongoCollection = mongoDatabase.GetCollection<Movies>(Movies.MoviesDBName);

            if (Ascending.Checked == true)
            {
                var sortFilter = Builders<Movies>.Sort.Ascending(f => f.Id);
                var matchFilter = Builders<Movies>.Filter.Empty;
                var pipeline = new EmptyPipelineDefinition<Movies>().Match(matchFilter).Sort(sortFilter);
                var MoviesFound = mongoCollection.Aggregate(pipeline).ToList();

                //Console.WriteLine(MoviesFound);

                //Show Data
                dataGridView1.DataSource = MoviesFound;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
            else if (Descending.Checked == true)
            {
                var sortFilter = Builders<Movies>.Sort.Descending(f => f.Id);
                var matchFilter = Builders<Movies>.Filter.Empty;
                var pipeline = new EmptyPipelineDefinition<Movies>().Match(matchFilter).Sort(sortFilter);
                var MoviesFound = mongoCollection.Aggregate(pipeline).ToList();

                //Console.WriteLine(MoviesFound);

                //Show Data
                dataGridView1.DataSource = MoviesFound;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
        }

        private void ByName_MouseClick(object sender, MouseEventArgs e)
        {
            //Clear the GridView
            ClearGView();

            //Like in setup
            var mongoDatabase = dbClient.GetDatabase("Wypozyczalnia");
            var mongoCollection = mongoDatabase.GetCollection<Movies>(Movies.MoviesDBName);

            if (Ascending.Checked == true)
            {
                var sortFilter = Builders<Movies>.Sort.Ascending(f => f.Tytul);
                var matchFilter = Builders<Movies>.Filter.Empty;
                var pipeline = new EmptyPipelineDefinition<Movies>().Match(matchFilter).Sort(sortFilter);
                var MoviesFound = mongoCollection.Aggregate(pipeline).ToList();

                //Console.WriteLine(MoviesFound);

                //Show Data
                dataGridView1.DataSource = MoviesFound;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
            else if (Descending.Checked == true)
            {
                var sortFilter = Builders<Movies>.Sort.Descending(f => f.Tytul);
                var matchFilter = Builders<Movies>.Filter.Empty;
                var pipeline = new EmptyPipelineDefinition<Movies>().Match(matchFilter).Sort(sortFilter);
                var MoviesFound = mongoCollection.Aggregate(pipeline).ToList();

                //Console.WriteLine(MoviesFound);

                //Show Data
                dataGridView1.DataSource = MoviesFound;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
        }

        public void ClearGView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
        }

        private void AddMovie_Click(object sender, EventArgs e)
        {
            Form2 addMovieForm = new Form2();
            addMovieForm.OK.Enabled = true;
            addMovieForm.OK.Visible = true;
            addMovieForm.ShowDialog(this);

            if (addMovieForm.safety)
            {
                //Enter the Database 
                var mongoDatabase = dbClient.GetDatabase("Wypozyczalnia");
                //Choose the Collection
                var mongoCollection = mongoDatabase.GetCollection<Movies>(Movies.MoviesDBName);
                int documentsAmount = (int)mongoCollection.CountDocuments(Builders<Movies>.Filter.Empty);

                Movies movie = new Movies
                {
                    Id = documentsAmount + 1,
                    Tytul = addMovieForm.title,
                    Rezyser = addMovieForm.director,
                    Opis = addMovieForm.description,
                    Ocena = addMovieForm.graded,
                    CzasTrwania = addMovieForm.movieLength,
                    Gatunek = addMovieForm.genres,
                    Aktorzy = addMovieForm.actors,
                    DataDodania = DateTime.Now
                };

                mongoCollection.InsertOne(movie);

                addMovieForm.Close();

                var filter = Builders<Movies>.Filter.Empty;
                var MoviesFound = mongoCollection.Find(filter).ToList();

                var moviesForDisplay = MoviesFound.Select(show => new
                {
                    show.Id,
                    show.Tytul,
                    Gatunek = string.Join(", ", show.Gatunek),
                    show.Rezyser,
                    show.CzasTrwania,
                    show.Ocena,
                    show.Opis,
                    Aktorzy = string.Join(", ", show.Aktorzy),
                    show.DataDodania
                }).ToList();

                //Clear Data from DataGridView
                ClearGView();
                //Show Data
                dataGridView1.DataSource = moviesForDisplay;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
        }

        private void ModifyMovie_Click(object sender, EventArgs e)
        {
            Form2 updateMovieForm = new Form2();
            updateMovieForm.Update.Enabled = true;
            updateMovieForm.Update.Visible = true;
            updateMovieForm.titleUpdate = dataGridView1.Rows[RowIdx].Cells[1].Value.ToString();
            updateMovieForm.genresUpdate = dataGridView1.Rows[RowIdx].Cells[2].Value.ToString();
            updateMovieForm.directorUpdate = dataGridView1.Rows[RowIdx].Cells[3].Value.ToString();
            updateMovieForm.movieLengthUpdate = dataGridView1.Rows[RowIdx].Cells[4].Value.ToString();
            updateMovieForm.gradeUpdate = dataGridView1.Rows[RowIdx].Cells[5].Value.ToString();
            updateMovieForm.descriptionUpdate = dataGridView1.Rows[RowIdx].Cells[6].Value.ToString();
            updateMovieForm.actorsUpdate = dataGridView1.Rows[RowIdx].Cells[7].Value.ToString();
            updateMovieForm.Populate();
            updateMovieForm.ShowDialog(this);

            if (updateMovieForm.safety)
            {
                //Enter the Database 
                var mongoDatabase = dbClient.GetDatabase("Wypozyczalnia");
                //Choose the Collection
                var mongoCollection = mongoDatabase.GetCollection<Movies>(Movies.MoviesDBName);
                int documentsAmount = (int)mongoCollection.CountDocuments(Builders<Movies>.Filter.Empty);

                var movieUpdate = Builders<Movies>.Update.Set(
                    movies => movies.Tytul, updateMovieForm.title).Set(
                    movies => movies.Rezyser, updateMovieForm.director).Set(
                    movies => movies.Opis, updateMovieForm.description).Set(
                    movies => movies.Ocena, updateMovieForm.graded).Set(
                    movies => movies.CzasTrwania, updateMovieForm.movieLength).Set(
                    movies => movies.Gatunek, updateMovieForm.genres).Set(
                    movies => movies.Aktorzy, updateMovieForm.actors);

                var UpdateFilter = Builders<Movies>.Filter.Eq(movies => movies.Tytul, updateMovieForm.titleUpdate);
                 //Update in DB
                mongoCollection.UpdateOne(UpdateFilter ,movieUpdate);

                updateMovieForm.Close();


                //Refreshing the DataGridView
                var filter = Builders<Movies>.Filter.Empty;
                var MoviesFound = mongoCollection.Find(filter).ToList();

                var moviesForDisplay = MoviesFound.Select(show => new
                {
                    show.Id,
                    show.Tytul,
                    Gatunek = string.Join(", ", show.Gatunek),
                    show.Rezyser,
                    show.CzasTrwania,
                    show.Ocena,
                    show.Opis,
                    Aktorzy = string.Join(", ", show.Aktorzy),
                    show.DataDodania
                }).ToList();

                //Clear Data from DataGridView
                ClearGView();
                //Show Data
                dataGridView1.DataSource = moviesForDisplay;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RowIdx = e.RowIndex;
        }

        private void DeleteMovie_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy chcesz usunąć " + dataGridView1.Rows[RowIdx].Cells[1].Value.ToString(), "Potwierdź", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Enter the Database 
                var mongoDatabase = dbClient.GetDatabase("Wypozyczalnia");
                //Choose the Collection
                var mongoCollection = mongoDatabase.GetCollection<Movies>(Movies.MoviesDBName);
                var deleteFilter = Builders<Movies>.Filter.Eq(movies => movies.Tytul, dataGridView1.Rows[RowIdx].Cells[1].Value.ToString());
                mongoCollection.DeleteOne(deleteFilter);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowIdx = e.RowIndex;
        }
    }

    public class Movies
    {
        public static readonly string MoviesDBName = "Filmy";

        public int Id { get; set; }

        [BsonElement("tytul")]
        public string Tytul { get; set; }

        [BsonElement("gatunek")]
        public string[] Gatunek { get; set; }

        [BsonElement("rezyser")]
        public string Rezyser { get; set; }

        [BsonElement("czasTrwania")]
        public int CzasTrwania { get; set; }

        [BsonElement("ocena")]
        public double Ocena { get; set; }

        [BsonElement("opis")]
        public string Opis { get; set; }

        [BsonElement("aktorzy")]
        public string[] Aktorzy { get; set; }

        [BsonElement("dataDodania")]
        public DateTime DataDodania { get; set; }
    }

    public class Clients
    {
        public static readonly string ClientsDBName = "Klienci";
        public ObjectId Id { get; set; }

        [BsonElement("imie")]
        public string Imie { get; set; }

        [BsonElement("nazwisko")]
        public string Nazwisko { get; set; }

        [BsonElement("adres")]
        public string Adres { get; set; }

        [BsonElement("telefon")]
        public string Telefon { get; set; }

        [BsonElement("dataRejestracji")]
        public DateTime DataRejestracji { get; set; }
    }
}