namespace GraphApp
{
    partial class NumOfApForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumOfApForm));
            this.NumOfApLabel = new System.Windows.Forms.Label();
            this.NumOfApTextBox = new System.Windows.Forms.TextBox();
            this.NumOfApBackButton = new System.Windows.Forms.Button();
            this.NumOfApMatrixButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumOfApLabel
            // 
            this.NumOfApLabel.AutoSize = true;
            this.NumOfApLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumOfApLabel.Location = new System.Drawing.Point(12, 34);
            this.NumOfApLabel.Name = "NumOfApLabel";
            this.NumOfApLabel.Size = new System.Drawing.Size(177, 18);
            this.NumOfApLabel.TabIndex = 0;
            this.NumOfApLabel.Text = "Введите кол-во вершин:";
            // 
            // NumOfApTextBox
            // 
            this.NumOfApTextBox.Location = new System.Drawing.Point(229, 33);
            this.NumOfApTextBox.Name = "NumOfApTextBox";
            this.NumOfApTextBox.Size = new System.Drawing.Size(149, 22);
            this.NumOfApTextBox.TabIndex = 1;
            this.NumOfApTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumOfApTextBox_KeyPress);
            this.NumOfApTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NumOfApTextBox_KeyUp);
            // 
            // NumOfApBackButton
            // 
            this.NumOfApBackButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NumOfApBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NumOfApBackButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.NumOfApBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumOfApBackButton.Location = new System.Drawing.Point(12, 122);
            this.NumOfApBackButton.Name = "NumOfApBackButton";
            this.NumOfApBackButton.Size = new System.Drawing.Size(90, 34);
            this.NumOfApBackButton.TabIndex = 2;
            this.NumOfApBackButton.Text = "Назад";
            this.NumOfApBackButton.UseVisualStyleBackColor = false;
            this.NumOfApBackButton.Click += new System.EventHandler(this.NumOfApBackButton_Click);
            // 
            // NumOfApMatrixButton
            // 
            this.NumOfApMatrixButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NumOfApMatrixButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NumOfApMatrixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumOfApMatrixButton.Location = new System.Drawing.Point(229, 108);
            this.NumOfApMatrixButton.Name = "NumOfApMatrixButton";
            this.NumOfApMatrixButton.Size = new System.Drawing.Size(215, 48);
            this.NumOfApMatrixButton.TabIndex = 3;
            this.NumOfApMatrixButton.Text = "Перейти к заполнению матрицы смежности";
            this.NumOfApMatrixButton.UseVisualStyleBackColor = false;
            this.NumOfApMatrixButton.Click += new System.EventHandler(this.NumOfApMatrixButton_Click);
            // 
            // NumOfApForm
            // 
            this.AcceptButton = this.NumOfApMatrixButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.NumOfApBackButton;
            this.ClientSize = new System.Drawing.Size(456, 168);
            this.ControlBox = false;
            this.Controls.Add(this.NumOfApMatrixButton);
            this.Controls.Add(this.NumOfApBackButton);
            this.Controls.Add(this.NumOfApTextBox);
            this.Controls.Add(this.NumOfApLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(474, 215);
            this.MinimumSize = new System.Drawing.Size(474, 215);
            this.Name = "NumOfApForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кол-во вершин";
            this.Load += new System.EventHandler(this.NumOfApForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumOfApLabel;
        private System.Windows.Forms.TextBox NumOfApTextBox;
        private System.Windows.Forms.Button NumOfApBackButton;
        private System.Windows.Forms.Button NumOfApMatrixButton;
    }
}