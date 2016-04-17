/*
 * Created by SharpDevelop.
 * User: Champal
 * Date: 16/4/2016
 * Time: 18:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Runtime.Remoting.Channels;

namespace Ej14
{
	class Program
	{
		public static void Main(string[] args)
		{
			Stack pila = new Stack();
			bool ok = false;
			ConsoleKeyInfo k = Console.ReadKey();
			while((k.Key != ConsoleKey.Enter) && !ok)
			{
				if(k.KeyChar == '{')
				{
					pila.Push(k.KeyChar);
				}
				if(k.KeyChar == '}')
				{
					if(pila.Count == 0)
						ok = true;
					else
						pila.Pop();
				}
				if(!ok)
					k = Console.ReadKey();
			}
			if(ok)
				Console.WriteLine("\nCadena invalida!");
			else
				Console.WriteLine("\nCadena valida!");

			Console.ReadKey(true);
		}
	}
}