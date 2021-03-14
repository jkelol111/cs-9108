Module OOPQ6
	Class Product
		Public Number As Integer
		Public Description As String
		Public Price As Single
		Public Stock As Integer
		Public Supplier As String
	End Class
	Sub Main()
		Dim Noodles As New Product
		Noodles.Number = 1
		Noodles.Description = "Noodles"
		Noodles.Price = 1.50
		Noodles.Stock = 999
		Noodles.Supplier = "Some company"
		Console.WriteLine("Product Number: {0}", Noodles.Number)
		Console.WriteLine("Product Description: {0}", Noodles.Description)
		Console.WriteLine("Product Price: {0}", Noodles.Price)
		Console.WriteLine("Product Stock: {0}", Noodles.Stock)
		Console.WriteLine("Product Supplier: {0}", Noodles.Supplier)
		Console.ReadLine()
	End Sub
End Module
