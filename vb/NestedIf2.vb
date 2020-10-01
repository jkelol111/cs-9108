Module NestedIf2
	Sub Main()
		Dim mark As Integer
		Console.Write("Enter your mark: ")
		mark = Console.ReadLine()
		
		If mark >= 40 Then
			If mark >= 60 Then 
				Console.WriteLine("You have FIRST class")
			Else
				Console.WriteLine("You have SECOND class")
			End if
		Else
			Console.WriteLine("Check the mark entered")
		End If
		Console.ReadKey()
	End Sub
End Module
