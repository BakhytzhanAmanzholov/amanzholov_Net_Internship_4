using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IQueueImpl;

[TestClass]
public class QueueTests
{
    [TestMethod]
    public void Enqueue_AddsItemToQueue()
    {
        Queue<int> queue = new Queue<int>();

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        Assert.AreEqual(1, queue.Peek());
    }

    [TestMethod]
    public void Dequeue_RemovesAndReturnsItemFromQueue()
    {
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("one");
        queue.Enqueue("two");
        queue.Enqueue("three");

        string item1 = queue.Dequeue();
        string item2 = queue.Dequeue();
        string item3 = queue.Dequeue();

        Assert.AreEqual("one", item1);
        Assert.AreEqual("two", item2);
        Assert.AreEqual("three", item3);
    }

    [TestMethod]
    public void Peek_ReturnsItemFromQueueWithoutRemoving()
    {
        Queue<char> queue = new Queue<char>();
        queue.Enqueue('A');
        queue.Enqueue('B');
        queue.Enqueue('C');

        char item1 = queue.Peek();
        char item2 = queue.Peek();
        char item3 = queue.Peek();

        Assert.AreEqual('A', item1);
        Assert.AreEqual('A', item2);
        Assert.AreEqual('A', item3);
    }

    [TestMethod]
    public void Remove_RemovesSpecifiedValueFromQueue()
    {
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        queue.Remove(2);

        Assert.AreEqual(1, queue.Dequeue());
        Assert.AreEqual(3, queue.Dequeue());
    }

    [TestMethod]
    public void Remove_ThrowsExceptionIfValueNotFound()
    {
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("one");
        queue.Enqueue("two");
        queue.Enqueue("three");

        Assert.ThrowsException<ArgumentException>(() => queue.Remove("four"));
    }
}