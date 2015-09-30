using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays {
	public class Stack<T> where T : IComparable {
		//private Node<T> root;
		private Node<T> head;

		public Stack(){
			head = null;
			//root = head;	// Ihope this is a shallow copy!!!
		}
		public Stack(T item) {
			head = new Node <T>(item);
			//root = head
		}

		public void push(T item) {
			if (head == null) {
				head = new Node<T>(item);
			}
			else {
				Node<T> tmpNode = new Node<T>(item);
				tmpNode.addLeaf(head);
				head = tmpNode;
			}
		}

		public T pop() {
			T ret = head.item;
			if (head.leaves.Any()) {
				head = head.leaves[0];
			}
			return ret;
		}

		public T peek() {
			return head.item;
		}
	}
}
