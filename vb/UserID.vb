Module UserID
	Sub Main()
		Console.Write("Input User ID: ")
		Dim uid As String = Console.ReadLine()
	
		If Len(uid) = 6 Then
			If Char.IsUpper(uid(0)) And (Char.IsLower(uid(1)) And Char.IsLower(uid(2))) And (Char.IsDigit(uid(3)) And Char.IsDigit(uid(4)) And Char.IsDigit(uid(5))) Then
				Console.WriteLine("Correct Format")
			Else
				Console.WriteLine("Wrong Format")
			End If
		Else 
			Console.WriteLine("Wrong Format")
		End If
		Console.ReadKey()
	End Sub
End Module
