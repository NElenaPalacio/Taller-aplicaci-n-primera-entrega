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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var formulario = new Form5();
            formulario.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var formulario = new Form2();
            formulario.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            var formulario = new Form14();
            formulario.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var formulario = new Form1();
            formulario.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var formulario = new Form8();
            formulario.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var formulario = new Form10();
            formulario.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var formulario = new Form11();
            formulario.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formulario = new Form11();
            formulario.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var formulario = new Form13();
            formulario.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var formulario = new Form12();
            formulario.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var formulario = new Form12();
            formulario.Show();
            this.Hide();
        }
    }
}
