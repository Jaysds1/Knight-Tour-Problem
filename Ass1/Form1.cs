using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
        }

        private void OutputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            update();
        }

        private void start_Click(object sender, EventArgs e)
        {
            bool s = smart.Checked, nonS = nonSmart.Checked;
            int trial = Convert.ToInt32(trials.Text), x = Convert.ToInt32(col.Value), y = Convert.ToInt32(row.Value);
            if (s)
            {
                /*for (int t = 0; t < trial; t++)
                {
                    Intelligent i = new Intelligent(x, y);
                }*/
            }
            else if (nonS)
            {
                Non_Intelligent nonI = new Non_Intelligent(trial, x, y);
                sd.Text = nonI.standDev+"";
                avg.Text = nonI.avg + "";
                update();
            }
            else
                MessageBox.Show("Select Computer Method", "Computer Method", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void update()
        {
            string output = "";
            try
            {
                using (StreamReader sr = new StreamReader("JaiquonNonIntelligentMethod.txt"))
                {
                    while (!sr.EndOfStream)
                        output += sr.ReadLine();
                }
                setOutputBox(output);
            }
            catch (Exception e)
            {
                
            }
        }
    }
}
