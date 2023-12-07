namespace site
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
            this.Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textm = new System.Windows.Forms.MaskedTextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskValor = new System.Windows.Forms.MaskedTextBox();
            this.rdb_cpf = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.coluID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluTelefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colusenha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn
            // 
            this.Btn.BackColor = System.Drawing.SystemColors.WindowText;
            this.Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Btn.Location = new System.Drawing.Point(33, 342);
            this.Btn.Name = "Btn";
            this.Btn.Size = new System.Drawing.Size(192, 51);
            this.Btn.TabIndex = 4;
            this.Btn.Text = "Cadastrar";
            this.Btn.UseVisualStyleBackColor = false;
            this.Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // text1
            // 
            this.text1.BackColor = System.Drawing.SystemColors.WindowText;
            this.text1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text1.ForeColor = System.Drawing.Color.White;
            this.text1.Location = new System.Drawing.Point(38, 88);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(190, 13);
            this.text1.TabIndex = 0;
            this.text1.TextChanged += new System.EventHandler(this.text1_TextChanged);
            // 
            // text2
            // 
            this.text2.BackColor = System.Drawing.SystemColors.WindowText;
            this.text2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text2.ForeColor = System.Drawing.Color.White;
            this.text2.Location = new System.Drawing.Point(38, 135);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(187, 13);
            this.text2.TabIndex = 1;
            this.text2.TextChanged += new System.EventHandler(this.text2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "E-mail";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // text3
            // 
            this.text3.BackColor = System.Drawing.SystemColors.WindowText;
            this.text3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text3.ForeColor = System.Drawing.Color.White;
            this.text3.Location = new System.Drawing.Point(38, 238);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(187, 13);
            this.text3.TabIndex = 3;
            this.text3.UseSystemPasswordChar = true;
            this.text3.TextChanged += new System.EventHandler(this.text3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "Senha";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "Telefone";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textm
            // 
            this.textm.BackColor = System.Drawing.SystemColors.WindowText;
            this.textm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textm.ForeColor = System.Drawing.Color.White;
            this.textm.Location = new System.Drawing.Point(38, 190);
            this.textm.Mask = "(00) 00000-0000";
            this.textm.Name = "textm";
            this.textm.Size = new System.Drawing.Size(187, 13);
            this.textm.TabIndex = 2;
            this.textm.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.textm_MaskInputRejected);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.BackColor = System.Drawing.Color.Transparent;
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(234, 9);
            this.Nome.MaximumSize = new System.Drawing.Size(900, 900);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(429, 73);
            this.Nome.TabIndex = 10;
            this.Nome.Text = "Urubu do PIX";
            this.Nome.Click += new System.EventHandler(this.Nome_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 36);
            this.label5.TabIndex = 12;
            this.label5.Text = "CPF";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // maskValor
            // 
            this.maskValor.BackColor = System.Drawing.SystemColors.WindowText;
            this.maskValor.ForeColor = System.Drawing.SystemColors.Window;
            this.maskValor.Location = new System.Drawing.Point(38, 293);
            this.maskValor.Mask = "000,000,000-00";
            this.maskValor.Name = "maskValor";
            this.maskValor.Size = new System.Drawing.Size(187, 20);
            this.maskValor.TabIndex = 13;
            this.maskValor.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // rdb_cpf
            // 
            this.rdb_cpf.AutoSize = true;
            this.rdb_cpf.Location = new System.Drawing.Point(38, 319);
            this.rdb_cpf.Name = "rdb_cpf";
            this.rdb_cpf.Size = new System.Drawing.Size(46, 17);
            this.rdb_cpf.TabIndex = 14;
            this.rdb_cpf.Text = "CPF";
            this.rdb_cpf.UseVisualStyleBackColor = true;
            this.rdb_cpf.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coluID,
            this.colunome,
            this.columail,
            this.coluTelefone,
            this.colusenha});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(247, 190);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(381, 158);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // coluID
            // 
            this.coluID.Text = "ID";
            this.coluID.Width = 23;
            // 
            // colunome
            // 
            this.colunome.Text = "Nome";
            this.colunome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colunome.Width = 90;
            // 
            // columail
            // 
            this.columail.Text = "Email";
            this.columail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columail.Width = 90;
            // 
            // coluTelefone
            // 
            this.coluTelefone.Text = "Senha";
            this.coluTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.coluTelefone.Width = 90;
            // 
            // colusenha
            // 
            this.colusenha.Text = "Telefone";
            this.colusenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colusenha.Width = 90;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(240, 103);
            this.label6.MaximumSize = new System.Drawing.Size(900, 900);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(367, 76);
            this.label6.TabIndex = 16;
            this.label6.Text = "Pessoas com seu seguro de\r\nvida com nosso metodo";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Silver;
            this.pictureBox3.BackgroundImage = global::site.Properties.Resources.pratoc_removebg_preview;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Image = global::site.Properties.Resources.pratoc_removebg_preview1;
            this.pictureBox3.Location = new System.Drawing.Point(376, 354);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::site.Properties.Resources.image_removebg_preview__1_;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(729, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(235, 68);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::site.Properties.Resources.hkolwgi2h7u61_removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(540, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(431, 395);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(976, 465);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.rdb_cpf);
            this.Controls.Add(this.maskValor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textm);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox textm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskValor;
        private System.Windows.Forms.CheckBox rdb_cpf;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colunome;
        private System.Windows.Forms.ColumnHeader columail;
        private System.Windows.Forms.ColumnHeader coluTelefone;
        private System.Windows.Forms.ColumnHeader coluID;
        private System.Windows.Forms.ColumnHeader colusenha;
        private System.Windows.Forms.Label label6;
    }
}

