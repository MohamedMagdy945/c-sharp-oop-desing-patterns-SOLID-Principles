# Observer Design Pattern

## What is the Observer Pattern?
The **Observer Pattern** is a **behavioral design pattern** that defines a one-to-many relationship between objects, so that when one object changes its state, all its dependents are notified and updated automatically.

> In simple terms:  
> "When one object changes, all related objects are notified."

---

## Purpose
- Establish communication between objects in a loosely coupled way.  
- Automatically notify multiple objects when one object changes.  
- Maintain consistency between related objects.  
- Support event-driven systems.

---

## Why the Observer Pattern is Important
- **Loose Coupling**: Subject and observers are independent of each other.  
- **Automatic Updates**: Observers are notified automatically when changes occur.  
- **Scalability**: Easy to add or remove observers.  
- **Flexibility**: Supports dynamic relationships between objects.  
- **Maintainability**: Reduces direct dependencies between components.

---

## How the Observer Pattern Works
The pattern typically includes:

1. **Subject (Publisher)**
   - Maintains a list of observers.  
   - Sends notifications when its state changes.  
   - Provides methods to attach or detach observers.  

2. **Observer Interface**
   - Defines an update method for receiving notifications.  

3. **Concrete Observers(Subscriper)**
   - Implement the observer interface.  
   - Receive and respond to updates from the subject.  

When the subject changes its state, it notifies all registered observers automatically.

---

## When to Use the Observer Pattern
- When multiple objects need to react to state changes of another object.  
- When implementing event-driven systems.  
- When building notification or subscription systems.  
- When you want to maintain consistency across related objects.

---

## Advantages
- Promotes loose coupling between objects.  
- Supports dynamic subscription and unsubscription.  
- Makes systems more flexible and scalable.  
- Simplifies broadcast communication.

---

## Disadvantages
- Large number of observers may affect performance.  
- Notifications can become complex in large systems.  
- Debugging may be harder due to indirect communication.

---

## Real-World Examples
- Notification systems (email, SMS, push notifications).  
- Event systems in GUI frameworks.  
- Stock market price updates.  
- Social media feeds and subscriptions.  

---

## Key Points
- Part of **Behavioral Design Patterns**.  
- Defines one-to-many dependency between objects.  
- Enables automatic notification and updates.  
- Supports event-driven and loosely coupled systems.  
