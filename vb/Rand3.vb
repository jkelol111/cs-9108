Module Rand3
	Sub Main()
		Dim rnd As New Random()
		Dim index As Integer
		Dim randomNumber As Integer
		For index = 1 To 10
			randomNumber = rnd.Next(10, 100)
			Console.WriteLine(randomNumber)
		Next
		Console.ReadLine()
	End Sub
End Module
