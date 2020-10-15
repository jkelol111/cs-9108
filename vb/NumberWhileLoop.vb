Module NumberWhileLoop
	Sub Main()
		Dim n, r As Integer
		Console.Write("Enter a number: ")
		n = CInt(Console.ReadLine())
		While n <> 0
			r = n Mod 10
			Console.Write(r)
			n \= 10
		End While
		Console.ReadKey()
	End Sub
End Module