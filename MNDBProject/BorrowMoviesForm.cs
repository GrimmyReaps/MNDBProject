using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MNDBProject
{
    public partial class BorrowMoviesForm : Form
    {
        private int RowIdx;
        public string ClientName;
        public string ClientSurname;
        public bool ConfirmBorrow = false;
        public string Title;
        public BorrowMoviesForm()
        {
            InitializeComponent();
        }

        public void Populate(List<Clients> data)
        {
            //Show Data
            dataGridView1.DataSource = data;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            MovieInfo.Text += Title;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowIdx = e.RowIndex;
        }

        private void BorrowButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy to właściwy klient:\n" + dataGridView1.Rows[RowIdx].Cells[1].Value.ToString() + " " + dataGridView1.Rows[RowIdx].Cells[2].Value.ToString(),
                "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                ClientName = dataGridView1.Rows[RowIdx].Cells[1].Value.ToString();
                ClientSurname = dataGridView1.Rows[RowIdx].Cells[2].Value.ToString();

                ConfirmBorrow = true;
                Hide();
            }
        }
    }
}
