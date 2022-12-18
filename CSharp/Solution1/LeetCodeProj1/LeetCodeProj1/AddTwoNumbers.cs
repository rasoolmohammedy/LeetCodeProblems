/*
 * https://leetcode.com/problems/add-two-numbers/
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProj1
{
    internal class AddTwoNumbers
    {
        static void Main(string[] args)
        {
            ListNode l1 = ConstructNode(342);
            ListNode l2 = ConstructNode(465);
            PrintNode(l1);
            PrintNode(l2);
            Solution s = new Solution();
            var answer = s.AddTwoNumbers(l1, l2);
            PrintNode(answer);
            Console.ReadKey();
        }

        static ListNode ConstructNode(int value)
        {
            ListNode l;
            ListNode temp = new ListNode();
            l = temp;
            while (value > 0)
            {
                temp.val = value % 10;
                value /= 10;
                if (value > 0)
                {
                    var temp2 = new ListNode();
                    temp.next = temp2;
                    temp = temp2;
                }
            }
            return l;
        }

        static void PrintNode(ListNode l)
        {
            Console.WriteLine("\nPrinting the List Node : ");
            while (l != null)
            {
                Console.Write(string.Format("{0}", l.val));
                l = l.next;
                if (l != null)
                    Console.Write(string.Format(" -> "));
            }
        }
    }


    //Definition for singly-linked list.
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

    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode answer;
            ListNode temp = new ListNode();
            answer = temp;
            while (true)
            {
                int summation = (l1.next == null ? 0 : l1.val) + (l2.next == null ? 0 : l2.val);
                if (summation > 9)
                {
                    temp.val = summation % 10;
                    ListNode temp2 = new ListNode();
                    temp2.val = 1;
                    temp.next = temp2;
                    temp = temp2;
                }
                else
                    temp.val = summation;
                if (l1.next == null && l2.next == null)
                    break;
                if (l1.next != null)
                    l1 = l1.next;
                if (l2.next != null)
                    l2 = l2.next;
                if (l1.next != null || l2.next != null)
                {
                    ListNode temp2 = new ListNode();
                    temp.next = temp2;
                    temp = temp2;
                }
            }
            return answer;
        }
    }

}
