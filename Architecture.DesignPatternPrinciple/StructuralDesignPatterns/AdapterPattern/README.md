# Adapter Design Pattern

## What is the Adapter Pattern?
The **Adapter Pattern** is a **structural design pattern** that allows objects with incompatible interfaces to work together by converting the interface of one class into an interface expected by the client.

> In simple terms:  
> "Make two incompatible interfaces compatible."

---

## Purpose
- Enable collaboration between incompatible interfaces.  
- Allow existing classes to be reused without modification.  
- Simplify integration of third-party or legacy code.  
- Promote flexibility and decoupling.  
- Encapsulate conversion logic in a single place.

---

## Why the Adapter Pattern is Important
- **Reusability**: Integrate existing components easily.  
- **Flexibility**: Works with multiple incompatible interfaces.  
- **Loose Coupling**: Clients depend on the expected interface, not the adaptee.  
- **Maintainability**: Changes are isolated in the adapter class.  
- **Integration**: Facilitates use of external libraries or systems.

---

## How the Adapter Pattern Works
The pattern typically includes:

1. **Target Interface**
   - Defines the interface expected by the client.  

2. **Adaptee**
   - The existing class with an incompatible interface.  
   - Contains useful functionality that needs to be adapted.  

3. **Adapter**
   - Implements the target interface.  
   - Holds a reference to the adaptee.  
   - Converts client requests into calls to the adaptee.

4. **Client**
   - Works with the target interface.  
   - Unaware of the adaptee’s implementation details.

When the client calls a method on the adapter, the adapter translates it to the adaptee’s interface and executes the corresponding functionality.

---

## When to Use the Adapter Pattern
- When you want to use an existing class but its interface does not match what the client expects.  
- When integrating third-party or legacy components.  
- When you want to decouple client and service implementations.  
- When creating reusable libraries or frameworks.  

---

## Advantages
- Promotes code reusability.  
- Enables integration with incompatible interfaces.  
- Reduces code duplication.  
- Improves flexibility in large systems.  
- Encapsulates conversion logic in one place.

---

## Disadvantages
- Can increase code complexity if overused.  
- Adds an extra layer of abstraction.  
- Too many adapters can make the system hard to maintain.  

---

## Real-World Examples
- Power plug adapters (physical world analogy).  
- Converting different file formats (e.g., CSV to JSON).  
- Wrapping legacy APIs to work with new systems.  
- Database connectors for different database types.  
- Adapting third-party payment gateways to a standard interface.

---

## Key Points
- Part of **Structural Design Patterns**.  
- Converts incompatible interfaces to a compatible one.  
- Promotes reuse and flexibility.  
- Encapsulates interface conversion logic.  
- Allows clients to interact with legacy or third-party classes seamlessly.
