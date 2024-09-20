
namespace Morse_Code_Decoder
{
    partial class Form1
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
            this.txtMorseCode = new System.Windows.Forms.TextBox();
            this.lblDecodedText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDecode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMorseCode
            // 
            this.txtMorseCode.Location = new System.Drawing.Point(118, 129);
            this.txtMorseCode.Multiline = true;
            this.txtMorseCode.Name = "txtMorseCode";
            this.txtMorseCode.Size = new System.Drawing.Size(273, 264);
            this.txtMorseCode.TabIndex = 0;
            // 
            // lblDecodedText
            // 
            this.lblDecodedText.Location = new System.Drawing.Point(682, 129);
            this.lblDecodedText.Multiline = true;
            this.lblDecodedText.Name = "lblDecodedText";
            this.lblDecodedText.Size = new System.Drawing.Size(273, 264);
            this.lblDecodedText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "THE BLACK SOCIETY";
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(476, 229);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(126, 40);
            this.btnDecode.TabIndex = 3;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(911, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Morse Code Decoder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 470);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDecodedText);
            this.Controls.Add(this.txtMorseCode);
            this.Name = "Form1";
            this.Text = "Decoder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMorseCode;
        private System.Windows.Forms.TextBox lblDecodedText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.Label label2;
    }
}

