Module NestedFor3
	Sub Main()
		Dim i, j, k As Integer
		For i = 1 To 7
			For j = 1 To i
				Console.Write(j)
			Next
			For k = 7 - i To 1 Step -1
				Console.Write("*")
			Next
			Console.WriteLine()
		Next
		Console.ReadKey()
	End Sub
End Module
