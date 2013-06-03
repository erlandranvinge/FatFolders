using System;
using System.Collections.Generic;

namespace FatFolders
{
	public class FatFolder
	{
		public readonly string Path;
		public readonly long Size;

		public FatFolder(string path, long size)
		{
			Path = path;
			Size = size;
		}
	}

	public class FatFoldersResult
	{
		public long TotalSize { get; private set; }
		private readonly List<FatFolder> _folders;

		public FatFoldersResult()
		{
			_folders = new List<FatFolder>();
			TotalSize = 0;
		}

		public void Clear()
		{
			_folders.Clear();
			TotalSize = 0;
		}

		public void Add(FatFolder folder)
		{
			_folders.Add(folder);
			TotalSize += folder.Size;
		}

		public void Sort()
		{
			_folders.Sort((a, b) =>
			{
				if (a == null)
					return 1;
				if (b == null)
					return -1;
				return a.Size > b.Size ? -1 : 1;
			});
			//ParallelSort.QuicksortParallel(_folders, (a, b) => b.Size.CompareTo(a.Size));
		}

		public FatFolder this[int index]
		{
			get { return _folders[index];  }
		}

		public int Count
		{
			get { return _folders.Count; } 
		}
	}
}