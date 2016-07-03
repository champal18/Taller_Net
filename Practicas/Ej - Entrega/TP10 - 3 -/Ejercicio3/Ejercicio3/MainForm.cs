/*
 * Created by SharpDevelop.
 * User: Facu
 * Date: 26/06/2016
 * Time: 07:55 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Ejercicio3
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		DataSet ds= new DataSet("MiDataSet");
		
		public MainForm()
		{
			
			
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			DataTable tabla1=new DataTable("Clientes");//Se instancia la tabla dt cuyo TableName es "MiTabla"
			DataTable tabla2=new DataTable("Ordenes");
			
			
			
			//Agrego las correspondientes tablas
			tabla1.Columns.Add("idCliente", typeof(int));
			tabla1.Columns.Add("Apellido", typeof(string));
			tabla1.Columns.Add("Nombre", typeof(string));
			tabla1.Columns.Add("Direccion", typeof(string));
			tabla1.Columns.Add("Telefono", typeof(string));
			
			
			tabla2.Columns.Add("idCliente", typeof(int));
			tabla2.Columns.Add("idOrden", typeof(int));
			tabla2.Columns.Add("Fecha", typeof(string));
			tabla2.Columns.Add("Detalle", typeof(string));
			
			//Agrego datos de prueba
			
			tabla1.Rows.Add(1,"Fuentes","Facundo","Calle199","2944660690");
			tabla1.Rows.Add(2,"Labrune","Juan","Calle 56","221345678");
			tabla1.Rows.Add(3,"Campagna","Cristian","Calle 32","2216343690");
			tabla1.Rows.Add(4,"Borrajo","Manuel","Calle 65","11434660690");
			
		
			tabla2.Rows.Add(1,1,"15/5/55","detalle1");
			tabla2.Rows.Add(2,2,"17/10/89","detalle2");
			tabla2.Rows.Add(2,3,"23/9/00","detalle3");
			tabla2.Rows.Add(4,4,"1/7/13","detalle4");
			
			
			
			ds.Tables.Add(tabla1);
			ds.Tables.Add(tabla2);
			
			//Enlace de controles del formulario
			bindingSource1.DataSource=ds.Tables["Clientes"];
			
			dataGridView1.DataSource=bindingSource1;
			//dataGridView1.DataMember="relacion";
			
			//Relacion maestro-detalle
			DataColumn colPadre=ds.Tables["Clientes"].Columns["idCliente"];
			DataColumn colHija=ds.Tables["Ordenes"].Columns["idCliente"];
			DataRelation dr=new DataRelation("relacion",colPadre,colHija);
			ds.Relations.Add(dr);
			
			
			dataGridView2.DataSource=bindingSource1;
			dataGridView2.DataMember="relacion";
			
			ds.Relations["relacion"].Nested = true;
			ds.WriteXml("dataset.xml");
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			dataGridView1.DataSource=ds.Tables["Clientes"];
			dataGridView2.DataSource=ds.Tables["Ordenes"];
		}
	}
}
