using System;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Drawing;
using System.Collections;
using System.Windows;


/*
 * Created by SharpDevelop.
 * User: Champal
 * Date: 22/5/2016
 * Time: 13:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Ej1
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		private ArrayList files_path = new ArrayList();
		private ArrayList files_names = new ArrayList();
		private int intervalo = 2;
		
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.abrirCarpetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.visualizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ajustarVentanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.verListaDeImagenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.presentacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.intervaloDePresentacionToolStripMenuItem = new System.Windows.Forms.ToolStripComboBox();
			this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
			this.panel1 = new System.Windows.Forms.Panel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripMenuItem1,
									this.visualizacionToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(284, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1ItemClicked);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.abrirCarpetaToolStripMenuItem,
									this.toolStripSeparator1,
									this.salirToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
			this.toolStripMenuItem1.Text = "Archivo";
			this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1Click);
			// 
			// abrirCarpetaToolStripMenuItem
			// 
			this.abrirCarpetaToolStripMenuItem.Name = "abrirCarpetaToolStripMenuItem";
			this.abrirCarpetaToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
			this.abrirCarpetaToolStripMenuItem.Text = "Abrir carpeta";
			this.abrirCarpetaToolStripMenuItem.Click += new System.EventHandler(this.Button_AbrirCarpeta_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(139, 6);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.Button_Exit_Click);
			// 
			// visualizacionToolStripMenuItem
			// 
			this.visualizacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.ajustarVentanaToolStripMenuItem,
									this.toolStripSeparator2,
									this.verListaDeImagenesToolStripMenuItem,
									this.toolStripSeparator3,
									this.presentacionToolStripMenuItem,
									this.intervaloDePresentacionToolStripMenuItem});
			this.visualizacionToolStripMenuItem.Name = "visualizacionToolStripMenuItem";
			this.visualizacionToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
			this.visualizacionToolStripMenuItem.Text = "Visualizacion";
			// 
			// ajustarVentanaToolStripMenuItem
			// 
			this.ajustarVentanaToolStripMenuItem.Name = "ajustarVentanaToolStripMenuItem";
			this.ajustarVentanaToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
			this.ajustarVentanaToolStripMenuItem.Text = "Ajustar ventana";
			this.ajustarVentanaToolStripMenuItem.Click += new System.EventHandler(this.Button_Ajustar_Img_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(264, 6);
			// 
			// verListaDeImagenesToolStripMenuItem
			// 
			this.verListaDeImagenesToolStripMenuItem.Checked = true;
			this.verListaDeImagenesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.verListaDeImagenesToolStripMenuItem.Name = "verListaDeImagenesToolStripMenuItem";
			this.verListaDeImagenesToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
			this.verListaDeImagenesToolStripMenuItem.Text = "Ver lista de imagenes";
			this.verListaDeImagenesToolStripMenuItem.Click += new System.EventHandler(this.Button_Ocultar_Lista_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(264, 6);
			// 
			// presentacionToolStripMenuItem
			// 
			this.presentacionToolStripMenuItem.Enabled = false;
			this.presentacionToolStripMenuItem.Name = "presentacionToolStripMenuItem";
			this.presentacionToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
			this.presentacionToolStripMenuItem.Text = "Presentacion";
			this.presentacionToolStripMenuItem.Click += new System.EventHandler(this.Button_Presentacion_Click);
			// 
			// intervaloDePresentacionToolStripMenuItem
			// 
			this.intervaloDePresentacionToolStripMenuItem.Name = "intervaloDePresentacionToolStripMenuItem";
			this.intervaloDePresentacionToolStripMenuItem.Size = new System.Drawing.Size(207, 23);
			this.intervaloDePresentacionToolStripMenuItem.Text = "Intervalo de presentacion";
			this.intervaloDePresentacionToolStripMenuItem.Click += new System.EventHandler(this.IntervaloDePresentacionToolStripMenuItemClick);
			// 
			// vScrollBar1
			// 
			this.vScrollBar1.Location = new System.Drawing.Point(0, 0);
			this.vScrollBar1.Name = "vScrollBar1";
			this.vScrollBar1.Size = new System.Drawing.Size(17, 80);
			this.vScrollBar1.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.splitContainer1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(284, 237);
			this.panel1.TabIndex = 1;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.listBox1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
			this.splitContainer1.Size = new System.Drawing.Size(284, 237);
			this.splitContainer1.SplitterDistance = 94;
			this.splitContainer1.TabIndex = 0;
			// 
			// listBox1
			// 
			this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(0, 0);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(94, 237);
			this.listBox1.TabIndex = 0;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1SelectedIndexChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(186, 237);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 240);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(284, 21);
			this.panel2.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(284, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "Path";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Ej1";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.VScrollBar vScrollBar1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripComboBox intervaloDePresentacionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem presentacionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem verListaDeImagenesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ajustarVentanaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem visualizacionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem abrirCarpetaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		
		void ToolStripMenuItem1Click(object sender, System.EventArgs e)
		{
			
		}
		
		void IntervaloDePresentacionToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			this.intervalo = (int)(intervaloDePresentacionToolStripMenuItem.SelectedItem as ComboboxItem).Value;
		}
		
		void MainFormLoad(object sender, System.EventArgs e)
		{
			
		}
		
		void ListBox1SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
			String aux = listBox1.SelectedItem.ToString();
			int i=0;
			while(i<files_path.Count)
			{
				if(files_names[i].Equals(aux))
				{
					aux = (string)files_path[i];
					i = files_names.Count + 1;
				}
				else
					i++;
			}
			
			pictureBox1.Image = Image.FromFile(aux);
			
			label1.Text = aux;
		}
		
		void ToolStripStatusLabel1Click(object sender, System.EventArgs e)
		{
			
		}
		
		void Label1Click(object sender, System.EventArgs e)
		{
			
		}
		
		void MenuStrip1ItemClicked(object sender, System.Windows.Forms.ToolStripItemClickedEventArgs e)
		{
			
		}
		
		void Button_AbrirCarpeta_Click(object sender, EventArgs e)
		{
			string[] aux_path;
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			if(fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				aux_path = Directory.GetFiles(fbd.SelectedPath);
				listBox1.Items.Clear();
				int j;
				for(j=0;j<aux_path.Length;j++)
				{
					string aux = Path.GetExtension(aux_path[j]);
					if((aux.Equals(".jpg")) || (aux.Equals(".JPG")) || (aux.Equals(".bmp")) || (aux.Equals(".BMP")) || (aux.Equals(".png")) || (aux.Equals(".PNG")))
					{
						files_names.Add(Path.GetFileNameWithoutExtension(aux_path[j]));
						files_path.Add(aux_path[j]);
						listBox1.Items.Add(Path.GetFileNameWithoutExtension(aux_path[j]));
					}
				}
				this.presentacionToolStripMenuItem.Enabled = true;
			}
		}
		
		void Button_Ajustar_Img_Click(object sender, EventArgs e)
		{
			 pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
		}
		
		void Button_Ocultar_Lista_Click(object sender, EventArgs e)
		{
			listBox1.Visible = !listBox1.Visible;
		}
		
		void Button_Exit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		
		void Button_Presentacion_Click(object sender, EventArgs e)
		{
			Form1 presentacion = new Form1(intervalo,files_path);
			presentacion.Show(this);
		}
		
	}
	
	public class ComboboxItem
	{
		public string text {get;set;}
		public 	object Value {get;set;}
		
		public override string ToString()
		{
			return text;
		
		}
	}
	
}