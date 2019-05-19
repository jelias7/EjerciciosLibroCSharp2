namespace Tarea2Ejercicios
{
    partial class Cadena
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
            this.Ordenbutton1 = new System.Windows.Forms.Button();
            this.Cadenalabel1 = new System.Windows.Forms.Label();
            this.Cadenalabel2 = new System.Windows.Forms.Label();
            this.CadtextBox1 = new System.Windows.Forms.TextBox();
            this.CadtextBox2 = new System.Windows.Forms.TextBox();
            this.CadtextBox3 = new System.Windows.Forms.TextBox();
            this.CadtextBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Ordenbutton1
            // 
            this.Ordenbutton1.Location = new System.Drawing.Point(232, 41);
            this.Ordenbutton1.Name = "Ordenbutton1";
            this.Ordenbutton1.Size = new System.Drawing.Size(75, 23);
            this.Ordenbutton1.TabIndex = 0;
            this.Ordenbutton1.Text = "Ordenar";
            this.Ordenbutton1.UseVisualStyleBackColor = true;
            this.Ordenbutton1.Click += new System.EventHandler(this.Ordenbutton1_Click);
            // 
            // Cadenalabel1
            // 
            this.Cadenalabel1.AutoSize = true;
            this.Cadenalabel1.Location = new System.Drawing.Point(13, 41);
            this.Cadenalabel1.Name = "Cadenalabel1";
            this.Cadenalabel1.Size = new System.Drawing.Size(44, 13);
            this.Cadenalabel1.TabIndex = 1;
            this.Cadenalabel1.Text = "Cadena";
            // 
            // Cadenalabel2
            // 
            this.Cadenalabel2.AutoSize = true;
            this.Cadenalabel2.Location = new System.Drawing.Point(13, 116);
            this.Cadenalabel2.Name = "Cadenalabel2";
            this.Cadenalabel2.Size = new System.Drawing.Size(44, 13);
            this.Cadenalabel2.TabIndex = 2;
            this.Cadenalabel2.Text = "Cadena";
            // 
            // CadtextBox1
            // 
            this.CadtextBox1.Location = new System.Drawing.Point(66, 41);
            this.CadtextBox1.Name = "CadtextBox1";
            this.CadtextBox1.Size = new System.Drawing.Size(146, 20);
            this.CadtextBox1.TabIndex = 3;
            // 
            // CadtextBox2
            // 
            this.CadtextBox2.Location = new System.Drawing.Point(66, 109);
            this.CadtextBox2.Name = "CadtextBox2";
            this.CadtextBox2.Size = new System.Drawing.Size(146, 20);
            this.CadtextBox2.TabIndex = 4;
            // 
            // CadtextBox3
            // 
            this.CadtextBox3.Location = new System.Drawing.Point(66, 183);
            this.CadtextBox3.Name = "CadtextBox3";
            this.CadtextBox3.Size = new System.Drawing.Size(146, 20);
            this.CadtextBox3.TabIndex = 5;
            // 
            // CadtextBox4
            // 
            this.CadtextBox4.Location = new System.Drawing.Point(66, 236);
            this.CadtextBox4.Name = "CadtextBox4";
            this.CadtextBox4.Size = new System.Drawing.Size(146, 20);
            this.CadtextBox4.TabIndex = 6;
            // 
            // Cadena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CadtextBox4);
            this.Controls.Add(this.CadtextBox3);
            this.Controls.Add(this.CadtextBox2);
            this.Controls.Add(this.CadtextBox1);
            this.Controls.Add(this.Cadenalabel2);
            this.Controls.Add(this.Cadenalabel1);
            this.Controls.Add(this.Ordenbutton1);
            this.Name = "Cadena";
            this.Text = "Cadena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ordenbutton1;
        private System.Windows.Forms.Label Cadenalabel1;
        private System.Windows.Forms.Label Cadenalabel2;
        private System.Windows.Forms.TextBox CadtextBox1;
        private System.Windows.Forms.TextBox CadtextBox2;
        private System.Windows.Forms.TextBox CadtextBox3;
        private System.Windows.Forms.TextBox CadtextBox4;
    }
}