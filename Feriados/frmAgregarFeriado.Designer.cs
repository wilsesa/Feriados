namespace Feriados
{
    partial class frmAgregarFeriado
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbFeriados = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbxMunicipio = new System.Windows.Forms.ComboBox();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.cbxUF = new System.Windows.Forms.ComboBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbxPais = new System.Windows.Forms.ComboBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.dtpDCadastro = new System.Windows.Forms.DateTimePicker();
            this.DCadastro = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.gbFeriados.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFeriados
            // 
            this.gbFeriados.Controls.Add(this.btnGuardar);
            this.gbFeriados.Controls.Add(this.cbxMunicipio);
            this.gbFeriados.Controls.Add(this.lblMunicipio);
            this.gbFeriados.Controls.Add(this.cbxUF);
            this.gbFeriados.Controls.Add(this.lblUF);
            this.gbFeriados.Controls.Add(this.cbxEstado);
            this.gbFeriados.Controls.Add(this.lblEstado);
            this.gbFeriados.Controls.Add(this.cbxPais);
            this.gbFeriados.Controls.Add(this.lblPais);
            this.gbFeriados.Controls.Add(this.cbxTipo);
            this.gbFeriados.Controls.Add(this.lblTipo);
            this.gbFeriados.Controls.Add(this.dtpDCadastro);
            this.gbFeriados.Controls.Add(this.DCadastro);
            this.gbFeriados.Controls.Add(this.dtpData);
            this.gbFeriados.Controls.Add(this.lblData);
            this.gbFeriados.Location = new System.Drawing.Point(84, 24);
            this.gbFeriados.Name = "gbFeriados";
            this.gbFeriados.Size = new System.Drawing.Size(734, 329);
            this.gbFeriados.TabIndex = 0;
            this.gbFeriados.TabStop = false;
            this.gbFeriados.Text = "Feriados";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(254, 201);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(117, 33);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbxMunicipio
            // 
            this.cbxMunicipio.FormattingEnabled = true;
            this.cbxMunicipio.Location = new System.Drawing.Point(574, 118);
            this.cbxMunicipio.Name = "cbxMunicipio";
            this.cbxMunicipio.Size = new System.Drawing.Size(121, 21);
            this.cbxMunicipio.TabIndex = 13;
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Location = new System.Drawing.Point(516, 121);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(52, 13);
            this.lblMunicipio.TabIndex = 12;
            this.lblMunicipio.Text = "Municipio";
            // 
            // cbxUF
            // 
            this.cbxUF.FormattingEnabled = true;
            this.cbxUF.Location = new System.Drawing.Point(414, 118);
            this.cbxUF.Name = "cbxUF";
            this.cbxUF.Size = new System.Drawing.Size(64, 21);
            this.cbxUF.TabIndex = 11;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(377, 121);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(21, 13);
            this.lblUF.TabIndex = 10;
            this.lblUF.Text = "UF";
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(250, 118);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(121, 21);
            this.cbxEstado.TabIndex = 9;
            this.cbxEstado.SelectedIndexChanged += new System.EventHandler(this.cbxEstado_SelectedIndexChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(207, 121);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Estado";
            // 
            // cbxPais
            // 
            this.cbxPais.FormattingEnabled = true;
            this.cbxPais.Location = new System.Drawing.Point(71, 118);
            this.cbxPais.Name = "cbxPais";
            this.cbxPais.Size = new System.Drawing.Size(121, 21);
            this.cbxPais.TabIndex = 7;
            this.cbxPais.SelectedIndexChanged += new System.EventHandler(this.cbxPais_SelectedIndexChanged);
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(37, 121);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(27, 13);
            this.lblPais.TabIndex = 6;
            this.lblPais.Text = "Pais";
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(284, 69);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(121, 21);
            this.cbxTipo.TabIndex = 5;
            this.cbxTipo.SelectedIndexChanged += new System.EventHandler(this.cbxTipo_SelectedIndexChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(207, 69);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Tipo";
            // 
            // dtpDCadastro
            // 
            this.dtpDCadastro.Location = new System.Drawing.Point(426, 18);
            this.dtpDCadastro.Name = "dtpDCadastro";
            this.dtpDCadastro.Size = new System.Drawing.Size(200, 20);
            this.dtpDCadastro.TabIndex = 3;
            // 
            // DCadastro
            // 
            this.DCadastro.AutoSize = true;
            this.DCadastro.Location = new System.Drawing.Point(345, 24);
            this.DCadastro.Name = "DCadastro";
            this.DCadastro.Size = new System.Drawing.Size(60, 13);
            this.DCadastro.TabIndex = 2;
            this.DCadastro.Text = "D.Cadastro";
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(95, 18);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 20);
            this.dtpData.TabIndex = 1;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(39, 18);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Data";
            // 
            // frmAgregarFeriado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 406);
            this.Controls.Add(this.gbFeriados);
            this.Name = "frmAgregarFeriado";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AgregarFeriado_Load);
            this.gbFeriados.ResumeLayout(false);
            this.gbFeriados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFeriados;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.DateTimePicker dtpDCadastro;
        private System.Windows.Forms.Label DCadastro;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cbxMunicipio;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.ComboBox cbxUF;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbxPais;
        private System.Windows.Forms.Label lblPais;
    }
}

