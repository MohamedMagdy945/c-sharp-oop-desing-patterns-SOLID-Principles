# Template Method Design Pattern

## What is the Template Method Pattern?
The **Template Method Pattern** is a **behavioral design pattern** that defines the skeleton of an algorithm in a base class, while allowing subclasses to override specific steps without changing the overall structure.

> In simple terms:  
> "Define the steps of an algorithm, but let subclasses customize some steps."

---

## Purpose
- Define a fixed algorithm structure in a base class.  
- Allow subclasses to implement or override certain steps.  
- Promote code reuse by keeping common logic in one place.  
- Ensure consistent workflow while allowing customization.

---

## Why the Template Method Pattern is Important
- **Code Reuse**: Common logic is written once in the base class.  
- **Consistency**: Ensures all subclasses follow the same algorithm structure.  
- **Flexibility**: Subclasses can customize specific steps.  
- **Maintainability**: Changes to the algorithm structure happen in one place.  
- **Supports Open/Closed Principle**: New variations can be added without modifying existing code.

---

## How the Template Method Pattern Works
The pattern usually includes:

1. **Abstract/Base Class**
   - Defines the template method (algorithm skeleton).  
   - Contains common logic shared by all subclasses.  
   - Declares abstract or optional methods for subclasses to implement.  

2. **Template Method**
   - Defines the sequence of steps for the algorithm.  
   - Calls abstract or overridable methods for specific steps.  

3. **Concrete Subclasses**
   - Implement or override specific steps of the algorithm.  
   - Customize behavior without changing the structure.

The algorithm structure remains fixed while specific behaviors can vary.

---

## When to Use the Template Method Pattern
- When multiple classes share the same algorithm structure.  
- When some steps of an algorithm need customization.  
- When you want to avoid code duplication.  
- When you want to enforce a consistent process across subclasses.

---

## Advantages
- Promotes code reuse and reduces duplication.  
- Maintains a consistent algorithm structure.  
- Simplifies maintenance and updates.  
- Allows controlled customization of behavior.

---

## Disadvantages
- May increase number of classes.  
- Changes to the base template can affect all subclasses.  
- Can be rigid if too many steps are fixed.

---

## Real-World Examples
- Data processing pipelines with fixed steps.  
- Authentication systems with different login methods.  
- Game development (game loop structure).  
- Report generation systems.  

---

## Key Points
- Part of **Behavioral Design Patterns**.  
- Defines algorithm structure in a base class.  
- Allows subclasses to customize specific steps.  
- Promotes reuse, consistency, and maintainability.  
