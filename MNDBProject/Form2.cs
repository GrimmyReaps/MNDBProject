using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MNDBProject
{
    public partial class Form2 : Form
    {
        //Readable info
        public string title;
        public string director;
        public string description;
        public int movieLength;
        public double graded;
        public string[] genres;
        public string[] actors;

        public Form2()
        {
            InitializeComponent();

        }

        private void lengthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            String Grade = gradeTextBox.Text;
            String patternGrade = @"^[0-9]\.[0-9]$|^[0-9]{1,2}$";
            //Fields cannot be empty XD
            if (String.IsNullOrEmpty(movieTitleTextBox.Text.ToString()) ||
                String.IsNullOrEmpty(directorTextBox.Text.ToString()) ||
                String.IsNullOrEmpty(descriptionTextBox.Text.ToString()) ||
                String.IsNullOrEmpty(gradeTextBox.Text.ToString()) ||
                String.IsNullOrEmpty(lengthTextBox.Text.ToString()) ||
                String.IsNullOrEmpty(genreTextBox.Text.ToString()) ||
                String.IsNullOrEmpty(actorsTextBox.Text.ToString()))
            {
                MessageBox.Show("Pola nie mogą być puste!", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //The only check needed here XD
            if (!Regex.Match(Grade, patternGrade).Success)
            {
                MessageBox.Show("Niepoprawnie wpisana ocena", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (Double.Parse(Grade) > 10)
                {
                    MessageBox.Show("Maksymalna ocena to 10", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            //To keep public fields clear I'd rather do it at the end
            title = movieTitleTextBox.Text.ToString().Trim();
            director = directorTextBox.Text.ToString().Trim();
            description = descriptionTextBox.Text.ToString().Trim();
            graded = Double.Parse(Grade);
            movieLength = Int32.Parse(lengthTextBox.Text.ToString().Trim());
            genres = genreTextBox.Text.ToString().Trim().Split(',');
            for (int i = 0; i < genres.Length; i++)
                genres[i].Trim();
            actors = actorsTextBox.Text.ToString().Trim().Split(',');
            for (int i = 0; i < actors.Length; i++)
                actors[i].Trim();

            DialogResult result = MessageBox.Show("Czy jesteś pewien?", "Potwierdź", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Hide();
            }
            
        }
    }
}
