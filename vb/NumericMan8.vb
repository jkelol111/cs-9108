Module NumericMan8
	Sub Main()
		Dim Input_Word As String
		Dim Count As Integer
		Dim Counter As Integer
		Dim Reverse As String = ""
		Console.Write("Enter the word: ")
		Input_Word = Console.ReadLine()
		Count = Len(Input_Word)
		For Counter = 1 To Count
			Reverse = Reverse & (Mid(Input_Word, (Count - (Counter -1)), 1))
		Next Counter
		Console.WriteLine(Reverse)
		Console.ReadKey()
	End Sub
End Module
