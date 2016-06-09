/*
 * Created by SharpDevelop.
 * User: Facu
 * Date: 05/06/2016
 * Time: 07:29 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio17
{
	class Program
	{
		enum Dias{lunes,martes,miercoles,jueves,viernes};
		public static void Main(string[] args)
		{
			
			
			Dias d;

			 //foreach(Dias d in Dias) Console.WriteLine(d); // Error	-> no se puede recorrer así un enum
			// for(int i=0;i< Dias.Lenght;i++) Console.WriteLine((Dias)i); // Error -> no exciste Dias.Length();
			for(d=Dias.lunes;d<=Dias.viernes;d++) Console.WriteLine(d);
			Console.ReadKey(true);
		}
	}
}