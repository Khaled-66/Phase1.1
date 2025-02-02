static SinglyLinkedListNode insertNodeAtTail(SinglyLinkedListNode head, int data)
{
    SinglyLinkedListNode s1 = new SinglyLinkedListNode(data);
    SinglyLinkedListNode temp = head;
    if (head == null)
    {
        return s1;
    }
    else
    {
        while (temp.next != null)
        {
            temp = temp.next;
        }
        temp.next = s1;
        return head;
    }
}
