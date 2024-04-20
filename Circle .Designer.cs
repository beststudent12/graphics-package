namespace GraphicsPackage
{
    partial class MidpointCircleAlgorithm
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
            this.circle = new System.Windows.Forms.PictureBox();
            this.xCenter = new System.Windows.Forms.TextBox();
            this.yCenter = new System.Windows.Forms.TextBox();
            this.Radius = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Xdw = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.circle)).BeginInit();
            this.SuspendLayout();
            // 
            // circle
            // 
            this.circle.BackColor = System.Drawing.Color.LavenderBlush;
            this.circle.Location = new System.Drawing.Point(361, 13);
            this.circle.Margin = new System.Windows.Forms.Padding(4);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(622, 635);
            this.circle.TabIndex = 0;
            this.circle.TabStop = false;
            // 
            // xCenter
            // 
            this.xCenter.Location = new System.Drawing.Point(28, 43);
            this.xCenter.Margin = new System.Windows.Forms.Padding(4);
            this.xCenter.Multiline = true;
            this.xCenter.Name = "xCenter";
            this.xCenter.Size = new System.Drawing.Size(63, 26);
            this.xCenter.TabIndex = 1;
            this.xCenter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yCenter
            // 
            this.yCenter.Location = new System.Drawing.Point(99, 122);
            this.yCenter.Margin = new System.Windows.Forms.Padding(4);
            this.yCenter.Multiline = true;
            this.yCenter.Name = "yCenter";
            this.yCenter.Size = new System.Drawing.Size(63, 26);
            this.yCenter.TabIndex = 2;
            this.yCenter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Radius
            // 
            this.Radius.Location = new System.Drawing.Point(28, 200);
            this.Radius.Margin = new System.Windows.Forms.Padding(4);
            this.Radius.Multiline = true;
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(63, 26);
            this.Radius.TabIndex = 3;
            this.Radius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Thistle;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(29, 292);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Draw Midpoint Circle ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Xdw
            // 
            this.Xdw.AutoSize = true;
            this.Xdw.Location = new System.Drawing.Point(24, 9);
            this.Xdw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Xdw.Name = "Xdw";
            this.Xdw.Size = new System.Drawing.Size(88, 24);
            this.Xdw.TabIndex = 5;
            this.Xdw.Text = "X Center";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y Center";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Radius";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(28, 414);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(63, 229);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(130, 414);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(63, 229);
            this.richTextBox2.TabIndex = 9;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(242, 414);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(72, 229);
            this.richTextBox3.TabIndex = 10;
            this.richTextBox3.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 387);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "K";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 387);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Pk";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 387);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "(X,Y)";
            // 
            // MidpointCircleAlgorithm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1019, 657);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Xdw);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Radius);
            this.Controls.Add(this.yCenter);
            this.Controls.Add(this.xCenter);
            this.Controls.Add(this.circle);
            this.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MidpointCircleAlgorithm";
            this.Text = "Midpoint Circle Algorithm";
            this.Load += new System.EventHandler(this.MidpointCircleAlgorithm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.circle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox circle;
        private System.Windows.Forms.TextBox xCenter;
        private System.Windows.Forms.TextBox yCenter;
        private System.Windows.Forms.TextBox Radius;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Xdw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}