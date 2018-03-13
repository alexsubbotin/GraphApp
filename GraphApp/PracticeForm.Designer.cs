namespace GraphApp
{
    partial class PracticeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PracticeForm));
            this.PracticePicBox = new System.Windows.Forms.PictureBox();
            this.GoToMenuButton = new System.Windows.Forms.Button();
            this.RandomGraphLabel = new System.Windows.Forms.Label();
            this.NewGraphBut = new System.Windows.Forms.Button();
            this.ZeroFloorLabel = new System.Windows.Forms.Label();
            this.FirstFloorLabel = new System.Windows.Forms.Label();
            this.SecondFloorLabel = new System.Windows.Forms.Label();
            this.ThirdFloorLabel = new System.Windows.Forms.Label();
            this.FourthFloorLabel = new System.Windows.Forms.Label();
            this.FifthFloorLabel = new System.Windows.Forms.Label();
            this.SixthFloorLabel = new System.Windows.Forms.Label();
            this.ZeroFloorTextBox = new System.Windows.Forms.TextBox();
            this.FirstFloorTextBox = new System.Windows.Forms.TextBox();
            this.SecondFloorTextBox = new System.Windows.Forms.TextBox();
            this.ThirdFloorTextBox = new System.Windows.Forms.TextBox();
            this.FourthFloorTextBox = new System.Windows.Forms.TextBox();
            this.FifthFloorTextBox = new System.Windows.Forms.TextBox();
            this.SixthFloorTextBox = new System.Windows.Forms.TextBox();
            this.SeventhFloorTextBox = new System.Windows.Forms.TextBox();
            this.SeventhFloorLabel = new System.Windows.Forms.Label();
            this.ShowZeroFloorDataButton = new System.Windows.Forms.Button();
            this.ShowFirstFloorDataButton = new System.Windows.Forms.Button();
            this.ShowSecondFloorDataButton = new System.Windows.Forms.Button();
            this.ShowThirdFloorDataButton = new System.Windows.Forms.Button();
            this.ShowFourthFloorDataButton = new System.Windows.Forms.Button();
            this.ShowFifthFloorDataButton = new System.Windows.Forms.Button();
            this.ShowSixthFloorDataButton = new System.Windows.Forms.Button();
            this.ShowSeventhFloorDataButton = new System.Windows.Forms.Button();
            this.CheckButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PracticePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PracticePicBox
            // 
            this.PracticePicBox.Location = new System.Drawing.Point(29, 51);
            this.PracticePicBox.Name = "PracticePicBox";
            this.PracticePicBox.Size = new System.Drawing.Size(716, 660);
            this.PracticePicBox.TabIndex = 0;
            this.PracticePicBox.TabStop = false;
            this.PracticePicBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PracticePicBox_Paint);
            // 
            // GoToMenuButton
            // 
            this.GoToMenuButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GoToMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoToMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoToMenuButton.Location = new System.Drawing.Point(12, 787);
            this.GoToMenuButton.Name = "GoToMenuButton";
            this.GoToMenuButton.Size = new System.Drawing.Size(267, 43);
            this.GoToMenuButton.TabIndex = 6;
            this.GoToMenuButton.Text = "Вернуться в главное меню";
            this.GoToMenuButton.UseVisualStyleBackColor = false;
            this.GoToMenuButton.Click += new System.EventHandler(this.GoToMenuButton_Click);
            // 
            // RandomGraphLabel
            // 
            this.RandomGraphLabel.AutoSize = true;
            this.RandomGraphLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RandomGraphLabel.Location = new System.Drawing.Point(243, 23);
            this.RandomGraphLabel.Name = "RandomGraphLabel";
            this.RandomGraphLabel.Size = new System.Drawing.Size(250, 25);
            this.RandomGraphLabel.TabIndex = 7;
            this.RandomGraphLabel.Text = "Сгенерированный граф";
            // 
            // NewGraphBut
            // 
            this.NewGraphBut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NewGraphBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewGraphBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewGraphBut.Location = new System.Drawing.Point(478, 717);
            this.NewGraphBut.Name = "NewGraphBut";
            this.NewGraphBut.Size = new System.Drawing.Size(267, 43);
            this.NewGraphBut.TabIndex = 8;
            this.NewGraphBut.Text = "Сгенерировать другой";
            this.NewGraphBut.UseVisualStyleBackColor = false;
            this.NewGraphBut.Click += new System.EventHandler(this.NewGraphBut_Click);
            // 
            // ZeroFloorLabel
            // 
            this.ZeroFloorLabel.AutoSize = true;
            this.ZeroFloorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ZeroFloorLabel.Location = new System.Drawing.Point(862, 51);
            this.ZeroFloorLabel.Name = "ZeroFloorLabel";
            this.ZeroFloorLabel.Size = new System.Drawing.Size(88, 25);
            this.ZeroFloorLabel.TabIndex = 9;
            this.ZeroFloorLabel.Text = "0 ярус: ";
            // 
            // FirstFloorLabel
            // 
            this.FirstFloorLabel.AutoSize = true;
            this.FirstFloorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstFloorLabel.Location = new System.Drawing.Point(862, 140);
            this.FirstFloorLabel.Name = "FirstFloorLabel";
            this.FirstFloorLabel.Size = new System.Drawing.Size(88, 25);
            this.FirstFloorLabel.TabIndex = 10;
            this.FirstFloorLabel.Text = "1 ярус: ";
            // 
            // SecondFloorLabel
            // 
            this.SecondFloorLabel.AutoSize = true;
            this.SecondFloorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondFloorLabel.Location = new System.Drawing.Point(862, 229);
            this.SecondFloorLabel.Name = "SecondFloorLabel";
            this.SecondFloorLabel.Size = new System.Drawing.Size(88, 25);
            this.SecondFloorLabel.TabIndex = 11;
            this.SecondFloorLabel.Text = "2 ярус: ";
            // 
            // ThirdFloorLabel
            // 
            this.ThirdFloorLabel.AutoSize = true;
            this.ThirdFloorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThirdFloorLabel.Location = new System.Drawing.Point(862, 319);
            this.ThirdFloorLabel.Name = "ThirdFloorLabel";
            this.ThirdFloorLabel.Size = new System.Drawing.Size(88, 25);
            this.ThirdFloorLabel.TabIndex = 12;
            this.ThirdFloorLabel.Text = "3 ярус: ";
            // 
            // FourthFloorLabel
            // 
            this.FourthFloorLabel.AutoSize = true;
            this.FourthFloorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FourthFloorLabel.Location = new System.Drawing.Point(862, 406);
            this.FourthFloorLabel.Name = "FourthFloorLabel";
            this.FourthFloorLabel.Size = new System.Drawing.Size(88, 25);
            this.FourthFloorLabel.TabIndex = 13;
            this.FourthFloorLabel.Text = "4 ярус: ";
            // 
            // FifthFloorLabel
            // 
            this.FifthFloorLabel.AutoSize = true;
            this.FifthFloorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FifthFloorLabel.Location = new System.Drawing.Point(862, 492);
            this.FifthFloorLabel.Name = "FifthFloorLabel";
            this.FifthFloorLabel.Size = new System.Drawing.Size(88, 25);
            this.FifthFloorLabel.TabIndex = 14;
            this.FifthFloorLabel.Text = "5 ярус: ";
            // 
            // SixthFloorLabel
            // 
            this.SixthFloorLabel.AutoSize = true;
            this.SixthFloorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SixthFloorLabel.Location = new System.Drawing.Point(862, 577);
            this.SixthFloorLabel.Name = "SixthFloorLabel";
            this.SixthFloorLabel.Size = new System.Drawing.Size(88, 25);
            this.SixthFloorLabel.TabIndex = 15;
            this.SixthFloorLabel.Text = "6 ярус: ";
            // 
            // ZeroFloorTextBox
            // 
            this.ZeroFloorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ZeroFloorTextBox.Location = new System.Drawing.Point(956, 48);
            this.ZeroFloorTextBox.Name = "ZeroFloorTextBox";
            this.ZeroFloorTextBox.Size = new System.Drawing.Size(266, 28);
            this.ZeroFloorTextBox.TabIndex = 16;
            this.ZeroFloorTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ZeroFloorTextBox_KeyPress);
            // 
            // FirstFloorTextBox
            // 
            this.FirstFloorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstFloorTextBox.Location = new System.Drawing.Point(956, 137);
            this.FirstFloorTextBox.Name = "FirstFloorTextBox";
            this.FirstFloorTextBox.Size = new System.Drawing.Size(266, 28);
            this.FirstFloorTextBox.TabIndex = 17;
            this.FirstFloorTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstFloorTextBox_KeyPress);
            // 
            // SecondFloorTextBox
            // 
            this.SecondFloorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondFloorTextBox.Location = new System.Drawing.Point(956, 226);
            this.SecondFloorTextBox.Name = "SecondFloorTextBox";
            this.SecondFloorTextBox.Size = new System.Drawing.Size(266, 28);
            this.SecondFloorTextBox.TabIndex = 18;
            this.SecondFloorTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SecondFloorTextBox_KeyPress);
            // 
            // ThirdFloorTextBox
            // 
            this.ThirdFloorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThirdFloorTextBox.Location = new System.Drawing.Point(956, 316);
            this.ThirdFloorTextBox.Name = "ThirdFloorTextBox";
            this.ThirdFloorTextBox.Size = new System.Drawing.Size(266, 28);
            this.ThirdFloorTextBox.TabIndex = 19;
            this.ThirdFloorTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ThirdFloorTextBox_KeyPress);
            // 
            // FourthFloorTextBox
            // 
            this.FourthFloorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FourthFloorTextBox.Location = new System.Drawing.Point(956, 403);
            this.FourthFloorTextBox.Name = "FourthFloorTextBox";
            this.FourthFloorTextBox.Size = new System.Drawing.Size(266, 28);
            this.FourthFloorTextBox.TabIndex = 20;
            this.FourthFloorTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FourthFloorTextBox_KeyPress);
            // 
            // FifthFloorTextBox
            // 
            this.FifthFloorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FifthFloorTextBox.Location = new System.Drawing.Point(956, 489);
            this.FifthFloorTextBox.Name = "FifthFloorTextBox";
            this.FifthFloorTextBox.Size = new System.Drawing.Size(266, 28);
            this.FifthFloorTextBox.TabIndex = 21;
            this.FifthFloorTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FifthFloorTextBox_KeyPress);
            // 
            // SixthFloorTextBox
            // 
            this.SixthFloorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SixthFloorTextBox.Location = new System.Drawing.Point(956, 574);
            this.SixthFloorTextBox.Name = "SixthFloorTextBox";
            this.SixthFloorTextBox.Size = new System.Drawing.Size(266, 28);
            this.SixthFloorTextBox.TabIndex = 22;
            this.SixthFloorTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SixthFloorTextBox_KeyPress);
            // 
            // SeventhFloorTextBox
            // 
            this.SeventhFloorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SeventhFloorTextBox.Location = new System.Drawing.Point(956, 657);
            this.SeventhFloorTextBox.Name = "SeventhFloorTextBox";
            this.SeventhFloorTextBox.Size = new System.Drawing.Size(266, 28);
            this.SeventhFloorTextBox.TabIndex = 24;
            this.SeventhFloorTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SeventhFloorTextBox_KeyPress);
            // 
            // SeventhFloorLabel
            // 
            this.SeventhFloorLabel.AutoSize = true;
            this.SeventhFloorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SeventhFloorLabel.Location = new System.Drawing.Point(862, 660);
            this.SeventhFloorLabel.Name = "SeventhFloorLabel";
            this.SeventhFloorLabel.Size = new System.Drawing.Size(88, 25);
            this.SeventhFloorLabel.TabIndex = 23;
            this.SeventhFloorLabel.Text = "7 ярус: ";
            // 
            // ShowZeroFloorDataButton
            // 
            this.ShowZeroFloorDataButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ShowZeroFloorDataButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowZeroFloorDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowZeroFloorDataButton.Location = new System.Drawing.Point(1228, 72);
            this.ShowZeroFloorDataButton.Name = "ShowZeroFloorDataButton";
            this.ShowZeroFloorDataButton.Size = new System.Drawing.Size(158, 36);
            this.ShowZeroFloorDataButton.TabIndex = 25;
            this.ShowZeroFloorDataButton.Text = "Показать ответ";
            this.ShowZeroFloorDataButton.UseVisualStyleBackColor = false;
            this.ShowZeroFloorDataButton.Click += new System.EventHandler(this.ShowZeroFloorDataButton_Click);
            // 
            // ShowFirstFloorDataButton
            // 
            this.ShowFirstFloorDataButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ShowFirstFloorDataButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowFirstFloorDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowFirstFloorDataButton.Location = new System.Drawing.Point(1228, 161);
            this.ShowFirstFloorDataButton.Name = "ShowFirstFloorDataButton";
            this.ShowFirstFloorDataButton.Size = new System.Drawing.Size(158, 35);
            this.ShowFirstFloorDataButton.TabIndex = 26;
            this.ShowFirstFloorDataButton.Text = "Показать ответ";
            this.ShowFirstFloorDataButton.UseVisualStyleBackColor = false;
            this.ShowFirstFloorDataButton.Click += new System.EventHandler(this.ShowFirstFloorDataButton_Click);
            // 
            // ShowSecondFloorDataButton
            // 
            this.ShowSecondFloorDataButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ShowSecondFloorDataButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowSecondFloorDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowSecondFloorDataButton.Location = new System.Drawing.Point(1228, 252);
            this.ShowSecondFloorDataButton.Name = "ShowSecondFloorDataButton";
            this.ShowSecondFloorDataButton.Size = new System.Drawing.Size(158, 34);
            this.ShowSecondFloorDataButton.TabIndex = 27;
            this.ShowSecondFloorDataButton.Text = "Показать ответ";
            this.ShowSecondFloorDataButton.UseVisualStyleBackColor = false;
            this.ShowSecondFloorDataButton.Click += new System.EventHandler(this.ShowSecondFloorDataButton_Click);
            // 
            // ShowThirdFloorDataButton
            // 
            this.ShowThirdFloorDataButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ShowThirdFloorDataButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowThirdFloorDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowThirdFloorDataButton.Location = new System.Drawing.Point(1228, 342);
            this.ShowThirdFloorDataButton.Name = "ShowThirdFloorDataButton";
            this.ShowThirdFloorDataButton.Size = new System.Drawing.Size(158, 35);
            this.ShowThirdFloorDataButton.TabIndex = 28;
            this.ShowThirdFloorDataButton.Text = "Показать ответ";
            this.ShowThirdFloorDataButton.UseVisualStyleBackColor = false;
            this.ShowThirdFloorDataButton.Click += new System.EventHandler(this.ShowThirdFloorDataButton_Click);
            // 
            // ShowFourthFloorDataButton
            // 
            this.ShowFourthFloorDataButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ShowFourthFloorDataButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowFourthFloorDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowFourthFloorDataButton.Location = new System.Drawing.Point(1228, 429);
            this.ShowFourthFloorDataButton.Name = "ShowFourthFloorDataButton";
            this.ShowFourthFloorDataButton.Size = new System.Drawing.Size(158, 30);
            this.ShowFourthFloorDataButton.TabIndex = 29;
            this.ShowFourthFloorDataButton.Text = "Показать ответ";
            this.ShowFourthFloorDataButton.UseVisualStyleBackColor = false;
            this.ShowFourthFloorDataButton.Click += new System.EventHandler(this.ShowFourthFloorDataButton_Click);
            // 
            // ShowFifthFloorDataButton
            // 
            this.ShowFifthFloorDataButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ShowFifthFloorDataButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowFifthFloorDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowFifthFloorDataButton.Location = new System.Drawing.Point(1228, 514);
            this.ShowFifthFloorDataButton.Name = "ShowFifthFloorDataButton";
            this.ShowFifthFloorDataButton.Size = new System.Drawing.Size(158, 35);
            this.ShowFifthFloorDataButton.TabIndex = 30;
            this.ShowFifthFloorDataButton.Text = "Показать ответ";
            this.ShowFifthFloorDataButton.UseVisualStyleBackColor = false;
            this.ShowFifthFloorDataButton.Click += new System.EventHandler(this.ShowFifthFloorDataButton_Click);
            // 
            // ShowSixthFloorDataButton
            // 
            this.ShowSixthFloorDataButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ShowSixthFloorDataButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowSixthFloorDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowSixthFloorDataButton.Location = new System.Drawing.Point(1228, 600);
            this.ShowSixthFloorDataButton.Name = "ShowSixthFloorDataButton";
            this.ShowSixthFloorDataButton.Size = new System.Drawing.Size(158, 33);
            this.ShowSixthFloorDataButton.TabIndex = 31;
            this.ShowSixthFloorDataButton.Text = "Показать ответ";
            this.ShowSixthFloorDataButton.UseVisualStyleBackColor = false;
            this.ShowSixthFloorDataButton.Click += new System.EventHandler(this.ShowSixthFloorDataButton_Click);
            // 
            // ShowSeventhFloorDataButton
            // 
            this.ShowSeventhFloorDataButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ShowSeventhFloorDataButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowSeventhFloorDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowSeventhFloorDataButton.Location = new System.Drawing.Point(1228, 683);
            this.ShowSeventhFloorDataButton.Name = "ShowSeventhFloorDataButton";
            this.ShowSeventhFloorDataButton.Size = new System.Drawing.Size(158, 33);
            this.ShowSeventhFloorDataButton.TabIndex = 32;
            this.ShowSeventhFloorDataButton.Text = "Показать ответ";
            this.ShowSeventhFloorDataButton.UseVisualStyleBackColor = false;
            this.ShowSeventhFloorDataButton.Click += new System.EventHandler(this.ShowSeventhFloorDataButton_Click);
            // 
            // CheckButton
            // 
            this.CheckButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CheckButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckButton.Location = new System.Drawing.Point(1208, 787);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(267, 43);
            this.CheckButton.TabIndex = 33;
            this.CheckButton.Text = "Проверить";
            this.CheckButton.UseVisualStyleBackColor = false;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(863, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Номера вершин вписываются через пробел";
            // 
            // PracticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1487, 842);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.ShowSeventhFloorDataButton);
            this.Controls.Add(this.ShowSixthFloorDataButton);
            this.Controls.Add(this.ShowFifthFloorDataButton);
            this.Controls.Add(this.ShowFourthFloorDataButton);
            this.Controls.Add(this.ShowThirdFloorDataButton);
            this.Controls.Add(this.ShowSecondFloorDataButton);
            this.Controls.Add(this.ShowFirstFloorDataButton);
            this.Controls.Add(this.ShowZeroFloorDataButton);
            this.Controls.Add(this.SeventhFloorTextBox);
            this.Controls.Add(this.SeventhFloorLabel);
            this.Controls.Add(this.SixthFloorTextBox);
            this.Controls.Add(this.FifthFloorTextBox);
            this.Controls.Add(this.FourthFloorTextBox);
            this.Controls.Add(this.ThirdFloorTextBox);
            this.Controls.Add(this.SecondFloorTextBox);
            this.Controls.Add(this.FirstFloorTextBox);
            this.Controls.Add(this.ZeroFloorTextBox);
            this.Controls.Add(this.SixthFloorLabel);
            this.Controls.Add(this.FifthFloorLabel);
            this.Controls.Add(this.FourthFloorLabel);
            this.Controls.Add(this.ThirdFloorLabel);
            this.Controls.Add(this.SecondFloorLabel);
            this.Controls.Add(this.FirstFloorLabel);
            this.Controls.Add(this.ZeroFloorLabel);
            this.Controls.Add(this.NewGraphBut);
            this.Controls.Add(this.RandomGraphLabel);
            this.Controls.Add(this.GoToMenuButton);
            this.Controls.Add(this.PracticePicBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PracticeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Практика";
            this.Load += new System.EventHandler(this.PracticeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PracticePicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PracticePicBox;
        private System.Windows.Forms.Button GoToMenuButton;
        private System.Windows.Forms.Label RandomGraphLabel;
        private System.Windows.Forms.Button NewGraphBut;
        private System.Windows.Forms.Label ZeroFloorLabel;
        private System.Windows.Forms.Label FirstFloorLabel;
        private System.Windows.Forms.Label SecondFloorLabel;
        private System.Windows.Forms.Label ThirdFloorLabel;
        private System.Windows.Forms.Label FourthFloorLabel;
        private System.Windows.Forms.Label FifthFloorLabel;
        private System.Windows.Forms.Label SixthFloorLabel;
        private System.Windows.Forms.TextBox ZeroFloorTextBox;
        private System.Windows.Forms.TextBox FirstFloorTextBox;
        private System.Windows.Forms.TextBox SecondFloorTextBox;
        private System.Windows.Forms.TextBox ThirdFloorTextBox;
        private System.Windows.Forms.TextBox FourthFloorTextBox;
        private System.Windows.Forms.TextBox FifthFloorTextBox;
        private System.Windows.Forms.TextBox SixthFloorTextBox;
        private System.Windows.Forms.TextBox SeventhFloorTextBox;
        private System.Windows.Forms.Label SeventhFloorLabel;
        private System.Windows.Forms.Button ShowZeroFloorDataButton;
        private System.Windows.Forms.Button ShowFirstFloorDataButton;
        private System.Windows.Forms.Button ShowSecondFloorDataButton;
        private System.Windows.Forms.Button ShowThirdFloorDataButton;
        private System.Windows.Forms.Button ShowFourthFloorDataButton;
        private System.Windows.Forms.Button ShowFifthFloorDataButton;
        private System.Windows.Forms.Button ShowSixthFloorDataButton;
        private System.Windows.Forms.Button ShowSeventhFloorDataButton;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Label label1;
    }
}