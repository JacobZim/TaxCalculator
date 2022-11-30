Imports System.IO

Public Class Payroll
    Private Sub AddButton_Click(sender As Object, e As EventArgs)
        If (TextBoxHoursWorked.Text.Length() > 0) Then
            ListBoxEmployee.Items.Add(TextBoxHoursWorked.Text)
            TextBoxHoursWorked.Text = ""
        End If
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs)
        Dim Index As Integer = ListBoxEmployee.SelectedIndex()
        If Index >= 0 Then
            ListBoxEmployee.Items.RemoveAt(Index)
        End If
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs)
        Dim sFileName As String = "employees.txt"
        Dim fStreamWriter As StreamWriter = File.CreateText(sFileName)
        Dim count, i As Integer

        count = ListBoxEmployee.Items.Count
        fStreamWriter.WriteLine(count)
        For i = 0 To count - 1
            fStreamWriter.WriteLine(ListBoxEmployee.Items(i))
        Next
        fStreamWriter.Flush()
        fStreamWriter.Close()

    End Sub

    Private Sub Load_Employees_Click(sender As Object, e As EventArgs) Handles Load_Employees.Click
        ' first erase any old data
        ListBoxEmployee.Items.Clear()

        Dim sFileName As String = "employees.txt"
        If (File.Exists(sFileName)) Then
            Dim fStreamReader As StreamReader = File.OpenText(sFileName)
            Dim count As Integer
            Dim i As Integer
            Dim name As String

            count = fStreamReader.ReadLine
            For i = 1 To count
                name = fStreamReader.ReadLine
                ListBoxEmployee.Items.Add(name)
                fStreamReader.ReadLine()
                fStreamReader.ReadLine()
                fStreamReader.ReadLine()
                fStreamReader.ReadLine()
            Next

            fStreamReader.Close()
        End If 'file exists

    End Sub

    Private Sub SetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetupToolStripMenuItem.Click
        Setup.Show()
        Setup.Load_Click_Function()
    End Sub

    Private Sub ListBoxEmployee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxEmployee.SelectedIndexChanged
        CalculatePay()
    End Sub

    Private Sub CalculatePay()
        Setup.Load_Click_Function()
        If (ListBoxEmployee.SelectedIndex >= 0) Then
            Dim Index As Integer = ListBoxEmployee.SelectedIndex()
            TextBoxSalary.Text = Setup.ListBoxSalary.Items.Item(Index).ToString
            If (TextBoxHoursWorked.Text.Length > 0) Then
                TextBoxGross.Text = CStr(CDbl(Setup.ListBoxSalary.Items.Item(Index)) * CDbl(TextBoxHoursWorked.Text))
                TextBoxFICA.Text = CStr(CDbl(TextBoxGross.Text) * CDbl(Setup.ListBoxFICA.Items.Item(Index)))
                TextBoxFederal.Text = CStr(CDbl(TextBoxGross.Text) * CDbl(Setup.ListBoxFederal.Items.Item(Index)))
                TextBoxState.Text = CStr(CDbl(TextBoxGross.Text) * CDbl(Setup.ListBoxState.Items.Item(Index)))
                TextBoxNet.Text = CStr(CDbl(TextBoxGross.Text) - (CDbl(TextBoxFICA.Text) + CDbl(TextBoxFederal.Text) + CDbl(TextBoxState.Text)))
            End If
        End If
    End Sub

    Private Sub ButtonCalculate_Click(sender As Object, e As EventArgs) Handles ButtonCalculate.Click
        CalculatePay()
    End Sub
End Class
