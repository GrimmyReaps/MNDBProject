﻿using System;
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

namespace MNDBProject
{
    public partial class Form1 : Form
    {
        //Connect to Atlas
        readonly MongoClient dbClient = new MongoClient("mongodb://localhost:27017");

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

            //Show Data
            dataGridView1.DataSource = MoviesFound;
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
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

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
        }

        private void ShowMovies_Click(object sender, EventArgs e)
        {
            //Clear the GridView
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            //Like in setup
            var mongoDatabase = dbClient.GetDatabase("Wypozyczalnia");
            var mongoCollection = mongoDatabase.GetCollection<Movies>(Movies.MoviesDBName);
            var filter = Builders<Movies>.Filter.Empty;
            var MoviesFound = mongoCollection.Find(filter).ToList();

            //Show Data
            dataGridView1.DataSource = MoviesFound;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            ShowClients.Enabled = true;
            ShowMovies.Enabled = false;
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
