namespace FatFolders.Forms
{
	partial class ProcessingDialog
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
			this.CancelSearchButton = new System.Windows.Forms.Button();
			this.SearchProgressStatusLabel = new System.Windows.Forms.Label();
			this.SearchProgressBar = new System.Windows.Forms.ProgressBar();
			this.SearchWorker = new System.ComponentModel.BackgroundWorker();
			this.SuspendLayout();
			// 
			// CancelSearchButton
			// 
			this.CancelSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CancelSearchButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelSearchButton.Enabled = false;
			this.CancelSearchButton.Location = new System.Drawing.Point(472, 86);
			this.CancelSearchButton.Name = "CancelSearchButton";
			this.CancelSearchButton.Size = new System.Drawing.Size(110, 30);
			this.CancelSearchButton.TabIndex = 7;
			this.CancelSearchButton.Text = "&Cancel";
			this.CancelSearchButton.UseVisualStyleBackColor = true;
			this.CancelSearchButton.Click += new System.EventHandler(this.CancelSearchButtonClick);
			// 
			// SearchProgressStatusLabel
			// 
			this.SearchProgressStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SearchProgressStatusLabel.Enabled = false;
			this.SearchProgressStatusLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SearchProgressStatusLabel.Location = new System.Drawing.Point(12, 55);
			this.SearchProgressStatusLabel.Name = "SearchProgressStatusLabel";
			this.SearchProgressStatusLabel.Size = new System.Drawing.Size(570, 18);
			this.SearchProgressStatusLabel.TabIndex = 6;
			this.SearchProgressStatusLabel.Text = "Ready";
			this.SearchProgressStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// SearchProgressBar
			// 
			this.SearchProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SearchProgressBar.Enabled = false;
			this.SearchProgressBar.Location = new System.Drawing.Point(12, 23);
			this.SearchProgressBar.Name = "SearchProgressBar";
			this.SearchProgressBar.Size = new System.Drawing.Size(570, 29);
			this.SearchProgressBar.TabIndex = 5;
			// 
			// SearchWorker
			// 
			this.SearchWorker.WorkerReportsProgress = true;
			this.SearchWorker.WorkerSupportsCancellation = true;
			this.SearchWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SearchWorkerDoWork);
			this.SearchWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.SearchWorkerProgressChanged);
			this.SearchWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.SearchWorkerRunWorkerCompleted);
			// 
			// ProcessingDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.CancelSearchButton;
			this.ClientSize = new System.Drawing.Size(594, 128);
			this.ControlBox = false;
			this.Controls.Add(this.CancelSearchButton);
			this.Controls.Add(this.SearchProgressStatusLabel);
			this.Controls.Add(this.SearchProgressBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "ProcessingDialog";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Processing Fat Folders...";
			this.VisibleChanged += new System.EventHandler(this.ProcessingDialogVisibleChanged);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button CancelSearchButton;
		private System.Windows.Forms.Label SearchProgressStatusLabel;
		private System.Windows.Forms.ProgressBar SearchProgressBar;
		private System.ComponentModel.BackgroundWorker SearchWorker;
	}
}