namespace Project.UserContols
{
    partial class ProjectUserControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            lbl1 = new Label();
            lbl2 = new Label();
            MoreInfoBtn = new Button();
            StatusTxt = new Label();
            ProjectNameTxt = new Label();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(14, 14);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(79, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "ProjectName:";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(14, 52);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(42, 15);
            lbl2.TabIndex = 1;
            lbl2.Text = "Status:";
            // 
            // MoreInfoBtn
            // 
            MoreInfoBtn.Location = new Point(15, 92);
            MoreInfoBtn.Name = "MoreInfoBtn";
            MoreInfoBtn.Size = new Size(75, 23);
            MoreInfoBtn.TabIndex = 2;
            MoreInfoBtn.Text = "Подробнее";
            MoreInfoBtn.UseVisualStyleBackColor = true;
            MoreInfoBtn.Click += MoreInfoBtn_Click;
            // 
            // StatusTxt
            // 
            StatusTxt.AutoSize = true;
            StatusTxt.Location = new Point(62, 52);
            StatusTxt.Name = "StatusTxt";
            StatusTxt.Size = new Size(38, 15);
            StatusTxt.TabIndex = 3;
            StatusTxt.Text = "label1";
            // 
            // ProjectNameTxt
            // 
            ProjectNameTxt.AutoSize = true;
            ProjectNameTxt.Location = new Point(99, 14);
            ProjectNameTxt.Name = "ProjectNameTxt";
            ProjectNameTxt.Size = new Size(38, 15);
            ProjectNameTxt.TabIndex = 4;
            ProjectNameTxt.Text = "label2";
            // 
            // ProjectUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(ProjectNameTxt);
            Controls.Add(StatusTxt);
            Controls.Add(MoreInfoBtn);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Name = "ProjectUserControl";
            Size = new Size(325, 163);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label lbl2;
        private Button MoreInfoBtn;
        private Label StatusTxt;
        private Label ProjectNameTxt;
    }
}
