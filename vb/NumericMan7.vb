Module NumericMan7
	Sub Main()
		Dim N1 As Integer
		Dim N2 As Integer
		Dim Total As Integer
		Dim Count As Integer
		N1 = 0
		N2 = 1
		For Count = 1 To 10
			Total = N1 + N2
			Console.WriteLine(Total)
			N2 = N1
			N1 = total
		Next Count
		Console.ReadKey()
	End Sub
End Module
