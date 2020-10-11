using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonRuntime
{
    public partial class Form1 : Form
    {
        int i = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (i < 10)
            {
                Button b = new Button();
                b.Height = 50;
                b.Width = 40;
                b.Location = new Point(e.X, e.Y);
                b.Name = "one";
                b.Font = new Font("Georgia", 16);
                b.BackColor = Color.BurlyWood;
                Controls.Add(b);
                //b.Location = e.Location;
                b.Text = i.ToString();
                b.Name = i.ToString();
            }
            i++;


        }
    }
}
