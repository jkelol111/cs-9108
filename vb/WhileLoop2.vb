Module WhileLoop2
	Sub Main()
		Dim mynum As Integer
		mynum = 25
		While mynum < 100
			mynum = mynum + 1
			Console.WriteLine(mynum)
			If mynum = 52 Then
				Exit While
			End If
		End While
		Console.ReadLine()
	End Sub
End Module