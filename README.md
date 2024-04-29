Simple C# code example


Extra task:<br/>
In the MS SQL Server database, there are products and categories. One product can correspond to many categories, and one category can contain many products. Write an SQL query to select all pairs of “Product Name – Category Name”. If a product has no categories, its name should still be displayed.<br/>
<br/>
Solution:<br/>
select PT.Name<br/>
, CT.Name<br/>
from  Products as PT<br/>
left join ProductsCategories as PC on PT.Id = PC.ProductId<br/>
left join Categories as CT on PC.CategoryId = CT.Id
