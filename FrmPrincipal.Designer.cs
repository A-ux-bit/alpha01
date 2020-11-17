
namespace Calcimc
{
    partial class Calculadora
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
            this.Lblpeso = new System.Windows.Forms.Label();
            this.Lblaltura = new System.Windows.Forms.Label();
            this.Lblresultado = new System.Windows.Forms.Label();
            this.Lblmostrar = new System.Windows.Forms.Label();
            this.Btncalcular = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.txtvalor1 = new System.Windows.Forms.TextBox();
            this.txtvalor2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lblpeso
            // 
            this.Lblpeso.AutoSize = true;
            this.Lblpeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblpeso.Location = new System.Drawing.Point(63, 41);
            this.Lblpeso.Name = "Lblpeso";
            this.Lblpeso.Size = new System.Drawing.Size(106, 13);
            this.Lblpeso.TabIndex = 0;
            this.Lblpeso.Text = "Digite o seu peso";
            // 
            // Lblaltura
            // 
            this.Lblaltura.AutoSize = true;
            this.Lblaltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblaltura.Location = new System.Drawing.Point(63, 122);
            this.Lblaltura.Name = "Lblaltura";
            this.Lblaltura.Size = new System.Drawing.Size(111, 13);
            this.Lblaltura.TabIndex = 1;
            this.Lblaltura.Text = "Digite a sua altura";
            // 
            // Lblresultado
            // 
            this.Lblresultado.AutoSize = true;
            this.Lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblresultado.Location = new System.Drawing.Point(63, 258);
            this.Lblresultado.Name = "Lblresultado";
            this.Lblresultado.Size = new System.Drawing.Size(64, 13);
            this.Lblresultado.TabIndex = 2;
            this.Lblresultado.Text = "Resultado";
            // 
            // Lblmostrar
            // 
            this.Lblmostrar.AutoSize = true;
            this.Lblmostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblmostrar.Location = new System.Drawing.Point(63, 284);
            this.Lblmostrar.Name = "Lblmostrar";
            this.Lblmostrar.Size = new System.Drawing.Size(0, 13);
            this.Lblmostrar.TabIndex = 3;
            // 
            // Btncalcular
            // 
            this.Btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btncalcular.Location = new System.Drawing.Point(699, 53);
            this.Btncalcular.Name = "Btncalcular";
            this.Btncalcular.Size = new System.Drawing.Size(75, 23);
            this.Btncalcular.TabIndex = 4;
            this.Btncalcular.Text = "Calcular";
            this.Btncalcular.UseVisualStyleBackColor = true;
            this.Btncalcular.Click += new System.EventHandler(this.Btncalcular_Click);
            // 
            // btnsair
            // 
            this.btnsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Location = new System.Drawing.Point(699, 96);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 5;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // txtvalor1
            // 
            this.txtvalor1.Location = new System.Drawing.Point(66, 68);
            this.txtvalor1.Name = "txtvalor1";
            this.txtvalor1.Size = new System.Drawing.Size(131, 20);
            this.txtvalor1.TabIndex = 6;
            // 
            // txtvalor2
            // 
            this.txtvalor2.Location = new System.Drawing.Point(66, 154);
            this.txtvalor2.Name = "txtvalor2";
            this.txtvalor2.Size = new System.Drawing.Size(131, 20);
            this.txtvalor2.TabIndex = 7;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtvalor2);
            this.Controls.Add(this.txtvalor1);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.Btncalcular);
            this.Controls.Add(this.Lblmostrar);
            this.Controls.Add(this.Lblresultado);
            this.Controls.Add(this.Lblaltura);
            this.Controls.Add(this.Lblpeso);
            this.Name = "Calculadora";
            this.Text = "Calculadora do IMC";
            this.Load += new System.EventHandler(this.Calculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lblpeso;
        private System.Windows.Forms.Label Lblaltura;
        private System.Windows.Forms.Label Lblresultado;
        private System.Windows.Forms.Label Lblmostrar;
        private System.Windows.Forms.Button Btncalcular;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.TextBox txtvalor1;
        private System.Windows.Forms.TextBox txtvalor2;
    }
}

