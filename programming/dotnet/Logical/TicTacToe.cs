using System;
using System.Collections.Generic;
using System.Text;

namespace Logical
{
	/// <summary>
	/// TicTacToe class enables to plays the tic tac toe game between computer and a player.
	/// it asks user for the entry and at the end checks who has won.
	/// </summary>
	class TicTacToe
    {
		int[,] array = new int[3, 3];

		/// <summary>
		/// TicTacToeMethod starts the game and successively promts user to enter the index to put its mark
		/// user has got 1 mark;
		/// computer has got -1 mark;
		/// it calls 4 methods namely  UserTurn() ComputerTurn() CheckStatus().
		/// </summary>
		public void TicTacToeMethod( )
		{
			int count = 0;
			Console.WriteLine("game started !!! ");
			while (count < 9)
			{
				Console.WriteLine("user turn : ");
				UserTurn(array);
				count++;
				Utility.Util.PrintTwoDIntArray(array);
				CheckStatus(array, count);
				Console.WriteLine("computer turn :");
				ComputerTurn(array);
				count++;
				Utility.Util.PrintTwoDIntArray(array);
				CheckStatus(array, count);
			}
			Console.WriteLine("draw!!!");
		}


		/// <summary>
		/// ComputerTurn() method is used to generateRandom index to mark "-1" on the gameboard unit.
		/// </summary>
		/// <param name="array">The array.</param>
		void ComputerTurn(int[,] array)
		{
			int i = 0;
			int j = 0;
			while (true)
			{
				//generates random number between 0 to 3 to select the board unit for the computer;
				i = Utility.Util.GenerateRandomInteger(3);
				j = Utility.Util.GenerateRandomInteger(3);

				//checks if the index has already been taken or not.
				if (array[i, j] == 0)
				{
					array[i, j] = -1;
					return;
				}
				else
				{
					continue;
				}
			}
		}




		/// <summary>
		/// UserTurn() prompts the user to enter the index of the array to set mark "1" for the user. 
		/// if the index is already taken than the user has to enter again.
		/// </summary>
		/// <param name="array">The array.</param>
		void UserTurn(int[,] array)
		{
			int i = 0;
			int j = 0;
			while (true)
			{
				Console.WriteLine("enter the index i and j to place your mark : ");
				//takes the index from the user
				i = Utility.Util.ReadInt();
				i = i % 3;
				j = Utility.Util.ReadInt();
				j = j % 3;

				//checks if the index has been already taken or not
				//if index is taken then repeat again.
				if (array[i, j] == 0)
				{
					array[i, j] = 1;
					return;
				}
				else
				{
					Console.WriteLine("already taken try again !!!");
					continue;
				}
			}
		}



		/// <summary>
		/// Checks the status of the game by calling a result() method based on whose return value  
		/// this method declares the result.
		/// </summary>
		/// <param name="array">The array which is board for the game.</param>
		/// <param name="count">The count.</param>
		void CheckStatus(int[,] array, int count)
		{
			int sum = Result(array);
			if (sum == 3 || sum == -3)
			{
				if (sum == 3)
					Console.WriteLine("user won!!!");
				else
					Console.WriteLine("computer won!!!");
				Environment.Exit(0);
			}
			else if (count == 9)
			{
				Console.WriteLine("draw!!!");
				Environment.Exit(0);
			}

		}

		/// <summary>
		/// Result() method is sued to check of the game ends up in draw , win or loss and returns 
		/// the value of sum to the caller method.
		/// </summary>
		/// <param name="array">The array.</param>
		/// <returns></returns>
		int Result(int[,] array)
		{
			int times = 1;
			int sum = 0;

			//to check the result horizontally and then vertically
			while (times <= 2)
			{
				for (int i = 0; i < 3; i++)
				{
					sum = 0;
					for (int j = 0; j < 3; j++)
					{
						//first it checks all the horizotal rows
						if (times == 1)
						{
							sum = sum + array[i,j];
						}
						else if (times == 2) //check for vertical coloum
						{
							sum = sum + array[j,i];
						}
					}
					if (sum == 3 || sum == -3)
					{
						return sum;
					}
				}
				times++;
			}

			sum = 0;
			//checks for diagonal elements
			sum = array[0,0] + array[1,1] + array[2,2];
			if (sum == 3 || sum == -3)
			{
				return sum;
			}
			else //checks for other diagonal element.
			{
				sum = array[0,2] + array[1,1] + array[2,0];
				if (sum == 3 || sum == -3)
				{
					return sum;
				}
			}

			return 0;
		}

		





	}
}
