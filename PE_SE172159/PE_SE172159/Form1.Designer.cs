namespace PE_SE172159
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
            label3 = new Label();
            txt_user = new TextBox();
            txt_pwd = new TextBox();
            btn_login = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(335, 27);
            label1.Name = "label1";
            label1.Size = new Size(102, 38);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(72, 121);
            label2.Name = "label2";
            label2.Size = new Size(123, 22);
            label2.TabIndex = 1;
            label2.Text = "UserAccount :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(72, 210);
            label3.Name = "label3";
            label3.Size = new Size(104, 22);
            label3.TabIndex = 2;
            label3.Text = "Password : ";
            // 
            // txt_user
            // 
            txt_user.Location = new Point(264, 116);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(279, 27);
            txt_user.TabIndex = 3;
            // 
            // txt_pwd
            // 
            txt_pwd.Location = new Point(264, 205);
            txt_pwd.Name = "txt_pwd";
            txt_pwd.Size = new Size(279, 27);
            txt_pwd.TabIndex = 4;
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.Location = new Point(289, 300);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(183, 48);
            btn_login.TabIndex = 5;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 437);
            Controls.Add(btn_login);
            Controls.Add(txt_pwd);
            Controls.Add(txt_user);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_user;
        private TextBox txt_pwd;
        private Button btn_login;
    }
}