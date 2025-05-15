namespace Project
{
    partial class ProjectView
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
            BackBtn = new Button();
            ProjectNameTxt = new Label();
            ListAreasCmb = new ComboBox();
            ListProfilesCmb = new ComboBox();
            ListPicketsCmb = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            PicketPanel = new Panel();
            AddAreaBtn = new Button();
            AddProfileBtn = new Button();
            AddPicketBtn = new Button();
            GraphicView = new OxyPlot.WindowsForms.PlotView();
            AreaGraphic = new OxyPlot.WindowsForms.PlotView();
            SuspendLayout();
            // 
            // BackBtn
            // 
            BackBtn.Font = new Font("Segoe UI", 10F);
            BackBtn.Location = new Point(12, 12);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(119, 49);
            BackBtn.TabIndex = 0;
            BackBtn.Text = "Список проектов";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // ProjectNameTxt
            // 
            ProjectNameTxt.AutoSize = true;
            ProjectNameTxt.Font = new Font("Segoe UI", 16F);
            ProjectNameTxt.Location = new Point(330, 18);
            ProjectNameTxt.Name = "ProjectNameTxt";
            ProjectNameTxt.Size = new Size(138, 30);
            ProjectNameTxt.TabIndex = 1;
            ProjectNameTxt.Text = "ProjectName";
            // 
            // ListAreasCmb
            // 
            ListAreasCmb.FormattingEnabled = true;
            ListAreasCmb.Location = new Point(41, 86);
            ListAreasCmb.Name = "ListAreasCmb";
            ListAreasCmb.Size = new Size(165, 23);
            ListAreasCmb.TabIndex = 2;
            ListAreasCmb.SelectedIndexChanged += ListAreasCmb_SelectedIndexChanged;
            // 
            // ListProfilesCmb
            // 
            ListProfilesCmb.FormattingEnabled = true;
            ListProfilesCmb.Location = new Point(280, 86);
            ListProfilesCmb.Name = "ListProfilesCmb";
            ListProfilesCmb.Size = new Size(165, 23);
            ListProfilesCmb.TabIndex = 3;
            ListProfilesCmb.SelectedIndexChanged += ListProfilesCmb_SelectedIndexChanged;
            // 
            // ListPicketsCmb
            // 
            ListPicketsCmb.FormattingEnabled = true;
            ListPicketsCmb.Location = new Point(509, 86);
            ListPicketsCmb.Name = "ListPicketsCmb";
            ListPicketsCmb.Size = new Size(165, 23);
            ListPicketsCmb.TabIndex = 4;
            ListPicketsCmb.SelectedIndexChanged += ListPicketsCmb_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 68);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 5;
            label1.Text = "Площади";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(280, 68);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 6;
            label2.Text = "Профили";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(509, 68);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 7;
            label3.Text = "Пикеты";
            // 
            // PicketPanel
            // 
            PicketPanel.Location = new Point(23, 124);
            PicketPanel.Name = "PicketPanel";
            PicketPanel.Size = new Size(765, 61);
            PicketPanel.TabIndex = 8;
            // 
            // AddAreaBtn
            // 
            AddAreaBtn.Location = new Point(550, 11);
            AddAreaBtn.Name = "AddAreaBtn";
            AddAreaBtn.Size = new Size(68, 50);
            AddAreaBtn.TabIndex = 9;
            AddAreaBtn.Text = "Добавить площадь";
            AddAreaBtn.UseVisualStyleBackColor = true;
            AddAreaBtn.Click += AddAreaBtn_Click;
            // 
            // AddProfileBtn
            // 
            AddProfileBtn.Location = new Point(624, 11);
            AddProfileBtn.Name = "AddProfileBtn";
            AddProfileBtn.Size = new Size(75, 50);
            AddProfileBtn.TabIndex = 10;
            AddProfileBtn.Text = "Добавить профиль";
            AddProfileBtn.UseVisualStyleBackColor = true;
            AddProfileBtn.Click += AddProfileBtn_Click;
            // 
            // AddPicketBtn
            // 
            AddPicketBtn.Location = new Point(705, 11);
            AddPicketBtn.Name = "AddPicketBtn";
            AddPicketBtn.Size = new Size(75, 50);
            AddPicketBtn.TabIndex = 11;
            AddPicketBtn.Text = "Добавить пикет";
            AddPicketBtn.UseVisualStyleBackColor = true;
            AddPicketBtn.Click += AddPicketBtn_Click;
            // 
            // GraphicView
            // 
            GraphicView.BackColor = SystemColors.Info;
            GraphicView.Location = new Point(23, 191);
            GraphicView.Name = "GraphicView";
            GraphicView.PanCursor = Cursors.Hand;
            GraphicView.Size = new Size(765, 247);
            GraphicView.TabIndex = 13;
            GraphicView.ZoomHorizontalCursor = Cursors.SizeWE;
            GraphicView.ZoomRectangleCursor = Cursors.SizeNWSE;
            GraphicView.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // AreaGraphic
            // 
            AreaGraphic.BackColor = SystemColors.Info;
            AreaGraphic.Location = new Point(23, 453);
            AreaGraphic.Name = "AreaGraphic";
            AreaGraphic.PanCursor = Cursors.Hand;
            AreaGraphic.Size = new Size(757, 284);
            AreaGraphic.TabIndex = 14;
            AreaGraphic.ZoomHorizontalCursor = Cursors.SizeWE;
            AreaGraphic.ZoomRectangleCursor = Cursors.SizeNWSE;
            AreaGraphic.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // ProjectView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 749);
            Controls.Add(AreaGraphic);
            Controls.Add(GraphicView);
            Controls.Add(AddPicketBtn);
            Controls.Add(AddProfileBtn);
            Controls.Add(AddAreaBtn);
            Controls.Add(PicketPanel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ListPicketsCmb);
            Controls.Add(ListProfilesCmb);
            Controls.Add(ListAreasCmb);
            Controls.Add(ProjectNameTxt);
            Controls.Add(BackBtn);
            Name = "ProjectView";
            Text = "ProjectView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackBtn;
        private Label ProjectNameTxt;
        private ComboBox ListAreasCmb;
        private ComboBox ListProfilesCmb;
        private ComboBox ListPicketsCmb;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel PicketPanel;
        private Button AddAreaBtn;
        private Button AddProfileBtn;
        private Button AddPicketBtn;
        private OxyPlot.WindowsForms.PlotView GraphicView;
        private OxyPlot.WindowsForms.PlotView AreaGraphic;
    }
}