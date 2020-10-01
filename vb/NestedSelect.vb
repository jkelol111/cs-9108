Module NestedSelect
	Sub Main()
		' Example of Nested Case
		Dim Value As String = "dog"
		
		' Handle first letter
		Select Case value(0)
			Case "c"
				' Handle second latter
				Select Case value(1)
					Case "a"
						Console.WriteLine("String starts with c, a")
					Case "o"
						Console.WriteLine("String starts with c, o")
				End Select
			Case Else
				Console.WriteLine("Unexpected 1st character.")
		End Select
		Console.ReadKey()
	End Sub
End Module

