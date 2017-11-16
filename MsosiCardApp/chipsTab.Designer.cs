namespace MsosiCardApp
{
    partial class chipsTab
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
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chipsTab));
            this.animator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.juicePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ngmbMshkakiBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.kukuBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.kkMshkakiBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.nyamaBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.samakiBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.mainiBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.kavuBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.mayaiBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.juicePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // animator
            // 
            this.animator.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.animator.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.animator.DefaultAnimation = animation4;
            this.animator.Interval = 5;
            // 
            // juicePanel
            // 
            this.juicePanel.AutoScroll = true;
            this.juicePanel.BackColor = System.Drawing.Color.Transparent;
            this.juicePanel.Controls.Add(this.mayaiBtn);
            this.juicePanel.Controls.Add(this.kavuBtn);
            this.juicePanel.Controls.Add(this.panel1);
            this.juicePanel.Controls.Add(this.label1);
            this.animator.SetDecoration(this.juicePanel, BunifuAnimatorNS.DecorationType.None);
            this.juicePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.juicePanel.Location = new System.Drawing.Point(0, 0);
            this.juicePanel.Name = "juicePanel";
            this.juicePanel.Size = new System.Drawing.Size(436, 551);
            this.juicePanel.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.animator.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(183, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 34);
            this.label1.TabIndex = 18;
            this.label1.Text = "CHIPS";
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
            this.ngmbMshkakiBtn.Location = new System.Drawing.Point(45, 263);
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
            this.kukuBtn.Location = new System.Drawing.Point(45, 28);
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
            this.kkMshkakiBtn.Location = new System.Drawing.Point(45, 216);
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
            this.nyamaBtn.ButtonText = "NYAMA";
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
            this.nyamaBtn.Location = new System.Drawing.Point(45, 75);
            this.nyamaBtn.Name = "nyamaBtn";
            this.nyamaBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.nyamaBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(49)))), ((int)(((byte)(199)))));
            this.nyamaBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.nyamaBtn.selected = false;
            this.nyamaBtn.Size = new System.Drawing.Size(351, 41);
            this.nyamaBtn.TabIndex = 10;
            this.nyamaBtn.Text = "NYAMA";
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
            this.samakiBtn.Location = new System.Drawing.Point(45, 122);
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
            // mainiBtn
            // 
            this.mainiBtn.Activecolor = System.Drawing.Color.DarkGreen;
            this.mainiBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.mainiBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainiBtn.BorderRadius = 5;
            this.mainiBtn.ButtonText = "MAINI";
            this.mainiBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.mainiBtn, BunifuAnimatorNS.DecorationType.None);
            this.mainiBtn.DisabledColor = System.Drawing.Color.Gray;
            this.mainiBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.mainiBtn.Iconimage = null;
            this.mainiBtn.Iconimage_right = null;
            this.mainiBtn.Iconimage_right_Selected = null;
            this.mainiBtn.Iconimage_Selected = null;
            this.mainiBtn.IconMarginLeft = 0;
            this.mainiBtn.IconMarginRight = 0;
            this.mainiBtn.IconRightVisible = true;
            this.mainiBtn.IconRightZoom = 0D;
            this.mainiBtn.IconVisible = true;
            this.mainiBtn.IconZoom = 90D;
            this.mainiBtn.IsTab = false;
            this.mainiBtn.Location = new System.Drawing.Point(45, 169);
            this.mainiBtn.Name = "mainiBtn";
            this.mainiBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.mainiBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(49)))), ((int)(((byte)(199)))));
            this.mainiBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.mainiBtn.selected = false;
            this.mainiBtn.Size = new System.Drawing.Size(351, 41);
            this.mainiBtn.TabIndex = 12;
            this.mainiBtn.Text = "MAINI";
            this.mainiBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainiBtn.Textcolor = System.Drawing.Color.White;
            this.mainiBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainiBtn.Click += new System.EventHandler(this.mainiBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.animator.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(-36, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 34);
            this.label2.TabIndex = 33;
            this.label2.Text = "CURRENT SELLS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.kukuBtn);
            this.panel1.Controls.Add(this.mainiBtn);
            this.panel1.Controls.Add(this.ngmbMshkakiBtn);
            this.panel1.Controls.Add(this.samakiBtn);
            this.panel1.Controls.Add(this.nyamaBtn);
            this.panel1.Controls.Add(this.kkMshkakiBtn);
            this.animator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(3, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 417);
            this.panel1.TabIndex = 19;
            this.panel1.Visible = false;
            // 
            // kavuBtn
            // 
            this.kavuBtn.Activecolor = System.Drawing.Color.DarkGreen;
            this.kavuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.kavuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kavuBtn.BorderRadius = 5;
            this.kavuBtn.ButtonText = "KAVU";
            this.kavuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.kavuBtn, BunifuAnimatorNS.DecorationType.None);
            this.kavuBtn.DisabledColor = System.Drawing.Color.Gray;
            this.kavuBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.kavuBtn.Iconimage = null;
            this.kavuBtn.Iconimage_right = null;
            this.kavuBtn.Iconimage_right_Selected = null;
            this.kavuBtn.Iconimage_Selected = null;
            this.kavuBtn.IconMarginLeft = 0;
            this.kavuBtn.IconMarginRight = 0;
            this.kavuBtn.IconRightVisible = true;
            this.kavuBtn.IconRightZoom = 0D;
            this.kavuBtn.IconVisible = true;
            this.kavuBtn.IconZoom = 90D;
            this.kavuBtn.IsTab = false;
            this.kavuBtn.Location = new System.Drawing.Point(77, 74);
            this.kavuBtn.Name = "kavuBtn";
            this.kavuBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.kavuBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(49)))), ((int)(((byte)(199)))));
            this.kavuBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.kavuBtn.selected = false;
            this.kavuBtn.Size = new System.Drawing.Size(142, 41);
            this.kavuBtn.TabIndex = 18;
            this.kavuBtn.Text = "KAVU";
            this.kavuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.kavuBtn.Textcolor = System.Drawing.Color.White;
            this.kavuBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kavuBtn.Click += new System.EventHandler(this.kavuBtn_Click);
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
            this.mayaiBtn.Location = new System.Drawing.Point(240, 74);
            this.mayaiBtn.Name = "mayaiBtn";
            this.mayaiBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.mayaiBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(49)))), ((int)(((byte)(199)))));
            this.mayaiBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.mayaiBtn.selected = false;
            this.mayaiBtn.Size = new System.Drawing.Size(127, 41);
            this.mayaiBtn.TabIndex = 20;
            this.mayaiBtn.Text = "MAYAI";
            this.mayaiBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mayaiBtn.Textcolor = System.Drawing.Color.White;
            this.mayaiBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mayaiBtn.Click += new System.EventHandler(this.mayaiBtn_Click);
            // 
            // chipsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.juicePanel);
            this.Controls.Add(this.label2);
            this.animator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "chipsTab";
            this.Size = new System.Drawing.Size(436, 551);
            this.juicePanel.ResumeLayout(false);
            this.juicePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BunifuAnimatorNS.BunifuTransition animator;
        private System.Windows.Forms.Panel juicePanel;
        private Bunifu.Framework.UI.BunifuFlatButton ngmbMshkakiBtn;
        private Bunifu.Framework.UI.BunifuFlatButton kukuBtn;
        private Bunifu.Framework.UI.BunifuFlatButton kkMshkakiBtn;
        private Bunifu.Framework.UI.BunifuFlatButton nyamaBtn;
        private Bunifu.Framework.UI.BunifuFlatButton samakiBtn;
        private Bunifu.Framework.UI.BunifuFlatButton mainiBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton mayaiBtn;
        private Bunifu.Framework.UI.BunifuFlatButton kavuBtn;
        private System.Windows.Forms.Panel panel1;
    }
}
