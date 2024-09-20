using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int nbA, nbB;
        public int LeMax(int leNombre1, int leNombre2)
        {
            if (leNombre1 > leNombre2) return leNombre1;
            return leNombre2;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculer(object sender, EventArgs e)
        {
            nbA = Convert.ToInt32(txtNombreA.Text);
            nbB = Convert.ToInt32(txtNombreB.Text);
            textBox3.Text = Convert.ToString(LeMax(nbA, nbB));
        }
    }
}
