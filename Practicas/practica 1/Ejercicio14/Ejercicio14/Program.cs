/*
 * Created by SharpDevelop.
 * User: Facu
 * Date: 19/05/2016
 * Time: 02:55 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio14
{
	class Program
	{
		public static void Main(string[] args)
		{
			string st;
			int n;
			int i;
			Console.WriteLine("Ingrese numero");
			st=Console.ReadLine();
			n=int.Parse(st);
			Console.WriteLine("Los divisores del numero ingresado son:");
			for(i=1;i<=n;i++){
				if(n%i==0)
				{
					Console.WriteLine(i);
				}
				
			}
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}