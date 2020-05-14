namespace BasicMathOperations1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblNumber1 = new System.Windows.Forms.Label();
			this.lblNumber2 = new System.Windows.Forms.Label();
			this.lblResultType = new System.Windows.Forms.Label();
			this.txtNumber1 = new System.Windows.Forms.TextBox();
			this.txtNumber2 = new System.Windows.Forms.TextBox();
			this.lblResult = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnminus = new System.Windows.Forms.Button();
			this.btnmal = new System.Windows.Forms.Button();
			this.btndividiert = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(77, 14);
			this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(383, 51);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Einfache Rechenoperationen";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblNumber1
			// 
			this.lblNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumber1.Location = new System.Drawing.Point(20, 90);
			this.lblNumber1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblNumber1.Name = "lblNumber1";
			this.lblNumber1.Size = new System.Drawing.Size(69, 25);
			this.lblNumber1.TabIndex = 1;
			this.lblNumber1.Text = "Zahl 1";
			// 
			// lblNumber2
			// 
			this.lblNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumber2.Location = new System.Drawing.Point(16, 130);
			this.lblNumber2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblNumber2.Name = "lblNumber2";
			this.lblNumber2.Size = new System.Drawing.Size(73, 25);
			this.lblNumber2.TabIndex = 2;
			this.lblNumber2.Text = "Zahl 2";
			// 
			// lblResultType
			// 
			this.lblResultType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultType.Location = new System.Drawing.Point(16, 170);
			this.lblResultType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblResultType.Name = "lblResultType";
			this.lblResultType.Size = new System.Drawing.Size(73, 25);
			this.lblResultType.TabIndex = 3;
			this.lblResultType.Text = "Ergebnis";
			// 
			// txtNumber1
			// 
			this.txtNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumber1.Location = new System.Drawing.Point(127, 90);
			this.txtNumber1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtNumber1.Name = "txtNumber1";
			this.txtNumber1.Size = new System.Drawing.Size(151, 26);
			this.txtNumber1.TabIndex = 4;
			this.txtNumber1.Text = "0";
			this.txtNumber1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtNumber1.TextChanged += new System.EventHandler(this.txtNumber1_TextChanged);
			// 
			// txtNumber2
			// 
			this.txtNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumber2.Location = new System.Drawing.Point(127, 128);
			this.txtNumber2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtNumber2.Name = "txtNumber2";
			this.txtNumber2.Size = new System.Drawing.Size(151, 26);
			this.txtNumber2.TabIndex = 5;
			this.txtNumber2.Text = "0";
			this.txtNumber2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lblResult
			// 
			this.lblResult.BackColor = System.Drawing.Color.White;
			this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResult.Location = new System.Drawing.Point(127, 168);
			this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(149, 27);
			this.lblResult.TabIndex = 6;
			this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(312, 92);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(44, 40);
			this.btnAdd.TabIndex = 7;
			this.btnAdd.Text = "+";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnClear
			// 
			this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClear.Location = new System.Drawing.Point(219, 212);
			this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(56, 38);
			this.btnClear.TabIndex = 8;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnminus
			// 
			this.btnminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnminus.Location = new System.Drawing.Point(312, 156);
			this.btnminus.Margin = new System.Windows.Forms.Padding(2);
			this.btnminus.Name = "btnminus";
			this.btnminus.Size = new System.Drawing.Size(44, 40);
			this.btnminus.TabIndex = 9;
			this.btnminus.Text = "-\r\n";
			this.btnminus.UseVisualStyleBackColor = true;
			this.btnminus.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnmal
			// 
			this.btnmal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnmal.Location = new System.Drawing.Point(386, 92);
			this.btnmal.Margin = new System.Windows.Forms.Padding(2);
			this.btnmal.Name = "btnmal";
			this.btnmal.Size = new System.Drawing.Size(44, 40);
			this.btnmal.TabIndex = 10;
			this.btnmal.Text = "x";
			this.btnmal.UseVisualStyleBackColor = true;
			this.btnmal.Click += new System.EventHandler(this.btnmal_Click);
			// 
			// btndividiert
			// 
			this.btndividiert.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btndividiert.Location = new System.Drawing.Point(386, 155);
			this.btndividiert.Margin = new System.Windows.Forms.Padding(2);
			this.btndividiert.Name = "btndividiert";
			this.btndividiert.Size = new System.Drawing.Size(44, 40);
			this.btndividiert.TabIndex = 11;
			this.btndividiert.Text = "/";
			this.btndividiert.UseVisualStyleBackColor = true;
			this.btndividiert.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGray;
			this.ClientSize = new System.Drawing.Size(533, 292);
			this.Controls.Add(this.btndividiert);
			this.Controls.Add(this.btnmal);
			this.Controls.Add(this.btnminus);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.txtNumber2);
			this.Controls.Add(this.txtNumber1);
			this.Controls.Add(this.lblResultType);
			this.Controls.Add(this.lblNumber2);
			this.Controls.Add(this.lblNumber1);
			this.Controls.Add(this.lblTitle);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.Label lblResultType;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnminus;
		private System.Windows.Forms.Button btnmal;
		private System.Windows.Forms.Button btndividiert;
	}
}

