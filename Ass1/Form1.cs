﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnightTour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void setOutputBox(String s)
        {
            OutputBox.Text = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool s = smart.Checked,nonS = nonSmart.Checked;
            int trial = Convert.ToInt32(trials.Text), x = Convert.ToInt32(col.Value),y=Convert.ToInt32(row.Value);
            if (s)
            {
                //Intelligent i = new Intelligent();
            }
            else if (nonS)
            {
                Non_Intelligent nonI = new Non_Intelligent(trial, x, y);
                //setOutputBox(nonI.ToString);
            }
            else
                MessageBox.Show("Select Computer Method", "Computer Method", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
