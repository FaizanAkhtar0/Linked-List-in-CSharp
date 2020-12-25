using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_Implementation {
    class Node<T> {

        private T data;
        private Node<T> nextNode;

        public Node(T t, T data) {
            this.data = data;
        }

        public T getData() {
            return this.data;
        }

        public void setData(T data) {
            this.data = data;
        }

        public String ToString() {
            return this.data.ToString();
        }

        public Node<T> getNextNode() {
            return this.nextNode;
        }

        public void setNextNode(Node<T> node) {
            this.nextNode = node;
        }
    }
}
