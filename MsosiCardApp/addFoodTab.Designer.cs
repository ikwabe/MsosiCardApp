namespace MsosiCardApp
{
    partial class addFoodTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addFoodTab));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchMainTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.mainFoodGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.addFoodBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchSubTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.subFoodGrid = new System.Windows.Forms.DataGridView();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.addSubFoodBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.subFoodTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.mainFoodTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.addNewFoodBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainFoodGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subFoodGrid)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.searchMainTxt);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.addFoodBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 330);
            this.panel1.TabIndex = 0;
            // 
            // searchMainTxt
            // 
            this.searchMainTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchMainTxt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.searchMainTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchMainTxt.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMainTxt.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.searchMainTxt.HintForeColor = System.Drawing.Color.Empty;
            this.searchMainTxt.HintText = "";
            this.searchMainTxt.isPassword = false;
            this.searchMainTxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.searchMainTxt.LineIdleColor = System.Drawing.Color.Gray;
            this.searchMainTxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.searchMainTxt.LineThickness = 4;
            this.searchMainTxt.Location = new System.Drawing.Point(5, 38);
            this.searchMainTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.searchMainTxt.Name = "searchMainTxt";
            this.searchMainTxt.Size = new System.Drawing.Size(209, 33);
            this.searchMainTxt.TabIndex = 18;
            this.searchMainTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchMainTxt.OnValueChanged += new System.EventHandler(this.searchMainTxt_OnValueChanged);
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.Controls.Add(this.mainFoodGrid);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 79);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(222, 251);
            this.panel5.TabIndex = 17;
            // 
            // mainFoodGrid
            // 
            this.mainFoodGrid.AllowUserToAddRows = false;
            this.mainFoodGrid.AllowUserToResizeColumns = false;
            this.mainFoodGrid.AllowUserToResizeRows = false;
            this.mainFoodGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.mainFoodGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.mainFoodGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainFoodGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1});
            this.mainFoodGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFoodGrid.Location = new System.Drawing.Point(0, 0);
            this.mainFoodGrid.Name = "mainFoodGrid";
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.mainFoodGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.mainFoodGrid.Size = new System.Drawing.Size(222, 251);
            this.mainFoodGrid.TabIndex = 1;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Check";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn1.Width = 63;
            // 
            // addFoodBtn
            // 
            this.addFoodBtn.Activecolor = System.Drawing.Color.DarkGreen;
            this.addFoodBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.addFoodBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addFoodBtn.BorderRadius = 5;
            this.addFoodBtn.ButtonText = "ADD MAIN FOOD";
            this.addFoodBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addFoodBtn.DisabledColor = System.Drawing.Color.Gray;
            this.addFoodBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.addFoodBtn.Iconimage = null;
            this.addFoodBtn.Iconimage_right = null;
            this.addFoodBtn.Iconimage_right_Selected = null;
            this.addFoodBtn.Iconimage_Selected = null;
            this.addFoodBtn.IconMarginLeft = 0;
            this.addFoodBtn.IconMarginRight = 0;
            this.addFoodBtn.IconRightVisible = true;
            this.addFoodBtn.IconRightZoom = 0D;
            this.addFoodBtn.IconVisible = true;
            this.addFoodBtn.IconZoom = 90D;
            this.addFoodBtn.IsTab = false;
            this.addFoodBtn.Location = new System.Drawing.Point(39, 3);
            this.addFoodBtn.Name = "addFoodBtn";
            this.addFoodBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.addFoodBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(49)))), ((int)(((byte)(199)))));
            this.addFoodBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.addFoodBtn.selected = false;
            this.addFoodBtn.Size = new System.Drawing.Size(151, 27);
            this.addFoodBtn.TabIndex = 15;
            this.addFoodBtn.Text = "ADD MAIN FOOD";
            this.addFoodBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addFoodBtn.Textcolor = System.Drawing.Color.White;
            this.addFoodBtn.TextFont = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.searchSubTxt);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.addSubFoodBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(222, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 330);
            this.panel2.TabIndex = 1;
            // 
            // searchSubTxt
            // 
            this.searchSubTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchSubTxt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.searchSubTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchSubTxt.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchSubTxt.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.searchSubTxt.HintForeColor = System.Drawing.Color.Empty;
            this.searchSubTxt.HintText = "";
            this.searchSubTxt.isPassword = false;
            this.searchSubTxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.searchSubTxt.LineIdleColor = System.Drawing.Color.Gray;
            this.searchSubTxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.searchSubTxt.LineThickness = 4;
            this.searchSubTxt.Location = new System.Drawing.Point(5, 38);
            this.searchSubTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.searchSubTxt.Name = "searchSubTxt";
            this.searchSubTxt.Size = new System.Drawing.Size(221, 33);
            this.searchSubTxt.TabIndex = 19;
            this.searchSubTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchSubTxt.OnValueChanged += new System.EventHandler(this.searchSubTxt_OnValueChanged);
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.subFoodGrid);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 79);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(229, 251);
            this.panel4.TabIndex = 16;
            // 
            // subFoodGrid
            // 
            this.subFoodGrid.AllowUserToAddRows = false;
            this.subFoodGrid.AllowUserToResizeColumns = false;
            this.subFoodGrid.AllowUserToResizeRows = false;
            this.subFoodGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.subFoodGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.subFoodGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subFoodGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check});
            this.subFoodGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subFoodGrid.Location = new System.Drawing.Point(0, 0);
            this.subFoodGrid.Name = "subFoodGrid";
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.subFoodGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.subFoodGrid.Size = new System.Drawing.Size(229, 251);
            this.subFoodGrid.TabIndex = 0;
            // 
            // check
            // 
            this.check.HeaderText = "Check";
            this.check.Name = "check";
            this.check.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.check.Width = 63;
            // 
            // addSubFoodBtn
            // 
            this.addSubFoodBtn.Activecolor = System.Drawing.Color.DarkGreen;
            this.addSubFoodBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.addSubFoodBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addSubFoodBtn.BorderRadius = 5;
            this.addSubFoodBtn.ButtonText = "ADD SUB FOOD";
            this.addSubFoodBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addSubFoodBtn.DisabledColor = System.Drawing.Color.Gray;
            this.addSubFoodBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.addSubFoodBtn.Iconimage = null;
            this.addSubFoodBtn.Iconimage_right = null;
            this.addSubFoodBtn.Iconimage_right_Selected = null;
            this.addSubFoodBtn.Iconimage_Selected = null;
            this.addSubFoodBtn.IconMarginLeft = 0;
            this.addSubFoodBtn.IconMarginRight = 0;
            this.addSubFoodBtn.IconRightVisible = true;
            this.addSubFoodBtn.IconRightZoom = 0D;
            this.addSubFoodBtn.IconVisible = true;
            this.addSubFoodBtn.IconZoom = 90D;
            this.addSubFoodBtn.IsTab = false;
            this.addSubFoodBtn.Location = new System.Drawing.Point(40, 3);
            this.addSubFoodBtn.Name = "addSubFoodBtn";
            this.addSubFoodBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.addSubFoodBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(49)))), ((int)(((byte)(199)))));
            this.addSubFoodBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.addSubFoodBtn.selected = false;
            this.addSubFoodBtn.Size = new System.Drawing.Size(151, 27);
            this.addSubFoodBtn.TabIndex = 15;
            this.addSubFoodBtn.Text = "ADD SUB FOOD";
            this.addSubFoodBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addSubFoodBtn.Textcolor = System.Drawing.Color.White;
            this.addSubFoodBtn.TextFont = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.subFoodTxt);
            this.panel3.Controls.Add(this.mainFoodTxt);
            this.panel3.Controls.Add(this.addNewFoodBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(451, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 330);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(6, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "Enter Sub Food";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(11, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "Enter Main Food";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label2.Location = new System.Drawing.Point(10, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "ADD NEW FOOD";
            // 
            // subFoodTxt
            // 
            this.subFoodTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subFoodTxt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.subFoodTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.subFoodTxt.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subFoodTxt.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.subFoodTxt.HintForeColor = System.Drawing.Color.Empty;
            this.subFoodTxt.HintText = "";
            this.subFoodTxt.isPassword = false;
            this.subFoodTxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.subFoodTxt.LineIdleColor = System.Drawing.Color.Gray;
            this.subFoodTxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.subFoodTxt.LineThickness = 4;
            this.subFoodTxt.Location = new System.Drawing.Point(8, 230);
            this.subFoodTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.subFoodTxt.Name = "subFoodTxt";
            this.subFoodTxt.Size = new System.Drawing.Size(222, 33);
            this.subFoodTxt.TabIndex = 20;
            this.subFoodTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.subFoodTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainFoodTxt_KeyDown);
            this.subFoodTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mainFoodTxt_KeyPress);
            // 
            // mainFoodTxt
            // 
            this.mainFoodTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainFoodTxt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.mainFoodTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mainFoodTxt.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFoodTxt.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.mainFoodTxt.HintForeColor = System.Drawing.Color.Empty;
            this.mainFoodTxt.HintText = "";
            this.mainFoodTxt.isPassword = false;
            this.mainFoodTxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.mainFoodTxt.LineIdleColor = System.Drawing.Color.Gray;
            this.mainFoodTxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.mainFoodTxt.LineThickness = 4;
            this.mainFoodTxt.Location = new System.Drawing.Point(8, 107);
            this.mainFoodTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.mainFoodTxt.Name = "mainFoodTxt";
            this.mainFoodTxt.Size = new System.Drawing.Size(222, 33);
            this.mainFoodTxt.TabIndex = 19;
            this.mainFoodTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mainFoodTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainFoodTxt_KeyDown);
            this.mainFoodTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mainFoodTxt_KeyPress);
            // 
            // addNewFoodBtn
            // 
            this.addNewFoodBtn.Activecolor = System.Drawing.Color.DarkGreen;
            this.addNewFoodBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addNewFoodBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.addNewFoodBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addNewFoodBtn.BorderRadius = 5;
            this.addNewFoodBtn.ButtonText = "ADD NEW FOOD";
            this.addNewFoodBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addNewFoodBtn.DisabledColor = System.Drawing.Color.Gray;
            this.addNewFoodBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.addNewFoodBtn.Iconimage = null;
            this.addNewFoodBtn.Iconimage_right = null;
            this.addNewFoodBtn.Iconimage_right_Selected = null;
            this.addNewFoodBtn.Iconimage_Selected = null;
            this.addNewFoodBtn.IconMarginLeft = 0;
            this.addNewFoodBtn.IconMarginRight = 0;
            this.addNewFoodBtn.IconRightVisible = true;
            this.addNewFoodBtn.IconRightZoom = 0D;
            this.addNewFoodBtn.IconVisible = true;
            this.addNewFoodBtn.IconZoom = 90D;
            this.addNewFoodBtn.IsTab = false;
            this.addNewFoodBtn.Location = new System.Drawing.Point(27, 271);
            this.addNewFoodBtn.Name = "addNewFoodBtn";
            this.addNewFoodBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.addNewFoodBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(49)))), ((int)(((byte)(199)))));
            this.addNewFoodBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.addNewFoodBtn.selected = false;
            this.addNewFoodBtn.Size = new System.Drawing.Size(172, 46);
            this.addNewFoodBtn.TabIndex = 15;
            this.addNewFoodBtn.Text = "ADD NEW FOOD";
            this.addNewFoodBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addNewFoodBtn.Textcolor = System.Drawing.Color.White;
            this.addNewFoodBtn.TextFont = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewFoodBtn.Click += new System.EventHandler(this.addNewFoodBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // addFoodTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "addFoodTab";
            this.Size = new System.Drawing.Size(686, 330);
            this.Load += new System.EventHandler(this.addFoodTab_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainFoodGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.subFoodGrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView mainFoodGrid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private Bunifu.Framework.UI.BunifuFlatButton addFoodBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView subFoodGrid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private Bunifu.Framework.UI.BunifuFlatButton addSubFoodBtn;
        private Bunifu.Framework.UI.BunifuFlatButton addNewFoodBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox searchMainTxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox searchSubTxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox subFoodTxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox mainFoodTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}
