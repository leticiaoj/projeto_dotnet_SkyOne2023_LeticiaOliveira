using System.Windows.Forms;

namespace teste4
{
    public partial class Teste5Form : Form
    {
        public Teste5Form()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // Configuração do Formulário
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Name = "Teste5Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste 5";
            this.ResumeLayout(false);
        }
    }
}
