# Command Design Pattern

## What is the Command Pattern?
The **Command Pattern** is a **behavioral design pattern** that turns a request into an object, allowing you to parameterize clients with different requests, queue or log requests, and support undo/redo operations.

> In simple terms:  
> "Encapsulate a request as an object so it can be executed later or stored."

---

## Purpose
- Encapsulate a request into an object.  
- Decouple sender from receiver.  
- Support undo and redo operations.  
- Enable request queuing and logging.  
- Allow flexible and extensible command execution.  

---

## Why the Command Pattern is Important
- **Loose Coupling**: Sender and receiver are independent.  
- **Undo/Redo Support**: Commands can be stored and reversed.  
- **Queue & Scheduling**: Commands can be delayed or queued.  
- **Extensibility**: Easy to add new commands.  
- **Flexibility**: Commands can be combined or logged.  

---

## How the Command Pattern Works
The pattern typically includes:

1. **Command Interface**
   - Declares method for executing a command.  
   - Often includes undo operation.  

2. **Concrete Command**
   - Implements command interface.  
   - Binds receiver and action together.  
   - Executes action on receiver.  

3. **Receiver**
   - Performs the actual work.  
   - Contains business logic.  

4. **Invoker**
   - Sends command to be executed.  
   - May store commands for history, queue, or undo.  

5. **Client**
   - Creates and configures command objects.  
   - Assigns receiver to command.  

When a request is made, the invoker triggers a command object, which then calls the receiver to perform the action.

---

## When to Use the Command Pattern
- When you want to parameterize objects with operations.  
- When you need undo/redo functionality.  
- When implementing queues or scheduling tasks.  
- When logging operations for history.  
- When decoupling sender from receiver.  

---

## Advantages
- Decouples sender and receiver.  
- Supports undo/redo operations.  
- Easy to add new commands.  
- Supports macro commands.  
- Enables request logging and queuing.  

---

## Disadvantages
- Increases number of classes.  
- Can make system more complex.  
- May require extra memory for storing commands.  
- Harder to understand for beginners.  

---

## Real-World Examples
- Remote control systems.  
- GUI button actions.  
- Task scheduling systems.  
- Transaction systems with undo.  
- Queue and job processing systems.  

---

## Key Points
- Part of **Behavioral Design Patterns**.  
- Encapsulates request as object.  
- Supports undo, redo, queue, and logging.  
- Decouples sender from receiver.  
- Improves flexibility and extensibility.
