namespace GraphApp
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.WorkButton = new System.Windows.Forms.Button();
            this.PracticeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WorkButton
            // 
            this.WorkButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.WorkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WorkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorkButton.Location = new System.Drawing.Point(329, 30);
            this.WorkButton.Name = "WorkButton";
            this.WorkButton.Size = new System.Drawing.Size(326, 106);
            this.WorkButton.TabIndex = 0;
            this.WorkButton.Text = "ПРИВЕДЕНИЕ";
            this.WorkButton.UseVisualStyleBackColor = false;
            this.WorkButton.Click += new System.EventHandler(this.WorkButton_Click);
            // 
            // PracticeButton
            // 
            this.PracticeButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PracticeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PracticeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PracticeButton.Location = new System.Drawing.Point(329, 190);
            this.PracticeButton.Name = "PracticeButton";
            this.PracticeButton.Size = new System.Drawing.Size(326, 106);
            this.PracticeButton.TabIndex = 1;
            this.PracticeButton.Text = "ПРАКТИКА";
            this.PracticeButton.UseVisualStyleBackColor = false;
            this.PracticeButton.Click += new System.EventHandler(this.PracticeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(329, 366);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(326, 106);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "ВЫХОД";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(901, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "HSE, 2018";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(989, 511);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PracticeButton);
            this.Controls.Add(this.WorkButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приведение графа к ЯПФ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenuForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WorkButton;
        private System.Windows.Forms.Button PracticeButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
    }
}

