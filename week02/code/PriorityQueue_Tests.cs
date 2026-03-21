using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario:Enqueue several items with different priorities and check if they are dequeued in the correct priority order.
    // Expected Result: first in, first out order (FIFO)
    // Defect(s) Found: Updated the priority queue so the comparison is flipped, ensuring higher-priority (more urgent) items are processed first.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Task A", 3);
        priorityQueue.Enqueue("Task B", 1);
        priorityQueue.Enqueue("Task C", 2);

        // Expected dequeue order: Task A, Task C, Task B
        Assert.AreEqual("Task A", priorityQueue.Dequeue());
        Assert.AreEqual("Task C", priorityQueue.Dequeue());
        Assert.AreEqual("Task B", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue multiple items with the same priority and verify they are dequeued in insertion order.
    // Expected Result: Items should follow FIFO order
    // Defect(s) Found: Initially failed, but fixed by adjusting the comparison operator so lower priority values are treated as more urgent
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("First", 1);
        priorityQueue.Enqueue("Second", 1);
        priorityQueue.Enqueue("Third", 1);

        // All same priority, expect FIFO order
        Assert.AreEqual("First", priorityQueue.Dequeue());
        Assert.AreEqual("Second", priorityQueue.Dequeue());
        Assert.AreEqual("Third", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.
}