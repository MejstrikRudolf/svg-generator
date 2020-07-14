namespace svg_generator
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio_ellipse = new System.Windows.Forms.RadioButton();
            this.radio_circle = new System.Windows.Forms.RadioButton();
            this.radio_square = new System.Windows.Forms.RadioButton();
            this.radio_rectangle = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numeric_blue = new System.Windows.Forms.NumericUpDown();
            this.numeric_green = new System.Windows.Forms.NumericUpDown();
            this.numeric_red = new System.Windows.Forms.NumericUpDown();
            this.numeric_X = new System.Windows.Forms.NumericUpDown();
            this.numeric_Y = new System.Windows.Forms.NumericUpDown();
            this.numeric_wid = new System.Windows.Forms.NumericUpDown();
            this.numeric_hei = new System.Windows.Forms.NumericUpDown();
            this.button_add = new System.Windows.Forms.Button();
            this.button_end = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.text_wid = new System.Windows.Forms.Label();
            this.text_hei = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_wid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_hei)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_ellipse);
            this.groupBox1.Controls.Add(this.radio_circle);
            this.groupBox1.Controls.Add(this.radio_square);
            this.groupBox1.Controls.Add(this.radio_rectangle);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shape";
            // 
            // radio_ellipse
            // 
            this.radio_ellipse.AutoSize = true;
            this.radio_ellipse.Location = new System.Drawing.Point(7, 38);
            this.radio_ellipse.Name = "radio_ellipse";
            this.radio_ellipse.Size = new System.Drawing.Size(54, 17);
            this.radio_ellipse.TabIndex = 5;
            this.radio_ellipse.TabStop = true;
            this.radio_ellipse.Text = "ellipse";
            this.radio_ellipse.UseVisualStyleBackColor = true;
            // 
            // radio_circle
            // 
            this.radio_circle.AutoSize = true;
            this.radio_circle.Location = new System.Drawing.Point(7, 15);
            this.radio_circle.Name = "radio_circle";
            this.radio_circle.Size = new System.Drawing.Size(50, 17);
            this.radio_circle.TabIndex = 4;
            this.radio_circle.TabStop = true;
            this.radio_circle.Text = "circle";
            this.radio_circle.UseVisualStyleBackColor = true;
            this.radio_circle.CheckedChanged += new System.EventHandler(this.radio_circle_CheckedChanged);
            // 
            // radio_square
            // 
            this.radio_square.AutoSize = true;
            this.radio_square.Location = new System.Drawing.Point(7, 84);
            this.radio_square.Name = "radio_square";
            this.radio_square.Size = new System.Drawing.Size(57, 17);
            this.radio_square.TabIndex = 3;
            this.radio_square.TabStop = true;
            this.radio_square.Text = "square";
            this.radio_square.UseVisualStyleBackColor = true;
            this.radio_square.CheckedChanged += new System.EventHandler(this.radio_square_CheckedChanged);
            // 
            // radio_rectangle
            // 
            this.radio_rectangle.AutoSize = true;
            this.radio_rectangle.Location = new System.Drawing.Point(7, 61);
            this.radio_rectangle.Name = "radio_rectangle";
            this.radio_rectangle.Size = new System.Drawing.Size(69, 17);
            this.radio_rectangle.TabIndex = 2;
            this.radio_rectangle.TabStop = true;
            this.radio_rectangle.Text = "rectangle";
            this.radio_rectangle.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numeric_blue);
            this.groupBox2.Controls.Add(this.numeric_green);
            this.groupBox2.Controls.Add(this.numeric_red);
            this.groupBox2.Location = new System.Drawing.Point(219, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 92);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "blue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "green";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "red";
            // 
            // numeric_blue
            // 
            this.numeric_blue.Location = new System.Drawing.Point(74, 66);
            this.numeric_blue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numeric_blue.Name = "numeric_blue";
            this.numeric_blue.Size = new System.Drawing.Size(120, 20);
            this.numeric_blue.TabIndex = 2;
            // 
            // numeric_green
            // 
            this.numeric_green.Location = new System.Drawing.Point(74, 43);
            this.numeric_green.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numeric_green.Name = "numeric_green";
            this.numeric_green.Size = new System.Drawing.Size(120, 20);
            this.numeric_green.TabIndex = 1;
            // 
            // numeric_red
            // 
            this.numeric_red.Location = new System.Drawing.Point(74, 20);
            this.numeric_red.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numeric_red.Name = "numeric_red";
            this.numeric_red.Size = new System.Drawing.Size(120, 20);
            this.numeric_red.TabIndex = 0;
            // 
            // numeric_X
            // 
            this.numeric_X.Location = new System.Drawing.Point(78, 128);
            this.numeric_X.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numeric_X.Name = "numeric_X";
            this.numeric_X.Size = new System.Drawing.Size(120, 20);
            this.numeric_X.TabIndex = 6;
            // 
            // numeric_Y
            // 
            this.numeric_Y.Location = new System.Drawing.Point(77, 154);
            this.numeric_Y.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numeric_Y.Name = "numeric_Y";
            this.numeric_Y.Size = new System.Drawing.Size(120, 20);
            this.numeric_Y.TabIndex = 7;
            // 
            // numeric_wid
            // 
            this.numeric_wid.Location = new System.Drawing.Point(77, 180);
            this.numeric_wid.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_wid.Name = "numeric_wid";
            this.numeric_wid.Size = new System.Drawing.Size(120, 20);
            this.numeric_wid.TabIndex = 8;
            this.numeric_wid.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numeric_hei
            // 
            this.numeric_hei.Location = new System.Drawing.Point(77, 206);
            this.numeric_hei.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_hei.Name = "numeric_hei";
            this.numeric_hei.Size = new System.Drawing.Size(120, 20);
            this.numeric_hei.TabIndex = 9;
            this.numeric_hei.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_add.Location = new System.Drawing.Point(237, 125);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(172, 50);
            this.button_add.TabIndex = 10;
            this.button_add.Text = "Add object";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_end
            // 
            this.button_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_end.Location = new System.Drawing.Point(237, 181);
            this.button_end.Name = "button_end";
            this.button_end.Size = new System.Drawing.Size(172, 50);
            this.button_end.TabIndex = 11;
            this.button_end.Text = "End file";
            this.button_end.UseVisualStyleBackColor = true;
            this.button_end.Click += new System.EventHandler(this.button_end_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Position X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Position Y";
            // 
            // text_wid
            // 
            this.text_wid.AutoSize = true;
            this.text_wid.Location = new System.Drawing.Point(13, 186);
            this.text_wid.Name = "text_wid";
            this.text_wid.Size = new System.Drawing.Size(35, 13);
            this.text_wid.TabIndex = 14;
            this.text_wid.Text = "Width";
            // 
            // text_hei
            // 
            this.text_hei.AutoSize = true;
            this.text_hei.Location = new System.Drawing.Point(13, 212);
            this.text_hei.Name = "text_hei";
            this.text_hei.Size = new System.Drawing.Size(38, 13);
            this.text_hei.TabIndex = 15;
            this.text_hei.Text = "Height";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 242);
            this.Controls.Add(this.text_hei);
            this.Controls.Add(this.text_wid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_end);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.numeric_hei);
            this.Controls.Add(this.numeric_wid);
            this.Controls.Add(this.numeric_Y);
            this.Controls.Add(this.numeric_X);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_wid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_hei)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio_rectangle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numeric_blue;
        private System.Windows.Forms.NumericUpDown numeric_green;
        private System.Windows.Forms.NumericUpDown numeric_red;
        private System.Windows.Forms.RadioButton radio_square;
        private System.Windows.Forms.NumericUpDown numeric_X;
        private System.Windows.Forms.NumericUpDown numeric_Y;
        private System.Windows.Forms.NumericUpDown numeric_wid;
        private System.Windows.Forms.NumericUpDown numeric_hei;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_end;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label text_wid;
        private System.Windows.Forms.Label text_hei;
        private System.Windows.Forms.RadioButton radio_ellipse;
        private System.Windows.Forms.RadioButton radio_circle;
    }
}

