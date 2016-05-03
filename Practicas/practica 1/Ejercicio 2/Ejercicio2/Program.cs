/*
 * Created by SharpDevelop.
 * User: Facu
 * Date: 07/04/2016
 * Time: 05:00 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio2
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Prueba de secuencias de escape");
			
			Console.WriteLine("Uso del /n");
			Console.WriteLine("Prueba \nPrueba \nPrueba \n");
			
			Console.WriteLine("Uso del /t");
			Console.WriteLine("Prueba\tPrueba\tPrueba\t");
			
			Console.WriteLine("Uso del /");
			Console.WriteLine("Prueba\"Prueba\"Prueba\"");
			
			Console.WriteLine("Uso del //");
			Console.WriteLine("Prueba\\Prueba\\Prueba\\");
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}