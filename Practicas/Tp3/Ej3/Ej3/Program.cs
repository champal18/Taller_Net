/*
 * Created by SharpDevelop.
 * User: Champal
 * Date: 15/4/2016
 * Time: 17:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Text;

namespace Ej3
{
	class Program
	{
		public static void Main(string[] args)
		{
			ConsoleKeyInfo k = Console.ReadKey(true);
			StringBuilder str = new StringBuilder();
			while(k.Key != ConsoleKey.Enter) // Mientras no se presione "Enter"
			{
				char c = k.KeyChar;
				if(char.IsLetter(c))	// Si ingreso una letra la muestro en mayuscula por consola y la agrego a la cadena
				{
					str.Append(c);
					Console.Write(char.ToUpper(c));
				}
				else	// Si ingreso un numero, signo, espacio en blanco o "borrar" lo agrego a la cadena
				{
					if(char.IsDigit(c) || char.IsWhiteSpace(c) || char.IsPunctuation(c) || (k.Key == ConsoleKey.Backspace))
						str.Append(c);
				}
				k = Console.ReadKey(true); // Espero el proximo caracter
				
			}
			Console.Write(str);	// Muestro la cadena
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}




StringBuilder str = new StringBuilder();
			ConsoleKeyInfo k = Console.ReadKey(true);
			while(k.Key != ConsoleKey.Enter)
			{
				String st = new string(k.KeyChar,1);
				str.Insert(0,st,1);
				k = Console.ReadKey(true);
			}
			Console.Write(str);