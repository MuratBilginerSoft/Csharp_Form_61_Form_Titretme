using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Form_Tİtretme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random();

        int x, y;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = 0;
            Point l = this.Location;

            while (c < 50)
            {
                int x = r.Next(1, 10);
                int y = r.Next(1, 10);

                this.Location = new Point(l.X + x, l.Y + y);
                Thread.Sleep(20); // bu çalışan kod parçacığının belirtilen bir süre duraklatılmasını sağlar.
                c++; 
            }

            this.Location = l;
            
        }
    }
}
