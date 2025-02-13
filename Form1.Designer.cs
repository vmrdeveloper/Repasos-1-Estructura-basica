namespace InscripcionItla
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNombreE = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.btnGuardarE = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombreA = new System.Windows.Forms.TextBox();
            this.btnGuardarA = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datos del estudiante";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Carrera";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(74, 51);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(102, 20);
            this.txtMatricula.TabIndex = 5;
            // 
            // txtNombreE
            // 
            this.txtNombreE.Location = new System.Drawing.Point(74, 88);
            this.txtNombreE.Name = "txtNombreE";
            this.txtNombreE.Size = new System.Drawing.Size(101, 20);
            this.txtNombreE.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(74, 121);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(101, 20);
            this.txtApellido.TabIndex = 7;
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(74, 158);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(101, 20);
            this.txtCarrera.TabIndex = 8;
            // 
            // btnGuardarE
            // 
            this.btnGuardarE.Location = new System.Drawing.Point(23, 196);
            this.btnGuardarE.Name = "btnGuardarE";
            this.btnGuardarE.Size = new System.Drawing.Size(141, 25);
            this.btnGuardarE.TabIndex = 9;
            this.btnGuardarE.Text = "Registrar Estudiante";
            this.btnGuardarE.UseVisualStyleBackColor = true;
            this.btnGuardarE.Click += new System.EventHandler(this.btnGuardarE_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGuardarE);
            this.panel1.Controls.Add(this.txtCarrera);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.txtNombreE);
            this.panel1.Controls.Add(this.txtMatricula);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 240);
            this.panel1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Codigo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nombre";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(65, 48);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(102, 20);
            this.txtCodigo.TabIndex = 10;
            // 
            // txtNombreA
            // 
            this.txtNombreA.Location = new System.Drawing.Point(65, 85);
            this.txtNombreA.Name = "txtNombreA";
            this.txtNombreA.Size = new System.Drawing.Size(102, 20);
            this.txtNombreA.TabIndex = 13;
            // 
            // btnGuardarA
            // 
            this.btnGuardarA.Location = new System.Drawing.Point(26, 118);
            this.btnGuardarA.Name = "btnGuardarA";
            this.btnGuardarA.Size = new System.Drawing.Size(141, 25);
            this.btnGuardarA.TabIndex = 10;
            this.btnGuardarA.Text = "Registrar Asignatura";
            this.btnGuardarA.UseVisualStyleBackColor = true;
            this.btnGuardarA.Click += new System.EventHandler(this.btnGuardarA_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Crear Asignatura";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnGuardarA);
            this.panel2.Controls.Add(this.txtNombreA);
            this.panel2.Controls.Add(this.txtCodigo);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(219, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 236);
            this.panel2.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(475, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Asignatura";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(416, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Horario";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(463, 83);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(102, 20);
            this.txtHorario.TabIndex = 14;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(478, 216);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 18;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(431, 130);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(194, 75);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNombreE;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.Button btnGuardarE;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombreA;
        private System.Windows.Forms.Button btnGuardarA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

