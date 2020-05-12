namespace _6._3F
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
            this.Жми = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.N = new System.Windows.Forms.TextBox();
            this.V = new System.Windows.Forms.TextBox();
            this.M = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Жми
            // 
            this.Жми.Location = new System.Drawing.Point(49, 123);
            this.Жми.Name = "Жми";
            this.Жми.Size = new System.Drawing.Size(75, 23);
            this.Жми.TabIndex = 0;
            this.Жми.Text = "Жми";
            this.Жми.UseVisualStyleBackColor = true;
            this.Жми.Click += new System.EventHandler(this.Жми_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите N";
            // 
            // N
            // 
            this.N.Location = new System.Drawing.Point(12, 25);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(100, 20);
            this.N.TabIndex = 2;
            // 
            // V
            // 
            this.V.Location = new System.Drawing.Point(139, 25);
            this.V.Multiline = true;
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(233, 121);
            this.V.TabIndex = 3;
            // 
            // M
            // 
            this.M.Location = new System.Drawing.Point(12, 73);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(100, 20);
            this.M.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите M";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.M);
            this.Controls.Add(this.V);
            this.Controls.Add(this.N);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Жми);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Жми;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox N;
        private System.Windows.Forms.TextBox V;
        private System.Windows.Forms.TextBox M;
        private System.Windows.Forms.Label label2;
    }
}

