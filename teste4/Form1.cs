using System;
using System.Windows.Forms;

namespace teste4
{
    public partial class Form1 : Form
    {
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Button btnEntrar;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Login do Professor";
        }

        private void InitializeComponent()
        {
            this.txtLogin = new TextBox();
            this.txtSenha = new TextBox();
            this.btnEntrar = new Button();
            this.SuspendLayout();

            // Configuração do TextBox de Login
            this.txtLogin.Location = new System.Drawing.Point(100, 50);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(200, 20);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.PlaceholderText = "Login";

            // Configuração do TextBox de Senha
            this.txtSenha.Location = new System.Drawing.Point(100, 80);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(200, 20);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.PlaceholderText = "Senha";
            this.txtSenha.PasswordChar = '*';

            // Configuração do botão Entrar
            this.btnEntrar.Location = new System.Drawing.Point(150, 120);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(100, 30);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);

            // Configuração do Formulário
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string senha = txtSenha.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Teste5Form teste5Form = new Teste5Form();
                teste5Form.Show();
                this.Hide();
            }
        }
    }
}
