Imports System.IO

Module FileHandling2
	Sub Main()
		Dim Student_Name As String
		Dim Student_Mark As Integer
		Dim Student_Detail As String
		Dim Student_Parsed() As String
		For Each line As String In File.ReadLines("../vb_filehandling/TFILE2")
			Student_Detail = line
			Student_Parsed = Student_Detail.Split(";")
			Student_Name = Student_Parsed(0)
			Student_Mark = CInt(Student_Parsed(1))
			Console.WriteLine("Name: {0} ; Grade: {1}", Student_Name, Student_Mark)
		Next
		Console.ReadKey()
	End Sub
End Module
