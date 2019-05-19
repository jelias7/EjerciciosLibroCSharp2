namespace Tarea2Ejercicios
{
    partial class Factorial
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
            this.TituloLabel = new System.Windows.Forms.Label();
            this.IngreseLabel = new System.Windows.Forms.Label();
            this.IngresetextBox = new System.Windows.Forms.TextBox();
            this.ResultadoLabel = new System.Windows.Forms.Label();
            this.ResultadotextBox = new System.Windows.Forms.TextBox();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TituloLabel
            // 
            this.TituloLabel.AutoSize = true;
            this.TituloLabel.Location = new System.Drawing.Point(344, 9);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(121, 13);
            this.TituloLabel.TabIndex = 0;
            this.TituloLabel.Text = "Factorial De Un Numero";
            // 
            // IngreseLabel
            // 
            this.IngreseLabel.AutoSize = true;
            this.IngreseLabel.Location = new System.Drawing.Point(13, 36);
            this.IngreseLabel.Name = "IngreseLabel";
            this.IngreseLabel.Size = new System.Drawing.Size(82, 13);
            this.IngreseLabel.TabIndex = 1;
            this.IngreseLabel.Text = "Ingrese Numero";
            // 
            // IngresetextBox
            // 
            this.IngresetextBox.Location = new System.Drawing.Point(125, 36);
            this.IngresetextBox.Name = "IngresetextBox";
            this.IngresetextBox.Size = new System.Drawing.Size(156, 20);
            this.IngresetextBox.TabIndex = 2;
            // 
            // ResultadoLabel
            // 
            this.ResultadoLabel.AutoSize = true;
            this.ResultadoLabel.Location = new System.Drawing.Point(13, 101);
            this.ResultadoLabel.Name = "ResultadoLabel";
            this.ResultadoLabel.Size = new System.Drawing.Size(55, 13);
            this.ResultadoLabel.TabIndex = 3;
            this.ResultadoLabel.Text = "Resultado";
            // 
            // ResultadotextBox
            // 
            this.ResultadotextBox.Location = new System.Drawing.Point(125, 101);
            this.ResultadotextBox.Name = "ResultadotextBox";
            this.ResultadotextBox.ReadOnly = true;
            this.ResultadotextBox.Size = new System.Drawing.Size(156, 20);
            this.ResultadotextBox.TabIndex = 4;
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(125, 164);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(75, 23);
            this.CalcularButton.TabIndex = 5;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // Factorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.ResultadotextBox);
            this.Controls.Add(this.ResultadoLabel);
            this.Controls.Add(this.IngresetextBox);
            this.Controls.Add(this.IngreseLabel);
            this.Controls.Add(this.TituloLabel);
            this.Name = "Factorial";
            this.Text = "Factorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TituloLabel;
        private System.Windows.Forms.Label IngreseLabel;
        private System.Windows.Forms.TextBox IngresetextBox;
        private System.Windows.Forms.Label ResultadoLabel;
        private System.Windows.Forms.TextBox ResultadotextBox;
        private System.Windows.Forms.Button CalcularButton;
    }
}