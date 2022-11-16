Imports System.IO

Public Class Form1
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If (TextBox1.Text.Length() > 0) Then
            ListBox1.Items.Add(TextBox1.Text)
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Dim Index As Integer = ListBox1.SelectedIndex()
        If Index >= 0 Then
            ListBox1.Items.RemoveAt(Index)
        End If
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        Dim sFileName As String = "employees.txt"
        Dim fStreamWriter As StreamWriter = File.CreateText(sFileName)
        Dim count, i As Integer

        count = ListBox1.Items.Count
        fStreamWriter.WriteLine(count)
        For i = 0 To count - 1
            fStreamWriter.WriteLine(ListBox1.Items(i))
        Next
        fStreamWriter.Flush()
        fStreamWriter.Close()

    End Sub

    Private Sub Load_Click(sender As Object, e As EventArgs) Handles Load.Click
        ' first erase any old data
        ListBox1.Items.Clear()

        Dim sFileName As String = "employees.txt"
        If (File.Exists(sFileName)) Then
            Dim fStreamReader As StreamReader = File.OpenText(sFileName)
            Dim count As Integer
            Dim i As Integer
            Dim name As String

            count = fStreamReader.ReadLine
            For i = 1 To count
                name = fStreamReader.ReadLine
                ListBox1.Items.Add(name)
            Next

            fStreamReader.Close()
        End If 'file exists

    End Sub
End Class
