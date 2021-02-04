Module Rand1
	Sub Main()
		Dim number As Integer
		Dim index As Integer

		For index = 1 To 10
			Randomize()
			number = Int(Rnd() * 50) + 1
			Console.WriteLine(number)
		Next
		Console.ReadLine()
	End Sub
End Module
