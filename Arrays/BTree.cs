﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays {
	public class BTree<T> where T : IComparable {

		enum Walk { LEFT, RIGHT };

		private Node<T> walker;
		private Node<T> root;

		private List<T> output;

		public BTree() {
			root = null;
			walker = null;
		}

		/// <summary>
		/// Generate a Empty Tree
		/// </summary>
		/// <param name="item"></param>
		public BTree(T item) {
			root = new BNode<T>(item);
			walker = null;
		}

		/// <summary>
		/// Generate a Tree with root Node
		/// </summary>
		/// <param name="node"> Root Node </param>
		public BTree(BNode<T> node) {
			root = node;
			walker = null;
		}

		public List<T> GetOutput() {
			return output;
		}

		/// <summary>
		/// Add item in a node and adds it to the tree
		/// </summary>
		/// <param name="item"></param>
		public void Add(T item) {
			Add(new BNode<T>(item));
		}
		/// <summary>
		/// Adds the newNode to the Tree
		/// BST
		/// </summary>
		/// <param name="newNode"></param>
		public void Add(BNode<T> newNode) {
			//walker = node;
			if (root != null) {
				bool keepRuning = true;
				walker = root;
				while (keepRuning) {
					//root > node
					if (walker.item.CompareTo(newNode.item) >= 0) {
						//go Left;
						if (walker.leaves[(int)Walk.LEFT] != null) {
							//go deeper!
							walker = walker.leaves[(int)Walk.LEFT];
						}
						else {
							//add new leaf
							newNode.root = walker;  // adding root
							walker.leaves[(int)Walk.LEFT] = newNode;    //setting leaf
							keepRuning = false;     //ending prosses
						}
					}
					//root < node
					else {
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


		//TODO add a list in to the mix 
		//TODO learn about call by ref in oder to handel the list or just send the list along!

		/// <summary>
		///  preoder reading root left right
		/// </summary>			
		public void Preorder() {
			output = new List<T>();
			Preorder(root);
		}

		/// <summary>
		/// give a root to start preoder reading r l r
		/// </summary>
		/// <param name="root"></param>
		public void Preorder(Node<T> root) {
			if (root != null) {
				output.Add(root.item);
				Preorder(root.leaves[0]);   // leaves[0] is left root
				Preorder(root.leaves[1]);   // leaves[1] is right root 
			}
		}

		public void Inorder() {
			output = new List<T>();
			output.Clear();
			Inorder(root);
		}

		public void Inorder(Node<T> root) {
			if (root != null) {
				Inorder(root.leaves[0]);   // leaves[0] is left root
				output.Add(root.item);
				Inorder(root.leaves[1]);   // leaves[1] is right root
			}
		}
	}
}
