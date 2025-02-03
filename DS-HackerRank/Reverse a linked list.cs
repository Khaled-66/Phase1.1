static SinglyLinkedListNode reverse(SinglyLinkedListNode llist)
{
    SinglyLinkedListNode reversed_list = null;
    SinglyLinkedListNode temp = llist;
    while (temp != null)
    {
        SinglyLinkedListNode n1 = new SinglyLinkedListNode(temp.data);
        n1.next = reversed_list;
        reversed_list = n1;
        temp = temp.next;
    }
    return reversed_list;
}