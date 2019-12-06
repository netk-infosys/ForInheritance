Module Module1

    Sub Main()
        Dim currentClient As Client = New Client("Иванов", "Иван", "НБД")
        Dim currentEmployee As Employee = New Employee("Петров", "Петр", "НБД")

        currentClient.Display()
        currentEmployee.Display()

        Console.ReadLine()

    End Sub

End Module
