Public Class Array

    Public Sub runArrayBasic()
        Dim intData(5) As Integer
        Dim i, j As Integer

        For i = 0 To 4
            intData(i) = i + 10
        Next

        For j = 0 To 4
            ListBoxArray.Items.Add(intData(j))
        Next
    End Sub

    Public Sub runArrayDynamic()
        Dim buah(5) As String
        buah(0) = "Apple"
        buah(1) = "Pisang"
        buah(2) = "Mangga"
        buah(3) = "Jambu"
        buah(4) = "Rambutan"

        ReDim Preserve buah(8)
        buah(5) = "Salak"
        buah(6) = "Durian"
        buah(7) = "Sirsak"

        For i = 0 To 7
            ListBoxArrayDynamic.Items.Add(buah(i))
        Next
    End Sub

    Public Sub runArrayMultiDimension()
        Dim buahJumlah(,) As Object = {{"Apple", 3}, {"Pisang", 10}, {"Mangga", 7}, {"Jambu", 5}, {"Rambutan", 15}}

        For i_horizontal = 0 To 4
            Dim buahDanJumlah As String = ""
            For j_vertical = 0 To 1
                buahDanJumlah += buahJumlah(i_horizontal, j_vertical) & " | "
            Next
            ListBoxArrayMulti.Items.Add(buahDanJumlah)
        Next
    End Sub

    Public Sub runArrayList()
        Dim student As New ArrayList()
        student.Add({"Amir", "TI-3A", "Jakarta", "2020"})
        student.Add({"Mira", "TI-3B", "Jakarta", "2021"})

        For Each rowStudent In student
            Dim dataList As String = rowStudent(0) & " | " & rowStudent(1) & " | " & rowStudent(2) & " | " & rowStudent(3)
            ListArrayList.Items.Add(datalist)
        Next
    End Sub

    Public Sub runHashTable()
        Dim students As New Hashtable()

        students.Add("A100", {"Amir", "TI-3A", "Jakarta", "2020"})
        students.Add("A101", {"Mira", "TI-3B", "Jakarta", "2021"})

        Dim keyStudents As ICollection = students.Keys()

        For Each rowKoleksis In keyStudents
            Dim rowStudent As String() = students(rowKoleksis)
            Dim dataList As String = rowStudent(0) & " | " & rowStudent(1) & " | " & rowStudent(2) & " | " & rowStudent(3)
            ListHashtable.Items.Add(dataList)
        Next
    End Sub

    Public Sub runStackCollection()
        Dim stackBuah As Stack = New Stack()
        stackBuah.Push("Apple")
        stackBuah.Push("Pisang")
        stackBuah.Push("Mangga")
        stackBuah.Push("Rambutan")

        For Each item In stackBuah
            ListBoxStack.Items.Add(item)
        Next
    End Sub

    Public Sub runQueueCollection()
        Dim queueBuah As Queue = New Queue()
        queueBuah.Enqueue("Apple")
        queueBuah.Enqueue("Pisang")
        queueBuah.Enqueue("Mangga")
        queueBuah.Enqueue("Rambutan")

        For Each item In queueBuah
            ListBoxQueue.Items.Add(item)
        Next
    End Sub

    Private Sub Array_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        runArrayBasic()
        runArrayDynamic()
        runArrayMultiDimension()
        runArrayList()
        runHashTable()
        runStackCollection()
        runQueueCollection()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Close()
    End Sub

End Class