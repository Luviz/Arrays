using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace testRun {
	class Program {
		private int[] list;
		private int size;
		static void Main(string[] args) {
			//testting lists
			int[] l1 = { 1, 2, 3, 4, 5, 6, 7, 12, 52, 16 };
			//l1[l1.Length] = 15;
			foreach (int i in l1) {
				Console.WriteLine(i);
			}
			Console.WriteLine("l1 is over");

			String[] l2 = new String[5];
			l2[1] = "hello";
			l2[2] = "World";
			l2[4] = "22";

			Console.WriteLine(l2.Length);

			foreach (String i in l2) {
				Console.WriteLine(i);
			}
			Console.WriteLine();
			Console.WriteLine("l2 over");

			Program p = new Program();
			DateTime start = DateTime.Now;
			for (int i = 0; i < 26; i++) {
				p.add(i);
			}
			DateTime stop = DateTime.Now;
			Console.WriteLine(stop - start);

			//p.disp();

			List<int> l3 = new List<int>();
			l3.Add(3);
			l3.Add(15);

			Console.WriteLine("l3 is done");
			Console.Write("done ...");
			Console.ReadKey();
		}

		public Program() {
			size = 0;
			list = new int[5];
		}
		private void add(int value) {
			try {
				this.list[size] = value;
				size++;
			} catch (IndexOutOfRangeException iOORE) {
				int[] tList = new int[list.Length*2];
				for (int i = 0; i < size; i++)
					tList[i] = list[i];
				list = tList;
				add(value);
			}
		}
		private void disp() {
			foreach(int i in list) {
				Console.WriteLine(i);
			}
		}
	}
}
