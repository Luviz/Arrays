using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays {
	class Program {
		static void Main(string[] args) {

			int[] input = new int[] { 20, 5, 6, 1, 98, 6, 120, 7, 25, 32, 12, 16 };
			BTree<int> tree = new BTree<int>();
			foreach (int i in input) {
				tree.Add(i);
			}

			List<int> output = tree.Read();
			foreach (int i in output) {
				Console.WriteLine(i);
			}
			Console.WriteLine("done...");
			Console.ReadKey();
		}
	}
}
