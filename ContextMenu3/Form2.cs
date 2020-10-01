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
    public partial class Form2 : Form
    {
        private int X, Y;

        public Form2()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            BackColor = Color.DarkGray;
            ShowInTaskbar = false;
            Shown += Form2_Shown;
            MouseHook mouseHook = new MouseHook();
            mouseHook.LeftButtonDown += MouseHook_LeftButtonDown;
            mouseHook.Install();
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            Location = new Point(X, Y);
        }

        private void MouseHook_LeftButtonDown(MouseHook.MSLLHOOKSTRUCT mouseStruct)
        {
            int X = mouseStruct.pt.x;
            int Y = mouseStruct.pt.y;

            if (X < Bounds.Left || X > Bounds.Right && Y < Bounds.Top || Y > Bounds.Bottom)
            {
                MessageBox.Show("L : " + Convert.ToString(Bounds.Left) + "   R : " + Convert.ToString(Bounds.Right) + "   T : " + Convert.ToString(Bounds.Top) + "   B : " + Convert.ToString(Bounds.Bottom) + "\nX : " + Convert.ToString(X) + "   Y : " + Convert.ToString(Y));
                //Dispose();
            }
        }

        public void Call(int X, int Y, Form ClientForm)
        {
            this.X = X;
            this.Y = Y;
            ShowDialog(ParentForm);
        }
    }
}
