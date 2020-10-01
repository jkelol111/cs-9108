Module NumberCase
	Sub Main()
		Dim i As Integer
		Console.WriteLine("Enter a number, then press ENTER: ")
		i = Console.ReadLine()
		
		Select Case i
			Case 1, 3, 5
				Console.WriteLine("1, 3, or 5")
			Case 7 To 11
				Console.WriteLine("Between 7 and 11")
			Case Is > 15
				Console.WriteLine(">= 15")
			Case Else
				Console.WriteLine("Other number")
		End Select
		Console.ReadKey()
	End Sub
End Module
