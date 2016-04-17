/*
 * Created by SharpDevelop.
 * User: Champal
 * Date: 16/4/2016
 * Time: 17:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace Ej13
{
	class Program
	{
		public static void Main(string[] args)
		{
			Stack pila = new Stack();
			int numero;
			int baseNueva;
			int resultado=0;
			Console.WriteLine("Ingrese numero");
			numero = int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese base nueva (divisor)");
			baseNueva = int.Parse(Console.ReadLine());
			int cociente = numero/baseNueva;
			while(cociente>=baseNueva)
			{
				resultado = numero%baseNueva;
				pila.Push(resultado);	// Guardo en la pila el resto de la divicion
				numero = cociente;
				cociente = numero/baseNueva;
			}
			pila.Push(resultado);		// Guardo el ultimo resto de la divicion
			Console.WriteLine("Resultado:");
			Console.Write(cociente);	// Imprimo el cociente
			while(pila.Count != 0)	// Mientras haya elementos en la pila los imprimo
			{
				Console.Write(pila.Pop());
			}
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}