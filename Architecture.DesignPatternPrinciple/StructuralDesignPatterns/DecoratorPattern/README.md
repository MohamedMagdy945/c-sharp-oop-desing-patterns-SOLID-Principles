# Decorator Design Pattern

## What is the Decorator Pattern?
The **Decorator Pattern** is a **structural design pattern** that allows behavior to be added to individual objects, dynamically, without affecting the behavior of other objects from the same class.

> In simple terms:  
> "Wrap an object to add new behavior without changing its code."

---

## Purpose
- Add responsibilities to objects at runtime.  
- Avoid class explosion from using inheritance for every combination of features.  
- Promote flexible and reusable code.  
- Extend behavior without modifying existing classes.  
- Combine multiple behaviors dynamically.  

---

## Why the Decorator Pattern is Important
- **Flexibility**: Behaviors can be added or removed dynamically.  
- **Open/Closed Principle**: Extend functionality without modifying existing code.  
- **Reusability**: Decorators can be reused across different objects.  
- **Maintainability**: Keeps classes focused and small.  
- **Combining Features**: Multiple decorators can be stacked on one object.  

---

## How the Decorator Pattern Works
The pattern typically includes:

1. **Component Interface**
   - Declares operations that can be dynamically added to objects.  

2. **Concrete Component**
   - Implements the component interface.  
   - Provides default behavior.  

3. **Decorator (Abstract)**
   - Implements the component interface.  
   - Maintains a reference to a component object.  
   - Delegates operations to the component.  

4. **Concrete Decorators**
   - Extend the decorator to add new behavior before or after delegating to the component.  

5. **Client**
   - Uses component objects wrapped with decorators.  
   - Interacts with them through the component interface.  

When a client calls a method, the decorator can execute additional behavior before or after forwarding the request to the underlying component.

---

## When to Use the Decorator Pattern
- When you want to add responsibilities to objects dynamically.  
- When subclassing would lead to an explosion of classes.  
- When behaviors should be added transparently to the client.  
- When you want flexible combinations of features.  
- When extending functionality without modifying original code.  

---

## Advantages
- Supports dynamic behavior addition.  
- Avoids class explosion from inheritance.  
- Promotes code reusability.  
- Enhances flexibility and maintainability.  
- Can combine multiple decorators to create complex behavior.  

---

## Disadvantages
- Can lead to many small classes.  
- Can make code more complex and harder to debug.  
- Lots of layers may make understanding the flow difficult.  

---

## Real-World Examples
- GUI frameworks: adding scrollbars, borders, or colors to widgets.  
- I/O streams in Java: BufferedReader, InputStreamReader, FileReader.  
- Logging and monitoring functionalities.  
- Adding discounts or bonuses in e-commerce objects.  
- Text formatting: bold, italic, underline dynamically applied.  

---

## Key Points
- Part of **Structural Design Patterns**.  
- Adds responsibilities dynamically without modifying original objects.  
- Uses composition instead of inheritance.  
- Supports flexible and reusable behavior extension.  
- Client interacts with decorated objects transparently.
