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

		[Test]
		public void Finds_node_with_given_value()
		{
			var expectedNode = new ListNode<int>(42);
			var head = new ListNode<int>(12) { Next = new ListNode<int>(77) {Next = expectedNode} };
			var list = new SinglyLinkedList<int>(head);

			Assert.That(list.Find(42), Is.EqualTo(expectedNode));
		}

		[Test]
		public void Does_not_find_value_which_is_not_in_the_list()
		{
			var expectedNode = new ListNode<int>(42);
			var head = new ListNode<int>(12) { Next = new ListNode<int>(77) { Next = expectedNode } };
			var list = new SinglyLinkedList<int>(head);

			Assert.Null(list.Find(99));
		} 

	}
}
