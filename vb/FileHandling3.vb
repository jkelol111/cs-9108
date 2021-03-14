Module FileHandling3
	Sub Main()
		Dim Student_Name, Student_Detail As String
		Dim Student_Mark As Integer
		FileOpen(1, "../vb_filehandling/TFILE", OpenMode.Append)
		For count As Integer = 1 To 5
			Console.WriteLine("Enter student name")
			Student_Name = Console.ReadLine()
			Console.WriteLine("Enter stduent mark")
			Student_Mark = Console.ReadLine()
			Student_Detail = Student_Name & Student_Mark
			WriteLine(1, Student_Detail)
		Next count
		FileClose(1)
	End Sub
End Module
