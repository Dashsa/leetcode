public class LinkedListManager
{
    public void Works()
    {
        Console.WriteLine("linkedList");
    }

    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var result = new ListNode();
        var current = result;

        while (list1 != null && list2 != null)
        {
            var tempVal = 0;
            if (list1.val <= list2.val)
            {
                tempVal = list1.val;
                list1 = list1.next;
            }
            else
            {
                tempVal = list2.val;
                list2 = list2.next;
            }
            var newNode = new ListNode(tempVal);
            current.next = newNode;
            current = current.next;
        }
        // Attach the remaining nodes from the non-empty list
        current.next = list1 ?? list2;

        return result;
    }

    public class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}