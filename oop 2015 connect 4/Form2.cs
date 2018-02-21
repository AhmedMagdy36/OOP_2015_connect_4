using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace oop_2015_connect_4
{
    public partial class Form2 : Form
    {
        Random r;
        int column1_count = 1;
        int column2_count = 1;
        int column3_count = 1;
        int column4_count = 1;
        int column5_count = 1;
        int column6_count = 1;
        int column7_count = 1;

        int computer_counter;
        

        connect4_computer comp = new connect4_computer();
         
        Button[] arr;

        public Form2()
        {
          
            InitializeComponent();
            r = new Random();
            computer_counter = 0;
            arr = new Button[7] {button1,button2,button3,button4,button5,button6,button7};
            

        }

        private void tableLayoutPanel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {


        }

      

        private void i(object sender, EventArgs e)
        {
            
        }
        public void computer()
        {
            int random = r.Next(1, 7);

            arr[random].PerformClick();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (column7_count == 1)
            {
                this.pic_c7_1.Image = new Bitmap("red.bmp");

            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (column1_count == 1)
            {
                this.pic_c1_1.Image = new Bitmap("red.bmp") ;
            
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (column2_count == 1)
            {
                this.pic_c2_1.Image = new Bitmap("red.bmp");

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (column3_count == 1)
            {
                this.pic_c3_1.Image = new Bitmap("red.bmp");

            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (column6_count == 1)
            {
                this.pic_c6_1.Image = new Bitmap("red.bmp");

            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (column4_count == 1)
            {
                this.pic_c4_1.Image = new Bitmap("red.bmp");

            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (column5_count == 1)
            {
                this.pic_c5_1.Image = new Bitmap("red.bmp");

            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            
            Console.Beep();

            
                if (column1_count == 1)
                {

                    if (comp.player == 1)
                    {
                        
                        
                       this.pic_c1_1.Image = new Bitmap("red.bmp");
                    }

                    else
                    {
                        this.pic_c1_1.Image = new Bitmap("yellow.bmp");
                    }
                    column1_count++; 
                }


                else if (column1_count == 2)
                {


                    if (comp.player == 1)
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


                    if (comp.player == 1)
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


                    if (comp.player == 1)
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


                    if (comp.player == 1)
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


                    if (comp.player == 1)
                    {
                        this.pic_c1_6.Image = new Bitmap("red.bmp");

                    }

                    else
                    {
                        this.pic_c1_6.Image = new Bitmap("yellow.bmp");

                        
                    }
                    column1_count++; 
                }



                if (column1_count <= 7 )
                {
                    comp.place_of_play(1);
                    computer_counter++;
                    if (computer_counter % 2 == 1)
                        computer();
                }
        


  

        }
 
        private void button2_Click(object sender, EventArgs e)
        {
            Console.Beep();
            
                if (column2_count == 1)
                {

                    if (comp.player == 1)
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


                    if (comp.player == 1)
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


                    if (comp.player == 1)
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


                    if (comp.player == 1)
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


                    if (comp.player == 1)
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


                    if (comp.player == 1)
                    {
                        this.pic_c2_6.Image = new Bitmap("red.bmp");
                    }

                    else
                    {
                        this.pic_c2_6.Image = new Bitmap("yellow.bmp");
                    }
                    column2_count++;
                }


                if (column2_count <=7)
                {
                    comp.place_of_play(2);
                    computer_counter++;
                    if (computer_counter % 2 == 1)
                        computer();
                }
               
           


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.Beep();
           
            if (column3_count == 1)
            {

                if (comp.player == 1)
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


                if (comp.player == 1)
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


                if (comp.player == 1)
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


                if (comp.player == 1)
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


                if (comp.player == 1)
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


                if (comp.player == 1)
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
                comp.place_of_play(3);
                computer_counter++;
                if (computer_counter % 2 == 1 )
                    computer();
            }
           




           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console.Beep();
            
            if (column4_count == 1)
            {

                if (comp.player == 1)
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


                if (comp.player == 1)
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


                if (comp.player == 1)
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


                if (comp.player == 1)
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


                if (comp.player == 1)
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


                if (comp.player == 1)
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
                comp.place_of_play(4);
                computer_counter++;
                if (computer_counter % 2 == 1 )
                    computer();
            }
     

            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Console.Beep();
           
            if (column5_count == 1)
            {

                if (comp.player == 1)
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


                if (comp.player == 1)
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


                if (comp.player == 1)
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


                if (comp.player == 1)
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


                if (comp.player == 1)
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


                if (comp.player == 1)
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
                comp.place_of_play(5);
                computer_counter++;
                if (computer_counter % 2 == 1 )
                    computer();
            }
           
           

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Console.Beep();

           
            if (column6_count == 1)
            {

                if (comp.player == 1)
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


                if (comp.player == 1)
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


                if (comp.player == 1)
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


                if (comp.player == 1)
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


                if (comp.player == 1)
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


                if (comp.player == 1)
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
                comp.place_of_play(6);
                computer_counter++;
                if (computer_counter % 2 == 1 )
                    computer();
            }
            
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Console.Beep();

            
            if (column7_count == 1)
            {

                if (comp.player == 1)
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


                if (comp.player == 1)
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


                if (comp.player == 1)
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


                if (comp.player == 1)
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


                if (comp.player == 1)
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


                if (comp.player == 1)
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
                comp.place_of_play(7);
                computer_counter++;
                if (computer_counter % 2 == 1 )
                    computer();
            }
          
        }

        private void button8_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 f1 = new Form1();

            f1.ShowDialog();
            this.Close();
        }

        private void pic_c1_6_Click(object sender, EventArgs e)
        {

        }
    }
}
