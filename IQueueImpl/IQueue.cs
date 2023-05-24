using System.Text;

namespace IQueueImpl;

public interface IQueue<T>
{
    // Method to enqueue an item into the queue, new item gets to the end of the queue
    void Enqueue(T item);

    // Method to dequeue an first item from the queue
    T Dequeue();

    // Method to peek at the front item of the queue without removing it
    T Peek();

    // Method to remove the specified value from the queue
    void Remove(T value);

    // Method to check if the queue is empty
    bool IsEmpty();
}

public class Queue<T> : IQueue<T>
{
    private class Node<T>
    {
        internal T Value { get; }
        internal Node<T> Next { get; set; }

        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }

    private Node<T> _head;
    private Node<T> _tail;

    public Queue()
    {
        _head = null;
        _tail = null;
    }


    public bool IsEmpty()
    {
        return _head == null;
    }

    public void Enqueue(T item)
    {
        Node<T> newNode = new Node<T>(item);

        if (IsEmpty())
        {
            _head = newNode;
            _tail = newNode;
        }
        else
        {
            _tail.Next = newNode;
            _tail = newNode;
        }
    }

    public T Dequeue()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Queue is empty");
        }

        T item = _head.Value;
        _head = _head.Next;

        if (_head == null)
        {
            _tail = null;
        }

        return item;
    }

    public T Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Queue is empty");
        }

        return _head.Value;
    }

    public void Remove(T value)
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Queue is empty");
        }

        if (_head.Value.Equals(value))
        {
            _head = _head.Next;
            if (_head == null)
            {
                _tail = null;
            }

            return;
        }

        Node<T> current = _head;
        Node<T> previous = null;

        while (current != null && !current.Value.Equals(value))
        {
            previous = current;
            current = current.Next;
        }

        if (current == null)
        {
            throw new ArgumentException("Value not found in the queue");
        }

        previous.Next = current.Next;

        if (current == _tail)
        {
            _tail = previous;
        }
    }

    public override string ToString()
    {
        if (IsEmpty())
        {
            return "Queue is empty";
        }

        StringBuilder sb = new StringBuilder();
        Node<T> current = _head;

        while (current != null)
        {
            sb.Append(current.Value.ToString());
            if (current.Next != null)
            {
                sb.Append(", ");
            }

            current = current.Next;
        }

        sb.Append(';');
        return sb.ToString();
    }
}