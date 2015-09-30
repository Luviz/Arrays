using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test02 {
	class Program {
		static void Main(string[] args) {
			List<int> l = new List<int>();
			for (int i = 0; i < 100000000; i++) {
				l.Add(i);
			}
			Console.WriteLine("list genraded");
			int[] find = { 50, 2500, 50000000, 7800000, 98985400 };

			DateTime t;
			foreach (int check in find) {
				Console.WriteLine("Find: " + check);
				t = DateTime.Now;
				l.IndexOf(check);
				Console.WriteLine(DateTime.Now - t);
				t = DateTime.Now;
				IndexOf(check, l);
				Console.WriteLine(DateTime.Now - t);
				Console.WriteLine();
			}

			Console.ReadLine();
		}

		public static int IndexOf(int key, List<int> l) {
			int ret = -1;
			for (int i = 0; i < l.Count; i++)
				if (l[i] == key)
					return i;

			return ret;
		}
	}
}
