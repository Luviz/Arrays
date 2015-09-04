using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays {
	class Program {
		static void Main(string[] args) {
			Stack<int> s = new Stack<int>();
			for (int i = 0 ; i < 10 ; i++)
				s.push(i);
			Console.WriteLine(s.peek());
			for (int i = 0 ; i < 10 ; i++)
				Console.WriteLine(s.pop());
			for (int i = 0; i < 15; i++)
				s.push(i);
			Console.WriteLine(s.peek());
			for (int i = 0; i < 10; i++)
				Console.WriteLine(s.pop());

			Console.WriteLine();
			Console.WriteLine(s.peek());

			Console.ReadKey();
		}
	}
}
