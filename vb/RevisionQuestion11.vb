Module RevisionQuestion11
	Sub Main()
		Dim number As Integer
		Console.Write("Input number: ")
		number = CInt(Console.ReadLine())

		Console.WriteLine("Table")
		Console.WriteLine("-----")
		For times As Integer = 1 To 10
			Console.WriteLine("{0} x {1} = {2}", number, times, number * times)
		Next

		Console.ReadKey()
	End Sub
End Module