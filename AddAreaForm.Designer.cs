namespace Project
{
    partial class AddAreaForm
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
            DescTextBox = new TextBox();
            label1 = new Label();
            SaveBtn = new Button();
            CoordinatesDataGridView = new DataGridView();
            AddPointBtn = new Button();
            RemovePointBtn = new Button();
            XCordTextBox = new TextBox();
            YCordTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)CoordinatesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // DescTextBox
            // 
            DescTextBox.Location = new Point(65, 47);
            DescTextBox.Multiline = true;
            DescTextBox.Name = "DescTextBox";
            DescTextBox.Size = new Size(293, 68);
            DescTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 29);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 3;
            label1.Text = "Описание";
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(118, 313);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(75, 23);
            SaveBtn.TabIndex = 6;
            SaveBtn.Text = "Добавить";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // CoordinatesDataGridView
            // 
            CoordinatesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CoordinatesDataGridView.Location = new Point(118, 141);
            CoordinatesDataGridView.Name = "CoordinatesDataGridView";
            CoordinatesDataGridView.Size = new Size(240, 150);
            CoordinatesDataGridView.TabIndex = 7;
            // 
            // AddPointBtn
            // 
            AddPointBtn.Location = new Point(22, 227);
            AddPointBtn.Name = "AddPointBtn";
            AddPointBtn.Size = new Size(75, 23);
            AddPointBtn.TabIndex = 8;
            AddPointBtn.Text = "Добавить";
            AddPointBtn.UseVisualStyleBackColor = true;
            AddPointBtn.Click += AddPointBtn_Click;
            // 
            // RemovePointBtn
            // 
            RemovePointBtn.Location = new Point(22, 268);
            RemovePointBtn.Name = "RemovePointBtn";
            RemovePointBtn.Size = new Size(75, 23);
            RemovePointBtn.TabIndex = 9;
            RemovePointBtn.Text = "Удалить";
            RemovePointBtn.UseVisualStyleBackColor = true;
            RemovePointBtn.Click += RemovePointBtn_Click;
            // 
            // XCordTextBox
            // 
            XCordTextBox.Location = new Point(12, 141);
            XCordTextBox.Name = "XCordTextBox";
            XCordTextBox.Size = new Size(92, 23);
            XCordTextBox.TabIndex = 10;
            // 
            // YCordTextBox
            // 
            YCordTextBox.Location = new Point(12, 186);
            YCordTextBox.Name = "YCordTextBox";
            YCordTextBox.Size = new Size(92, 23);
            YCordTextBox.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 123);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 12;
            label2.Text = "X";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 168);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 13;
            label3.Text = "Y";
            // 
            // AddAreaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 376);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(YCordTextBox);
            Controls.Add(XCordTextBox);
            Controls.Add(RemovePointBtn);
            Controls.Add(AddPointBtn);
            Controls.Add(CoordinatesDataGridView);
            Controls.Add(SaveBtn);
            Controls.Add(label1);
            Controls.Add(DescTextBox);
            Name = "AddAreaForm";
            Text = "AddAreaForm";
            ((System.ComponentModel.ISupportInitialize)CoordinatesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DescTextBox;
        private Label label1;
        private Button SaveBtn;
        private DataGridView CoordinatesDataGridView;
        private Button AddPointBtn;
        private Button RemovePointBtn;
        private TextBox XCordTextBox;
        private TextBox YCordTextBox;
        private Label label2;
        private Label label3;
    }
}