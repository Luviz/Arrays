using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays {
	
	public class Node <T> where T : IComparable{

		private T _item;
		private Node<T> _root;
		private List<Node<T>> _leaves;

		public T item { get { return _item; } set { _item = value; } }
		public Node<T> root { get { return _root; } set { _root = value; } }
		public List<Node<T>> leaves { get { return _leaves; } set { _leaves = value; } }

		/**
			sets all to null
		*/
		public Node() {
			item = default(T);
			root = null;
			_leaves = null;
		}

		/**
			root and leaves are sett to null
			item will be set 
		*/
		public Node(T item) {
			this.item = item;
			root = null;
			leaves = new List<Node<T>>();
		}

		/**
			item and a root a set
			leave are set to null
		*/
		public Node(T item, Node<T> root) {
			this.item = item;
			this.root = root;
			leaves = new List<Node<T>>();
		}

		/**
			set all 
		*/
		public Node(T item, Node <T> root, List<Node<T>> leaves) {
			this.item = item;
			this.root = root;
            this.leaves = leaves;
		}	

		public void addLeaf (Node <T> leaf) {
			leaves.Add(leaf);
		}
		
	}
}
