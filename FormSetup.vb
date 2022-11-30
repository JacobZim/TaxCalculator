Imports System.IO

Public Class Setup


    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If ((TextBoxAddName.Text.Length() > 0) And
            (TextBoxAddFICA.Text.Length() > 0) And
            (TextBoxAddFederal.Text.Length() > 0) And
            (TextBoxAddState.Text.Length() > 0) And
            (TextBoxAddHourly.Text.Length() > 0)) Then
            ListBoxEmployee.Items.Add(TextBoxAddName.Text)
            ListBoxFICA.Items.Add(TextBoxAddFICA.Text)
            ListBoxFederal.Items.Add(TextBoxAddFederal.Text)
            ListBoxState.Items.Add(TextBoxAddState.Text)
            ListBoxSalary.Items.Add(TextBoxAddHourly.Text)
            TextBoxAddName.Text = ""
            TextBoxAddFICA.Text = ""
            TextBoxAddFederal.Text = ""
            TextBoxAddState.Text = ""
            TextBoxAddHourly.Text = ""
        End If
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Dim Index As Integer = ListBoxEmployee.SelectedIndex()
        If Index >= 0 Then
            ListBoxEmployee.Items.RemoveAt(Index)
            ListBoxFICA.Items.RemoveAt(Index)
            ListBoxFederal.Items.RemoveAt(Index)
            ListBoxState.Items.RemoveAt(Index)
            ListBoxSalary.Items.RemoveAt(Index)
        End If
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        Dim sFileName As String = "employees.txt"
        Dim fStreamWriter As StreamWriter = File.CreateText(sFileName)
        Dim count, i As Integer

        count = ListBoxEmployee.Items.Count
        fStreamWriter.WriteLine(count)
        For i = 0 To count - 1
            fStreamWriter.WriteLine(ListBoxEmployee.Items(i))
            fStreamWriter.WriteLine(ListBoxFICA.Items(i))
            fStreamWriter.WriteLine(ListBoxFederal.Items(i))
            fStreamWriter.WriteLine(ListBoxState.Items(i))
            fStreamWriter.WriteLine(ListBoxSalary.Items(i))
        Next
        fStreamWriter.Flush()
        fStreamWriter.Close()
        Me.Close()
        Load_Click_Function()
    End Sub


    Private Sub Load_Click(sender As Object, e As EventArgs) Handles Load.Click
        Dim Index As Integer = ListBoxEmployee.SelectedIndex()
        If Index >= 0 Then
            ListBoxEmployee.Items.RemoveAt(Index)
            ListBoxFICA.Items.RemoveAt(Index)
            ListBoxFederal.Items.RemoveAt(Index)
            ListBoxState.Items.RemoveAt(Index)
            ListBoxSalary.Items.RemoveAt(Index)

            ListBoxEmployee.Items.Add(TextBoxName.Text)
            ListBoxFICA.Items.Add(TextBoxFICA.Text)
            ListBoxFederal.Items.Add(TextBoxFederal.Text)
            ListBoxState.Items.Add(TextBoxState.Text)
            ListBoxSalary.Items.Add(TextBoxHourly.Text)
        End If
    End Sub

    Public Sub Load_Click_Function()
        ' first erase any old data
        ListBoxEmployee.Items.Clear()
        ListBoxFICA.Items.Clear()
        ListBoxFederal.Items.Clear()
        ListBoxState.Items.Clear()
        ListBoxSalary.Items.Clear()

        Dim sFileName As String = "employees.txt"
        If (File.Exists(sFileName)) Then
            Dim fStreamReader As StreamReader = File.OpenText(sFileName)
            Dim count As Integer
            Dim i As Integer
            Dim name As String
            Dim FICA As String
            Dim Federal As String
            Dim State As String
            Dim Hourly As String

            count = fStreamReader.ReadLine
            For i = 1 To count
                name = fStreamReader.ReadLine
                ListBoxEmployee.Items.Add(name)
                FICA = fStreamReader.ReadLine
                ListBoxFICA.Items.Add(FICA)
                Federal = fStreamReader.ReadLine
                ListBoxFederal.Items.Add(Federal)
                State = fStreamReader.ReadLine
                ListBoxState.Items.Add(State)
                Hourly = fStreamReader.ReadLine
                ListBoxSalary.Items.Add(Hourly)
            Next

            fStreamReader.Close()
        End If 'file exists
    End Sub

    Private Sub EmployeeListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxEmployee.SelectedIndexChanged
        'Load_Click_Function()

        TextBoxName.ReadOnly = False
        TextBoxFICA.ReadOnly = False
        TextBoxFederal.ReadOnly = False
        TextBoxState.ReadOnly = False
        TextBoxHourly.ReadOnly = False
        If (ListBoxEmployee.SelectedIndex >= 0) Then
            Dim Index As Integer = ListBoxEmployee.SelectedIndex()
            TextBoxName.Text = ListBoxEmployee.Items.Item(Index)
            TextBoxFICA.Text = ListBoxFICA.Items.Item(Index)
            TextBoxFederal.Text = ListBoxFederal.Items.Item(Index)
            TextBoxState.Text = ListBoxState.Items.Item(Index)
            TextBoxHourly.Text = ListBoxSalary.Items.Item(Index)
        End If
    End Sub

    Private Sub TextBoxName_TextChanged(sender As Object, e As EventArgs) Handles TextBoxName.TextChanged

    End Sub
End Class