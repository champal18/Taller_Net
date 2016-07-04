/*
 * Created by SharpDevelop.
 * User: Champal
 * Date: 25/4/2016
 * Time: 17:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ej9
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Matriz A=new Matriz(2,3);
			for(int i=0;i<6;i++) A.setElemento(i/3,i%3,(i+1)/3.0);
			Console.WriteLine("Impresión de la matriz A");
			//A.imprimir("0.000");
			A.imprimir();
			
			double[,] aux=new double[,] {{1,2,3},{4,5,6},{7,8,9}};
			Matriz B=new Matriz(aux);
			Console.WriteLine("\nImpresión de la matriz B");
			B.imprimir();
			
			Console.WriteLine("\nAcceso al elemento B[1,2]={0}",B.getElemento(1,2));
			
			Console.Write("\nfila 1 de A: ");
			foreach(double d in A.getFila(1)) Console.Write("{0:0.0} ",d);
			
			Console.Write("\n\nColumna 0 de B: ");
			foreach(double d in B.getColumna(0)) Console.Write("{0} ",d);
			
			Console.Write("\n\nDiagonal principal de B: ");
			foreach(double d in B.getDiagonalPpal()) Console.Write("{0} ",d);
			
			Console.Write("\n\nDiagonal secundaria de B: ");
			foreach(double d in B.getDiagonalSec()) Console.Write("{0} ",d);
			
			A.multiplicacion(B);
			Console.WriteLine("\n\nA multiplicado por B");
			A.imprimir();
			
			Console.Write("Press any key to continue . . . ");
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
		
		public void setElemento(int fila, int columna, double elem)
		{
			this.matriz[fila,columna] = elem;
		}
		
		public double getElemento(int fila, int columna)
		{
			return this.matriz[fila,columna];
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
		
		public double[] getDiagonalPpal()
		{
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
		
		public double[] getDiagonalSec()
		{
			double[] resultado = new double[this.matriz.GetLength(0)];
			if(this.matriz.GetLength(0) == this.matriz.GetLength(1))
			{
				//for(int i=this.matriz.GetLength(0);i>=0;i--)
				//	for(int j=0;j<this.matriz.GetLength(0);j++)
				//		if(this.matriz.GetLength(0)-1-i == j)
				//			resultado[j] = this.matriz[i,j];
				
				for(int i=0;i<this.matriz.GetLength(0);i++)
				{
					for(int j=this.matriz.GetLength(0);j>=0;j--)
						if(this.matriz.GetLength(0)-1-j == i)
							resultado[i] = this.matriz[i,j];
				}
				
				
				return resultado;
			}
			else
				return null;
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
	}
}