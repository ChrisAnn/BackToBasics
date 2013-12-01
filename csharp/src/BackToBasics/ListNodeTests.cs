using NUnit.Framework;

namespace BackToBasics
{
	[TestFixture]
	public class ListNodeTests
	{
		[Test]
		public void Node_should_contain_value()
		{
			var node = new ListNode<int>(12);
			Assert.That(node.Value, Is.EqualTo(12));
		}

		[Test]
		public void Node_should_contain_reference_to_next_node()
		{
			var node = new ListNode<int>(12);
			var nextNode = new ListNode<int>(42);

			node.Next = nextNode;
			Assert.That(node.Next, Is.EqualTo(nextNode));
		}
	}
}
