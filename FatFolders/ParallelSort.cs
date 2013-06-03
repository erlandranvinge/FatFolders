using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FatFolders
{
	public static class ParallelSort
	{
		public static void QuicksortSequential<T>(List<T> list, Func<T, T, int> comparer) 
		{
			QuicksortSequential(list, 0, list.Count - 1, comparer);
		}

		public static void QuicksortParallel<T>(List<T> list, Func<T, T, int> comparer) 
		{
			QuicksortParallel(list, 0, list.Count - 1, comparer);
		}

		private static void QuicksortSequential<T>(List<T> list, int left, int right, Func<T, T, int> comparer)
		{
			if (right <= left) return;
			var pivot = Partition(list, left, right, comparer);
			QuicksortSequential(list, left, pivot - 1, comparer);
			QuicksortSequential(list, pivot + 1, right, comparer);
		}

		private static void QuicksortParallel<T>(List<T> list, int left, int right, Func<T, T, int> comparer)
		{
			const int sequentialThreshold = 2048;
			if (right <= left) return;
			if (right - left < sequentialThreshold)
			{
				QuicksortSequential(list, left, right, comparer);
			}
			else
			{
				var pivot = Partition(list, left, right, comparer);
				Parallel.Invoke(new Action[]
				{
					() => QuicksortParallel(list, left, pivot - 1, comparer),
					() => QuicksortParallel(list, pivot + 1, right, comparer)
				});
			}
		}

		private static void Swap<T>(List<T> list, int i, int j)
		{
			var tmp = list[i];
			list[i] = list[j];
			list[j] = tmp;
		}

		private static int Partition<T>(List<T> list, int low, int high, Func<T, T, int> comparer)
		{
			var pivotPos = (high + low)/2;
			var pivot = list[pivotPos];
			Swap(list, low, pivotPos);

			var left = low;
			for (var i = low + 1; i <= high; i++)
			{
				//if (list[i].CompareTo(pivot) >= 0) continue;
				if (list[i] == null || pivot == null) continue;
				if (comparer(list[i], pivot) >= 0) continue;
				left++;
				Swap(list, i, left);
			}
			Swap(list, low, left);
			return left;
		}
	}
}