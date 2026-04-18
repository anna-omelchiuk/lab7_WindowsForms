namespace lab7_WindowsForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.txtAccel = new System.Windows.Forms.TextBox();
            this.buttonSpeed = new System.Windows.Forms.Button();
            this.buttonAccel = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(200, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "x=bcos(at)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(200, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "y=bsin(at)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 5;
            this.hScrollBar1.Location = new System.Drawing.Point(523, 103);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(158, 25);
            this.hScrollBar1.TabIndex = 2;
            this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.LargeChange = 5;
            this.hScrollBar2.Location = new System.Drawing.Point(523, 61);
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(158, 25);
            this.hScrollBar2.TabIndex = 3;
            this.hScrollBar2.ValueChanged += new System.EventHandler(this.hScrollBar2_ValueChanged);
            // 
            // txtSpeed
            // 
            this.txtSpeed.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSpeed.Location = new System.Drawing.Point(241, 197);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.ReadOnly = true;
            this.txtSpeed.Size = new System.Drawing.Size(137, 29);
            this.txtSpeed.TabIndex = 4;
            this.txtSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSpeed.Visible = false;
            // 
            // txtAccel
            // 
            this.txtAccel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAccel.Location = new System.Drawing.Point(450, 197);
            this.txtAccel.Name = "txtAccel";
            this.txtAccel.ReadOnly = true;
            this.txtAccel.Size = new System.Drawing.Size(137, 29);
            this.txtAccel.TabIndex = 5;
            this.txtAccel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAccel.Visible = false;
            // 
            // buttonSpeed
            // 
            this.buttonSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSpeed.Location = new System.Drawing.Point(241, 248);
            this.buttonSpeed.Name = "buttonSpeed";
            this.buttonSpeed.Size = new System.Drawing.Size(137, 42);
            this.buttonSpeed.TabIndex = 6;
            this.buttonSpeed.Text = "Швидкість";
            this.buttonSpeed.UseVisualStyleBackColor = true;
            this.buttonSpeed.Click += new System.EventHandler(this.buttonSpeed_Click);
            // 
            // buttonAccel
            // 
            this.buttonAccel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAccel.Location = new System.Drawing.Point(450, 248);
            this.buttonAccel.Name = "buttonAccel";
            this.buttonAccel.Size = new System.Drawing.Size(137, 41);
            this.buttonAccel.TabIndex = 7;
            this.buttonAccel.Text = "Прискорення";
            this.buttonAccel.UseVisualStyleBackColor = true;
            this.buttonAccel.Click += new System.EventHandler(this.buttonAccel_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(703, 481);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(125, 41);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Вихід";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(843, 543);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonAccel);
            this.Controls.Add(this.buttonSpeed);
            this.Controls.Add(this.txtAccel);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.hScrollBar2);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кінематика точки";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar2;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.TextBox txtAccel;
        private System.Windows.Forms.Button buttonSpeed;
        private System.Windows.Forms.Button buttonAccel;
        private System.Windows.Forms.Button buttonExit;
    }
}

