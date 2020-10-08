Module ForConditionLoop
	Sub Main()
		' This loop goes from 0 to 5
		For value As Integer = 0 To 5
			' Exit confition if the value is three
			Console.WriteLine(value)
			If (value = 3) Then
				Exit For
			End If
		Next
		Console.ReadKey()
	End Sub
End Module
