using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppBinaryTree
{
    public class Node
    {
        public int value;
        public Node left;
        public Node right;

        public Node(int _value) 
        {
            value = _value;
            left = null;
            right = null;
        }
    }

    internal class BinarySearchTree
    {
        public Node root;

        public void Insert(int _value)
        {
            root = InsertRecursive(root, _value);
        }

        private Node InsertRecursive(Node current, int _value) 
        {
            if (current == null)
            {
                return new Node(_value);
            }

            if (_value < current.value)
            {
                current.left = InsertRecursive(current.left, _value);
            }
            else if (_value > current.value) 
            {
                current.right = InsertRecursive(current.right, _value);
            }

            return current;
        }

        public bool Contains(int _value)
        {
            return ContainsRecursive(root, _value);
        }

        private bool ContainsRecursive(Node current, int _value)
        {
            if (current == null)
            {
                return false;
            }
            if (_value == current.value) 
            {
                return true;
            }

            return _value < current.value ? ContainsRecursive(current.left, _value) : ContainsRecursive(current.right, _value);
        }

        public void BottomUpTraversal(Node current, List<int> result)
        {
            if(current == null)
            {
                return;
            }
            BottomUpTraversal(current.left, result);
            BottomUpTraversal(current.right, result);
            result.Add(current.value);
        }

        public Node FindNode(Node current, int value)
        {
            if (current == null)
            {
                return null;
            }
            if (current.value == value)
            {
                return current;
            } 

            var found = FindNode(current.left, value);

            if (found != null)
            {
                return found;
            }

            return FindNode(current.right, value);
        }

        public Node FindParent(Node current, int targetValue, Node parent = null)
        {
            if (current == null)
            {
                return null;
            }
            if (current.value == targetValue) 
            { 
                return parent;
            }

            var leftCheck = FindParent(current.left, targetValue, current);
            if (leftCheck != null)
            {
                return leftCheck;
            }

            return FindParent(current.right, targetValue, current);
        }

        public int? GetSecondEvenVertex()
        {
            List<int> allElements = new List<int>();
            BottomUpTraversal(root, allElements);

            int evenCount = 0;
            foreach (var val in allElements)
            {
                if (val % 2 == 0)
                {
                    evenCount++;
                    if (evenCount == 2)
                    {
                        return val;
                    }
                }
            }
            return null;
        }
    }
}
