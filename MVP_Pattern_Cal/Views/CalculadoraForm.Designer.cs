namespace MVP_Pattern_Cal
{
    partial class CalculadoraForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSumar = new System.Windows.Forms.Button();
            this.BtnRestar = new System.Windows.Forms.Button();
            this.BtnMult = new System.Windows.Forms.Button();
            this.BtnDividir = new System.Windows.Forms.Button();
            this.txtFirstNumber = new System.Windows.Forms.TextBox();
            this.txtSecondNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnClean = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primer Numero";
            // 
            // BtnSumar
            // 
            this.BtnSumar.Location = new System.Drawing.Point(153, 235);
            this.BtnSumar.Name = "BtnSumar";
            this.BtnSumar.Size = new System.Drawing.Size(75, 37);
            this.BtnSumar.TabIndex = 1;
            this.BtnSumar.Text = "Sumar";
            this.BtnSumar.UseVisualStyleBackColor = true;
            // 
            // BtnRestar
            // 
            this.BtnRestar.Location = new System.Drawing.Point(259, 235);
            this.BtnRestar.Name = "BtnRestar";
            this.BtnRestar.Size = new System.Drawing.Size(75, 37);
            this.BtnRestar.TabIndex = 2;
            this.BtnRestar.Text = "Restar";
            this.BtnRestar.UseVisualStyleBackColor = true;
            // 
            // BtnMult
            // 
            this.BtnMult.Location = new System.Drawing.Point(360, 235);
            this.BtnMult.Name = "BtnMult";
            this.BtnMult.Size = new System.Drawing.Size(95, 37);
            this.BtnMult.TabIndex = 3;
            this.BtnMult.Text = "Multiplicar";
            this.BtnMult.UseVisualStyleBackColor = true;
            // 
            // BtnDividir
            // 
            this.BtnDividir.Location = new System.Drawing.Point(474, 235);
            this.BtnDividir.Name = "BtnDividir";
            this.BtnDividir.Size = new System.Drawing.Size(75, 37);
            this.BtnDividir.TabIndex = 4;
            this.BtnDividir.Text = "Dividir";
            this.BtnDividir.UseVisualStyleBackColor = true;
            // 
            // txtFirstNumber
            // 
            this.txtFirstNumber.Location = new System.Drawing.Point(292, 85);
            this.txtFirstNumber.Name = "txtFirstNumber";
            this.txtFirstNumber.Size = new System.Drawing.Size(186, 26);
            this.txtFirstNumber.TabIndex = 5;
            // 
            // txtSecondNumber
            // 
            this.txtSecondNumber.Location = new System.Drawing.Point(292, 143);
            this.txtSecondNumber.Name = "txtSecondNumber";
            this.txtSecondNumber.Size = new System.Drawing.Size(186, 26);
            this.txtSecondNumber.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Segundo Numero";
            // 
            // BtnClean
            // 
            this.BtnClean.Location = new System.Drawing.Point(317, 294);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(75, 37);
            this.BtnClean.TabIndex = 8;
            this.BtnClean.Text = "C";
            this.BtnClean.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(532, 118);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(82, 20);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "Resultado";
            // 
            // CalculadoraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 343);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.BtnClean);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSecondNumber);
            this.Controls.Add(this.txtFirstNumber);
            this.Controls.Add(this.BtnDividir);
            this.Controls.Add(this.BtnMult);
            this.Controls.Add(this.BtnRestar);
            this.Controls.Add(this.BtnSumar);
            this.Controls.Add(this.label1);
            this.Name = "CalculadoraForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSumar;
        private System.Windows.Forms.Button BtnRestar;
        private System.Windows.Forms.Button BtnMult;
        private System.Windows.Forms.Button BtnDividir;
        private System.Windows.Forms.TextBox txtFirstNumber;
        private System.Windows.Forms.TextBox txtSecondNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnClean;
        private System.Windows.Forms.Label lblResultado;
    }
}

