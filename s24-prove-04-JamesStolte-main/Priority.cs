using System.Diagnostics;

namespace prove_04;

/*
 * CSE212 
 * (c) BYU-Idaho
 * 02-Prove - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 1");
        var players = new PriorityQueue();
        players.Enqueue("Bob", 2);
        players.Enqueue("Joe", 3);
        players.Enqueue("Sam", 1);
        Console.WriteLine("Priory queue is: ");
        Console.WriteLine(players.ToString());
        var result = players.Dequeue();
        Console.WriteLine(result);
        Trace.Assert(result == "Joe");
        result = players.Dequeue();
        Console.WriteLine(result);
        Trace.Assert(result == "Bob");
        result = players.Dequeue();
        Console.WriteLine(result);
        Trace.Assert(result == "Sam");
        // Defect(s) Found: Dequeue is not taking the highest priority item out of the queue.  No other problems were found outside of user error.

        Console.WriteLine("---------");

        // Test 2
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 2");

        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}