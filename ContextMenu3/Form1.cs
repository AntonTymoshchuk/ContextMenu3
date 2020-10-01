using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RamGecTools;

namespace ContextMenu3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MouseClick += Form1_MouseClick;
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Form2 form2 = new Form2();
                form2.Call(Bounds.X + e.X, Bounds.Y + e.Y, this);
            }
        }
    }
}
