<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Setup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.Load = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.ListBoxEmployee = New System.Windows.Forms.ListBox()
        Me.TextBoxAddName = New System.Windows.Forms.TextBox()
        Me.New_Employee = New System.Windows.Forms.Label()
        Me.New_Name = New System.Windows.Forms.Label()
        Me.FICA = New System.Windows.Forms.Label()
        Me.TextBoxAddFICA = New System.Windows.Forms.TextBox()
        Me.Federal = New System.Windows.Forms.Label()
        Me.TextBoxAddFederal = New System.Windows.Forms.TextBox()
        Me.State = New System.Windows.Forms.Label()
        Me.TextBoxAddState = New System.Windows.Forms.TextBox()
        Me.Hourly = New System.Windows.Forms.Label()
        Me.TextBoxAddHourly = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxHourly = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxState = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxFederal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxFICA = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Edit_Employee = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ListBoxSalary = New System.Windows.Forms.ListBox()
        Me.ListBoxState = New System.Windows.Forms.ListBox()
        Me.ListBoxFederal = New System.Windows.Forms.ListBox()
        Me.ListBoxFICA = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(523, 258)
        Me.AddButton.Margin = New System.Windows.Forms.Padding(2)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(110, 24)
        Me.AddButton.TabIndex = 3
        Me.AddButton.Text = "Add Employee"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'Load
        '
        Me.Load.Location = New System.Drawing.Point(339, 258)
        Me.Load.Margin = New System.Windows.Forms.Padding(2)
        Me.Load.Name = "Load"
        Me.Load.Size = New System.Drawing.Size(110, 24)
        Me.Load.TabIndex = 8
        Me.Load.Text = "Make Changes"
        Me.Load.UseVisualStyleBackColor = True
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(546, 341)
        Me.Save.Margin = New System.Windows.Forms.Padding(2)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(110, 24)
        Me.Save.TabIndex = 7
        Me.Save.Text = "Save Changes"
        Me.Save.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Location = New System.Drawing.Point(81, 340)
        Me.Delete.Margin = New System.Windows.Forms.Padding(2)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(110, 24)
        Me.Delete.TabIndex = 6
        Me.Delete.Text = "Delete Selected Item"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'ListBoxEmployee
        '
        Me.ListBoxEmployee.FormattingEnabled = True
        Me.ListBoxEmployee.Location = New System.Drawing.Point(81, 54)
        Me.ListBoxEmployee.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBoxEmployee.Name = "ListBoxEmployee"
        Me.ListBoxEmployee.Size = New System.Drawing.Size(144, 225)
        Me.ListBoxEmployee.TabIndex = 9
        '
        'TextBoxAddName
        '
        Me.TextBoxAddName.Location = New System.Drawing.Point(529, 72)
        Me.TextBoxAddName.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxAddName.Name = "TextBoxAddName"
        Me.TextBoxAddName.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxAddName.TabIndex = 11
        '
        'New_Employee
        '
        Me.New_Employee.AutoSize = True
        Me.New_Employee.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.New_Employee.Location = New System.Drawing.Point(526, 26)
        Me.New_Employee.Name = "New_Employee"
        Me.New_Employee.Size = New System.Drawing.Size(130, 17)
        Me.New_Employee.TabIndex = 12
        Me.New_Employee.Text = "Add New Employee"
        '
        'New_Name
        '
        Me.New_Name.AutoSize = True
        Me.New_Name.Location = New System.Drawing.Point(529, 54)
        Me.New_Name.Name = "New_Name"
        Me.New_Name.Size = New System.Drawing.Size(35, 13)
        Me.New_Name.TabIndex = 13
        Me.New_Name.Text = "Name"
        '
        'FICA
        '
        Me.FICA.AutoSize = True
        Me.FICA.Location = New System.Drawing.Point(529, 92)
        Me.FICA.Name = "FICA"
        Me.FICA.Size = New System.Drawing.Size(58, 13)
        Me.FICA.TabIndex = 15
        Me.FICA.Text = "FICA tax %"
        '
        'TextBoxAddFICA
        '
        Me.TextBoxAddFICA.Location = New System.Drawing.Point(529, 110)
        Me.TextBoxAddFICA.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxAddFICA.Name = "TextBoxAddFICA"
        Me.TextBoxAddFICA.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxAddFICA.TabIndex = 14
        '
        'Federal
        '
        Me.Federal.AutoSize = True
        Me.Federal.Location = New System.Drawing.Point(529, 130)
        Me.Federal.Name = "Federal"
        Me.Federal.Size = New System.Drawing.Size(70, 13)
        Me.Federal.TabIndex = 17
        Me.Federal.Text = "Federal tax %"
        '
        'TextBoxAddFederal
        '
        Me.TextBoxAddFederal.Location = New System.Drawing.Point(529, 148)
        Me.TextBoxAddFederal.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxAddFederal.Name = "TextBoxAddFederal"
        Me.TextBoxAddFederal.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxAddFederal.TabIndex = 16
        '
        'State
        '
        Me.State.AutoSize = True
        Me.State.Location = New System.Drawing.Point(529, 170)
        Me.State.Name = "State"
        Me.State.Size = New System.Drawing.Size(60, 13)
        Me.State.TabIndex = 19
        Me.State.Text = "State tax %"
        '
        'TextBoxAddState
        '
        Me.TextBoxAddState.Location = New System.Drawing.Point(529, 188)
        Me.TextBoxAddState.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxAddState.Name = "TextBoxAddState"
        Me.TextBoxAddState.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxAddState.TabIndex = 18
        '
        'Hourly
        '
        Me.Hourly.AutoSize = True
        Me.Hourly.Location = New System.Drawing.Point(529, 213)
        Me.Hourly.Name = "Hourly"
        Me.Hourly.Size = New System.Drawing.Size(69, 13)
        Me.Hourly.TabIndex = 21
        Me.Hourly.Text = "Hourly Salary"
        '
        'TextBoxAddHourly
        '
        Me.TextBoxAddHourly.Location = New System.Drawing.Point(529, 231)
        Me.TextBoxAddHourly.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxAddHourly.Name = "TextBoxAddHourly"
        Me.TextBoxAddHourly.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxAddHourly.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(345, 213)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Hourly Salary"
        '
        'TextBoxHourly
        '
        Me.TextBoxHourly.Location = New System.Drawing.Point(345, 231)
        Me.TextBoxHourly.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxHourly.Name = "TextBoxHourly"
        Me.TextBoxHourly.ReadOnly = True
        Me.TextBoxHourly.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxHourly.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(345, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "State tax %"
        '
        'TextBoxState
        '
        Me.TextBoxState.Location = New System.Drawing.Point(345, 188)
        Me.TextBoxState.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxState.Name = "TextBoxState"
        Me.TextBoxState.ReadOnly = True
        Me.TextBoxState.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxState.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(345, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Federal tax %"
        '
        'TextBoxFederal
        '
        Me.TextBoxFederal.Location = New System.Drawing.Point(345, 148)
        Me.TextBoxFederal.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxFederal.Name = "TextBoxFederal"
        Me.TextBoxFederal.ReadOnly = True
        Me.TextBoxFederal.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxFederal.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(345, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "FICA tax %"
        '
        'TextBoxFICA
        '
        Me.TextBoxFICA.Location = New System.Drawing.Point(345, 110)
        Me.TextBoxFICA.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxFICA.Name = "TextBoxFICA"
        Me.TextBoxFICA.ReadOnly = True
        Me.TextBoxFICA.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxFICA.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(345, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Name"
        '
        'Edit_Employee
        '
        Me.Edit_Employee.AutoSize = True
        Me.Edit_Employee.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Edit_Employee.Location = New System.Drawing.Point(342, 26)
        Me.Edit_Employee.Name = "Edit_Employee"
        Me.Edit_Employee.Size = New System.Drawing.Size(98, 17)
        Me.Edit_Employee.TabIndex = 23
        Me.Edit_Employee.Text = "Edit Employee"
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(345, 72)
        Me.TextBoxName.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.ReadOnly = True
        Me.TextBoxName.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxName.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(78, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Employees"
        '
        'ListBoxSalary
        '
        Me.ListBoxSalary.FormattingEnabled = True
        Me.ListBoxSalary.Location = New System.Drawing.Point(446, 341)
        Me.ListBoxSalary.Name = "ListBoxSalary"
        Me.ListBoxSalary.Size = New System.Drawing.Size(54, 30)
        Me.ListBoxSalary.TabIndex = 37
        Me.ListBoxSalary.Visible = False
        '
        'ListBoxState
        '
        Me.ListBoxState.FormattingEnabled = True
        Me.ListBoxState.Location = New System.Drawing.Point(386, 341)
        Me.ListBoxState.Name = "ListBoxState"
        Me.ListBoxState.Size = New System.Drawing.Size(54, 30)
        Me.ListBoxState.TabIndex = 36
        Me.ListBoxState.Visible = False
        '
        'ListBoxFederal
        '
        Me.ListBoxFederal.FormattingEnabled = True
        Me.ListBoxFederal.Location = New System.Drawing.Point(324, 341)
        Me.ListBoxFederal.Name = "ListBoxFederal"
        Me.ListBoxFederal.Size = New System.Drawing.Size(56, 30)
        Me.ListBoxFederal.TabIndex = 35
        Me.ListBoxFederal.Visible = False
        '
        'ListBoxFICA
        '
        Me.ListBoxFICA.FormattingEnabled = True
        Me.ListBoxFICA.Location = New System.Drawing.Point(262, 341)
        Me.ListBoxFICA.Name = "ListBoxFICA"
        Me.ListBoxFICA.Size = New System.Drawing.Size(56, 30)
        Me.ListBoxFICA.TabIndex = 34
        Me.ListBoxFICA.Visible = False
        '
        'Setup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 375)
        Me.Controls.Add(Me.ListBoxSalary)
        Me.Controls.Add(Me.ListBoxState)
        Me.Controls.Add(Me.ListBoxFederal)
        Me.Controls.Add(Me.ListBoxFICA)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxHourly)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxState)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxFederal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxFICA)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Edit_Employee)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.Hourly)
        Me.Controls.Add(Me.TextBoxAddHourly)
        Me.Controls.Add(Me.State)
        Me.Controls.Add(Me.TextBoxAddState)
        Me.Controls.Add(Me.Federal)
        Me.Controls.Add(Me.TextBoxAddFederal)
        Me.Controls.Add(Me.FICA)
        Me.Controls.Add(Me.TextBoxAddFICA)
        Me.Controls.Add(Me.New_Name)
        Me.Controls.Add(Me.New_Employee)
        Me.Controls.Add(Me.TextBoxAddName)
        Me.Controls.Add(Me.ListBoxEmployee)
        Me.Controls.Add(Me.Load)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.AddButton)
        Me.Name = "Setup"
        Me.Text = "Setup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddButton As Button
    Friend WithEvents Load As Button
    Friend WithEvents Save As Button
    Friend WithEvents Delete As Button
    Friend WithEvents ListBoxEmployee As ListBox
    Friend WithEvents TextBoxAddName As TextBox
    Friend WithEvents New_Employee As Label
    Friend WithEvents New_Name As Label
    Friend WithEvents FICA As Label
    Friend WithEvents TextBoxAddFICA As TextBox
    Friend WithEvents Federal As Label
    Friend WithEvents TextBoxAddFederal As TextBox
    Friend WithEvents State As Label
    Friend WithEvents TextBoxAddState As TextBox
    Friend WithEvents Hourly As Label
    Friend WithEvents TextBoxAddHourly As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxHourly As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxState As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxFederal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxFICA As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Edit_Employee As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ListBoxSalary As ListBox
    Friend WithEvents ListBoxState As ListBox
    Friend WithEvents ListBoxFederal As ListBox
    Friend WithEvents ListBoxFICA As ListBox
End Class
