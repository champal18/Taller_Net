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

namespace Ejercicio1
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	/// 
	
	public partial class MainForm : Form
	{	
		public DataTable dt=new DataTable("MiTabla");//Se instancia la tabla dt cuyo TableName es "MiTabla"
		public DataSet ds= new DataSet("MiDataSet");
		//public int eliminar; 
			
		public MainForm()
		{
			
			
			//Agrego las correpondientes columnas
			dt.Columns.Add("Nombre", typeof(string));
			dt.Columns.Add("Apellido", typeof(string));
			dt.Columns.Add("Edad", typeof(int));
			
			
			//Agrego filas de prueba
			dt.Rows.Add("Alejandro","Garcia",33);
			dt.Rows.Add("Jose","Perez",33);
			dt.Rows.Add("Ana","Rodriguez",33);
			
			ds.Tables.Add(dt);
			
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			if(dt.Rows.Count==0)
			{	button2.Enabled=false;
				button3.Enabled=false;
			}
			else
			{
				button2.Enabled=true;
				button3.Enabled=true;
			}
			
			//foreach(DataRow f in dt.Rows)
			//{
			//	textBox1.Text += f["Columna2"]+"\r\n";
			//}
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			
		}
		
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
			dataGridView1.DataSource=ds.Tables["MiTabla"];
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			//dt.Rows.Add("Fulanito","Garcia",33);
			//w=int.Parse(textBox1.Text);
			//dt.Rows.Add(textBox1.Text,textBox2.Text,int.Parse(textBox3.Text));
			
			//Limpio los controles de los textbox
			
			
			try
			{	
				if (int.Parse(textBox3.Text)<0)
				{
					byte b=255;
					b++;
				}
				dt.Rows.Add(textBox1.Text,textBox2.Text,int.Parse(textBox3.Text));
				button2.Enabled=true;
				button3.Enabled=true;
				
			}
			catch
			{
				MessageBox.Show("Ingreso de datos incorrecto. Por favor intentelo de nuevo");
			}
			textBox1.Text=null;
			textBox2.Text=null;
			textBox3.Text=null;
			
			
		}
		
		void TextBox1TextChanged(object sender, EventArgs e) //Textbox nombre
		{
			if((textBox1.Text != "")&&(textBox2.Text != "")&&(textBox3.Text != ""))
				button1.Enabled=true;
			else
				button1.Enabled=false;
		}
		
		void TextBox2TextChanged(object sender, EventArgs e) //textbox apellido
		{
			if((textBox1.Text != "")&&(textBox2.Text != "")&&(textBox3.Text != ""))
				button1.Enabled=true;
			else
				button1.Enabled=false;
		}
		
		void TextBox3TextChanged(object sender, EventArgs e) //textbox edad
		{
			if((textBox1.Text != "")&&(textBox2.Text != "")&&(textBox3.Text != ""))
				button1.Enabled=true;
			else
				button1.Enabled=false;
		}
		
		void Button3Click(object sender, EventArgs e) //Boton borras todas las filas
		{
			if(MessageBox.Show("Desea borrar todas las filas?",
			                   "Confirmacion",MessageBoxButtons.YesNo)==DialogResult.Yes){
				
				dt.Rows.Clear();
				button2.Enabled=false;
				button3.Enabled=false;
				
			}
		}
		
		void Button2Click(object sender, EventArgs e) // boton Borrar fila
		{
			Form1 f=new Form1(dt.Rows.Count);
			
			//f.Show(this);
			
			if(f.ShowDialog()==DialogResult.OK)
			{	
				dt.Rows.RemoveAt(f.eliminar);
				if(dt.Rows.Count == 0)
				{
					button2.Enabled=false;
					button3.Enabled=false;
				}
			}
		
		}
		
		/*void DataGridView1RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			
			
				button2.Enabled=true;
				button3.Enabled=true;
			
		}
		
		void DataGridView1RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			if(dt.Rows.Count == 0)
			{
				button2.Enabled=false;
				button3.Enabled=false;
				
			}
		}*/
	}
	
	
}
