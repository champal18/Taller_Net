using System;
class Program
{
	public delegate void PrecioCambiadoEventHandler();
	
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
	
	public static void precioCambiado(object sender, PrecioCambiadoEventArgs e){
		string texto="Artículo {0} valía {1} y ahora vale {2}";
		Console.WriteLine(texto,e.Codigo,e.PrecioAnterior,e.PrecioNuevo);
	}
}

