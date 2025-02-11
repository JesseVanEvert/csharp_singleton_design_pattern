Assignment: Implementing the Singleton Design Pattern in C#

Objective: The goal of this assignment is to understand and implement the Singleton Design Pattern in C#. You will learn how to ensure that only one instance of a class exists throughout the lifetime of the application, while providing a global point of access to that instance.
Assignment Tasks
Task 1: Implement the Singleton Class

Create a class Logger that follows the Singleton design pattern to ensure that only one instance of the Logger class exists.

    Requirements:
        The class should have a private static field to hold the single instance of Logger.
        The constructor must be private to prevent external instantiation.
        Create a public static method GetInstance() that returns the single instance of Logger. If the instance does not exist, it should create one.
        Implement a Log(string message) method that simulates logging by printing the message to the console, along with a timestamp.

Task 2: Thread Safety (Advanced)

To make sure the Logger class is thread-safe (to avoid multiple instances being created in a multi-threaded environment):

    Requirements:
        Ensure that the GetInstance() method is thread-safe. You can use techniques such as:
            Double-checked locking
            Lazy initialization
            Or other appropriate mechanisms
        Only one thread should be able to create the instance, and the rest of the threads should use the same instance.

Task 3: Testing Singleton Behavior

Write a Main() method to demonstrate the Singleton pattern.

    Requirements:
        Call Logger.GetInstance() multiple times and verify that each call returns the same instance.
        Log a few messages using the Logger.Log() method to demonstrate that all logs are coming from the same instance.

Task 4: Real-World Example Simulation (Optional)

Extend the assignment by simulating a real-world scenario where the Singleton pattern might be useful, such as:

    Logging System: A logger that logs events from different parts of the application but always uses the same instance.
    Configuration Manager: A configuration manager that reads settings from a file or environment variables, but ensures the same instance is used throughout the application.
    Database Connection Pooling: A class that handles a pool of database connections, ensuring the application only has one pool object.

Submission Requirements:

    Code Implementation: Submit your Logger class and any additional code files you created (e.g., configuration manager, database pool class).
    Documentation: Provide a brief explanation of how the Singleton design pattern works and how you ensured thread safety (if applicable).
    Test Cases: Include the Main() method that tests the Singleton behavior by creating multiple calls to GetInstance() and logging different messages.

Bonus Task: Enum Singleton (Optional)

In C#, an alternative way to create a Singleton is by using an enum. Try to implement a Singleton using an enum and compare the differences with your standard implementation.
Example Structure:

    Singleton Class: Implement a basic thread-safe Singleton with logging functionality.
    Thread-Safe Singleton: Ensure thread safety using locking mechanisms or lazy initialization.
    Test Class: Simulate logging or configuration management and verify Singleton behavior.
    Real-World Use Case (Optional): Simulate a real-world example using the Singleton pattern.

Hints & Tips:

    Make sure the constructor of your Logger class is private.
    The Singleton instance should be stored as a static field.
    Think carefully about how to handle thread safety. Simple locking mechanisms might work, but consider performance implications for heavily used Singletons.

This assignment will help you gain hands-on experience with one of the most widely used design patterns in software engineering.
