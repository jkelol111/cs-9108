Module ForPrimeLoop
	Sub Main()
		' Local Variable definition
		Dim i, j As Integer
		For i = 2 To 100
			For j = 2 To i
				' if factor found, not prime
				If ((i Mod j) = 0) Then
					Exit For
				End If
			Next j
			If (j > (i \ j)) Then
				Console.WriteLine("{0} is prime", i)
			End If
		Next i
		Console.ReadKey()
	End Sub
End Module
