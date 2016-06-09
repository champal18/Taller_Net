/*
 * Created by SharpDevelop.
 * User: Facu
 * Date: 05/06/2016
 * Time: 08:20 p.m.
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
			Console.WriteLine("Ingrese n: ");
			int n = int.Parse(Console.ReadLine());
			
			Console.WriteLine("Ingrese k: ");
			int k = int.Parse(Console.ReadLine());
			
			int numerador = factorial(n);
			int denominador = factorial(n-k) * factorial(k);
			
			float resultado = numerador / denominador;
			
			Console.WriteLine("Resultado {0}",resultado);
			Console.ReadKey(true);
		}
		
		
		public static int factorial(int numero){
			int i;
			int resultado = numero;
			
			for(i=1;i<numero;i++){
				resultado = resultado*i;
			}
			
			return resultado;
		}
	}
}