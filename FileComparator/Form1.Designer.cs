namespace FileComparator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openOrigBtn = new System.Windows.Forms.Button();
            this.openModBtn = new System.Windows.Forms.Button();
            this.OriginalTextBox = new System.Windows.Forms.RichTextBox();
            this.ModifiedTextBox = new System.Windows.Forms.RichTextBox();
            this.compareBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Title = "чмы";
            // 
            // openOrigBtn
            // 
            this.openOrigBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(168)))), ((int)(((byte)(108)))));
            this.openOrigBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openOrigBtn.FlatAppearance.BorderSize = 0;
            this.openOrigBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openOrigBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openOrigBtn.ForeColor = System.Drawing.Color.White;
            this.openOrigBtn.Location = new System.Drawing.Point(43, 20);
            this.openOrigBtn.Name = "openOrigBtn";
            this.openOrigBtn.Size = new System.Drawing.Size(100, 23);
            this.openOrigBtn.TabIndex = 0;
            this.openOrigBtn.Text = "Open original file";
            this.openOrigBtn.UseVisualStyleBackColor = false;
            this.openOrigBtn.Click += new System.EventHandler(this.openOrigBtn_Click);
            // 
            // openModBtn
            // 
            this.openModBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openModBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(168)))), ((int)(((byte)(108)))));
            this.openModBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openModBtn.FlatAppearance.BorderSize = 0;
            this.openModBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openModBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openModBtn.ForeColor = System.Drawing.Color.White;
            this.openModBtn.Location = new System.Drawing.Point(458, 20);
            this.openModBtn.Name = "openModBtn";
            this.openModBtn.Size = new System.Drawing.Size(100, 23);
            this.openModBtn.TabIndex = 1;
            this.openModBtn.Text = "Open modified file ";
            this.openModBtn.UseVisualStyleBackColor = false;
            this.openModBtn.Click += new System.EventHandler(this.openModBtn_Click);
            // 
            // OriginalTextBox
            // 
            this.OriginalTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.OriginalTextBox.BackColor = System.Drawing.Color.Silver;
            this.OriginalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OriginalTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OriginalTextBox.Location = new System.Drawing.Point(19, 83);
            this.OriginalTextBox.Name = "OriginalTextBox";
            this.OriginalTextBox.ReadOnly = true;
            this.OriginalTextBox.Size = new System.Drawing.Size(383, 316);
            this.OriginalTextBox.TabIndex = 2;
            this.OriginalTextBox.Text = "Нажмите на кноку \"Open original file\", чтобы открыть оригинальный файл";
            // 
            // ModifiedTextBox
            // 
            this.ModifiedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModifiedTextBox.BackColor = System.Drawing.Color.Silver;
            this.ModifiedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ModifiedTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ModifiedTextBox.Location = new System.Drawing.Point(426, 83);
            this.ModifiedTextBox.Name = "ModifiedTextBox";
            this.ModifiedTextBox.ReadOnly = true;
            this.ModifiedTextBox.Size = new System.Drawing.Size(383, 316);
            this.ModifiedTextBox.TabIndex = 3;
            this.ModifiedTextBox.Text = "Нажмите на кноку \"Open modified file\", чтобы открыть измененный файл";
            // 
            // compareBtn
            // 
            this.compareBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.compareBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(168)))), ((int)(((byte)(108)))));
            this.compareBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.compareBtn.FlatAppearance.BorderSize = 0;
            this.compareBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compareBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.compareBtn.ForeColor = System.Drawing.Color.White;
            this.compareBtn.Location = new System.Drawing.Point(375, 424);
            this.compareBtn.Name = "compareBtn";
            this.compareBtn.Size = new System.Drawing.Size(75, 23);
            this.compareBtn.TabIndex = 4;
            this.compareBtn.Text = "Compare";
            this.compareBtn.UseVisualStyleBackColor = false;
            this.compareBtn.Click += new System.EventHandler(this.compareBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(168)))), ((int)(((byte)(108)))));
            this.label1.Location = new System.Drawing.Point(39, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(168)))), ((int)(((byte)(108)))));
            this.label2.Location = new System.Drawing.Point(454, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(830, 466);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.compareBtn);
            this.Controls.Add(this.ModifiedTextBox);
            this.Controls.Add(this.OriginalTextBox);
            this.Controls.Add(this.openModBtn);
            this.Controls.Add(this.openOrigBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(846, 505);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File comparator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button openOrigBtn;
        private System.Windows.Forms.Button openModBtn;
        private System.Windows.Forms.RichTextBox OriginalTextBox;
        private System.Windows.Forms.RichTextBox ModifiedTextBox;
        private System.Windows.Forms.Button compareBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

