SRP :
    states that every module, class or function in a computer program should have responsibility over a single part of that program's functionality, and it should encapsulate that part.

Scenario 

We need to build a TodoList
with : 
* client should be able add an item
* client should be able to delete an item from the list.
* client should be able to save items permanently.

There is Bad way which is violating SRP of doing this : check Bad_Way.cs

and proper way which does not violate SRP is being used in SRP_Client.cs