namespace Project
{
    partial class AddProjectForm
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
            StatusComboBox = new ComboBox();
            ProjectNameTextBox = new TextBox();
            CustomerComboBox = new ComboBox();
            SaveBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // StatusComboBox
            // 
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Items.AddRange(new object[] { "Новый", "В работе", "Закончен" });
            StatusComboBox.Location = new Point(72, 159);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(137, 23);
            StatusComboBox.TabIndex = 0;
            // 
            // ProjectNameTextBox
            // 
            ProjectNameTextBox.Location = new Point(72, 52);
            ProjectNameTextBox.Name = "ProjectNameTextBox";
            ProjectNameTextBox.Size = new Size(137, 23);
            ProjectNameTextBox.TabIndex = 1;
            // 
            // CustomerComboBox
            // 
            CustomerComboBox.FormattingEnabled = true;
            CustomerComboBox.Location = new Point(72, 105);
            CustomerComboBox.Name = "CustomerComboBox";
            CustomerComboBox.Size = new Size(137, 23);
            CustomerComboBox.TabIndex = 2;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(103, 209);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(75, 23);
            SaveBtn.TabIndex = 3;
            SaveBtn.Text = "Добавить";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 34);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 4;
            label1.Text = "Название проекта";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 87);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 5;
            label2.Text = "Заказчик";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 141);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 6;
            label3.Text = "Статус";
            // 
            // AddProjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 263);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SaveBtn);
            Controls.Add(CustomerComboBox);
            Controls.Add(ProjectNameTextBox);
            Controls.Add(StatusComboBox);
            Name = "AddProjectForm";
            Text = "AddProjectForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox StatusComboBox;
        private TextBox ProjectNameTextBox;
        private ComboBox CustomerComboBox;
        private Button SaveBtn;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}