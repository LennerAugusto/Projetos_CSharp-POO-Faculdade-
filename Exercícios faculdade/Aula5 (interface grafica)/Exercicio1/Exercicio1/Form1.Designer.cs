﻿namespace Exercicio1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formularioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segundoFormulárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formularioToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // formularioToolStripMenuItem
            // 
            this.formularioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formulToolStripMenuItem,
            this.segundoFormulárioToolStripMenuItem});
            this.formularioToolStripMenuItem.Name = "formularioToolStripMenuItem";
            this.formularioToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.formularioToolStripMenuItem.Text = "Formularios ";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.ajudaToolStripMenuItem.Text = "ajuda";
            // 
            // formulToolStripMenuItem
            // 
            this.formulToolStripMenuItem.Name = "formulToolStripMenuItem";
            this.formulToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.formulToolStripMenuItem.Text = "Primerio Formulário ";
            this.formulToolStripMenuItem.Click += new System.EventHandler(this.formulToolStripMenuItem_Click);
            // 
            // segundoFormulárioToolStripMenuItem
            // 
            this.segundoFormulárioToolStripMenuItem.Name = "segundoFormulárioToolStripMenuItem";
            this.segundoFormulárioToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.segundoFormulárioToolStripMenuItem.Text = "Segundo Formulário ";
            this.segundoFormulárioToolStripMenuItem.Click += new System.EventHandler(this.segundoFormulárioToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem formularioToolStripMenuItem;
        private ToolStripMenuItem formulToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem segundoFormulárioToolStripMenuItem;
    }
}