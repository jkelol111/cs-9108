Module OneDArray12
	Sub Main()
		Dim StudentName(4) As String
		Dim Marks (4) As Integer
		Dim Row As Integer
		Dim Found As Boolean = False
		Dim SearchName As String
		Dim Count As Integer = 0
		For Row = 0 To 4
			Console.WriteLine("Enter name of student {0}: ", Row + 1)
			StudentName(Row) = Console.ReadLine()
			Console.WriteLine("Enter mark for student {0} term 1 ", Row + 1)
			Marks(Row) = CInt(Console.ReadLine())
		Next
		Console.WriteLine("Enter name of student to search ")
		SearchName = Console.ReadLine()
		While Found = False And Count < 5
			If (StudentName(Count)) = SearchName Then
				Row = Count
				Found = True
				Console.WriteLine("Name of student {0}", StudentName(Row))
				Console.WriteLine("Mark of student {0} ", Marks(Row))
			Else
				Count = Count + 1
			End If
		End While
		Console.ReadLine()
	End Sub
End Module 
		
