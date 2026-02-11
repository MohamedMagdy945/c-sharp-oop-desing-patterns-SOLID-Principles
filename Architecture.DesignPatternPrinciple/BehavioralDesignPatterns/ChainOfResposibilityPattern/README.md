# Chain of Responsibility Design Pattern

## What is the Chain of Responsibility Pattern?
The **Chain of Responsibility Pattern** is a **behavioral design pattern** that allows a request to pass through a chain of handlers. Each handler decides either to process the request or pass it to the next handler in the chain.

> In simple terms:  
> "A request moves through a chain of handlers until one handles it."

---

## Purpose
- Decouple sender and receiver of a request.  
- Allow multiple objects to handle a request.  
- Process requests dynamically at runtime.  
- Avoid large conditional statements.  
- Create flexible and extensible processing chains.  

---

## Why the Chain of Responsibility Pattern is Important
- **Loose Coupling**: Sender doesn't know who handles the request.  
- **Flexibility**: Handlers can be added or removed easily.  
- **Single Responsibility**: Each handler handles one task.  
- **Extensibility**: Easy to introduce new handlers.  
- **Cleaner Code**: Reduces complex if/else logic.  

---

## How the Chain of Responsibility Pattern Works
The pattern typically includes:

1. **Handler Interface**
   - Defines method to handle request.  
   - Contains reference to next handler.  

2. **Concrete Handlers**
   - Implement handler interface.  
   - Process request if able.  
   - Otherwise pass request to next handler.  

3. **Client**
   - Creates and links handlers together.  
   - Sends request to first handler in chain.  

A request travels through the chain until a handler processes it or the chain ends.

---

## When to Use the Chain of Responsibility Pattern
- When multiple objects can handle a request.  
- When handler is not known in advance.  
- When you want dynamic request processing.  
- When avoiding complex conditional logic.  
- When building pipelines or middleware systems.  

---

## Advantages
- Reduces coupling between sender and receiver.  
- Flexible and dynamic request handling.  
- Easy to add or remove handlers.  
- Follows single responsibility principle.  
- Improves maintainability.  

---

## Disadvantages
- Request may go unhandled.  
- Debugging chain flow can be difficult.  
- Can affect performance with long chains.  
- Hard to guarantee which handler will process.  

---

## Real-World Examples
- Customer support escalation systems.  
- Middleware pipelines in web frameworks.  
- Event handling systems.  
- Approval workflows.  
- Logging systems with levels (info, warning, error).  

---

## Key Points
- Part of **Behavioral Design Patterns**.  
- Passes request through chain of handlers.  
- Promotes loose coupling.  
- Supports dynamic request handling.  
- Reduces complex conditional logic.
