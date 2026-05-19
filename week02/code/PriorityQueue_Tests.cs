using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
     [TestMethod]
// Scenario: Higher priority should be removed first
// Expected Result: B
// Defect(s) Found: Priority ordering incorrect in Dequeue
public void TestPriorityQueue_HighestPriorityFirst()
{
    var pq = new PriorityQueue();

    pq.Enqueue("A", 1);
    pq.Enqueue("B", 5);
    pq.Enqueue("C", 3);

    var result = pq.Dequeue();

    Assert.AreEqual("B", result);
}
     [TestMethod]
// Scenario: Same priority should follow FIFO order
// Expected Result: A
// Defect(s) Found: Tie-breaking not implemented correctly
public void TestPriorityQueue_FifoTieBreaker()
{
    var pq = new PriorityQueue();

    pq.Enqueue("A", 5);
    pq.Enqueue("B", 5);
    pq.Enqueue("C", 5);

    var result = pq.Dequeue();

    Assert.AreEqual("A", result);
}

    // Add more test cases as needed below.
    [TestMethod]
// Scenario: Dequeue on empty queue
// Expected Result: InvalidOperationException
// Defect(s) Found: Empty check missing or incorrect message handling
public void TestPriorityQueue_EmptyException()
{
    var pq = new PriorityQueue();

    try
    {
        pq.Dequeue();
        Assert.Fail("Exception expected");
    }
    catch (InvalidOperationException e)
    {
        Assert.AreEqual("The queue is empty.", e.Message);
    }
}
}