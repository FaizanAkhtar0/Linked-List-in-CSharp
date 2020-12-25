using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_Implementation
{
    interface List<T> {

        void insert(T data);
        void traverse();
        Node<T> removeLast();
        Node<T> removeFirst();
        Node<T> remove(T data);
        int size();
    }
}
