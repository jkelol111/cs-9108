Module LoopQuestion8i
	Sub Main()
		Dim row, column As Integer
		For row = 5 To 1 Step -1
			For column = 1 To row
				Console.Write(Chr(64 + column))
			Next
			Console.WriteLine()
		Next
		Console.ReadKey()
	End Sub
End Module
