Module LinkedList1
	Dim List() As String = {}
	Dim Link() As Integer = {}
	Sub PrintList(ByVal Start As Integer, ByVal Finish As Integer)
		Dim Pointer As Integer = Start
		Do
			Console.WriteLine(List(Pointer))
			Pointer = Link(Pointer)
		Loop Until Pointer = Finish
	End Sub
	Sub SearchList(ByVal Start As Integer, ByVal Data As String)
		Dim Pointer As Integer = Start
		Do
			If Data = List(Pointer) Then
				Console.WriteLine("Found in list: {0}", Data)
				Exit Sub
			Else
				Pointer = Link(Pointer)
			End If
		Loop Until Pointer = 0
		Console.WriteLine("Search NOT found")
	End Sub
	Sub Main()
		Call PrintList(1, 6)
		Call SearchList(1, "?")
	End Sub
End Module
