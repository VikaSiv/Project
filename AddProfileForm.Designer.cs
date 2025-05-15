namespace Project
{
    partial class AddProfileForm
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
            TypeProfileComboBox = new ComboBox();
            XCordTextBox = new TextBox();
            YCordTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SaveBtn = new Button();
            SuspendLayout();
            // 
            // TypeProfileComboBox
            // 
            TypeProfileComboBox.FormattingEnabled = true;
            TypeProfileComboBox.Items.AddRange(new object[] { "Сейсмический", "Гравиметрический", "Магнитный", "Электрический" });
            TypeProfileComboBox.Location = new Point(76, 51);
            TypeProfileComboBox.Name = "TypeProfileComboBox";
            TypeProfileComboBox.Size = new Size(142, 23);
            TypeProfileComboBox.TabIndex = 0;
            // 
            // XCordTextBox
            // 
            XCordTextBox.Location = new Point(90, 109);
            XCordTextBox.Name = "XCordTextBox";
            XCordTextBox.Size = new Size(100, 23);
            XCordTextBox.TabIndex = 1;
            // 
            // YCordTextBox
            // 
            YCordTextBox.Location = new Point(90, 159);
            YCordTextBox.Name = "YCordTextBox";
            YCordTextBox.Size = new Size(100, 23);
            YCordTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 33);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 3;
            label1.Text = "Тип профиля";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 91);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 4;
            label2.Text = "X";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 141);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 5;
            label3.Text = "Y";
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(103, 210);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(75, 23);
            SaveBtn.TabIndex = 6;
            SaveBtn.Text = "Сохранить";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SabeBtn_Click;
            // 
            // AddProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 296);
            Controls.Add(SaveBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(YCordTextBox);
            Controls.Add(XCordTextBox);
            Controls.Add(TypeProfileComboBox);
            Name = "AddProfileForm";
            Text = "AddProfileForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox TypeProfileComboBox;
        private TextBox XCordTextBox;
        private TextBox YCordTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button SaveBtn;
    }
}