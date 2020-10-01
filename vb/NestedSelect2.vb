Module NestedSelect2
	Sub Main()
		' local variable definition
		Dim a As Integer
		Console.WriteLine("Enter a number")
		a = Console.ReadLine()
		Select Case a
			Case Is > 100
				Console.WriteLine("This is part of outer case")
			Select Case a
				Case Is > 300
					Console.WriteLine("This is aprt of inner case Option A")
				Case Is > 200
					Console.WriteLine("This is part of inner case Option B")
			End Select
		End Select

		Console.WriteLine("The value of a is: {0}", a)
		' Console.WriteLine("The value of b is: {0}", b)
		Console.ReadKey()
	End Sub
End Module
