/*
 * Created by SharpDevelop.
 * User: Facu
 * Date: 19/05/2016
 * Time: 02:59 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio15
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Ingrese numeros");
			string st1;
			string st2;
			st1=Console.ReadLine();
			st2=Console.ReadLine();
			double n1=double.Parse(st1);
			double n2=double.Parse(st2);
			double n3=n1+n2;
			Console.WriteLine("El resultado de sumar ambos numeros es:"+n3);
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}