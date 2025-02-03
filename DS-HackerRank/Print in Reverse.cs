public static void reversePrint(SinglyLinkedListNode llist)
{
    SinglyLinkedListNode temp = llist;
    Stack<int> ints = new Stack<int>();
    while (temp != null)
    {
        ints.Push(temp.data);
        temp = temp.next;
    }
    while (ints.Count > 0)
    {
        Console.WriteLine(ints.Pop());
    }

}