namespace ADO.NET
{
    partial class FrnCliente
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
            this.lbNome = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.clnCODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTELEFONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(12, 9);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(15, 25);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(200, 20);
            this.tbNome.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(440, 25);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnCODIGO,
            this.clnNOME,
            this.clnTELEFONE});
            this.dgvClientes.Location = new System.Drawing.Point(15, 52);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(662, 338);
            this.dgvClientes.TabIndex = 3;
            // 
            // clnCODIGO
            // 
            this.clnCODIGO.DataPropertyName = "CODIGO";
            this.clnCODIGO.HeaderText = "Código";
            this.clnCODIGO.Name = "clnCODIGO";
            this.clnCODIGO.ReadOnly = true;
            this.clnCODIGO.Visible = false;
            // 
            // clnNOME
            // 
            this.clnNOME.DataPropertyName = "NOME";
            this.clnNOME.HeaderText = "Nome";
            this.clnNOME.Name = "clnNOME";
            this.clnNOME.ReadOnly = true;
            this.clnNOME.Width = 250;
            // 
            // clnTELEFONE
            // 
            this.clnTELEFONE.DataPropertyName = "TELEFONE";
            this.clnTELEFONE.HeaderText = "Telefone";
            this.clnTELEFONE.Name = "clnTELEFONE";
            this.clnTELEFONE.ReadOnly = true;
            this.clnTELEFONE.Width = 250;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(521, 25);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 4;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(602, 25);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Telefone";
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(224, 24);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(210, 20);
            this.tbTelefone.TabIndex = 7;
            // 
            // FrnCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 401);
            this.Controls.Add(this.tbTelefone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lbNome);
            this.Name = "FrnCliente";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTELEFONE;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTelefone;
    }
}

