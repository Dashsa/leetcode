public class LinkedListManager
{
    public void Works()
    {
        Console.WriteLine("linkedList");
    }

    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var result = new ListNode();

        while (list1.next != null && list2.next != null)
        {
            if (list1.val <= list2.val)
            {
                result.val = list1.val;
                list1 = list1.next;
            }
            else
            {
                result.val = list2.val;
                list2 = list2.next;
            }


        }

        return result;
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}