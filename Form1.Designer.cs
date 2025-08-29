namespace LocalSettingsFileGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new System.Windows.Forms.TextBox();
            btnGenerate = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            textBox2 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            lblResposne = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new System.Drawing.Font("Courier New", 12F);
            textBox1.Location = new System.Drawing.Point(22, 50);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textBox1.Size = new System.Drawing.Size(1029, 261);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnGenerate
            // 
            btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGenerate.Font = new System.Drawing.Font("Segoe UI", 12F);
            btnGenerate.Location = new System.Drawing.Point(912, 747);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new System.Drawing.Size(139, 50);
            btnGenerate.TabIndex = 1;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += button1_Click;
            // 
            // btnClear
            // 
            btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClear.Font = new System.Drawing.Font("Segoe UI", 12F);
            btnClear.Location = new System.Drawing.Point(767, 747);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(139, 50);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new System.Drawing.Font("Courier New", 9F);
            textBox2.Location = new System.Drawing.Point(22, 349);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textBox2.Size = new System.Drawing.Size(1029, 377);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(22, 27);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(538, 20);
            label1.TabIndex = 4;
            label1.Text = "Paste Environment variables copied from Azure Function App configuration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(22, 326);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(76, 20);
            label2.TabIndex = 5;
            label2.Text = "Response";
            // 
            // lblResposne
            // 
            lblResposne.AutoEllipsis = true;
            lblResposne.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblResposne.ForeColor = System.Drawing.Color.Red;
            lblResposne.Location = new System.Drawing.Point(22, 747);
            lblResposne.Name = "lblResposne";
            lblResposne.Size = new System.Drawing.Size(726, 63);
            lblResposne.TabIndex = 6;
            lblResposne.Text = "Error message shown here";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1076, 819);
            Controls.Add(lblResposne);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(btnGenerate);
            Controls.Add(textBox2);
            Controls.Add(btnClear);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "FunctionApp Settings Assistant";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResposne;
    }
}
