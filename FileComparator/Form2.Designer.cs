namespace FileComparator
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.ResultTextBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.orgLineCountLable = new System.Windows.Forms.Label();
            this.modLineCountLabel = new System.Windows.Forms.Label();
            this.linesUnchangedLabel = new System.Windows.Forms.Label();
            this.removalsLabel = new System.Windows.Forms.Label();
            this.additionsLabel = new System.Windows.Forms.Label();
            this.changesLabel = new System.Windows.Forms.Label();
            this.runtimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultTextBox.BackColor = System.Drawing.Color.Silver;
            this.ResultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultTextBox.Location = new System.Drawing.Point(13, 41);
            this.ResultTextBox.MinimumSize = new System.Drawing.Size(456, 375);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(456, 378);
            this.ResultTextBox.TabIndex = 0;
            this.ResultTextBox.Text = "";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(168)))), ((int)(((byte)(108)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(205, 614);
            this.button1.MaximumSize = new System.Drawing.Size(75, 35);
            this.button1.MinimumSize = new System.Drawing.Size(75, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(168)))), ((int)(((byte)(108)))));
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.MaximumSize = new System.Drawing.Size(357, 29);
            this.label1.MinimumSize = new System.Drawing.Size(357, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Результат сравнения файлов";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(168)))), ((int)(((byte)(108)))));
            this.label2.Location = new System.Drawing.Point(13, 468);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Строк в оригинальном файле:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(168)))), ((int)(((byte)(108)))));
            this.label3.Location = new System.Drawing.Point(13, 488);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Строк в измененном файле:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(168)))), ((int)(((byte)(108)))));
            this.label4.Location = new System.Drawing.Point(13, 508);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Строк без изменений:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(168)))), ((int)(((byte)(108)))));
            this.label5.Location = new System.Drawing.Point(13, 528);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Строк удалено:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(168)))), ((int)(((byte)(108)))));
            this.label6.Location = new System.Drawing.Point(13, 548);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Строк добавлено:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(168)))), ((int)(((byte)(108)))));
            this.label7.Location = new System.Drawing.Point(13, 568);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Строк изменено:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(168)))), ((int)(((byte)(108)))));
            this.label8.Location = new System.Drawing.Point(13, 588);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Время выполнения сравнения (мс):";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(168)))), ((int)(((byte)(108)))));
            this.label9.Location = new System.Drawing.Point(153, 434);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Краткий отчёт";
            // 
            // orgLineCountLable
            // 
            this.orgLineCountLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.orgLineCountLable.AutoSize = true;
            this.orgLineCountLable.Location = new System.Drawing.Point(180, 468);
            this.orgLineCountLable.Name = "orgLineCountLable";
            this.orgLineCountLable.Size = new System.Drawing.Size(0, 13);
            this.orgLineCountLable.TabIndex = 11;
            // 
            // modLineCountLabel
            // 
            this.modLineCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.modLineCountLabel.AutoSize = true;
            this.modLineCountLabel.Location = new System.Drawing.Point(171, 488);
            this.modLineCountLabel.Name = "modLineCountLabel";
            this.modLineCountLabel.Size = new System.Drawing.Size(0, 13);
            this.modLineCountLabel.TabIndex = 12;
            // 
            // linesUnchangedLabel
            // 
            this.linesUnchangedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linesUnchangedLabel.AutoSize = true;
            this.linesUnchangedLabel.Location = new System.Drawing.Point(140, 508);
            this.linesUnchangedLabel.Name = "linesUnchangedLabel";
            this.linesUnchangedLabel.Size = new System.Drawing.Size(0, 13);
            this.linesUnchangedLabel.TabIndex = 13;
            // 
            // removalsLabel
            // 
            this.removalsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removalsLabel.AutoSize = true;
            this.removalsLabel.Location = new System.Drawing.Point(103, 528);
            this.removalsLabel.Name = "removalsLabel";
            this.removalsLabel.Size = new System.Drawing.Size(0, 13);
            this.removalsLabel.TabIndex = 14;
            // 
            // additionsLabel
            // 
            this.additionsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.additionsLabel.AutoSize = true;
            this.additionsLabel.Location = new System.Drawing.Point(117, 549);
            this.additionsLabel.Name = "additionsLabel";
            this.additionsLabel.Size = new System.Drawing.Size(0, 13);
            this.additionsLabel.TabIndex = 15;
            // 
            // changesLabel
            // 
            this.changesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.changesLabel.AutoSize = true;
            this.changesLabel.Location = new System.Drawing.Point(113, 568);
            this.changesLabel.Name = "changesLabel";
            this.changesLabel.Size = new System.Drawing.Size(0, 13);
            this.changesLabel.TabIndex = 16;
            // 
            // runtimeLabel
            // 
            this.runtimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.runtimeLabel.AutoSize = true;
            this.runtimeLabel.Location = new System.Drawing.Point(208, 588);
            this.runtimeLabel.Name = "runtimeLabel";
            this.runtimeLabel.Size = new System.Drawing.Size(0, 13);
            this.runtimeLabel.TabIndex = 17;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(484, 661);
            this.Controls.Add(this.runtimeLabel);
            this.Controls.Add(this.changesLabel);
            this.Controls.Add(this.additionsLabel);
            this.Controls.Add(this.removalsLabel);
            this.Controls.Add(this.linesUnchangedLabel);
            this.Controls.Add(this.modLineCountLabel);
            this.Controls.Add(this.orgLineCountLable);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ResultTextBox);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 700);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analysis result";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ResultTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label orgLineCountLable;
        private System.Windows.Forms.Label modLineCountLabel;
        private System.Windows.Forms.Label linesUnchangedLabel;
        private System.Windows.Forms.Label removalsLabel;
        private System.Windows.Forms.Label additionsLabel;
        private System.Windows.Forms.Label changesLabel;
        private System.Windows.Forms.Label runtimeLabel;
    }
}