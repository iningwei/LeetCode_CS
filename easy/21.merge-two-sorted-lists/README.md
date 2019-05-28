#合并两个已排序的链表
## 题干
把两个已经排好序的链表合并为一个链表，最终的链表依旧有序且包含输入的两个链表中的所有元素。

已定义单链表结构如下:
```
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}
```
## 示例
输入：1->2->2>5, 2->3->5->7->9

输出：1->2->2->2->3->5->5->7->9

## 解答
假设输入链表分表为l1和l2，如下。
```
public ListNode MergeTwoLists(ListNode l1, ListNode l2)
{        
}
```
### 笔者解答
依次循环取l1和l2链表的元素，进行大小比较，把较小的放入目标链表中，并把对应链表指向移动到next节点。直到l1，l2有一个为null。同时还要考虑输入为null的情况。

代码如下：
```
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        ListNode result = null;
        ListNode header = null;
        if (l1 == null && l2 == null)
        {
            return null;
        }
        else if (l1 == null && l2 != null)
        {
            return l2;
        }
        else if (l1 != null && l2 == null)
        {
            return l1;
        }

        while (l1 != null && l2 != null)
        {
            if (l1.val < l2.val)
            {
                if (result == null)
                {
                    result = new ListNode(l1.val);
                    header = result;
                }
                else
                {
                    result.next = l1;
                    result = result.next;
                }
                l1 = l1.next;
            }
            else
            {
                if (result == null)
                {
                    result = new ListNode(l2.val);
                    header = result;
                }
                else
                {
                    result.next = l2;
                    result = result.next;
                }
                l2 = l2.next;
            }
        }
        if (l1 == null && l2 != null)
        {
            result.next = l2;
        }
        else if (l1 != null && l2 == null)
        {
            result.next = l1;
        }
        return header;
    }
```
案列测试结果统计:
```
√ Accepted
  √ 208/208 cases passed (100 ms)
  √ Your runtime beats 35.47 % of csharp submissions
  √ Your memory usage beats 21.74 % of csharp submissions (23.8 MB)
```
### 参考答案
#### 1.递归法
```
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        if (l1 == null)
        {
            return l2;
        }
        else if (l2 == null)
        {
            return l1;
        }

        if (l1.val < l2.val)
        {
            l1.next = MergeTwoLists(l1.next, l2);
            return l1;
        }
        else
        {
            l2.next = MergeTwoLists(l1, l2.next);
            return l2;
        }
    }
```
结果统计：
```
√ Accepted
  √ 208/208 cases passed (100 ms)
  √ Your runtime beats 35.47 % of csharp submissions
  √ Your memory usage beats 17.88 % of csharp submissions (23.8 MB)
```