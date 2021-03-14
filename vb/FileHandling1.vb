Module FileHandling1
	Sub Main()
		Dim Student_Name, Student_Detail As String
		Dim Student_Mark As Integer
		Dim Count As Integer
		FileOpen(1, "../vb_filehandling/TFILE2", OpenMode.Output)
		For Count = 1 To 5
			Console.WriteLine("Enter student name")
			Student_Name = Console.ReadLine()
			Console.WriteLine("Enter student mark")
			Student_Mark = Console.ReadLine()
			Student_Detail = Student_Name & ";" & Student_Mark
			PrintLine(1, Student_Detail)
		Next count
		FileClose(1)
	End Sub
End Module
