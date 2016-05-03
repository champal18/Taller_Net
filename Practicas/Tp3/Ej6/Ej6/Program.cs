/*
 * Created by SharpDevelop.
 * User: Champal
 * Date: 3/5/2016
 * Time: 11:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ej6
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Ingrese un numero:");
			String linea = Console.ReadLine();
			int suma=0;
			while (!linea.Equals("")){
				int actual=0;
				
				try{
					actual = int.Parse(linea);
					suma+=actual;
				}
				catch (Exception e){
					Console.WriteLine(e.Message);
					//break;
				}
				
				Console.WriteLine("Total: {0}",suma);
				linea = Console.ReadLine();
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}