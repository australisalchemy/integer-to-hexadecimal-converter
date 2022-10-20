namespace IntHex
{
    partial class frmMain
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
            this.gbHex = new System.Windows.Forms.GroupBox();
            this.txtInputHex = new System.Windows.Forms.TextBox();
            this.txtHex = new System.Windows.Forms.TextBox();
            this.gbDec = new System.Windows.Forms.GroupBox();
            this.txtInputDec = new System.Windows.Forms.TextBox();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.gbBinary = new System.Windows.Forms.GroupBox();
            this.txtBinInput = new System.Windows.Forms.TextBox();
            this.txtBinary = new System.Windows.Forms.TextBox();
            this.gbHex.SuspendLayout();
            this.gbDec.SuspendLayout();
            this.gbBinary.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbHex
            // 
            this.gbHex.Controls.Add(this.txtInputHex);
            this.gbHex.Controls.Add(this.txtHex);
            this.gbHex.Location = new System.Drawing.Point(12, 7);
            this.gbHex.Name = "gbHex";
            this.gbHex.Size = new System.Drawing.Size(171, 259);
            this.gbHex.TabIndex = 0;
            this.gbHex.TabStop = false;
            this.gbHex.Text = "Hexadecimal";
            // 
            // txtInputHex
            // 
            this.txtInputHex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInputHex.Location = new System.Drawing.Point(6, 231);
            this.txtInputHex.Name = "txtInputHex";
            this.txtInputHex.Size = new System.Drawing.Size(159, 20);
            this.txtInputHex.TabIndex = 3;
            this.txtInputHex.TextChanged += new System.EventHandler(this.txtInputHex_TextChanged);
            // 
            // txtHex
            // 
            this.txtHex.BackColor = System.Drawing.SystemColors.Control;
            this.txtHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHex.Location = new System.Drawing.Point(6, 19);
            this.txtHex.Multiline = true;
            this.txtHex.Name = "txtHex";
            this.txtHex.ReadOnly = true;
            this.txtHex.Size = new System.Drawing.Size(159, 171);
            this.txtHex.TabIndex = 0;
            this.txtHex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbDec
            // 
            this.gbDec.Controls.Add(this.txtInputDec);
            this.gbDec.Controls.Add(this.txtDecimal);
            this.gbDec.Location = new System.Drawing.Point(189, 7);
            this.gbDec.Name = "gbDec";
            this.gbDec.Size = new System.Drawing.Size(171, 259);
            this.gbDec.TabIndex = 1;
            this.gbDec.TabStop = false;
            this.gbDec.Text = "Decimal";
            // 
            // txtInputDec
            // 
            this.txtInputDec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInputDec.Location = new System.Drawing.Point(6, 231);
            this.txtInputDec.Name = "txtInputDec";
            this.txtInputDec.Size = new System.Drawing.Size(159, 20);
            this.txtInputDec.TabIndex = 4;
            this.txtInputDec.TextChanged += new System.EventHandler(this.txtInputDec_TextChanged);
            // 
            // txtDecimal
            // 
            this.txtDecimal.BackColor = System.Drawing.SystemColors.Control;
            this.txtDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecimal.Location = new System.Drawing.Point(6, 19);
            this.txtDecimal.Multiline = true;
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.ReadOnly = true;
            this.txtDecimal.Size = new System.Drawing.Size(159, 171);
            this.txtDecimal.TabIndex = 3;
            this.txtDecimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbBinary
            // 
            this.gbBinary.Controls.Add(this.txtBinInput);
            this.gbBinary.Controls.Add(this.txtBinary);
            this.gbBinary.Location = new System.Drawing.Point(366, 7);
            this.gbBinary.Name = "gbBinary";
            this.gbBinary.Size = new System.Drawing.Size(171, 259);
            this.gbBinary.TabIndex = 2;
            this.gbBinary.TabStop = false;
            this.gbBinary.Text = "Binary";
            // 
            // txtBinInput
            // 
            this.txtBinInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBinInput.Location = new System.Drawing.Point(6, 231);
            this.txtBinInput.Name = "txtBinInput";
            this.txtBinInput.Size = new System.Drawing.Size(159, 20);
            this.txtBinInput.TabIndex = 4;
            this.txtBinInput.TextChanged += new System.EventHandler(this.txtBinInput_TextChanged);
            // 
            // txtBinary
            // 
            this.txtBinary.BackColor = System.Drawing.SystemColors.Control;
            this.txtBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBinary.Location = new System.Drawing.Point(6, 19);
            this.txtBinary.Multiline = true;
            this.txtBinary.Name = "txtBinary";
            this.txtBinary.ReadOnly = true;
            this.txtBinary.Size = new System.Drawing.Size(159, 171);
            this.txtBinary.TabIndex = 3;
            this.txtBinary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 270);
            this.Controls.Add(this.gbBinary);
            this.Controls.Add(this.gbDec);
            this.Controls.Add(this.gbHex);
            this.Name = "frmMain";
            this.Text = "IntHexBin Calculator";
            this.gbHex.ResumeLayout(false);
            this.gbHex.PerformLayout();
            this.gbDec.ResumeLayout(false);
            this.gbDec.PerformLayout();
            this.gbBinary.ResumeLayout(false);
            this.gbBinary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbHex;
        private System.Windows.Forms.TextBox txtHex;
        private System.Windows.Forms.GroupBox gbDec;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.TextBox txtInputHex;
        private System.Windows.Forms.TextBox txtInputDec;
        private System.Windows.Forms.GroupBox gbBinary;
        private System.Windows.Forms.TextBox txtBinInput;
        private System.Windows.Forms.TextBox txtBinary;
    }
}

