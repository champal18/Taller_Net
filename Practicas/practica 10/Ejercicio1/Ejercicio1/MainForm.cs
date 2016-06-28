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
	public partial class MainForm : Form
	{	
		DataTable dt=new DataTable("MiTabla");//Se instancia la tabla dt cuyo TableName es "MiTabla"
		DataSet ds= new DataSet("MiDataSet");
			
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
				dt.Rows.Add(textBox1.Text,textBox2.Text,int.Parse(textBox3.Text));
			}
			catch
			{
				MessageBox.Show("Ingreso incorrecto de datos, vuelva a intentarlo");
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
				
				
			}
		}
		
		void Button2Click(object sender, EventArgs e) // boton Borrar fila
		{
			Form f=new Form();
		
			Label label9 = new System.Windows.Forms.Label();
			
			f.Controls.Add(label9);
				
			label9.Location = new System.Drawing.Point(50, 10);
			label9.Name = "label1";
			label9.Size = new System.Drawing.Size(300, 300);
	
			label9.Text = "Indique el numero de fila que desea eliminar de la tabla";
				
				
			
			if(f.ShowDialog()==DialogResult.OK)
				MessageBox.Show("Aceptaron");
		
			
		
		}
	}
	
	
}
