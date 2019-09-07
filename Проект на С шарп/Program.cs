using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проект_на_С_шарп
{
	class Program
	{
		static void Main(string[] args)
		{
			int a;
			int rez = 1;

			Console.Write("Введите число ");
			a = Convert.ToInt32(Console.ReadLine());

			Console.Write("Введите степень,в которую хотите возвести число ");
			int n = Convert.ToInt32(Console.ReadLine());

			for (int i = 1;i <= n;i++)
			{
				rez = rez * a;
			}

			Console.WriteLine($"Результат: {rez}");
			Console.Read();
		}
	}
}
