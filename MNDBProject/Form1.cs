using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace MNDBProject
{
    public partial class Form1 : Form
    {
        MongoClient dbClient = null;
        public Form1()
        {
            dbClient = new MongoClient("mongodb://localhost:27017");
            var mongoDatabase = dbClient.GetDatabase("Wypozyczalnia");
            var mongoCollection = mongoDatabase.GetCollection<Movies>(Movies.MoviesDBName);
            //var document = mongoCollection.Find(new BsonDocument()).FirstOrDefault();
            var filter = Builders<Movies>.Filter.Empty;
            var MoviesFound = mongoCollection.Find(filter).ToList();

            InitializeComponent();

            label1.Enabled = false;
            label1.Visible = false;

            dataGridView1.ReadOnly = true;

            dataGridView1.DataSource = MoviesFound;

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
            label1.Visible = true;
            label1.Text = dataGridView1.CurrentCell.RowIndex.ToString();
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
}
