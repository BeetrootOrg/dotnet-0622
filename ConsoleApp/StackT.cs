namespace ConsoleApp;

/*
реализовать СТЕК 
стек это структура данных в которой элементы этой структуры лежат как книжки одна на другой, вертикально а не горизонтально как обычный лист.. э это соответсвенно накладывет кое какие особенности по работе с ним.
например нельзя извлечь элимент с серидины, или добавить в середину.. добавить можно только на самый верх..  ну и тд.
добавить элеимент можно только медодом Push, он добавит элемент наверх.
удалить можно только верхний - метод нахзывается Pop

*/
public class Stack<T>
{
    
    private record ListItem
    {
        public T Value { get; init; }
        public ListItem Next { get; set; }
    }

    private ListItem _head;
    public int Length { get; private set; }

    

       // void Push(obj) - adds obj at the top of stack
        //T Pop() - returns top element of stack & removes it
        //void Clear() - clear stack

    //int Count - property return number of elements

    //T Peek() - returns top element but doesn’t remove it

    //void CopyTo(arr) - copies stack to array

}