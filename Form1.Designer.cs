namespace Laboratorio_7
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOrdenarAsc = new System.Windows.Forms.Button();
            this.btnOrdenarDesc = new System.Windows.Forms.Button();
            this.lblMayorc = new System.Windows.Forms.Label();
            this.lblMenorC = new System.Windows.Forms.Label();
            this.lblPropietarioC = new System.Windows.Forms.Label();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(65, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(430, 190);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnOrdenarAsc
            // 
            this.btnOrdenarAsc.Location = new System.Drawing.Point(524, 104);
            this.btnOrdenarAsc.Name = "btnOrdenarAsc";
            this.btnOrdenarAsc.Size = new System.Drawing.Size(130, 23);
            this.btnOrdenarAsc.TabIndex = 1;
            this.btnOrdenarAsc.Text = "Ordenar Ascendente";
            this.btnOrdenarAsc.UseVisualStyleBackColor = true;
            this.btnOrdenarAsc.Click += new System.EventHandler(this.btnOrdenarAsc_Click);
            // 
            // btnOrdenarDesc
            // 
            this.btnOrdenarDesc.Location = new System.Drawing.Point(524, 148);
            this.btnOrdenarDesc.Name = "btnOrdenarDesc";
            this.btnOrdenarDesc.Size = new System.Drawing.Size(128, 23);
            this.btnOrdenarDesc.TabIndex = 2;
            this.btnOrdenarDesc.Text = "Ordenar Descendente";
            this.btnOrdenarDesc.UseVisualStyleBackColor = true;
            this.btnOrdenarDesc.Click += new System.EventHandler(this.btnOrdenarDesc_Click);
            // 
            // lblMayorc
            // 
            this.lblMayorc.AutoSize = true;
            this.lblMayorc.Location = new System.Drawing.Point(167, 273);
            this.lblMayorc.Name = "lblMayorc";
            this.lblMayorc.Size = new System.Drawing.Size(35, 13);
            this.lblMayorc.TabIndex = 3;
            this.lblMayorc.Text = "label1";
            // 
            // lblMenorC
            // 
            this.lblMenorC.AutoSize = true;
            this.lblMenorC.Location = new System.Drawing.Point(167, 309);
            this.lblMenorC.Name = "lblMenorC";
            this.lblMenorC.Size = new System.Drawing.Size(35, 13);
            this.lblMenorC.TabIndex = 4;
            this.lblMenorC.Text = "label2";
            // 
            // lblPropietarioC
            // 
            this.lblPropietarioC.AutoSize = true;
            this.lblPropietarioC.Location = new System.Drawing.Point(272, 344);
            this.lblPropietarioC.Name = "lblPropietarioC";
            this.lblPropietarioC.Size = new System.Drawing.Size(35, 13);
            this.lblPropietarioC.TabIndex = 5;
            this.lblPropietarioC.Text = "label3";
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(524, 61);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(128, 23);
            this.btnMostrarDatos.TabIndex = 6;
            this.btnMostrarDatos.Text = "Mostrar";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(367, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cuotas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cuota mayor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cuota menor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Propietario con cuota más alta:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 401);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.lblPropietarioC);
            this.Controls.Add(this.lblMenorC);
            this.Controls.Add(this.lblMayorc);
            this.Controls.Add(this.btnOrdenarDesc);
            this.Controls.Add(this.btnOrdenarAsc);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOrdenarAsc;
        private System.Windows.Forms.Button btnOrdenarDesc;
        private System.Windows.Forms.Label lblMayorc;
        private System.Windows.Forms.Label lblMenorC;
        private System.Windows.Forms.Label lblPropietarioC;
        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

