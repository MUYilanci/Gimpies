using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int attempts = 3;

        public Form1()
        {
            InitializeComponent();
        }
       
        private void Login_buton(object sender, EventArgs e)
        {
            string password = Wachtwoord.Text;

            if (password == "gimpies")
            {
                this.Hide();
                MessageBox.Show("Welcome " + Gebruikersnaam.Text + "!");
                Menu menu = new Menu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("U Heeft Nog " + attempts + " Pogingen Over!");
                attempts--;
            }
            if (attempts == -1)
            {
                MessageBox.Show("U heeft al uw pogingen gebruikt! Probeer het later nog eens!");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }   
    }
}
