OCP: 
    states "software entities (classes, modules, functions, etc.) should be open for extension, but closed for modification.


Scenario 

We need to build a Products List
Where : 
* client should be able filter product on different parameters  an item
* client can ask for another/new filter on any property of product

There is Bad way which is violating OCP of doing this : check Bad_Way.cs

and proper way which does not violate OCP is being used in OCP_Client.cs