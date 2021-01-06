Module OneDArrayQ9
	Sub Main()
		Dim MonthName() As String = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}
		Console.Write("Input month number: ")
		Dim Input As Byte = CByte(Console.ReadLine())
		Console.WriteLine(MonthName(Input - 1))
		Console.ReadKey()
	End Sub
End Module
