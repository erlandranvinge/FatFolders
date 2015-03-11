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
			this.CancelSearchButton.Location = new System.Drawing.Point(944, 165);
			this.CancelSearchButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.CancelSearchButton.Name = "CancelSearchButton";
			this.CancelSearchButton.Size = new System.Drawing.Size(220, 58);
			this.CancelSearchButton.TabIndex = 7;
			this.CancelSearchButton.Text = "&Cancel";
			this.CancelSearchButton.UseVisualStyleBackColor = true;
			this.CancelSearchButton.Click += new System.EventHandler(this.CancelSearchButtonClick);
			// 
			// SearchProgressStatusLabel
			// 
			this.SearchProgressStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SearchProgressStatusLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SearchProgressStatusLabel.Location = new System.Drawing.Point(24, 106);
			this.SearchProgressStatusLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.SearchProgressStatusLabel.Name = "SearchProgressStatusLabel";
			this.SearchProgressStatusLabel.Size = new System.Drawing.Size(1140, 35);
			this.SearchProgressStatusLabel.TabIndex = 6;
			this.SearchProgressStatusLabel.Text = "Ready";
			this.SearchProgressStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// SearchProgressBar
			// 
			this.SearchProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SearchProgressBar.Location = new System.Drawing.Point(24, 44);
			this.SearchProgressBar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.SearchProgressBar.Name = "SearchProgressBar";
			this.SearchProgressBar.Size = new System.Drawing.Size(1140, 56);
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
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.CancelSearchButton;
			this.ClientSize = new System.Drawing.Size(1188, 246);
			this.ControlBox = false;
			this.Controls.Add(this.CancelSearchButton);
			this.Controls.Add(this.SearchProgressStatusLabel);
			this.Controls.Add(this.SearchProgressBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.Name = "ProcessingDialog";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Processing potentially Fat Folders...";
			this.Shown += new System.EventHandler(this.ProcessingDialogShown);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button CancelSearchButton;
		private System.Windows.Forms.Label SearchProgressStatusLabel;
		private System.Windows.Forms.ProgressBar SearchProgressBar;
		private System.ComponentModel.BackgroundWorker SearchWorker;
	}
}