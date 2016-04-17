/*
 * Created by SharpDevelop.
 * User: Champal
 * Date: 15/4/2016
 * Time: 20:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Collections;

namespace Ej5
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			String cadena = Console.ReadLine();		// Ingresar el nombre del archivo: nombre.extension
			StreamReader lector = new StreamReader(cadena);
			cadena = Console.ReadLine();
			StreamWriter escritor = new StreamWriter(cadena);
			ArrayList array = new ArrayList();
			while(!lector.EndOfStream)	// Mientras no se llegue al final del archivo lector
			{
				cadena = lector.ReadLine();
				if(array.Count == 0)	// Si es el primer elemento lo agrego al array
					array.Add(cadena);
				else	// Si existe mas de un elemento en el array
				{
					int i = 0;
					Boolean ok = false;
					while((i<array.Count) && !ok)	// Recorro el array en busca de la posicion del elemento
					{
						if(cadena.CompareTo(array[i]) == -1)
						{
							ok = true;
							array.Insert(i,cadena);
						}
						else
							i++;
					}
					if(i == array.Count)	// Si se llego al final coloco ahi el nuevo elemento
						array.Add(cadena);
				}
			}
			for(int i=0;i<array.Count;i++)		// Recorro el array y lo escribo en el archivo escritor
				escritor.WriteLine(array[i]);
			lector.Close();
			escritor.Close();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}