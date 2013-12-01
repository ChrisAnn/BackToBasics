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
    }

	public class Node<T>
	{
		public int Value { get; set; }

		public Node(int value)
		{
			Value = value;
		}
	}
}
