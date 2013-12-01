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
			var node = new ListNode<int>(12);
			var list = new SinglyLinkedList<int>(node);
			Assert.That(list.Head, Is.EqualTo(node));
		}

		[Test]
		public void Length_return_number_of_items_in_list()
		{
			var head = new ListNode<int>(12) { Next = new ListNode<int>(77) };
			var list = new SinglyLinkedList<int>(head);

			Assert.That(list.Length, Is.EqualTo(2));
		}
	}
}
