/*
 * Created by SharpDevelop.
 * User: Facu
 * Date: 07/04/2016
 * Time: 06:37 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio6
{
	class Program
	{
		public static void Main(string[] args)
		{
			string nombre;
			Console.WriteLine("Ingrese su nombre");
			nombre=Console.ReadLine();
			if (nombre=="")
			{
				Console.WriteLine("Hola mundo");
			}
			else
			{
				Console.WriteLine("Bienvenido "+nombre);
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}