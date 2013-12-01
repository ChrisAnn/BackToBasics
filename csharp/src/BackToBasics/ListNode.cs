namespace BackToBasics
{
	public class ListNode<T>
	{
		public int Value { get; set; }

		public ListNode<T> Next { get; set; }

		public ListNode(int value)
		{
			Value = value;
		}
	}
}