﻿namespace MiCalculadora
{
    partial class FrmCalculadora
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
            label1 = new Label();
            txbx_primerOperando = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(152, 70);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // txbx_primerOperando
            // 
            txbx_primerOperando.Location = new Point(96, 210);
            txbx_primerOperando.Name = "txbx_primerOperando";
            txbx_primerOperando.PlaceholderText = "0";
            txbx_primerOperando.Size = new Size(150, 31);
            txbx_primerOperando.TabIndex = 1;
            txbx_primerOperando.TextChanged += txbxPrimerOperando_TextChanged;
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txbx_primerOperando);
            Controls.Add(label1);
            Name = "FrmCalculadora";
            Text = "Calculadora de Juan David Chaves";
            Load += FrmCalculadora_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbx_primerOperando;
    }
}