Module ForStringLoop
	Sub Main()
		Dim value As String = "cat"
		
		' Start at zero and proceed until final index
		For i As Integer = 0 To value.length - 1
			' Get character from string
			Dim c As Char = value(i)
			
			' Test and display character
			If c = "c" Then
				Console.WritelIne("***C***")
			Else
				Console.WriteLine(c)
			End If
		Next
		Console.ReadLine()
	End Sub
End Module
