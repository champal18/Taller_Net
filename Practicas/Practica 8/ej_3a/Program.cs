using System;
class Program
{
	public delegate void PrecioCambiadoEventHandler(object sender, PrecioCambiadoEventArgs e);
	
	public static void Main(string[] args) {
		Articulo a=new Articulo();
		a.PrecioCambiado += new PrecioCambiadoEventHandler(precioCambiado);
		a.Codigo = 1;
		a.Precio = 10;
		a.Precio = 12;
		a.Precio = 12;
		a.Precio = 14;
		Console.ReadKey(true);
	}
	
	public static void precioCambiado(object sender, PrecioCambiadoEventArgs e)
	{
		string texto="Artículo {0} valía {1} y ahora vale {2}";
		Console.WriteLine(texto,e.Codigo,e.PrecioAnterior,e.PrecioNuevo);
	}
	
	
	public class Articulo
	{
		private int codigo;
		private float precio;
		
		private PrecioCambiadoEventHandler precioCambiado;
		public event PrecioCambiadoEventHandler PrecioCambiado
		{
			add{precioCambiado += value;}
			remove{precioCambiado -= value;}
		}
		
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
			set
			{
				if(precio!=value)
				{
					if(precioCambiado!= null)
					{
						precioCambiado(this,new PrecioCambiadoEventArgs(){Codigo=this.codigo,PrecioAnterior=this.precio,PrecioNuevo=value});
					}
					precio = value;
				}
			}
		}
	}
	
}

class PrecioCambiadoEventArgs:EventArgs
{
	// e.Codigo,e.PrecioAnterior,e.PrecioNuevo
	public int Codigo {get;set;}
	public float PrecioAnterior {get;set;}
	public float PrecioNuevo {get;set;}
}

