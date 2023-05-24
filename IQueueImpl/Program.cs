/*
    1) In the Queue<T> class, a linked list is used as the data structure to store the elements of the queue. 
        Each node in the linked list represents an item in the queue, 
        and the Next pointer links the nodes together to maintain the order.
    3) 
        1) Quickly access the n element in the queue. The array is obtained in O(1), 
            and our data structure in O(n)
        2) Memory, the array consumes less memory than our data structure.
        3) Insertion or deletion in certain positions, in the array it is faster.
 */

using IQueueImpl;

public class Application
{
    public static void main()
    {
        IQueue<int> queue = new IQueueImpl.Queue<int>();
        queue.Enqueue(5);
        queue.Enqueue(6);
        queue.Enqueue(7);
        System.Console.WriteLine(queue.ToString());
        queue.Dequeue();
        queue.Dequeue();
        System.Console.WriteLine(queue.ToString());
    }
}