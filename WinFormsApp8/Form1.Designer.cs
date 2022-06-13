namespace WinFormsApp8
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb_brush = new System.Windows.Forms.RadioButton();
            this.rb_pen = new System.Windows.Forms.RadioButton();
            this.btn_line = new System.Windows.Forms.Button();
            this.btn_rectangle = new System.Windows.Forms.Button();
            this.btn_ellipse = new System.Windows.Forms.Button();
            this.btn_color = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.rb_brush);
            this.panel1.Controls.Add(this.rb_pen);
            this.panel1.Controls.Add(this.btn_line);
            this.panel1.Controls.Add(this.btn_rectangle);
            this.panel1.Controls.Add(this.btn_ellipse);
            this.panel1.Controls.Add(this.btn_color);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 125);
            this.panel1.TabIndex = 0;
            // 
            // rb_brush
            // 
            this.rb_brush.AutoSize = true;
            this.rb_brush.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_brush.Location = new System.Drawing.Point(125, 48);
            this.rb_brush.Name = "rb_brush";
            this.rb_brush.Size = new System.Drawing.Size(79, 25);
            this.rb_brush.TabIndex = 2;
            this.rb_brush.TabStop = true;
            this.rb_brush.Text = "Brush";
            this.rb_brush.UseVisualStyleBackColor = true;
            // 
            // rb_pen
            // 
            this.rb_pen.AutoSize = true;
            this.rb_pen.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_pen.Location = new System.Drawing.Point(32, 48);
            this.rb_pen.Name = "rb_pen";
            this.rb_pen.Size = new System.Drawing.Size(61, 25);
            this.rb_pen.TabIndex = 2;
            this.rb_pen.TabStop = true;
            this.rb_pen.Text = "Pen";
            this.rb_pen.UseVisualStyleBackColor = true;
            // 
            // btn_line
            // 
            this.btn_line.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_line.BackgroundImage = global::WinFormsApp8.Properties.Resources.icons8_линия_24;
            this.btn_line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_line.Location = new System.Drawing.Point(771, 30);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(66, 57);
            this.btn_line.TabIndex = 1;
            this.btn_line.UseVisualStyleBackColor = false;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            // 
            // btn_rectangle
            // 
            this.btn_rectangle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_rectangle.BackgroundImage = global::WinFormsApp8.Properties.Resources.icons8_прямоугольник_48;
            this.btn_rectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_rectangle.Location = new System.Drawing.Point(666, 30);
            this.btn_rectangle.Name = "btn_rectangle";
            this.btn_rectangle.Size = new System.Drawing.Size(66, 57);
            this.btn_rectangle.TabIndex = 1;
            this.btn_rectangle.UseVisualStyleBackColor = false;
            this.btn_rectangle.Click += new System.EventHandler(this.btn_rectangle_Click);
            // 
            // btn_ellipse
            // 
            this.btn_ellipse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ellipse.BackgroundImage = global::WinFormsApp8.Properties.Resources.icons8_ellipse_32;
            this.btn_ellipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ellipse.Location = new System.Drawing.Point(561, 30);
            this.btn_ellipse.Name = "btn_ellipse";
            this.btn_ellipse.Size = new System.Drawing.Size(66, 57);
            this.btn_ellipse.TabIndex = 1;
            this.btn_ellipse.UseVisualStyleBackColor = false;
            this.btn_ellipse.Click += new System.EventHandler(this.btn_ellipse_Click);
            // 
            // btn_color
            // 
            this.btn_color.BackgroundImage = global::WinFormsApp8.Properties.Resources.color;
            this.btn_color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_color.Location = new System.Drawing.Point(453, 30);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(66, 57);
            this.btn_color.TabIndex = 0;
            this.btn_color.UseVisualStyleBackColor = true;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 682);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btn_color;
        private Button btn_rectangle;
        private Button btn_ellipse;
        private Button btn_line;
        private ColorDialog colorDialog1;
        private RadioButton rb_brush;
        private RadioButton rb_pen;
    }
}