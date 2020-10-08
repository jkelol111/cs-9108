Module NestedFor
	Sub Main()
		' Use a nested For loop
		For row As Integer = 0 To 2
			For column As Integer = 0 To 2
				Console.WriteLine("row is: {0}, column is {1}", row, column)
			Next
		Next
		Console.ReadKey()
	End Sub
End Module
