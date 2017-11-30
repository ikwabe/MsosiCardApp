namespace MsosiCardApp
{
    partial class centreReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(centreReg));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.regCentBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.centNameTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.empRegBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.closeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // regCentBtn
            // 
            this.regCentBtn.Activecolor = System.Drawing.Color.DarkGreen;
            this.regCentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.regCentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.regCentBtn.BorderRadius = 5;
            this.regCentBtn.ButtonText = "REGISTER CENTRE";
            this.regCentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regCentBtn.DisabledColor = System.Drawing.Color.Gray;
            this.regCentBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.regCentBtn.Iconimage = null;
            this.regCentBtn.Iconimage_right = null;
            this.regCentBtn.Iconimage_right_Selected = null;
            this.regCentBtn.Iconimage_Selected = null;
            this.regCentBtn.IconMarginLeft = 0;
            this.regCentBtn.IconMarginRight = 0;
            this.regCentBtn.IconRightVisible = true;
            this.regCentBtn.IconRightZoom = 0D;
            this.regCentBtn.IconVisible = true;
            this.regCentBtn.IconZoom = 90D;
            this.regCentBtn.IsTab = false;
            this.regCentBtn.Location = new System.Drawing.Point(458, 171);
            this.regCentBtn.Name = "regCentBtn";
            this.regCentBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.regCentBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(49)))), ((int)(((byte)(199)))));
            this.regCentBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.regCentBtn.selected = false;
            this.regCentBtn.Size = new System.Drawing.Size(392, 65);
            this.regCentBtn.TabIndex = 10;
            this.regCentBtn.Text = "REGISTER CENTRE";
            this.regCentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.regCentBtn.Textcolor = System.Drawing.Color.White;
            this.regCentBtn.TextFont = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regCentBtn.Click += new System.EventHandler(this.regCentBtn_Click);
            // 
            // centNameTxt
            // 
            this.centNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.centNameTxt.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centNameTxt.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.centNameTxt.HintForeColor = System.Drawing.Color.Empty;
            this.centNameTxt.HintText = "";
            this.centNameTxt.isPassword = false;
            this.centNameTxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.centNameTxt.LineIdleColor = System.Drawing.Color.Gray;
            this.centNameTxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.centNameTxt.LineThickness = 4;
            this.centNameTxt.Location = new System.Drawing.Point(458, 98);
            this.centNameTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.centNameTxt.Name = "centNameTxt";
            this.centNameTxt.Size = new System.Drawing.Size(392, 45);
            this.centNameTxt.TabIndex = 11;
            this.centNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Location = new System.Drawing.Point(560, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter Centre Name";
            // 
            // empRegBtn
            // 
            this.empRegBtn.Activecolor = System.Drawing.Color.DarkGreen;
            this.empRegBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.empRegBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.empRegBtn.BorderRadius = 5;
            this.empRegBtn.ButtonText = "REGISTER EMPLOYEE";
            this.empRegBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.empRegBtn.DisabledColor = System.Drawing.Color.Gray;
            this.empRegBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.empRegBtn.Iconimage = null;
            this.empRegBtn.Iconimage_right = null;
            this.empRegBtn.Iconimage_right_Selected = null;
            this.empRegBtn.Iconimage_Selected = null;
            this.empRegBtn.IconMarginLeft = 0;
            this.empRegBtn.IconMarginRight = 0;
            this.empRegBtn.IconRightVisible = true;
            this.empRegBtn.IconRightZoom = 0D;
            this.empRegBtn.IconVisible = true;
            this.empRegBtn.IconZoom = 90D;
            this.empRegBtn.IsTab = false;
            this.empRegBtn.Location = new System.Drawing.Point(20, 14);
            this.empRegBtn.Name = "empRegBtn";
            this.empRegBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.empRegBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(49)))), ((int)(((byte)(199)))));
            this.empRegBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.empRegBtn.selected = false;
            this.empRegBtn.Size = new System.Drawing.Size(291, 57);
            this.empRegBtn.TabIndex = 13;
            this.empRegBtn.Text = "REGISTER EMPLOYEE";
            this.empRegBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.empRegBtn.Textcolor = System.Drawing.Color.White;
            this.empRegBtn.TextFont = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empRegBtn.Click += new System.EventHandler(this.empRegBtn_Click);
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
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.empRegBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1378, 209);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 571);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1378, 209);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.regCentBtn);
            this.panel3.Controls.Add(this.centNameTxt);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 209);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1378, 362);
            this.panel3.TabIndex = 17;
            // 
            // centreReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1378, 780);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "centreReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "centreReg";
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton closeBtn;
        private Bunifu.Framework.UI.BunifuFlatButton empRegBtn;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox centNameTxt;
        private Bunifu.Framework.UI.BunifuFlatButton regCentBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}