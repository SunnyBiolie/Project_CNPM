namespace ProjectCS_CNPM
{
    partial class FormLogin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBoxUser = new System.Windows.Forms.PictureBox();
            this.picBoxTradeMark = new System.Windows.Forms.PictureBox();
            this.pictBoxThumb = new System.Windows.Forms.PictureBox();
            this.csTBoxName = new Project_CNPM.Controls.csTextBox();
            this.csTBoxPass = new Project_CNPM.Controls.csTextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblSlogan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTradeMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxThumb)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectCS_CNPM.Properties.Resources.password_img;
            this.pictureBox1.Location = new System.Drawing.Point(127, 382);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // picBoxUser
            // 
            this.picBoxUser.Image = global::ProjectCS_CNPM.Properties.Resources.user_img;
            this.picBoxUser.Location = new System.Drawing.Point(122, 328);
            this.picBoxUser.Name = "picBoxUser";
            this.picBoxUser.Size = new System.Drawing.Size(45, 45);
            this.picBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxUser.TabIndex = 2;
            this.picBoxUser.TabStop = false;
            // 
            // picBoxTradeMark
            // 
            this.picBoxTradeMark.Image = global::ProjectCS_CNPM.Properties.Resources.Screenshot_2023_02_23_101530;
            this.picBoxTradeMark.Location = new System.Drawing.Point(125, 260);
            this.picBoxTradeMark.Name = "picBoxTradeMark";
            this.picBoxTradeMark.Size = new System.Drawing.Size(350, 50);
            this.picBoxTradeMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxTradeMark.TabIndex = 1;
            this.picBoxTradeMark.TabStop = false;
            // 
            // pictBoxThumb
            // 
            this.pictBoxThumb.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictBoxThumb.Image = global::ProjectCS_CNPM.Properties.Resources.login_img;
            this.pictBoxThumb.Location = new System.Drawing.Point(0, 0);
            this.pictBoxThumb.Name = "pictBoxThumb";
            this.pictBoxThumb.Size = new System.Drawing.Size(582, 250);
            this.pictBoxThumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBoxThumb.TabIndex = 0;
            this.pictBoxThumb.TabStop = false;
            // 
            // csTBoxName
            // 
            this.csTBoxName.BackColor = System.Drawing.SystemColors.Window;
            this.csTBoxName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.csTBoxName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.csTBoxName.BorderRadius = 0;
            this.csTBoxName.BorderSize = 2;
            this.csTBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csTBoxName.ForeColor = System.Drawing.Color.DimGray;
            this.csTBoxName.Location = new System.Drawing.Point(173, 335);
            this.csTBoxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.csTBoxName.Multiline = false;
            this.csTBoxName.Name = "csTBoxName";
            this.csTBoxName.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.csTBoxName.PasswordChar = false;
            this.csTBoxName.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.csTBoxName.PlaceHolderText = "Tên đăng nhập";
            this.csTBoxName.Size = new System.Drawing.Size(300, 31);
            this.csTBoxName.TabIndex = 4;
            this.csTBoxName.Texts = "";
            this.csTBoxName.UnderlineStyle = true;
            // 
            // csTBoxPass
            // 
            this.csTBoxPass.BackColor = System.Drawing.SystemColors.Window;
            this.csTBoxPass.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.csTBoxPass.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(185)))), ((int)(((byte)(232)))));
            this.csTBoxPass.BorderRadius = 0;
            this.csTBoxPass.BorderSize = 2;
            this.csTBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csTBoxPass.ForeColor = System.Drawing.Color.DimGray;
            this.csTBoxPass.Location = new System.Drawing.Point(173, 385);
            this.csTBoxPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.csTBoxPass.Multiline = false;
            this.csTBoxPass.Name = "csTBoxPass";
            this.csTBoxPass.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.csTBoxPass.PasswordChar = true;
            this.csTBoxPass.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.csTBoxPass.PlaceHolderText = "Mật khẩu";
            this.csTBoxPass.Size = new System.Drawing.Size(300, 31);
            this.csTBoxPass.TabIndex = 5;
            this.csTBoxPass.Texts = "";
            this.csTBoxPass.UnderlineStyle = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(215, 448);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 40);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnLogin_Click);
            // 
            // lblSlogan
            // 
            this.lblSlogan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(177)))), ((int)(((byte)(65)))));
            this.lblSlogan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSlogan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlogan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblSlogan.Location = new System.Drawing.Point(0, 509);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(582, 44);
            this.lblSlogan.TabIndex = 7;
            this.lblSlogan.Text = "DRINK GOOD COFFEE – THE BETTER THE HEALTH";
            this.lblSlogan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.lblSlogan);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.csTBoxPass);
            this.Controls.Add(this.csTBoxName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picBoxUser);
            this.Controls.Add(this.picBoxTradeMark);
            this.Controls.Add(this.pictBoxThumb);
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Coffee House - Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTradeMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxThumb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBoxThumb;
        private System.Windows.Forms.PictureBox picBoxTradeMark;
        private System.Windows.Forms.PictureBox picBoxUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Project_CNPM.Controls.csTextBox csTBoxName;
        private Project_CNPM.Controls.csTextBox csTBoxPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblSlogan;
    }
}

