
namespace Floricuturaa
{
    partial class addFuncionario
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
            this.txt_tel = new System.Windows.Forms.MaskedTextBox();
            this.Adicionar = new System.Windows.Forms.Button();
            this.Salvar = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.txt_pesquisa = new System.Windows.Forms.TextBox();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cel = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_rg = new System.Windows.Forms.TextBox();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(93, 184);
            this.txt_tel.Mask = "(00)00000-0000";
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(74, 23);
            this.txt_tel.TabIndex = 0;
            // 
            // Adicionar
            // 
            this.Adicionar.Location = new System.Drawing.Point(36, 31);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(67, 44);
            this.Adicionar.TabIndex = 1;
            this.Adicionar.Text = "ADD";
            this.Adicionar.UseVisualStyleBackColor = true;
            this.Adicionar.Click += new System.EventHandler(this.Adicionar_Click);
            // 
            // Salvar
            // 
            this.Salvar.Location = new System.Drawing.Point(109, 31);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(67, 44);
            this.Salvar.TabIndex = 2;
            this.Salvar.Text = "SALVAR";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(182, 31);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(67, 44);
            this.Buscar.TabIndex = 3;
            this.Buscar.Text = "BUSCAR";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Editar
            // 
            this.Editar.Location = new System.Drawing.Point(255, 31);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(67, 44);
            this.Editar.TabIndex = 4;
            this.Editar.Text = "EDITAR";
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Excluir
            // 
            this.Excluir.Location = new System.Drawing.Point(328, 31);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(67, 44);
            this.Excluir.TabIndex = 5;
            this.Excluir.Text = "APAGAR";
            this.Excluir.UseVisualStyleBackColor = true;
            this.Excluir.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 7;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Celular";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Endereço:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(82, 136);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(252, 23);
            this.txt_nome.TabIndex = 11;
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(67, 331);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(100, 23);
            this.txt_numero.TabIndex = 12;
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.Location = new System.Drawing.Point(135, 94);
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(255, 23);
            this.txt_pesquisa.TabIndex = 13;
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(93, 271);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(257, 23);
            this.txt_endereco.TabIndex = 14;
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(234, 331);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(100, 23);
            this.txt_bairro.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Pesquisar Nome";
            // 
            // txt_cel
            // 
            this.txt_cel.Location = new System.Drawing.Point(243, 184);
            this.txt_cel.Mask = "(00)00000-0000";
            this.txt_cel.Name = "txt_cel";
            this.txt_cel.Size = new System.Drawing.Size(74, 23);
            this.txt_cel.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Nº";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(187, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Bairro:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "RG:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(200, 380);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "CPF:";
            // 
            // txt_rg
            // 
            this.txt_rg.Location = new System.Drawing.Point(67, 377);
            this.txt_rg.Name = "txt_rg";
            this.txt_rg.Size = new System.Drawing.Size(100, 23);
            this.txt_rg.TabIndex = 22;
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(237, 377);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(100, 23);
            this.txt_cpf.TabIndex = 23;
            // 
            // txt_email
            // 
            this.txt_email.AutoSize = true;
            this.txt_email.Location = new System.Drawing.Point(46, 231);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(41, 15);
            this.txt_email.TabIndex = 24;
            this.txt_email.Text = "E-mail";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 228);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 23);
            this.textBox1.TabIndex = 25;
            // 
            // addFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 415);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.txt_rg);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_cel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.txt_endereco);
            this.Controls.Add(this.txt_pesquisa);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.Adicionar);
            this.Controls.Add(this.txt_tel);
            this.Name = "addFuncionario";
            this.Text = "addFuncionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txt_tel;
        private System.Windows.Forms.Button Adicionar;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.TextBox txt_pesquisa;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txt_cel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_rg;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.Label txt_email;
        private System.Windows.Forms.TextBox textBox1;
    }
}