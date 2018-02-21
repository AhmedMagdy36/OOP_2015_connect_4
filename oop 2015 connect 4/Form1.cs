using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
namespace oop_2015_connect_4
{
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer mid = new WMPLib.WindowsMediaPlayer();

        public Form1()
        {

            InitializeComponent();
            mid.URL = "br.mp3";
            mid.controls.stop();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

     

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();

            f2.ShowDialog();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();

            f3.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
         

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            mid.controls.play();
        }

          
    }
}
