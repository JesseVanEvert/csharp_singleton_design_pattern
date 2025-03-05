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

