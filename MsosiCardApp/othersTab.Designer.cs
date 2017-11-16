namespace MsosiCardApp
{
    partial class othersTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(othersTab));
            this.animator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.juicePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ngmbMshkakiBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.kukuBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.kkMshkakiBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.nyamaBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.samakiBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ndiziBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.mayaiBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sousageBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.juicePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // animator
            // 
            this.animator.AnimationType = BunifuAnimatorNS.AnimationType.Rotate;
            this.animator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(50);
            animation1.RotateCoeff = 1F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.animator.DefaultAnimation = animation1;
            // 
            // juicePanel
            // 
            this.juicePanel.AutoScroll = true;
            this.juicePanel.BackColor = System.Drawing.Color.Transparent;
            this.juicePanel.Controls.Add(this.label1);
            this.juicePanel.Controls.Add(this.ngmbMshkakiBtn);
            this.juicePanel.Controls.Add(this.kukuBtn);
            this.juicePanel.Controls.Add(this.kkMshkakiBtn);
            this.juicePanel.Controls.Add(this.nyamaBtn);
            this.juicePanel.Controls.Add(this.samakiBtn);
            this.juicePanel.Controls.Add(this.ndiziBtn);
            this.juicePanel.Controls.Add(this.mayaiBtn);
            this.juicePanel.Controls.Add(this.sousageBtn);
            this.animator.SetDecoration(this.juicePanel, BunifuAnimatorNS.DecorationType.None);
            this.juicePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.juicePanel.Location = new System.Drawing.Point(0, 0);
            this.juicePanel.Name = "juicePanel";
            this.juicePanel.Size = new System.Drawing.Size(436, 551);
            this.juicePanel.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.animator.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(181, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 34);
            this.label1.TabIndex = 26;
            this.label1.Text = "NDIZI";
            // 
            // ngmbMshkakiBtn
            // 
            this.ngmbMshkakiBtn.Activecolor = System.Drawing.Color.DarkGreen;
            this.ngmbMshkakiBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ngmbMshkakiBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ngmbMshkakiBtn.BorderRadius = 5;
            this.ngmbMshkakiBtn.ButtonText = "MSHKAKI NG`OMBE";
            this.ngmbMshkakiBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.ngmbMshkakiBtn, BunifuAnimatorNS.DecorationType.None);
            this.ngmbMshkakiBtn.DisabledColor = System.Drawing.Color.Gray;
            this.ngmbMshkakiBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.ngmbMshkakiBtn.Iconimage = null;
            this.ngmbMshkakiBtn.Iconimage_right = null;
            this.ngmbMshkakiBtn.Iconimage_right_Selected = null;
            this.ngmbMshkakiBtn.Iconimage_Selected = null;
            this.ngmbMshkakiBtn.IconMarginLeft = 0;
            this.ngmbMshkakiBtn.IconMarginRight = 0;
            this.ngmbMshkakiBtn.IconRightVisible = true;
            this.ngmbMshkakiBtn.IconRightZoom = 0D;
            this.ngmbMshkakiBtn.IconVisible = true;
            this.ngmbMshkakiBtn.IconZoom = 90D;
            this.ngmbMshkakiBtn.IsTab = false;
            this.ngmbMshkakiBtn.Location = new System.Drawing.Point(42, 390);
            this.ngmbMshkakiBtn.Name = "ngmbMshkakiBtn";
            this.ngmbMshkakiBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ngmbMshkakiBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(49)))), ((int)(((byte)(199)))));
            this.ngmbMshkakiBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.ngmbMshkakiBtn.selected = false;
            this.ngmbMshkakiBtn.Size = new System.Drawing.Size(351, 41);
            this.ngmbMshkakiBtn.TabIndex = 17;
            this.ngmbMshkakiBtn.Text = "MSHKAKI NG`OMBE";
            this.ngmbMshkakiBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ngmbMshkakiBtn.Textcolor = System.Drawing.Color.White;
            this.ngmbMshkakiBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // kukuBtn
            // 
            this.kukuBtn.Activecolor = System.Drawing.Color.DarkGreen;
            this.kukuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.kukuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kukuBtn.BorderRadius = 5;
            this.kukuBtn.ButtonText = "KUKU";
            this.kukuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.kukuBtn, BunifuAnimatorNS.DecorationType.None);
            this.kukuBtn.DisabledColor = System.Drawing.Color.Gray;
            this.kukuBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.kukuBtn.Iconimage = null;
            this.kukuBtn.Iconimage_right = null;
            this.kukuBtn.Iconimage_right_Selected = null;
            this.kukuBtn.Iconimage_Selected = null;
            this.kukuBtn.IconMarginLeft = 0;
            this.kukuBtn.IconMarginRight = 0;
            this.kukuBtn.IconRightVisible = true;
            this.kukuBtn.IconRightZoom = 0D;
            this.kukuBtn.IconVisible = true;
            this.kukuBtn.IconZoom = 90D;
            this.kukuBtn.IsTab = false;
            this.kukuBtn.Location = new System.Drawing.Point(42, 61);
            this.kukuBtn.Name = "kukuBtn";
            this.kukuBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.kukuBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(49)))), ((int)(((byte)(199)))));
            this.kukuBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.kukuBtn.selected = false;
            this.kukuBtn.Size = new System.Drawing.Size(351, 41);
            this.kukuBtn.TabIndex = 9;
            this.kukuBtn.Text = "KUKU";
            this.kukuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.kukuBtn.Textcolor = System.Drawing.Color.White;
            this.kukuBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // kkMshkakiBtn
            // 
            this.kkMshkakiBtn.Activecolor = System.Drawing.Color.DarkGreen;
            this.kkMshkakiBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.kkMshkakiBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kkMshkakiBtn.BorderRadius = 5;
            this.kkMshkakiBtn.ButtonText = "MSHKAKI KUKU";
            this.kkMshkakiBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.kkMshkakiBtn, BunifuAnimatorNS.DecorationType.None);
            this.kkMshkakiBtn.DisabledColor = System.Drawing.Color.Gray;
            this.kkMshkakiBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.kkMshkakiBtn.Iconimage = null;
            this.kkMshkakiBtn.Iconimage_right = null;
            this.kkMshkakiBtn.Iconimage_right_Selected = null;
            this.kkMshkakiBtn.Iconimage_Selected = null;
            this.kkMshkakiBtn.IconMarginLeft = 0;
            this.kkMshkakiBtn.IconMarginRight = 0;
            this.kkMshkakiBtn.IconRightVisible = true;
            this.kkMshkakiBtn.IconRightZoom = 0D;
            this.kkMshkakiBtn.IconVisible = true;
            this.kkMshkakiBtn.IconZoom = 90D;
            this.kkMshkakiBtn.IsTab = false;
            this.kkMshkakiBtn.Location = new System.Drawing.Point(42, 343);
            this.kkMshkakiBtn.Name = "kkMshkakiBtn";
            this.kkMshkakiBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.kkMshkakiBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(49)))), ((int)(((byte)(199)))));
            this.kkMshkakiBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.kkMshkakiBtn.selected = false;
            this.kkMshkakiBtn.Size = new System.Drawing.Size(351, 41);
            this.kkMshkakiBtn.TabIndex = 16;
            this.kkMshkakiBtn.Text = "MSHKAKI KUKU";
            this.kkMshkakiBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.kkMshkakiBtn.Textcolor = System.Drawing.Color.White;
            this.kkMshkakiBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // nyamaBtn
            // 
            this.nyamaBtn.Activecolor = System.Drawing.Color.DarkGreen;
            this.nyamaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.nyamaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nyamaBtn.BorderRadius = 5;
            this.nyamaBtn.ButtonText = "NYAMA CHOMA";
            this.nyamaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.nyamaBtn, BunifuAnimatorNS.DecorationType.None);
            this.nyamaBtn.DisabledColor = System.Drawing.Color.Gray;
            this.nyamaBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.nyamaBtn.Iconimage = null;
            this.nyamaBtn.Iconimage_right = null;
            this.nyamaBtn.Iconimage_right_Selected = null;
            this.nyamaBtn.Iconimage_Selected = null;
            this.nyamaBtn.IconMarginLeft = 0;
            this.nyamaBtn.IconMarginRight = 0;
            this.nyamaBtn.IconRightVisible = true;
            this.nyamaBtn.IconRightZoom = 0D;
            this.nyamaBtn.IconVisible = true;
            this.nyamaBtn.IconZoom = 90D;
            this.nyamaBtn.IsTab = false;
            this.nyamaBtn.Location = new System.Drawing.Point(42, 108);
            this.nyamaBtn.Name = "nyamaBtn";
            this.nyamaBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.nyamaBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(49)))), ((int)(((byte)(199)))));
            this.nyamaBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.nyamaBtn.selected = false;
            this.nyamaBtn.Size = new System.Drawing.Size(351, 41);
            this.nyamaBtn.TabIndex = 10;
            this.nyamaBtn.Text = "NYAMA CHOMA";
            this.nyamaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nyamaBtn.Textcolor = System.Drawing.Color.White;
            this.nyamaBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // samakiBtn
            // 
            this.samakiBtn.Activecolor = System.Drawing.Color.DarkGreen;
            this.samakiBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.samakiBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.samakiBtn.BorderRadius = 5;
            this.samakiBtn.ButtonText = "SAMAKI";
            this.samakiBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.samakiBtn, BunifuAnimatorNS.DecorationType.None);
            this.samakiBtn.DisabledColor = System.Drawing.Color.Gray;
            this.samakiBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.samakiBtn.Iconimage = null;
            this.samakiBtn.Iconimage_right = null;
            this.samakiBtn.Iconimage_right_Selected = null;
            this.samakiBtn.Iconimage_Selected = null;
            this.samakiBtn.IconMarginLeft = 0;
            this.samakiBtn.IconMarginRight = 0;
            this.samakiBtn.IconRightVisible = true;
            this.samakiBtn.IconRightZoom = 0D;
            this.samakiBtn.IconVisible = true;
            this.samakiBtn.IconZoom = 90D;
            this.samakiBtn.IsTab = false;
            this.samakiBtn.Location = new System.Drawing.Point(42, 155);
            this.samakiBtn.Name = "samakiBtn";
            this.samakiBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.samakiBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(49)))), ((int)(((byte)(199)))));
            this.samakiBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.samakiBtn.selected = false;
            this.samakiBtn.Size = new System.Drawing.Size(351, 41);
            this.samakiBtn.TabIndex = 11;
            this.samakiBtn.Text = "SAMAKI";
            this.samakiBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.samakiBtn.Textcolor = System.Drawing.Color.White;
            this.samakiBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ndiziBtn
            // 
            this.ndiziBtn.Activecolor = System.Drawing.Color.DarkGreen;
            this.ndiziBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ndiziBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ndiziBtn.BorderRadius = 5;
            this.ndiziBtn.ButtonText = "NDIZI CHOMA";
            this.ndiziBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.ndiziBtn, BunifuAnimatorNS.DecorationType.None);
            this.ndiziBtn.DisabledColor = System.Drawing.Color.Gray;
            this.ndiziBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.ndiziBtn.Iconimage = null;
            this.ndiziBtn.Iconimage_right = null;
            this.ndiziBtn.Iconimage_right_Selected = null;
            this.ndiziBtn.Iconimage_Selected = null;
            this.ndiziBtn.IconMarginLeft = 0;
            this.ndiziBtn.IconMarginRight = 0;
            this.ndiziBtn.IconRightVisible = true;
            this.ndiziBtn.IconRightZoom = 0D;
            this.ndiziBtn.IconVisible = true;
            this.ndiziBtn.IconZoom = 90D;
            this.ndiziBtn.IsTab = false;
            this.ndiziBtn.Location = new System.Drawing.Point(42, 296);
            this.ndiziBtn.Name = "ndiziBtn";
            this.ndiziBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ndiziBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(49)))), ((int)(((byte)(199)))));
            this.ndiziBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.ndiziBtn.selected = false;
            this.ndiziBtn.Size = new System.Drawing.Size(351, 41);
            this.ndiziBtn.TabIndex = 14;
            this.ndiziBtn.Text = "NDIZI CHOMA";
            this.ndiziBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ndiziBtn.Textcolor = System.Drawing.Color.White;
            this.ndiziBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // mayaiBtn
            // 
            this.mayaiBtn.Activecolor = System.Drawing.Color.DarkGreen;
            this.mayaiBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.mayaiBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mayaiBtn.BorderRadius = 5;
            this.mayaiBtn.ButtonText = "MAYAI";
            this.mayaiBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.mayaiBtn, BunifuAnimatorNS.DecorationType.None);
            this.mayaiBtn.DisabledColor = System.Drawing.Color.Gray;
            this.mayaiBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.mayaiBtn.Iconimage = null;
            this.mayaiBtn.Iconimage_right = null;
            this.mayaiBtn.Iconimage_right_Selected = null;
            this.mayaiBtn.Iconimage_Selected = null;
            this.mayaiBtn.IconMarginLeft = 0;
            this.mayaiBtn.IconMarginRight = 0;
            this.mayaiBtn.IconRightVisible = true;
            this.mayaiBtn.IconRightZoom = 0D;
            this.mayaiBtn.IconVisible = true;
            this.mayaiBtn.IconZoom = 90D;
            this.mayaiBtn.IsTab = false;
            this.mayaiBtn.Location = new System.Drawing.Point(42, 202);
            this.mayaiBtn.Name = "mayaiBtn";
            this.mayaiBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.mayaiBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(49)))), ((int)(((byte)(199)))));
            this.mayaiBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.mayaiBtn.selected = false;
            this.mayaiBtn.Size = new System.Drawing.Size(351, 41);
            this.mayaiBtn.TabIndex = 12;
            this.mayaiBtn.Text = "MAYAI";
            this.mayaiBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mayaiBtn.Textcolor = System.Drawing.Color.White;
            this.mayaiBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // sousageBtn
            // 
            this.sousageBtn.Activecolor = System.Drawing.Color.DarkGreen;
            this.sousageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.sousageBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sousageBtn.BorderRadius = 5;
            this.sousageBtn.ButtonText = "SOUSAGE";
            this.sousageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.sousageBtn, BunifuAnimatorNS.DecorationType.None);
            this.sousageBtn.DisabledColor = System.Drawing.Color.Gray;
            this.sousageBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.sousageBtn.Iconimage = null;
            this.sousageBtn.Iconimage_right = null;
            this.sousageBtn.Iconimage_right_Selected = null;
            this.sousageBtn.Iconimage_Selected = null;
            this.sousageBtn.IconMarginLeft = 0;
            this.sousageBtn.IconMarginRight = 0;
            this.sousageBtn.IconRightVisible = true;
            this.sousageBtn.IconRightZoom = 0D;
            this.sousageBtn.IconVisible = true;
            this.sousageBtn.IconZoom = 90D;
            this.sousageBtn.IsTab = false;
            this.sousageBtn.Location = new System.Drawing.Point(42, 249);
            this.sousageBtn.Name = "sousageBtn";
            this.sousageBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.sousageBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(49)))), ((int)(((byte)(199)))));
            this.sousageBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.sousageBtn.selected = false;
            this.sousageBtn.Size = new System.Drawing.Size(351, 41);
            this.sousageBtn.TabIndex = 13;
            this.sousageBtn.Text = "SOUSAGE";
            this.sousageBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sousageBtn.Textcolor = System.Drawing.Color.White;
            this.sousageBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.animator.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(-36, -47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 34);
            this.label2.TabIndex = 25;
            this.label2.Text = "CURRENT SELLS";
            // 
            // othersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.juicePanel);
            this.Controls.Add(this.label2);
            this.animator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "othersTab";
            this.Size = new System.Drawing.Size(436, 551);
            this.juicePanel.ResumeLayout(false);
            this.juicePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BunifuAnimatorNS.BunifuTransition animator;
        private System.Windows.Forms.Panel juicePanel;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton ngmbMshkakiBtn;
        private Bunifu.Framework.UI.BunifuFlatButton kukuBtn;
        private Bunifu.Framework.UI.BunifuFlatButton kkMshkakiBtn;
        private Bunifu.Framework.UI.BunifuFlatButton nyamaBtn;
        private Bunifu.Framework.UI.BunifuFlatButton samakiBtn;
        private Bunifu.Framework.UI.BunifuFlatButton ndiziBtn;
        private Bunifu.Framework.UI.BunifuFlatButton mayaiBtn;
        private Bunifu.Framework.UI.BunifuFlatButton sousageBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}
