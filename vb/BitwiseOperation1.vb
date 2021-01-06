Module BitwiseOperation1
	Sub Main()
		Dim sentence As String
		Dim converted As String = ""
		sentence = Console.ReadLine()
		Console.WriteLine("converting...")
		For x As Integer = 0 To sentence.Length - 1
			converted += Chr(Asc(sentence.Substring(x, 1)) Xor 32)
		Next
		Console.WriteLine(converted)
	End Sub
End Module
