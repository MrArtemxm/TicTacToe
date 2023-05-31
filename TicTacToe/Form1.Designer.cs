namespace TicTacToe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.playerTwoScoreField = new System.Windows.Forms.Label();
            this.drawsScoreField = new System.Windows.Forms.Label();
            this.playerOneScoreField = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.player2Selection = new System.Windows.Forms.ComboBox();
            this.player1Selection = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Игрок = new System.Windows.Forms.Label();
            this.beginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.turnLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.turnCountLabel = new System.Windows.Forms.Label();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.MaximumSize = new System.Drawing.Size(205, 185);
            this.panel1.MinimumSize = new System.Drawing.Size(205, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 185);
            this.panel1.TabIndex = 0;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelOnClick);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Silver;
            this.panel10.Controls.Add(this.turnCountLabel);
            this.panel10.Controls.Add(this.label10);
            this.panel10.Controls.Add(this.turnLabel);
            this.panel10.Controls.Add(this.label8);
            this.panel10.Controls.Add(this.label7);
            this.panel10.Controls.Add(this.radioButton2);
            this.panel10.Controls.Add(this.radioButton1);
            this.panel10.Controls.Add(this.playerTwoScoreField);
            this.panel10.Controls.Add(this.drawsScoreField);
            this.panel10.Controls.Add(this.playerOneScoreField);
            this.panel10.Controls.Add(this.label6);
            this.panel10.Controls.Add(this.label5);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Controls.Add(this.label3);
            this.panel10.Controls.Add(this.player2Selection);
            this.panel10.Controls.Add(this.player1Selection);
            this.panel10.Controls.Add(this.label2);
            this.panel10.Controls.Add(this.Игрок);
            this.panel10.Controls.Add(this.beginButton);
            this.panel10.Controls.Add(this.label1);
            this.panel10.Location = new System.Drawing.Point(650, 12);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(374, 567);
            this.panel10.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(16, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(278, 26);
            this.label8.TabIndex = 16;
            this.label8.Text = "Крестики или нолики?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(16, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = "Играть против:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.ForeColor = System.Drawing.Color.Navy;
            this.radioButton2.Location = new System.Drawing.Point(154, 351);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(150, 25);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Против друга";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.againstChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.ForeColor = System.Drawing.Color.Navy;
            this.radioButton1.Location = new System.Drawing.Point(12, 351);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(130, 25);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Против ИИ";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.againstChanged);
            // 
            // playerTwoScoreField
            // 
            this.playerTwoScoreField.AutoSize = true;
            this.playerTwoScoreField.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerTwoScoreField.ForeColor = System.Drawing.Color.Navy;
            this.playerTwoScoreField.Location = new System.Drawing.Point(298, 174);
            this.playerTwoScoreField.Name = "playerTwoScoreField";
            this.playerTwoScoreField.Size = new System.Drawing.Size(24, 24);
            this.playerTwoScoreField.TabIndex = 12;
            this.playerTwoScoreField.Text = "0";
            // 
            // drawsScoreField
            // 
            this.drawsScoreField.AutoSize = true;
            this.drawsScoreField.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drawsScoreField.ForeColor = System.Drawing.Color.Navy;
            this.drawsScoreField.Location = new System.Drawing.Point(179, 174);
            this.drawsScoreField.Name = "drawsScoreField";
            this.drawsScoreField.Size = new System.Drawing.Size(24, 24);
            this.drawsScoreField.TabIndex = 11;
            this.drawsScoreField.Text = "0";
            // 
            // playerOneScoreField
            // 
            this.playerOneScoreField.AutoSize = true;
            this.playerOneScoreField.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerOneScoreField.ForeColor = System.Drawing.Color.Navy;
            this.playerOneScoreField.Location = new System.Drawing.Point(42, 174);
            this.playerOneScoreField.Name = "playerOneScoreField";
            this.playerOneScoreField.Size = new System.Drawing.Size(24, 24);
            this.playerOneScoreField.TabIndex = 10;
            this.playerOneScoreField.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(262, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "Игрок 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(149, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ничья";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(16, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Игрок 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(140, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "Счёт";
            // 
            // player2Selection
            // 
            this.player2Selection.BackColor = System.Drawing.Color.Gainsboro;
            this.player2Selection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.player2Selection.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player2Selection.ForeColor = System.Drawing.Color.Navy;
            this.player2Selection.FormattingEnabled = true;
            this.player2Selection.Items.AddRange(new object[] {
            "Крестики",
            "Нолики"});
            this.player2Selection.Location = new System.Drawing.Point(154, 439);
            this.player2Selection.Name = "player2Selection";
            this.player2Selection.Size = new System.Drawing.Size(136, 29);
            this.player2Selection.TabIndex = 5;
            this.player2Selection.SelectedValueChanged += new System.EventHandler(this.player2OnChange);
            // 
            // player1Selection
            // 
            this.player1Selection.BackColor = System.Drawing.Color.Gainsboro;
            this.player1Selection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.player1Selection.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player1Selection.ForeColor = System.Drawing.Color.Navy;
            this.player1Selection.FormattingEnabled = true;
            this.player1Selection.Items.AddRange(new object[] {
            "Крестики",
            "Нолики"});
            this.player1Selection.Location = new System.Drawing.Point(12, 439);
            this.player1Selection.Name = "player1Selection";
            this.player1Selection.Size = new System.Drawing.Size(136, 29);
            this.player1Selection.TabIndex = 4;
            this.player1Selection.SelectedValueChanged += new System.EventHandler(this.player1OnChange);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(150, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Игрок 2";
            // 
            // Игрок
            // 
            this.Игрок.AutoSize = true;
            this.Игрок.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Игрок.ForeColor = System.Drawing.Color.Navy;
            this.Игрок.Location = new System.Drawing.Point(8, 414);
            this.Игрок.Name = "Игрок";
            this.Игрок.Size = new System.Drawing.Size(87, 22);
            this.Игрок.TabIndex = 2;
            this.Игрок.Text = "Игрок 1";
            // 
            // beginButton
            // 
            this.beginButton.BackColor = System.Drawing.Color.Gainsboro;
            this.beginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beginButton.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.beginButton.ForeColor = System.Drawing.Color.Navy;
            this.beginButton.Location = new System.Drawing.Point(12, 484);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(350, 68);
            this.beginButton.TabIndex = 1;
            this.beginButton.Text = "Начать новую игру";
            this.beginButton.UseVisualStyleBackColor = false;
            this.beginButton.Click += new System.EventHandler(this.beginButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Крестики-нолики";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(223, 12);
            this.panel2.MaximumSize = new System.Drawing.Size(205, 185);
            this.panel2.MinimumSize = new System.Drawing.Size(205, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 185);
            this.panel2.TabIndex = 3;
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelOnClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(434, 12);
            this.panel3.MaximumSize = new System.Drawing.Size(205, 185);
            this.panel3.MinimumSize = new System.Drawing.Size(205, 185);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(205, 185);
            this.panel3.TabIndex = 1;
            this.panel3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelOnClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(12, 203);
            this.panel4.MaximumSize = new System.Drawing.Size(205, 185);
            this.panel4.MinimumSize = new System.Drawing.Size(205, 185);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(205, 185);
            this.panel4.TabIndex = 4;
            this.panel4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelOnClick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(223, 203);
            this.panel5.MaximumSize = new System.Drawing.Size(205, 185);
            this.panel5.MinimumSize = new System.Drawing.Size(205, 185);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(205, 185);
            this.panel5.TabIndex = 2;
            this.panel5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelOnClick);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(434, 203);
            this.panel6.MaximumSize = new System.Drawing.Size(205, 185);
            this.panel6.MinimumSize = new System.Drawing.Size(205, 185);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(205, 185);
            this.panel6.TabIndex = 2;
            this.panel6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelOnClick);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(12, 394);
            this.panel7.MaximumSize = new System.Drawing.Size(205, 185);
            this.panel7.MinimumSize = new System.Drawing.Size(205, 185);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(205, 185);
            this.panel7.TabIndex = 2;
            this.panel7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelOnClick);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(223, 394);
            this.panel8.MaximumSize = new System.Drawing.Size(205, 185);
            this.panel8.MinimumSize = new System.Drawing.Size(205, 185);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(205, 185);
            this.panel8.TabIndex = 5;
            this.panel8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelOnClick);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(434, 394);
            this.panel9.MaximumSize = new System.Drawing.Size(205, 185);
            this.panel9.MinimumSize = new System.Drawing.Size(205, 185);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(205, 185);
            this.panel9.TabIndex = 2;
            this.panel9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelOnClick);
            // 
            // turnLabel
            // 
            this.turnLabel.AutoSize = true;
            this.turnLabel.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.turnLabel.ForeColor = System.Drawing.Color.Navy;
            this.turnLabel.Location = new System.Drawing.Point(16, 220);
            this.turnLabel.Name = "turnLabel";
            this.turnLabel.Size = new System.Drawing.Size(216, 26);
            this.turnLabel.TabIndex = 17;
            this.turnLabel.Text = "Очередь игрока: ?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(16, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 26);
            this.label10.TabIndex = 18;
            this.label10.Text = "Ходов:";
            // 
            // turnCountLabel
            // 
            this.turnCountLabel.AutoSize = true;
            this.turnCountLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.turnCountLabel.ForeColor = System.Drawing.Color.Navy;
            this.turnCountLabel.Location = new System.Drawing.Point(106, 248);
            this.turnCountLabel.Name = "turnCountLabel";
            this.turnCountLabel.Size = new System.Drawing.Size(24, 24);
            this.turnCountLabel.TabIndex = 19;
            this.turnCountLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1036, 586);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Крестики-нолики";
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button beginButton;
        private System.Windows.Forms.ComboBox player2Selection;
        private System.Windows.Forms.ComboBox player1Selection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Игрок;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label playerTwoScoreField;
        private System.Windows.Forms.Label drawsScoreField;
        private System.Windows.Forms.Label playerOneScoreField;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label turnCountLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label turnLabel;
    }
}

