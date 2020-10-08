Module LoopQuestion9
	Sub Main()
		Dim i As Integer = 1
		For row As Integer = 1 To 5
			For column As Integer = 1 To i
				Console.Write("*")
			Next
			i += 1
			Console.WriteLine()
		Next
	End Sub
End Module
