using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
[TestMethod]
// Scenario: Enqueue three items with priorities 1, 3, 2. Dequeue once.
// Expected Result: Item with priority 3 is removed first ("High").
// Defect(s) Found: Removes items in wrong order (doesn't respect highest priority).
public void TestPriorityQueue_1()
{
    var pq = new PriorityQueue();
    pq.Enqueue("Low", 1);
    pq.Enqueue("High", 3);
    pq.Enqueue("Mid", 2);

    var result = pq.Dequeue();
    Assert.AreEqual("High", result);
}


   [TestMethod]
// Scenario: Enqueue two items with same high priority. Dequeue once.
// Expected Result: The first inserted item is removed ("First").
// Defect(s) Found: Was removing the later one instead.
public void TestPriorityQueue_2()
{
    var pq = new PriorityQueue();
    pq.Enqueue("First", 5);
    pq.Enqueue("Second", 5);

    var result = pq.Dequeue();
    Assert.AreEqual("First", result);
}

}