namespace MsosiCardApp
{
    partial class EmpRegForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpRegForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.closeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.regEmpBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.empNameTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.userNameTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.roleCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.addressTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label2.Location = new System.Drawing.Point(555, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "EMPLOYEE REGISTRATION";
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
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Location = new System.Drawing.Point(313, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Full Name";
            // 
            // regEmpBtn
            // 
            this.regEmpBtn.Activecolor = System.Drawing.Color.DarkGreen;
            this.regEmpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.regEmpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.regEmpBtn.BorderRadius = 5;
            this.regEmpBtn.ButtonText = "REGISTER EMPLOYEE";
            this.regEmpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regEmpBtn.DisabledColor = System.Drawing.Color.Gray;
            this.regEmpBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.regEmpBtn.Iconimage = null;
            this.regEmpBtn.Iconimage_right = null;
            this.regEmpBtn.Iconimage_right_Selected = null;
            this.regEmpBtn.Iconimage_Selected = null;
            this.regEmpBtn.IconMarginLeft = 0;
            this.regEmpBtn.IconMarginRight = 0;
            this.regEmpBtn.IconRightVisible = true;
            this.regEmpBtn.IconRightZoom = 0D;
            this.regEmpBtn.IconVisible = true;
            this.regEmpBtn.IconZoom = 90D;
            this.regEmpBtn.IsTab = false;
            this.regEmpBtn.Location = new System.Drawing.Point(458, 568);
            this.regEmpBtn.Name = "regEmpBtn";
            this.regEmpBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.regEmpBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(49)))), ((int)(((byte)(199)))));
            this.regEmpBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.regEmpBtn.selected = false;
            this.regEmpBtn.Size = new System.Drawing.Size(392, 65);
            this.regEmpBtn.TabIndex = 10;
            this.regEmpBtn.Text = "REGISTER EMPLOYEE";
            this.regEmpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.regEmpBtn.Textcolor = System.Drawing.Color.White;
            this.regEmpBtn.TextFont = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regEmpBtn.Click += new System.EventHandler(this.regEmpBtn_Click);
            // 
            // empNameTxt
            // 
            this.empNameTxt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.empNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empNameTxt.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empNameTxt.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.empNameTxt.HintForeColor = System.Drawing.Color.Empty;
            this.empNameTxt.HintText = "";
            this.empNameTxt.isPassword = false;
            this.empNameTxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.empNameTxt.LineIdleColor = System.Drawing.Color.Gray;
            this.empNameTxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.empNameTxt.LineThickness = 4;
            this.empNameTxt.Location = new System.Drawing.Point(317, 166);
            this.empNameTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.empNameTxt.Name = "empNameTxt";
            this.empNameTxt.Size = new System.Drawing.Size(318, 45);
            this.empNameTxt.TabIndex = 11;
            this.empNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.empNameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.empNameTxt_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.userNameTxt);
            this.panel3.Controls.Add(this.roleCombo);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.phoneTxt);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.addressTxt);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.regEmpBtn);
            this.panel3.Controls.Add(this.empNameTxt);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1378, 655);
            this.panel3.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label6.Location = new System.Drawing.Point(704, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 22);
            this.label6.TabIndex = 21;
            this.label6.Text = "Role";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label5.Location = new System.Drawing.Point(313, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 22);
            this.label5.TabIndex = 20;
            this.label5.Text = "Username";
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
            this.userNameTxt.Location = new System.Drawing.Point(317, 456);
            this.userNameTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(318, 45);
            this.userNameTxt.TabIndex = 19;
            this.userNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // roleCombo
            // 
            this.roleCombo.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.roleCombo.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleCombo.FormattingEnabled = true;
            this.roleCombo.Items.AddRange(new object[] {
            "Admin",
            "Reception",
            "Mess"});
            this.roleCombo.Location = new System.Drawing.Point(708, 300);
            this.roleCombo.Name = "roleCombo";
            this.roleCombo.Size = new System.Drawing.Size(305, 30);
            this.roleCombo.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label4.Location = new System.Drawing.Point(691, 130);
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
            this.phoneTxt.Location = new System.Drawing.Point(695, 166);
            this.phoneTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(318, 45);
            this.phoneTxt.TabIndex = 16;
            this.phoneTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.phoneTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneTxt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label3.Location = new System.Drawing.Point(313, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Address";
            // 
            // addressTxt
            // 
            this.addressTxt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.addressTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addressTxt.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTxt.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.addressTxt.HintForeColor = System.Drawing.Color.Empty;
            this.addressTxt.HintText = "";
            this.addressTxt.isPassword = false;
            this.addressTxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.addressTxt.LineIdleColor = System.Drawing.Color.Gray;
            this.addressTxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.addressTxt.LineThickness = 4;
            this.addressTxt.Location = new System.Drawing.Point(317, 296);
            this.addressTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(318, 45);
            this.addressTxt.TabIndex = 14;
            this.addressTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 655);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1378, 125);
            this.panel2.TabIndex = 19;
            // 
            // EmpRegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 780);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmpRegForm";
            this.Text = "EmpRegForm";
            this.Load += new System.EventHandler(this.EmpRegForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton closeBtn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton regEmpBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox empNameTxt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox phoneTxt;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox addressTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox userNameTxt;
        private System.Windows.Forms.ComboBox roleCombo;
    }
}