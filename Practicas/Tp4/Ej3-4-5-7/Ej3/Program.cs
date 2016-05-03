/*
 * Created by SharpDevelop.
 * User: Champal
 * Date: 25/4/2016
 * Time: 14:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Text;

namespace Ej3
{
	class Program
	{
		public static void Main(string[] args)
		{
			// Ejercicio 3 y 4
			
			Console.WriteLine("Ingrese cantidad de personas");
			int cant = int.Parse(Console.ReadLine());
			Persona[] array = new Persona[cant];
			Console.WriteLine("Ingrese datos en el formato correcto");
			String dato;
			for(int i=0;i<cant;i++)
			{
				dato = Console.ReadLine();
				String nombre = null;
				int edad = 0;
				int dni = 0;
				int j = 0;
				string aux = null;
				while(dato[j] != '\t')
				{
					nombre+=dato[j];
					j++;
				}
				j++;
				while(dato[j] != '\t')
				{
					aux+=dato[j];
					j++;
				}
				dni = int.Parse(aux);
				aux = null;
				j++;
				while(j<dato.Length)
				{
					aux+=dato[j];
					j++;
				}
				edad = int.Parse(aux);
				array[i] = new Persona(nombre,edad,dni);
			}
			
			for(int j=0;j<cant;j++)
			{
				array[j].imprimir(j);
			}
			
			// Ejercicio 5
			
			for(int j=0;j<cant;j++)
			{
				array[j].cumple();
				array[j].imprimir(j);
			}
			
			// Ejercicio 7
			
			Persona p = array[0];
			for(int j=1;j<cant;j++)
			{
				Console.WriteLine(p.esMayorQue(array[j]));
			}
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
	
	class Persona
	{
		private String Nombre;
		private int edad;
		private int DNI;
		
		public Persona(String nom, int edad, int dni)
		{
			this.Nombre = nom;
			this.edad = edad;
			this.DNI = dni;
		}
		
		public String getNombre()
		{
			return this.Nombre;
		}
		
		public int getEdad()
		{
			return this.edad;
		}
		
		public int getDNI()
		{
			return this.DNI;
		}
			
		public void imprimir(int num)
		{
			Console.WriteLine("{0}) {1} ({2})		{3}",num,this.Nombre,this.edad,this.DNI);
		}
		
		// Ejercicio 5
		public void cumple()
		{
			this.edad++;
		}
		
		// Ejercicio 7
		public bool esMayorQue(Persona p)
		{
			if(this.edad>p.getEdad())
				return true;
			else
				return false;
		}
	}
}