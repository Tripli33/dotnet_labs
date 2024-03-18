*in progress*
# Lab2: Working with WPF
## Task:
Describe a desktop application based on the proposed entities.
For more correct and optimal operation, implement the repository pattern: create a repository for each table and place there all methods for working with this table from the database (CRUD).  And also implement special queries.

Use a WPF template, demonstrate the CRUD-operations.

## Entities:
| **Dishes** | **Customer** |  **Orders** |
|------------|--------------|-------------|
| ID         | ID           | ID          |
| Name       | Name         | Dish ID     |
| Price      | Address      | Customer ID |
| Weight     | Phone        | Quantity    |
|            | Sale         | PaymentType |
|            |              | Order Date  |
|            |              | Price       |

## Special queries:
- Print a list of customers who ordered a given dish, indicating their  sales. 
- Print the list of dishes whose price is higher than the specified one.
- Print a list of dishes with the amount of his order.  
- Print a list of customers, indicating their average number of ordered dishes.

## Implementation:
The [API](https://github.com/Tripli33/dotnet_labs/tree/api) is used as the backend.

## Key-technologies:
WPF, Entity Framework Core, MySQL
