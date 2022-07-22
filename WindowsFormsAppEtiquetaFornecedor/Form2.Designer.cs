namespace WindowsFormsAppEtiquetaFornecedor
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.autoLabelStk = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabelEncomenda = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabelDescricao = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabelCliente = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.sfBarcode1 = new Syncfusion.Windows.Forms.Barcode.SfBarcode();
            this.SuspendLayout();
            // 
            // autoLabelStk
            // 
            this.autoLabelStk.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabelStk.Location = new System.Drawing.Point(92, 66);
            this.autoLabelStk.Name = "autoLabelStk";
            this.autoLabelStk.Size = new System.Drawing.Size(16, 19);
            this.autoLabelStk.TabIndex = 4;
            this.autoLabelStk.Text = "?";
            // 
            // autoLabelEncomenda
            // 
            this.autoLabelEncomenda.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabelEncomenda.Location = new System.Drawing.Point(127, 45);
            this.autoLabelEncomenda.Name = "autoLabelEncomenda";
            this.autoLabelEncomenda.Size = new System.Drawing.Size(16, 19);
            this.autoLabelEncomenda.TabIndex = 5;
            this.autoLabelEncomenda.Text = "?";
            // 
            // autoLabelDescricao
            // 
            this.autoLabelDescricao.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabelDescricao.Location = new System.Drawing.Point(11, 0);
            this.autoLabelDescricao.Name = "autoLabelDescricao";
            this.autoLabelDescricao.Size = new System.Drawing.Size(19, 23);
            this.autoLabelDescricao.TabIndex = 6;
            this.autoLabelDescricao.Text = "?";
            this.autoLabelDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // autoLabelCliente
            // 
            this.autoLabelCliente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabelCliente.Location = new System.Drawing.Point(74, 26);
            this.autoLabelCliente.Name = "autoLabelCliente";
            this.autoLabelCliente.Size = new System.Drawing.Size(16, 19);
            this.autoLabelCliente.TabIndex = 8;
            this.autoLabelCliente.Text = "?";
            // 
            // autoLabel3
            // 
            this.autoLabel3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel3.Location = new System.Drawing.Point(12, 26);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(64, 19);
            this.autoLabel3.TabIndex = 9;
            this.autoLabel3.Text = "Cliente :";
            // 
            // autoLabel2
            // 
            this.autoLabel2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel2.Location = new System.Drawing.Point(12, 64);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(81, 19);
            this.autoLabel2.TabIndex = 12;
            this.autoLabel2.Text = "Nº Stock  :";
            this.autoLabel2.Click += new System.EventHandler(this.AutoLabel2_Click);
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.Location = new System.Drawing.Point(12, 45);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(119, 19);
            this.autoLabel1.TabIndex = 13;
            this.autoLabel1.Text = "Nº Encomenda :";
            // 
            // sfBarcode1
            // 
            this.sfBarcode1.DarkBarColor = System.Drawing.Color.Black;
            this.sfBarcode1.DisplayText = true;
            this.sfBarcode1.LightBarColor = System.Drawing.Color.White;
            this.sfBarcode1.Location = new System.Drawing.Point(243, 26);
            this.sfBarcode1.Name = "sfBarcode1";
            this.sfBarcode1.Size = new System.Drawing.Size(114, 73);
            this.sfBarcode1.Symbology = Syncfusion.Windows.Forms.Barcode.BarcodeSymbolType.Code39Extended;
            this.sfBarcode1.SymbologySettings = null;
            this.sfBarcode1.TabIndex = 14;
            this.sfBarcode1.TextAlignment = Syncfusion.Windows.Forms.Barcode.BarcodeTextAlignment.Center;
            this.sfBarcode1.TextColor = System.Drawing.Color.Black;
            this.sfBarcode1.TextGapHeight = 0F;
            this.sfBarcode1.Load += new System.EventHandler(this.SfBarcode1_Load);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 106);
            this.Controls.Add(this.sfBarcode1);
            this.Controls.Add(this.autoLabelStk);
            this.Controls.Add(this.autoLabelEncomenda);
            this.Controls.Add(this.autoLabelDescricao);
            this.Controls.Add(this.autoLabelCliente);
            this.Controls.Add(this.autoLabel3);
            this.Controls.Add(this.autoLabel2);
            this.Controls.Add(this.autoLabel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabelStk;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabelEncomenda;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabelDescricao;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabelCliente;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Barcode.SfBarcode sfBarcode1;
    }
}