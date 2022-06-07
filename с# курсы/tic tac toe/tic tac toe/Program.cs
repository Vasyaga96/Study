using System;

namespace tic_tac_toe
{
    class Program
    {
        static void Main(string[] args)
        {
			string[,] arr = new string[3, 3]
			{
   				{" "," "," "},
				{" "," "," "},
				{" "," "," "}
			};
			int step = 0;

			static void PrintField(string [,] arr)
            {
				for (int i = 0; i < arr.GetLength(0); i++)
				{
					Console.WriteLine("+-+-+-+");
					Console.WriteLine("|" + arr[i, 0] + "|" + arr[i, 1] + "|" + arr[i, 2] + "|");
				}
				Console.WriteLine("+-+-+-+");
				Console.WriteLine("--------------------");
			}

			PrintField(arr);
			for (int i = 0; i < arr.Length; i++)
   			{
				Console.WriteLine("Сейчас ходит игрок X \n Выберете строку от 1 до 3");
   				int lineNumber = int.Parse(Console.ReadLine());
				Console.WriteLine("Выберете столбец от 1 до 3");
   				int columnNumber = int.Parse(Console.ReadLine());
				while (lineNumber < 0 || lineNumber > 3 || columnNumber < 0 || columnNumber > 3)
				{
					Console.WriteLine("Попробуйте еще раз");
					Console.WriteLine("Сейчас ходит игрок Х \n Выберете строку от 1 до 3");
					lineNumber = int.Parse(Console.ReadLine());
					Console.WriteLine("Выберете столбец от 1 до 3");
					columnNumber = int.Parse(Console.ReadLine());
				}
				while (arr[lineNumber - 1, columnNumber - 1] == "X" || arr[lineNumber - 1, columnNumber - 1] == "0")
				{
					Console.WriteLine("Это место занято");
					Console.WriteLine("Сейчас ходит игрок X \n Выберете строку от 1 до 3");
   					lineNumber = int.Parse(Console.ReadLine());
					Console.WriteLine("Выберете столбец от 1 до 3");
					columnNumber = int.Parse(Console.ReadLine());
				}
				arr[lineNumber - 1, columnNumber - 1] = "X";
				step += 1;
				PrintField(arr);
				if (step == 9)
				{
					Console.WriteLine("Ничья");
					break;
				}
				if ((arr[0, 0] == "X" & arr[0, 1] == "X" & arr[0, 2] == "X") || (arr[1, 0] == "X" & arr[1, 1] == "X" & arr[1, 2] == "X") || (arr[2, 0] == "X" & arr[2, 1] == "X" & arr[2, 2] == "X") || (arr[0, 0] == "X" & arr[1, 0] == "X" & arr[2, 0] == "X") || (arr[0, 1] == "X" & arr[1, 1] == "X" & arr[2, 1] == "X") || (arr[0, 2] == "X" & arr[1, 2] == "X" & arr[2, 2] == "X") || (arr[0, 0] == "X" & arr[1, 1] == "X" & arr[2, 2] == "X") || (arr[0, 2] == "X" & arr[1, 1] == "X" & arr[2, 0] == "X"))
				{
					Console.WriteLine("победил игрок X");
					break;
				}
				Console.WriteLine("Сейчас ходит игрок 0 \n Выберете строку от 1 до 3");
   				lineNumber = int.Parse(Console.ReadLine());
				Console.WriteLine("Выберете столбец от 1 до 3");
				columnNumber = int.Parse(Console.ReadLine());
				while (lineNumber < 0 || lineNumber > 3 || columnNumber < 0 || columnNumber > 3)
				{
					Console.WriteLine("Попробуйте еще раз");
					Console.WriteLine("Сейчас ходит игрок 0 \n Выберете строку от 1 до 3");
					lineNumber = int.Parse(Console.ReadLine());
					Console.WriteLine("Выберете столбец от 1 до 3");
					columnNumber = int.Parse(Console.ReadLine());
				}
				while (arr[lineNumber - 1, columnNumber - 1] == "X" || arr[lineNumber - 1, columnNumber - 1] == "0")
				{
					Console.WriteLine("Это место занято");
					Console.WriteLine("Сейчас ходит игрок 0 /t Выберете строку от 1 до 3");
					lineNumber = int.Parse(Console.ReadLine());
					Console.WriteLine("Выберете столбец от 1 до 3");
					columnNumber = int.Parse(Console.ReadLine());
				}
				arr[lineNumber - 1, columnNumber - 1] = "0";
				step += 1;
				PrintField(arr);
				if ((arr[0, 0] == "0" & arr[0, 1] == "0" & arr[0, 2] == "0") || (arr[1, 0] == "0" & arr[1, 1] == "0" & arr[1, 2] == "0") || (arr[2, 0] == "0" & arr[2, 1] == "0" & arr[2, 2] == "0") || (arr[0, 0] == "0" & arr[1, 0] == "0" & arr[2, 0] == "0") || (arr[0, 1] == "0" & arr[1, 1] == "0" & arr[2, 1] == "0") || (arr[0, 2] == "0" & arr[1, 2] == "0" & arr[2, 2] == "0") || (arr[0, 0] == "0" & arr[1, 1] == "0" & arr[2, 2] == "0") || (arr[0, 2] == "0" & arr[1, 1] == "0" & arr[2, 0] == "0"))
				{
					Console.WriteLine("победил игрок 0");
					break;
				}
			}
		}
	}
}
