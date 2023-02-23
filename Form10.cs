using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_aplicación
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var formulario = new Form4();
            formulario.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var formulario = new Form7();
            formulario.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formulario = new Form6();
            formulario.Show();
            this.Hide();
        }
    }
}
