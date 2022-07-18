namespace ConsoleApp;

class LinkedList<T>
{
    private record ListItem // create exempl one of list
    {
        public T Value { get; init}
        public ListItem Next {get; set}
    }
private ListItem _head;



}