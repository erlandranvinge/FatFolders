﻿using System;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FatFolders.Forms
{
	public partial class ProcessingDialog : Form
	{
		private string _path;
		private FatFoldersResult _result;

		public ProcessingDialog(string path, FatFoldersResult result)
		{
			_path = path;
			_result = result;
			InitializeComponent();
		}

		private void SearchWorkerDoWork(object sender, DoWorkEventArgs e)
		{
			var worker = sender as BackgroundWorker;

			var path = e.Argument as string;
			if (string.IsNullOrEmpty(path) || !Directory.Exists(path))
				return;

			SearchWorker.ReportProgress(0, "Enumerating folders...");
			var folders = SafeWalker.GetFolders(path);
			SearchWorker.ReportProgress(0, string.Format("Processing folders 0/{0}...", folders.Count));

			int processed = 0;
			float total = folders.Count;
			int statusInterval = folders.Count / 100;
			if (worker.CancellationPending)
				return;

			Parallel.For(0L, folders.Count, i =>
			{
				if (worker.CancellationPending)
					return;

				var folder = ProcessFolder(folders[(int)i]);
				if (folder.Size > 0)
					_result.Add(folder);

				Interlocked.Add(ref processed, 1);

				if (statusInterval > 0 && processed % statusInterval == 0)
					SearchWorker.ReportProgress((int)((processed / total) * 100.0), "Processing folders (" + processed + "/" + total + ")...");
			});

			SearchWorker.ReportProgress((int)((processed / total) * 100.0), "Sorting folders...");
			_result.Sort();
		}

		private FatFolder ProcessFolder(string path)
		{
			try
			{
				var files = Directory.EnumerateFiles(path, "*", SearchOption.TopDirectoryOnly).GetEnumerator();
				long size = 0;
				for (; ; )
				{
					try
					{
						if (!files.MoveNext())
							break;


						size += (new FileInfo(files.Current)).Length;
					}
					catch (UnauthorizedAccessException)
					{
						/* Allow to skip files when counting */
					}
				}
				return new FatFolder(path, size);
			}
			catch (UnauthorizedAccessException)
			{
				return new FatFolder(path, 0);
			}
		}

		private void SearchWorkerProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
		{
			SearchProgressBar.Value = e.ProgressPercentage;
			if (e.UserState is string)
			{
				SearchProgressStatusLabel.Text = e.UserState as string;
			}
			if (!CancelSearchButton.Enabled)
				CancelSearchButton.Enabled = true;
		}

		private void SearchWorkerRunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{
			SearchProgressStatusLabel.Text = "Ready";
			SearchProgressBar.Enabled = false;
			SearchProgressBar.Value = 0;
			SearchProgressStatusLabel.Enabled = false;
			CancelSearchButton.Enabled = false;
			Close();
		}

		private void CancelSearchButtonClick(object sender, EventArgs e)
		{
			CancelSearchButton.Enabled = false;
			SafeWalker.Cancel();
			SearchWorker.CancelAsync();
		}

		private void ProcessingDialogVisibleChanged(object sender, EventArgs e)
		{
			if (!SearchWorker.IsBusy)
				SearchWorker.RunWorkerAsync(_path);

		}
	}
}
