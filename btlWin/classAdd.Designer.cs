namespace btlWin1
{
    partial class classAdd
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
            label18 = new Label();
            label17 = new Label();
            txtClassMa = new TextBox();
            txtClassName = new TextBox();
            btnAdd = new Button();
            labelError = new Label();
            SuspendLayout();
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(239, 36);
            label18.Name = "label18";
            label18.Size = new Size(64, 15);
            label18.TabIndex = 10;
            label18.Text = "Tên Ngành";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(46, 36);
            label17.Name = "label17";
            label17.Size = new Size(51, 15);
            label17.TabIndex = 11;
            label17.Text = "Tên  Lớp";
            // 
            // txtClassMa
            // 
            txtClassMa.Location = new Point(239, 54);
            txtClassMa.Name = "txtClassMa";
            txtClassMa.Size = new Size(211, 23);
            txtClassMa.TabIndex = 6;
            txtClassMa.TextAlign = HorizontalAlignment.Center;
            // 
            // txtClassName
            // 
            txtClassName.Location = new Point(46, 54);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(133, 23);
            txtClassName.TabIndex = 5;
            txtClassName.TextAlign = HorizontalAlignment.Center;
            txtClassName.TextChanged += txtClassName_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(486, 41);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(99, 46);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.ForeColor = Color.Red;
            labelError.Location = new Point(306, 96);
            labelError.Name = "labelError";
            labelError.Size = new Size(0, 15);
            labelError.TabIndex = 16;
            // 
            // classAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 133);
            Controls.Add(labelError);
            Controls.Add(btnAdd);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(txtClassMa);
            Controls.Add(txtClassName);
            Name = "classAdd";
            Text = "Thêm Lớp";
            Load += classAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label18;
        private Label label17;
        private TextBox txtClassMa;
        private TextBox txtClassName;
        private Button btnAdd;
        private Label labelError;
    }
}