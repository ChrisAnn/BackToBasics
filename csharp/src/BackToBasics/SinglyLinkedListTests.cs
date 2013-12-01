using NUnit.Framework;

namespace BackToBasics
{
	[TestFixture]
    public class SinglyLinkedListTests
    {
		[Test]
		public void Node_should_contain_value()
		{
			var node = new Node<int>(12);
			Assert.That(node.Value, Is.EqualTo(12));
		}

		[Test]
		public void Node_should_contain_reference_to_next_node()
		{
			var node = new Node<int>(12);
			var nextNode = new Node<int>(42);

			node.Next = nextNode;
			Assert.That(node.Next, Is.EqualTo(nextNode));
		}

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
