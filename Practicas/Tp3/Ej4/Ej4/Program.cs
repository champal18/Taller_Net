/*
 * Created by SharpDevelop.
 * User: Champal
 * Date: 15/4/2016
 * Time: 18:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Text;

namespace Ej4
{
	class Program
	{
		public static void Main(string[] args)
		{
			StringBuilder[] strArray;
			int linea = 10;							// Cantidad maxima de lineas
			strArray = new StringBuilder[linea];	// Arreglo donde guardo cada cadena ingresada
			int cant = 0;							// cantidad de cadenas ingresadas hasta el momento
			Console.CursorVisible = true;
			int cursorL = Console.WindowWidth-1;	// Guardo la posicion final del cursor
			ConsoleKeyInfo k = Console.ReadKey(true);
			while((cant!=linea) && (k.Key != ConsoleKey.Escape))	// Mientras no se cargue el total de lineas o se presione Escape
			{
				StringBuilder str = new StringBuilder();
				while(k.Key != ConsoleKey.Enter)			// Mientras no se presione Enter
				{
					Console.CursorTop = 0;					// Posiciono el cursor en la linea 0
					Console.CursorLeft = cursorL;			// Posiciono el cursor en el final de la linea
					Console.Write(k.KeyChar);
					cursorL= cursorL-1;						// Guardo la posicion anterior del cursor
					String st = new string(k.KeyChar,1);	// Cadena auxiliar para ir almacenando los caracteres
					str.Insert(0,st,1);						// Almaceno el valor ingresado al principio de la cadena
					k = Console.ReadKey(true);
				}
				Console.Clear();					// Limpio la consola
				strArray[linea-cant-1] = str;		// Guardo la cadena ingresada, comenzando de la ultima posicion del array hacia el inicio
				cant++;
				int cursorT = cant;
				for(int i=0;i<cant;i++)				// Muestro cada cadena almacenada en el array
				{
					Console.CursorTop = cursorT;
					Console.Write(strArray[linea-i-1]);
					cursorT--;
					Console.CursorLeft = 0;
				}
				
				Console.CursorTop = 0;				// Vuelvo a colocar los cursor al final de la linea 0.
				cursorL = Console.WindowWidth-1;
				Console.CursorLeft = cursorL;
				if(cant!=linea)
					k = Console.ReadKey(true);
			}
			
			Console.CursorLeft = 0;
			Console.CursorTop = linea+1;
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}