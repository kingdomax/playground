namespace FizzBuzzQuestion.Medium
{
    /*
        Reverse a singly linked list.

        Input: 1->2->3->4->5->NULL
        Output: 5->4->3->2->1->NULL
     */
    public static class ReverseLinkedList
    {
        public static ListNode Solution(ListNode head)
        {
            // 0) handle
            if (head == null) { return head; }
            
            // 1) utilize two pointer which are previous and next, to store value
            // 2) running throug linklist by 'current' pointer
            ListNode previous = null;
            ListNode current = head;
            while (current.Next != null)
            {
                var next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }
            
            // 3) set the last one
            current.Next = previous;
            
            return current;
        }
    }

    public class ListNode
    {
        public ListNode(int x) => Value = x;
        public int Value { get; }
        public ListNode Next { get; set; }
    }
}