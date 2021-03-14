Module OOP3
	Class Greeter
		Public Sub Greet()
			Console.WriteLine("Hello object world!")
		End Sub
	End Class
	Sub Main()
		Dim greet1 As New Greeter()
		greet1.Greet()
		Console.ReadLine()
	End Sub
End Module
