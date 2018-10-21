namespace ProjectBouncingBall
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editFigureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTheShapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorOfTheFigureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTheFillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.behaviorOfTheFigureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.colorLine = new System.Windows.Forms.ColorDialog();
            this.trackBaryspeed = new System.Windows.Forms.TrackBar();
            this.trackBarXySpeed = new System.Windows.Forms.TrackBar();
            this.trackBarxspeed = new System.Windows.Forms.TrackBar();
            this.changeTheObjectBox = new System.Windows.Forms.GroupBox();
            this.radioButtonRectangle = new System.Windows.Forms.RadioButton();
            this.radioButtonEllipse = new System.Windows.Forms.RadioButton();
            this.radioButtonSquare = new System.Windows.Forms.RadioButton();
            this.radioButtonCircle = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelXspeed = new System.Windows.Forms.Label();
            this.labelYspeed = new System.Windows.Forms.Label();
            this.labelSPEED = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBaryspeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarXySpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarxspeed)).BeginInit();
            this.changeTheObjectBox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editFigureToolStripMenuItem,
            this.editFormToolStripMenuItem,
            this.behaviorOfTheFigureToolStripMenuItem,
            this.informationToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(856, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editFigureToolStripMenuItem
            // 
            this.editFigureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeTheShapeToolStripMenuItem,
            this.colorOfTheFigureToolStripMenuItem});
            this.editFigureToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editFigureToolStripMenuItem.Image")));
            this.editFigureToolStripMenuItem.Name = "editFigureToolStripMenuItem";
            this.editFigureToolStripMenuItem.Size = new System.Drawing.Size(129, 29);
            this.editFigureToolStripMenuItem.Text = "Edit figure";
            this.editFigureToolStripMenuItem.MouseHover += new System.EventHandler(this.editFigureToolStripMenuItem_MouseHover);
            // 
            // changeTheShapeToolStripMenuItem
            // 
            this.changeTheShapeToolStripMenuItem.CheckOnClick = true;
            this.changeTheShapeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changeTheShapeToolStripMenuItem.Image")));
            this.changeTheShapeToolStripMenuItem.Name = "changeTheShapeToolStripMenuItem";
            this.changeTheShapeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.changeTheShapeToolStripMenuItem.Size = new System.Drawing.Size(299, 30);
            this.changeTheShapeToolStripMenuItem.Text = "&Change the shape";
            this.changeTheShapeToolStripMenuItem.Click += new System.EventHandler(this.changeTheShapeToolStripMenuItem_Click);
            this.changeTheShapeToolStripMenuItem.MouseHover += new System.EventHandler(this.changeTheShapeToolStripMenuItem_MouseHover);
            // 
            // colorOfTheFigureToolStripMenuItem
            // 
            this.colorOfTheFigureToolStripMenuItem.CheckOnClick = true;
            this.colorOfTheFigureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorDialogToolStripMenuItem,
            this.changeTheFillToolStripMenuItem,
            this.lineColorToolStripMenuItem});
            this.colorOfTheFigureToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("colorOfTheFigureToolStripMenuItem.Image")));
            this.colorOfTheFigureToolStripMenuItem.Name = "colorOfTheFigureToolStripMenuItem";
            this.colorOfTheFigureToolStripMenuItem.Size = new System.Drawing.Size(299, 30);
            this.colorOfTheFigureToolStripMenuItem.Text = "Change figure\'s color";
            this.colorOfTheFigureToolStripMenuItem.MouseHover += new System.EventHandler(this.colorOfTheFigureToolStripMenuItem_MouseHover);
            // 
            // colorDialogToolStripMenuItem
            // 
            this.colorDialogToolStripMenuItem.Enabled = false;
            this.colorDialogToolStripMenuItem.Name = "colorDialogToolStripMenuItem";
            this.colorDialogToolStripMenuItem.Size = new System.Drawing.Size(269, 30);
            this.colorDialogToolStripMenuItem.Text = "Color dialog";
            // 
            // changeTheFillToolStripMenuItem
            // 
            this.changeTheFillToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changeTheFillToolStripMenuItem.Image")));
            this.changeTheFillToolStripMenuItem.Name = "changeTheFillToolStripMenuItem";
            this.changeTheFillToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.changeTheFillToolStripMenuItem.Size = new System.Drawing.Size(269, 30);
            this.changeTheFillToolStripMenuItem.Text = "&Fillling colors";
            this.changeTheFillToolStripMenuItem.Click += new System.EventHandler(this.changeTheFillToolStripMenuItem_Click);
            this.changeTheFillToolStripMenuItem.MouseHover += new System.EventHandler(this.changeTheFillToolStripMenuItem_MouseHover);
            // 
            // lineColorToolStripMenuItem
            // 
            this.lineColorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lineColorToolStripMenuItem.Image")));
            this.lineColorToolStripMenuItem.Name = "lineColorToolStripMenuItem";
            this.lineColorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F2)));
            this.lineColorToolStripMenuItem.Size = new System.Drawing.Size(269, 30);
            this.lineColorToolStripMenuItem.Text = "&Line color";
            this.lineColorToolStripMenuItem.Click += new System.EventHandler(this.lineColorToolStripMenuItem_Click);
            this.lineColorToolStripMenuItem.MouseHover += new System.EventHandler(this.lineColorToolStripMenuItem_MouseHover);
            // 
            // editFormToolStripMenuItem
            // 
            this.editFormToolStripMenuItem.CheckOnClick = true;
            this.editFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeColorToolStripMenuItem});
            this.editFormToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editFormToolStripMenuItem.Image")));
            this.editFormToolStripMenuItem.Name = "editFormToolStripMenuItem";
            this.editFormToolStripMenuItem.Size = new System.Drawing.Size(122, 29);
            this.editFormToolStripMenuItem.Text = "Edit form";
            this.editFormToolStripMenuItem.Click += new System.EventHandler(this.editFormToolStripMenuItem_Click);
            this.editFormToolStripMenuItem.MouseHover += new System.EventHandler(this.editFormToolStripMenuItem_MouseHover);
            // 
            // changeColorToolStripMenuItem
            // 
            this.changeColorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changeColorToolStripMenuItem.Image")));
            this.changeColorToolStripMenuItem.Name = "changeColorToolStripMenuItem";
            this.changeColorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.changeColorToolStripMenuItem.Size = new System.Drawing.Size(363, 30);
            this.changeColorToolStripMenuItem.Text = "&Change background color";
            this.changeColorToolStripMenuItem.Click += new System.EventHandler(this.changeColorToolStripMenuItem_Click);
            this.changeColorToolStripMenuItem.MouseHover += new System.EventHandler(this.changeColorToolStripMenuItem_MouseHover);
            // 
            // behaviorOfTheFigureToolStripMenuItem
            // 
            this.behaviorOfTheFigureToolStripMenuItem.CheckOnClick = true;
            this.behaviorOfTheFigureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.speedToolStripMenuItem});
            this.behaviorOfTheFigureToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("behaviorOfTheFigureToolStripMenuItem.Image")));
            this.behaviorOfTheFigureToolStripMenuItem.Name = "behaviorOfTheFigureToolStripMenuItem";
            this.behaviorOfTheFigureToolStripMenuItem.Size = new System.Drawing.Size(219, 29);
            this.behaviorOfTheFigureToolStripMenuItem.Text = "Behavior of the figure";
            this.behaviorOfTheFigureToolStripMenuItem.Click += new System.EventHandler(this.behaviorOfTheFigureToolStripMenuItem_Click);
            this.behaviorOfTheFigureToolStripMenuItem.MouseHover += new System.EventHandler(this.behaviorOfTheFigureToolStripMenuItem_MouseHover);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("startToolStripMenuItem.Image")));
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.startToolStripMenuItem.Size = new System.Drawing.Size(345, 30);
            this.startToolStripMenuItem.Text = "&Start moving";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            this.startToolStripMenuItem.MouseHover += new System.EventHandler(this.startToolStripMenuItem_MouseHover);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stopToolStripMenuItem.Image")));
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Space)));
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(345, 30);
            this.stopToolStripMenuItem.Text = "&Stop moving";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            this.stopToolStripMenuItem.MouseHover += new System.EventHandler(this.stopToolStripMenuItem_MouseHover);
            // 
            // speedToolStripMenuItem
            // 
            this.speedToolStripMenuItem.CheckOnClick = true;
            this.speedToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("speedToolStripMenuItem.Image")));
            this.speedToolStripMenuItem.Name = "speedToolStripMenuItem";
            this.speedToolStripMenuItem.Size = new System.Drawing.Size(345, 30);
            this.speedToolStripMenuItem.Text = "&Speed ";
            this.speedToolStripMenuItem.Click += new System.EventHandler(this.speedToolStripMenuItem_Click);
            this.speedToolStripMenuItem.MouseHover += new System.EventHandler(this.speedToolStripMenuItem_MouseHover);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInfoToolStripMenuItem,
            this.autorInfoToolStripMenuItem});
            this.informationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("informationToolStripMenuItem.Image")));
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(147, 29);
            this.informationToolStripMenuItem.Text = "Information ";
            // 
            // showInfoToolStripMenuItem
            // 
            this.showInfoToolStripMenuItem.Image = global::ProjectBouncingBall.Properties.Resources.ux_design;
            this.showInfoToolStripMenuItem.Name = "showInfoToolStripMenuItem";
            this.showInfoToolStripMenuItem.Size = new System.Drawing.Size(233, 30);
            this.showInfoToolStripMenuItem.Text = "&Application info";
            this.showInfoToolStripMenuItem.Click += new System.EventHandler(this.showInfoToolStripMenuItem_Click);
            // 
            // autorInfoToolStripMenuItem
            // 
            this.autorInfoToolStripMenuItem.Image = global::ProjectBouncingBall.Properties.Resources.graduation_ceremony;
            this.autorInfoToolStripMenuItem.Name = "autorInfoToolStripMenuItem";
            this.autorInfoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.autorInfoToolStripMenuItem.Size = new System.Drawing.Size(233, 30);
            this.autorInfoToolStripMenuItem.Text = "&Autor info";
            this.autorInfoToolStripMenuItem.Click += new System.EventHandler(this.autorInfoToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Image = global::ProjectBouncingBall.Properties.Resources.customer_problem;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(124, 29);
            this.helpToolStripMenuItem.Text = "Hide help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            this.helpToolStripMenuItem.MouseHover += new System.EventHandler(this.helpToolStripMenuItem_MouseHover);
            // 
            // colorDialog2
            // 
            this.colorDialog2.Color = System.Drawing.Color.Blue;
            // 
            // trackBaryspeed
            // 
            this.trackBaryspeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBaryspeed.Location = new System.Drawing.Point(613, 131);
            this.trackBaryspeed.Maximum = 4;
            this.trackBaryspeed.Name = "trackBaryspeed";
            this.trackBaryspeed.Size = new System.Drawing.Size(230, 69);
            this.trackBaryspeed.TabIndex = 4;
            this.trackBaryspeed.Visible = false;
            this.trackBaryspeed.Scroll += new System.EventHandler(this.trackBaryspeed_Scroll);
            // 
            // trackBarXySpeed
            // 
            this.trackBarXySpeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarXySpeed.Location = new System.Drawing.Point(614, 206);
            this.trackBarXySpeed.Maximum = 4;
            this.trackBarXySpeed.Name = "trackBarXySpeed";
            this.trackBarXySpeed.Size = new System.Drawing.Size(230, 69);
            this.trackBarXySpeed.TabIndex = 5;
            this.trackBarXySpeed.Visible = false;
            this.trackBarXySpeed.Scroll += new System.EventHandler(this.trackBarXySpeed_Scroll);
            // 
            // trackBarxspeed
            // 
            this.trackBarxspeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarxspeed.Location = new System.Drawing.Point(614, 56);
            this.trackBarxspeed.Maximum = 4;
            this.trackBarxspeed.Name = "trackBarxspeed";
            this.trackBarxspeed.Size = new System.Drawing.Size(230, 69);
            this.trackBarxspeed.TabIndex = 6;
            this.trackBarxspeed.Visible = false;
            this.trackBarxspeed.Scroll += new System.EventHandler(this.trackBarxspeed_Scroll_1);
            // 
            // changeTheObjectBox
            // 
            this.changeTheObjectBox.Controls.Add(this.radioButtonRectangle);
            this.changeTheObjectBox.Controls.Add(this.radioButtonEllipse);
            this.changeTheObjectBox.Controls.Add(this.radioButtonSquare);
            this.changeTheObjectBox.Controls.Add(this.radioButtonCircle);
            this.changeTheObjectBox.Location = new System.Drawing.Point(625, 261);
            this.changeTheObjectBox.Name = "changeTheObjectBox";
            this.changeTheObjectBox.Size = new System.Drawing.Size(218, 276);
            this.changeTheObjectBox.TabIndex = 7;
            this.changeTheObjectBox.TabStop = false;
            this.changeTheObjectBox.Text = "Choose a figure";
            this.changeTheObjectBox.Visible = false;
            // 
            // radioButtonRectangle
            // 
            this.radioButtonRectangle.AutoSize = true;
            this.radioButtonRectangle.Location = new System.Drawing.Point(6, 161);
            this.radioButtonRectangle.Name = "radioButtonRectangle";
            this.radioButtonRectangle.Size = new System.Drawing.Size(107, 24);
            this.radioButtonRectangle.TabIndex = 3;
            this.radioButtonRectangle.Text = "Rectangle";
            this.radioButtonRectangle.UseVisualStyleBackColor = true;
            // 
            // radioButtonEllipse
            // 
            this.radioButtonEllipse.AutoSize = true;
            this.radioButtonEllipse.Location = new System.Drawing.Point(6, 120);
            this.radioButtonEllipse.Name = "radioButtonEllipse";
            this.radioButtonEllipse.Size = new System.Drawing.Size(80, 24);
            this.radioButtonEllipse.TabIndex = 2;
            this.radioButtonEllipse.Text = "Ellipse";
            this.radioButtonEllipse.UseVisualStyleBackColor = true;
            // 
            // radioButtonSquare
            // 
            this.radioButtonSquare.AutoSize = true;
            this.radioButtonSquare.Location = new System.Drawing.Point(6, 80);
            this.radioButtonSquare.Name = "radioButtonSquare";
            this.radioButtonSquare.Size = new System.Drawing.Size(86, 24);
            this.radioButtonSquare.TabIndex = 1;
            this.radioButtonSquare.Text = "Square";
            this.radioButtonSquare.UseVisualStyleBackColor = true;
            // 
            // radioButtonCircle
            // 
            this.radioButtonCircle.AutoSize = true;
            this.radioButtonCircle.Checked = true;
            this.radioButtonCircle.Location = new System.Drawing.Point(6, 37);
            this.radioButtonCircle.Name = "radioButtonCircle";
            this.radioButtonCircle.Size = new System.Drawing.Size(73, 24);
            this.radioButtonCircle.TabIndex = 0;
            this.radioButtonCircle.TabStop = true;
            this.radioButtonCircle.Text = "Circle";
            this.radioButtonCircle.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 534);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.ShowItemToolTips = true;
            this.statusStrip1.Size = new System.Drawing.Size(856, 30);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(640, 25);
            this.toolStripStatusLabel1.Text = "Demonstration of bouncing object .Please choose a command from the menu .";
            // 
            // labelXspeed
            // 
            this.labelXspeed.AutoSize = true;
            this.labelXspeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelXspeed.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelXspeed.Location = new System.Drawing.Point(610, 35);
            this.labelXspeed.Name = "labelXspeed";
            this.labelXspeed.Size = new System.Drawing.Size(144, 22);
            this.labelXspeed.TabIndex = 8;
            this.labelXspeed.Text = "Horizontal speed";
            this.labelXspeed.Visible = false;
            // 
            // labelYspeed
            // 
            this.labelYspeed.AutoSize = true;
            this.labelYspeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYspeed.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelYspeed.Location = new System.Drawing.Point(610, 105);
            this.labelYspeed.Name = "labelYspeed";
            this.labelYspeed.Size = new System.Drawing.Size(124, 22);
            this.labelYspeed.TabIndex = 9;
            this.labelYspeed.Text = "Vertical speed";
            this.labelYspeed.Visible = false;
            // 
            // labelSPEED
            // 
            this.labelSPEED.AutoSize = true;
            this.labelSPEED.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSPEED.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelSPEED.Location = new System.Drawing.Point(610, 181);
            this.labelSPEED.Name = "labelSPEED";
            this.labelSPEED.Size = new System.Drawing.Size(62, 22);
            this.labelSPEED.TabIndex = 10;
            this.labelSPEED.Text = "Speed";
            this.labelSPEED.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(856, 564);
            this.Controls.Add(this.labelSPEED);
            this.Controls.Add(this.labelYspeed);
            this.Controls.Add(this.labelXspeed);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.changeTheObjectBox);
            this.Controls.Add(this.trackBarxspeed);
            this.Controls.Add(this.trackBarXySpeed);
            this.Controls.Add(this.trackBaryspeed);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(657, 526);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bouncing figure";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBaryspeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarXySpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarxspeed)).EndInit();
            this.changeTheObjectBox.ResumeLayout(false);
            this.changeTheObjectBox.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editFigureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeTheShapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorOfTheFigureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeTheFillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem behaviorOfTheFigureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showInfoToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ToolStripMenuItem speedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorInfoToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorLine;
        private System.Windows.Forms.ToolStripMenuItem colorDialogToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBaryspeed;
        private System.Windows.Forms.TrackBar trackBarXySpeed;
        private System.Windows.Forms.TrackBar trackBarxspeed;
        private System.Windows.Forms.GroupBox changeTheObjectBox;
        private System.Windows.Forms.RadioButton radioButtonRectangle;
        private System.Windows.Forms.RadioButton radioButtonEllipse;
        private System.Windows.Forms.RadioButton radioButtonSquare;
        private System.Windows.Forms.RadioButton radioButtonCircle;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label labelXspeed;
        private System.Windows.Forms.Label labelYspeed;
        private System.Windows.Forms.Label labelSPEED;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

