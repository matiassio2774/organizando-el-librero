Module Module1
    Dim cantLibros As Integer = 0

    Function librero(bases() As Integer, libros() As Integer) As Integer
        Dim alturaFinal As Integer
        Dim temp As Integer = 0
        Dim aux As Integer
        Dim aux2 As Integer

        'Utilizo dos veces el metodo burbujeo para ordenar los vectores.

        For i = 1 To cantLibros Step 1  'Se ordenan los libros de menor a mayor
            For k = 0 To cantLibros - 1 Step 1
                If libros(k) > libros(k + 1) Then
                    aux = libros(k + 1)
                    libros(k + 1) = libros(k)
                    libros(k) = aux
                End If
            Next
        Next

        For i = 0 To cantLibros - 1 Step 1  'Se ordenan las bases de mayor a menor
            For k = 0 To cantLibros - i - 1 Step 1
                If bases(k) < bases(k + 1) Then
                    aux = bases(k)
                    bases(k) = bases(k + 1)
                    bases(k + 1) = aux
                End If
            Next
        Next


        ' Estos dos For son para ver como quedan los vectores ordenados. (opcional)

        'For i = 0 To cantLibros Step 1
        'Console.Write(Str(bases(i)) + ",")
        'Next

        'Console.WriteLine(" ")

        'For i = 0 To cantLibros Step 1
        'Console.Write(Str(libros(i)) + ",")
        'Next


        temp = bases(0) + libros(0)
        For l = 0 To cantLibros - 1     ' Comparo si la primer base+altura es igual al resto.
            If libros(l) + bases(l) = temp Then
                alturaFinal = temp      ' Si es asi, queda como altura final y sigo recorriendo el ciclo
            Else
                alturaFinal = -1        ' Si alguna base+altura no coincide, ya está mal entonces es -1
                Return alturaFinal
            End If

        Next

        Return alturaFinal

    End Function

    Sub Main()

        Dim bases(cantLibros) As Integer
        Dim libros(cantLibros) As Integer

        '   INPUT:
        '   --- Cantidad de libros n
        '   --- Altura de bases(n) en órden
        '   --- Altura de libros(n) en órden

        Console.Write("Ingrese cantidad de libros: ")
        cantLibros = Console.ReadLine()
        cantLibros -= 1

        Console.WriteLine("") 'Salto de linea

        If (cantLibros < 1 Or cantLibros > 1000) Then
            Console.Clear()
            Console.WriteLine("No se puede ingresar esta cantidad.")
            Console.ReadKey()
            End 'Sale del programa
        End If

        ReDim bases(cantLibros)
        ReDim libros(cantLibros)

        Console.WriteLine("Ingrese la altura de las bases EN ÓRDEN.")
        For i = 0 To cantLibros Step 1
            Console.Write("Base " + Str(i + 1) + ": ")
            bases(i) = Console.ReadLine()

            If bases(i) < 1 Or bases(i) > 1000 Then
                Console.Clear()
                Console.WriteLine("No se puede ingresar esta cantidad.")
                Console.ReadKey()
                End 'Sale del programa
            End If

        Next
        Console.WriteLine("") 'Salto de linea

        Console.WriteLine("Ingrese la altura de los libros EN ÓRDEN.")
        For i = 0 To cantLibros Step 1
            Console.Write("Libro " + Str(i + 1) + ": ")
            libros(i) = Console.ReadLine()
            If libros(i) < 1 Or libros(i) > 1000 Then
                Console.Clear()
                Console.WriteLine("No se puede ingresar esta cantidad.")
                Console.ReadKey()
                End 'Sale del programa
            End If
        Next
        Console.WriteLine("") 'Salto de linea

        Console.WriteLine("Altura final: " + Str(librero(bases, libros)))

        Console.ReadKey()
    End Sub
End Module
