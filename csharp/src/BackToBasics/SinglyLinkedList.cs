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
	}
}