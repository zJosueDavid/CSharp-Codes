using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineasWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Point> lista = new List<Point>();
        private void Form1_Load(object sender,EventArgs e)
        {
         
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen lapiz = new Pen(Color.Aqua, 3);
            g.DrawRectangle(lapiz, new Rectangle(e.X, e.Y, 3 , 3));

            lista.Add(new Point(e.X, e.Y));

            if (lista.Count > 1)
            {
                g.DrawLine(lapiz, lista[lista.Count - 1], lista[lista.Count - 2]);
            }
        }
    }
}
