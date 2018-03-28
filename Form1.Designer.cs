namespace Mandelbrot
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
            this.Coefficient = new System.Windows.Forms.GroupBox();
            this.InIter = new System.Windows.Forms.NumericUpDown();
            this.OutCurrY = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.InCntrIm = new System.Windows.Forms.TextBox();
            this.InCntrReal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.InCFim = new System.Windows.Forms.TextBox();
            this.InCFreal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OutCurrX = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Build = new System.Windows.Forms.Button();
            this.ExtBt = new System.Windows.Forms.Button();
            this.prBar = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ClrBtn = new System.Windows.Forms.Button();
            this.Coefficient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InIter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Coefficient
            // 
            this.Coefficient.Controls.Add(this.InIter);
            this.Coefficient.Controls.Add(this.OutCurrY);
            this.Coefficient.Controls.Add(this.label9);
            this.Coefficient.Controls.Add(this.label8);
            this.Coefficient.Controls.Add(this.label7);
            this.Coefficient.Controls.Add(this.InCntrIm);
            this.Coefficient.Controls.Add(this.InCntrReal);
            this.Coefficient.Controls.Add(this.label5);
            this.Coefficient.Controls.Add(this.label6);
            this.Coefficient.Controls.Add(this.label4);
            this.Coefficient.Controls.Add(this.InCFim);
            this.Coefficient.Controls.Add(this.InCFreal);
            this.Coefficient.Controls.Add(this.label3);
            this.Coefficient.Controls.Add(this.label2);
            this.Coefficient.Controls.Add(this.OutCurrX);
            this.Coefficient.Controls.Add(this.Label1);
            this.Coefficient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Coefficient.Location = new System.Drawing.Point(645, 12);
            this.Coefficient.Name = "Coefficient";
            this.Coefficient.Size = new System.Drawing.Size(200, 287);
            this.Coefficient.TabIndex = 1;
            this.Coefficient.TabStop = false;
            this.Coefficient.Text = "Menu";
            // 
            // InIter
            // 
            this.InIter.Location = new System.Drawing.Point(109, 201);
            this.InIter.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.InIter.Name = "InIter";
            this.InIter.Size = new System.Drawing.Size(85, 23);
            this.InIter.TabIndex = 16;
            this.InIter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // OutCurrY
            // 
            this.OutCurrY.AutoSize = true;
            this.OutCurrY.Location = new System.Drawing.Point(106, 267);
            this.OutCurrY.Name = "OutCurrY";
            this.OutCurrY.Size = new System.Drawing.Size(0, 17);
            this.OutCurrY.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Current y:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Centre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Coefficient:";
            // 
            // InCntrIm
            // 
            this.InCntrIm.Location = new System.Drawing.Point(109, 77);
            this.InCntrIm.Name = "InCntrIm";
            this.InCntrIm.Size = new System.Drawing.Size(85, 23);
            this.InCntrIm.TabIndex = 11;
            // 
            // InCntrReal
            // 
            this.InCntrReal.Location = new System.Drawing.Point(109, 48);
            this.InCntrReal.Name = "InCntrReal";
            this.InCntrReal.Size = new System.Drawing.Size(85, 23);
            this.InCntrReal.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Imaginary:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Real:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Max iterations:";
            // 
            // InCFim
            // 
            this.InCFim.Location = new System.Drawing.Point(109, 172);
            this.InCFim.Name = "InCFim";
            this.InCFim.Size = new System.Drawing.Size(85, 23);
            this.InCFim.TabIndex = 5;
            // 
            // InCFreal
            // 
            this.InCFreal.Location = new System.Drawing.Point(109, 143);
            this.InCFreal.Name = "InCFreal";
            this.InCFreal.Size = new System.Drawing.Size(85, 23);
            this.InCFreal.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Imaginary:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Real:";
            // 
            // OutCurrX
            // 
            this.OutCurrX.AutoSize = true;
            this.OutCurrX.Location = new System.Drawing.Point(106, 242);
            this.OutCurrX.Name = "OutCurrX";
            this.OutCurrX.Size = new System.Drawing.Size(0, 17);
            this.OutCurrX.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 242);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(69, 17);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Current x:";
            // 
            // Build
            // 
            this.Build.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Build.Location = new System.Drawing.Point(645, 337);
            this.Build.Name = "Build";
            this.Build.Size = new System.Drawing.Size(100, 34);
            this.Build.TabIndex = 2;
            this.Build.Text = "Build";
            this.Build.UseVisualStyleBackColor = true;
            this.Build.Click += new System.EventHandler(this.Build_Click);
            // 
            // ExtBt
            // 
            this.ExtBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ExtBt.Location = new System.Drawing.Point(754, 383);
            this.ExtBt.Name = "ExtBt";
            this.ExtBt.Size = new System.Drawing.Size(94, 34);
            this.ExtBt.TabIndex = 3;
            this.ExtBt.Text = "Exit";
            this.ExtBt.UseVisualStyleBackColor = true;
            this.ExtBt.Click += new System.EventHandler(this.ExtBt_Click);
            // 
            // prBar
            // 
            this.prBar.Location = new System.Drawing.Point(645, 305);
            this.prBar.Name = "prBar";
            this.prBar.Size = new System.Drawing.Size(200, 23);
            this.prBar.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(627, 405);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
            // 
            // ClrBtn
            // 
            this.ClrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ClrBtn.Location = new System.Drawing.Point(748, 337);
            this.ClrBtn.Name = "ClrBtn";
            this.ClrBtn.Size = new System.Drawing.Size(100, 34);
            this.ClrBtn.TabIndex = 5;
            this.ClrBtn.Text = "Clear";
            this.ClrBtn.UseVisualStyleBackColor = true;
            this.ClrBtn.Click += new System.EventHandler(this.ClrBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 429);
            this.Controls.Add(this.ClrBtn);
            this.Controls.Add(this.prBar);
            this.Controls.Add(this.ExtBt);
            this.Controls.Add(this.Build);
            this.Controls.Add(this.Coefficient);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Coefficient.ResumeLayout(false);
            this.Coefficient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InIter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox Coefficient;
        private System.Windows.Forms.TextBox InCFim;
        private System.Windows.Forms.TextBox InCFreal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label OutCurrX;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Build;
        private System.Windows.Forms.Button ExtBt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox InCntrIm;
        private System.Windows.Forms.TextBox InCntrReal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label OutCurrY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown InIter;
        private System.Windows.Forms.ProgressBar prBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ClrBtn;
    }
}

