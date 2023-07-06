namespace apl2
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
            Encript = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Decript = new Button();
            textBox3 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Encript
            // 
            Encript.Location = new Point(69, 203);
            Encript.Name = "Encript";
            Encript.Size = new Size(118, 31);
            Encript.TabIndex = 0;
            Encript.Text = "Encript";
            Encript.UseVisualStyleBackColor = true;
            Encript.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(69, 84);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(297, 76);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(69, 260);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(279, 184);
            textBox2.TabIndex = 2;
            // 
            // Decript
            // 
            Decript.Location = new Point(485, 203);
            Decript.Name = "Decript";
            Decript.Size = new Size(118, 31);
            Decript.TabIndex = 3;
            Decript.Text = "Decript";
            Decript.UseVisualStyleBackColor = true;
            Decript.Click += Decript_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(485, 260);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(293, 184);
            textBox3.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 66);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 5;
            label1.Text = "Scrie textul";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 537);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(Decript);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Encript);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Encript;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button Decript;
        private TextBox textBox3;
        private Label label1;
    }
}