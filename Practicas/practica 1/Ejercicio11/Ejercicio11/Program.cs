/*
 * Created by SharpDevelop.
 * User: Facu
 * Date: 19/04/2016
 * Time: 02:31 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio11
{
	class Program
	{
		public static void Main(string[] args)
		{
			string st;
		
			int cant;
			int i=0;
			bool ok=true;
			
			Console.WriteLine("Ingresar la cadena para determinar simetria");
			st=Console.ReadLine();
			cant=st.Length;
			
			if(cant%2 != 1)
				Console.WriteLine("La cadena NO es simetrica");
			else
			{
				while((ok) && (i<(cant/2)))
				{
					if (st[i] != st[cant-1-i]){
						ok=false;
					}
					//Console.WriteLine("letra "+st[i]);
					//Console.WriteLine("letra "+st[cant-1-i]);
					i=i+1;
					
				}
				if (ok)
					Console.WriteLine("La cadena es simetrica");
				else
					Console.WriteLine("La cadena NO es simetrica");
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}