Module Rand4
	Sub Main()
		Dim rnd As New Random()
		Dim index As Integer
		Dim randomNumber As Integer
		For index = 1 to 10
			randomNumber = rnd.Next(0, 7)
			Console.WriteLine(randomNumber)
		Next
		Console.ReadLine()
	End Sub
End Module
