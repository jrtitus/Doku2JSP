namespace WindowsFormsApplication1
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
            this.convertBtn = new System.Windows.Forms.Button();
            this.dokuInput = new System.Windows.Forms.TextBox();
            this.jspOutput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.copyBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // convertBtn
            // 
            this.convertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertBtn.Location = new System.Drawing.Point(21, 371);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(378, 51);
            this.convertBtn.TabIndex = 1;
            this.convertBtn.Text = "Convert";
            this.convertBtn.UseVisualStyleBackColor = true;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // dokuInput
            // 
            this.dokuInput.AcceptsReturn = true;
            this.dokuInput.AcceptsTab = true;
            this.dokuInput.AllowDrop = true;
            this.dokuInput.Location = new System.Drawing.Point(6, 24);
            this.dokuInput.Multiline = true;
            this.dokuInput.Name = "dokuInput";
            this.dokuInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dokuInput.Size = new System.Drawing.Size(481, 150);
            this.dokuInput.TabIndex = 0;
            this.dokuInput.WordWrap = false;
            // 
            // jspOutput
            // 
            this.jspOutput.AcceptsReturn = true;
            this.jspOutput.AcceptsTab = true;
            this.jspOutput.CausesValidation = false;
            this.jspOutput.Location = new System.Drawing.Point(6, 193);
            this.jspOutput.Multiline = true;
            this.jspOutput.Name = "jspOutput";
            this.jspOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.jspOutput.Size = new System.Drawing.Size(481, 154);
            this.jspOutput.TabIndex = 2;
            this.jspOutput.WordWrap = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.jspOutput);
            this.groupBox1.Controls.Add(this.dokuInput);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 353);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "JSPWiki Output";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "DokiWiki Input";
            // 
            // copyBtn
            // 
            this.copyBtn.Location = new System.Drawing.Point(405, 371);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(94, 51);
            this.copyBtn.TabIndex = 3;
            this.copyBtn.Text = "Copy Output";
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 434);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.convertBtn);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(527, 472);
            this.Name = "Form1";
            this.Text = "Doku-2-JSP";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button convertBtn;
        private System.Windows.Forms.TextBox dokuInput;
        private System.Windows.Forms.TextBox jspOutput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button copyBtn;
    }
}

