using Microsoft.VisualStudio.TestTools.UnitTesting;


[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue items with different priorities and dequeue once.
    // Expected Result: The item with the highest priority (Avacado, 5) is returned.
    // Defect(s) Found: 
    public void TestPriorityQueue_HighestPriority()
    {
        var queue = new PriorityQueue();
        queue.Enqueue("Mango", 1);
        queue.Enqueue("Avacado", 5);
        queue.Enqueue("Apple", 3);

        var result = queue.Dequeue();
        Assert.AreEqual("Avacado", result);
    }

    [TestMethod]
    // Scenario: Enqueue multiple items with the same highest priority. Dequeue should follow FIFO for same priority.
    // Expected Result: "Racheal" (priority 4) should be returned before "Mary" (priority 4).
    // Defect(s) Found: 
    public void TestPriorityQueue_TieBreakerFIFO()
    {
        var queue = new PriorityQueue();
        queue.Enqueue("Racheal", 4);
        queue.Enqueue("Mary", 4);
        queue.Enqueue("Specy", 2);

        var result1 = queue.Dequeue();
        var result2 = queue.Dequeue();

        Assert.AreEqual("Racheal", result1);
        Assert.AreEqual("Mary", result2);
    }

    [TestMethod]
    // Scenario: Call Dequeue on an empty queue.
    // Expected Result: An InvalidOperationException with message "The queue is empty." should be thrown.
    // Defect(s) Found: 
    public void TestPriorityQueue_Empty()
    {
        var queue = new PriorityQueue();

        try
        {
            queue.Dequeue();
            Assert.Fail("Expected exception was not thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }
}