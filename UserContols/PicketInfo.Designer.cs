namespace Project.UserContols
{
    partial class PicketInfo
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
            Lbl1 = new Label();
            idLbl = new Label();
            label1 = new Label();
            label2 = new Label();
            LatitudeTxt = new Label();
            LongitudeTxt = new Label();
            label3 = new Label();
            UnitTxt = new Label();
            lbl5 = new Label();
            ValueTxt = new Label();
            label4 = new Label();
            ElectrodeTypeTxt = new Label();
            SuspendLayout();
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.Location = new Point(14, 19);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(21, 15);
            Lbl1.TabIndex = 0;
            Lbl1.Text = "ID:";
            // 
            // idLbl
            // 
            idLbl.AutoSize = true;
            idLbl.Location = new Point(41, 19);
            idLbl.Name = "idLbl";
            idLbl.Size = new Size(38, 15);
            idLbl.TabIndex = 1;
            idLbl.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 9);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 2;
            label1.Text = "Latitude:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 30);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 3;
            label2.Text = "Longitude:";
            // 
            // LatitudeTxt
            // 
            LatitudeTxt.AutoSize = true;
            LatitudeTxt.Location = new Point(164, 9);
            LatitudeTxt.Name = "LatitudeTxt";
            LatitudeTxt.Size = new Size(38, 15);
            LatitudeTxt.TabIndex = 4;
            LatitudeTxt.Text = "label3";
            // 
            // LongitudeTxt
            // 
            LongitudeTxt.AutoSize = true;
            LongitudeTxt.Location = new Point(175, 30);
            LongitudeTxt.Name = "LongitudeTxt";
            LongitudeTxt.Size = new Size(38, 15);
            LongitudeTxt.TabIndex = 5;
            LongitudeTxt.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(241, 19);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 6;
            label3.Text = "Unit:";
            // 
            // UnitTxt
            // 
            UnitTxt.AutoSize = true;
            UnitTxt.Location = new Point(279, 19);
            UnitTxt.Name = "UnitTxt";
            UnitTxt.Size = new Size(38, 15);
            UnitTxt.TabIndex = 7;
            UnitTxt.Text = "label4";
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Location = new Point(340, 19);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(38, 15);
            lbl5.TabIndex = 8;
            lbl5.Text = "Value:";
            // 
            // ValueTxt
            // 
            ValueTxt.AutoSize = true;
            ValueTxt.Location = new Point(384, 19);
            ValueTxt.Name = "ValueTxt";
            ValueTxt.Size = new Size(38, 15);
            ValueTxt.TabIndex = 9;
            ValueTxt.Text = "label4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(447, 19);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 10;
            label4.Text = "ElectrodeType:";
            // 
            // ElectrodeTypeTxt
            // 
            ElectrodeTypeTxt.AutoSize = true;
            ElectrodeTypeTxt.Location = new Point(536, 19);
            ElectrodeTypeTxt.Name = "ElectrodeTypeTxt";
            ElectrodeTypeTxt.Size = new Size(38, 15);
            ElectrodeTypeTxt.TabIndex = 11;
            ElectrodeTypeTxt.Text = "label5";
            // 
            // PicketInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(ElectrodeTypeTxt);
            Controls.Add(label4);
            Controls.Add(ValueTxt);
            Controls.Add(lbl5);
            Controls.Add(UnitTxt);
            Controls.Add(label3);
            Controls.Add(LongitudeTxt);
            Controls.Add(LatitudeTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(idLbl);
            Controls.Add(Lbl1);
            Name = "PicketInfo";
            Size = new Size(680, 52);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl1;
        private Label idLbl;
        private Label label1;
        private Label label2;
        private Label LatitudeTxt;
        private Label LongitudeTxt;
        private Label label3;
        private Label UnitTxt;
        private Label lbl5;
        private Label ValueTxt;
        private Label label4;
        private Label ElectrodeTypeTxt;
    }
}
