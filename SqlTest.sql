SELECT prod.[ProductName], cat.[CategoryName] 
FROM [Products] prod
LEFT JOIN [ProductsCategories] as prodCat on prodCat.ProductId = prod.Id
LEFT JOIN [Categories] as cat ON prodCat.CategoryId = cat.Id