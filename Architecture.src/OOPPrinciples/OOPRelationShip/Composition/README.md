# Composition in Object-Oriented Programming (OOP)

## What is Composition?
Composition is a **strong has-a relationship** where one object **owns and manages** the lifecycle of another object.  
The child object **cannot exist without** the parent.

> "Objects are part of a whole."

---

## Key Characteristics
- Strong ownership
- Dependent lifecycle
- High encapsulation
- Strong structural coupling

---

## Design Intent
Composition is used to model **part-of relationships** where objects are tightly bound to the parent.

---

## When to Use Composition
- When objects represent integral parts of a whole
- When the child should not exist independently
- When strong encapsulation is required
- When modeling internal structure

---

## Advantages
- Clear ownership and responsibility
- Strong encapsulation
- Safer internal design
- Easier to reason about object lifecycles

---

## Limitations
- Less flexible than aggregation
- Tighter coupling
- Requires careful design to avoid rigidity

---

## Summary
Composition is the strongest object relationship and should be used when **lifecycle dependency and ownership are essential**.
