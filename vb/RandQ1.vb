Module RandQ1
	Dim rnd As New Random()
	Sub Main()
		Dim Player1Score As Integer = 0
		Dim Player2Score As Integer = 0
		For i As Integer = 1 To 20
			Dim Player1Result As Integer = rnd.Next(1, 6)
			Dim Player2Result As Integer = rnd.Next(1, 6)
			If Player1Result > Player2Result Then
				Player1Score += 1
			Else If Player1Result < Player2Result Then
				Player2Score += 1
			End If
		Next
		If Player1Score > Player2Score Then
			Console.WriteLine("Player 1 won!")
		Else If Player1Score < Player2Score Then
			Console.WriteLine("Player 2 won!")
		Else
			Console.WriteLine("It's a draw!")
		End If	
		Console.ReadLine()
	End Sub
End Module
