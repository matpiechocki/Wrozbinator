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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void dzien_TextChanged(object sender, EventArgs e)
        {

        }

        private void miesiac_TextChanged(object sender, EventArgs e)
        {

        }

        Zodiak liczba = new Zodiak();
        

        private void btnPodaj_Click(object sender, EventArgs e)
        {
            poleLiczba.Text = liczba.Podajliczbe(int.Parse(dzien.Text), int.Parse(miesiac.Text)).ToString();

            poleZodiak.Text = liczba.Twojzodiak(int.Parse(dzien.Text), int.Parse(miesiac.Text));

            polePOL.Text = liczba.Twojwiek(int.Parse(dzien.Text), int.Parse(miesiac.Text)).ToString();
        }

        private void poleZodiak_Click(object sender, EventArgs e)
        {

        }

        private void poleLiczba_Click(object sender, EventArgs e)
        {

        }

        private void polePOL_Click(object sender, EventArgs e)
        {

        }
    }
}
