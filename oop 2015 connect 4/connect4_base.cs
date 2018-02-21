using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2015_connect_4
{
 abstract public   class connect4_base
    {
        public bool win;
	 public int player;
     public int[,] board;
	
        public connect4_base()
        {

            board = new int[6,7];
            player = 1;
            win = false;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    board[i,j] = 0;

                }
            }
        }
        public void check_winner()
        {
            int start = 0;

            //Horizontal Win
            for (int i = 0; i < 6; i++)
            {
                for (start = 0; start <= 3; start++)
                {
                    if ((board[i, start] == board[i, start + 1] && board[i, start + 1] == board[i, start + 2] && board[i, start + 2] == board[i, start + 3]) && (board[i, start] != 0))
                    {
                        win = true;
                        player = board[i, start];
                        break;
                    }
                }
            }

            //Vertical Win
            for (int i = 0; i < 7; i++)
            {
                for (start = 0; start <= 2; start++)
                {
                    if ((board[start, i] == board[start + 1, i] && board[start + 1, i] == board[start + 2, i] && board[start + 2, i] == board[start + 3, i]) && (board[start, i] != 0))
                    {
                        win = true;
                        player = board[start, i];
                        break;
                    }
                }
            }

            //Diagonal Win - "/"
            for (int i = 3; i < 6; i++)
            {
                for (start = 0; start <= 3; start++)
                {
                    if ((board[i, start] == board[i - 1, start + 1] && board[i - 1, start + 1] == board[i - 2, start + 2] && board[i - 2, start + 2] == board[i - 3, start + 3]) && (board[i, start] != 0))
                    {
                        win = true;
                        player = board[i, start];
                        break;
                    }
                }
            }

            //Diagonal Win -"\"
            for (int i = 0; i < 3; i++)
            {
                for (start = 0; start < 4; start++)
                {
                    if ((board[i, start] == board[i + 1, start + 1] && board[i + 1, start + 1] == board[i + 2, start + 2] && board[i + 2, start + 2] == board[i + 3, start + 3]) && (board[i, start] != 0))
                    {
                        win = true;
                        player = board[i, start];
                        break;
                    }
                }
            }

        }
        public virtual void place_of_play(int place)
        {

        }
      

    }
}



































































































/*#include <iostream>
using namespace std;
class connect4_base
{
public:
	connect4_base();
	//void display_board();
	void check_winner();
	//void clearscreen();
protected:
	bool win;
	int player;
	int board[6][7];
	
private:
	
};

class connect4 :public connect4_base
{

public:
	connect4();
	void connect4_game();
	void place_of_play();
private:
	int place;
};

 
 #include"Basic.h"
connect4_base::connect4_base()
{
	player = 1;
	win = false;

	for (int i = 0; i <6; i++)
	{
		for (int j = 0; j < 7; j++)
		{
			board[i][j] = 0;
			
		}
	}
}
void connect4_base :: display_board()
{
	clearscreen();
	cout << "  1  2  3  4  5  6  7 " << endl;
	cout <<"-----------------------"<< endl;
	for (int i = 0; i < 6; i++)
	{
		cout << endl;
		for (int j = 0; j < 7; j++)
		{
			
			cout << "  " << board[i][j];
			
		}
		cout << endl;
	}
}
connect4::connect4()
{

	connect4_base();


}
void connect4::connect4_game()
{
	check_winner();
	if (win == true)
	{
		clearscreen();
		display_board();
		cout <<"congratulation >>>>>>> player : " << player << "  has won " << endl;
	}
	else
	{
		display_board();
		place_of_play();
	}
}
void connect4::place_of_play()
{

	int empty_place = 0;
	cout << endl;
	cout << "player :" << player << " which place want to Drop ?" << endl;
	cin >> place;


	if (place > 7 || place <= 0)
	{
		cout << "......Wrong Place ....enter Again " << endl;
		place_of_play();
	}
	
	for (int i = 5; i >= 0; i--)
	{
		if (board[i][place-1] == 0)
		{
			board[i][place - 1] = player;
			break;
		}
		else
		{
			empty_place += 1;
			
		}

	}

	if (empty_place == 6)
	{
		cout << "there is no more space in : " << place << "Try Again :D " << endl;
		place_of_play();
	}
	if (player == 1)
	{
		player = 2;
	}
	else

	{
		player = 1;
	}

	connect4_game();
}
void connect4_base::check_winner()
{

	int start = 0;

	//Horizontal Win
	for (int i = 0; i < 6; i++){
		for (start = 0; start <= 3; start++)
		{
			if ((board[i][start] == board[i][start + 1] && board[i][start + 1] == board[i][start + 2] && board[i][start + 2] == board[i][start + 3]) && (board[i][start] != 0))
			{
				win = true;
				player = board[i][start];
				break;
			}
		}
	}

	//Vertical Win
	for (int i = 0; i < 7; i++){
		for (start = 0; start <= 2; start++){
			if ((board[start][i] == board[start + 1][i] && board[start + 1][i] == board[start + 2][i] && board[start + 2][i] == board[start + 3][i]) && (board[start][i] != 0)){
				win = true;
				player = board[start][i];
				break;
			}
		}
	}

	//Diagonal Win - "/"
	for (int i = 3; i < 6; i++){
		for (start = 0; start <= 3; start++){
			if ((board[i][start] == board[i - 1][start + 1] && board[i - 1][start + 1] == board[i - 2][start + 2] && board[i - 2][start + 2] == board[i - 3][start + 3]) && (board[i][start] != 0)){
				win = true;
				player = board[i][start];
				break;
			}
		}
	}

	//Diagonal Win -"\"
	for (int i = 0; i < 3; i++){
		for (start = 0; start <= 4; start++){
			if ((board[i][start] == board[i + 1][start + 1] && board[i + 1][start + 1] == board[i + 2][start + 2] && board[i + 2][start + 2] == board[i + 3][start + 3]) && (board[i][start] != 0)){
				win = true;
				player = board[i][start];
				break;
			}
		}
	}
}


*/