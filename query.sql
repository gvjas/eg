SELECT product_name, category_name 
FROM products LEFT JOIN catigories
     ON product.product_id = catigories.product_id
ORDER BY product_name;