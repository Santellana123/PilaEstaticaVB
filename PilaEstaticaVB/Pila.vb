Public Class Pila
    Private Const MAX_SIZE As Integer = 10
    Private arreglo(MAX_SIZE - 1) As Integer
    Private tope As Integer = -1

    Public Function EstaVacia() As Boolean
        Return tope = -1
    End Function

    Public Function EstaLlena() As Boolean
        Return tope = MAX_SIZE - 1
    End Function

    Public Sub Push(elemento As Integer)
        If Not EstaLlena() Then
            tope += 1
            arreglo(tope) = elemento
            Console.WriteLine($"Se ha insertado {elemento} en la pila.")
        Else
            Console.WriteLine("La pila está llena. No se puede insertar.")
        End If
    End Sub

    Public Sub Pop()
        If Not EstaVacia() Then
            Console.WriteLine($"Se ha eliminado {arreglo(tope)} de la pila.")
            tope -= 1
        Else
            Console.WriteLine("La pila está vacía. No se puede eliminar.")
        End If
    End Sub

    Public Function Top() As Integer
        If Not EstaVacia() Then
            Return arreglo(tope)
        Else
            Console.WriteLine("La pila está vacía. No hay elemento superior.")
            Return -1 ' Valor sentinela para indicar que la pila está vacía
        End If
    End Function
End Class
