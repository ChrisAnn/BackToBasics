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
			get { return 0; }
		}
	}
}