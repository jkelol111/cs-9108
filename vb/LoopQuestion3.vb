Module LoopQuestion2
	Sub Main()
		For i As Integer = 1 To 100
			If (i Mod 2 <> 0) Then
				Console.WriteLine(i)
			End If
		Next
		Console.ReadKey()
	End Sub
End Module
