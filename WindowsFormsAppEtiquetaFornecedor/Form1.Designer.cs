namespace WindowsFormsAppEtiquetaFornecedor
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.bindingetiquetas = new System.Windows.Forms.BindingSource(this.components);
            this.etiquetasDataSet = new WindowsFormsAppEtiquetaFornecedor.EtiquetasDataSet();
            this.artigosTableAdapter = new WindowsFormsAppEtiquetaFornecedor.EtiquetasDataSetTableAdapters.ArtigosTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codArtigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelprocurar = new System.Windows.Forms.Label();
            this.textBoxprocurar = new System.Windows.Forms.TextBox();
            this.btn_imprimir = new Syncfusion.WinForms.Controls.SfButton();
            this.sfButton1 = new Syncfusion.WinForms.Controls.SfButton();
            this.sfBarcode1 = new Syncfusion.Windows.Forms.Barcode.SfBarcode();
            this.txtBCodArtigo = new System.Windows.Forms.TextBox();
            this.txtBCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBEncomenda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBDescricao = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingetiquetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etiquetasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingetiquetas
            // 
            this.bindingetiquetas.DataMember = "Artigos";
            this.bindingetiquetas.DataSource = this.etiquetasDataSet;
            // 
            // etiquetasDataSet
            // 
            this.etiquetasDataSet.DataSetName = "EtiquetasDataSet";
            this.etiquetasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artigosTableAdapter
            // 
            this.artigosTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codArtigoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingetiquetas;
            this.dataGridView1.Location = new System.Drawing.Point(0, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(568, 213);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // codArtigoDataGridViewTextBoxColumn
            // 
            this.codArtigoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codArtigoDataGridViewTextBoxColumn.DataPropertyName = "CodArtigo";
            this.codArtigoDataGridViewTextBoxColumn.HeaderText = "CodArtigo";
            this.codArtigoDataGridViewTextBoxColumn.Name = "codArtigoDataGridViewTextBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // labelprocurar
            // 
            this.labelprocurar.AutoSize = true;
            this.labelprocurar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprocurar.Location = new System.Drawing.Point(12, 100);
            this.labelprocurar.Name = "labelprocurar";
            this.labelprocurar.Size = new System.Drawing.Size(60, 17);
            this.labelprocurar.TabIndex = 21;
            this.labelprocurar.Text = "Procurar";
            // 
            // textBoxprocurar
            // 
            this.textBoxprocurar.Location = new System.Drawing.Point(12, 120);
            this.textBoxprocurar.Name = "textBoxprocurar";
            this.textBoxprocurar.Size = new System.Drawing.Size(225, 20);
            this.textBoxprocurar.TabIndex = 20;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.AccessibleName = "Button";
            this.btn_imprimir.BackColor = System.Drawing.Color.Blue;
            this.btn_imprimir.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn_imprimir.ForeColor = System.Drawing.Color.White;
            this.btn_imprimir.Location = new System.Drawing.Point(288, 25);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(96, 28);
            this.btn_imprimir.Style.BackColor = System.Drawing.Color.Blue;
            this.btn_imprimir.Style.ForeColor = System.Drawing.Color.White;
            this.btn_imprimir.TabIndex = 13;
            this.btn_imprimir.Text = "Gerar Etiqueta";
            this.btn_imprimir.UseVisualStyleBackColor = false;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // sfButton1
            // 
            this.sfButton1.AccessibleName = "Button";
            this.sfButton1.BackColor = System.Drawing.Color.Blue;
            this.sfButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButton1.ForeColor = System.Drawing.Color.White;
            this.sfButton1.Location = new System.Drawing.Point(288, 59);
            this.sfButton1.Name = "sfButton1";
            this.sfButton1.Size = new System.Drawing.Size(96, 28);
            this.sfButton1.Style.BackColor = System.Drawing.Color.Blue;
            this.sfButton1.Style.ForeColor = System.Drawing.Color.White;
            this.sfButton1.TabIndex = 12;
            this.sfButton1.Text = "Sair";
            this.sfButton1.UseVisualStyleBackColor = false;
            this.sfButton1.Click += new System.EventHandler(this.sfButton1_Click);
            // 
            // sfBarcode1
            // 
            this.sfBarcode1.DarkBarColor = System.Drawing.Color.Black;
            this.sfBarcode1.DisplayText = true;
            this.sfBarcode1.LightBarColor = System.Drawing.Color.White;
            this.sfBarcode1.Location = new System.Drawing.Point(409, 13);
            this.sfBarcode1.Name = "sfBarcode1";
            this.sfBarcode1.Size = new System.Drawing.Size(150, 106);
            this.sfBarcode1.Symbology = Syncfusion.Windows.Forms.Barcode.BarcodeSymbolType.Code39Extended;
            this.sfBarcode1.SymbologySettings = null;
            this.sfBarcode1.TabIndex = 22;
            this.sfBarcode1.TextAlignment = Syncfusion.Windows.Forms.Barcode.BarcodeTextAlignment.Center;
            this.sfBarcode1.TextColor = System.Drawing.Color.Black;
            this.sfBarcode1.TextGapHeight = 0F;
            this.sfBarcode1.Load += new System.EventHandler(this.sfBarcode1_Load);
            // 
            // txtBCodArtigo
            // 
            this.txtBCodArtigo.Location = new System.Drawing.Point(530, 122);
            this.txtBCodArtigo.Name = "txtBCodArtigo";
            this.txtBCodArtigo.Size = new System.Drawing.Size(36, 20);
            this.txtBCodArtigo.TabIndex = 20;
            // 
            // txtBCliente
            // 
            this.txtBCliente.Location = new System.Drawing.Point(12, 23);
            this.txtBCliente.Name = "txtBCliente";
            this.txtBCliente.Size = new System.Drawing.Size(92, 20);
            this.txtBCliente.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Cliente";
            // 
            // txtBEncomenda
            // 
            this.txtBEncomenda.Location = new System.Drawing.Point(139, 23);
            this.txtBEncomenda.Name = "txtBEncomenda";
            this.txtBEncomenda.Size = new System.Drawing.Size(92, 20);
            this.txtBEncomenda.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nº de Encomenda";
            // 
            // txtBDescricao
            // 
            this.txtBDescricao.Location = new System.Drawing.Point(488, 122);
            this.txtBDescricao.Name = "txtBDescricao";
            this.txtBDescricao.Size = new System.Drawing.Size(36, 20);
            this.txtBDescricao.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 359);
            this.Controls.Add(this.sfBarcode1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBEncomenda);
            this.Controls.Add(this.labelprocurar);
            this.Controls.Add(this.txtBCliente);
            this.Controls.Add(this.txtBDescricao);
            this.Controls.Add(this.txtBCodArtigo);
            this.Controls.Add(this.textBoxprocurar);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.sfButton1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingetiquetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etiquetasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingetiquetas;
        private EtiquetasDataSet etiquetasDataSet;
        private EtiquetasDataSetTableAdapters.ArtigosTableAdapter artigosTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codArtigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelprocurar;
        private System.Windows.Forms.TextBox textBoxprocurar;
        private Syncfusion.WinForms.Controls.SfButton btn_imprimir;
        private Syncfusion.WinForms.Controls.SfButton sfButton1;
        private Syncfusion.Windows.Forms.Barcode.SfBarcode sfBarcode1;
        private System.Windows.Forms.TextBox txtBCodArtigo;
        private System.Windows.Forms.TextBox txtBCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBEncomenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBDescricao;
    }
}

