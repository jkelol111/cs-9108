Module AmnesiaQ8
	Function routes(ByVal East As Integer, ByVal South As Integer) As Integer
		If East = 0 Or South = 0 Then
			routes = 1
		Else
			routes = routes(East - 1, South) + routes(East, South - 1)
		End If
	End Function
	Sub Main()
		Console.Write("Input east: ")
		Dim east As Integer = Console.ReadLine()
		Console.Write("Input south: ")
		Dim south As Integer = Console.ReadLine()
		Console.WriteLine("Routes: {0}", routes(east, south))
		Console.ReadLine()
	End Sub
End Module
