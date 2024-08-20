namespace GestorDeEstudantesT6
{
    partial class FormEstatisticas
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
            this.labelTotalDeAlunos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelMeninos = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelMeninas = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTotalDeAlunos
            // 
            this.labelTotalDeAlunos.AutoSize = true;
            this.labelTotalDeAlunos.Location = new System.Drawing.Point(337, 108);
            this.labelTotalDeAlunos.Name = "labelTotalDeAlunos";
            this.labelTotalDeAlunos.Size = new System.Drawing.Size(105, 13);
            this.labelTotalDeAlunos.TabIndex = 0;
            this.labelTotalDeAlunos.Text = "Total de Alunos: 999";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.labelTotalDeAlunos);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 244);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cyan;
            this.panel2.Controls.Add(this.labelMeninos);
            this.panel2.Location = new System.Drawing.Point(12, 262);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(387, 235);
            this.panel2.TabIndex = 2;
            // 
            // labelMeninos
            // 
            this.labelMeninos.AutoSize = true;
            this.labelMeninos.Location = new System.Drawing.Point(145, 110);
            this.labelMeninos.Name = "labelMeninos";
            this.labelMeninos.Size = new System.Drawing.Size(73, 13);
            this.labelMeninos.TabIndex = 0;
            this.labelMeninos.Text = "Meninos: 50%";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Crimson;
            this.panel3.Controls.Add(this.labelMeninas);
            this.panel3.Location = new System.Drawing.Point(405, 262);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(383, 235);
            this.panel3.TabIndex = 3;
            // 
            // labelMeninas
            // 
            this.labelMeninas.AutoSize = true;
            this.labelMeninas.Location = new System.Drawing.Point(163, 110);
            this.labelMeninas.Name = "labelMeninas";
            this.labelMeninas.Size = new System.Drawing.Size(73, 13);
            this.labelMeninas.TabIndex = 0;
            this.labelMeninas.Text = "Meninas: 50%";
            // 
            // FormEstatisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormEstatisticas";
            this.Text = "FormEstatisticas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTotalDeAlunos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelMeninos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelMeninas;
    }
}