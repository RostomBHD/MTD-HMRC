namespace MTD
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
            label1 = new Label();
            label2 = new Label();
            From_date = new DateTimePicker();
            To_date = new DateTimePicker();
            Submit = new Button();
            label3 = new Label();
            CompanyName = new TextBox();
            RegistrationNum = new TextBox();
            label4 = new Label();
            label5 = new Label();
            sap_data = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 71);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "From:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(513, 73);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 1;
            label2.Text = "To:";
            label2.Click += label2_Click;
            // 
            // From_date
            // 
            From_date.Format = DateTimePickerFormat.Short;
            From_date.Location = new Point(64, 65);
            From_date.Name = "From_date";
            From_date.Size = new Size(200, 23);
            From_date.TabIndex = 2;
            From_date.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // To_date
            // 
            To_date.Format = DateTimePickerFormat.Short;
            To_date.Location = new Point(559, 67);
            To_date.Name = "To_date";
            To_date.Size = new Size(200, 23);
            To_date.TabIndex = 3;
            To_date.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // Submit
            // 
            Submit.Location = new Point(358, 415);
            Submit.Name = "Submit";
            Submit.Size = new Size(75, 23);
            Submit.TabIndex = 4;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 5;
            label3.Text = "APH MTD";
            label3.Click += label3_Click;
            // 
            // CompanyName
            // 
            CompanyName.Location = new Point(346, 317);
            CompanyName.Name = "CompanyName";
            CompanyName.Size = new Size(100, 23);
            CompanyName.TabIndex = 6;
            CompanyName.TextChanged += CompanyName_TextChanged;
            // 
            // RegistrationNum
            // 
            RegistrationNum.Location = new Point(346, 346);
            RegistrationNum.Name = "RegistrationNum";
            RegistrationNum.Size = new Size(100, 23);
            RegistrationNum.TabIndex = 7;
            RegistrationNum.TextChanged += RegistrationNum_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(222, 325);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 8;
            label4.Text = "Company name:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(179, 354);
            label5.Name = "label5";
            label5.Size = new Size(138, 15);
            label5.TabIndex = 9;
            label5.Text = "VAT registration number:";
            // 
            // sap_data
            // 
            sap_data.AutoSize = true;
            sap_data.Location = new Point(317, 116);
            sap_data.Name = "sap_data";
            sap_data.Size = new Size(0, 15);
            sap_data.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(665, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 51);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(sap_data);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(RegistrationNum);
            Controls.Add(CompanyName);
            Controls.Add(label3);
            Controls.Add(Submit);
            Controls.Add(To_date);
            Controls.Add(From_date);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker From_date;
        private DateTimePicker To_date;
        private Button Submit;
        private Label label3;
        private TextBox CompanyName;
        private TextBox RegistrationNum;
        private Label label4;
        private Label label5;
        private Label sap_data;
        private PictureBox pictureBox1;
    }
}
