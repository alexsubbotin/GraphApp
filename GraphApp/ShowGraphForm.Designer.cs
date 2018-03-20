namespace GraphApp
{
    partial class ShowGraphForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowGraphForm));
            this.CasualPicBox = new System.Windows.Forms.PictureBox();
            this.ParallelPicBox = new System.Windows.Forms.PictureBox();
            this.CasualGraphLabel = new System.Windows.Forms.Label();
            this.ParalleGraphLabel = new System.Windows.Forms.Label();
            this.ShowParallelGraphCheckBox = new System.Windows.Forms.CheckBox();
            this.GoToMenuButton = new System.Windows.Forms.Button();
            this.ShowParallelLabel = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CasualPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParallelPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CasualPicBox
            // 
            this.CasualPicBox.BackColor = System.Drawing.Color.PapayaWhip;
            this.CasualPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CasualPicBox.Location = new System.Drawing.Point(12, 52);
            this.CasualPicBox.Name = "CasualPicBox";
            this.CasualPicBox.Size = new System.Drawing.Size(716, 660);
            this.CasualPicBox.TabIndex = 0;
            this.CasualPicBox.TabStop = false;
            this.CasualPicBox.Paint += new System.Windows.Forms.PaintEventHandler(this.CasualPicBox_Paint);
            // 
            // ParallelPicBox
            // 
            this.ParallelPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ParallelPicBox.Location = new System.Drawing.Point(730, 52);
            this.ParallelPicBox.Name = "ParallelPicBox";
            this.ParallelPicBox.Size = new System.Drawing.Size(716, 660);
            this.ParallelPicBox.TabIndex = 1;
            this.ParallelPicBox.TabStop = false;
            this.ParallelPicBox.Paint += new System.Windows.Forms.PaintEventHandler(this.ParallelPicBox_Paint);
            // 
            // CasualGraphLabel
            // 
            this.CasualGraphLabel.AutoSize = true;
            this.CasualGraphLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CasualGraphLabel.Location = new System.Drawing.Point(220, 24);
            this.CasualGraphLabel.Name = "CasualGraphLabel";
            this.CasualGraphLabel.Size = new System.Drawing.Size(195, 25);
            this.CasualGraphLabel.TabIndex = 2;
            this.CasualGraphLabel.Text = "Полученный граф";
            // 
            // ParalleGraphLabel
            // 
            this.ParalleGraphLabel.AutoSize = true;
            this.ParalleGraphLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParalleGraphLabel.Location = new System.Drawing.Point(1030, 24);
            this.ParalleGraphLabel.Name = "ParalleGraphLabel";
            this.ParalleGraphLabel.Size = new System.Drawing.Size(130, 25);
            this.ParalleGraphLabel.TabIndex = 3;
            this.ParalleGraphLabel.Text = "ЯПФ графа";
            // 
            // ShowParallelGraphCheckBox
            // 
            this.ShowParallelGraphCheckBox.AutoSize = true;
            this.ShowParallelGraphCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowParallelGraphCheckBox.Location = new System.Drawing.Point(1280, 730);
            this.ShowParallelGraphCheckBox.Name = "ShowParallelGraphCheckBox";
            this.ShowParallelGraphCheckBox.Size = new System.Drawing.Size(148, 22);
            this.ShowParallelGraphCheckBox.TabIndex = 4;
            this.ShowParallelGraphCheckBox.Text = "Показать ЯПФ";
            this.ShowParallelGraphCheckBox.UseVisualStyleBackColor = true;
            this.ShowParallelGraphCheckBox.CheckedChanged += new System.EventHandler(this.ShowParallelGraphCheckBox_CheckedChanged);
            // 
            // GoToMenuButton
            // 
            this.GoToMenuButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GoToMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoToMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoToMenuButton.Location = new System.Drawing.Point(12, 776);
            this.GoToMenuButton.Name = "GoToMenuButton";
            this.GoToMenuButton.Size = new System.Drawing.Size(267, 43);
            this.GoToMenuButton.TabIndex = 5;
            this.GoToMenuButton.Text = "Вернуться в главное меню";
            this.GoToMenuButton.UseVisualStyleBackColor = false;
            this.GoToMenuButton.Click += new System.EventHandler(this.GoToMenuButton_Click);
            // 
            // ShowParallelLabel
            // 
            this.ShowParallelLabel.AutoSize = true;
            this.ShowParallelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowParallelLabel.Location = new System.Drawing.Point(881, 769);
            this.ShowParallelLabel.Name = "ShowParallelLabel";
            this.ShowParallelLabel.Size = new System.Drawing.Size(359, 54);
            this.ShowParallelLabel.TabIndex = 6;
            this.ShowParallelLabel.Text = "При нажатии кнопки \"Обновить\" ЯПФ меняет вид,\r\nно не меняет смысла \r\n(можно выбра" +
    "ть удобную для себя ЯПФ)\r\n";
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UpdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateButton.Location = new System.Drawing.Point(1280, 776);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(130, 43);
            this.UpdateButton.TabIndex = 7;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ShowGraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1460, 831);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.ShowParallelLabel);
            this.Controls.Add(this.GoToMenuButton);
            this.Controls.Add(this.ShowParallelGraphCheckBox);
            this.Controls.Add(this.ParalleGraphLabel);
            this.Controls.Add(this.CasualGraphLabel);
            this.Controls.Add(this.ParallelPicBox);
            this.Controls.Add(this.CasualPicBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1478, 878);
            this.MinimumSize = new System.Drawing.Size(1478, 878);
            this.Name = "ShowGraphForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Показ графа";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShowGraphForm_FormClosed);
            this.Load += new System.EventHandler(this.ShowGraphForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CasualPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParallelPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CasualPicBox;
        private System.Windows.Forms.PictureBox ParallelPicBox;
        private System.Windows.Forms.Label CasualGraphLabel;
        private System.Windows.Forms.Label ParalleGraphLabel;
        private System.Windows.Forms.CheckBox ShowParallelGraphCheckBox;
        private System.Windows.Forms.Button GoToMenuButton;
        private System.Windows.Forms.Label ShowParallelLabel;
        private System.Windows.Forms.Button UpdateButton;
    }
}