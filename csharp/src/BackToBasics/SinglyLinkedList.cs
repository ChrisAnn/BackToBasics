namespace BackToBasics
{
	public class SinglyLinkedList<T>
	{
		public Node<T> Head { get; private set; }

		public SinglyLinkedList(Node<T> node)
		{
			Head = node;
		}

		public int Length
		{
			get { return 0; }
		}
	}
}