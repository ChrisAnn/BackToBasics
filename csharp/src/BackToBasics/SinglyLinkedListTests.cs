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

		[Test]
		public void Create_empty_List()
		{
			var list = new SinglyLinkedList<int>(null);
			Assert.That(list.Length, Is.EqualTo(0));
		}

		[Test]
		public void Create_list_with_single_node()
		{
			var node = new Node<int>(12);
			var list = new SinglyLinkedList<int>(node);
			Assert.That(list.Head, Is.EqualTo(node));
		}
	}

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
