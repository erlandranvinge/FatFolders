namespace FatFolders.Forms
{
	partial class FatFoldersForm
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
			this.AddFolderButton = new System.Windows.Forms.Button();
			this.TotalSizeValueLabel = new System.Windows.Forms.Label();
			this.TotalSizeLabel = new System.Windows.Forms.Label();
			this.ClearTopListButton = new System.Windows.Forms.Button();
			this.TopFatFoldersLabel = new System.Windows.Forms.Label();
			this.FoldersListView = new FoldersListView();
			this.PathColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SizeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// AddFolderButton
			// 
			this.AddFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.AddFolderButton.Location = new System.Drawing.Point(577, 304);
			this.AddFolderButton.Name = "AddFolderButton";
			this.AddFolderButton.Size = new System.Drawing.Size(110, 30);
			this.AddFolderButton.TabIndex = 12;
			this.AddFolderButton.Text = "Add Folders...";
			this.AddFolderButton.UseVisualStyleBackColor = true;
			this.AddFolderButton.Click += new System.EventHandler(this.AddFoldersButtonClick);
			// 
			// TotalSizeValueLabel
			// 
			this.TotalSizeValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.TotalSizeValueLabel.AutoSize = true;
			this.TotalSizeValueLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TotalSizeValueLabel.Location = new System.Drawing.Point(68, 304);
			this.TotalSizeValueLabel.Name = "TotalSizeValueLabel";
			this.TotalSizeValueLabel.Size = new System.Drawing.Size(29, 13);
			this.TotalSizeValueLabel.TabIndex = 11;
			this.TotalSizeValueLabel.Text = "N/A";
			// 
			// TotalSizeLabel
			// 
			this.TotalSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.TotalSizeLabel.AutoSize = true;
			this.TotalSizeLabel.Location = new System.Drawing.Point(12, 304);
			this.TotalSizeLabel.Name = "TotalSizeLabel";
			this.TotalSizeLabel.Size = new System.Drawing.Size(58, 13);
			this.TotalSizeLabel.TabIndex = 9;
			this.TotalSizeLabel.Text = "Total Size:";
			// 
			// ClearTopListButton
			// 
			this.ClearTopListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ClearTopListButton.Location = new System.Drawing.Point(693, 304);
			this.ClearTopListButton.Name = "ClearTopListButton";
			this.ClearTopListButton.Size = new System.Drawing.Size(110, 30);
			this.ClearTopListButton.TabIndex = 8;
			this.ClearTopListButton.Text = "Clear";
			this.ClearTopListButton.UseVisualStyleBackColor = true;
			this.ClearTopListButton.Click += new System.EventHandler(this.FoldersListClearClick);
			// 
			// TopFatFoldersLabel
			// 
			this.TopFatFoldersLabel.AutoSize = true;
			this.TopFatFoldersLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TopFatFoldersLabel.Location = new System.Drawing.Point(9, 9);
			this.TopFatFoldersLabel.Name = "TopFatFoldersLabel";
			this.TopFatFoldersLabel.Size = new System.Drawing.Size(109, 25);
			this.TopFatFoldersLabel.TabIndex = 7;
			this.TopFatFoldersLabel.Text = "Fat Folders";
			// 
			// FoldersListView
			// 
			this.FoldersListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FoldersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PathColumn,
            this.SizeColumn});
			this.FoldersListView.FullRowSelect = true;
			this.FoldersListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.FoldersListView.Location = new System.Drawing.Point(12, 37);
			this.FoldersListView.Name = "FoldersListView";
			this.FoldersListView.ShowGroups = false;
			this.FoldersListView.Size = new System.Drawing.Size(791, 261);
			this.FoldersListView.TabIndex = 10;
			this.FoldersListView.UseCompatibleStateImageBehavior = false;
			this.FoldersListView.View = System.Windows.Forms.View.Details;
			this.FoldersListView.VirtualMode = true;
			this.FoldersListView.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.FoldersListViewRetrieveVirtualItem);
			this.FoldersListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FoldersListViewMouseDoubleClick);
			// 
			// PathColumn
			// 
			this.PathColumn.Text = "Path";
			this.PathColumn.Width = 700;
			// 
			// SizeColumn
			// 
			this.SizeColumn.Text = "Size";
			this.SizeColumn.Width = 80;
			// 
			// FatFoldersForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(815, 346);
			this.Controls.Add(this.AddFolderButton);
			this.Controls.Add(this.TotalSizeValueLabel);
			this.Controls.Add(this.FoldersListView);
			this.Controls.Add(this.TotalSizeLabel);
			this.Controls.Add(this.ClearTopListButton);
			this.Controls.Add(this.TopFatFoldersLabel);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MinimumSize = new System.Drawing.Size(400, 200);
			this.Name = "FatFoldersForm";
			this.ShowIcon = false;
			this.Text = "Fat Folders";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button AddFolderButton;
		private System.Windows.Forms.Label TotalSizeValueLabel;
		private FoldersListView FoldersListView;
		private System.Windows.Forms.ColumnHeader PathColumn;
		private System.Windows.Forms.ColumnHeader SizeColumn;
		private System.Windows.Forms.Label TotalSizeLabel;
		private System.Windows.Forms.Button ClearTopListButton;
		private System.Windows.Forms.Label TopFatFoldersLabel;

	}
}

