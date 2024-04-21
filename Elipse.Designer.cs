
namespace GraphicsPackage
{
    partial class Elipse
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
            this.lbl_rx = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Xdw = new System.Windows.Forms.Label();
            this.btn_ellipse = new System.Windows.Forms.Button();
            this.txtbox_rx = new System.Windows.Forms.TextBox();
            this.txtbox_ycenter = new System.Windows.Forms.TextBox();
            this.txtbox_xcenter = new System.Windows.Forms.TextBox();
            this.picbox = new System.Windows.Forms.PictureBox();
            this.lbl_ry = new System.Windows.Forms.Label();
            this.txtbox_ry = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_rx
            // 
            this.lbl_rx.AutoSize = true;
            this.lbl_rx.Location = new System.Drawing.Point(13, 188);
            this.lbl_rx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_rx.Name = "lbl_rx";
            this.lbl_rx.Size = new System.Drawing.Size(89, 24);
            this.lbl_rx.TabIndex = 15;
            this.lbl_rx.Text = "X Radius ";
            this.lbl_rx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Y Center";
            // 
            // Xdw
            // 
            this.Xdw.AutoSize = true;
            this.Xdw.Location = new System.Drawing.Point(13, 9);
            this.Xdw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Xdw.Name = "Xdw";
            this.Xdw.Size = new System.Drawing.Size(88, 24);
            this.Xdw.TabIndex = 13;
            this.Xdw.Text = "X Center";
            // 
            // btn_ellipse
            // 
            this.btn_ellipse.BackColor = System.Drawing.Color.Thistle;
            this.btn_ellipse.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ellipse.FlatAppearance.BorderSize = 3;
            this.btn_ellipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ellipse.Location = new System.Drawing.Point(85, 340);
            this.btn_ellipse.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ellipse.Name = "btn_ellipse";
            this.btn_ellipse.Size = new System.Drawing.Size(227, 52);
            this.btn_ellipse.TabIndex = 12;
            this.btn_ellipse.Text = "Draw Ellipse  ";
            this.btn_ellipse.UseVisualStyleBackColor = false;
            this.btn_ellipse.Click += new System.EventHandler(this.btn_ellipse_Click);
            // 
            // txtbox_rx
            // 
            this.txtbox_rx.Location = new System.Drawing.Point(17, 216);
            this.txtbox_rx.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_rx.Multiline = true;
            this.txtbox_rx.Name = "txtbox_rx";
            this.txtbox_rx.Size = new System.Drawing.Size(63, 26);
            this.txtbox_rx.TabIndex = 11;
            this.txtbox_rx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbox_ycenter
            // 
            this.txtbox_ycenter.Location = new System.Drawing.Point(85, 135);
            this.txtbox_ycenter.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_ycenter.Multiline = true;
            this.txtbox_ycenter.Name = "txtbox_ycenter";
            this.txtbox_ycenter.Size = new System.Drawing.Size(63, 26);
            this.txtbox_ycenter.TabIndex = 10;
            this.txtbox_ycenter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbox_xcenter
            // 
            this.txtbox_xcenter.Location = new System.Drawing.Point(16, 49);
            this.txtbox_xcenter.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_xcenter.Multiline = true;
            this.txtbox_xcenter.Name = "txtbox_xcenter";
            this.txtbox_xcenter.Size = new System.Drawing.Size(63, 26);
            this.txtbox_xcenter.TabIndex = 9;
            this.txtbox_xcenter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picbox
            // 
            this.picbox.BackColor = System.Drawing.Color.LavenderBlush;
            this.picbox.Location = new System.Drawing.Point(610, 13);
            this.picbox.Margin = new System.Windows.Forms.Padding(4);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(622, 635);
            this.picbox.TabIndex = 8;
            this.picbox.TabStop = false;
            // 
            // lbl_ry
            // 
            this.lbl_ry.AutoSize = true;
            this.lbl_ry.Location = new System.Drawing.Point(82, 263);
            this.lbl_ry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ry.Name = "lbl_ry";
            this.lbl_ry.Size = new System.Drawing.Size(88, 24);
            this.lbl_ry.TabIndex = 17;
            this.lbl_ry.Text = "Y Radius ";
            this.lbl_ry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbox_ry
            // 
            this.txtbox_ry.Location = new System.Drawing.Point(86, 291);
            this.txtbox_ry.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_ry.Multiline = true;
            this.txtbox_ry.Name = "txtbox_ry";
            this.txtbox_ry.Size = new System.Drawing.Size(63, 26);
            this.txtbox_ry.TabIndex = 16;
            this.txtbox_ry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(32, 444);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(70, 199);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(127, 446);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(70, 199);
            this.richTextBox2.TabIndex = 19;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(225, 449);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(70, 199);
            this.richTextBox3.TabIndex = 20;
            this.richTextBox3.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 417);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "K";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 417);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Pk";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 417);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "(X,Y)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 422);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "2Ry^2 .x ";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(339, 449);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(70, 199);
            this.richTextBox4.TabIndex = 25;
            this.richTextBox4.Text = "";
            // 
            // richTextBox5
            // 
            this.richTextBox5.Location = new System.Drawing.Point(464, 449);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(70, 199);
            this.richTextBox5.TabIndex = 26;
            this.richTextBox5.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(460, 422);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = "2Ry^2 .y";
            // 
            // Elipse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1260, 657);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lbl_ry);
            this.Controls.Add(this.txtbox_ry);
            this.Controls.Add(this.lbl_rx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Xdw);
            this.Controls.Add(this.btn_ellipse);
            this.Controls.Add(this.txtbox_rx);
            this.Controls.Add(this.txtbox_ycenter);
            this.Controls.Add(this.txtbox_xcenter);
            this.Controls.Add(this.picbox);
            this.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Elipse";
            this.Text = "Midpoint Ellipse Algorithm";
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_rx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Xdw;
        private System.Windows.Forms.Button btn_ellipse;
        private System.Windows.Forms.TextBox txtbox_rx;
        private System.Windows.Forms.TextBox txtbox_ycenter;
        private System.Windows.Forms.TextBox txtbox_xcenter;
        private System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.Label lbl_ry;
        private System.Windows.Forms.TextBox txtbox_ry;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.Label label6;
    }
}