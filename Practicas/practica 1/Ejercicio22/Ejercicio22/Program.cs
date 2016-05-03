/*
 * Created by SharpDevelop.
 * User: Facu
 * Date: 03/05/2016
 * Time: 01:12 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio22
{
	class Program
	{
		public static void Main(string[] args) 
		{ 
			int i=1; 
			if (--i==0){ 
				Console.WriteLine("cero"); 
			} 
			if (i++==0){ 
				Console.WriteLine("cero"); 
			} 
			Console.WriteLine(i); 
			Console.ReadKey(); 
		} 

	
	}
}