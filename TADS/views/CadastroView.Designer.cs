namespace Projeto_Interdisciplinar_III
{
    partial class CadastroView
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnVoltar = new Button();
            btnCadastrar = new Button();
            txtNome = new TextBox();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            label5 = new Label();
            txtSenhaConfirm = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(98, 26);
            label1.Name = "label1";
            label1.Size = new Size(330, 32);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de novo funcionario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 89);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(115, 135);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 2;
            label3.Text = "Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 179);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Senha";
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(115, 288);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 4;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(329, 288);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(242, 89);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(162, 23);
            txtNome.TabIndex = 6;
            txtNome.KeyPress += txtNome_KeyPress;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(242, 135);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(162, 23);
            txtUsuario.TabIndex = 7;
            txtUsuario.KeyPress += txtUsuario_KeyPress;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(242, 182);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(162, 23);
            txtSenha.TabIndex = 8;
            txtSenha.KeyPress += txtSenha_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(115, 228);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 9;
            label5.Text = "Confirmar senha";
            // 
            // txtSenhaConfirm
            // 
            txtSenhaConfirm.PasswordChar = '*';
            txtSenhaConfirm.Location = new Point(242, 228);
            txtSenhaConfirm.Name = "txtSenhaConfirm";
            txtSenhaConfirm.Size = new Size(162, 23);
            txtSenhaConfirm.TabIndex = 10;
            // 
            // CadastroView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 350);
            Controls.Add(txtSenhaConfirm);
            Controls.Add(label5);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(txtNome);
            Controls.Add(btnCadastrar);
            Controls.Add(btnVoltar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastroView";
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnVoltar;
        private Button btnCadastrar;
        private TextBox txtNome;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Label label5;
        private TextBox txtSenhaConfirm;
    }
}