/*
 * Created by SharpDevelop.
 * User: Facu
 * Date: 09/05/2016
 * Time: 02:42 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio1
{
	class Program
	{
		public static void Main(string[] args)
		{
			// TODO: Implement Functionality Here
			
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
				float prom= 0;
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
				edad = int.Parse(aux);
				aux = null;
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
				prom = float.Parse(aux);
				
				array[i] = new Alumno(nombre,edad,dni,prom);
			}
			
			for(int j=0;j<cant;j++)
			{
				array[j].imprimir(j+1);
			}
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
	
	
	class Persona
	{
		protected string nombre;
		protected int edad;
		protected int DNI;
		
		public Persona(string nom, int edad, int dni)
		{
			this.nombre = nom;
			this.edad = edad;
			this.DNI = dni;
		}
		
		public string getNombre()
		{
			return this.nombre;
		}
		
		public int getEdad()
		{
			return this.edad;
		}
		
		public int getDNI()
		{
			return this.DNI;
		}
			
		public virtual void imprimir(int num)
		{
			Console.WriteLine("{0}) {1} ({2})		{3}",num,this.nombre,this.edad,this.DNI);
		}	
	}
	
	
	class Alumno:Persona
	{
		private float promedio;
		
		public Alumno(string nom, int edad, int dni, float prom):base(nom,edad,dni)
		{
			this.promedio = prom;
		}
		
		/*public String getNombre()
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
		}*/
			
		public override void imprimir(int num)
		{
			Console.WriteLine("{0}) ALUMNO: {1} ({2})		{3}  {4}",num,this.nombre,this.edad,this.DNI,this.promedio);
		}	
	}
	
	
	
	
}