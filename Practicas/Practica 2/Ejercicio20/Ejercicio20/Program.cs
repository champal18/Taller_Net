/*
 * Created by SharpDevelop.
 * User: Facu
 * Date: 05/06/2016
 * Time: 08:07 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio20
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Ingrese un número");
			int numero = int.Parse(Console.ReadLine());
			
			int resultado;
			factorial(numero,out resultado);
			
			Console.WriteLine("Factorial: {0}",resultado);
			Console.ReadKey(true);
		}
		
		public static void factorial(int numero,out int resultado){
			int i;
			resultado = numero;
			
			for(i=1;i<numero;i++){
				resultado = resultado*i;
			}
		}
		
	}
}