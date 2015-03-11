using System;
using System.Collections.Concurrent;
using System.IO;
using System.Threading.Tasks;

namespace FatFolders
{
	public class ParallelWalk
	{
		private ConcurrentQueue<string> _items;

		public string[] GetFolders(string path)
		{
			_items = new ConcurrentQueue<string>();
			GetSubFolders(path);
			return _items.ToArray();
		}

		private void GetSubFolders(string path)
		{
			try
			{
				_items.Enqueue(path);
				var subFolders = Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly);
				Parallel.ForEach(subFolders, GetSubFolders);
			}
			catch (UnauthorizedAccessException) {}
			catch (PathTooLongException) {}
		}
	}
}
