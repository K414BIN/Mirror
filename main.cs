using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mirror
{
    class Program
    {
        static void Main(string[] args)
        {
           	int len;
			System.Console.WriteLine("Добрый день! Введите Ваше сообщение: ");
			string str = Console.ReadLine();
			len = str.Length-1;
			// Переведем строку в массив символов
			char[] revers = str.ToCharArray();
			System.Console.WriteLine();
			// Выведем символы в обратном порядке
			for (int j=len;j>=0;j--)
			{
				System.Console.Write(revers[j]);
	                                 	}
		    System.Console.WriteLine();
			      Console.ReadLine();


        }
    }
}
