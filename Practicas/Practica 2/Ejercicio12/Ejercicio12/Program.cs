/*
 * Created by SharpDevelop.
 * User: Facu
 * Date: 05/06/2016
 * Time: 06:27 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio12
{
	class Program
	{
		public static void Main(string[] args)
		{
			const int DIM = 10000000;
			int[] arreglo = new int[DIM];
			int i;
			
			DateTime startTime;
			DateTime endTime;
			TimeSpan totalTime;
			
			DateTime startTime2;
			DateTime endTime2;
			TimeSpan totalTime2;
			
			Random random = new Random();
			for (i=0;i<DIM;i++){
				arreglo[i]=random.Next(0,1000);
			}
			
			Array.Sort(arreglo);	// Ordena arreglo para poder usar la búsqueda binaria
			
			int numero_busqueda = random.Next(0,1000);
			
			// Búsqueda binaria
			startTime = DateTime.Now;	// Hora antes de ejecutar
			Array.BinarySearch(arreglo,numero_busqueda);
			endTime = DateTime.Now;		// Hora después de ejecutar
			totalTime = endTime.Subtract(startTime);	// Tiempo neto de ejecución
			Console.WriteLine("Tiempo ejecución con Búsqueda binaria: {0}",totalTime.ToString());
			
			// Búsqueda secuencial
			startTime2 = DateTime.Now;	// Hora antes de ejecutar
			for (i=0;i<DIM;i++){
				if (arreglo[i]==numero_busqueda){
					break;
				}
			}
			endTime2 = DateTime.Now;		// Hora después de ejecutar
			totalTime2= endTime2.Subtract(startTime2);	// Tiempo neto de ejecución
			Console.WriteLine("Tiempo ejecución con Búsqueda secuencial: {0}",totalTime2.ToString());
			
			Console.ReadKey(true);
		}
	}
}