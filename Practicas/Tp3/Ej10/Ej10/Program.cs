/*
 * Created by SharpDevelop.
 * User: Champal
 * Date: 16/4/2016
 * Time: 17:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.IO;

namespace Ej10
{
	class Program
	{
		public static void Main(string[] args)
		{
			// Creo un archivo de texto para guardar lo mostrado por consola
			StreamWriter destino = new StreamWriter("destino.txt");
			
			int[] vectorDeInt = new int[] {5,255};
			Console.WriteLine("BitArray construido a partir del vector de enteros {5,255}");
			destino.WriteLine("BitArray construido a partir del vector de enteros {5,255}");
			
			BitArray ba1=new BitArray(vectorDeInt);
			for(int i=0;i<ba1.Count;i++)
			{
				Console.WriteLine ("posicion {0,2} valor {1}", i, ba1[i]);
				destino.WriteLine("posicion {0,2} valor {1}", i, ba1[i]);
			}
			byte[] vectorDeByte = new byte[] {5,255};
			Console.WriteLine("BitArray construido a partir " +
								"del vector de bytes {5,255}");
			destino.WriteLine("BitArray construido a partir del vector de bytes {5,255}");
			
			BitArray ba2=new BitArray(vectorDeByte);
			for(int i=0;i<ba2.Count;i++)
			{
				Console.WriteLine ("posicion {0,2} valor {1}", i, ba2[i]);
				destino.WriteLine("posicion {0,2} valor {1}", i, ba2[i]);
			}
			Console.ReadKey(true);
			
			destino.Close();
		}
	}
}