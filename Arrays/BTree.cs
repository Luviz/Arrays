using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays {
	class BTree<T> where T : IComparable{

		enum Walk{ LEFT, RIGHT };

		private Node<T> walker;
		private Node<T> root;

		private List<T> output;

		public BTree() {
			root = null;
			walker = null;
		}

		/**
		* A new node vill be created for item:T
		**/
		public BTree(T item) {
			root = new BNode<T>(item);
			walker = null;
		}

		/**
		* the node will referd to the root!
		**/
		public BTree(BNode<T> node) {
			root = node;
			walker = null;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="item"></param>
		public void Add(T item) {
			Add(new BNode<T>(item));
		}

		public void Add(BNode<T> newNode) {
			//walker = node;
			if (root != null) {

				bool keepRuning = true;
				walker = root;
				while (keepRuning) {
					//Console.WriteLine(root.leaves.Any());
					//root > node
					if (walker.item.CompareTo(newNode.item) >= 0) {	
						Console.WriteLine("root.item.CompareTo(node.item) >= 0");		//DEBUG
						//go Left;
						if(walker.leaves[(int)Walk.LEFT] != null) {
							//go deeper!
							walker = walker.leaves[(int)Walk.LEFT];
						}
						else {
							//add new leaf
							newNode.root = walker;	// adding root
							walker.leaves[(int)Walk.LEFT] = newNode;	//setting leaf
							keepRuning = false;		//ending prosses
							
						}

                    }
					//root < node
					else {	
						Console.WriteLine("!(root.item.CompareTo(node.item) >= 0)");	//DEBUG
						//go right
						if (walker.leaves[(int)Walk.RIGHT] != null) {
							//go deeper!
							walker = walker.leaves[(int)Walk.RIGHT];
						}
						else {
							//add new leaf
							newNode.root = walker;
							walker.leaves[(int)Walk.RIGHT] = newNode;
							keepRuning = false;
						}
					}
					
				}
			}
			else {
				root = newNode;
			}
		}
		/**
		*	dose Left Root Right reading of the tree
		**/
	
		public List<T> Read() {
			List<T> ret = new List<T>();
			walker = root;
			//gose as left as posseble
			/*while (walker.leaves[(int)Walk.LEFT] != null) {
				walker = walker.leaves[(int)Walk.LEFT];
			}*/
			while (walker.leaves[(int)Walk.RIGHT] != null ) {
				
				while (walker.leaves[(int)Walk.LEFT] != null) {
					walker = walker.leaves[(int)Walk.LEFT];
				}
				ret.Add(walker.item);
				walker = root;
				ret.Add(walker.item);
				walker = walker.leaves[(int)Walk.RIGHT];
			}
			return ret;
		}

		public void LRR() {
			walker = root;
			TLeft();
			TRoot();
			TRight();
		}

		public T TLeft() {
			Console.WriteLine(walker.item);
			if (walker.leaves[(int)Walk.LEFT] != null) {
				walker = walker.leaves[(int)Walk.LEFT];
				TLeft();
			}
			else {
				
				return walker.item;
			}
			
			return default(T);
		}

		public T TRoot() {
			Console.WriteLine(walker.item);
			if (walker.root !=null) {
				walker = walker.root;
				return walker.item; 
			}
			return default (T);
		}

		public T TRight() {
			Console.WriteLine(walker.item);
			if (walker.leaves[(int)Walk.LEFT] != null) {
				walker = walker.leaves[(int)Walk.LEFT];
				TLeft();
			}
			else {
				
				return walker.item;
			}
			
			return default(T);
		}

	}
}
