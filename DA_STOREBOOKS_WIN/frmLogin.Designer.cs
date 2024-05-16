
namespace DA_STOREBOOKS_WIN
{
    partial class frmLogin
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
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.chk_HienMatKhau = new System.Windows.Forms.CheckBox();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(138, 330);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(260, 30);
            this.txt_Password.TabIndex = 24;
            this.txt_Password.UseSystemPasswordChar = true;
            this.txt_Password.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Password_KeyUp);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Login.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Login.Location = new System.Drawing.Point(138, 433);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(181, 48);
            this.btn_Login.TabIndex = 23;
            this.btn_Login.Text = "Đăng nhập";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // chk_HienMatKhau
            // 
            this.chk_HienMatKhau.AutoSize = true;
            this.chk_HienMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chk_HienMatKhau.Location = new System.Drawing.Point(138, 376);
            this.chk_HienMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.chk_HienMatKhau.Name = "chk_HienMatKhau";
            this.chk_HienMatKhau.Size = new System.Drawing.Size(138, 22);
            this.chk_HienMatKhau.TabIndex = 22;
            this.chk_HienMatKhau.Text = "Hiện mật khẩu";
            this.chk_HienMatKhau.UseVisualStyleBackColor = true;
            this.chk_HienMatKhau.CheckedChanged += new System.EventHandler(this.chk_HienMatKhau_CheckedChanged);
            // 
            // txt_User
            // 
            this.txt_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_User.Location = new System.Drawing.Point(138, 240);
            this.txt_User.Margin = new System.Windows.Forms.Padding(0);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(260, 30);
            this.txt_User.TabIndex = 21;
            this.txt_User.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_User_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(142, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(142, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Password:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::DA_STOREBOOKS_WIN.Properties.Resources.anh_o_khoa;
            this.pictureBox4.Image = global::DA_STOREBOOKS_WIN.Properties.Resources.anh_o_khoa;
            this.pictureBox4.Location = new System.Drawing.Point(66, 330);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(55, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::DA_STOREBOOKS_WIN.Properties.Resources.User;
            this.pictureBox3.Image = global::DA_STOREBOOKS_WIN.Properties.Resources.User;
            this.pictureBox3.Location = new System.Drawing.Point(66, 240);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_logo.Image = global::DA_STOREBOOKS_WIN.Properties.Resources.logoTachNen;
            this.pictureBox_logo.Location = new System.Drawing.Point(131, 11);
            this.pictureBox_logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(225, 147);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_logo.TabIndex = 18;
            this.pictureBox_logo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DA_STOREBOOKS_WIN.Properties.Resources.e3a316a016fdaa7daa098465e2cf812e;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(486, 513);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btn_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 513);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.chk_HienMatKhau);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox_logo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.CheckBox chk_HienMatKhau;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}