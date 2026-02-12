# Proxy Design Pattern

## What is the Proxy Pattern?
The **Proxy Pattern** is a **structural design pattern** that provides a surrogate or placeholder for another object to control access to it.

> In simple terms:  
> "Use a proxy object to control access to the real object."

---

## Purpose
- Control access to an object.  
- Add functionality like lazy loading, caching, or logging.  
- Protect sensitive or expensive resources.  
- Decouple clients from real object implementation.  
- Provide a placeholder for complex or remote objects.  

---

## Why the Proxy Pattern is Important
- **Access Control**: Restricts access to the real object.  
- **Resource Management**: Loads expensive resources only when needed.  
- **Security**: Adds protection before delegating requests.  
- **Decoupling**: Client interacts with proxy, not the real object.  
- **Flexibility**: Proxy can add extra behavior transparently.  

---

## How the Proxy Pattern Works
The pattern typically includes:

1. **Subject Interface**
   - Defines common interface for real object and proxy.  
   - Ensures client can use proxy transparently.  

2. **Real Subject**
   - Implements the actual functionality.  
   - Performs the real work.  

3. **Proxy**
   - Implements the same interface as real subject.  
   - Controls access to the real subject.  
   - May add additional behavior (lazy loading, caching, logging).  

4. **Client**
   - Interacts with the subject through the interface.  
   - Unaware whether it is using a proxy or real object.  

When the client calls a method, the proxy can perform checks or additional operations before delegating the call to the real subject.

---

## When to Use the Proxy Pattern
- When access to an object needs to be controlled.  
- When the real object is resource-intensive or remote.  
- When adding functionality without modifying the real object.  
- When implementing lazy initialization.  
- When security or logging is required.  

---

## Advantages
- Adds a level of control over object access.  
- Reduces client dependency on real object.  
- Supports lazy initialization of resources.  
- Can implement additional functionalities transparently.  
- Simplifies client code.  

---

## Disadvantages
- Adds extra layer of abstraction.  
- Can increase complexity of system.  
- May introduce slight performance overhead.  

---

## Real-World Examples
- Virtual proxies for lazy loading images.  
- Remote proxies in distributed systems.  
- Protection proxies for access control.  
- Caching proxies for expensive computations.  
- Logging or auditing proxies.  

---

## Key Points
- Part of **Structural Design Patterns**.  
- Provides a surrogate for another object.  
- Controls access and adds extra behavior.  
- Client interacts with proxy transparently.  
- Useful for security, caching, lazy loading, and remote access.
