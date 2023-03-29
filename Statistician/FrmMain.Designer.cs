
namespace Statistician
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutStatisticianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.Lbl_DataPath = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.Lbl_Year = new System.Windows.Forms.ToolStripLabel();
            this.Combo_Year = new System.Windows.Forms.ToolStripComboBox();
            this.Lbl_Month = new System.Windows.Forms.ToolStripLabel();
            this.Combo_Month = new System.Windows.Forms.ToolStripComboBox();
            this.Lbl_DataTarget = new System.Windows.Forms.ToolStripLabel();
            this.Combo_DataTarget = new System.Windows.Forms.ToolStripComboBox();
            this.Lbl_GamePlayer = new System.Windows.Forms.ToolStripLabel();
            this.Combo_GamePlayer = new System.Windows.Forms.ToolStripComboBox();
            this.Lbl_GameControl = new System.Windows.Forms.ToolStripLabel();
            this.Combo_GameControl = new System.Windows.Forms.ToolStripComboBox();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MenuStrip.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(2180, 39);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importDataToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(73, 35);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // importDataToolStripMenuItem
            // 
            this.importDataToolStripMenuItem.Name = "importDataToolStripMenuItem";
            this.importDataToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.importDataToolStripMenuItem.Size = new System.Drawing.Size(381, 44);
            this.importDataToolStripMenuItem.Text = "&Import Data...";
            this.importDataToolStripMenuItem.Click += new System.EventHandler(this.importDataToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(378, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(381, 44);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshGraphToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(89, 35);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // refreshGraphToolStripMenuItem
            // 
            this.refreshGraphToolStripMenuItem.Enabled = false;
            this.refreshGraphToolStripMenuItem.Name = "refreshGraphToolStripMenuItem";
            this.refreshGraphToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.refreshGraphToolStripMenuItem.Size = new System.Drawing.Size(399, 44);
            this.refreshGraphToolStripMenuItem.Text = "&Refresh Graph";
            this.refreshGraphToolStripMenuItem.Click += new System.EventHandler(this.refreshGraphToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutStatisticianToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(105, 35);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // aboutStatisticianToolStripMenuItem
            // 
            this.aboutStatisticianToolStripMenuItem.Name = "aboutStatisticianToolStripMenuItem";
            this.aboutStatisticianToolStripMenuItem.Size = new System.Drawing.Size(366, 44);
            this.aboutStatisticianToolStripMenuItem.Text = "&About Statistician...";
            this.aboutStatisticianToolStripMenuItem.Click += new System.EventHandler(this.aboutStatisticianToolStripMenuItem_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Lbl_DataPath});
            this.StatusStrip.Location = new System.Drawing.Point(0, 1429);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(2180, 41);
            this.StatusStrip.SizingGrip = false;
            this.StatusStrip.TabIndex = 1;
            // 
            // Lbl_DataPath
            // 
            this.Lbl_DataPath.Name = "Lbl_DataPath";
            this.Lbl_DataPath.Size = new System.Drawing.Size(188, 31);
            this.Lbl_DataPath.Text = "Data not found";
            // 
            // ToolStrip
            // 
            this.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Lbl_Year,
            this.Combo_Year,
            this.Lbl_Month,
            this.Combo_Month,
            this.Lbl_DataTarget,
            this.Combo_DataTarget,
            this.Lbl_GamePlayer,
            this.Combo_GamePlayer,
            this.Lbl_GameControl,
            this.Combo_GameControl});
            this.ToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ToolStrip.Location = new System.Drawing.Point(0, 39);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(2180, 39);
            this.ToolStrip.TabIndex = 2;
            // 
            // Lbl_Year
            // 
            this.Lbl_Year.Name = "Lbl_Year";
            this.Lbl_Year.Size = new System.Drawing.Size(64, 33);
            this.Lbl_Year.Text = "Year";
            // 
            // Combo_Year
            // 
            this.Combo_Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_Year.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.Combo_Year.Name = "Combo_Year";
            this.Combo_Year.Size = new System.Drawing.Size(121, 39);
            this.Combo_Year.SelectedIndexChanged += new System.EventHandler(this.Combo_Year_SelectedIndexChanged);
            // 
            // Lbl_Month
            // 
            this.Lbl_Month.Margin = new System.Windows.Forms.Padding(20, 2, 0, 4);
            this.Lbl_Month.Name = "Lbl_Month";
            this.Lbl_Month.Size = new System.Drawing.Size(91, 33);
            this.Lbl_Month.Text = "Month";
            this.Lbl_Month.Visible = false;
            // 
            // Combo_Month
            // 
            this.Combo_Month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_Month.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.Combo_Month.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.Combo_Month.Name = "Combo_Month";
            this.Combo_Month.Size = new System.Drawing.Size(121, 39);
            this.Combo_Month.Visible = false;
            // 
            // Lbl_DataTarget
            // 
            this.Lbl_DataTarget.Margin = new System.Windows.Forms.Padding(20, 2, 0, 4);
            this.Lbl_DataTarget.Name = "Lbl_DataTarget";
            this.Lbl_DataTarget.Size = new System.Drawing.Size(67, 33);
            this.Lbl_DataTarget.Text = "Data";
            // 
            // Combo_DataTarget
            // 
            this.Combo_DataTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_DataTarget.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.Combo_DataTarget.Items.AddRange(new object[] {
            "Duration",
            "Found cards count",
            "Used cards count",
            "Drew shapes count",
            "Moved distance"});
            this.Combo_DataTarget.Name = "Combo_DataTarget";
            this.Combo_DataTarget.Size = new System.Drawing.Size(300, 39);
            this.Combo_DataTarget.SelectedIndexChanged += new System.EventHandler(this.Combo_DataTarget_SelectedIndexChanged);
            // 
            // Lbl_GamePlayer
            // 
            this.Lbl_GamePlayer.Margin = new System.Windows.Forms.Padding(20, 2, 0, 4);
            this.Lbl_GamePlayer.Name = "Lbl_GamePlayer";
            this.Lbl_GamePlayer.Size = new System.Drawing.Size(151, 33);
            this.Lbl_GamePlayer.Text = "GamePlayer";
            // 
            // Combo_GamePlayer
            // 
            this.Combo_GamePlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_GamePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.Combo_GamePlayer.Items.AddRange(new object[] {
            "Player1",
            "Player2",
            "Both"});
            this.Combo_GamePlayer.Name = "Combo_GamePlayer";
            this.Combo_GamePlayer.Size = new System.Drawing.Size(150, 39);
            this.Combo_GamePlayer.SelectedIndexChanged += new System.EventHandler(this.Combo_GamePlayer_SelectedIndexChanged);
            // 
            // Lbl_GameControl
            // 
            this.Lbl_GameControl.Margin = new System.Windows.Forms.Padding(20, 2, 0, 4);
            this.Lbl_GameControl.Name = "Lbl_GameControl";
            this.Lbl_GameControl.Size = new System.Drawing.Size(166, 33);
            this.Lbl_GameControl.Text = "GameControl";
            this.Lbl_GameControl.Visible = false;
            // 
            // Combo_GameControl
            // 
            this.Combo_GameControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_GameControl.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.Combo_GameControl.Items.AddRange(new object[] {
            "Keyboard",
            "Sensors",
            "Both"});
            this.Combo_GameControl.Name = "Combo_GameControl";
            this.Combo_GameControl.Size = new System.Drawing.Size(150, 39);
            this.Combo_GameControl.Visible = false;
            // 
            // SplitContainer
            // 
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.Location = new System.Drawing.Point(0, 78);
            this.SplitContainer.Name = "SplitContainer";
            this.SplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.Controls.Add(this.Chart1);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.Controls.Add(this.Chart2);
            this.SplitContainer.Size = new System.Drawing.Size(2180, 1351);
            this.SplitContainer.SplitterDistance = 727;
            this.SplitContainer.TabIndex = 3;
            // 
            // Chart1
            // 
            this.Chart1.BorderlineWidth = 0;
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea1.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea";
            this.Chart1.ChartAreas.Add(chartArea1);
            this.Chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Chart1.Location = new System.Drawing.Point(0, 0);
            this.Chart1.Name = "Chart1";
            series1.ChartArea = "ChartArea";
            series1.Name = "SeriesData";
            this.Chart1.Series.Add(series1);
            this.Chart1.Size = new System.Drawing.Size(2180, 727);
            this.Chart1.TabIndex = 5;
            title1.Name = "Title";
            this.Chart1.Titles.Add(title1);
            // 
            // Chart2
            // 
            this.Chart2.BorderlineWidth = 0;
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea2.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea2.BorderWidth = 0;
            chartArea2.Name = "ChartArea";
            this.Chart2.ChartAreas.Add(chartArea2);
            this.Chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Chart2.Location = new System.Drawing.Point(0, 0);
            this.Chart2.Name = "Chart2";
            series2.ChartArea = "ChartArea";
            series2.Name = "SeriesData";
            this.Chart2.Series.Add(series2);
            this.Chart2.Size = new System.Drawing.Size(2180, 620);
            this.Chart2.TabIndex = 6;
            title2.Name = "Title";
            this.Chart2.Titles.Add(title2);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2180, 1470);
            this.Controls.Add(this.SplitContainer);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "FrmMain";
            this.Text = "Statistician";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel Lbl_Year;
        private System.Windows.Forms.ToolStripComboBox Combo_Year;
        private System.Windows.Forms.ToolStripLabel Lbl_GamePlayer;
        private System.Windows.Forms.ToolStripComboBox Combo_GamePlayer;
        private System.Windows.Forms.ToolStripLabel Lbl_GameControl;
        private System.Windows.Forms.ToolStripComboBox Combo_GameControl;
        private System.Windows.Forms.ToolStripStatusLabel Lbl_DataPath;
        private System.Windows.Forms.ToolStripMenuItem importDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel Lbl_Month;
        private System.Windows.Forms.ToolStripComboBox Combo_Month;
        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart2;
        private System.Windows.Forms.ToolStripComboBox Combo_DataTarget;
        private System.Windows.Forms.ToolStripLabel Lbl_DataTarget;
        private System.Windows.Forms.ToolStripMenuItem refreshGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutStatisticianToolStripMenuItem;
    }
}

