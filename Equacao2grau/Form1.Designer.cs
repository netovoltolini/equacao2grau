namespace Equacao2grau
{
    partial class frmbaskara
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
            System.Windows.Forms.Button btncalcular;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbaskara));
            this.lbla = new System.Windows.Forms.Label();
            this.lblb = new System.Windows.Forms.Label();
            this.lblc = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txtc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtx2 = new System.Windows.Forms.TextBox();
            this.txtx1 = new System.Windows.Forms.TextBox();
            this.txtdelta = new System.Windows.Forms.TextBox();
            btncalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.BackColor = System.Drawing.Color.Transparent;
            this.lbla.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbla.ForeColor = System.Drawing.Color.Crimson;
            this.lbla.Location = new System.Drawing.Point(32, 50);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(207, 22);
            this.lbla.TabIndex = 0;
            this.lbla.Text = "Digite o valor de A :";
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.BackColor = System.Drawing.Color.Transparent;
            this.lblb.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblb.ForeColor = System.Drawing.Color.Crimson;
            this.lblb.Location = new System.Drawing.Point(32, 128);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(199, 22);
            this.lblb.TabIndex = 1;
            this.lblb.Text = "Digite o valor de B:";
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.BackColor = System.Drawing.Color.Transparent;
            this.lblc.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblc.ForeColor = System.Drawing.Color.Crimson;
            this.lblc.Location = new System.Drawing.Point(32, 228);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(201, 22);
            this.lblc.TabIndex = 2;
            this.lblc.Text = "Digite o valor de C:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.White;
            this.lbl1.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbl1.Location = new System.Drawing.Point(428, 50);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(124, 22);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Seu delta é:";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(36, 95);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(203, 20);
            this.txta.TabIndex = 5;
            this.txta.TextChanged += new System.EventHandler(this.txta_TextChanged);
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(36, 178);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(202, 20);
            this.txtb.TabIndex = 6;
            this.txtb.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(35, 267);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(203, 20);
            this.txtc.TabIndex = 7;
            this.txtc.TextChanged += new System.EventHandler(this.txtc_TextChanged);
            // 
            // btncalcular
            // 
            btncalcular.BackColor = System.Drawing.Color.PeachPuff;
            btncalcular.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btncalcular.ForeColor = System.Drawing.Color.Black;
            btncalcular.Location = new System.Drawing.Point(35, 315);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new System.Drawing.Size(122, 55);
            btncalcular.TabIndex = 12;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = false;
            btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(561, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "X1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(561, 530);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "X2:";
            // 
            // txtx2
            // 
            this.txtx2.Location = new System.Drawing.Point(624, 529);
            this.txtx2.Name = "txtx2";
            this.txtx2.Size = new System.Drawing.Size(148, 20);
            this.txtx2.TabIndex = 15;
            // 
            // txtx1
            // 
            this.txtx1.Location = new System.Drawing.Point(624, 472);
            this.txtx1.Name = "txtx1";
            this.txtx1.Size = new System.Drawing.Size(148, 20);
            this.txtx1.TabIndex = 16;
            // 
            // txtdelta
            // 
            this.txtdelta.Location = new System.Drawing.Point(565, 50);
            this.txtdelta.Name = "txtdelta";
            this.txtdelta.Size = new System.Drawing.Size(136, 20);
            this.txtdelta.TabIndex = 17;
            // 
            // frmbaskara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Equacao2grau.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.txtdelta);
            this.Controls.Add(this.txtx1);
            this.Controls.Add(this.txtx2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(btncalcular);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblc);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.lbla);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmbaskara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resolvedor de Báskara :)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtx2;
        private System.Windows.Forms.TextBox txtx1;
        private System.Windows.Forms.TextBox txtdelta;
    }
}

