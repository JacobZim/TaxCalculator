Imports System.IO

Public Class Payroll
    Private Sub AddButton_Click(sender As Object, e As EventArgs)
        If (TextBox1.Text.Length() > 0) Then
            EmployeeListBox.Items.Add(TextBox1.Text)
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs)
        Dim Index As Integer = EmployeeListBox.SelectedIndex()
        If Index >= 0 Then
            EmployeeListBox.Items.RemoveAt(Index)
        End If
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs)
        Dim sFileName As String = "employees.txt"
        Dim fStreamWriter As StreamWriter = File.CreateText(sFileName)
        Dim count, i As Integer

        count = EmployeeListBox.Items.Count
        fStreamWriter.WriteLine(count)
        For i = 0 To count - 1
            fStreamWriter.WriteLine(EmployeeListBox.Items(i))
        Next
        fStreamWriter.Flush()
        fStreamWriter.Close()

    End Sub

    Private Sub Load_Click(sender As Object, e As EventArgs)
        ' first erase any old data
        EmployeeListBox.Items.Clear()

        Dim sFileName As String = "employees.txt"
        If (File.Exists(sFileName)) Then
            Dim fStreamReader As StreamReader = File.OpenText(sFileName)
            Dim count As Integer
            Dim i As Integer
            Dim name As String

            count = fStreamReader.ReadLine
            For i = 1 To count
                name = fStreamReader.ReadLine
                EmployeeListBox.Items.Add(name)
            Next

            fStreamReader.Close()
        End If 'file exists

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
