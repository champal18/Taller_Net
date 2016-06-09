/*
 * Created by SharpDevelop.
 * User: Facu
 * Date: 05/06/2016
 * Time: 06:46 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace Ejercicio13
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			string st;
			ArrayList arrayList=new ArrayList();
			int j=0;
			Console.WriteLine("Ingrese Apellido y Documento");
			st=	Console.ReadLine();
			while(st!=""){
				arrayList.Add(st);
				st=	Console.ReadLine();
			}
			
			for(int i=0;i<=arrayList.Count;i++){
			
				st=arrayList.RemoveAt(i);
				
				while(st[j]!='\t'){
					j++;
				}
				
				for(j;j<=st.Length;j++){
				
					Console.Write(st[j]);
				}
				Console.WriteLine();
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}