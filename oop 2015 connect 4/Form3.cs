using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_2015_connect_4
{
    public partial class Form3 : Form
    {
        connect4 conn = new connect4();
        int column1_count = 1;
        int column2_count = 1;
        int column3_count = 1;
        int column4_count = 1;
        int column5_count = 1;
        int column6_count = 1;
        int column7_count = 1;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.Beep();


            if (column1_count == 1)
            {

                if (conn.player == 1)
                {

                    //refresh the picture box
                    pic_c1_1.Refresh();
                    //create a graphics object
                    Graphics g = pic_c1_1.CreateGraphics();
                    //create a pen object
                    Brush b = new SolidBrush(Color.Red);
                    //draw Ellipse
                    g.FillEllipse(b, 16, 5, 72,72);
                    //dispose pen and graphics object
                    b.Dispose();
                    g.Dispose();
                    //  this.pic_c1_1.Image = new Bitmap("red.bmp");
                }

                else
                {


                   
                    //this.pic_c1_1.Image = new Bitmap("yellow.bmp");
                }
                column1_count++;
            }


            else if (column1_count == 2)
            {


                if (conn.player == 1)
                {
                    this.pic_c1_2.Image = new Bitmap("red.bmp");
                }

                else
                {
                    this.pic_c1_2.Image = new Bitmap("yellow.bmp");
                }

                column1_count++;
            }


            else if (column1_count == 3)
            {


                if (conn.player == 1)
                {
                    this.pic_c1_3.Image = new Bitmap("red.bmp");
                }

                else
                {
                    this.pic_c1_3.Image = new Bitmap("yellow.bmp");
                }

                column1_count++;
            }



            else if (column1_count == 4)
            {


                if (conn.player == 1)
                {
                    this.pic_c1_4.Image = new Bitmap("red.bmp");
                }

                else
                {
                    this.pic_c1_4.Image = new Bitmap("yellow.bmp");
                }

                column1_count++;
            }



            else if (column1_count == 5)
            {


                if (conn.player == 1)
                {
                    this.pic_c1_5.Image = new Bitmap("red.bmp");
                }

                else
                {
                    this.pic_c1_5.Image = new Bitmap("yellow.bmp");
                }
                column1_count++;

            }


            else if (column1_count == 6)
            {


                if (conn.player == 1)
                {
                    this.pic_c1_6.Image = new Bitmap("red.bmp");

                }

                else
                {
                    this.pic_c1_6.Image = new Bitmap("yellow.bmp");


                }
                column1_count++;
            }



            if (column1_count <= 7)
            {
                conn.place_of_play(1);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.Beep();

            if (column2_count == 1)
            {

                if (conn.player == 1)
                {
                    this.pic_c2_1.Image = new Bitmap("red.bmp");
                }

                else
                {
                    this.pic_c2_1.Image = new Bitmap("yellow.bmp");
                }
                column2_count++;
            }


            else if (column2_count == 2)
            {


                if (conn.player == 1)
                {
                    this.pic_c2_2.Image = new Bitmap("red.bmp");
                }

                else
                {
                    this.pic_c2_2.Image = new Bitmap("yellow.bmp");
                }

                column2_count++;
            }


            else if (column2_count == 3)
            {


                if (conn.player == 1)
                {
                    this.pic_c2_3.Image = new Bitmap("red.bmp");
                }

                else
                {
                    this.pic_c2_3.Image = new Bitmap("yellow.bmp");
                }

                column2_count++;
            }



            else if (column2_count == 4)
            {


                if (conn.player == 1)
                {
                    this.pic_c2_4.Image = new Bitmap("red.bmp");
                }

                else
                {
                    this.pic_c2_4.Image = new Bitmap("yellow.bmp");
                }
                column2_count++;

            }



            else if (column2_count == 5)
            {


                if (conn.player == 1)
                {
                    this.pic_c2_5.Image = new Bitmap("red.bmp");
                }

                else
                {
                    this.pic_c2_5.Image = new Bitmap("yellow.bmp");
                }
                column2_count++;

            }


            else if (column2_count == 6)
            {


                if (conn.player == 1)
                {
                    this.pic_c2_6.Image = new Bitmap("red.bmp");
                }

                else
                {
                    this.pic_c2_6.Image = new Bitmap("yellow.bmp");
                }
                column2_count++;
            }


            if (column2_count <= 7)
            {
                conn.place_of_play(2);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.Beep();

            if (column3_count == 1)
            {

                if (conn.player == 1)
                {
                    this.pic_c3_1.Image = new Bitmap("red.bmp");
                }

                else
                {
                    this.pic_c3_1.Image = new Bitmap("yellow.bmp");
                }
                column3_count++;
            }


            else if (column3_count == 2)
            {


                if (conn.player == 1)
                {
                    this.pic_c3_2.Image = new Bitmap("red.bmp");
                }

                else
                {
                    this.pic_c3_2.Image = new Bitmap("yellow.bmp");
                }

                column3_count++;
            }


            else if (column3_count == 3)
            {


                if (conn.player == 1)
                {
                    this.pic_c3_3.Image = new Bitmap("red.bmp");
                }

                else
                {
                    this.pic_c3_3.Image = new Bitmap("yellow.bmp");
                }

                column3_count++;
            }



            else if (column3_count == 4)
            {


                if (conn.player == 1)
                {
                    this.pic_c3_4.Image = new Bitmap("red.bmp");
                }

                else
                {
                    this.pic_c3_4.Image = new Bitmap("yellow.bmp");
                }
                column3_count++;

            }



            else if (column3_count == 5)
            {


                if (conn.player == 1)
                {
                    this.pic_c3_5.Image = new Bitmap("red.bmp");
                }

                else
                {
                    this.pic_c3_5.Image = new Bitmap("yellow.bmp");
                }
                column3_count++;

            }


            else if (column3_count == 6)
            {


                if (conn.player == 1)
                {
                    this.pic_c3_6.Image = new Bitmap("red.bmp");
                }

                else
                {
                    this.pic_c3_6.Image = new Bitmap("yellow.bmp");
                }
                column3_count++;
            }

            if (column3_count <= 7)
            {
                conn.place_of_play(3);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console.Beep();

            if (column4_count == 1)
            {

                if (conn.player == 1)
                {
                    this.pic_c4_1.Image = new Bitmap("red.bmp");
                }

                else
                {
                    this.pic_c4_1.Image = new Bitmap("yellow.bmp");
                }
                column4_count++;
            }


            else if (column4_count == 2)
            {


                if (conn.player == 1)
                {
                    this.pic_c4_2.Image = new Bitmap("red.bmp");
                }

                else
                {
                    this.pic_c4_2.Image = new Bitmap("yellow.bmp");
                }

                column4_count++;
            }


            else if (column4_count == 3)
            {


                if (conn.player == 1)
                {
                    this.pic_c4_3.Image = new Bitmap("red.bmp");
                }

                else
                {
                    this.pic_c4_3.Image = new Bitmap("yellow.bmp");
                }

                column4_count++;
            }



            else if (column4_count == 4)
            {


                if (conn.player == 1)
                {
                    this.pic_c4_4.Image = new Bitmap("red.bmp");
                }

                else
                {
                    this.pic_c4_4.Image = new Bitmap("yellow.bmp");
                }
                column4_count++;

            }



            else if (column4_count == 5)
            {


                if (conn.player == 1)
                {
                    this.pic_c4_5.Image = new Bitmap("red.bmp");
                }

                else
                {
                    this.pic_c4_5.Image = new Bitmap("yellow.bmp");
                }
                column4_count++;

            }


            else if (column4_count == 6)
            {


                if (conn.player == 1)
                {
                    this.pic_c4_6.Image = new Bitmap("red.bmp");
                }

                else
                {
                    this.pic_c4_6.Image = new Bitmap("yellow.bmp");
                }
                column4_count++;
            }
            if (column4_count <= 7)
            {
                conn.place_of_play(4);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Console.Beep();

            if (column5_count == 1)
            {

                if (conn.player == 1)
                {
                    this.pic_c5_1.Image = new Bitmap("red.bmp");
                }

                else
                {
                    this.pic_c5_1.Image = new Bitmap("yellow.bmp");
                }
                column5_count++;
            }


            else if (column5_count == 2)
            {


                if (conn.player == 1)
                {
                    this.pic_c5_2.Image = new Bitmap("red.bmp");
                }

                else
                {
                    this.pic_c5_2.Image = new Bitmap("yellow.bmp");
                }

                column5_count++;
            }


            else if (column5_count == 3)
            {


                if (conn.player == 1)
                {
                    this.pic_c5_3.Image = new Bitmap("red.bmp");
                }

                else
                {

                    this.pic_c5_3.Image = new Bitmap("yellow.bmp");
                }

                column5_count++;
            }



            else if (column5_count == 4)
            {


                if (conn.player == 1)
                {
                    this.pic_c5_4.Image = new Bitmap("red.bmp");
                }

                else
                {
                    this.pic_c5_4.Image = new Bitmap("yellow.bmp");
                }
                column5_count++;

            }



            else if (column5_count == 5)
            {


                if (conn.player == 1)
                {
                    this.pic_c5_5.Image = new Bitmap("red.bmp");
                }

                else
                {
                    this.pic_c5_5.Image = new Bitmap("yellow.bmp");
                }
                column5_count++;

            }


            else if (column5_count == 6)
            {


                if (conn.player == 1)
                {
                    this.pic_c5_6.Image = new Bitmap("red.bmp");
                }

                else
                {
                    this.pic_c5_6.Image = new Bitmap("yellow.bmp");
                }
                column5_count++;
            }

            if (column5_count <= 7)
            {
                conn.place_of_play(5);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Console.Beep();


            if (column6_count == 1)
            {

                if (conn.player == 1)
                {
                    this.pic_c6_1.Image = new Bitmap("red.bmp");
                }

                else
                {
                    this.pic_c6_1.Image = new Bitmap("yellow.bmp");
                }
                column6_count++;
            }


            else if (column6_count == 2)
            {


                if (conn.player == 1)
                {
                    this.pic_c6_2.Image = new Bitmap("red.bmp");
                }

                else
                {
                    this.pic_c6_2.Image = new Bitmap("yellow.bmp");
                }

                column6_count++;
            }


            else if (column6_count == 3)
            {


                if (conn.player == 1)
                {
                    this.pic_c6_3.Image = new Bitmap("red.bmp");
                }

                else
                {
                    this.pic_c6_3.Image = new Bitmap("yellow.bmp");
                }

                column6_count++;
            }



            else if (column6_count == 4)
            {


                if (conn.player == 1)
                {
                    this.pic_c6_4.Image = new Bitmap("red.bmp");
                }

                else
                {
                    this.pic_c6_4.Image = new Bitmap("yellow.bmp");
                }
                column6_count++;

            }



            else if (column6_count == 5)
            {


                if (conn.player == 1)
                {
                    this.pic_c6_5.Image = new Bitmap("red.bmp");
                }

                else
                {
                    this.pic_c6_5.Image = new Bitmap("yellow.bmp");
                }
                column6_count++;

            }


            else if (column6_count == 6)
            {


                if (conn.player == 1)
                {
                    this.pic_c6_6.Image = new Bitmap("red.bmp");
                }

                else
                {
                    this.pic_c6_6.Image = new Bitmap("yellow.bmp");
                }
                column6_count++;
            }

            if (column6_count <= 7)
            {
                conn.place_of_play(6);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Console.Beep();


            if (column7_count == 1)
            {

                if (conn.player == 1)
                {
                    this.pic_c7_1.Image = new Bitmap("red.bmp");
                }

                else
                {
                    this.pic_c7_1.Image = new Bitmap("yellow.bmp");
                }
                column7_count++;
            }


            else if (column7_count == 2)
            {


                if (conn.player == 1)
                {
                    this.pic_c7_2.Image = new Bitmap("red.bmp");
                }

                else
                {
                    this.pic_c7_2.Image = new Bitmap("yellow.bmp");
                }

                column7_count++;
            }


            else if (column7_count == 3)
            {


                if (conn.player == 1)
                {
                    this.pic_c7_3.Image = new Bitmap("red.bmp");
                }

                else
                {
                    this.pic_c7_3.Image = new Bitmap("yellow.bmp");
                }

                column7_count++;
            }



            else if (column7_count == 4)
            {


                if (conn.player == 1)
                {
                    this.pic_c7_4.Image = new Bitmap("red.bmp");
                }

                else
                {
                    this.pic_c7_4.Image = new Bitmap("yellow.bmp");
                }
                column7_count++;

            }



            else if (column7_count == 5)
            {


                if (conn.player == 1)
                {
                    this.pic_c7_5.Image = new Bitmap("red.bmp");
                }

                else
                {
                    this.pic_c7_5.Image = new Bitmap("yellow.bmp");
                }
                column7_count++;

            }


            else if (column7_count == 6)
            {


                if (conn.player == 1)
                {
                    this.pic_c7_6.Image = new Bitmap("red.bmp");
                }

                else
                {
                    this.pic_c7_6.Image = new Bitmap("yellow.bmp");
                }
                column7_count++;
            }
            if (column7_count <= 7)
            {
                conn.place_of_play(7);
            }
        }

        
        private void button9_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 f1 = new Form1();

            f1.ShowDialog();
            this.Close();
        }
    }
}