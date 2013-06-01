using System;
using System.Runtime.InteropServices;

namespace FatFolders
{
	public class Native
	{
		public const int GWL_STYLE = -16;
		public const int WS_VSCROLL = 0x00200000;
		public const int WM_ERASEBKGND = 0x14;
		public const int WM_NCCALCSIZE = 0x83;

		public static int GetWindowLong(IntPtr hWnd, int nIndex)
		{
			if (IntPtr.Size == 4)
				return (int) GetWindowLong32(hWnd, nIndex);
			return (int) (long) GetWindowLongPtr64(hWnd, nIndex);
		}

		public static int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong)
		{
			if (IntPtr.Size == 4)
				return (int) SetWindowLongPtr32(hWnd, nIndex, dwNewLong);
			return (int) (long) SetWindowLongPtr64(hWnd, nIndex, dwNewLong);
		}

		[DllImport("user32.dll", EntryPoint = "GetWindowLong", CharSet = CharSet.Auto)]
		public static extern IntPtr GetWindowLong32(IntPtr hWnd, int nIndex);

		[DllImport("user32.dll", EntryPoint = "GetWindowLongPtr", CharSet = CharSet.Auto)]
		public static extern IntPtr GetWindowLongPtr64(IntPtr hWnd, int nIndex);

		[DllImport("user32.dll", EntryPoint = "SetWindowLong", CharSet = CharSet.Auto)]
		public static extern IntPtr SetWindowLongPtr32(IntPtr hWnd, int nIndex, int dwNewLong);

		[DllImport("user32.dll", EntryPoint = "SetWindowLongPtr", CharSet = CharSet.Auto)]
		public static extern IntPtr SetWindowLongPtr64(IntPtr hWnd, int nIndex, int dwNewLong);
	}
}