/*
 * Created by SharpDevelop.
 * User: Facu
 * Date: 07/04/2016
 * Time: 06:13 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio4
{
	class Program 
	{ 
		public static void Main(string[] args) 
		{ 
			for (int i=1;i<=10 ;i++ ) 
			{ 
				System.Console.WriteLine("Hola Mundo!\a"); 
				System.Threading.Thread.Sleep(500); 
			} 
			System.Console.WriteLine("Presione una tecla para continuar"); 
			System.Console.ReadKey(true); 
		} 
   } 

}