Module Module1

    Sub Main()
        ' Crear una matriz de 3x3
        Dim matriz(2, 2) As Integer

        ' Inicializar la matriz con algunos valores
        matriz(0, 0) = 1
        matriz(0, 1) = 2
        matriz(0, 2) = 3
        matriz(1, 0) = 4
        matriz(1, 1) = 5
        matriz(1, 2) = 6
        matriz(2, 0) = 7
        matriz(2, 1) = 8
        matriz(2, 2) = 9

        ' Imprimir la matriz en la consola
        For i As Integer = 0 To UBound(matriz)
            For j As Integer = 0 To UBound(matriz)
                Console.Write(matriz(i, j).ToString() + " ")
            Next j
            Console.WriteLine()
        Next i

        Console.ReadKey()
    End Sub

End Module
