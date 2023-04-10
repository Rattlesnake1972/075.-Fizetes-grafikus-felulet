using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fizetes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hát elég nagy hülye vagy!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Akkor megemelem 100 ezerrel.";
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            // label1.Text = "Minek piszkálod?"

            Random r = new Random();
            int x = r.Next(1,this.Width-button2.Width);
            int y = r.Next(1, this.Height-button2.Height);
            button2.SetBounds(x,y,button2.Width, button2.Height);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
