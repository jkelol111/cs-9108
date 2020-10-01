Module DiscountRate
	Sub Main()
		Console.Write("Input purchase: ")
		Dim purchase As Integer = Console.ReadLine()
		
		Dim discountRate As Single
		If purchase > 1000 Then
			discountRate = 0.10
		Else
			If purchase > 500 Then
				discountRate = 0.05
			Else 
				discountRate = 0
			End If
		End If

		Dim paid As Single = purchase * (1 - discountRate)

		Console.WriteLine("Paid: {0}", paid)
		Console.ReadKey()
	End Sub
End Module
