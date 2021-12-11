using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication3
{
    public partial class ProcessStartClose : Form
    {
        public object ColumnHeaderAutoResizeStyles { get; private set; }

        public ProcessStartClose()
        {
            InitializeComponent();

        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { try
            {
                process1.StartInfo.FileName = textBox1.Text;
                process1.Start();


            }
            catch (Exception)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)

        {
            Process[] getprocess = Process.GetProcesses();
            int i;
            try {
                for (i = 0; i < getprocess.Length; i++)
                {
                    if (getprocess[i].ProcessName == textBox1.Text)
                    {
                        getprocess[i].Kill();

                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("not permission is extended");
            }
        }
      

        private void button3_Click(object sender, EventArgs e)
        {
            Process[] p = Process.GetProcesses();
            foreach (Process process in p)
            {
                listBox1.Items.Add(process.ProcessName);
              
            }
        }
        public static System.Diagnostics.Process[] GetProcesses()
        {
         
            return GetProcesses();
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedItem.ToString();
        }
  }
 
}
