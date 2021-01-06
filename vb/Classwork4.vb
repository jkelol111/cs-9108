Module Classwork4
    Sub Main()
        Dim StudentName(4) As String
        Dim Marks(4) As Integer
        Dim Row As Integer

        For Row = 0 To 4
            Console.WriteLine("Enter name of student {0}" < Row + 1)
            StudentName(Row) = Console.ReadLine()
            Console.WriteLine("Enter mark for student {0} term 1", Row + 1)
            Marks(Row) = CInt(Console.ReadLine())
        Next
        For Row = 0 To 4
            Console.Write(StudentName(Row))
            Console.Write(" " & Marks(Row))
        Next
        Console.ReadLine()
    End Sub
End Module
