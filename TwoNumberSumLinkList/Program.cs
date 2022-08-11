using System;

namespace TwoNumberSumLinkList
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var l1 = new ListNode(2)
            {
                Next = new ListNode(4)
                {
                    Next = new ListNode(3)
                }
            };
            
            var l2 = new ListNode(5)
            {
                Next = new ListNode(6)
                {
                    Next = new ListNode(4)
                }
            };
            
            ListNode result = AddTwoNumbers(l1, l2);
            while (result != null)
            {
                Console.WriteLine(result.Val);
                result = result.Next;
            }
        }

        private static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var dummy = new ListNode(0);

            var more = 0; //进位
            var pre = dummy;
            while (!(l1 is null) || l2 != null || more > 0)
            {
                var sum = (l1?.Val ?? 0) + (l2?.Val ?? 0) + more; //结果
                more = sum / 10;
                sum %= 10;

                var tempNode = new ListNode(sum);
                pre.Next = tempNode;
                pre = tempNode;
                l1 = l1?.Next;
                l2 = l2?.Next;
            }
            
            return dummy.Next;
        }
    }
}