Module Records1
	Structure Student
		Dim ID As Integer
		Dim Name As String
		Dim DoB As Date
	End Structure
	Sub Main()
		Dim NewStudents(3) As Student
		For i As Integer = 0 To 3
			Console.Write("ID: ")
			NewStudents(i).ID = Console.ReadLine()
			Console.Write("Name: ")
			NewStudents(i).Name = Console.ReadLine()
			Console.Write("DoB: ")
			NewStudents(i).DoB = Console.ReadLine()
		Next
		For i As Integer = 0 To 3
			Console.WriteLine("Record: ID: {0}, Name: {1}, DoB: {2}", NewStudents(i).ID, NewStudents(i).Name, NewStudents(i).DoB)
		Next
	End Sub
End Module

