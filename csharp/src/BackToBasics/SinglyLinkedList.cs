using System;

namespace BackToBasics
{
	public class SinglyLinkedList<T>
	{
		public ListNode<T> Head { get; private set; }

		public SinglyLinkedList(ListNode<T> listNode)
		{
			Head = listNode;
		}

		public int Length
		{
			get
			{
				if (Head == null)
					return 0;

				var count = 1;
				var node = Head;
				while (node.Next != null)
				{
					count++;
					node = node.Next;
				}
				return count;
			}
		}

		public ListNode<T> Find(T value)
		{
			var node = Head;
			while (node != null && !node.Value.Equals(value))
			{
				node = node.Next;
			}

			return node;
		}

		public void Append(ListNode<T> nodeToAppend)
		{
			if (Head == null)
			{
				Head = nodeToAppend;
				return;
			}

			var node = Head;
			while(node.Next != null)
			{
				node = node.Next;
			}

			node.Next = nodeToAppend;
		}

		public void Prepend(ListNode<T> nodeToPrepend)
		{
			var node = nodeToPrepend;
			while(node.Next != null)
			{
				node = node.Next;
			}
			node.Next = Head;

			Head = nodeToPrepend;
		}

		public void Remove(ListNode<T> nodeToRemove)
		{
			var node = Head;
			var previousNode = Head;
			while (node != null && !node.Value.Equals(nodeToRemove.Value))
			{
				previousNode = node;
				node = node.Next;
			}

			if (node == null)
				return;

			if (node == Head && previousNode == Head)
				Head = Head.Next;

			previousNode.Next = node.Next;
		}
	}
}