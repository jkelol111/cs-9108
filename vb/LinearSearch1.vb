Module LinearSearch
	Sub Main()
		Dim Data() As String = {"Daniel", "Natasha", "Aydan", "Lynette", "Rafii", "Sarine", "Vishnu", "Dasun", "Derrick", "Joceline"}
		Console.Write("Enter data to search for: ")
		Dim Sdata As String = Console.ReadLine()
		
		Dim Flag As Boolean = False
		Dim Max As Integer = 9
		Dim i As Integer = 0
		Dim Pos As Integer = 0
		Do
			If Sdata = Data(i) Then
				Flag = true
				Pos = i
				Exit Do
			Else
				i = i + 1
			End If
		Loop Until Flag = True Or i = Max

		If Flag = false Then
			Console.WriteLine("Not found")
		Else
			Console.WriteLine("Found at position {0}!", Pos)
		End If
		Console.ReadLine()
	End Sub
End Module
