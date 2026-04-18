using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7_WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSpeed.Visible = false;
            txtAccel.Visible = false;

            UpdateFormulas();
            
        }

        private void UpdateFormulas()
        {
            int a = hScrollBar1.Value;
            int b = hScrollBar2.Value;

            label1.Text = $"x={b}cos({a}t)";
            label2.Text = $"y={b}sin({a}t)";
        }

        private void UpdateValues()
        {
            int a = hScrollBar1.Value;
            int b = hScrollBar2.Value;

            int V = a * b;
            int accel = a * a * b;

            if (txtSpeed.Visible)
                txtSpeed.Text = V.ToString();
            if (txtAccel.Visible)
                txtAccel.Text = accel.ToString();
        }

        private void buttonSpeed_Click(object sender, EventArgs e)
        {
            txtSpeed.Visible = !txtSpeed.Visible;
            UpdateValues();
        }

        private void buttonAccel_Click(object sender, EventArgs e)
        {
            txtAccel.Visible = !txtAccel.Visible;
            UpdateValues();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hScrollBar2_ValueChanged(object sender, EventArgs e)
        {
            UpdateFormulas();
            UpdateValues();
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            UpdateFormulas();
            UpdateValues();
        }
    }
}
