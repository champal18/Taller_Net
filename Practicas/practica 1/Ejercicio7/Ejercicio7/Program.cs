/*
 * Created by SharpDevelop.
 * User: Facu
 * Date: 07/04/2016
 * Time: 06:55 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio7
{
	class Program
	{
		public static void Main(string[] args)
		{
			string nombre;
			Console.WriteLine("Ingrese su nombre");
			nombre=Console.ReadLine();
			
			/*if (nombre=="Juan")
				Console.WriteLine("Hola amigo!Me alegro de verte");
			else
				if(nombre=="Maria")
					Console.WriteLine("Buen dia señora");
				else
					if(nombre=="Alberto")
						Console.WriteLine("Hola Alberto,que tenga usted un buen dia");
					else
						if(nombre=="")
							Console.WriteLine("Hola mundo");
						else
							Console.WriteLine("Hola "+nombre);
			*/
			switch(nombre)
			{
					case "Juan":
					Console.WriteLine("Hola amigo!Me alegro de verte");
					break;

					case "Maria":
					Console.WriteLine("Buen dia señora");
					break;
					
					case "Alberto":
					Console.WriteLine("Hola Alberto,que tenga usted un buen dia");
					break;
					
					case "":
					Console.WriteLine("Hola mundo");
					break;

					default:
					Console.WriteLine("Hola "+nombre);
					break;
			}
			
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}