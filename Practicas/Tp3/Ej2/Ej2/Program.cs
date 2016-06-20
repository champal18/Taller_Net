/*
 * Created by SharpDevelop.
 * User: Champal
 * Date: 15/4/2016
 * Time: 17:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ej2
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.CursorVisible = false;
			ConsoleKeyInfo k = Console.ReadKey(true);
			while(k.Key != ConsoleKey.End)
			{
				Console.Clear();
				Console.Write("{0,-10} {1,-10} {2,-10}", k.Modifiers, k.Key, k.KeyChar);
				if(k.Modifiers.ToString().Equals("Control")) Console.WriteLine("Control vieja!");
				k = Console.ReadKey(true);
			}
			
			
			//Console.Write("Press any key to continue . . . ");
			//Console.ReadKey(true);
		}
	}
}