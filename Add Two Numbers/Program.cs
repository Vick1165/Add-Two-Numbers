internal class Program
{

    //https://leetcode.com/problems/add-two-numbers/
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

    private static void Main(string[] args)
    {
        var l1 = new ListNode();
        var l2 = new ListNode();
        l1.val = 2;
        l1.next = new ListNode
        {
            val = 4,
            next = new ListNode(3)
        };

        l2.val = 5;
        l2.next = new ListNode
        {
            val = 6,
            next = new ListNode(4)
        };

        var op = addTwoNumbers(l1, l2);
        Console.WriteLine(op);
        Console.ReadLine();
    }

    public static ListNode addTwoNumbers(ListNode l1, ListNode l2)
    {
        var prev = new ListNode(0);
        var head = prev;

        int carry = 0;

        while (l1 != null || l2 != null || carry != 0)
        {
            var cur = new ListNode(0);
            int sum = ((l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + carry);
            cur.val = sum % 10;
            carry = sum / 10;

            prev.next = cur;
            prev = prev.next;

            l1 = (l1 != null) ? l1.next : l1;
            l2 = (l2 != null) ? l2.next : l2;
        }
        return head.next;
    }
}