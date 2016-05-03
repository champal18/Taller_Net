/*
 * Created by SharpDevelop.
 * User: Facu
 * Date: 03/05/2016
 * Time: 02:40 a.m.
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
			int[] v1= new int[1] {1}; 
			int[] v2=v1; 
			v1[0] = 2; 
			Console.Write(v1[0]); 
			Console.WriteLine(" " + v2[0]); 
			object obj1 = 1; 
			object obj2 = obj1; 
			obj1 = 2; 
			Console.Write(obj1); 
			Console.WriteLine(" " + obj2); 
			Console.ReadKey(); 

		}
	}
}