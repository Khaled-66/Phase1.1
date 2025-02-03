static SinglyLinkedListNode insertNodeAtPosition(SinglyLinkedListNode llist, int data, int position)
{
    SinglyLinkedListNode n1 = new SinglyLinkedListNode(data);
    if (llist == null)
    {
        return n1;
    }
    else
    {
        SinglyLinkedListNode temp = llist;
        for (int i = 0; i < position - 1 && temp != null; i++)
        {
            temp = temp.next;
        }
        n1.next = temp.next;
        temp.next = n1;

    }
    return llist;
}