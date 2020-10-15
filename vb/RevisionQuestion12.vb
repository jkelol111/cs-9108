Module RevisionQuestion12
	Sub Main()
		Dim number As Integer
		Console.Write("Input number: ")
		number = CInt(Console.ReadLine())

		Console.WriteLine("Table")
		Console.WriteLine("-----")
		For numbers As Integer = 2 To number:
			For times As Integer = 1 To 10
				Console.WriteLine("{0} x {1} = {2}", numbers, times, numbers * times)
			Next
			Console.WriteLine("-----")
		Next

		Console.ReadKey()
	End Sub
End Module