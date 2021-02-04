Module Rand5
	Sub Main()
		Dim r As Random = New Random
		Console.WriteLine(r.Next(5, 10))
		Console.WriteLine(r.Next(5, 10))
		Console.WriteLine(r.Next(5, 10))
		Console.ReadLine()
	End Sub
End Module
