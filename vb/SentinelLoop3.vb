Module SentinelLoop3
	Sub Main()
		Dim Quantity As Integer
		Dim Price As Single
		Dim BillTotal As Single
		Dim ItemTotal As Single

		Console.Write("Enter the quantity of the item (input = -1 to stop): ")
		Quantity = Console.ReadLine()

		While Quantity > -1
			Console.Write("Enter the price of the item: ")
			Price = Console.ReadLine()
			ItemTotal = Quantity * Price
			BillTotal = BillTotal + ItemTotal
			Console.Write("Enter the quantity of the item (input = -1 to stop): ")
			Quantity = Console.ReadLine()
		End While

		Console.WriteLine("The Bill amount is {0}", BillTotal)
		Console.ReadKey()
	End Sub
End Module