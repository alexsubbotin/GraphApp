namespace GraphApp
{
    partial class ChooseLevelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseLevelForm));
            this.ChooseLabel = new System.Windows.Forms.Label();
            this.EasyCheckBox = new System.Windows.Forms.CheckBox();
            this.MediumCheckBox = new System.Windows.Forms.CheckBox();
            this.HardCheckBox = new System.Windows.Forms.CheckBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChooseLabel
            // 
            this.ChooseLabel.AutoSize = true;
            this.ChooseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseLabel.Location = new System.Drawing.Point(12, 9);
            this.ChooseLabel.Name = "ChooseLabel";
            this.ChooseLabel.Size = new System.Drawing.Size(370, 40);
            this.ChooseLabel.TabIndex = 3;
            this.ChooseLabel.Text = "Пожалуйста, выберите уровень сложности\r\nна который Вы хотите добавить граф:";
            // 
            // EasyCheckBox
            // 
            this.EasyCheckBox.AutoSize = true;
            this.EasyCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EasyCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EasyCheckBox.Location = new System.Drawing.Point(29, 82);
            this.EasyCheckBox.Name = "EasyCheckBox";
            this.EasyCheckBox.Size = new System.Drawing.Size(90, 24);
            this.EasyCheckBox.TabIndex = 4;
            this.EasyCheckBox.Text = "Легкий";
            this.EasyCheckBox.UseVisualStyleBackColor = true;
            this.EasyCheckBox.CheckedChanged += new System.EventHandler(this.EasyCheckBox_CheckedChanged);
            // 
            // MediumCheckBox
            // 
            this.MediumCheckBox.AutoSize = true;
            this.MediumCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MediumCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MediumCheckBox.Location = new System.Drawing.Point(213, 82);
            this.MediumCheckBox.Name = "MediumCheckBox";
            this.MediumCheckBox.Size = new System.Drawing.Size(105, 24);
            this.MediumCheckBox.TabIndex = 5;
            this.MediumCheckBox.Text = "Средний";
            this.MediumCheckBox.UseVisualStyleBackColor = true;
            this.MediumCheckBox.CheckedChanged += new System.EventHandler(this.MediumCheckBox_CheckedChanged);
            // 
            // HardCheckBox
            // 
            this.HardCheckBox.AutoSize = true;
            this.HardCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HardCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HardCheckBox.Location = new System.Drawing.Point(411, 82);
            this.HardCheckBox.Name = "HardCheckBox";
            this.HardCheckBox.Size = new System.Drawing.Size(105, 24);
            this.HardCheckBox.TabIndex = 6;
            this.HardCheckBox.Text = "Тяжелый";
            this.HardCheckBox.UseVisualStyleBackColor = true;
            this.HardCheckBox.CheckedChanged += new System.EventHandler(this.HardCheckBox_CheckedChanged);
            // 
            // OKButton
            // 
            this.OKButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OKButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OKButton.Location = new System.Drawing.Point(13, 150);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(106, 37);
            this.OKButton.TabIndex = 7;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = false;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(435, 150);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(106, 37);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ChooseLevelForm
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelButton;
            this.ClientSize = new System.Drawing.Size(553, 199);
            this.ControlBox = false;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.HardCheckBox);
            this.Controls.Add(this.MediumCheckBox);
            this.Controls.Add(this.EasyCheckBox);
            this.Controls.Add(this.ChooseLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChooseLevelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Уровень сложности";
            this.Load += new System.EventHandler(this.ChooseLevelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChooseLabel;
        private System.Windows.Forms.CheckBox EasyCheckBox;
        private System.Windows.Forms.CheckBox MediumCheckBox;
        private System.Windows.Forms.CheckBox HardCheckBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
    }
}