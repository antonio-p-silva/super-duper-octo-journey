# super-duper-octo-journey

Extend primitive types to show intent - create meaningful types to express domain concepts. 

The idea behind these extensions is to provide a simple way to create types that represent business domain concepts.

## Example:

You have a function that expects a `customer name` as input, you could do the following:

```
public void IsCustomerAllowed(string customerName) {
  ...
 }
 ```
 
 It's simple and may work, but does a string fully represents a `customer name`? Can you make sure that what you actually send is a `customer name` ?
 
 One of the biggest software challanges is showing intent. Domain Driven Design help us showing intent and one key advantage is to map domain concepts into code. 
 In this example, `customer name` is a domain concept, so you could create a type CustomerName. Like so:
 
 ```
 public class CustomerName : MeaningfulString {
  
  public CustomerName(string value) : base(value) {}
  
 }
 ```
 
 Then you can replace the previous function to:
 ```
 public void IsCustomerAllowed(CustomerName customerName) {
  ...
 }
 ```
 
 Like so, your code doesn't compile if you don't send a `CustomerName` type.
 
 ## Meaningful types available
 
 1. string 
 2. short
 3. int 
 4. long
 
 ## Operators available for meaninful types
 
 1. `==`
 2. `!=`
 
 All numeric operators (short, int, long) have `Add`, `Subtract`, `Multiply` and `Divide` extensions.
