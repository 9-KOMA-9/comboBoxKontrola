using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox_kontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ispis_TextChanged(object sender, EventArgs e)
        {

        }

        private void izbornik_SelectedIndexChanged(object sender, EventArgs e)
        {
            string odabranaStavka = izbornik.SelectedItem.ToString();
            ispis.Text = odabranaStavka;


        }
    }
}
