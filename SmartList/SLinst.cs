using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartList {

	class Person{
		public string FName { get; set; }
		public string LName { get; set; }

		public Person(string fName) {
			FName = fName;
			LName = "";
		}
		public Person(string fName, string lName) {
			FName = fName;
			LName = lName;
		}

		public override string ToString() {
			return string.Format("{0} {1}", FName, LName);
		}

	}

	class run {
		public static void Main(string[] args) {
			List<Person> sl = new List<Person>();
			sl.Add(new Person("Bardia", "Jedi"));
			sl.Add(new Person("Tim", "MacBraid"));
			sl.Add(new Person("James", "Jackson"));
			sl.Add(new Person("Tom", "Clancy"));
			sl.Add(new Person("Mik", "Miaclson"));

			Func <Person, bool> findFName = (p) => p.FName == "James";
			bool b = sl.Any(findFName);
			Console.WriteLine(b);

			Person x = sl.Find(p => p.FName == "James" );
			Console.WriteLine("{0,2} - Person : {1}", sl.IndexOf(x), x);

			string keyName = "Jedi";
			// this is a Lambda Expertion	 p => p.LName == keyName
			Predicate<Person> findLastName = p => p.LName == keyName;
			Person y = sl.Find(findLastName);

			//output x and y
			Console.WriteLine("{0,2} - Person : {1}", sl.IndexOf(y), y);
			

			//predifind Names
			List<Person> persons = sl.FindAll(p => (p.FName == "Bardia") || (p.FName == "James" )|| (p.FName == "Mik"));

			//useing a list of items As loang as the list have GetEnumerator it works fine
			string[] lNames = { "Jedi", "MacBraid", "Jackson" };
			List<Person> persons1 = sl.FindAll(p => lNames.Contains(p.LName));

			//print persoins
			Console.WriteLine();
			foreach (Person p in persons) {
				Console.WriteLine("{0,2} - Person : {1}", sl.IndexOf(p), p);
			}
			//print persons 1
			Console.WriteLine();
			foreach (Person p in persons1) {
				Console.WriteLine("{0,2} - Person : {1}", sl.IndexOf(p), p);
			}

			Console.WriteLine();
			//Lambda style ForEach
			persons1.ForEach(p => Console.WriteLine("{0,2} - Person : {1}",sl.IndexOf(p),p));
			Console.ReadLine();
		}
	}

}
