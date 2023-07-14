using System;
using System.Drawing;
using System.Windows.Forms;

namespace teste4
{
    public partial class Teste05Form : Form
    {
        private TextBox txtNome;
        private TextBox txtNota1;
        private TextBox txtNota2;
        private Label lblNomeErro;
        private Label lblNota1Erro;
        private Label lblNota2Erro;
        private Button btnLimpar;
        private Button btnEnviar;
        private Label lblResultado;

        public Teste05Form()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.txtNome = new TextBox();
            this.txtNota1 = new TextBox();
            this.txtNota2 = new TextBox();
            this.lblNomeErro = new Label();
            this.lblNota1Erro = new Label();
            this.lblNota2Erro = new Label();
            this.btnLimpar = new Button();
            this.btnEnviar = new Button();
            this.lblResultado = new Label();
            this.SuspendLayout();

            // Configuração do TextBox de Nome
            this.txtNome.Location = new Point(100, 50);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new Size(200, 20);
            this.txtNome.TabIndex = 0;

            // Configuração do TextBox de Nota1
            this.txtNota1.Location = new Point(100, 80);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new Size(200, 20);
            this.txtNota1.TabIndex = 1;

            // Configuração do TextBox de Nota2
            this.txtNota2.Location = new Point(100, 110);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new Size(200, 20);
            this.txtNota2.TabIndex = 2;

            // Configuração da Label de erro do Nome
            this.lblNomeErro.AutoSize = true;
            this.lblNomeErro.ForeColor = Color.Red;
            this.lblNomeErro.Location = new Point(310, 53);
            this.lblNomeErro.Name = "lblNomeErro";
            this.lblNomeErro.Size = new Size(80, 13);
            this.lblNomeErro.TabIndex = 3;
            this.lblNomeErro.Text = "Campo obrigatório";

            // Configuração da Label de erro da Nota1
            this.lblNota1Erro.AutoSize = true;
            this.lblNota1Erro.ForeColor = Color.Red;
            this.lblNota1Erro.Location = new Point(310, 83);
            this.lblNota1Erro.Name = "lblNota1Erro";
            this.lblNota1Erro.Size = new Size(80, 13);
            this.lblNota1Erro.TabIndex = 4;
            this.lblNota1Erro.Text = "Campo obrigatório";

            // Configuração da Label de erro da Nota2
            this.lblNota2Erro.AutoSize = true;
            this.lblNota2Erro.ForeColor = Color.Red;
            this.lblNota2Erro.Location = new Point(310, 113);
            this.lblNota2Erro.Name = "lblNota2Erro";
            this.lblNota2Erro.Size = new Size(80, 13);
            this.lblNota2Erro.TabIndex = 5;
            this.lblNota2Erro.Text = "Campo obrigatório";

            // Configuração do botão Limpar
            this.btnLimpar.Location = new Point(100, 150);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new Size(100, 30);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new EventHandler(this.btnLimpar_Click);

            // Configuração do botão Enviar
            this.btnEnviar.Location = new Point(200, 150);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new Size(100, 30);
            this.btnEnviar.TabIndex = 7;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new EventHandler(this.btnEnviar_Click);

            // Configuração da Label de resultado
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new Point(100, 190);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new Size(0, 13);

            // Configuração do Formulário
            this.ClientSize = new Size(400, 250);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblNota2Erro);
            this.Controls.Add(this.lblNota1Erro);
            this.Controls.Add(this.lblNomeErro);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.txtNome);
            this.Name = "Teste05Form";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Lançamento de Notas";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string nota1 = txtNota1.Text;
            string nota2 = txtNota2.Text;

            bool camposPreenchidos = true;

            if (string.IsNullOrEmpty(nome))
            {
                lblNomeErro.Visible = true;
                camposPreenchidos = false;
            }
            else
            {
                lblNomeErro.Visible = false;
            }

            if (string.IsNullOrEmpty(nota1))
            {
                lblNota1Erro.Visible = true;
                camposPreenchidos = false;
            }
            else
            {
                lblNota1Erro.Visible = false;
            }

            if (string.IsNullOrEmpty(nota2))
            {
                lblNota2Erro.Visible = true;
                camposPreenchidos = false;
            }
            else
            {
                lblNota2Erro.Visible = false;
            }

            if (camposPreenchidos)
            {
                double media = (Convert.ToDouble(nota1) + Convert.ToDouble(nota2)) / 2;

                if (media < 6.5)
                {
                    lblResultado.ForeColor = Color.Red;
                    lblResultado.Text = "Reprovado";
                }
                else
                {
                    lblResultado.ForeColor = Color.Green;
                    lblResultado.Text = "Aprovado";
                }
            }
            else
            {
                lblResultado.Text = "";
            }
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtNota1.Text = "";
            txtNota2.Text = "";
            lblNomeErro.Visible = false;
            lblNota1Erro.Visible = false;
            lblNota2Erro.Visible = false;
            lblResultado.Text = "";
        }
    }
}
