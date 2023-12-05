Imports System

Module Program
    Sub Main(args As String())
        Dim miPila As New Pila()

        While True
            Dim opcion As Integer ' Declaración de la variable opcion

            Console.WriteLine("Seleccione una operación:")
            Console.WriteLine("1. Push")
            Console.WriteLine("2. Pop")
            Console.WriteLine("3. Elemento Superior")
            Console.WriteLine("4. Salir")

            If Integer.TryParse(Console.ReadLine(), opcion) Then
                Select Case opcion
                    Case 1
                        Console.WriteLine("Ingrese el elemento a insertar:")
                        Dim elementoPush As Integer
                        If Integer.TryParse(Console.ReadLine(), elementoPush) Then
                            miPila.Push(elementoPush)
                        Else
                            Console.WriteLine("Entrada no válida. Ingrese un número entero.")
                        End If

                    Case 2
                        miPila.Pop()

                    Case 3
                        Dim elementoSuperior As Integer = miPila.Top()
                        If elementoSuperior <> -1 Then
                            Console.WriteLine($"Elemento superior de la pila: {elementoSuperior}")
                        End If

                    Case 4
                        Environment.Exit(0)

                    Case Else
                        Console.WriteLine("Opción no válida. Intente de nuevo.")
                End Select
            Else
                Console.WriteLine("Entrada no válida. Ingrese un número entero.")
            End If

            Console.WriteLine()
        End While
    End Sub
End Module
