Module ForEvenCheck
	Sub Main()
		For i As Integer = 1 To 10
			If i Mod 2 = 0 Then
				Console.WriteLine(i) ' an even number
			Else
				' we do nothing as the number is odd
			End If
		Next
		Console.ReadKey()
	End Sub
End Module
