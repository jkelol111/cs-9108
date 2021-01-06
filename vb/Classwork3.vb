Module Classwork3
	Sub main()
		Dim Marks(4) As Integer
		Dim Row As Integer
		Dim Total As Integer
		For Row = 0 To 4
			Console.WriteLine("Enter mark for student {0} term 1", Row + 1)
			Marks(Row) = CInt(Console.ReadLine())
		Next
		For Row = 0 To 4
			Total += Marks(Row)
		Next
		Console.WriteLine("Total: {0}", Total)
		Console.WriteLine("Avg: {0}", Total / 5)
		Console.ReadKey()
	End Sub
End Module
