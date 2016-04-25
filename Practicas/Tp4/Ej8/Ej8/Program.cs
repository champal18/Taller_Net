/*
 * Created by SharpDevelop.
 * User: Champal
 * Date: 25/4/2016
 * Time: 16:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ej8
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			ArbolBinario arbol = new ArbolBinario();
			
			Console.WriteLine("Ingrese numeros menores a 99");
			int k = int.Parse(Console.ReadLine());
			while(k != 99)
			{
				arbol.insertar(k);
				k = int.Parse(Console.ReadLine());
			}
			
			Console.WriteLine("\nAltura: {0}", arbol.altura());
			Console.WriteLine("\nMaximo: {0}", arbol.valorMax());
			Console.WriteLine("\nMinimo: {0}", arbol.valorMin());
			Console.WriteLine("\nCantidad: {0}", arbol.cantNodos());
			
			int[] array = arbol.recorridoInOrden();
			Console.WriteLine("\nRecorrido In Orden:\n");
			for(int i=0;i<array.Length;i++)
				Console.Write("{0}-",array[i]);
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
	
	class Nodo
	{
		public int dato;
		public Nodo hijoIzq;
		public Nodo hijoDer;
	
		public Nodo(int num)
		{
			this.dato = num;
			this.hijoIzq = null;
			this.hijoDer = null;
		}
	}
	
	class ArbolBinario
	{
		Nodo raiz = null;
		
		public void insertar(int num)
		{
			Nodo nuevo = new Nodo(num);
			if(raiz == null)
			{
				this.raiz = nuevo;
			}
			else
			{
				Nodo anterior = null, reco;
				reco = raiz;
				while(reco != null)
				{
					anterior = reco;
					if(num<reco.dato)
						reco = reco.hijoIzq;
					else
						reco = reco.hijoDer;
				}
				if(num<anterior.dato)
					anterior.hijoIzq = nuevo;
				else
					anterior.hijoDer = nuevo;
				
			}
		}
		
		private void recorridoInOrden(Nodo reco, ref int[] array, ref int pos)
		{
			if(reco!=null)
			{
				recorridoInOrden(reco.hijoIzq, ref array, ref pos);
				array[pos] = reco.dato;
				pos++;
				recorridoInOrden(reco.hijoDer, ref array, ref pos);
			}
		}
		
		public int[] recorridoInOrden()
		{
			int pos = 0;
			int[] array = new int[this.cantNodos()];
			this.recorridoInOrden(raiz, ref array, ref pos);
			return array;
		}
		
		
		private void cantidad(Nodo reco, ref int cant)
		{
			if(reco!=null)
			{
				cant++;
				cantidad(reco.hijoIzq, ref cant);
				cantidad(reco.hijoDer, ref cant);
			}
		}
		
		public int cantNodos()
		{
			int cant = 0;
			cantidad(raiz, ref cant);
			return cant;
		}
		
		private void altura(Nodo reco,int nivel, ref int alto)
		{
			if(reco!=null)
			{
				altura(reco.hijoIzq,(nivel+1), ref alto);
				if(nivel>alto)
				{
					alto = nivel;
				}
				altura(reco.hijoDer, (nivel+1), ref alto);
			}
		}
		
		public int altura()
		{
			int alto = 0;
			altura(raiz,0, ref alto);
			return alto;
		}
		
		public int valorMax()
		{
			Nodo reco = raiz;
			while(reco.hijoDer!=null)
				reco = reco.hijoDer;
			return reco.dato;
		}
		
		public int valorMin()
		{
			Nodo reco = raiz;
			while(reco.hijoIzq!=null)
				reco = reco.hijoIzq;
			return reco.dato;
		}
		
	}
}