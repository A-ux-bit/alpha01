
namespace Calc
{
    partial class frmprincipal
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
            this.Btnsomar = new System.Windows.Forms.Button();
            this.Lbl1Valor = new System.Windows.Forms.Label();
            this.Txt1valor = new System.Windows.Forms.TextBox();
            this.Lbl2Valor = new System.Windows.Forms.Label();
            this.LblResultado = new System.Windows.Forms.Label();
            this.LblMostrar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt2valor = new System.Windows.Forms.TextBox();
            this.Btnsubtrair = new System.Windows.Forms.Button();
            this.Btnmultiplicar = new System.Windows.Forms.Button();
            this.Btndividir = new System.Windows.Forms.Button();
            this.Btnsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btnsomar
            // 
            this.Btnsomar.Location = new System.Drawing.Point(464, 23);
            this.Btnsomar.Name = "Btnsomar";
            this.Btnsomar.Size = new System.Drawing.Size(75, 23);
            this.Btnsomar.TabIndex = 0;
            this.Btnsomar.Text = "&Somar";
            this.Btnsomar.UseVisualStyleBackColor = true;
            this.Btnsomar.Click += new System.EventHandler(this.Btnsomar_Click);
            // 
            // Lbl1Valor
            // 
            this.Lbl1Valor.AutoSize = true;
            this.Lbl1Valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl1Valor.Location = new System.Drawing.Point(21, 9);
            this.Lbl1Valor.Name = "Lbl1Valor";
            this.Lbl1Valor.Size = new System.Drawing.Size(144, 13);
            this.Lbl1Valor.TabIndex = 1;
            this.Lbl1Valor.Text = "Digite o primeiro número";
            // 
            // Txt1valor
            // 
            this.Txt1valor.Location = new System.Drawing.Point(24, 26);
            this.Txt1valor.Name = "Txt1valor";
            this.Txt1valor.Size = new System.Drawing.Size(141, 20);
            this.Txt1valor.TabIndex = 2;
            // 
            // Lbl2Valor
            // 
            this.Lbl2Valor.AutoSize = true;
            this.Lbl2Valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl2Valor.Location = new System.Drawing.Point(21, 56);
            this.Lbl2Valor.Name = "Lbl2Valor";
            this.Lbl2Valor.Size = new System.Drawing.Size(148, 13);
            this.Lbl2Valor.TabIndex = 3;
            this.Lbl2Valor.Text = "Digite o segundo número";
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultado.Location = new System.Drawing.Point(21, 161);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(64, 13);
            this.LblResultado.TabIndex = 4;
            this.LblResultado.Text = "Resultado";
            // 
            // LblMostrar
            // 
            this.LblMostrar.AutoSize = true;
            this.LblMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMostrar.Location = new System.Drawing.Point(21, 201);
            this.LblMostrar.Name = "LblMostrar";
            this.LblMostrar.Size = new System.Drawing.Size(0, 31);
            this.LblMostrar.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 6;
            // 
            // txt2valor
            // 
            this.txt2valor.Location = new System.Drawing.Point(24, 80);
            this.txt2valor.Name = "txt2valor";
            this.txt2valor.Size = new System.Drawing.Size(141, 20);
            this.txt2valor.TabIndex = 7;
            // 
            // Btnsubtrair
            // 
            this.Btnsubtrair.Location = new System.Drawing.Point(464, 68);
            this.Btnsubtrair.Name = "Btnsubtrair";
            this.Btnsubtrair.Size = new System.Drawing.Size(75, 23);
            this.Btnsubtrair.TabIndex = 9;
            this.Btnsubtrair.Text = "S&ubtrair";
            this.Btnsubtrair.UseVisualStyleBackColor = true;
            this.Btnsubtrair.Click += new System.EventHandler(this.Btnsubtrair_Click);
            // 
            // Btnmultiplicar
            // 
            this.Btnmultiplicar.Location = new System.Drawing.Point(464, 112);
            this.Btnmultiplicar.Name = "Btnmultiplicar";
            this.Btnmultiplicar.Size = new System.Drawing.Size(75, 23);
            this.Btnmultiplicar.TabIndex = 10;
            this.Btnmultiplicar.Text = "Multi&plicar";
            this.Btnmultiplicar.UseVisualStyleBackColor = true;
            this.Btnmultiplicar.Click += new System.EventHandler(this.Btnmultiplicar_Click);
            // 
            // Btndividir
            // 
            this.Btndividir.Location = new System.Drawing.Point(464, 151);
            this.Btndividir.Name = "Btndividir";
            this.Btndividir.Size = new System.Drawing.Size(75, 23);
            this.Btndividir.TabIndex = 11;
            this.Btndividir.Text = "Dividi&r";
            this.Btndividir.UseVisualStyleBackColor = true;
            this.Btndividir.Click += new System.EventHandler(this.Btndividir_Click);
            // 
            // Btnsair
            // 
            this.Btnsair.Location = new System.Drawing.Point(464, 265);
            this.Btnsair.Name = "Btnsair";
            this.Btnsair.Size = new System.Drawing.Size(75, 23);
            this.Btnsair.TabIndex = 13;
            this.Btnsair.Text = "Sair";
            this.Btnsair.UseVisualStyleBackColor = true;
            this.Btnsair.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 363);
            this.Controls.Add(this.Btnsair);
            this.Controls.Add(this.Btndividir);
            this.Controls.Add(this.Btnmultiplicar);
            this.Controls.Add(this.Btnsubtrair);
            this.Controls.Add(this.txt2valor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblMostrar);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.Lbl2Valor);
            this.Controls.Add(this.Txt1valor);
            this.Controls.Add(this.Lbl1Valor);
            this.Controls.Add(this.Btnsomar);
            this.Name = "frmprincipal";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.frmprincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btnsomar;
        private System.Windows.Forms.Label Lbl1Valor;
        private System.Windows.Forms.TextBox Txt1valor;
        private System.Windows.Forms.Label Lbl2Valor;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Label LblMostrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt2valor;
        private System.Windows.Forms.Button Btnsubtrair;
        private System.Windows.Forms.Button Btnmultiplicar;
        private System.Windows.Forms.Button Btndividir;
        private System.Windows.Forms.Button Btnsair;
    }
}

