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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void Verkoop_Click(object sender, EventArgs e)
        {
            this.Hide();
            Verkoop registreren = new Verkoop();
            registreren.Show(); 
        }
        private void Bekijken_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bekijken bekijken = new Bekijken();
            bekijken.Show();
        }
        private void Wijzigen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Wijzigen wijzigen = new Wijzigen();
            wijzigen.Show();
        }
        private void Uitloggen_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 inlog = new Form1();
            inlog.Show();
        }
        private void afsluiten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
