namespace locadoraCarros
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboboxLocal = new System.Windows.Forms.ComboBox();
            this.comboboxVeiculo = new System.Windows.Forms.ComboBox();
            this.textboxId = new System.Windows.Forms.TextBox();
            this.textboxNome = new System.Windows.Forms.TextBox();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.buttonDeletar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.dataGridViewLocadora = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRetirada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDevolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locadora_carrosDataSet = new locadoraCarros.locadora_carrosDataSet();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new locadoraCarros.locadora_carrosDataSetTableAdapters.clientesTableAdapter();
            this.dateTimePickerRetirada = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDevolucao = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocadora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locadora_carrosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(268, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Local de retirada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(430, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data da retirada - (dd/mm/aaaa)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(627, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data da devolução - (dd/mm/aaaa)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(833, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "Modelo do veículo";
            // 
            // comboboxLocal
            // 
            this.comboboxLocal.FormattingEnabled = true;
            this.comboboxLocal.Items.AddRange(new object[] {
            "Florianópolis",
            "Biguaçu",
            "São José",
            "Palhoça",
            "Bauneário Camboriú",
            "Itajaí",
            "Brusque",
            "Lages"});
            this.comboboxLocal.Location = new System.Drawing.Point(271, 64);
            this.comboboxLocal.Name = "comboboxLocal";
            this.comboboxLocal.Size = new System.Drawing.Size(121, 21);
            this.comboboxLocal.TabIndex = 6;
            // 
            // comboboxVeiculo
            // 
            this.comboboxVeiculo.FormattingEnabled = true;
            this.comboboxVeiculo.Items.AddRange(new object[] {
            "Hyundai",
            "Fiat",
            "Volkswagen",
            "Ford",
            "Chevrolet"});
            this.comboboxVeiculo.Location = new System.Drawing.Point(836, 62);
            this.comboboxVeiculo.Name = "comboboxVeiculo";
            this.comboboxVeiculo.Size = new System.Drawing.Size(121, 21);
            this.comboboxVeiculo.TabIndex = 7;
            // 
            // textboxId
            // 
            this.textboxId.Enabled = false;
            this.textboxId.Location = new System.Drawing.Point(34, 64);
            this.textboxId.Name = "textboxId";
            this.textboxId.Size = new System.Drawing.Size(35, 20);
            this.textboxId.TabIndex = 8;
            // 
            // textboxNome
            // 
            this.textboxNome.Location = new System.Drawing.Point(114, 64);
            this.textboxNome.Name = "textboxNome";
            this.textboxNome.Size = new System.Drawing.Size(124, 20);
            this.textboxNome.TabIndex = 9;
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAtualizar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonAtualizar.Location = new System.Drawing.Point(539, 122);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(75, 23);
            this.buttonAtualizar.TabIndex = 12;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = false;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // buttonNovo
            // 
            this.buttonNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNovo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNovo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonNovo.Location = new System.Drawing.Point(239, 122);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(75, 23);
            this.buttonNovo.TabIndex = 13;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.UseVisualStyleBackColor = false;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // buttonDeletar
            // 
            this.buttonDeletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonDeletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDeletar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeletar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDeletar.Location = new System.Drawing.Point(684, 122);
            this.buttonDeletar.Name = "buttonDeletar";
            this.buttonDeletar.Size = new System.Drawing.Size(75, 23);
            this.buttonDeletar.TabIndex = 14;
            this.buttonDeletar.Text = "Deletar";
            this.buttonDeletar.UseVisualStyleBackColor = false;
            this.buttonDeletar.Click += new System.EventHandler(this.buttonDeletar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSalvar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonSalvar.Location = new System.Drawing.Point(378, 122);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 15;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // dataGridViewLocadora
            // 
            this.dataGridViewLocadora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLocadora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNome,
            this.ColumnLocal,
            this.ColumnRetirada,
            this.ColumnDevolucao,
            this.ColumnVeiculo});
            this.dataGridViewLocadora.Location = new System.Drawing.Point(34, 173);
            this.dataGridViewLocadora.Name = "dataGridViewLocadora";
            this.dataGridViewLocadora.Size = new System.Drawing.Size(923, 331);
            this.dataGridViewLocadora.TabIndex = 16;
            this.dataGridViewLocadora.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLocadora_CellContentClick);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.Width = 80;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.Width = 160;
            // 
            // ColumnLocal
            // 
            this.ColumnLocal.HeaderText = "Local de retirada";
            this.ColumnLocal.Name = "ColumnLocal";
            this.ColumnLocal.Width = 160;
            // 
            // ColumnRetirada
            // 
            this.ColumnRetirada.HeaderText = "Data da retirada";
            this.ColumnRetirada.Name = "ColumnRetirada";
            this.ColumnRetirada.Width = 160;
            // 
            // ColumnDevolucao
            // 
            this.ColumnDevolucao.HeaderText = "Data da devolução";
            this.ColumnDevolucao.Name = "ColumnDevolucao";
            this.ColumnDevolucao.Width = 160;
            // 
            // ColumnVeiculo
            // 
            this.ColumnVeiculo.HeaderText = "Modelo do veículo";
            this.ColumnVeiculo.Name = "ColumnVeiculo";
            this.ColumnVeiculo.Width = 160;
            // 
            // locadora_carrosDataSet
            // 
            this.locadora_carrosDataSet.DataSetName = "locadora_carrosDataSet";
            this.locadora_carrosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.locadora_carrosDataSet;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePickerRetirada
            // 
            this.dateTimePickerRetirada.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerRetirada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerRetirada.Location = new System.Drawing.Point(433, 65);
            this.dateTimePickerRetirada.Name = "dateTimePickerRetirada";
            this.dateTimePickerRetirada.Size = new System.Drawing.Size(157, 20);
            this.dateTimePickerRetirada.TabIndex = 17;
            this.dateTimePickerRetirada.Value = new System.DateTime(2020, 9, 4, 0, 0, 0, 0);
            // 
            // dateTimePickerDevolucao
            // 
            this.dateTimePickerDevolucao.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDevolucao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerDevolucao.Location = new System.Drawing.Point(630, 65);
            this.dateTimePickerDevolucao.Name = "dateTimePickerDevolucao";
            this.dateTimePickerDevolucao.Size = new System.Drawing.Size(172, 20);
            this.dateTimePickerDevolucao.TabIndex = 18;
            this.dateTimePickerDevolucao.Value = new System.DateTime(2020, 9, 4, 0, 0, 0, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1024, 533);
            this.Controls.Add(this.dateTimePickerDevolucao);
            this.Controls.Add(this.dateTimePickerRetirada);
            this.Controls.Add(this.dataGridViewLocadora);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonDeletar);
            this.Controls.Add(this.buttonNovo);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.textboxNome);
            this.Controls.Add(this.textboxId);
            this.Controls.Add(this.comboboxVeiculo);
            this.Controls.Add(this.comboboxLocal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocadora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locadora_carrosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboboxLocal;
        private System.Windows.Forms.ComboBox comboboxVeiculo;
        private System.Windows.Forms.TextBox textboxId;
        private System.Windows.Forms.TextBox textboxNome;
        private System.Windows.Forms.DataGridView dataGridViewLocadora;
        private locadora_carrosDataSet locadora_carrosDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private locadora_carrosDataSetTableAdapters.clientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRetirada;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDevolucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVeiculo;
        private System.Windows.Forms.DateTimePicker dateTimePickerRetirada;
        private System.Windows.Forms.DateTimePicker dateTimePickerDevolucao;
        internal System.Windows.Forms.Button buttonAtualizar;
        internal System.Windows.Forms.Button buttonNovo;
        internal System.Windows.Forms.Button buttonDeletar;
        internal System.Windows.Forms.Button buttonSalvar;
    }
}

