namespace Lagrange
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtEcuacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbP = new System.Windows.Forms.ComboBox();
            this.lblFormula = new System.Windows.Forms.Label();
            this.lblX0 = new System.Windows.Forms.Label();
            this.txtX0 = new System.Windows.Forms.TextBox();
            this.lblX1 = new System.Windows.Forms.Label();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.lblX2 = new System.Windows.Forms.Label();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInterpolar = new System.Windows.Forms.TextBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this._i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._fx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblX3 = new System.Windows.Forms.Label();
            this.txtX3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pbFormula = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormula)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEcuacion
            // 
            this.txtEcuacion.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEcuacion.Location = new System.Drawing.Point(149, 114);
            this.txtEcuacion.Name = "txtEcuacion";
            this.txtEcuacion.Size = new System.Drawing.Size(121, 24);
            this.txtEcuacion.TabIndex = 0;
            this.txtEcuacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEcuacion.TextChanged += new System.EventHandler(this.txtX0_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ecuación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(76, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Grado P:";
            // 
            // cbP
            // 
            this.cbP.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbP.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbP.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbP.FormattingEnabled = true;
            this.cbP.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbP.Location = new System.Drawing.Point(149, 158);
            this.cbP.MaxDropDownItems = 3;
            this.cbP.Name = "cbP";
            this.cbP.Size = new System.Drawing.Size(121, 27);
            this.cbP.TabIndex = 1;
            this.cbP.SelectedIndexChanged += new System.EventHandler(this.cbP_SelectedIndexChanged);
            // 
            // lblFormula
            // 
            this.lblFormula.AutoSize = true;
            this.lblFormula.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormula.ForeColor = System.Drawing.Color.White;
            this.lblFormula.Location = new System.Drawing.Point(173, 230);
            this.lblFormula.Name = "lblFormula";
            this.lblFormula.Size = new System.Drawing.Size(154, 26);
            this.lblFormula.TabIndex = 4;
            this.lblFormula.Text = "Fórmula a usar";
            // 
            // lblX0
            // 
            this.lblX0.AutoSize = true;
            this.lblX0.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX0.ForeColor = System.Drawing.Color.White;
            this.lblX0.Location = new System.Drawing.Point(351, 97);
            this.lblX0.Name = "lblX0";
            this.lblX0.Size = new System.Drawing.Size(32, 20);
            this.lblX0.TabIndex = 7;
            this.lblX0.Text = "X0:";
            // 
            // txtX0
            // 
            this.txtX0.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX0.Location = new System.Drawing.Point(385, 95);
            this.txtX0.MaxLength = 5;
            this.txtX0.Name = "txtX0";
            this.txtX0.ShortcutsEnabled = false;
            this.txtX0.Size = new System.Drawing.Size(35, 24);
            this.txtX0.TabIndex = 2;
            this.txtX0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtX0.TextChanged += new System.EventHandler(this.txtX0_TextChanged);
            this.txtX0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtX0_KeyPress);
            // 
            // lblX1
            // 
            this.lblX1.AutoSize = true;
            this.lblX1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX1.ForeColor = System.Drawing.Color.White;
            this.lblX1.Location = new System.Drawing.Point(347, 127);
            this.lblX1.Name = "lblX1";
            this.lblX1.Size = new System.Drawing.Size(36, 20);
            this.lblX1.TabIndex = 9;
            this.lblX1.Text = " X1:";
            // 
            // txtX1
            // 
            this.txtX1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX1.Location = new System.Drawing.Point(385, 125);
            this.txtX1.MaxLength = 5;
            this.txtX1.Name = "txtX1";
            this.txtX1.ShortcutsEnabled = false;
            this.txtX1.Size = new System.Drawing.Size(35, 24);
            this.txtX1.TabIndex = 3;
            this.txtX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtX1.TextChanged += new System.EventHandler(this.txtX0_TextChanged);
            this.txtX1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtX0_KeyPress);
            // 
            // lblX2
            // 
            this.lblX2.AutoSize = true;
            this.lblX2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX2.ForeColor = System.Drawing.Color.White;
            this.lblX2.Location = new System.Drawing.Point(347, 159);
            this.lblX2.Name = "lblX2";
            this.lblX2.Size = new System.Drawing.Size(36, 20);
            this.lblX2.TabIndex = 11;
            this.lblX2.Text = " X2:";
            // 
            // txtX2
            // 
            this.txtX2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX2.Location = new System.Drawing.Point(385, 155);
            this.txtX2.MaxLength = 5;
            this.txtX2.Name = "txtX2";
            this.txtX2.ShortcutsEnabled = false;
            this.txtX2.Size = new System.Drawing.Size(35, 24);
            this.txtX2.TabIndex = 4;
            this.txtX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtX2.TextChanged += new System.EventHandler(this.txtX0_TextChanged);
            this.txtX2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtX0_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(67, 466);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Valor a interpolar:";
            // 
            // txtInterpolar
            // 
            this.txtInterpolar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterpolar.Location = new System.Drawing.Point(208, 464);
            this.txtInterpolar.MaxLength = 5;
            this.txtInterpolar.Name = "txtInterpolar";
            this.txtInterpolar.ShortcutsEnabled = false;
            this.txtInterpolar.Size = new System.Drawing.Size(35, 24);
            this.txtInterpolar.TabIndex = 6;
            this.txtInterpolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInterpolar.TextChanged += new System.EventHandler(this.txtX0_TextChanged);
            this.txtInterpolar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtX0_KeyPress);
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AllowUserToResizeColumns = false;
            this.dgv1.AllowUserToResizeRows = false;
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(119)))));
            this.dgv1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._i,
            this._x,
            this._fx});
            this.dgv1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv1.Location = new System.Drawing.Point(46, 502);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgv1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv1.Size = new System.Drawing.Size(240, 150);
            this.dgv1.TabIndex = 14;
            // 
            // _i
            // 
            this._i.HeaderText = "Iteración";
            this._i.Name = "_i";
            this._i.ReadOnly = true;
            // 
            // _x
            // 
            this._x.HeaderText = "x";
            this._x.Name = "_x";
            this._x.ReadOnly = true;
            // 
            // _fx
            // 
            this._fx.HeaderText = "f(x)";
            this._fx.Name = "_fx";
            this._fx.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(355, 579);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.ForeColor = System.Drawing.Color.White;
            this.txtResultado.Location = new System.Drawing.Point(351, 602);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(90, 24);
            this.txtResultado.TabIndex = 15;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(119)))));
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(72)))));
            this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(252)))));
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Image = global::Lagrange.Properties.Resources.calcular_35;
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Location = new System.Drawing.Point(329, 477);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(121, 38);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(119)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(72)))));
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(252)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Image = global::Lagrange.Properties.Resources.limpiar_35;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(329, 522);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(121, 38);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblX3
            // 
            this.lblX3.AutoSize = true;
            this.lblX3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX3.ForeColor = System.Drawing.Color.White;
            this.lblX3.Location = new System.Drawing.Point(351, 187);
            this.lblX3.Name = "lblX3";
            this.lblX3.Size = new System.Drawing.Size(32, 20);
            this.lblX3.TabIndex = 20;
            this.lblX3.Text = "X3:";
            // 
            // txtX3
            // 
            this.txtX3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX3.Location = new System.Drawing.Point(385, 185);
            this.txtX3.MaxLength = 5;
            this.txtX3.Name = "txtX3";
            this.txtX3.ShortcutsEnabled = false;
            this.txtX3.Size = new System.Drawing.Size(35, 24);
            this.txtX3.TabIndex = 5;
            this.txtX3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtX3.TextChanged += new System.EventHandler(this.txtX0_TextChanged);
            this.txtX3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtX0_KeyPress);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(14, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(520, 40);
            this.label6.TabIndex = 21;
            this.label6.Text = "INTERPOLACIÓN DE LAGRANGE";
            // 
            // pbFormula
            // 
            this.pbFormula.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pbFormula.Location = new System.Drawing.Point(35, 259);
            this.pbFormula.Name = "pbFormula";
            this.pbFormula.Size = new System.Drawing.Size(445, 197);
            this.pbFormula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFormula.TabIndex = 5;
            this.pbFormula.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(518, 664);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblX3);
            this.Controls.Add(this.txtX3);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInterpolar);
            this.Controls.Add(this.lblX2);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.lblX1);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.lblX0);
            this.Controls.Add(this.txtX0);
            this.Controls.Add(this.pbFormula);
            this.Controls.Add(this.lblFormula);
            this.Controls.Add(this.cbP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEcuacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Interpolación de Lagrange";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEcuacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbP;
        private System.Windows.Forms.Label lblFormula;
        private System.Windows.Forms.PictureBox pbFormula;
        private System.Windows.Forms.Label lblX0;
        private System.Windows.Forms.TextBox txtX0;
        private System.Windows.Forms.Label lblX1;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.Label lblX2;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInterpolar;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn _i;
        private System.Windows.Forms.DataGridViewTextBoxColumn _x;
        private System.Windows.Forms.DataGridViewTextBoxColumn _fx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblX3;
        private System.Windows.Forms.TextBox txtX3;
        private System.Windows.Forms.Label label6;
    }
}

