static SinglyLinkedListNode insertNodeAtHead(SinglyLinkedListNode llist, int data)
{
    SinglyLinkedListNode temp = new SinglyLinkedListNode(data);
    temp.next = null;
    temp.next = llist;
    llist = temp;
    return temp;

}