﻿namespace PlaneAlerter {
	partial class PlaneAlerter {
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Conditions");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Email");
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Radar");
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Program");
			System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Settings", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4});
			System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node0");
			System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node1");
			System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node2");
			System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node3");
			System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Statistics", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaneAlerter));
			this.console = new System.Windows.Forms.RichTextBox();
			this.conditionTreeView = new System.Windows.Forms.TreeView();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.startConditionEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.twitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.emailContentConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openLogFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reloadConditionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clearConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.propertyInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.donateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.activeMatchesLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.activeMatchesList = new System.Windows.Forms.ListBox();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// console
			// 
			this.console.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.console.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.console.Location = new System.Drawing.Point(329, 43);
			this.console.Name = "console";
			this.console.ReadOnly = true;
			this.console.Size = new System.Drawing.Size(557, 342);
			this.console.TabIndex = 0;
			this.console.Text = "";
			this.console.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.ConsoleLinkClicked);
			// 
			// conditionTreeView
			// 
			this.conditionTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.conditionTreeView.Location = new System.Drawing.Point(12, 43);
			this.conditionTreeView.Name = "conditionTreeView";
			treeNode1.Name = "conditionsNode";
			treeNode1.Text = "Conditions";
			treeNode2.Name = "emailSettingsNode";
			treeNode2.Text = "Email";
			treeNode3.Name = "radarSettingsNode";
			treeNode3.Text = "Radar";
			treeNode4.Name = "programSettingsNode";
			treeNode4.Text = "Program";
			treeNode5.Name = "settingsNode";
			treeNode5.Text = "Settings";
			treeNode6.Name = "Node0";
			treeNode6.Text = "Node0";
			treeNode7.Name = "Node1";
			treeNode7.Text = "Node1";
			treeNode8.Name = "Node2";
			treeNode8.Text = "Node2";
			treeNode9.Name = "Node3";
			treeNode9.Text = "Node3";
			treeNode10.Name = "statsNode";
			treeNode10.Text = "Statistics";
			this.conditionTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode5,
            treeNode10});
			this.conditionTreeView.Size = new System.Drawing.Size(312, 202);
			this.conditionTreeView.TabIndex = 1;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.reloadConditionsToolStripMenuItem,
            this.clearConsoleToolStripMenuItem,
            this.propertyInfoToolStripMenuItem,
            this.donateToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(898, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip";
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startConditionEditorToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.twitterToolStripMenuItem,
            this.emailContentConfigToolStripMenuItem,
            this.openLogFileToolStripMenuItem});
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.optionsToolStripMenuItem.Text = "Options";
			// 
			// startConditionEditorToolStripMenuItem
			// 
			this.startConditionEditorToolStripMenuItem.Name = "startConditionEditorToolStripMenuItem";
			this.startConditionEditorToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
			this.startConditionEditorToolStripMenuItem.Text = "Open Condition Editor";
			this.startConditionEditorToolStripMenuItem.Click += new System.EventHandler(this.startConditionEditorToolStripMenuItem_Click);
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
			this.settingsToolStripMenuItem.Text = "Settings";
			this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
			// 
			// twitterToolStripMenuItem
			// 
			this.twitterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAccountToolStripMenuItem,
            this.removeAccountToolStripMenuItem});
			this.twitterToolStripMenuItem.Name = "twitterToolStripMenuItem";
			this.twitterToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
			this.twitterToolStripMenuItem.Text = "Twitter";
			// 
			// removeAccountToolStripMenuItem
			// 
			this.removeAccountToolStripMenuItem.Name = "removeAccountToolStripMenuItem";
			this.removeAccountToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.removeAccountToolStripMenuItem.Text = "Remove Account";
			// 
			// addAccountToolStripMenuItem
			// 
			this.addAccountToolStripMenuItem.Name = "addAccountToolStripMenuItem";
			this.addAccountToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.addAccountToolStripMenuItem.Text = "Add Account";
			this.addAccountToolStripMenuItem.Click += new System.EventHandler(this.addAccountToolStripMenuItem_Click);
			// 
			// emailContentConfigToolStripMenuItem
			// 
			this.emailContentConfigToolStripMenuItem.Name = "emailContentConfigToolStripMenuItem";
			this.emailContentConfigToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
			this.emailContentConfigToolStripMenuItem.Text = "Email Content Config";
			this.emailContentConfigToolStripMenuItem.Click += new System.EventHandler(this.emailContentConfigToolStripMenuItem_Click);
			// 
			// openLogFileToolStripMenuItem
			// 
			this.openLogFileToolStripMenuItem.Name = "openLogFileToolStripMenuItem";
			this.openLogFileToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
			this.openLogFileToolStripMenuItem.Text = "Open log file";
			this.openLogFileToolStripMenuItem.Click += new System.EventHandler(this.openLogFileToolStripMenuItem_Click);
			// 
			// reloadConditionsToolStripMenuItem
			// 
			this.reloadConditionsToolStripMenuItem.Name = "reloadConditionsToolStripMenuItem";
			this.reloadConditionsToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
			this.reloadConditionsToolStripMenuItem.Text = "Reload Conditions";
			this.reloadConditionsToolStripMenuItem.Click += new System.EventHandler(this.ReloadConditionsToolStripMenuItemClick);
			// 
			// clearConsoleToolStripMenuItem
			// 
			this.clearConsoleToolStripMenuItem.Name = "clearConsoleToolStripMenuItem";
			this.clearConsoleToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
			this.clearConsoleToolStripMenuItem.Text = "Clear Console";
			this.clearConsoleToolStripMenuItem.Click += new System.EventHandler(this.clearConsoleToolStripMenuItem_Click);
			// 
			// propertyInfoToolStripMenuItem
			// 
			this.propertyInfoToolStripMenuItem.Name = "propertyInfoToolStripMenuItem";
			this.propertyInfoToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
			this.propertyInfoToolStripMenuItem.Text = "Property Info";
			this.propertyInfoToolStripMenuItem.Click += new System.EventHandler(this.propertyInfoToolStripMenuItem_Click);
			// 
			// donateToolStripMenuItem
			// 
			this.donateToolStripMenuItem.Name = "donateToolStripMenuItem";
			this.donateToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
			this.donateToolStripMenuItem.Text = "Donate";
			this.donateToolStripMenuItem.Click += new System.EventHandler(this.donateToolStripMenuItem_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activeMatchesLabel,
            this.statusLabel});
			this.statusStrip1.Location = new System.Drawing.Point(0, 392);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(898, 22);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// activeMatchesLabel
			// 
			this.activeMatchesLabel.Name = "activeMatchesLabel";
			this.activeMatchesLabel.Size = new System.Drawing.Size(91, 17);
			this.activeMatchesLabel.Text = "Active Matches:";
			// 
			// statusLabel
			// 
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(64, 17);
			this.statusLabel.Text = "Status: Idle";
			// 
			// activeMatchesList
			// 
			this.activeMatchesList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.activeMatchesList.FormattingEnabled = true;
			this.activeMatchesList.Location = new System.Drawing.Point(12, 251);
			this.activeMatchesList.Name = "activeMatchesList";
			this.activeMatchesList.Size = new System.Drawing.Size(311, 134);
			this.activeMatchesList.TabIndex = 4;
			// 
			// notifyIcon
			// 
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "PlaneAlerter";
			this.notifyIcon.Visible = true;
			this.notifyIcon.BalloonTipClicked += new System.EventHandler(this.notifyIcon_BalloonTipClicked);
			// 
			// PlaneAlerter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(898, 414);
			this.Controls.Add(this.activeMatchesList);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.conditionTreeView);
			this.Controls.Add(this.console);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "PlaneAlerter";
			this.Text = "PlaneAlerter";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlaneAlerterFormClosing);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private System.Windows.Forms.RichTextBox console;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem startConditionEditorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openLogFileToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripMenuItem clearConsoleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem propertyInfoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem emailContentConfigToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem donateToolStripMenuItem;
		public System.Windows.Forms.ToolStripStatusLabel activeMatchesLabel;
		public System.Windows.Forms.TreeView conditionTreeView;
		public System.Windows.Forms.ListBox activeMatchesList;
		public System.Windows.Forms.ToolStripStatusLabel statusLabel;
		public System.Windows.Forms.NotifyIcon notifyIcon;
		public System.Windows.Forms.ToolStripMenuItem reloadConditionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem twitterToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeAccountToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addAccountToolStripMenuItem;
	}
}
