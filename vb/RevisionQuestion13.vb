Module RevisionQuestion13
	Sub Main()
		Dim price, sum As Double
		Dim quantity As Integer

		Console.Write("Input price (input 0 to quit): ")
		price = Console.ReadLine()

		Console.Write("Input quantity (input 0 to quit): ")
		quantity = Console.ReadLine()

		Console.WriteLine()

		While price > 0.0 And quantity > 0
			sum += price * quantity

			Console.Write("Input price (input 0 to quit): ")
			price = Console.ReadLine()

			Console.Write("Input quantity (input 0 to quit): ")
			quantity = Console.ReadLine()

			Console.WriteLine()
		End While

		Console.WriteLine("Total sum to be paid: ${0}", sum)
		Console.ReadKey()
	End Sub
End Module
