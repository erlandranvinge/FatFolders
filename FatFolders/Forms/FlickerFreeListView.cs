using System.Windows.Forms;

namespace FatFolders.Forms
{
	public class FoldersListView : ListView
	{
		public FoldersListView()
		{
			//Activate double buffering
			SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);

			//Enable the OnNotifyMessage event so we get a chance to filter out 
			// Windows messages before they get to the form's WndProc
			SetStyle(ControlStyles.EnableNotifyMessage, true);
		}

		protected override void OnNotifyMessage(Message m)
		{
			if (m.Msg != Native.WM_ERASEBKGND) 
				base.OnNotifyMessage(m);
		}

		protected override void OnResize(System.EventArgs e)
		{
			Columns[0].Width = (int) (0.9*(ClientSize.Width - 10));
			Columns[1].Width = -2;

			base.OnResize(e);
		}
	}
}