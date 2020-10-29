using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libreriaGradosaFarenheit;
namespace convertidor
{
    public partial class conver : UserControl
    {
        public conver()
        {
            InitializeComponent();
        }
        double uno;
        double dos;

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                uno = double.Parse(textBox1.Text);
                double c = opera.gradoscaf(uno);
                textBox2.Text = c.ToString();


            }



            if (radioButton2.Checked)
            {


                dos = double.Parse(textBox2.Text);
                double tres = opera.gradosfac(dos);
                textBox1.Text = tres.ToString();


            }
        }
    }
}
