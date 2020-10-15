Module RevisionQuestion14
	Sub Main()
		Dim input As Integer
		Dim sum As Long

		Console.Write("Input a positive integer (negative integer to quit): ")
		input = Console.ReadLine()

		While input >= 0:
			sum += input 

			Console.Write("Input a positive integer (negative integer to quit): ")
			input = Console.ReadLine()
		End While

		Console.WriteLine("The sum is: {0}", sum)
		Console.ReadKey()
	End Sub
End Module