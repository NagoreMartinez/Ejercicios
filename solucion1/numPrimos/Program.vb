Imports System

Module Program

    Public Function primo(ByVal j As Integer) As Boolean
        Dim primos As Boolean = True
        For a As Integer = j - 1 To 2 Step -1
            If (j Mod a = 0) Then
                primos = False
            End If
        Next
        Return primos
    End Function
    Sub Main(args As String())

        Dim n As Integer
        Dim cont As Integer
        Dim p As Integer
        Dim esPrimo As Boolean

        Console.WriteLine("Introduce un número")
        n = Console.ReadLine

        For i As Integer = n To 2 Step -1
            esPrimo = primo(i)
            If esPrimo = True Then
                cont += 1
            End If
        Next
        Console.Write(cont)

    End Sub
End Module
