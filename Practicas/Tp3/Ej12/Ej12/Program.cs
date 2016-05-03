/*
 * Created by SharpDevelop.
 * User: Champal
 * Date: 3/5/2016
 * Time: 11:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace Ej12
{
	class Program
	{
		public static void Main(string[] args)
		{
			string st1= Console.ReadLine();
			string st2= Console.ReadLine();
			
			byte[]letras=new byte[st1.Length];
			byte[]letras2=new byte[st2.Length];			// El de mas arriba es el bit mas significativo
			
			for(int i=0;i<st1.Length;i++){
				letras[i]=(byte)st1[i];
			}
			for(int i=0;i<st2.Length;i++){
				letras2[i]=(byte)st2[i];
			}
			BitArray ba= new BitArray(letras);
			BitArray ba2= new BitArray(letras2);
			ba.And(ba2);
			
			for (int i=0;i<ba.Count;i++)
			{
				Console.WriteLine(ba[i]);
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}