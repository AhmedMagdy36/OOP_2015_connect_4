using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace oop_2015_connect_4
{
    public class connect4 : connect4_base
    {


        public connect4()  : base()
        {

        }
        public override void place_of_play(int place)
        {

            int empty_place = 0;
            for (int i = 5; i >= 0; i--)
            {
                if (board[i, place - 1] == 0)
                {
                    board[i, place - 1] = player;
                    break;
                }
                else
                {
                    empty_place += 1;

                }

            }

            if (player == 1)
            {

                player = 2;
            }
            else
            {


                player = 1;
            }

            check_winner();
            if (win == true)
            {
                if (player == 1)
                {


                    MessageBox.Show("     Congratulations >>>>  Red Has Won :D  <<<<   ");


                }
                else
                {


                    MessageBox.Show("     Congratulations >>>>   Yellow Has Won :D <<<<  ");


                }


            }
        }

    }


    //#############################################################################
    //#############################################################################
    public class connect4_computer : connect4_base
    {
        public connect4_computer(): base()
        {

        }


        public override void place_of_play(int place)
        {

            int empty_place = 0;
            for (int i = 5; i >= 0; i--)
            {
                if (board[i, place - 1] == 0)
                {
                    board[i, place - 1] = player;
                    break;
                }
                else
                {
                    empty_place += 1;

                }

            }

            if (player == 1)
            {

                player = 2;
            }
            else
            {


                player = 1;
            }

            check_winner();
            if (win == true)
            {
                if (player == 1)
                {


                    MessageBox.Show(" <<<<<    Congratulations     >>>>\n                    player 1 Has Won   ");


                }
                else
                {


                    MessageBox.Show("                           you lose                           ");


                }


            }
        }
    }
}





