Module DoLoopQuestion4
    Sub Main()
        Dim largest As Integer
        Dim smallest As Integer = 1000

        Dim GradeA As Integer
        Dim GradeB As Integer
        Dim GradeC As Integer

        Dim egg As Integer
        Do
            Console.Write("Input egg: ")
            egg = Console.ReadLine()
            If egg > 0 Then
                If egg < smallest Then
                    smallest = egg
                ElseIf egg > largest Then
                    largest = egg
                End If

                If egg <= 25 Then
                    GradeC += 1
                ElseIf egg <= 50 Then
                    GradeB += 1
                Else 
                    GradeA += 1
                End If
            End If
        Loop Until egg < 0
        Console.WriteLine("Largest: {0}", largest)
        Console.WriteLine("Smallest: {0}", smallest)
        Console.WriteLine("Grade A: {0}", GradeA)
        Console.WriteLine("Grade B: {0}", GradeB)
        Console.WriteLine("Grade C: {0}", GradeC)
    End Sub
End Module