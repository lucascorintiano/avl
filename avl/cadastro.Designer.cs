namespace avl
{
    partial class cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastro));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.senha = new System.Windows.Forms.TextBox();
            this.textBoxemail = new System.Windows.Forms.TextBox();
            this.textBoxendereco = new System.Windows.Forms.TextBox();
            this.textBoxcpf = new System.Windows.Forms.TextBox();
            this.textBoxcelular = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxpesquisar = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBoxnivel = new System.Windows.Forms.ComboBox();
            this.dataGridViewusers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewusers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informação do Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Senha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Celular:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nivel:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "CPF:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Endereço:";
            this.label8.Click += new System.EventHandler(this.label7_Click);
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(6, 77);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(209, 20);
            this.user.TabIndex = 2;
            this.user.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // senha
            // 
            this.senha.Location = new System.Drawing.Point(6, 133);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(209, 20);
            this.senha.TabIndex = 2;
            this.senha.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxemail
            // 
            this.textBoxemail.Location = new System.Drawing.Point(6, 244);
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.Size = new System.Drawing.Size(209, 20);
            this.textBoxemail.TabIndex = 2;
            this.textBoxemail.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxendereco
            // 
            this.textBoxendereco.Location = new System.Drawing.Point(6, 420);
            this.textBoxendereco.Name = "textBoxendereco";
            this.textBoxendereco.Size = new System.Drawing.Size(209, 20);
            this.textBoxendereco.TabIndex = 2;
            this.textBoxendereco.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxcpf
            // 
            this.textBoxcpf.Location = new System.Drawing.Point(6, 356);
            this.textBoxcpf.Name = "textBoxcpf";
            this.textBoxcpf.Size = new System.Drawing.Size(209, 20);
            this.textBoxcpf.TabIndex = 2;
            this.textBoxcpf.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxcelular
            // 
            this.textBoxcelular.Location = new System.Drawing.Point(6, 300);
            this.textBoxcelular.Name = "textBoxcelular";
            this.textBoxcelular.Size = new System.Drawing.Size(209, 20);
            this.textBoxcelular.TabIndex = 2;
            this.textBoxcelular.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 520);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(141, 520);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 47);
            this.button2.TabIndex = 3;
            this.button2.Text = "Atuaizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(272, 520);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 47);
            this.button3.TabIndex = 3;
            this.button3.Text = "Excluir ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(526, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Pesquisar por Nome:";
            // 
            // textBoxpesquisar
            // 
            this.textBoxpesquisar.Location = new System.Drawing.Point(707, 15);
            this.textBoxpesquisar.Name = "textBoxpesquisar";
            this.textBoxpesquisar.Size = new System.Drawing.Size(243, 20);
            this.textBoxpesquisar.TabIndex = 2;
            this.textBoxpesquisar.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(973, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 41);
            this.button4.TabIndex = 3;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBoxnivel
            // 
            this.comboBoxnivel.FormattingEnabled = true;
            this.comboBoxnivel.Location = new System.Drawing.Point(6, 184);
            this.comboBoxnivel.Name = "comboBoxnivel";
            this.comboBoxnivel.Size = new System.Drawing.Size(209, 21);
            this.comboBoxnivel.TabIndex = 6;
            // 
            // dataGridViewusers
            // 
            this.dataGridViewusers.AllowUserToAddRows = false;
            this.dataGridViewusers.AllowUserToDeleteRows = false;
            this.dataGridViewusers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewusers.Location = new System.Drawing.Point(491, 65);
            this.dataGridViewusers.Name = "dataGridViewusers";
            this.dataGridViewusers.ReadOnly = true;
            this.dataGridViewusers.Size = new System.Drawing.Size(589, 518);
            this.dataGridViewusers.TabIndex = 7;
            this.dataGridViewusers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewusers_CellContentClick);
            // 
            // cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 592);
            this.Controls.Add(this.dataGridViewusers);
            this.Controls.Add(this.comboBoxnivel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxpesquisar);
            this.Controls.Add(this.textBoxendereco);
            this.Controls.Add(this.textBoxcelular);
            this.Controls.Add(this.textBoxcpf);
            this.Controls.Add(this.textBoxemail);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewusers)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.TextBox textBoxemail;
        private System.Windows.Forms.TextBox textBoxendereco;
        private System.Windows.Forms.TextBox textBoxcpf;
        private System.Windows.Forms.TextBox textBoxcelular;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxpesquisar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBoxnivel;
        private System.Windows.Forms.DataGridView dataGridViewusers;
    }
}