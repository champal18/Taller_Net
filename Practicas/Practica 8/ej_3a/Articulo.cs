
using System;

namespace ej_3
{
	/// <summary>
	/// Description of Articulo.
	/// </summary>
	public class Articulo
	{
		private int codigo;
		private float precio;
		
		public int Codigo
		{
			get{
				return codigo;
			}
			set{
				codigo = value;
			}
		}
		
		public float Precio
		{
			get{
				return precio;
			}
			set{
				precio = value;
			}
		}
		
		
		public Articulo()
		{
		}
		
		public event PrecioCambiado precioCambiado{
			add{
				
			}
			
			remove{
				
			}
		}
	}
}
