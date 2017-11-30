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
            this.kukuOutBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.nyamaOutBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.samakiOutBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.mayaiOutBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.kkMshkakiOutBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.ndiziOutBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.sousageOutBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.ngmbMshkakiOutBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.ngmbMshkakiInBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.kkMshkakiInBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.ndiziInBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.sousageInBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.mayaiInBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.samakiInBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.nyamaInBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.kukuInBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editBtn = new Bunifu.Framework.UI.BunifuTileButton();
            this.doneBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.juicePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kukuOutBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyamaOutBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.samakiOutBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mayaiOutBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kkMshkakiOutBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndiziOutBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sousageOutBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngmbMshkakiOutBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngmbMshkakiInBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kkMshkakiInBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndiziInBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sousageInBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mayaiInBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.samakiInBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyamaInBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kukuInBtn)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.juicePanel.Controls.Add(this.doneBtn);
            this.juicePanel.Controls.Add(this.editBtn);
            this.juicePanel.Controls.Add(this.panel1);
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
            this.label1.Location = new System.Drawing.Point(156, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 34);
            this.label1.TabIndex = 26;
            this.label1.Text = "OTHERS";
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
            this.ngmbMshkakiBtn.Click += new System.EventHandler(this.ngmbMshkakiBtn_Click);
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
            this.kukuBtn.Click += new System.EventHandler(this.kukuBtn_Click);
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
            this.kkMshkakiBtn.Click += new System.EventHandler(this.kkMshkakiBtn_Click);
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
            this.nyamaBtn.Click += new System.EventHandler(this.nyamaBtn_Click);
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
            this.samakiBtn.Click += new System.EventHandler(this.samakiBtn_Click);
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
            this.ndiziBtn.Click += new System.EventHandler(this.ndiziBtn_Click);
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
            this.mayaiBtn.Click += new System.EventHandler(this.mayaiBtn_Click);
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
            this.sousageBtn.Click += new System.EventHandler(this.sousageBtn_Click);
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
            // kukuOutBtn
            // 
            this.kukuOutBtn.BackColor = System.Drawing.Color.Transparent;
            this.kukuOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.kukuOutBtn, BunifuAnimatorNS.DecorationType.None);
            this.kukuOutBtn.Image = ((System.Drawing.Image)(resources.GetObject("kukuOutBtn.Image")));
            this.kukuOutBtn.ImageActive = null;
            this.kukuOutBtn.Location = new System.Drawing.Point(3, 24);
            this.kukuOutBtn.Name = "kukuOutBtn";
            this.kukuOutBtn.Size = new System.Drawing.Size(23, 41);
            this.kukuOutBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kukuOutBtn.TabIndex = 27;
            this.kukuOutBtn.TabStop = false;
            this.kukuOutBtn.Visible = false;
            this.kukuOutBtn.Zoom = 10;
            this.kukuOutBtn.Click += new System.EventHandler(this.kukuOutBtn_Click);
            // 
            // nyamaOutBtn
            // 
            this.nyamaOutBtn.BackColor = System.Drawing.Color.Transparent;
            this.nyamaOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.nyamaOutBtn, BunifuAnimatorNS.DecorationType.None);
            this.nyamaOutBtn.Image = ((System.Drawing.Image)(resources.GetObject("nyamaOutBtn.Image")));
            this.nyamaOutBtn.ImageActive = null;
            this.nyamaOutBtn.Location = new System.Drawing.Point(3, 71);
            this.nyamaOutBtn.Name = "nyamaOutBtn";
            this.nyamaOutBtn.Size = new System.Drawing.Size(23, 41);
            this.nyamaOutBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nyamaOutBtn.TabIndex = 28;
            this.nyamaOutBtn.TabStop = false;
            this.nyamaOutBtn.Visible = false;
            this.nyamaOutBtn.Zoom = 10;
            this.nyamaOutBtn.Click += new System.EventHandler(this.nyamaOutBtn_Click);
            // 
            // samakiOutBtn
            // 
            this.samakiOutBtn.BackColor = System.Drawing.Color.Transparent;
            this.samakiOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.samakiOutBtn, BunifuAnimatorNS.DecorationType.None);
            this.samakiOutBtn.Image = ((System.Drawing.Image)(resources.GetObject("samakiOutBtn.Image")));
            this.samakiOutBtn.ImageActive = null;
            this.samakiOutBtn.Location = new System.Drawing.Point(3, 118);
            this.samakiOutBtn.Name = "samakiOutBtn";
            this.samakiOutBtn.Size = new System.Drawing.Size(23, 41);
            this.samakiOutBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.samakiOutBtn.TabIndex = 29;
            this.samakiOutBtn.TabStop = false;
            this.samakiOutBtn.Visible = false;
            this.samakiOutBtn.Zoom = 10;
            this.samakiOutBtn.Click += new System.EventHandler(this.samakiOutBtn_Click);
            // 
            // mayaiOutBtn
            // 
            this.mayaiOutBtn.BackColor = System.Drawing.Color.Transparent;
            this.mayaiOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.mayaiOutBtn, BunifuAnimatorNS.DecorationType.None);
            this.mayaiOutBtn.Image = ((System.Drawing.Image)(resources.GetObject("mayaiOutBtn.Image")));
            this.mayaiOutBtn.ImageActive = null;
            this.mayaiOutBtn.Location = new System.Drawing.Point(3, 165);
            this.mayaiOutBtn.Name = "mayaiOutBtn";
            this.mayaiOutBtn.Size = new System.Drawing.Size(23, 41);
            this.mayaiOutBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mayaiOutBtn.TabIndex = 30;
            this.mayaiOutBtn.TabStop = false;
            this.mayaiOutBtn.Visible = false;
            this.mayaiOutBtn.Zoom = 10;
            this.mayaiOutBtn.Click += new System.EventHandler(this.mayaiOutBtn_Click);
            // 
            // kkMshkakiOutBtn
            // 
            this.kkMshkakiOutBtn.BackColor = System.Drawing.Color.Transparent;
            this.kkMshkakiOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.kkMshkakiOutBtn, BunifuAnimatorNS.DecorationType.None);
            this.kkMshkakiOutBtn.Image = ((System.Drawing.Image)(resources.GetObject("kkMshkakiOutBtn.Image")));
            this.kkMshkakiOutBtn.ImageActive = null;
            this.kkMshkakiOutBtn.Location = new System.Drawing.Point(3, 306);
            this.kkMshkakiOutBtn.Name = "kkMshkakiOutBtn";
            this.kkMshkakiOutBtn.Size = new System.Drawing.Size(23, 41);
            this.kkMshkakiOutBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kkMshkakiOutBtn.TabIndex = 33;
            this.kkMshkakiOutBtn.TabStop = false;
            this.kkMshkakiOutBtn.Visible = false;
            this.kkMshkakiOutBtn.Zoom = 10;
            this.kkMshkakiOutBtn.Click += new System.EventHandler(this.kkMshkakiOutBtn_Click);
            // 
            // ndiziOutBtn
            // 
            this.ndiziOutBtn.BackColor = System.Drawing.Color.Transparent;
            this.ndiziOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.ndiziOutBtn, BunifuAnimatorNS.DecorationType.None);
            this.ndiziOutBtn.Image = ((System.Drawing.Image)(resources.GetObject("ndiziOutBtn.Image")));
            this.ndiziOutBtn.ImageActive = null;
            this.ndiziOutBtn.Location = new System.Drawing.Point(3, 259);
            this.ndiziOutBtn.Name = "ndiziOutBtn";
            this.ndiziOutBtn.Size = new System.Drawing.Size(23, 41);
            this.ndiziOutBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ndiziOutBtn.TabIndex = 32;
            this.ndiziOutBtn.TabStop = false;
            this.ndiziOutBtn.Visible = false;
            this.ndiziOutBtn.Zoom = 10;
            this.ndiziOutBtn.Click += new System.EventHandler(this.ndiziOutBtn_Click);
            // 
            // sousageOutBtn
            // 
            this.sousageOutBtn.BackColor = System.Drawing.Color.Transparent;
            this.sousageOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.sousageOutBtn, BunifuAnimatorNS.DecorationType.None);
            this.sousageOutBtn.Image = ((System.Drawing.Image)(resources.GetObject("sousageOutBtn.Image")));
            this.sousageOutBtn.ImageActive = null;
            this.sousageOutBtn.Location = new System.Drawing.Point(3, 212);
            this.sousageOutBtn.Name = "sousageOutBtn";
            this.sousageOutBtn.Size = new System.Drawing.Size(23, 41);
            this.sousageOutBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sousageOutBtn.TabIndex = 31;
            this.sousageOutBtn.TabStop = false;
            this.sousageOutBtn.Visible = false;
            this.sousageOutBtn.Zoom = 10;
            this.sousageOutBtn.Click += new System.EventHandler(this.sousageOutBtn_Click);
            // 
            // ngmbMshkakiOutBtn
            // 
            this.ngmbMshkakiOutBtn.BackColor = System.Drawing.Color.Transparent;
            this.ngmbMshkakiOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.ngmbMshkakiOutBtn, BunifuAnimatorNS.DecorationType.None);
            this.ngmbMshkakiOutBtn.Image = ((System.Drawing.Image)(resources.GetObject("ngmbMshkakiOutBtn.Image")));
            this.ngmbMshkakiOutBtn.ImageActive = null;
            this.ngmbMshkakiOutBtn.Location = new System.Drawing.Point(3, 353);
            this.ngmbMshkakiOutBtn.Name = "ngmbMshkakiOutBtn";
            this.ngmbMshkakiOutBtn.Size = new System.Drawing.Size(23, 41);
            this.ngmbMshkakiOutBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ngmbMshkakiOutBtn.TabIndex = 34;
            this.ngmbMshkakiOutBtn.TabStop = false;
            this.ngmbMshkakiOutBtn.Visible = false;
            this.ngmbMshkakiOutBtn.Zoom = 10;
            this.ngmbMshkakiOutBtn.Click += new System.EventHandler(this.ngmbMshkakiOutBtn_Click);
            // 
            // ngmbMshkakiInBtn
            // 
            this.ngmbMshkakiInBtn.BackColor = System.Drawing.Color.Transparent;
            this.ngmbMshkakiInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.ngmbMshkakiInBtn, BunifuAnimatorNS.DecorationType.None);
            this.ngmbMshkakiInBtn.Image = ((System.Drawing.Image)(resources.GetObject("ngmbMshkakiInBtn.Image")));
            this.ngmbMshkakiInBtn.ImageActive = null;
            this.ngmbMshkakiInBtn.Location = new System.Drawing.Point(3, 353);
            this.ngmbMshkakiInBtn.Name = "ngmbMshkakiInBtn";
            this.ngmbMshkakiInBtn.Size = new System.Drawing.Size(23, 41);
            this.ngmbMshkakiInBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ngmbMshkakiInBtn.TabIndex = 42;
            this.ngmbMshkakiInBtn.TabStop = false;
            this.ngmbMshkakiInBtn.Zoom = 10;
            this.ngmbMshkakiInBtn.Click += new System.EventHandler(this.ngmbMshkakiInBtn_Click);
            // 
            // kkMshkakiInBtn
            // 
            this.kkMshkakiInBtn.BackColor = System.Drawing.Color.Transparent;
            this.kkMshkakiInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.kkMshkakiInBtn, BunifuAnimatorNS.DecorationType.None);
            this.kkMshkakiInBtn.Image = ((System.Drawing.Image)(resources.GetObject("kkMshkakiInBtn.Image")));
            this.kkMshkakiInBtn.ImageActive = null;
            this.kkMshkakiInBtn.Location = new System.Drawing.Point(3, 306);
            this.kkMshkakiInBtn.Name = "kkMshkakiInBtn";
            this.kkMshkakiInBtn.Size = new System.Drawing.Size(23, 41);
            this.kkMshkakiInBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kkMshkakiInBtn.TabIndex = 41;
            this.kkMshkakiInBtn.TabStop = false;
            this.kkMshkakiInBtn.Zoom = 10;
            this.kkMshkakiInBtn.Click += new System.EventHandler(this.kkMshkakiInBtn_Click);
            // 
            // ndiziInBtn
            // 
            this.ndiziInBtn.BackColor = System.Drawing.Color.Transparent;
            this.ndiziInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.ndiziInBtn, BunifuAnimatorNS.DecorationType.None);
            this.ndiziInBtn.Image = ((System.Drawing.Image)(resources.GetObject("ndiziInBtn.Image")));
            this.ndiziInBtn.ImageActive = null;
            this.ndiziInBtn.Location = new System.Drawing.Point(3, 259);
            this.ndiziInBtn.Name = "ndiziInBtn";
            this.ndiziInBtn.Size = new System.Drawing.Size(23, 41);
            this.ndiziInBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ndiziInBtn.TabIndex = 40;
            this.ndiziInBtn.TabStop = false;
            this.ndiziInBtn.Zoom = 10;
            this.ndiziInBtn.Click += new System.EventHandler(this.ndiziInBtn_Click);
            // 
            // sousageInBtn
            // 
            this.sousageInBtn.BackColor = System.Drawing.Color.Transparent;
            this.sousageInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.sousageInBtn, BunifuAnimatorNS.DecorationType.None);
            this.sousageInBtn.Image = ((System.Drawing.Image)(resources.GetObject("sousageInBtn.Image")));
            this.sousageInBtn.ImageActive = null;
            this.sousageInBtn.Location = new System.Drawing.Point(3, 212);
            this.sousageInBtn.Name = "sousageInBtn";
            this.sousageInBtn.Size = new System.Drawing.Size(23, 41);
            this.sousageInBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sousageInBtn.TabIndex = 39;
            this.sousageInBtn.TabStop = false;
            this.sousageInBtn.Zoom = 10;
            this.sousageInBtn.Click += new System.EventHandler(this.sousageInBtn_Click);
            // 
            // mayaiInBtn
            // 
            this.mayaiInBtn.BackColor = System.Drawing.Color.Transparent;
            this.mayaiInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.mayaiInBtn, BunifuAnimatorNS.DecorationType.None);
            this.mayaiInBtn.Image = ((System.Drawing.Image)(resources.GetObject("mayaiInBtn.Image")));
            this.mayaiInBtn.ImageActive = null;
            this.mayaiInBtn.Location = new System.Drawing.Point(3, 165);
            this.mayaiInBtn.Name = "mayaiInBtn";
            this.mayaiInBtn.Size = new System.Drawing.Size(23, 41);
            this.mayaiInBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mayaiInBtn.TabIndex = 38;
            this.mayaiInBtn.TabStop = false;
            this.mayaiInBtn.Zoom = 10;
            this.mayaiInBtn.Click += new System.EventHandler(this.mayaiInBtn_Click);
            // 
            // samakiInBtn
            // 
            this.samakiInBtn.BackColor = System.Drawing.Color.Transparent;
            this.samakiInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.samakiInBtn, BunifuAnimatorNS.DecorationType.None);
            this.samakiInBtn.Image = ((System.Drawing.Image)(resources.GetObject("samakiInBtn.Image")));
            this.samakiInBtn.ImageActive = null;
            this.samakiInBtn.Location = new System.Drawing.Point(3, 118);
            this.samakiInBtn.Name = "samakiInBtn";
            this.samakiInBtn.Size = new System.Drawing.Size(23, 41);
            this.samakiInBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.samakiInBtn.TabIndex = 37;
            this.samakiInBtn.TabStop = false;
            this.samakiInBtn.Zoom = 10;
            this.samakiInBtn.Click += new System.EventHandler(this.samakiInBtn_Click);
            // 
            // nyamaInBtn
            // 
            this.nyamaInBtn.BackColor = System.Drawing.Color.Transparent;
            this.nyamaInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.nyamaInBtn, BunifuAnimatorNS.DecorationType.None);
            this.nyamaInBtn.Image = ((System.Drawing.Image)(resources.GetObject("nyamaInBtn.Image")));
            this.nyamaInBtn.ImageActive = null;
            this.nyamaInBtn.Location = new System.Drawing.Point(3, 71);
            this.nyamaInBtn.Name = "nyamaInBtn";
            this.nyamaInBtn.Size = new System.Drawing.Size(23, 41);
            this.nyamaInBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nyamaInBtn.TabIndex = 36;
            this.nyamaInBtn.TabStop = false;
            this.nyamaInBtn.Zoom = 10;
            this.nyamaInBtn.Click += new System.EventHandler(this.nyamaInBtn_Click);
            // 
            // kukuInBtn
            // 
            this.kukuInBtn.BackColor = System.Drawing.Color.Transparent;
            this.kukuInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.kukuInBtn, BunifuAnimatorNS.DecorationType.None);
            this.kukuInBtn.Image = ((System.Drawing.Image)(resources.GetObject("kukuInBtn.Image")));
            this.kukuInBtn.ImageActive = null;
            this.kukuInBtn.Location = new System.Drawing.Point(3, 24);
            this.kukuInBtn.Name = "kukuInBtn";
            this.kukuInBtn.Size = new System.Drawing.Size(23, 41);
            this.kukuInBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kukuInBtn.TabIndex = 35;
            this.kukuInBtn.TabStop = false;
            this.kukuInBtn.Zoom = 10;
            this.kukuInBtn.Click += new System.EventHandler(this.kukuInBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.kukuInBtn);
            this.panel1.Controls.Add(this.ngmbMshkakiInBtn);
            this.panel1.Controls.Add(this.kukuOutBtn);
            this.panel1.Controls.Add(this.kkMshkakiInBtn);
            this.panel1.Controls.Add(this.nyamaOutBtn);
            this.panel1.Controls.Add(this.ndiziInBtn);
            this.panel1.Controls.Add(this.samakiOutBtn);
            this.panel1.Controls.Add(this.sousageInBtn);
            this.panel1.Controls.Add(this.mayaiOutBtn);
            this.panel1.Controls.Add(this.mayaiInBtn);
            this.panel1.Controls.Add(this.sousageOutBtn);
            this.panel1.Controls.Add(this.samakiInBtn);
            this.panel1.Controls.Add(this.ndiziOutBtn);
            this.panel1.Controls.Add(this.nyamaInBtn);
            this.panel1.Controls.Add(this.kkMshkakiOutBtn);
            this.panel1.Controls.Add(this.ngmbMshkakiOutBtn);
            this.animator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(3, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(37, 414);
            this.panel1.TabIndex = 43;
            this.panel1.Visible = false;
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Transparent;
            this.editBtn.color = System.Drawing.Color.Transparent;
            this.editBtn.colorActive = System.Drawing.Color.DimGray;
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.editBtn, BunifuAnimatorNS.DecorationType.None);
            this.editBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Image = ((System.Drawing.Image)(resources.GetObject("editBtn.Image")));
            this.editBtn.ImagePosition = 1;
            this.editBtn.ImageZoom = 50;
            this.editBtn.LabelPosition = 17;
            this.editBtn.LabelText = "Edit Menu";
            this.editBtn.Location = new System.Drawing.Point(369, 4);
            this.editBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(64, 50);
            this.editBtn.TabIndex = 44;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // doneBtn
            // 
            this.doneBtn.Activecolor = System.Drawing.Color.DarkGreen;
            this.doneBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.doneBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doneBtn.BorderRadius = 5;
            this.doneBtn.ButtonText = "Done";
            this.doneBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.doneBtn, BunifuAnimatorNS.DecorationType.None);
            this.doneBtn.DisabledColor = System.Drawing.Color.Gray;
            this.doneBtn.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.doneBtn.Iconimage = null;
            this.doneBtn.Iconimage_right = null;
            this.doneBtn.Iconimage_right_Selected = null;
            this.doneBtn.Iconimage_Selected = null;
            this.doneBtn.IconMarginLeft = 0;
            this.doneBtn.IconMarginRight = 0;
            this.doneBtn.IconRightVisible = true;
            this.doneBtn.IconRightZoom = 0D;
            this.doneBtn.IconVisible = true;
            this.doneBtn.IconZoom = 90D;
            this.doneBtn.IsTab = false;
            this.doneBtn.Location = new System.Drawing.Point(6, 4);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.doneBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(49)))), ((int)(((byte)(199)))));
            this.doneBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.doneBtn.selected = false;
            this.doneBtn.Size = new System.Drawing.Size(60, 28);
            this.doneBtn.TabIndex = 45;
            this.doneBtn.Text = "Done";
            this.doneBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.doneBtn.Textcolor = System.Drawing.Color.White;
            this.doneBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneBtn.Visible = false;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.kukuOutBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyamaOutBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.samakiOutBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mayaiOutBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kkMshkakiOutBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndiziOutBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sousageOutBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngmbMshkakiOutBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngmbMshkakiInBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kkMshkakiInBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndiziInBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sousageInBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mayaiInBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.samakiInBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyamaInBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kukuInBtn)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private Bunifu.Framework.UI.BunifuImageButton ngmbMshkakiInBtn;
        private Bunifu.Framework.UI.BunifuImageButton kkMshkakiInBtn;
        private Bunifu.Framework.UI.BunifuImageButton ndiziInBtn;
        private Bunifu.Framework.UI.BunifuImageButton sousageInBtn;
        private Bunifu.Framework.UI.BunifuImageButton mayaiInBtn;
        private Bunifu.Framework.UI.BunifuImageButton samakiInBtn;
        private Bunifu.Framework.UI.BunifuImageButton nyamaInBtn;
        private Bunifu.Framework.UI.BunifuImageButton kukuInBtn;
        private Bunifu.Framework.UI.BunifuImageButton ngmbMshkakiOutBtn;
        private Bunifu.Framework.UI.BunifuImageButton kkMshkakiOutBtn;
        private Bunifu.Framework.UI.BunifuImageButton ndiziOutBtn;
        private Bunifu.Framework.UI.BunifuImageButton sousageOutBtn;
        private Bunifu.Framework.UI.BunifuImageButton mayaiOutBtn;
        private Bunifu.Framework.UI.BunifuImageButton samakiOutBtn;
        private Bunifu.Framework.UI.BunifuImageButton nyamaOutBtn;
        private Bunifu.Framework.UI.BunifuImageButton kukuOutBtn;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuTileButton editBtn;
        private Bunifu.Framework.UI.BunifuFlatButton doneBtn;
    }
}
