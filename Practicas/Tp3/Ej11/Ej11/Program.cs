/*
 * Created by SharpDevelop.
 * User: Champal
 * Date: 3/5/2016
 * Time: 11:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.IO;

namespace Ej11
{
	class Program
	{
		public static void Main(string[] args)
		{
			StreamWriter destino = new StreamWriter("destino.txt");
			
			byte[]letras=new byte[]{(byte)'A',(byte)'B'}; // El de mas arriba es el bit mas significativo
			BitArray ba= new BitArray(letras); 
			
			for(int i=0;i<ba.Count;i++){
				Console.WriteLine ("posicion {0,2} valor {1}", i, ba[i]);
				destino.WriteLine("posicion {0,2} valor {1}", i, ba[i]);
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
			destino.Close();
		}
	}
}