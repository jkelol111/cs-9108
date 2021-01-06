Module OneDArrayQ2
	Sub Main()
		Dim Tracks(150) As String
		For i As Integer = 0 To Tracks.Length - 1
			Tracks(i) = ""
		Next
		Console.Write("Input track name: ")
		Dim SearchString As String = Console.ReadLine()
		Dim Found As Boolean = false
		For i As Integer = 0 To Tracks.Length - 1
			If Tracks(i) = SearchString Then
				Console.WriteLine("Found track {0} in library!", SearchString)
				Found = true
				Exit For
			End If
		Next
		If Not Found Then
			Console.WriteLine("Track couldn't be found!")
		End If
		Console.ReadKey()
	End Sub
End Module
