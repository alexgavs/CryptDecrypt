namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEncode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDecode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCryptXOR = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDecryptXOR = new System.Windows.Forms.Button();
            this.txtEnc64 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDec64 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEnc64 = new System.Windows.Forms.Button();
            this.btnDec64 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEncode
            // 
            this.txtEncode.BackColor = System.Drawing.SystemColors.Window;
            this.txtEncode.Location = new System.Drawing.Point(51, 95);
            this.txtEncode.Name = "txtEncode";
            this.txtEncode.Size = new System.Drawing.Size(654, 20);
            this.txtEncode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Encode";
            // 
            // txtDecode
            // 
            this.txtDecode.Location = new System.Drawing.Point(51, 149);
            this.txtDecode.Name = "txtDecode";
            this.txtDecode.Size = new System.Drawing.Size(654, 20);
            this.txtDecode.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Decoder";
            // 
            // btnCryptXOR
            // 
            this.btnCryptXOR.Location = new System.Drawing.Point(749, 39);
            this.btnCryptXOR.Name = "btnCryptXOR";
            this.btnCryptXOR.Size = new System.Drawing.Size(180, 23);
            this.btnCryptXOR.TabIndex = 5;
            this.btnCryptXOR.Text = "Crypt";
            this.btnCryptXOR.UseVisualStyleBackColor = true;
            this.btnCryptXOR.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(506, 42);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(199, 20);
            this.txtKey.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "key";
            // 
            // btnDecryptXOR
            // 
            this.btnDecryptXOR.Location = new System.Drawing.Point(749, 145);
            this.btnDecryptXOR.Name = "btnDecryptXOR";
            this.btnDecryptXOR.Size = new System.Drawing.Size(180, 23);
            this.btnDecryptXOR.TabIndex = 8;
            this.btnDecryptXOR.Text = "Decrypt";
            this.btnDecryptXOR.UseVisualStyleBackColor = true;
            this.btnDecryptXOR.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtEnc64
            // 
            this.txtEnc64.Location = new System.Drawing.Point(54, 242);
            this.txtEnc64.Name = "txtEnc64";
            this.txtEnc64.Size = new System.Drawing.Size(651, 20);
            this.txtEnc64.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "EncryptBase64";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtDec64
            // 
            this.txtDec64.Location = new System.Drawing.Point(57, 318);
            this.txtDec64.Name = "txtDec64";
            this.txtDec64.Size = new System.Drawing.Size(648, 20);
            this.txtDec64.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "DecryptBase64";
            // 
            // btnEnc64
            // 
            this.btnEnc64.Location = new System.Drawing.Point(749, 242);
            this.btnEnc64.Name = "btnEnc64";
            this.btnEnc64.Size = new System.Drawing.Size(75, 23);
            this.btnEnc64.TabIndex = 13;
            this.btnEnc64.Text = "Enc64";
            this.btnEnc64.UseVisualStyleBackColor = true;
            this.btnEnc64.Click += new System.EventHandler(this.btnEnc64_Click);
            // 
            // btnDec64
            // 
            this.btnDec64.Location = new System.Drawing.Point(749, 315);
            this.btnDec64.Name = "btnDec64";
            this.btnDec64.Size = new System.Drawing.Size(75, 23);
            this.btnDec64.TabIndex = 14;
            this.btnDec64.Text = "Dec64";
            this.btnDec64.UseVisualStyleBackColor = true;
            this.btnDec64.Click += new System.EventHandler(this.btnDec64_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 472);
            this.Controls.Add(this.btnDec64);
            this.Controls.Add(this.btnEnc64);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDec64);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEnc64);
            this.Controls.Add(this.btnDecryptXOR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.btnCryptXOR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDecode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEncode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEncode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDecode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCryptXOR;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDecryptXOR;
        private System.Windows.Forms.TextBox txtEnc64;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDec64;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEnc64;
        private System.Windows.Forms.Button btnDec64;
    }
}

