Module SumOfDigits
	Sub Main()
		Dim n, sum, r As Integer
		Console.Write("Enter a number: ")
		n = CInt(Console.ReadLine())
		sum = 0
		While n <> 0
			r = n Mod 10
			sum += r
			n \= 0 
		End While
		Console.WriteLine("Sum of Digits = {0}", sum)
		Console.ReadKey()
	End Sub
End Module