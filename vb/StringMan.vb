Module StringMan
	Sub Main()
		Dim student As String = "Elizabeth"
		Dim student_name As String = "Taylor"
		Dim nom As Integer
		Console.WriteLine(Len(student))
		Console.WriteLine(Right(student, 4))
		Console.WriteLine(Left(student, 5))
		Console.WriteLine(Mid(student, 6, 2))
		Console.WriteLine(UCase(student))
		student = "ELIZABETH"
		Console.WriteLine(LCase(student))
		student = " elizabeth"
		Console.WriteLine(LTrim(student))
		student = "elizabeth "
		Console.WriteLine(RTrim(student))
		student = " elizabeth "
		Console.WriteLine(Trim(student))
		student = "elizabeth"
		Console.WriteLine(InStr(student, "beth"))
		student = "E"
		Console.WriteLine(Asc(student))
		nom = 65
		Console.WriteLine(Chr(nom))
		student = "elizabeth"
		Console.WriteLine(student & student_name)
		Console.ReadLine()
	End Sub
End Module
