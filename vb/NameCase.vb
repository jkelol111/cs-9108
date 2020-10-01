Module NameCase
	Sub Main()
		Console.Write("Enter a word: ")
		Dim value As String = Console.ReadLine()
		Select Case value
			Case "John"
				Console.WriteLine("You entered John")
			Case "David"
				Console.WriteLine("You entered David")
			Case "Peter"
				Console.WriteLine("You entered Peter")
			Case Else
				Console.WriteLine("Something else")
		End Select
		Console.ReadKey()
	End Sub
End Module
