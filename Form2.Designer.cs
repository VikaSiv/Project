namespace Project
{
    partial class Form2
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
            ProjectListPanel = new FlowLayoutPanel();
            AddProjectBtn = new Button();
            ClearDbBtn = new Button();
            SeedDbBtn = new Button();
            SuspendLayout();
            // 
            // ProjectListPanel
            // 
            ProjectListPanel.AutoScroll = true;
            ProjectListPanel.Location = new Point(54, 77);
            ProjectListPanel.Name = "ProjectListPanel";
            ProjectListPanel.Size = new Size(694, 315);
            ProjectListPanel.TabIndex = 0;
            // 
            // AddProjectBtn
            // 
            AddProjectBtn.Location = new Point(22, 12);
            AddProjectBtn.Name = "AddProjectBtn";
            AddProjectBtn.Size = new Size(84, 43);
            AddProjectBtn.TabIndex = 1;
            AddProjectBtn.Text = "Добавить проект";
            AddProjectBtn.UseVisualStyleBackColor = true;
            AddProjectBtn.Click += AddProjectBtn_Click;
            // 
            // ClearDbBtn
            // 
            ClearDbBtn.Location = new Point(605, 30);
            ClearDbBtn.Name = "ClearDbBtn";
            ClearDbBtn.Size = new Size(75, 23);
            ClearDbBtn.TabIndex = 2;
            ClearDbBtn.Text = "Очистить";
            ClearDbBtn.UseVisualStyleBackColor = true;
            ClearDbBtn.Click += ClearDbBtn_Click;
            // 
            // SeedDbBtn
            // 
            SeedDbBtn.Location = new Point(701, 30);
            SeedDbBtn.Name = "SeedDbBtn";
            SeedDbBtn.Size = new Size(75, 23);
            SeedDbBtn.TabIndex = 3;
            SeedDbBtn.Text = "Заполнить";
            SeedDbBtn.UseVisualStyleBackColor = true;
            SeedDbBtn.Click += SeedDbBtn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SeedDbBtn);
            Controls.Add(ClearDbBtn);
            Controls.Add(AddProjectBtn);
            Controls.Add(ProjectListPanel);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel ProjectListPanel;
        private Button AddProjectBtn;
        private Button ClearDbBtn;
        private Button SeedDbBtn;
    }
}