# Aggregation in Object-Oriented Programming (OOP)

## What is Aggregation?
Aggregation is a specialized form of association that represents a **weak has-a relationship**.  
The parent object groups child objects, but **does not control their lifecycle**.

> "Objects belong together, but can exist independently."

---

## Key Characteristics
- Weak ownership
- Child objects have independent lifecycles
- Represents logical grouping
- Moderate coupling

---

## Design Intent
Aggregation models situations where objects are **conceptually related** but not structurally dependent.

---

## When to Use Aggregation
- When modeling collections or containers
- When child objects are shared or reusable
- When lifecycle independence is required
- When ownership should not be enforced

---

## Advantages
- Promotes reuse of child objects
- Maintains flexibility
- Clear representation of grouping relationships
- Safer than composition when ownership is unclear

---

## Limitations
- Weaker encapsulation compared to composition
- Can be confused with association if not documented
- Does not enforce strong structural integrity

---

## Summary
Aggregation is useful for modeling **group relationships** while keeping objects independent and reusable.
