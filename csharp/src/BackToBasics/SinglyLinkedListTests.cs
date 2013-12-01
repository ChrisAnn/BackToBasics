using NUnit.Framework;

namespace BackToBasics
{
	[TestFixture]
    public class SinglyLinkedListTests
    {
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
}
