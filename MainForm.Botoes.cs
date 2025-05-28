namespace JogoAdivinhacao.Views
{
    partial class MainForm
    {
        private System.Windows.Forms.TextBox txtPalpite;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblResultado;

        private void InicializarBotoes()
        {
            this.txtPalpite = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();

            // txtPalpite
            this.txtPalpite.Location = new System.Drawing.Point(30, 110);
            this.txtPalpite.Size = new System.Drawing.Size(100, 23);

            // btnVerificar
            this.btnVerificar.Location = new System.Drawing.Point(140, 110);
            this.btnVerificar.Size = new System.Drawing.Size(100, 23);
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);

            // lblResultado
            this.lblResultado.Location = new System.Drawing.Point(30, 150);
            this.lblResultado.Size = new System.Drawing.Size(200, 23);

            // Adiciona ao formulário
            this.Controls.Add(this.txtPalpite);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lblResultado);
        }
    }
}
