
namespace SegundoParcial
{
    partial class Informes
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
            this.dataGridViewCanalesS = new System.Windows.Forms.DataGridView();
            this.listBoxPaqueteSilver = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxPaquetePremium = new System.Windows.Forms.ListBox();
            this.dataGridViewCanalesP = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelPaqueteContratadoS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelRecaudacion = new System.Windows.Forms.Label();
            this.labelPaqueteMasMenosV = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxCanales = new System.Windows.Forms.ListBox();
            this.buttonRecaudacion = new System.Windows.Forms.Button();
            this.buttonPaqMenosVend = new System.Windows.Forms.Button();
            this.buttonPaqMasVend = new System.Windows.Forms.Button();
            this.labelPcontratadoP = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCanalesS)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCanalesP)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCanalesS
            // 
            this.dataGridViewCanalesS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCanalesS.Location = new System.Drawing.Point(135, 32);
            this.dataGridViewCanalesS.Name = "dataGridViewCanalesS";
            this.dataGridViewCanalesS.Size = new System.Drawing.Size(535, 135);
            this.dataGridViewCanalesS.TabIndex = 2;
            // 
            // listBoxPaqueteSilver
            // 
            this.listBoxPaqueteSilver.FormattingEnabled = true;
            this.listBoxPaqueteSilver.Location = new System.Drawing.Point(9, 33);
            this.listBoxPaqueteSilver.Name = "listBoxPaqueteSilver";
            this.listBoxPaqueteSilver.Size = new System.Drawing.Size(93, 134);
            this.listBoxPaqueteSilver.TabIndex = 5;
            this.listBoxPaqueteSilver.SelectedIndexChanged += new System.EventHandler(this.listBoxPaqueteSilver_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxPaquetePremium);
            this.groupBox1.Controls.Add(this.dataGridViewCanalesP);
            this.groupBox1.Controls.Add(this.dataGridViewCanalesS);
            this.groupBox1.Controls.Add(this.listBoxPaqueteSilver);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 324);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paquetes";
            // 
            // listBoxPaquetePremium
            // 
            this.listBoxPaquetePremium.FormattingEnabled = true;
            this.listBoxPaquetePremium.Location = new System.Drawing.Point(9, 173);
            this.listBoxPaquetePremium.Name = "listBoxPaquetePremium";
            this.listBoxPaquetePremium.Size = new System.Drawing.Size(93, 134);
            this.listBoxPaquetePremium.TabIndex = 7;
            this.listBoxPaquetePremium.SelectedIndexChanged += new System.EventHandler(this.listBoxPaquetePremium_SelectedIndexChanged);
            // 
            // dataGridViewCanalesP
            // 
            this.dataGridViewCanalesP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCanalesP.Location = new System.Drawing.Point(135, 173);
            this.dataGridViewCanalesP.Name = "dataGridViewCanalesP";
            this.dataGridViewCanalesP.Size = new System.Drawing.Size(535, 135);
            this.dataGridViewCanalesP.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.labelPcontratadoP);
            this.groupBox2.Controls.Add(this.labelPaqueteContratadoS);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(25, 375);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 206);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clientes";
            // 
            // labelPaqueteContratadoS
            // 
            this.labelPaqueteContratadoS.AutoSize = true;
            this.labelPaqueteContratadoS.Location = new System.Drawing.Point(141, 27);
            this.labelPaqueteContratadoS.Name = "labelPaqueteContratadoS";
            this.labelPaqueteContratadoS.Size = new System.Drawing.Size(10, 13);
            this.labelPaqueteContratadoS.TabIndex = 8;
            this.labelPaqueteContratadoS.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Paquete contratado:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.labelRecaudacion);
            this.groupBox3.Controls.Add(this.labelPaqueteMasMenosV);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.listBoxCanales);
            this.groupBox3.Controls.Add(this.buttonRecaudacion);
            this.groupBox3.Controls.Add(this.buttonPaqMenosVend);
            this.groupBox3.Controls.Add(this.buttonPaqMasVend);
            this.groupBox3.Location = new System.Drawing.Point(731, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(395, 324);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estadísticas y economía";
            // 
            // labelRecaudacion
            // 
            this.labelRecaudacion.AutoSize = true;
            this.labelRecaudacion.Location = new System.Drawing.Point(46, 252);
            this.labelRecaudacion.Name = "labelRecaudacion";
            this.labelRecaudacion.Size = new System.Drawing.Size(10, 13);
            this.labelRecaudacion.TabIndex = 11;
            this.labelRecaudacion.Text = "-";
            // 
            // labelPaqueteMasMenosV
            // 
            this.labelPaqueteMasMenosV.AutoSize = true;
            this.labelPaqueteMasMenosV.Location = new System.Drawing.Point(252, 20);
            this.labelPaqueteMasMenosV.Name = "labelPaqueteMasMenosV";
            this.labelPaqueteMasMenosV.Size = new System.Drawing.Size(10, 13);
            this.labelPaqueteMasMenosV.TabIndex = 10;
            this.labelPaqueteMasMenosV.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Paquete:";
            // 
            // listBoxCanales
            // 
            this.listBoxCanales.FormattingEnabled = true;
            this.listBoxCanales.Location = new System.Drawing.Point(199, 36);
            this.listBoxCanales.Name = "listBoxCanales";
            this.listBoxCanales.Size = new System.Drawing.Size(171, 108);
            this.listBoxCanales.TabIndex = 6;
            // 
            // buttonRecaudacion
            // 
            this.buttonRecaudacion.Location = new System.Drawing.Point(9, 195);
            this.buttonRecaudacion.Name = "buttonRecaudacion";
            this.buttonRecaudacion.Size = new System.Drawing.Size(151, 40);
            this.buttonRecaudacion.TabIndex = 2;
            this.buttonRecaudacion.Text = "Calcular recaudacion";
            this.buttonRecaudacion.UseVisualStyleBackColor = true;
            this.buttonRecaudacion.Click += new System.EventHandler(this.buttonRecaudacion_Click);
            // 
            // buttonPaqMenosVend
            // 
            this.buttonPaqMenosVend.Location = new System.Drawing.Point(9, 82);
            this.buttonPaqMenosVend.Name = "buttonPaqMenosVend";
            this.buttonPaqMenosVend.Size = new System.Drawing.Size(151, 40);
            this.buttonPaqMenosVend.TabIndex = 1;
            this.buttonPaqMenosVend.Text = "Paquete menos vendido";
            this.buttonPaqMenosVend.UseVisualStyleBackColor = true;
            this.buttonPaqMenosVend.Click += new System.EventHandler(this.buttonPaqMenosVend_Click);
            // 
            // buttonPaqMasVend
            // 
            this.buttonPaqMasVend.Location = new System.Drawing.Point(9, 36);
            this.buttonPaqMasVend.Name = "buttonPaqMasVend";
            this.buttonPaqMasVend.Size = new System.Drawing.Size(151, 40);
            this.buttonPaqMasVend.TabIndex = 0;
            this.buttonPaqMasVend.Text = "Paquete mas vendido";
            this.buttonPaqMasVend.UseVisualStyleBackColor = true;
            this.buttonPaqMasVend.Click += new System.EventHandler(this.buttonPaqMasVend_Click);
            // 
            // labelPcontratadoP
            // 
            this.labelPcontratadoP.AutoSize = true;
            this.labelPcontratadoP.Location = new System.Drawing.Point(351, 27);
            this.labelPcontratadoP.Name = "labelPcontratadoP";
            this.labelPcontratadoP.Size = new System.Drawing.Size(10, 13);
            this.labelPcontratadoP.TabIndex = 9;
            this.labelPcontratadoP.Text = "-";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(644, 147);
            this.listBox1.TabIndex = 10;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Total:";
            // 
            // Informes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 593);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Informes";
            this.Text = "Informes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Informes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCanalesS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCanalesP)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCanalesS;
        private System.Windows.Forms.ListBox listBoxPaqueteSilver;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelPaqueteContratadoS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelPaqueteMasMenosV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxCanales;
        private System.Windows.Forms.Button buttonRecaudacion;
        private System.Windows.Forms.Button buttonPaqMenosVend;
        private System.Windows.Forms.Button buttonPaqMasVend;
        private System.Windows.Forms.Label labelRecaudacion;
        private System.Windows.Forms.ListBox listBoxPaquetePremium;
        private System.Windows.Forms.DataGridView dataGridViewCanalesP;
        private System.Windows.Forms.Label labelPcontratadoP;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
    }
}