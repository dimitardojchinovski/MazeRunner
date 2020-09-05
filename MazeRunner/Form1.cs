using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeRunner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dolu(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                movingObject.Left -= 5;
            }
            if (e.KeyCode == Keys.Right)
            {
                movingObject.Left += 5;
            }
            if (e.KeyCode == Keys.Up)
            {
                movingObject.Top -= 5;
            }
            if (e.KeyCode == Keys.Down)
            {
                movingObject.Top +=5;
            }
        }

        private void gore(object sender, KeyEventArgs e)
        {
            
        }
        private void MoveToStart()
        {
            movingObject.Location = new Point(33, 408);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
   
            if (movingObject.Bounds.IntersectsWith(end.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Победник!");
                Close();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            foreach(Control x in this.Controls)
            {
                if(x is Label && x.Tag == "boundries")
                {
                    if (movingObject.Bounds.IntersectsWith(x.Bounds))
                    {
                            timer2.Stop();
                            MessageBox.Show("Не допирај!");
                            MoveToStart();
                            timer2.Start();
                        
                        
                    }
                }
            }
        }
    }
}
