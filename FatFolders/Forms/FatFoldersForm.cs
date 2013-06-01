using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace FatFolders.Forms
{
	public partial class FatFoldersForm : Form
	{
		private readonly FatFoldersResult _result = new FatFoldersResult();

		public FatFoldersForm()
		{
			InitializeComponent();
		}

		private void FoldersListViewRetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
		{
			var folder = _result[e.ItemIndex];
			e.Item = new ListViewItem(new[] { folder.Path, Utils.FormatSize(folder.Size) });
		}

		private void AddFoldersButtonClick(object sender, EventArgs e)
		{
			var dlg = new FolderBrowserDialog();
			dlg.Description = "Select a root folder to start processing fat folders.";
			var result = dlg.ShowDialog(this);
			if (result == DialogResult.OK && !string.IsNullOrEmpty(dlg.SelectedPath) && Directory.Exists(dlg.SelectedPath))
			{
				var processingDialog = new ProcessingDialog(dlg.SelectedPath, _result);
				processingDialog.ShowDialog(this);
				FoldersListView.VirtualListSize = _result.Count;
				TotalSizeValueLabel.Text = Utils.FormatSize(_result.TotalSize);
			}
		}

		private void FoldersListClearClick(object sender, EventArgs e)
		{
			_result.Clear();
			FoldersListView.VirtualListSize = 0;
			TotalSizeValueLabel.Text = Utils.FormatSize(_result.TotalSize);
		}

		private void FoldersListViewMouseDoubleClick(object sender, MouseEventArgs e)
		{
			var list = sender as FoldersListView;
			if (list == null || list.SelectedIndices.Count <= 0)
				return;
			var item = _result[list.SelectedIndices[0]];
			Process.Start(item.Path);
		}
	}
}
