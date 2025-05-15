namespace Project
{
    partial class AddPicketForm
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
            LatitudeTextBox = new TextBox();
            LongitudeTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            MeasurementDatePicker = new DateTimePicker();
            MeasurementTypeComboBox = new ComboBox();
            ElectrodeTypeComboBox = new ComboBox();
            ValueTextBox = new TextBox();
            UnitTextBox = new TextBox();
            SaveBtn = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // LatitudeTextBox
            // 
            LatitudeTextBox.Location = new Point(87, 62);
            LatitudeTextBox.Name = "LatitudeTextBox";
            LatitudeTextBox.Size = new Size(130, 23);
            LatitudeTextBox.TabIndex = 0;
            // 
            // LongitudeTextBox
            // 
            LongitudeTextBox.Location = new Point(87, 116);
            LongitudeTextBox.Name = "LongitudeTextBox";
            LongitudeTextBox.Size = new Size(130, 23);
            LongitudeTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 44);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 2;
            label1.Text = "Широта";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 98);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 3;
            label2.Text = "Долгота";
            // 
            // MeasurementDatePicker
            // 
            MeasurementDatePicker.Location = new Point(56, 160);
            MeasurementDatePicker.Name = "MeasurementDatePicker";
            MeasurementDatePicker.Size = new Size(200, 23);
            MeasurementDatePicker.TabIndex = 4;
            // 
            // MeasurementTypeComboBox
            // 
            MeasurementTypeComboBox.FormattingEnabled = true;
            MeasurementTypeComboBox.Items.AddRange(new object[] { "Тип A", "Тип B", "Тип C", "Тип D" });
            MeasurementTypeComboBox.Location = new Point(87, 208);
            MeasurementTypeComboBox.Name = "MeasurementTypeComboBox";
            MeasurementTypeComboBox.Size = new Size(130, 23);
            MeasurementTypeComboBox.TabIndex = 5;
            // 
            // ElectrodeTypeComboBox
            // 
            ElectrodeTypeComboBox.FormattingEnabled = true;
            ElectrodeTypeComboBox.Items.AddRange(new object[] { "Тип A", "Тип B", "Тип C", "Тип D" });
            ElectrodeTypeComboBox.Location = new Point(87, 258);
            ElectrodeTypeComboBox.Name = "ElectrodeTypeComboBox";
            ElectrodeTypeComboBox.Size = new Size(130, 23);
            ElectrodeTypeComboBox.TabIndex = 6;
            // 
            // ValueTextBox
            // 
            ValueTextBox.Location = new Point(87, 310);
            ValueTextBox.Name = "ValueTextBox";
            ValueTextBox.Size = new Size(130, 23);
            ValueTextBox.TabIndex = 7;
            // 
            // UnitTextBox
            // 
            UnitTextBox.Location = new Point(87, 360);
            UnitTextBox.Name = "UnitTextBox";
            UnitTextBox.Size = new Size(130, 23);
            UnitTextBox.TabIndex = 8;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(111, 399);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(80, 25);
            SaveBtn.TabIndex = 9;
            SaveBtn.Text = "Добавить";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 190);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 10;
            label3.Text = "Тип измерения";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 240);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 11;
            label4.Text = "Тип электрода";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(87, 292);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 12;
            label5.Text = "Значение";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(87, 342);
            label6.Name = "label6";
            label6.Size = new Size(116, 15);
            label6.TabIndex = 13;
            label6.Text = "Единица измерения";
            // 
            // AddPicketForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 447);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(SaveBtn);
            Controls.Add(UnitTextBox);
            Controls.Add(ValueTextBox);
            Controls.Add(ElectrodeTypeComboBox);
            Controls.Add(MeasurementTypeComboBox);
            Controls.Add(MeasurementDatePicker);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LongitudeTextBox);
            Controls.Add(LatitudeTextBox);
            Name = "AddPicketForm";
            Text = "AddPicketForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LatitudeTextBox;
        private TextBox LongitudeTextBox;
        private Label label1;
        private Label label2;
        private DateTimePicker MeasurementDatePicker;
        private ComboBox MeasurementTypeComboBox;
        private ComboBox ElectrodeTypeComboBox;
        private TextBox ValueTextBox;
        private TextBox UnitTextBox;
        private Button SaveBtn;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}