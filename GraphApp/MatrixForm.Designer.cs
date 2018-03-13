namespace GraphApp
{
    partial class MatrixForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatrixForm));
            this.MatrixDGV = new System.Windows.Forms.DataGridView();
            this.MatrixBackButton = new System.Windows.Forms.Button();
            this.ShowGraphButton = new System.Windows.Forms.Button();
            this.FillEmtyButton = new System.Windows.Forms.Button();
            this.SaveGraphButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // MatrixDGV
            // 
            this.MatrixDGV.AllowUserToAddRows = false;
            this.MatrixDGV.AllowUserToDeleteRows = false;
            this.MatrixDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.MatrixDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrixDGV.GridColor = System.Drawing.Color.Silver;
            this.MatrixDGV.Location = new System.Drawing.Point(12, 12);
            this.MatrixDGV.Name = "MatrixDGV";
            this.MatrixDGV.RowTemplate.Height = 24;
            this.MatrixDGV.Size = new System.Drawing.Size(600, 420);
            this.MatrixDGV.TabIndex = 0;
            // 
            // MatrixBackButton
            // 
            this.MatrixBackButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MatrixBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MatrixBackButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.MatrixBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MatrixBackButton.Location = new System.Drawing.Point(12, 454);
            this.MatrixBackButton.Name = "MatrixBackButton";
            this.MatrixBackButton.Size = new System.Drawing.Size(99, 35);
            this.MatrixBackButton.TabIndex = 1;
            this.MatrixBackButton.Text = "Назад";
            this.MatrixBackButton.UseVisualStyleBackColor = false;
            this.MatrixBackButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowGraphButton
            // 
            this.ShowGraphButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ShowGraphButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowGraphButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowGraphButton.Location = new System.Drawing.Point(650, 358);
            this.ShowGraphButton.Name = "ShowGraphButton";
            this.ShowGraphButton.Size = new System.Drawing.Size(216, 74);
            this.ShowGraphButton.TabIndex = 2;
            this.ShowGraphButton.Text = "Перейти к построению графа";
            this.ShowGraphButton.UseVisualStyleBackColor = false;
            this.ShowGraphButton.Click += new System.EventHandler(this.ShowGraphButton_Click);
            // 
            // FillEmtyButton
            // 
            this.FillEmtyButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FillEmtyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FillEmtyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FillEmtyButton.Location = new System.Drawing.Point(650, 12);
            this.FillEmtyButton.Name = "FillEmtyButton";
            this.FillEmtyButton.Size = new System.Drawing.Size(216, 74);
            this.FillEmtyButton.TabIndex = 3;
            this.FillEmtyButton.Text = "Заполнить пустые ячейки нулями";
            this.FillEmtyButton.UseVisualStyleBackColor = false;
            this.FillEmtyButton.Click += new System.EventHandler(this.FillEmtyButton_Click);
            // 
            // SaveGraphButton
            // 
            this.SaveGraphButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SaveGraphButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveGraphButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveGraphButton.Location = new System.Drawing.Point(650, 167);
            this.SaveGraphButton.Name = "SaveGraphButton";
            this.SaveGraphButton.Size = new System.Drawing.Size(216, 74);
            this.SaveGraphButton.TabIndex = 4;
            this.SaveGraphButton.Text = "Сохранить граф в базу данных практики";
            this.SaveGraphButton.UseVisualStyleBackColor = false;
            this.SaveGraphButton.Click += new System.EventHandler(this.SaveGraphButton_Click);
            // 
            // MatrixForm
            // 
            this.AcceptButton = this.ShowGraphButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.CancelButton = this.MatrixBackButton;
            this.ClientSize = new System.Drawing.Size(878, 501);
            this.Controls.Add(this.SaveGraphButton);
            this.Controls.Add(this.FillEmtyButton);
            this.Controls.Add(this.ShowGraphButton);
            this.Controls.Add(this.MatrixBackButton);
            this.Controls.Add(this.MatrixDGV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MatrixForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Матрица смежности";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MatrixForm_FormClosed);
            this.Load += new System.EventHandler(this.MatrixForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MatrixDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView MatrixDGV;
        private System.Windows.Forms.Button MatrixBackButton;
        private System.Windows.Forms.Button ShowGraphButton;
        private System.Windows.Forms.Button FillEmtyButton;
        private System.Windows.Forms.Button SaveGraphButton;
    }
}