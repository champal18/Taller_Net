/*
 * Created by SharpDevelop.
 * User: Facu
 * Date: 19/04/2016
 * Time: 02:14 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio8
{
	class Program
	{
		public static void Main(string[] args)
		{
			string st;
			
			Console.WriteLine("Ingrese las cadenas de strings");
			
			st = Console.ReadLine();
			
			while(st.Length != 0)
			{
				
				Console.WriteLine("La cantidad de caracteres es "+ st.Length);
				st= Console.ReadLine();
					
			}
			
			
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}