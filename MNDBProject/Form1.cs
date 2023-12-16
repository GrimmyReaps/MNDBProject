using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;

namespace MNDBProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MongoClient dbClient = new MongoClient("mongodb://localhost:27017");

            var dbList = dbClient.ListDatabases().ToList();

            Console.WriteLine("The list of databases on this server is: ");
            foreach (var db in dbList)
            {
                Console.WriteLine(db);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
