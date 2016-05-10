/*
 * Created by SharpDevelop.
 * User: Facu
 * Date: 09/05/2016
 * Time: 10:23 p.m.
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
			
			Taxi t=new Taxi();
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
	
	class Auto{
			private string marca;
			public Auto(string marca){
				this.marca=marca;
			}
			public Auto(){ }

	}
		
	class Taxi:Auto
	{
		
	}
	
}