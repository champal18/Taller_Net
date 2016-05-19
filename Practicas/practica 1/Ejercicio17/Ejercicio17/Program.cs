/*
 * Created by SharpDevelop.
 * User: Facu
 * Date: 19/05/2016
 * Time: 03:06 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio17
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Ingrese a y luego b");
			
			string st1=Console.ReadLine();
			string st2=Console.ReadLine();
			double a=double.Parse(st1);
			double b=double.Parse(st2);
			double c=a/b;			
			int res=Convert.ToInt32(c);
			Console.WriteLine("El resultado de dividir a/b, expresado en entero es:"+res);
			
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}