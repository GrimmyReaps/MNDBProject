using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MNDBProject
{
    public partial class ClientForm : Form
    {

        public string NewClientName;
        public string NewClientSurname;
        public string NewClientPhoneNumber;
        public string NewClientAddress;
        public bool ClientSafety;
        public string OldClientName;
        public string OldClientSurname;
        public string OldClientPhoneNumber;
        public string OldClientAddress;
        private string AddressPattern = @"^[AaĄąBbCcĆćDdEeĘęFfGgHhIiJjKkLlŁłMmNnŃńOoÓóPpRrSsŚśTtUuWwYyZzŹźŻż0-9\s]+\s\d+\,\s[AaĄąBbCcĆćDdEeĘęFfGgHhIiJjKkLlŁłMmNnŃńOoÓóPpRrSsŚśTtUuWwYyZzŹźŻż\s]{1,}$|^[AaĄąBbCcĆćDdEeĘęFfGgHhIiJjKkLlŁłMmNnŃńOoÓóPpRrSsŚśTtUuWwYyZzŹźŻż0-9\s]+\s\d+\/\d+\,\s[AaĄąBbCcĆćDdEeĘęFfGgHhIiJjKkLlŁłMmNnŃńOoÓóPpRrSsŚśTtUuWwYyZzŹźŻż\s]{1,}$";
        private string PhonePattern = @"\+\d{11}";
        public ClientForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NameTextBox.Text.ToString()) ||
                String.IsNullOrEmpty(SurnameTextBox.Text.ToString()) ||
                String.IsNullOrEmpty(PhoneNumberTextBox.Text.ToString()) ||
                String.IsNullOrEmpty(AddressTextBox.Text.ToString()))
            {
                MessageBox.Show("Pola nie mogą być puste!", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(!Regex.Match(AddressTextBox.Text.ToString(), AddressPattern).Success)
            {
                MessageBox.Show("Przykładowy sposób wpisania adresu: \nKatowicka 51, Zambrów", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(!Regex.Match(PhoneNumberTextBox.Text.ToString(), PhonePattern).Success)
            {
                MessageBox.Show("Numer telefonu zaczyna się z \"+\" i posiada 11 cyfr", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Czy jesteś pewien?", "Potwierdź", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                NewClientName = NameTextBox.Text.ToString();
                NewClientSurname = SurnameTextBox.Text.ToString();
                NewClientAddress = AddressTextBox.Text.ToString();
                NewClientPhoneNumber = PhoneNumberTextBox.Text.ToString();

                ClientSafety = true;
                Hide();
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('+') && String.IsNullOrEmpty(PhoneNumberTextBox.Text.ToString())) return;
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NameTextBox.Text.ToString()) ||
                String.IsNullOrEmpty(SurnameTextBox.Text.ToString()) ||
                String.IsNullOrEmpty(PhoneNumberTextBox.Text.ToString()) ||
                String.IsNullOrEmpty(AddressTextBox.Text.ToString()))
            {
                MessageBox.Show("Pola nie mogą być puste!", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.Match(AddressTextBox.Text.ToString(), AddressPattern).Success)
            {
                MessageBox.Show("Przykładowy sposób wpisania adresu: \nKatowicka 51, Zambrów", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.Match(PhoneNumberTextBox.Text.ToString(), PhonePattern).Success)
            {
                MessageBox.Show("Numer telefonu zaczyna się z \"+\" i posiada 11 cyfr", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Czy jesteś pewien?", "Potwierdź", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (OldClientName.Equals(NameTextBox.Text.ToString()) &&
                    OldClientSurname.Equals(SurnameTextBox.Text.ToString()) &&
                    OldClientAddress.Equals(AddressTextBox.Text.ToString()) &&
                    OldClientPhoneNumber.Equals(PhoneNumberTextBox.Text.ToString()))
                {
                    Close();
                } else {
                    NewClientName = NameTextBox.Text.ToString();
                    NewClientSurname = SurnameTextBox.Text.ToString();
                    NewClientAddress = AddressTextBox.Text.ToString();
                    NewClientPhoneNumber = PhoneNumberTextBox.Text.ToString();

                    ClientSafety = true;
                    Hide();
                }
            }
        }

        public void Populate()
        {
            NameTextBox.Text = OldClientName;
            SurnameTextBox.Text = OldClientSurname;
            PhoneNumberTextBox.Text = OldClientPhoneNumber;
            AddressTextBox.Text = OldClientAddress;
        }
    }
}
