
namespace U2_1
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
            this.InstSimple = new System.Windows.Forms.Button();
            this.InstOver = new System.Windows.Forms.Button();
            this.InstParam = new System.Windows.Forms.Button();
            this.textBoxCuenta = new System.Windows.Forms.TextBox();
            this.textBoxCant = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCuenta = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.buttonRetirar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InstSimple
            // 
            this.InstSimple.Location = new System.Drawing.Point(30, 12);
            this.InstSimple.Name = "InstSimple";
            this.InstSimple.Size = new System.Drawing.Size(96, 48);
            this.InstSimple.TabIndex = 0;
            this.InstSimple.Text = "Constructor simple";
            this.InstSimple.UseVisualStyleBackColor = true;
            this.InstSimple.Click += new System.EventHandler(this.instSimple_Click);
            // 
            // InstOver
            // 
            this.InstOver.Location = new System.Drawing.Point(306, 78);
            this.InstOver.Name = "InstOver";
            this.InstOver.Size = new System.Drawing.Size(188, 51);
            this.InstOver.TabIndex = 1;
            this.InstOver.Text = "Constructor Over";
            this.InstOver.UseVisualStyleBackColor = true;
            this.InstOver.Click += new System.EventHandler(this.InstOver_Click);
            // 
            // InstParam
            // 
            this.InstParam.Location = new System.Drawing.Point(30, 78);
            this.InstParam.Name = "InstParam";
            this.InstParam.Size = new System.Drawing.Size(202, 51);
            this.InstParam.TabIndex = 2;
            this.InstParam.Text = "Constructor param";
            this.InstParam.UseVisualStyleBackColor = true;
            this.InstParam.Click += new System.EventHandler(this.InstParam_Click);
            // 
            // textBoxCuenta
            // 
            this.textBoxCuenta.Location = new System.Drawing.Point(153, 27);
            this.textBoxCuenta.Name = "textBoxCuenta";
            this.textBoxCuenta.Size = new System.Drawing.Size(127, 20);
            this.textBoxCuenta.TabIndex = 3;
            // 
            // textBoxCant
            // 
            this.textBoxCant.Location = new System.Drawing.Point(306, 27);
            this.textBoxCant.Name = "textBoxCant";
            this.textBoxCant.Size = new System.Drawing.Size(127, 20);
            this.textBoxCant.TabIndex = 4;
            this.textBoxCant.TextChanged += new System.EventHandler(this.textBoxCant_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Titular de cuenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cantidad";
            // 
            // labelCuenta
            // 
            this.labelCuenta.AutoSize = true;
            this.labelCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCuenta.Location = new System.Drawing.Point(24, 148);
            this.labelCuenta.Name = "labelCuenta";
            this.labelCuenta.Size = new System.Drawing.Size(0, 31);
            this.labelCuenta.TabIndex = 8;
            this.labelCuenta.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidad.Location = new System.Drawing.Point(251, 148);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(0, 31);
            this.labelCantidad.TabIndex = 9;
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Location = new System.Drawing.Point(30, 204);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(202, 51);
            this.buttonIngresar.TabIndex = 10;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // buttonRetirar
            // 
            this.buttonRetirar.Location = new System.Drawing.Point(292, 204);
            this.buttonRetirar.Name = "buttonRetirar";
            this.buttonRetirar.Size = new System.Drawing.Size(202, 51);
            this.buttonRetirar.TabIndex = 11;
            this.buttonRetirar.Text = "Retirar";
            this.buttonRetirar.UseVisualStyleBackColor = true;
            this.buttonRetirar.Click += new System.EventHandler(this.buttonRetirar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 379);
            this.Controls.Add(this.buttonRetirar);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.labelCuenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCant);
            this.Controls.Add(this.textBoxCuenta);
            this.Controls.Add(this.InstParam);
            this.Controls.Add(this.InstOver);
            this.Controls.Add(this.InstSimple);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InstSimple;
        private System.Windows.Forms.Button InstOver;
        private System.Windows.Forms.Button InstParam;
        private System.Windows.Forms.TextBox textBoxCuenta;
        private System.Windows.Forms.TextBox textBoxCant;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

    
        private System.Windows.Forms.Label labe6;
        private System.Windows.Forms.Label labe5;
        private System.Windows.Forms.Label labelCuenta;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.Button buttonRetirar;
    }
}

