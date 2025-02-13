-- Youtube Videos Class Diagram
+-------------------+
|      Video        |
+-------------------+
| - title: string   |
| - author: string  |
| - length: int     |
| - comments: List<Comment>  |
+-------------------+
| + AddComment(Comment) |
| + GetCommentCount(): int  |
| + DisplayInfo()  |
+-------------------+

         ▲
         │

+-------------------+
|      Comment      |
+-------------------+
| - commenter: string | 
| - text: string |
+-------------------+
| + DisplayComment() |
+-------------------+


--     Online Ordering Class Diagram     --
+-------------------+
|      Product      |
+-------------------+
| - name: string    |
| - ProduceId: int         |
| - price: double   |
| - quantity: int   |
+-------------------+
| + GetTotalCost(): double  |
| + GetPackingLabel(): string |
+-------------------+

         ▲
         │
+-------------------+
|      Order        |
+-------------------+
| - customer: Customer |
| - products: List<Product> |
+-------------------+
| + GetTotalPrice(): double  |
| + GetPackingLabel(): string |
| + GetShippingLabel(): string |
+-------------------+

         ▲
         │
+-------------------+
|      Customer     |
+-------------------+
| - name: string    |
| - class: Address |
+-------------------+
| + IsInUSA(): bool |
| + GetName(): string |
| + GetAddress(): string |
+-------------------+

            ▲
            │
+-------------------+
|      Address      |
+-------------------+
| - street: string  |
| - city: string    |
| - state: string   |
| - country: string |
+-------------------+
| + IsInUSA(): bool  |
| + GetFullAddress(): string |
+-------------------+

