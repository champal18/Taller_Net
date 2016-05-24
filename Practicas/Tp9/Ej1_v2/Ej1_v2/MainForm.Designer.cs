﻿/*
 * Created by SharpDevelop.
 * User: Champal
 * Date: 22/5/2016
 * Time: 21:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Ej1_v2
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(260, 237);
			this.panel1.TabIndex = 0;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.splitContainer1);
			this.panel4.Location = new System.Drawing.Point(3, 40);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(254, 157);
			this.panel4.TabIndex = 2;
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
			this.splitContainer1.Size = new System.Drawing.Size(254, 157);
			this.splitContainer1.SplitterDistance = 84;
			this.splitContainer1.TabIndex = 0;
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(3, 3);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(78, 147);
			this.listBox1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(160, 151);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.label1);
			this.panel3.Location = new System.Drawing.Point(6, 203);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(254, 31);
			this.panel3.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.menuStrip1);
			this.panel2.Location = new System.Drawing.Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(254, 31);
			this.panel2.TabIndex = 0;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.archivoToolStripMenuItem,
									this.visualizacionToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(254, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// archivoToolStripMenuItem
			// 
			this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.abrirCarpetaToolStripMenuItem,
									this.toolStripSeparator1,
									this.salirToolStripMenuItem});
			this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.archivoToolStripMenuItem.Text = "Archivo";
			// 
			// abrirCarpetaToolStripMenuItem
			// 
			this.abrirCarpetaToolStripMenuItem.Name = "abrirCarpetaToolStripMenuItem";
			this.abrirCarpetaToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
			this.abrirCarpetaToolStripMenuItem.Text = "Abrir carpeta";
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
			this.visualizacionToolStripMenuItem.Click += new System.EventHandler(this.VisualizacionToolStripMenuItemClick);
			// 
			// ajustarVentanaToolStripMenuItem
			// 
			this.ajustarVentanaToolStripMenuItem.Name = "ajustarVentanaToolStripMenuItem";
			this.ajustarVentanaToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
			this.ajustarVentanaToolStripMenuItem.Text = "Ajustar ventana";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(264, 6);
			// 
			// verListaDeImagenesToolStripMenuItem
			// 
			this.verListaDeImagenesToolStripMenuItem.Name = "verListaDeImagenesToolStripMenuItem";
			this.verListaDeImagenesToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
			this.verListaDeImagenesToolStripMenuItem.Text = "Ver lista de imagenes";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(264, 6);
			// 
			// presentacionToolStripMenuItem
			// 
			this.presentacionToolStripMenuItem.Name = "presentacionToolStripMenuItem";
			this.presentacionToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
			this.presentacionToolStripMenuItem.Text = "Presentacion";
			// 
			// intervaloDePresentacionToolStripMenuItem
			// 
			this.intervaloDePresentacionToolStripMenuItem.Name = "intervaloDePresentacionToolStripMenuItem";
			this.intervaloDePresentacionToolStripMenuItem.Size = new System.Drawing.Size(207, 23);
			this.intervaloDePresentacionToolStripMenuItem.Text = "Intervalo de presentacion";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(248, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.panel1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Ej1_v2";
			this.panel1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStripComboBox intervaloDePresentacionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem presentacionToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem verListaDeImagenesToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem ajustarVentanaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem visualizacionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem abrirCarpetaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel1;
	}
}
