namespace Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoginText = new TextBox();
            PasswordText = new TextBox();
            LoginBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // LoginText
            // 
            LoginText.Location = new Point(140, 45);
            LoginText.Name = "LoginText";
            LoginText.Size = new Size(100, 23);
            LoginText.TabIndex = 0;
            // 
            // PasswordText
            // 
            PasswordText.Location = new Point(140, 100);
            PasswordText.Name = "PasswordText";
            PasswordText.Size = new Size(100, 23);
            PasswordText.TabIndex = 1;
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(150, 142);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(75, 23);
            LoginBtn.TabIndex = 2;
            LoginBtn.Text = "Войти";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 27);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 3;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 82);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 4;
            label2.Text = "Пароль";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 244);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LoginBtn);
            Controls.Add(PasswordText);
            Controls.Add(LoginText);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoginText;
        private TextBox PasswordText;
        private Button LoginBtn;
        private Label label1;
        private Label label2;
    }
}
