namespace MsosiCardApp
{
    partial class userReg
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userReg));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.balanceTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.regUserBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.userNameTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.closeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.accountNumberLb = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.accountNumberLb);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.balanceTxt);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.phoneTxt);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.regUserBtn);
            this.panel3.Controls.Add(this.userNameTxt);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1378, 560);
            this.panel3.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label5.Location = new System.Drawing.Point(317, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 22);
            this.label5.TabIndex = 20;
            this.label5.Text = "Intitial Balance";
            // 
            // balanceTxt
            // 
            this.balanceTxt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.balanceTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.balanceTxt.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceTxt.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.balanceTxt.HintForeColor = System.Drawing.Color.Empty;
            this.balanceTxt.HintText = "";
            this.balanceTxt.isPassword = false;
            this.balanceTxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.balanceTxt.LineIdleColor = System.Drawing.Color.Gray;
            this.balanceTxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.balanceTxt.LineThickness = 4;
            this.balanceTxt.Location = new System.Drawing.Point(321, 341);
            this.balanceTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.balanceTxt.Name = "balanceTxt";
            this.balanceTxt.Size = new System.Drawing.Size(318, 45);
            this.balanceTxt.TabIndex = 19;
            this.balanceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.balanceTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.balanceTxt_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label4.Location = new System.Drawing.Point(686, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "Phone";
            // 
            // phoneTxt
            // 
            this.phoneTxt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.phoneTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneTxt.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTxt.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.phoneTxt.HintForeColor = System.Drawing.Color.Empty;
            this.phoneTxt.HintText = "";
            this.phoneTxt.isPassword = false;
            this.phoneTxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.phoneTxt.LineIdleColor = System.Drawing.Color.Gray;
            this.phoneTxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.phoneTxt.LineThickness = 4;
            this.phoneTxt.Location = new System.Drawing.Point(690, 81);
            this.phoneTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(318, 45);
            this.phoneTxt.TabIndex = 16;
            this.phoneTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.phoneTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneTxt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Location = new System.Drawing.Point(308, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Full Name";
            // 
            // regUserBtn
            // 
            this.regUserBtn.Activecolor = System.Drawing.Color.DarkGreen;
            this.regUserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.regUserBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.regUserBtn.BorderRadius = 5;
            this.regUserBtn.ButtonText = "REGISTER USER";
            this.regUserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regUserBtn.DisabledColor = System.Drawing.Color.Gray;
            this.regUserBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.regUserBtn.Iconimage = null;
            this.regUserBtn.Iconimage_right = null;
            this.regUserBtn.Iconimage_right_Selected = null;
            this.regUserBtn.Iconimage_Selected = null;
            this.regUserBtn.IconMarginLeft = 0;
            this.regUserBtn.IconMarginRight = 0;
            this.regUserBtn.IconRightVisible = true;
            this.regUserBtn.IconRightZoom = 0D;
            this.regUserBtn.IconVisible = true;
            this.regUserBtn.IconZoom = 90D;
            this.regUserBtn.IsTab = false;
            this.regUserBtn.Location = new System.Drawing.Point(561, 471);
            this.regUserBtn.Name = "regUserBtn";
            this.regUserBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.regUserBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(49)))), ((int)(((byte)(199)))));
            this.regUserBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.regUserBtn.selected = false;
            this.regUserBtn.Size = new System.Drawing.Size(361, 65);
            this.regUserBtn.TabIndex = 10;
            this.regUserBtn.Text = "REGISTER USER";
            this.regUserBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.regUserBtn.Textcolor = System.Drawing.Color.White;
            this.regUserBtn.TextFont = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regUserBtn.Click += new System.EventHandler(this.regUserBtn_Click);
            // 
            // userNameTxt
            // 
            this.userNameTxt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.userNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameTxt.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTxt.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.userNameTxt.HintForeColor = System.Drawing.Color.Empty;
            this.userNameTxt.HintText = "";
            this.userNameTxt.isPassword = false;
            this.userNameTxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.userNameTxt.LineIdleColor = System.Drawing.Color.Gray;
            this.userNameTxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.userNameTxt.LineThickness = 4;
            this.userNameTxt.Location = new System.Drawing.Point(312, 81);
            this.userNameTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(318, 45);
            this.userNameTxt.TabIndex = 11;
            this.userNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userNameTxt.OnValueChanged += new System.EventHandler(this.userNameTxt_OnValueChanged);
            this.userNameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userNameTxt_KeyPress_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 655);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1378, 125);
            this.panel2.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label2.Location = new System.Drawing.Point(555, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "USER REGISTRATION";
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.ImageActive = null;
            this.closeBtn.Location = new System.Drawing.Point(1310, 23);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(40, 34);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 14;
            this.closeBtn.TabStop = false;
            this.closeBtn.Zoom = 10;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1378, 95);
            this.panel1.TabIndex = 21;
            // 
            // accountNumberLb
            // 
            this.accountNumberLb.AutoSize = true;
            this.accountNumberLb.BackColor = System.Drawing.Color.Transparent;
            this.accountNumberLb.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNumberLb.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.accountNumberLb.Location = new System.Drawing.Point(306, 210);
            this.accountNumberLb.Name = "accountNumberLb";
            this.accountNumberLb.Size = new System.Drawing.Size(0, 32);
            this.accountNumberLb.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label6.Location = new System.Drawing.Point(308, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 22);
            this.label6.TabIndex = 22;
            this.label6.Text = "Account Number";
            // 
            // userReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 780);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userReg";
            this.Text = "userReg";
            this.Load += new System.EventHandler(this.userReg_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox balanceTxt;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox phoneTxt;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton regUserBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox userNameTxt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton closeBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label accountNumberLb;
    }
}