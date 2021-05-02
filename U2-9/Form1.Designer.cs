
namespace U2_9
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Litros = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Marca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Azucar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Promocion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Origen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Litros,
            this.Precio,
            this.Marca,
            this.Azucar,
            this.Promocion,
            this.Origen});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(281, 22);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(560, 303);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Litros
            // 
            this.Litros.Text = "Litros";
            // 
            // Precio
            // 
            this.Precio.Text = "Precio";
            // 
            // Marca
            // 
            this.Marca.Text = "Marca";
            // 
            // Azucar
            // 
            this.Azucar.Text = "Azucar";
            // 
            // Promocion
            // 
            this.Promocion.Text = "Promocion";
            this.Promocion.Width = 81;
            // 
            // Origen
            // 
            this.Origen.Text = "Origen";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar producto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(52, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Calcular totales";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(52, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 38);
            this.button3.TabIndex = 3;
            this.button3.Text = "Calcular total marca";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(52, 287);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 38);
            this.button4.TabIndex = 4;
            this.button4.Text = "Calcular total estantería";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(52, 66);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(166, 38);
            this.button5.TabIndex = 5;
            this.button5.Text = "Eliminar producto";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(52, 110);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(166, 38);
            this.button6.TabIndex = 6;
            this.button6.Text = "Mostrar información";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 349);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Litros;
        private System.Windows.Forms.ColumnHeader Precio;
        private System.Windows.Forms.ColumnHeader Marca;
        private System.Windows.Forms.ColumnHeader Azucar;
        private System.Windows.Forms.ColumnHeader Promocion;
        private System.Windows.Forms.ColumnHeader Origen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

