namespace EasySyslogMonitor {
   partial class FrmMain {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing) {
         if (disposing && (components != null)) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent() {
         this.components = new System.ComponentModel.Container();
         System.Windows.Forms.Label nameLabel;
         System.Windows.Forms.Label source_ipLabel;
         System.Windows.Forms.Label patternLabel;
         System.Windows.Forms.Label mailtoLabel;
         System.Windows.Forms.Label templateLabel;
         System.Windows.Forms.Label facilityLabel;
         System.Windows.Forms.Label severityLabel;
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
         this.toolStrip1 = new System.Windows.Forms.ToolStrip();
         this.btnStart1 = new System.Windows.Forms.ToolStripButton();
         this.btnStop = new System.Windows.Forms.ToolStripButton();
         this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.btnShowMessages = new System.Windows.Forms.ToolStripButton();
         this.tabControl1 = new System.Windows.Forms.TabControl();
         this.tabMessages = new System.Windows.Forms.TabPage();
         this.grdMessages = new System.Windows.Forms.DataGridView();
         this.colTimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.colHostname = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.colSeverity = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.colFacility = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.colMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.tabRules = new System.Windows.Forms.TabPage();
         this.splitContainer1 = new System.Windows.Forms.SplitContainer();
         this.rulesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
         this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
         this.rulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.easysyslogmonDataSet = new EasySyslogMonitor.easysyslogmonDataSet1();
         this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
         this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
         this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
         this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
         this.rulesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
         this.nameTextBox = new System.Windows.Forms.TextBox();
         this.source_ipTextBox = new System.Windows.Forms.TextBox();
         this.patternTextBox = new System.Windows.Forms.TextBox();
         this.mailtoTextBox = new System.Windows.Forms.TextBox();
         this.templateTextBox = new System.Windows.Forms.TextBox();
         this.facilityTextBox = new System.Windows.Forms.TextBox();
         this.severityTextBox = new System.Windows.Forms.TextBox();
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.sourceipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.patternDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.mailtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.templateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.facilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.severityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.rulesTableAdapter = new EasySyslogMonitor.easysyslogmonDataSet1TableAdapters.rulesTableAdapter();
         this.tableAdapterManager = new EasySyslogMonitor.easysyslogmonDataSet1TableAdapters.TableAdapterManager();
         nameLabel = new System.Windows.Forms.Label();
         source_ipLabel = new System.Windows.Forms.Label();
         patternLabel = new System.Windows.Forms.Label();
         mailtoLabel = new System.Windows.Forms.Label();
         templateLabel = new System.Windows.Forms.Label();
         facilityLabel = new System.Windows.Forms.Label();
         severityLabel = new System.Windows.Forms.Label();
         this.toolStrip1.SuspendLayout();
         this.tabControl1.SuspendLayout();
         this.tabMessages.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.grdMessages)).BeginInit();
         this.tabRules.SuspendLayout();
         this.splitContainer1.Panel1.SuspendLayout();
         this.splitContainer1.Panel2.SuspendLayout();
         this.splitContainer1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.rulesBindingNavigator)).BeginInit();
         this.rulesBindingNavigator.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.rulesBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.easysyslogmonDataSet)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         this.SuspendLayout();
         // 
         // nameLabel
         // 
         nameLabel.AutoSize = true;
         nameLabel.Location = new System.Drawing.Point(8, 45);
         nameLabel.Name = "nameLabel";
         nameLabel.Size = new System.Drawing.Size(36, 13);
         nameLabel.TabIndex = 16;
         nameLabel.Text = "name:";
         // 
         // source_ipLabel
         // 
         source_ipLabel.AutoSize = true;
         source_ipLabel.Location = new System.Drawing.Point(8, 71);
         source_ipLabel.Name = "source_ipLabel";
         source_ipLabel.Size = new System.Drawing.Size(53, 13);
         source_ipLabel.TabIndex = 18;
         source_ipLabel.Text = "source ip:";
         // 
         // patternLabel
         // 
         patternLabel.AutoSize = true;
         patternLabel.Location = new System.Drawing.Point(8, 124);
         patternLabel.Name = "patternLabel";
         patternLabel.Size = new System.Drawing.Size(43, 13);
         patternLabel.TabIndex = 20;
         patternLabel.Text = "pattern:";
         // 
         // mailtoLabel
         // 
         mailtoLabel.AutoSize = true;
         mailtoLabel.Location = new System.Drawing.Point(8, 150);
         mailtoLabel.Name = "mailtoLabel";
         mailtoLabel.Size = new System.Drawing.Size(37, 13);
         mailtoLabel.TabIndex = 22;
         mailtoLabel.Text = "mailto:";
         // 
         // templateLabel
         // 
         templateLabel.AutoSize = true;
         templateLabel.Location = new System.Drawing.Point(8, 176);
         templateLabel.Name = "templateLabel";
         templateLabel.Size = new System.Drawing.Size(50, 13);
         templateLabel.TabIndex = 24;
         templateLabel.Text = "template:";
         // 
         // facilityLabel
         // 
         facilityLabel.AutoSize = true;
         facilityLabel.Location = new System.Drawing.Point(8, 98);
         facilityLabel.Name = "facilityLabel";
         facilityLabel.Size = new System.Drawing.Size(39, 13);
         facilityLabel.TabIndex = 26;
         facilityLabel.Text = "facility:";
         // 
         // severityLabel
         // 
         severityLabel.AutoSize = true;
         severityLabel.Location = new System.Drawing.Point(331, 97);
         severityLabel.Name = "severityLabel";
         severityLabel.Size = new System.Drawing.Size(46, 13);
         severityLabel.TabIndex = 28;
         severityLabel.Text = "severity:";
         // 
         // toolStrip1
         // 
         this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnStart1,
            this.btnStop,
            this.toolStripSeparator1,
            this.btnShowMessages});
         this.toolStrip1.Location = new System.Drawing.Point(0, 0);
         this.toolStrip1.Name = "toolStrip1";
         this.toolStrip1.Size = new System.Drawing.Size(661, 25);
         this.toolStrip1.TabIndex = 2;
         this.toolStrip1.Text = "toolStrip1";
         // 
         // btnStart1
         // 
         this.btnStart1.Image = ((System.Drawing.Image)(resources.GetObject("btnStart1.Image")));
         this.btnStart1.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.btnStart1.Name = "btnStart1";
         this.btnStart1.Size = new System.Drawing.Size(51, 22);
         this.btnStart1.Text = "Start";
         this.btnStart1.Click += new System.EventHandler(this.btnStart1_Click);
         // 
         // btnStop
         // 
         this.btnStop.Enabled = false;
         this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
         this.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.btnStop.Name = "btnStop";
         this.btnStop.Size = new System.Drawing.Size(49, 22);
         this.btnStop.Text = "Stop";
         this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
         // 
         // toolStripSeparator1
         // 
         this.toolStripSeparator1.Name = "toolStripSeparator1";
         this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
         // 
         // btnShowMessages
         // 
         this.btnShowMessages.CheckOnClick = true;
         this.btnShowMessages.Image = ((System.Drawing.Image)(resources.GetObject("btnShowMessages.Image")));
         this.btnShowMessages.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.btnShowMessages.Name = "btnShowMessages";
         this.btnShowMessages.Size = new System.Drawing.Size(111, 22);
         this.btnShowMessages.Text = "Display Messages";
         this.btnShowMessages.Click += new System.EventHandler(this.btnShowMessages_Click);
         // 
         // tabControl1
         // 
         this.tabControl1.Controls.Add(this.tabMessages);
         this.tabControl1.Controls.Add(this.tabRules);
         this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tabControl1.Location = new System.Drawing.Point(0, 25);
         this.tabControl1.Name = "tabControl1";
         this.tabControl1.SelectedIndex = 0;
         this.tabControl1.Size = new System.Drawing.Size(661, 364);
         this.tabControl1.TabIndex = 3;
         // 
         // tabMessages
         // 
         this.tabMessages.Controls.Add(this.grdMessages);
         this.tabMessages.Location = new System.Drawing.Point(4, 22);
         this.tabMessages.Name = "tabMessages";
         this.tabMessages.Padding = new System.Windows.Forms.Padding(3);
         this.tabMessages.Size = new System.Drawing.Size(653, 338);
         this.tabMessages.TabIndex = 0;
         this.tabMessages.Text = "Received Messages";
         this.tabMessages.UseVisualStyleBackColor = true;
         // 
         // grdMessages
         // 
         this.grdMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.grdMessages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTimeStamp,
            this.colHostname,
            this.colSeverity,
            this.colFacility,
            this.colMessage});
         this.grdMessages.Dock = System.Windows.Forms.DockStyle.Fill;
         this.grdMessages.Location = new System.Drawing.Point(3, 3);
         this.grdMessages.Name = "grdMessages";
         this.grdMessages.ReadOnly = true;
         this.grdMessages.Size = new System.Drawing.Size(647, 332);
         this.grdMessages.TabIndex = 2;
         // 
         // colTimeStamp
         // 
         this.colTimeStamp.HeaderText = "TimeStamp";
         this.colTimeStamp.Name = "colTimeStamp";
         this.colTimeStamp.ReadOnly = true;
         // 
         // colHostname
         // 
         this.colHostname.HeaderText = "HostName";
         this.colHostname.Name = "colHostname";
         this.colHostname.ReadOnly = true;
         // 
         // colSeverity
         // 
         this.colSeverity.HeaderText = "Severity";
         this.colSeverity.Name = "colSeverity";
         this.colSeverity.ReadOnly = true;
         // 
         // colFacility
         // 
         this.colFacility.HeaderText = "Facility";
         this.colFacility.Name = "colFacility";
         this.colFacility.ReadOnly = true;
         // 
         // colMessage
         // 
         this.colMessage.HeaderText = "Message";
         this.colMessage.Name = "colMessage";
         this.colMessage.ReadOnly = true;
         // 
         // tabRules
         // 
         this.tabRules.AutoScroll = true;
         this.tabRules.Controls.Add(this.splitContainer1);
         this.tabRules.Location = new System.Drawing.Point(4, 22);
         this.tabRules.Name = "tabRules";
         this.tabRules.Padding = new System.Windows.Forms.Padding(3);
         this.tabRules.Size = new System.Drawing.Size(653, 338);
         this.tabRules.TabIndex = 1;
         this.tabRules.Text = "Rules";
         this.tabRules.UseVisualStyleBackColor = true;
         // 
         // splitContainer1
         // 
         this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
         this.splitContainer1.Location = new System.Drawing.Point(3, 3);
         this.splitContainer1.Name = "splitContainer1";
         this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
         // 
         // splitContainer1.Panel1
         // 
         this.splitContainer1.Panel1.Controls.Add(this.rulesBindingNavigator);
         this.splitContainer1.Panel1.Controls.Add(nameLabel);
         this.splitContainer1.Panel1.Controls.Add(this.nameTextBox);
         this.splitContainer1.Panel1.Controls.Add(source_ipLabel);
         this.splitContainer1.Panel1.Controls.Add(this.source_ipTextBox);
         this.splitContainer1.Panel1.Controls.Add(patternLabel);
         this.splitContainer1.Panel1.Controls.Add(this.patternTextBox);
         this.splitContainer1.Panel1.Controls.Add(mailtoLabel);
         this.splitContainer1.Panel1.Controls.Add(this.mailtoTextBox);
         this.splitContainer1.Panel1.Controls.Add(templateLabel);
         this.splitContainer1.Panel1.Controls.Add(this.templateTextBox);
         this.splitContainer1.Panel1.Controls.Add(facilityLabel);
         this.splitContainer1.Panel1.Controls.Add(this.facilityTextBox);
         this.splitContainer1.Panel1.Controls.Add(severityLabel);
         this.splitContainer1.Panel1.Controls.Add(this.severityTextBox);
         // 
         // splitContainer1.Panel2
         // 
         this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
         this.splitContainer1.Size = new System.Drawing.Size(647, 332);
         this.splitContainer1.SplitterDistance = 204;
         this.splitContainer1.TabIndex = 0;
         // 
         // rulesBindingNavigator
         // 
         this.rulesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
         this.rulesBindingNavigator.BindingSource = this.rulesBindingSource;
         this.rulesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
         this.rulesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
         this.rulesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.rulesBindingNavigatorSaveItem});
         this.rulesBindingNavigator.Location = new System.Drawing.Point(0, 0);
         this.rulesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
         this.rulesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
         this.rulesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
         this.rulesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
         this.rulesBindingNavigator.Name = "rulesBindingNavigator";
         this.rulesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
         this.rulesBindingNavigator.Size = new System.Drawing.Size(647, 25);
         this.rulesBindingNavigator.TabIndex = 4;
         this.rulesBindingNavigator.Text = "bindingNavigator1";
         // 
         // bindingNavigatorAddNewItem
         // 
         this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
         this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
         this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorAddNewItem.Text = "Add new";
         // 
         // rulesBindingSource
         // 
         this.rulesBindingSource.DataMember = "rules";
         this.rulesBindingSource.DataSource = this.easysyslogmonDataSet;
         // 
         // easysyslogmonDataSet
         // 
         this.easysyslogmonDataSet.DataSetName = "easysyslogmonDataSet";
         this.easysyslogmonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // bindingNavigatorCountItem
         // 
         this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
         this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
         this.bindingNavigatorCountItem.Text = "of {0}";
         this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
         // 
         // bindingNavigatorDeleteItem
         // 
         this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
         this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
         this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorDeleteItem.Text = "Delete";
         // 
         // bindingNavigatorMoveFirstItem
         // 
         this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
         this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
         this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorMoveFirstItem.Text = "Move first";
         // 
         // bindingNavigatorMovePreviousItem
         // 
         this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
         this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
         this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorMovePreviousItem.Text = "Move previous";
         // 
         // bindingNavigatorSeparator
         // 
         this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
         this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
         // 
         // bindingNavigatorPositionItem
         // 
         this.bindingNavigatorPositionItem.AccessibleName = "Position";
         this.bindingNavigatorPositionItem.AutoSize = false;
         this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
         this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
         this.bindingNavigatorPositionItem.Text = "0";
         this.bindingNavigatorPositionItem.ToolTipText = "Current position";
         // 
         // bindingNavigatorSeparator1
         // 
         this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
         this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
         // 
         // bindingNavigatorMoveNextItem
         // 
         this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
         this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
         this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorMoveNextItem.Text = "Move next";
         // 
         // bindingNavigatorMoveLastItem
         // 
         this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
         this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
         this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorMoveLastItem.Text = "Move last";
         // 
         // bindingNavigatorSeparator2
         // 
         this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
         this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
         // 
         // rulesBindingNavigatorSaveItem
         // 
         this.rulesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.rulesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rulesBindingNavigatorSaveItem.Image")));
         this.rulesBindingNavigatorSaveItem.Name = "rulesBindingNavigatorSaveItem";
         this.rulesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
         this.rulesBindingNavigatorSaveItem.Text = "Save Data";
         this.rulesBindingNavigatorSaveItem.Click += new System.EventHandler(this.rulesBindingNavigatorSaveItem_Click);
         // 
         // nameTextBox
         // 
         this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rulesBindingSource, "name", true));
         this.nameTextBox.Location = new System.Drawing.Point(67, 42);
         this.nameTextBox.Name = "nameTextBox";
         this.nameTextBox.Size = new System.Drawing.Size(577, 20);
         this.nameTextBox.TabIndex = 17;
         // 
         // source_ipTextBox
         // 
         this.source_ipTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.source_ipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rulesBindingSource, "source_ip", true));
         this.source_ipTextBox.Location = new System.Drawing.Point(67, 68);
         this.source_ipTextBox.Name = "source_ipTextBox";
         this.source_ipTextBox.Size = new System.Drawing.Size(577, 20);
         this.source_ipTextBox.TabIndex = 19;
         // 
         // patternTextBox
         // 
         this.patternTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.patternTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rulesBindingSource, "pattern", true));
         this.patternTextBox.Location = new System.Drawing.Point(67, 121);
         this.patternTextBox.Name = "patternTextBox";
         this.patternTextBox.Size = new System.Drawing.Size(577, 20);
         this.patternTextBox.TabIndex = 21;
         // 
         // mailtoTextBox
         // 
         this.mailtoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.mailtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rulesBindingSource, "mailto", true));
         this.mailtoTextBox.Location = new System.Drawing.Point(67, 147);
         this.mailtoTextBox.Name = "mailtoTextBox";
         this.mailtoTextBox.Size = new System.Drawing.Size(577, 20);
         this.mailtoTextBox.TabIndex = 23;
         // 
         // templateTextBox
         // 
         this.templateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.templateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rulesBindingSource, "template", true));
         this.templateTextBox.Location = new System.Drawing.Point(67, 173);
         this.templateTextBox.Name = "templateTextBox";
         this.templateTextBox.Size = new System.Drawing.Size(248, 20);
         this.templateTextBox.TabIndex = 25;
         // 
         // facilityTextBox
         // 
         this.facilityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rulesBindingSource, "facility", true));
         this.facilityTextBox.Location = new System.Drawing.Point(67, 95);
         this.facilityTextBox.Name = "facilityTextBox";
         this.facilityTextBox.Size = new System.Drawing.Size(248, 20);
         this.facilityTextBox.TabIndex = 27;
         // 
         // severityTextBox
         // 
         this.severityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.severityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rulesBindingSource, "severity", true));
         this.severityTextBox.Location = new System.Drawing.Point(390, 94);
         this.severityTextBox.Name = "severityTextBox";
         this.severityTextBox.Size = new System.Drawing.Size(254, 20);
         this.severityTextBox.TabIndex = 29;
         // 
         // dataGridView1
         // 
         this.dataGridView1.AutoGenerateColumns = false;
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.sourceipDataGridViewTextBoxColumn,
            this.patternDataGridViewTextBoxColumn,
            this.mailtoDataGridViewTextBoxColumn,
            this.templateDataGridViewTextBoxColumn,
            this.facilityDataGridViewTextBoxColumn,
            this.severityDataGridViewTextBoxColumn});
         this.dataGridView1.DataSource = this.rulesBindingSource;
         this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.dataGridView1.Location = new System.Drawing.Point(0, 0);
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.Size = new System.Drawing.Size(647, 124);
         this.dataGridView1.TabIndex = 0;
         // 
         // idDataGridViewTextBoxColumn
         // 
         this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
         this.idDataGridViewTextBoxColumn.HeaderText = "id";
         this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
         // 
         // nameDataGridViewTextBoxColumn
         // 
         this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
         this.nameDataGridViewTextBoxColumn.HeaderText = "name";
         this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
         // 
         // sourceipDataGridViewTextBoxColumn
         // 
         this.sourceipDataGridViewTextBoxColumn.DataPropertyName = "source_ip";
         this.sourceipDataGridViewTextBoxColumn.HeaderText = "source_ip";
         this.sourceipDataGridViewTextBoxColumn.Name = "sourceipDataGridViewTextBoxColumn";
         // 
         // patternDataGridViewTextBoxColumn
         // 
         this.patternDataGridViewTextBoxColumn.DataPropertyName = "pattern";
         this.patternDataGridViewTextBoxColumn.HeaderText = "pattern";
         this.patternDataGridViewTextBoxColumn.Name = "patternDataGridViewTextBoxColumn";
         // 
         // mailtoDataGridViewTextBoxColumn
         // 
         this.mailtoDataGridViewTextBoxColumn.DataPropertyName = "mailto";
         this.mailtoDataGridViewTextBoxColumn.HeaderText = "mailto";
         this.mailtoDataGridViewTextBoxColumn.Name = "mailtoDataGridViewTextBoxColumn";
         // 
         // templateDataGridViewTextBoxColumn
         // 
         this.templateDataGridViewTextBoxColumn.DataPropertyName = "template";
         this.templateDataGridViewTextBoxColumn.HeaderText = "template";
         this.templateDataGridViewTextBoxColumn.Name = "templateDataGridViewTextBoxColumn";
         // 
         // facilityDataGridViewTextBoxColumn
         // 
         this.facilityDataGridViewTextBoxColumn.DataPropertyName = "facility";
         this.facilityDataGridViewTextBoxColumn.HeaderText = "facility";
         this.facilityDataGridViewTextBoxColumn.Name = "facilityDataGridViewTextBoxColumn";
         // 
         // severityDataGridViewTextBoxColumn
         // 
         this.severityDataGridViewTextBoxColumn.DataPropertyName = "severity";
         this.severityDataGridViewTextBoxColumn.HeaderText = "severity";
         this.severityDataGridViewTextBoxColumn.Name = "severityDataGridViewTextBoxColumn";
         // 
         // rulesTableAdapter
         // 
         this.rulesTableAdapter.ClearBeforeFill = true;
         // 
         // tableAdapterManager
         // 
         this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
         this.tableAdapterManager.rulesTableAdapter = this.rulesTableAdapter;
         this.tableAdapterManager.UpdateOrder = EasySyslogMonitor.easysyslogmonDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
         // 
         // FrmMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(661, 389);
         this.Controls.Add(this.tabControl1);
         this.Controls.Add(this.toolStrip1);
         this.Name = "FrmMain";
         this.Text = "EasySyslogMonitor";
         this.Load += new System.EventHandler(this.FrmMain_Load);
         this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
         this.toolStrip1.ResumeLayout(false);
         this.toolStrip1.PerformLayout();
         this.tabControl1.ResumeLayout(false);
         this.tabMessages.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.grdMessages)).EndInit();
         this.tabRules.ResumeLayout(false);
         this.splitContainer1.Panel1.ResumeLayout(false);
         this.splitContainer1.Panel1.PerformLayout();
         this.splitContainer1.Panel2.ResumeLayout(false);
         this.splitContainer1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.rulesBindingNavigator)).EndInit();
         this.rulesBindingNavigator.ResumeLayout(false);
         this.rulesBindingNavigator.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.rulesBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.easysyslogmonDataSet)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ToolStrip toolStrip1;
      private System.Windows.Forms.ToolStripButton btnStart1;
      private System.Windows.Forms.ToolStripButton btnStop;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
      private System.Windows.Forms.ToolStripButton btnShowMessages;
      private System.Windows.Forms.TabControl tabControl1;
      private System.Windows.Forms.TabPage tabMessages;
      private System.Windows.Forms.DataGridView grdMessages;
      private System.Windows.Forms.DataGridViewTextBoxColumn colTimeStamp;
      private System.Windows.Forms.DataGridViewTextBoxColumn colHostname;
      private System.Windows.Forms.DataGridViewTextBoxColumn colSeverity;
      private System.Windows.Forms.DataGridViewTextBoxColumn colFacility;
      private System.Windows.Forms.DataGridViewTextBoxColumn colMessage;
      private System.Windows.Forms.TabPage tabRules;
      private easysyslogmonDataSet1 easysyslogmonDataSet;
      private System.Windows.Forms.BindingSource rulesBindingSource;
      private EasySyslogMonitor.easysyslogmonDataSet1TableAdapters.rulesTableAdapter rulesTableAdapter;
      private EasySyslogMonitor.easysyslogmonDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
      private System.Windows.Forms.BindingNavigator rulesBindingNavigator;
      private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
      private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
      private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
      private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
      private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
      private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
      private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
      private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
      private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
      private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
      private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
      private System.Windows.Forms.ToolStripButton rulesBindingNavigatorSaveItem;
      private System.Windows.Forms.SplitContainer splitContainer1;
      private System.Windows.Forms.TextBox nameTextBox;
      private System.Windows.Forms.TextBox source_ipTextBox;
      private System.Windows.Forms.TextBox patternTextBox;
      private System.Windows.Forms.TextBox mailtoTextBox;
      private System.Windows.Forms.TextBox templateTextBox;
      private System.Windows.Forms.TextBox facilityTextBox;
      private System.Windows.Forms.TextBox severityTextBox;
      private System.Windows.Forms.DataGridView dataGridView1;
      private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn sourceipDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn patternDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn mailtoDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn templateDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn facilityDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn severityDataGridViewTextBoxColumn;
   }
}

