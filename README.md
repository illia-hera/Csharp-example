Simple C# code example


Extra task:
In the MS SQL Server database, there are products and categories. One product can correspond to many categories, and one category can contain many products. Write an SQL query to select all pairs of “Product Name – Category Name”. If a product has no categories, its name should still be displayed.

Solution:
select PT.Name
, CT.Name
from  Products as PT
left join ProductsCategories as PC on PT.Id = PC.ProductId
left join Categories as CT on PC.CategoryId = CT.Id
