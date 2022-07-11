using System;

namespace test
{
	class Program
	{
		static void PrintField(string[,] arr)
		{
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				Console.WriteLine("+-+-+-+");
				Console.WriteLine("|" + arr[i, 0] + "|" + arr[i, 1] + "|" + arr[i, 2] + "|");
			}
			Console.WriteLine("+-+-+-+");
			Console.WriteLine("--------------------");
		}
		static string[,] Move(string[,] arr, string player)
		{
			Console.WriteLine($"Сейчас ходит игрок {player} \n Выберете строку от 1 до 3");
			int lineNumber = int.Parse(Console.ReadLine());
			Console.WriteLine("Выберете столбец от 1 до 3");
			int columnNumber = int.Parse(Console.ReadLine());
			while (lineNumber < 0 || lineNumber > 3 || columnNumber < 0 || columnNumber > 3 || arr[lineNumber - 1, columnNumber - 1] == "X" || arr[lineNumber - 1, columnNumber - 1] == "O")
			{
				if (lineNumber < 0 || lineNumber > 3 || columnNumber < 0 || columnNumber > 3)
				{
					Console.WriteLine("Попробуйте еще раз");
				}
				else
				{
					Console.WriteLine("Это место занято");
				}
				Console.WriteLine($"Сейчас ходит игрок {player} \n Выберете строку от 1 до 3");
				lineNumber = int.Parse(Console.ReadLine());
				Console.WriteLine("Выберете столбец от 1 до 3");
				columnNumber = int.Parse(Console.ReadLine());
			}
			arr[lineNumber - 1, columnNumber - 1] = player;
			return arr;
		}

		static bool Winner(string player, string[,] arr)
		{
			return (arr[0, 0] == player & arr[0, 1] == player & arr[0, 2] == player) || (arr[1, 0] == player & arr[1, 1] == player & arr[1, 2] == player) || (arr[2, 0] == player & arr[2, 1] == player & arr[2, 2] == player) || (arr[0, 0] == player & arr[1, 0] == player & arr[2, 0] == player) || (arr[0, 1] == player & arr[1, 1] == player & arr[2, 1] == player) || (arr[0, 2] == player & arr[1, 2] == player & arr[2, 2] == player) || (arr[0, 0] == player & arr[1, 1] == player & arr[2, 2] == player) || (arr[0, 2] == player & arr[1, 1] == player & arr[2, 0] == player);
		}	
		static void Main(string[] args)
		{
			string[,] arr = new string[3, 3]
			{
   			{" "," "," "},
			{" "," "," "},
			{" "," "," "}
			};

			int step = 0;
			string player = "X";
			PrintField(arr);
			for (int i = 0; i < arr.Length; i++)
			{
				arr = Move(arr, player);
				step += 1;
				PrintField(arr);				
				if (Winner(player, arr))
                {
					Console.WriteLine($"победил игрок {player}");
					break;
				}
				if (player == "X")
                {
					player = "O";
                }
				else
                {
					player = "X";
                }
			}
			Console.WriteLine("Ничья");
		}
	}	
}
