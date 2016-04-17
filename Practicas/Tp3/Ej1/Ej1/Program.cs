/*
 * Created by SharpDevelop.
 * User: Champal
 * Date: 15/4/2016
 * Time: 16:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ej1
{
	class Program
	{
		public static void Main(string[] args)
		{
			// Valores maximos de la consola(predeterminada) sin utilizar setWindowsSize()
			Console.WindowHeight = 58;
			Console.WindowWidth = 227;
			for(int i=0;i<Console.WindowHeight;i++)
			{
				Console.CursorLeft = Console.WindowWidth-1-i; 	// Desplazamiento horizontal
				Console.CursorTop = i*2;						// Desplazamiento vertical
				Console.Write(i);
			}
			Console.CursorLeft = 0;
			Console.CursorVisible = false;		// Ocultar o mostrar el cursor
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}