static SinglyLinkedListNode deleteNode(SinglyLinkedListNode llist, int position)
{
    SinglyLinkedListNode temp = llist;
    if (position == 0)
    {
        llist = llist.next;
        return llist;
    }
    else
    {
        for (int i = 0; i < position - 1; i++)
        {
            temp = temp.next;
        }
        temp.next = temp.next.next;
        return llist;
    }
}