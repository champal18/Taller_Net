/*
 * Created by SharpDevelop.
 * User: Champal
 * Date: 3/5/2016
 * Time: 11:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ej1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Matriz A=new Matriz(3,3);
			for(int i=0;i<9;i++) A[i/3,i%3] = (i+1);
			Console.WriteLine("Impresión de la matriz A");
			A.imprimir();
			
			Console.Write("\nAcceso al elemento A[1,0]={0}",A[1,0]);
			
			Console.Write("\n\nDiagonal principal de A: ");
			foreach(double d in A.getDiagonalPpal) Console.Write("{0} ",d);
			
			Console.Write("\n\nDiagonal secundaria de A: ");
			foreach(double d in A.getDiagonalSec) Console.Write("{0} ",d);
			
			Console.ReadKey(true);
		}
	}
	
	class Matriz
	{
		private double[,] matriz;
		
		public Matriz(int filas, int columnas)
		{
			this.matriz = new double[filas,columnas];
		}
		
		public Matriz(double[,] matriz)
		{
			this.matriz = matriz;
		}
		
		/*
		public void setElemento(int fila, int columna, double elem)
		{
			this.matriz[fila,columna] = elem;
		}
		*/
		
		/*
		public double getElemento(int fila, int columna)
		{
			return this.matriz[fila,columna];
		}
		*/
		
		// Indizadores para get y set!
		public double this[int fila, int columna]
		{
			get
			{
				return this.matriz[fila,columna];
			}
			set
			{
				this.matriz[fila,columna] = value;
			}
		}
		
		public void imprimir()
		{
			for(int i=0;i<this.matriz.GetLength(0);i++)
			{
				for(int j=0;j<this.matriz.GetLength(1);j++)
					Console.Write("{0}-",this.matriz[i,j]);
				Console.Write("\n");
			}
		}
		
		public void imprimir(String formatString)
		{
			// ???
		}
		
		public double[] getFila(int fila)
		{
			double[] array = new double[this.matriz.GetLength(1)];
			for(int i=0;i<this.matriz.GetLength(1);i++)
				array[i] = this.matriz[fila,i];
			return array;
		}
		
		public double[] getColumna(int columna)
		{
			double[] array = new double[this.matriz.GetLength(1)];
			for(int i=0;i<this.matriz.GetLength(0);i++)
				array[i] = this.matriz[i,columna];
			return array;
		}
		
		public double[] getDiagonalPpal
		{
			get{
				double[] resultado = new double[this.matriz.GetLength(0)];
				if(this.matriz.GetLength(0) == this.matriz.GetLength(1))
				{
					for(int i=0;i<this.matriz.GetLength(1);i++)
						resultado[i] = this.matriz[i,i];
					return resultado;
				}
				else
					return null;
			}
		}
		
		public double[] getDiagonalSec
		{
			get{
				double[] resultado = new double[this.matriz.GetLength(0)];
				if(this.matriz.GetLength(0) == this.matriz.GetLength(1))
				{
					for(int i=this.matriz.GetLength(0);i>=0;i--)
						for(int j=0;j<this.matriz.GetLength(0);j++)
							if(this.matriz.GetLength(0)-1-i == j)
								resultado[j] = this.matriz[i,j];
					return resultado;
				}
				else
					return null;
			}
		}
		
		public double[][] getArreglo()
		{
			double[][] array = new double[this.matriz.GetLength(0)][];
			for(int i=0;i<this.matriz.GetLength(0);i++)
			{
				array[i] = new double[this.matriz.GetLength(1)];
				for(int j=0;j<this.matriz.GetLength(1);j++)
					array[i][j] = this.matriz[i,j];
			}
			return array;
		}
		
		public void suma(double[,] B)
		{
			if((this.matriz.GetLength(0) == B.GetLength(0)) && (this.matriz.GetLength(1) == B.GetLength(1)))
			{
				for(int i=0;i<this.matriz.GetLength(0);i++)
				{
					for(int j=0;j<this.matriz.GetLength(1);j++)
					{
						this.matriz[i,j] = this.matriz[i,j] + B[i,j];
					}
				}
			}
		}
		
		public void resta(double[,] B)
		{
			if((this.matriz.GetLength(0) == B.GetLength(0)) && (this.matriz.GetLength(1) == B.GetLength(1)))
			{
				for(int i=0;i<this.matriz.GetLength(0);i++)
				{
					for(int j=0;j<this.matriz.GetLength(1);j++)
					{
						this.matriz[i,j] = this.matriz[i,j] - B[i,j];
					}
				}
			}
		}
		/*
		public void multiplicacion(Matriz B)
		{
			if(this.matriz.GetLength(1) == B.getFila(0).Length)
			{
				double[,] C = new double[this.matriz.GetLength(0),B.getColumna(1).Length];
				int inner = this.matriz.GetLength(1);
				for(int i=0;i<this.matriz.GetLength(0);i++)
				{	
					for(int j=0;j<B.getColumna(1).Length;j++)
					{
						for(int k=0;k<inner;k++)
						{
							C[i,j] += this.matriz[i,k]*B.getElemento(k,j);
						}
					}
				}
				this.matriz = C;
			}
		}
		*/
	}
}