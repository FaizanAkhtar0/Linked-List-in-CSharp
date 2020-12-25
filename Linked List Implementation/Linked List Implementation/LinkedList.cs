using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_Implementation
{
    class LinkedList<T> : List<T> {

        private Node<T> root;
        private int sizeOfList;

        public void insert(T data)
        {
            if (root == null) {
                root = new Node<>(T data);
            }
            else {

            }
        }

        public Node<T> remove(T data)
        {
            throw new NotImplementedException();
        }

        public Node<T> removeFirst()
        {
            throw new NotImplementedException();
        }

        public Node<T> removeLast()
        {
            throw new NotImplementedException();
        }

        public int size() {
            return this.sizeOfList;
        }

        public void traverse()
        {
            throw new NotImplementedException();
        }
    }
}
