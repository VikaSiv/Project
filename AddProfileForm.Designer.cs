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
            label1 = new Label();
            SaveBtn = new Button();
            CoordinatesDataGridView = new DataGridView();
            XCordTextBox = new TextBox();
            YCordTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            AddPointBtn = new Button();
            RemovePointBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)CoordinatesDataGridView).BeginInit();
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
            TypeProfileComboBox.SelectedIndexChanged += TypeProfileComboBox_SelectedIndexChanged;
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
            // SaveBtn
            // 
            SaveBtn.Location = new Point(143, 372);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(75, 23);
            SaveBtn.TabIndex = 6;
            SaveBtn.Text = "Сохранить";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SabeBtn_Click;
            // 
            // CoordinatesDataGridView
            // 
            CoordinatesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CoordinatesDataGridView.Location = new Point(143, 136);
            CoordinatesDataGridView.Name = "CoordinatesDataGridView";
            CoordinatesDataGridView.Size = new Size(270, 190);
            CoordinatesDataGridView.TabIndex = 7;
            // 
            // XCordTextBox
            // 
            XCordTextBox.Location = new Point(21, 152);
            XCordTextBox.Name = "XCordTextBox";
            XCordTextBox.Size = new Size(100, 23);
            XCordTextBox.TabIndex = 8;
            // 
            // YCordTextBox
            // 
            YCordTextBox.Location = new Point(21, 202);
            YCordTextBox.Name = "YCordTextBox";
            YCordTextBox.Size = new Size(100, 23);
            YCordTextBox.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 134);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 10;
            label2.Text = "X";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 184);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 11;
            label3.Text = "Y";
            // 
            // AddPointBtn
            // 
            AddPointBtn.Location = new Point(33, 247);
            AddPointBtn.Name = "AddPointBtn";
            AddPointBtn.Size = new Size(75, 23);
            AddPointBtn.TabIndex = 12;
            AddPointBtn.Text = "Добавить";
            AddPointBtn.UseVisualStyleBackColor = true;
            AddPointBtn.Click += AddPointBtn_Click;
            // 
            // RemovePointBtn
            // 
            RemovePointBtn.Location = new Point(33, 290);
            RemovePointBtn.Name = "RemovePointBtn";
            RemovePointBtn.Size = new Size(75, 23);
            RemovePointBtn.TabIndex = 13;
            RemovePointBtn.Text = "Удалить";
            RemovePointBtn.UseVisualStyleBackColor = true;
            RemovePointBtn.Click += RemovePointBtn_Click;
            // 
            // AddProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 445);
            Controls.Add(RemovePointBtn);
            Controls.Add(AddPointBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(YCordTextBox);
            Controls.Add(XCordTextBox);
            Controls.Add(CoordinatesDataGridView);
            Controls.Add(SaveBtn);
            Controls.Add(label1);
            Controls.Add(TypeProfileComboBox);
            Name = "AddProfileForm";
            Text = "AddProfileForm";
            ((System.ComponentModel.ISupportInitialize)CoordinatesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox TypeProfileComboBox;
        private Label label1;
        private Button SaveBtn;
        private DataGridView CoordinatesDataGridView;
        private TextBox XCordTextBox;
        private TextBox YCordTextBox;
        private Label label2;
        private Label label3;
        private Button AddPointBtn;
        private Button RemovePointBtn;
    }
}