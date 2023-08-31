namespace Aula15Cadastro
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtNascmt = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSenha2 = new System.Windows.Forms.TextBox();
            this.txtUsuario2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.txtNascmt);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.txtSenha2);
            this.groupBox1.Controls.Add(this.txtUsuario2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 402);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(82, 355);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(103, 31);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtNascmt
            // 
            this.txtNascmt.Location = new System.Drawing.Point(19, 307);
            this.txtNascmt.Name = "txtNascmt";
            this.txtNascmt.Size = new System.Drawing.Size(230, 29);
            this.txtNascmt.TabIndex = 8;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(19, 225);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(230, 29);
            this.txtNome.TabIndex = 7;
            // 
            // txtSenha2
            // 
            this.txtSenha2.Location = new System.Drawing.Point(19, 140);
            this.txtSenha2.Name = "txtSenha2";
            this.txtSenha2.Size = new System.Drawing.Size(230, 29);
            this.txtSenha2.TabIndex = 6;
            // 
            // txtUsuario2
            // 
            this.txtUsuario2.Location = new System.Drawing.Point(19, 62);
            this.txtUsuario2.Name = "txtUsuario2";
            this.txtUsuario2.Size = new System.Drawing.Size(230, 29);
            this.txtUsuario2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ano de nascimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome completo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuário:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Boas-vindas! Para prosseguir preencha os campos abaixo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Controls.Add(this.btnProcurar);
            this.groupBox2.Controls.Add(this.txtBusca);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(325, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 402);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busca por Clientes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Clientes cadastrados:";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(19, 192);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(230, 194);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(65, 106);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(137, 31);
            this.btnProcurar.TabIndex = 9;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(19, 62);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(230, 29);
            this.txtBusca.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 21);
            this.label9.TabIndex = 1;
            this.label9.Text = "Buscar cliente pelo nome";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 469);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtNascmt;
        private TextBox txtNome;
        private TextBox txtSenha2;
        private TextBox txtUsuario2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label6;
        private ListView listView1;
        private Button btnProcurar;
        private TextBox txtBusca;
        private Label label9;
        private Button btnSalvar;
    }
}