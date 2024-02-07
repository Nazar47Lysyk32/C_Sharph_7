using System;

class Stack<T>
{
    private T[] items;
    private int top; // Індекс верхнього елемента стеку

    public Stack(int capacity)
    {
        items = new T[capacity];
        top = -1; // Початкове значення індексу верхнього елемента
    }

    public void Push(T item)
    {
        if (top == items.Length - 1)
        {
            Console.WriteLine("Стек переповнений!");
            return;
        }

        items[++top] = item; // Збільшуємо індекс верхнього елемента та додаємо елемент у стек
    }

    public T Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Стек порожній!");
            return default(T);
        }

        return items[top--]; // Повертаємо верхній елемент та зменшуємо індекс верхнього елемента
    }

    public T Peek()
    {
        if (top == -1)
        {
            Console.WriteLine("Стек порожній!");
            return default(T);
        }

        return items[top]; // Повертаємо верхній елемент без видалення
    }
}

class Program
{
    static void Main()
    {
        // Тестування стеку з цілими числами
        Console.WriteLine("Тестування стеку з цілими числами:");
        Stack<int> intStack = new Stack<int>(5);
        intStack.Push(10);
        intStack.Push(20);
        intStack.Push(30);
        Console.WriteLine("Верхній елемент: " + intStack.Peek()); // 30
        Console.WriteLine("Видалено елемент: " + intStack.Pop()); // 30
        Console.WriteLine("Верхній елемент: " + intStack.Peek()); // 20

        // Тестування стеку з рядками
        Console.WriteLine("\nТестування стеку з рядками:");
        Stack<string> stringStack = new Stack<string>(3);
        stringStack.Push("one");
        stringStack.Push("two");
        stringStack.Push("three");
        Console.WriteLine("Верхній елемент: " + stringStack.Peek()); // three
        Console.WriteLine("Видалено елемент: " + stringStack.Pop()); // three
        Console.WriteLine("Верхній елемент: " + stringStack.Peek()); // two
    }
}
