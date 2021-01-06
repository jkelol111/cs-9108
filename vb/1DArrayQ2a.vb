Module OneDArray2a
	Sub Main()
		Dim Alpha(26) As Char
		For Pos As Byte = 0 To 25
			Alpha(Pos) = Chr(65 + Pos)
		Next
		For Pos As Byte = 0 To 25
			Console.Write(" {0}", Alpha(Pos))
		Next
		Console.WriteLine()
		Console.ReadKey()
	End Sub
End Module
