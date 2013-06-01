using System;

namespace FatFolders
{
	public static class Utils
	{
		public static string FormatSize(long size)
		{
			string[] suffixes = { "B", "KB", "MB", "GB", "TB", "PB", "EB" };
			if (size == 0)
				return "N/A";
			var bytes = Math.Abs(size);
			var place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
			var num = Math.Round(bytes / Math.Pow(1024, place), 1);
			return (Math.Sign(size) * num) + suffixes[place];
		}
	}
}
