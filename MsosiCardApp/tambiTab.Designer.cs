namespace MsosiCardApp
{
    partial class tambiTab
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
            BunifuAnimatorNS.Animation animation10 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tambiTab));
            this.animator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.juicePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.maharageBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ngmbMshkakiBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.kukuBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.kkMshkakiBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.nyamaBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dagaaBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.samakiBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.utumboBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.mainiBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.njegereBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.juicePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // animator
            // 
            this.animator.AnimationType = BunifuAnimatorNS.AnimationType.Rotate;
            this.animator.Cursor = null;
            animation10.AnimateOnlyDifferences = true;
            animation10.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.BlindCoeff")));
            animation10.LeafCoeff = 0F;
            animation10.MaxTime = 1F;
            animation10.MinTime = 0F;
            animation10.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.MosaicCoeff")));
            animation10.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation10.MosaicShift")));
            animation10.MosaicSize = 0;
            animation10.Padding = new System.Windows.Forms.Padding(50);
            animation10.RotateCoeff = 1F;
            animation10.RotateLimit = 0F;
            animation10.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.ScaleCoeff")));
            animation10.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.SlideCoeff")));
            animation10.TimeCoeff = 0F;
            animation10.TransparencyCoeff = 1F;
            this.animator.DefaultAnimation = animation10;
            // 
            // juicePanel
            // 
            this.juicePanel.AutoScroll = true;
            this.juicePanel.BackColor = System.Drawing.Color.Transparent;
            this.juicePanel.Controls.Add(this.label1);
            this.juicePanel.Controls.Add(this.maharageBtn);
            this.juicePanel.Controls.Add(this.ngmbMshkakiBtn);
            this.juicePanel.Controls.Add(this.kukuBtn);
            this.juicePanel.Controls.Add(this.kkMshkakiBtn);
            this.juicePanel.Controls.Add(this.nyamaBtn);
            this.juicePanel.Controls.Add(this.dagaaBtn);
            this.juicePanel.Controls.Add(this.samakiBtn);
            this.juicePanel.Controls.Add(this.utumboBtn);
            this.juicePanel.Controls.Add(this.mainiBtn);
            this.juicePanel.Controls.Add(this.njegereBtn);
            this.animator.SetDecoration(this.juicePanel, BunifuAnimatorNS.DecorationType.None);
            this.juicePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.juicePanel.Location = new System.Drawing.Point(0, 0);
            this.juicePanel.Name = "juicePanel";
            this.juicePanel.Size = new System.Drawing.Size(436, 551);
            this.juicePanel.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.animator.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(175, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 34);
            this.label1.TabIndex = 19;
            this.label1.Text = "TAMBI";
            // 
            // maharageBtn
            // 
            this.maharageBtn.Activecolor = System.Drawing.Color.DarkGreen;
            this.maharageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.maharageBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maharageBtn.BorderRadius = 5;
            this.maharageBtn.ButtonText = "MAHARAGWE";
            this.maharageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.maharageBtn, BunifuAnimatorNS.DecorationType.None);
            this.maharageBtn.DisabledColor = System.Drawing.Color.Gray;
            this.maharageBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.maharageBtn.Iconimage = null;
            this.maharageBtn.Iconimage_right = null;
            this.maharageBtn.Iconimage_right_Selected = null;
            this.maharageBtn.Iconimage_Selected = null;
            this.maharageBtn.IconMarginLeft = 0;
            this.maharageBtn.IconMarginRight = 0;
            this.maharageBtn.IconRightVisible = true;
            this.maharageBtn.IconRightZoom = 0D;
            this.maharageBtn.IconVisible = true;
            this.maharageBtn.IconZoom = 90D;
            this.maharageBtn.IsTab = false;
            this.maharageBtn.Location = new System.Drawing.Point(45, 400);
            this.maharageBtn.Name = "maharageBtn";
            this.maharageBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.maharageBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(49)))), ((int)(((byte)(199)))));
            this.maharageBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.maharageBtn.selected = false;
            this.maharageBtn.Size = new System.Drawing.Size(351, 41);
            this.maharageBtn.TabIndex = 18;
            this.maharageBtn.Text = "MAHARAGWE";
            this.maharageBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.maharageBtn.Textcolor = System.Drawing.Color.White;
            this.maharageBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maharageBtn.Click += new System.EventHandler(this.maharageBtn_Click);
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
            this.ngmbMshkakiBtn.Location = new System.Drawing.Point(45, 494);
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
            this.kukuBtn.Location = new System.Drawing.Point(45, 71);
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
            this.kkMshkakiBtn.Location = new System.Drawing.Point(45, 447);
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
            this.nyamaBtn.Location = new System.Drawing.Point(45, 118);
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
            // dagaaBtn
            // 
            this.dagaaBtn.Activecolor = System.Drawing.Color.DarkGreen;
            this.dagaaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dagaaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dagaaBtn.BorderRadius = 5;
            this.dagaaBtn.ButtonText = "DAGAA";
            this.dagaaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.dagaaBtn, BunifuAnimatorNS.DecorationType.None);
            this.dagaaBtn.DisabledColor = System.Drawing.Color.Gray;
            this.dagaaBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.dagaaBtn.Iconimage = null;
            this.dagaaBtn.Iconimage_right = null;
            this.dagaaBtn.Iconimage_right_Selected = null;
            this.dagaaBtn.Iconimage_Selected = null;
            this.dagaaBtn.IconMarginLeft = 0;
            this.dagaaBtn.IconMarginRight = 0;
            this.dagaaBtn.IconRightVisible = true;
            this.dagaaBtn.IconRightZoom = 0D;
            this.dagaaBtn.IconVisible = true;
            this.dagaaBtn.IconZoom = 90D;
            this.dagaaBtn.IsTab = false;
            this.dagaaBtn.Location = new System.Drawing.Point(45, 353);
            this.dagaaBtn.Name = "dagaaBtn";
            this.dagaaBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dagaaBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(49)))), ((int)(((byte)(199)))));
            this.dagaaBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.dagaaBtn.selected = false;
            this.dagaaBtn.Size = new System.Drawing.Size(351, 41);
            this.dagaaBtn.TabIndex = 15;
            this.dagaaBtn.Text = "DAGAA";
            this.dagaaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dagaaBtn.Textcolor = System.Drawing.Color.White;
            this.dagaaBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dagaaBtn.Click += new System.EventHandler(this.dagaaBtn_Click);
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
            this.samakiBtn.Location = new System.Drawing.Point(45, 165);
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
            // utumboBtn
            // 
            this.utumboBtn.Activecolor = System.Drawing.Color.DarkGreen;
            this.utumboBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.utumboBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.utumboBtn.BorderRadius = 5;
            this.utumboBtn.ButtonText = "UTUMBO";
            this.utumboBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.utumboBtn, BunifuAnimatorNS.DecorationType.None);
            this.utumboBtn.DisabledColor = System.Drawing.Color.Gray;
            this.utumboBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.utumboBtn.Iconimage = null;
            this.utumboBtn.Iconimage_right = null;
            this.utumboBtn.Iconimage_right_Selected = null;
            this.utumboBtn.Iconimage_Selected = null;
            this.utumboBtn.IconMarginLeft = 0;
            this.utumboBtn.IconMarginRight = 0;
            this.utumboBtn.IconRightVisible = true;
            this.utumboBtn.IconRightZoom = 0D;
            this.utumboBtn.IconVisible = true;
            this.utumboBtn.IconZoom = 90D;
            this.utumboBtn.IsTab = false;
            this.utumboBtn.Location = new System.Drawing.Point(45, 306);
            this.utumboBtn.Name = "utumboBtn";
            this.utumboBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.utumboBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(49)))), ((int)(((byte)(199)))));
            this.utumboBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.utumboBtn.selected = false;
            this.utumboBtn.Size = new System.Drawing.Size(351, 41);
            this.utumboBtn.TabIndex = 14;
            this.utumboBtn.Text = "UTUMBO";
            this.utumboBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.utumboBtn.Textcolor = System.Drawing.Color.White;
            this.utumboBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utumboBtn.Click += new System.EventHandler(this.utumboBtn_Click);
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
            this.mainiBtn.Location = new System.Drawing.Point(45, 212);
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
            // njegereBtn
            // 
            this.njegereBtn.Activecolor = System.Drawing.Color.DarkGreen;
            this.njegereBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.njegereBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.njegereBtn.BorderRadius = 5;
            this.njegereBtn.ButtonText = "NJEGERE";
            this.njegereBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.njegereBtn, BunifuAnimatorNS.DecorationType.None);
            this.njegereBtn.DisabledColor = System.Drawing.Color.Gray;
            this.njegereBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.njegereBtn.Iconimage = null;
            this.njegereBtn.Iconimage_right = null;
            this.njegereBtn.Iconimage_right_Selected = null;
            this.njegereBtn.Iconimage_Selected = null;
            this.njegereBtn.IconMarginLeft = 0;
            this.njegereBtn.IconMarginRight = 0;
            this.njegereBtn.IconRightVisible = true;
            this.njegereBtn.IconRightZoom = 0D;
            this.njegereBtn.IconVisible = true;
            this.njegereBtn.IconZoom = 90D;
            this.njegereBtn.IsTab = false;
            this.njegereBtn.Location = new System.Drawing.Point(45, 259);
            this.njegereBtn.Name = "njegereBtn";
            this.njegereBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.njegereBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(49)))), ((int)(((byte)(199)))));
            this.njegereBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.njegereBtn.selected = false;
            this.njegereBtn.Size = new System.Drawing.Size(351, 41);
            this.njegereBtn.TabIndex = 13;
            this.njegereBtn.Text = "NJEGERE";
            this.njegereBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.njegereBtn.Textcolor = System.Drawing.Color.White;
            this.njegereBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.njegereBtn.Click += new System.EventHandler(this.njegereBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.animator.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(-36, -5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 34);
            this.label2.TabIndex = 31;
            this.label2.Text = "CURRENT SELLS";
            // 
            // tambiTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.juicePanel);
            this.Controls.Add(this.label2);
            this.animator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "tambiTab";
            this.Size = new System.Drawing.Size(436, 551);
            this.juicePanel.ResumeLayout(false);
            this.juicePanel.PerformLayout();
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
        private Bunifu.Framework.UI.BunifuFlatButton dagaaBtn;
        private Bunifu.Framework.UI.BunifuFlatButton samakiBtn;
        private Bunifu.Framework.UI.BunifuFlatButton utumboBtn;
        private Bunifu.Framework.UI.BunifuFlatButton mainiBtn;
        private Bunifu.Framework.UI.BunifuFlatButton njegereBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuFlatButton maharageBtn;
        private System.Windows.Forms.Label label1;
    }
}
