using System;
using System.Collections;
using System.Collections.Generic;

public class Deque<Item> : IEnumerable<Item>
{
    private Node first;
    private Node last;
    private int count;

    private class Node
    {
        public Item item;
        public Node next;
        public Node previous;
    }

    public Deque()
    {
        first = null;
        last = null;
        count = 0;
    }

    public bool IsEmpty()
    {
        return count == 0;
    }

    public int Size()
    {
        return count;
    }

    public void AddFirst(Item item)
    {
        if (item == null)
            throw new ArgumentNullException("Cannot add a null item.");

        Node newNode = new Node();
        newNode.item = item;

        if (IsEmpty())
        {
            first = newNode;
            last = newNode;
        }
        else
        {
            newNode.next = first;
            first.previous = newNode;
            first = newNode;
        }

        count++;
    }

    public void AddLast(Item item)
    {
        if (item == null)
            throw new ArgumentNullException("Cannot add a null item.");

        Node newNode = new Node();
        newNode.item = item;

        if (IsEmpty())
        {
            first = newNode;
            last = newNode;
        }
        else
        {
            newNode.previous = last;
            last.next = newNode;
            last = newNode;
        }

        count++;
    }

    public Item RemoveFirst()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Cannot remove an item from an empty deque.");

        Item item = first.item;

        if (count == 1)
        {
            first = null;
            last = null;
        }
        else
        {
            first = first.next;
            first.previous = null;
        }

        count--;
        return item;
    }

    public Item RemoveLast()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Cannot remove an item from an empty deque.");

        Item item = last.item;

        if (count == 1)
        {
            first = null;
            last = null;
        }
        else
        {
            last = last.previous;
            last.next = null;
        }

        count--;
        return item;
    }

    public IEnumerator<Item> GetEnumerator()
    {
        Node current = first;
        while (current != null)
        {
            yield return current.item;
            current = current.next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public class RandomizedQueue<Item> : IEnumerable<Item>
{
    private Item[] items;
    private int count;
    private Random random;

    public RandomizedQueue()
    {
        items = new Item[1];
        count = 0;
        random = new Random();
    }

    public bool IsEmpty()
    {
        return count == 0;
    }

    public int Size()
    {
        return count;
    }

    public void Enqueue(Item item)
    {
        if (item == null)
            throw new ArgumentNullException("Cannot enqueue a null item.");

        if (count == items.Length)
            ResizeArray(2 * items.Length);

        items[count++] = item;
    }

    public Item Dequeue()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Cannot dequeue an item from an empty randomized queue.");

        int randomIndex = random.Next(count);
        Item item = items[randomIndex];

        // Move the last item to the randomly selected index
        items[randomIndex] = items[count - 1];
        items[count - 1] = default(Item);

        count--;

        if (count > 0 && count == items.Length / 4)
            ResizeArray(items.Length / 2);

        return item;
    }

    public Item Sample()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Cannot sample an item from an empty randomized queue.");

        int randomIndex = random.Next(count);
        return items[randomIndex];
    }

    public IEnumerator<Item> GetEnumerator()
    {
        List<Item> shuffledItems = new List<Item>(items);
        Shuffle(shuffledItems);

        foreach (Item item in shuffledItems)
        {
            yield return item;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    private void ResizeArray(int capacity)
    {
        Item[] resizedArray = new Item[capacity];
        Array.Copy(items, resizedArray, count);
        items = resizedArray;
    }

    private void Shuffle(List<Item> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            Item value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Test Deque
        Deque<int> deque = new Deque<int>();
        deque.AddFirst(1);
        deque.AddLast(2);
        deque.AddFirst(3);
        deque.AddLast(4);

        Console.WriteLine("Deque:");
        foreach (int item in deque)
        {
            Console.WriteLine(item);
        }

        // Test RandomizedQueue
        RandomizedQueue<string> randomizedQueue = new RandomizedQueue<string>();
        randomizedQueue.Enqueue("A");
        randomizedQueue.Enqueue("B");
        randomizedQueue.Enqueue("C");
        randomizedQueue.Enqueue("D");

        Console.WriteLine("RandomizedQueue:");
        foreach (string item in randomizedQueue)
        {
            Console.WriteLine(item);
        }
    }
}