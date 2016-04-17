/*
 * Created by SharpDevelop.
 * User: Champal
 * Date: 17/4/2016
 * Time: 13:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace Ej15
{
	class Program
	{
		public static void Main(string[] args)
		{
			Queue cola = new Queue();
			Queue cola2 = new Queue();
			int[] clave = {5,3,9,7};
			for(int i=0;i<clave.Length;i++)
			{
				cola.Enqueue(clave[i]);
				cola2.Enqueue(clave[i]);
			}
			Console.WriteLine("Ingrese cadena que desea codificar (SOLO letras en minusculas): \n");
			StringBuilder cadena = new StringBuilder(Console.ReadLine());
			
			StringBuilder msjCodificado = new StringBuilder();	// Codifica la cadena ingresada
			msjCodificado = codificar(cadena,cola);
			
			StringBuilder msjDecoficado = new StringBuilder();	// Decodifica la cadena que codificada para ver que es igual a la ingresada
			msjDecoficado = decodificar(msjCodificado,cola2);
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	
		public static int[] letraToNum(StringBuilder str)	// Paso la cadena de caracteres a numeros
		{
			char[] abc = {'0','a','b','c','d','e','f','g','h','i','j','k','l','m','n', 'ñ','o','p','q','r','s','t','u','v','w','x','y','z',' '};
			int[] resultado = new int[str.Length];
			for(int i=0;i<str.Length;i++)
			{
				bool ok = false;
				int cont = 0;
				while(!ok)
				{
					char a = str[i];
					if(str[i] == abc[cont])
					{
						resultado[i] = cont;
						ok = true;
					}
					else
						cont++;
					if(cont == 29)
					{
						Console.WriteLine("Mensaje mal ingresado, fin de aplicacion!");
						Console.ReadKey(true);
						System.Environment.Exit(0);
					}
				}
			}
			return resultado;
		}
		
		public static StringBuilder numToLetra(int[] cadenaNum)	// Paso la cadena de numeros a letras
		{
			char[] abc = {'0','a','b','c','d','e','f','g','h','i','j','k','l','m','n', 'ñ','o','p','q','r','s','t','u','v','w','x','y','z',' '};
			StringBuilder resultado = new StringBuilder();
			for(int i=0;i<cadenaNum.Length;i++)
			{
				resultado.Append(abc[cadenaNum[i]]);
			}
			
			return resultado;
		}
		
		public static StringBuilder codificar(StringBuilder str, Queue cola)
		{
			int[] cadenaNumerica = letraToNum(str);
			int[] cadenaCodificada = new int[str.Length];
			for(int i=0;i<cadenaNumerica.Length;i++)
			{
				int clave = (int)cola.Dequeue();
				int aux = cadenaNumerica[i] + clave;
				aux = aux%28;
				cadenaCodificada[i] = aux;
				cola.Enqueue(clave);
			}
			
			StringBuilder msjCodificado = new StringBuilder();
			msjCodificado = numToLetra(cadenaCodificada);
			Console.WriteLine("Mensaje codificado: \n");
			Console.WriteLine(msjCodificado);
			return msjCodificado;
		}
		
		public static StringBuilder decodificar(StringBuilder str, Queue cola)
		{
			int[] cadenaNumerica = letraToNum(str);
			int[] cadenaCodificada = new int[str.Length];
			for(int i=0;i<cadenaNumerica.Length;i++)
			{
				int clave = (int)cola.Dequeue();
				int aux;
				if(clave>cadenaNumerica[i])
				{
					aux = clave - cadenaNumerica[i];
					aux = 28 - aux;
				}
				else
				{
					if(clave==cadenaNumerica[i])
						aux = 28;
					else
						aux = cadenaNumerica[i] - clave;
				}
				cadenaCodificada[i] = aux;
				cola.Enqueue(clave);
			}
			
			StringBuilder msjCodificado = new StringBuilder();
			msjCodificado = numToLetra(cadenaCodificada);
			Console.WriteLine("Mensaje decodificado: \n");
			Console.WriteLine(msjCodificado);
			return msjCodificado;
		}
	
	}
}