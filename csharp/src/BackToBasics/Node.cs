namespace BackToBasics
{
	public class Node<T>
	{
		public int Value { get; set; }

		public Node<T> Next { get; set; }

		public Node(int value)
		{
			Value = value;
		}
	}
}