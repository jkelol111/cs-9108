Module TwoDArray1
	Sub Main()
		Dim StudentName(4) As String
		Dim Marks(4, 2) As Integer
		Dim Row As Integer
		Dim Column As Integer
		For Row = 0 To 4
			Console.WriteLine("Enter name of student {0} ", Row + 1)
			StudentName(Row) = Console.ReadLine()
			For Column = 0 To 2
				Console.WriteLine("Enter mark for student {0} term {1}", Row + 1, Column + 1)
				Marks(Row, Column) = CInt(Console.ReadLine())
			Next
		Next
		For Row As Integer = 0 To 4
			Console.Write(StudentName(Row))
			For Column As Integer = 0 To 2
				Console.Write("    " & Marks(Row, Column))
			Next
			Console.WriteLine()
		Next
		Dim TotalStudent(4) As Integer
		For Row As Integer = 0 To 4
			For Column As Integer = 0 To 2
				TotalStudent(Row) += Marks(Row, Column)
			Next
			Console.WriteLine("Total marks for student {0}: {1}", StudentName(Row), TotalStudent(Row))
		Next
		Dim TotalTerm(2) As Integer
		For Column As Integer = 0 To 2
			For Row As Integer = 0 To 4
				TotalTerm(Column) += Marks(Row, Column)
			Next
			Console.WriteLine("Total for term {0}: {1}", Column + 1, TotalTerm(Column))
		Next
		Console.ReadKey()
	End Sub
End Module
