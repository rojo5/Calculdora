namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pantalla = new System.Windows.Forms.Label();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnPotencia = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnCambiaSigno = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 22);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pantalla
            // 
            this.pantalla.BackColor = System.Drawing.Color.DarkGray;
            this.pantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pantalla.Location = new System.Drawing.Point(12, 35);
            this.pantalla.Name = "pantalla";
            this.pantalla.Size = new System.Drawing.Size(258, 37);
            this.pantalla.TabIndex = 2;
            this.pantalla.Text = "0";
            this.pantalla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCos
            // 
            this.btnCos.Location = new System.Drawing.Point(12, 92);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(48, 47);
            this.btnCos.TabIndex = 3;
            this.btnCos.Text = "cos(x)";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnSin
            // 
            this.btnSin.Location = new System.Drawing.Point(82, 92);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(48, 47);
            this.btnSin.TabIndex = 4;
            this.btnSin.Text = "sin(x)";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnTan
            // 
            this.btnTan.Location = new System.Drawing.Point(152, 92);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(48, 47);
            this.btnTan.TabIndex = 5;
            this.btnTan.Text = "tan(x)";
            this.btnTan.UseVisualStyleBackColor = true;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnPotencia
            // 
            this.btnPotencia.Location = new System.Drawing.Point(222, 92);
            this.btnPotencia.Name = "btnPotencia";
            this.btnPotencia.Size = new System.Drawing.Size(48, 47);
            this.btnPotencia.TabIndex = 6;
            this.btnPotencia.Text = "X²";
            this.btnPotencia.UseVisualStyleBackColor = true;
            this.btnPotencia.Click += new System.EventHandler(this.btnPotencia_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.Location = new System.Drawing.Point(222, 145);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(48, 47);
            this.btnMultiplicacion.TabIndex = 10;
            this.btnMultiplicacion.Text = "X";
            this.btnMultiplicacion.UseVisualStyleBackColor = true;
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnMultiplicacion_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(152, 145);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(48, 47);
            this.btnDividir.TabIndex = 9;
            this.btnDividir.Text = "÷";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.Location = new System.Drawing.Point(82, 145);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(48, 47);
            this.btnRaiz.TabIndex = 8;
            this.btnRaiz.Text = "√";
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(12, 145);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(48, 47);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "C";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.Location = new System.Drawing.Point(222, 198);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(48, 47);
            this.btnRestar.TabIndex = 14;
            this.btnRestar.Text = "-";
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(152, 198);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(48, 47);
            this.btn9.TabIndex = 13;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(82, 198);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(48, 47);
            this.btn8.TabIndex = 12;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(12, 198);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(48, 47);
            this.btn7.TabIndex = 11;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(222, 251);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(48, 47);
            this.btnSuma.TabIndex = 18;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(152, 251);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(48, 47);
            this.btn6.TabIndex = 17;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(82, 251);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(48, 47);
            this.btn5.TabIndex = 16;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 251);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(48, 47);
            this.btn4.TabIndex = 15;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(152, 304);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(48, 47);
            this.btn3.TabIndex = 21;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(82, 304);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(48, 47);
            this.btn2.TabIndex = 20;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 304);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(48, 47);
            this.btn1.TabIndex = 19;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.Location = new System.Drawing.Point(152, 357);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(48, 47);
            this.btnPunto.TabIndex = 24;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(82, 357);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(48, 47);
            this.btn0.TabIndex = 23;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnCambiaSigno
            // 
            this.btnCambiaSigno.Location = new System.Drawing.Point(12, 357);
            this.btnCambiaSigno.Name = "btnCambiaSigno";
            this.btnCambiaSigno.Size = new System.Drawing.Size(48, 47);
            this.btnCambiaSigno.TabIndex = 22;
            this.btnCambiaSigno.Text = "±";
            this.btnCambiaSigno.UseVisualStyleBackColor = true;
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(222, 304);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(48, 100);
            this.btnResultado.TabIndex = 25;
            this.btnResultado.Text = "=";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(282, 411);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnCambiaSigno);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnPotencia);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.pantalla);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pantalla;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnPotencia;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnCambiaSigno;
        private System.Windows.Forms.Button btnResultado;
    }
}

