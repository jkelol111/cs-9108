Module TwoDArrayQ1
	Sub Main()
		Dim table(2, 5) As Integer
		For Row As Integer = 0 To 2
			For Column As Integer = 0 To 5
				Console.Write("Input integer for position ({0}, {1}): ", Row + 1, Column + 1)
				table(Row, Column) = Console.ReadLine()
			Next
		Next
		For Row As Integer = 0 To 2
			Dim RowTotal As Integer = 0
			For Column As Integer = 0 To 5
				Console.Write("{0} ", table(Row, Column))
				RowTotal += table(Row, Column)
			Next
			Console.Write("| {0}", RowTotal)
			Console.WriteLine()
		Next
		For Column As Integer = 0 To 5
			Console.Write("- ")
		Next
		Console.WriteLine()
		For Column As Integer = 0 To 5
			Dim ColumnTotal As Integer = 0
			For Row As Integer = 0 To 2
				ColumnTotal += table(Row, Column)
			Next
			Console.Write("{0} ", ColumnTotal)
		Next
		Console.WriteLine()
		Console.ReadKey()
	End Sub
End Module
