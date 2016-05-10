/*
 * Created by SharpDevelop.
 * User: Facu
 * Date: 09/05/2016
 * Time: 09:56 p.m.
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
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
	class Auto{ 
		protected double velocidad; 
		public virtual void acelerar()
		{
			Console.WriteLine("Velocidad = {0}", velocidad+=10); 
		} 
	} 
		
	class Taxi:Auto{
		public override void acelerar() 
		{ 
			Console.WriteLine("Velocidad = {0}", velocidad+=5); 
		} 
	} 

}