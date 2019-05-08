using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocio;
namespace CapaPresentacion
{
    public partial class Form1 : Form
    {

        
        ManttVendor enlc = new ManttVendor();

        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(enlc.prueba());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            enlc.CodVendor = textBox1.Text;
            enlc.NombreVendor = textBox2.Text;
            enlc.insertVendor();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            enlc.CodVendor = textBox1.Text;
            enlc.NombreVendor = textBox2.Text;
            enlc.updateVendor();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            enlc.CodVendor = textBox1.Text;
            enlc.NombreVendor = textBox2.Text;
            enlc.deleteVendor();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
