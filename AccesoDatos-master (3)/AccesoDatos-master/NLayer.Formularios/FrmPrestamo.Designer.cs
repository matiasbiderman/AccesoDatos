namespace NLayer.Formularios
{
    partial class FrmPrestamo
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
            this.btnAlta = new System.Windows.Forms.Button();
            this.lstTipoPrestamos = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblcuotaint = new System.Windows.Forms.Label();
            this.txtcuotaint = new System.Windows.Forms.TextBox();
            this.txtcuotatot = new System.Windows.Forms.TextBox();
            this.txtcuotacap = new System.Windows.Forms.TextBox();
            this.txtplazo = new System.Windows.Forms.TextBox();
            this.txtmonto = new System.Windows.Forms.TextBox();
            this.txttna = new System.Windows.Forms.TextBox();
            this.txtlinea = new System.Windows.Forms.TextBox();
            this.lblcuotatot = new System.Windows.Forms.Label();
            this.lblcuotacap = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblmonto = new System.Windows.Forms.Label();
            this.lblTNA = new System.Windows.Forms.Label();
            this.lbllinea = new System.Windows.Forms.Label();
            this.btnSimular = new System.Windows.Forms.Button();
            this.lbltipoprestamo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtcomisiontot = new System.Windows.Forms.TextBox();
            this.lblcomisiontot = new System.Windows.Forms.Label();
            this.lblpdalta = new System.Windows.Forms.Label();
            this.lstPrestamos = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAlta
            // 
            this.btnAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.Location = new System.Drawing.Point(224, 336);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(165, 36);
            this.btnAlta.TabIndex = 0;
            this.btnAlta.Text = "ALTA";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // lstTipoPrestamos
            // 
            this.lstTipoPrestamos.FormattingEnabled = true;
            this.lstTipoPrestamos.Location = new System.Drawing.Point(3, 52);
            this.lstTipoPrestamos.Name = "lstTipoPrestamos";
            this.lstTipoPrestamos.Size = new System.Drawing.Size(197, 329);
            this.lstTipoPrestamos.TabIndex = 2;
            this.lstTipoPrestamos.Click += new System.EventHandler(this.lstTipoPrestamos_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblcuotaint);
            this.panel1.Controls.Add(this.txtcuotaint);
            this.panel1.Controls.Add(this.txtcuotatot);
            this.panel1.Controls.Add(this.txtcuotacap);
            this.panel1.Controls.Add(this.txtplazo);
            this.panel1.Controls.Add(this.txtmonto);
            this.panel1.Controls.Add(this.txttna);
            this.panel1.Controls.Add(this.txtlinea);
            this.panel1.Controls.Add(this.lblcuotatot);
            this.panel1.Controls.Add(this.lblcuotacap);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblmonto);
            this.panel1.Controls.Add(this.lblTNA);
            this.panel1.Controls.Add(this.lbllinea);
            this.panel1.Controls.Add(this.btnSimular);
            this.panel1.Controls.Add(this.lbltipoprestamo);
            this.panel1.Controls.Add(this.btnAlta);
            this.panel1.Controls.Add(this.lstTipoPrestamos);
            this.panel1.Location = new System.Drawing.Point(6, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 388);
            this.panel1.TabIndex = 3;
            // 
            // lblcuotaint
            // 
            this.lblcuotaint.AutoSize = true;
            this.lblcuotaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcuotaint.Location = new System.Drawing.Point(201, 262);
            this.lblcuotaint.Name = "lblcuotaint";
            this.lblcuotaint.Size = new System.Drawing.Size(91, 13);
            this.lblcuotaint.TabIndex = 18;
            this.lblcuotaint.Text = "Cuota (Interes)";
            // 
            // txtcuotaint
            // 
            this.txtcuotaint.Location = new System.Drawing.Point(293, 259);
            this.txtcuotaint.Name = "txtcuotaint";
            this.txtcuotaint.Size = new System.Drawing.Size(100, 20);
            this.txtcuotaint.TabIndex = 17;
            // 
            // txtcuotatot
            // 
            this.txtcuotatot.Location = new System.Drawing.Point(292, 296);
            this.txtcuotatot.Name = "txtcuotatot";
            this.txtcuotatot.Size = new System.Drawing.Size(100, 20);
            this.txtcuotatot.TabIndex = 16;
            // 
            // txtcuotacap
            // 
            this.txtcuotacap.Location = new System.Drawing.Point(292, 223);
            this.txtcuotacap.Name = "txtcuotacap";
            this.txtcuotacap.Size = new System.Drawing.Size(100, 20);
            this.txtcuotacap.TabIndex = 15;
            // 
            // txtplazo
            // 
            this.txtplazo.Location = new System.Drawing.Point(288, 154);
            this.txtplazo.Name = "txtplazo";
            this.txtplazo.Size = new System.Drawing.Size(100, 20);
            this.txtplazo.TabIndex = 14;
            // 
            // txtmonto
            // 
            this.txtmonto.Location = new System.Drawing.Point(288, 121);
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(100, 20);
            this.txtmonto.TabIndex = 13;
            // 
            // txttna
            // 
            this.txttna.Location = new System.Drawing.Point(288, 84);
            this.txttna.Name = "txttna";
            this.txttna.Size = new System.Drawing.Size(100, 20);
            this.txttna.TabIndex = 12;
            // 
            // txtlinea
            // 
            this.txtlinea.Location = new System.Drawing.Point(287, 48);
            this.txtlinea.Name = "txtlinea";
            this.txtlinea.Size = new System.Drawing.Size(100, 20);
            this.txtlinea.TabIndex = 11;
            // 
            // lblcuotatot
            // 
            this.lblcuotatot.AutoSize = true;
            this.lblcuotatot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcuotatot.Location = new System.Drawing.Point(201, 299);
            this.lblcuotatot.Name = "lblcuotatot";
            this.lblcuotatot.Size = new System.Drawing.Size(93, 13);
            this.lblcuotatot.TabIndex = 10;
            this.lblcuotatot.Text = "CUOTA TOTAL";
            // 
            // lblcuotacap
            // 
            this.lblcuotacap.AutoSize = true;
            this.lblcuotacap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcuotacap.Location = new System.Drawing.Point(200, 223);
            this.lblcuotacap.Name = "lblcuotacap";
            this.lblcuotacap.Size = new System.Drawing.Size(91, 13);
            this.lblcuotacap.TabIndex = 8;
            this.lblcuotacap.Text = "Cuota (Capital)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(216, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Plazo";
            // 
            // lblmonto
            // 
            this.lblmonto.AutoSize = true;
            this.lblmonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmonto.Location = new System.Drawing.Point(216, 123);
            this.lblmonto.Name = "lblmonto";
            this.lblmonto.Size = new System.Drawing.Size(42, 13);
            this.lblmonto.TabIndex = 6;
            this.lblmonto.Text = "Monto";
            // 
            // lblTNA
            // 
            this.lblTNA.AutoSize = true;
            this.lblTNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTNA.Location = new System.Drawing.Point(216, 90);
            this.lblTNA.Name = "lblTNA";
            this.lblTNA.Size = new System.Drawing.Size(32, 13);
            this.lblTNA.TabIndex = 5;
            this.lblTNA.Text = "TNA";
            // 
            // lbllinea
            // 
            this.lbllinea.AutoSize = true;
            this.lbllinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllinea.Location = new System.Drawing.Point(216, 52);
            this.lbllinea.Name = "lbllinea";
            this.lbllinea.Size = new System.Drawing.Size(38, 13);
            this.lbllinea.TabIndex = 4;
            this.lbllinea.Text = "Linea";
            // 
            // btnSimular
            // 
            this.btnSimular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimular.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSimular.Location = new System.Drawing.Point(219, 187);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(183, 23);
            this.btnSimular.TabIndex = 3;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // lbltipoprestamo
            // 
            this.lbltipoprestamo.AutoSize = true;
            this.lbltipoprestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipoprestamo.Location = new System.Drawing.Point(14, 19);
            this.lbltipoprestamo.Name = "lbltipoprestamo";
            this.lbltipoprestamo.Size = new System.Drawing.Size(154, 18);
            this.lbltipoprestamo.TabIndex = 1;
            this.lbltipoprestamo.Text = "TIPOS PRESTAMO";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtcomisiontot);
            this.panel2.Controls.Add(this.lblcomisiontot);
            this.panel2.Controls.Add(this.lblpdalta);
            this.panel2.Controls.Add(this.lstPrestamos);
            this.panel2.Location = new System.Drawing.Point(423, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 388);
            this.panel2.TabIndex = 4;
            // 
            // txtcomisiontot
            // 
            this.txtcomisiontot.Location = new System.Drawing.Point(140, 356);
            this.txtcomisiontot.Name = "txtcomisiontot";
            this.txtcomisiontot.Size = new System.Drawing.Size(202, 20);
            this.txtcomisiontot.TabIndex = 18;
            // 
            // lblcomisiontot
            // 
            this.lblcomisiontot.AutoSize = true;
            this.lblcomisiontot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcomisiontot.Location = new System.Drawing.Point(19, 359);
            this.lblcomisiontot.Name = "lblcomisiontot";
            this.lblcomisiontot.Size = new System.Drawing.Size(112, 16);
            this.lblcomisiontot.TabIndex = 2;
            this.lblcomisiontot.Text = "Comision Total";
            // 
            // lblpdalta
            // 
            this.lblpdalta.AutoSize = true;
            this.lblpdalta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpdalta.Location = new System.Drawing.Point(25, 19);
            this.lblpdalta.Name = "lblpdalta";
            this.lblpdalta.Size = new System.Drawing.Size(246, 18);
            this.lblpdalta.TabIndex = 1;
            this.lblpdalta.Text = "PRESTAMOS DADOS DE ALTA";
            // 
            // lstPrestamos
            // 
            this.lstPrestamos.FormattingEnabled = true;
            this.lstPrestamos.Location = new System.Drawing.Point(19, 52);
            this.lstPrestamos.Name = "lstPrestamos";
            this.lstPrestamos.Size = new System.Drawing.Size(323, 277);
            this.lstPrestamos.TabIndex = 0;
            // 
            // FrmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPrestamo";
            this.Text = "FrmPrestamo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrestamo_FormClosed);
            this.Load += new System.EventHandler(this.FrmPrestamo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.ListBox lstTipoPrestamos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblcuotaint;
        private System.Windows.Forms.TextBox txtcuotaint;
        private System.Windows.Forms.TextBox txtcuotatot;
        private System.Windows.Forms.TextBox txtcuotacap;
        private System.Windows.Forms.TextBox txtplazo;
        private System.Windows.Forms.TextBox txtmonto;
        private System.Windows.Forms.TextBox txttna;
        private System.Windows.Forms.TextBox txtlinea;
        private System.Windows.Forms.Label lblcuotatot;
        private System.Windows.Forms.Label lblcuotacap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblmonto;
        private System.Windows.Forms.Label lblTNA;
        private System.Windows.Forms.Label lbllinea;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.Label lbltipoprestamo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtcomisiontot;
        private System.Windows.Forms.Label lblcomisiontot;
        private System.Windows.Forms.Label lblpdalta;
        private System.Windows.Forms.ListBox lstPrestamos;
    }
}