Imports System

Module Program

    Public Function fibonacci(ByVal j As Integer) As Integer
        If (j = 0 Or j = 1) Then
            Return j
        Else
            Return fibonacci(j - 1) + fibonacci(j - 2)
        End If
    End Function

    Sub main(args As String())
        Dim n As Integer
        Console.WriteLine("Introduce la cantidad de números fibonacci que quieres saber")
        n = Console.ReadLine

        For i As Integer = 0 To n - 1
            Console.Write($"{fibonacci(i)},")
        Next

    End Sub
End Module
