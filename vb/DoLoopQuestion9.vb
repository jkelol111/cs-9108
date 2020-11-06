Module DoLoopQuestion9
    Sub Main()
        Dim CandidateName1, CandidateName2, CandidateName3 As String
        Dim Candidate1, Candidate2, Candidate3 As Integer
        Dim CurrentVote As Char
        Dim Winner As String
        Console.Write("Input Candidate 1 Name: ")
        CandidateName1 = Console.ReadLine()
        Console.Write("Input Candidate 2 Name: ")
        CandidateName2 = Console.ReadLine()
        Console.Write("Input Candidate 3 Name: ")
        CandidateName3 = Console.ReadLine()
        Do
            Console.Write("1, 2, 3, or X to exit: ")
            CurrentVote = Console.ReadLine()
            If CurrentVote = "1" Then
                Candidate1 += 1
            ElseIf CurrentVote = "2" Then
                Candidate2 += 1
            ElseIf CurrentVote = "3" Then
                Candidate3 += 1
            ElseIf CurrentVote = "X" Then
                Exit Do
            Else
                Console.WriteLine("Unknown input!")
            End If
        Loop Until CurrentVote = "X"
        If Candidate1 > Candidate2 And Candidate1 > Candidate3 Then
            Winner = CandidateName1
        ElseIf Candidate2 > Candidate3 Then
            Winner = CandidateName2
        Else
            Winner = CandidateName3
        End If
        Console.WriteLine("The winner is: {0}", Winner)
        Console.ReadKey()
    End Sub
End Module
