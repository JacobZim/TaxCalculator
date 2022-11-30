<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Payroll
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ListBoxEmployee = New System.Windows.Forms.ListBox()
        Me.TextBoxHoursWorked = New System.Windows.Forms.TextBox()
        Me.ButtonCalculate = New System.Windows.Forms.Button()
        Me.TextBoxFICA = New System.Windows.Forms.TextBox()
        Me.TextBoxFederal = New System.Windows.Forms.TextBox()
        Me.TextBoxState = New System.Windows.Forms.TextBox()
        Me.TextBoxNet = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxGross = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxSalary = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Load_Employees = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBoxEmployee
        '
        Me.ListBoxEmployee.FormattingEnabled = True
        Me.ListBoxEmployee.Location = New System.Drawing.Point(47, 88)
        Me.ListBoxEmployee.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBoxEmployee.Name = "ListBoxEmployee"
        Me.ListBoxEmployee.Size = New System.Drawing.Size(144, 225)
        Me.ListBoxEmployee.TabIndex = 0
        '
        'TextBoxHoursWorked
        '
        Me.TextBoxHoursWorked.Location = New System.Drawing.Point(331, 325)
        Me.TextBoxHoursWorked.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxHoursWorked.Name = "TextBoxHoursWorked"
        Me.TextBoxHoursWorked.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxHoursWorked.TabIndex = 1
        '
        'ButtonCalculate
        '
        Me.ButtonCalculate.Location = New System.Drawing.Point(311, 350)
        Me.ButtonCalculate.Name = "ButtonCalculate"
        Me.ButtonCalculate.Size = New System.Drawing.Size(140, 23)
        Me.ButtonCalculate.TabIndex = 6
        Me.ButtonCalculate.Text = "Compute Deductions"
        Me.ButtonCalculate.UseVisualStyleBackColor = True
        '
        'TextBoxFICA
        '
        Me.TextBoxFICA.Location = New System.Drawing.Point(498, 145)
        Me.TextBoxFICA.Name = "TextBoxFICA"
        Me.TextBoxFICA.ReadOnly = True
        Me.TextBoxFICA.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxFICA.TabIndex = 7
        '
        'TextBoxFederal
        '
        Me.TextBoxFederal.Location = New System.Drawing.Point(498, 195)
        Me.TextBoxFederal.Name = "TextBoxFederal"
        Me.TextBoxFederal.ReadOnly = True
        Me.TextBoxFederal.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxFederal.TabIndex = 8
        '
        'TextBoxState
        '
        Me.TextBoxState.Location = New System.Drawing.Point(498, 249)
        Me.TextBoxState.Name = "TextBoxState"
        Me.TextBoxState.ReadOnly = True
        Me.TextBoxState.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxState.TabIndex = 9
        '
        'TextBoxNet
        '
        Me.TextBoxNet.Location = New System.Drawing.Point(498, 301)
        Me.TextBoxNet.Name = "TextBoxNet"
        Me.TextBoxNet.ReadOnly = True
        Me.TextBoxNet.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNet.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(345, 308)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Hours Worked"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(523, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "FICA Tax"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(519, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Federal Tax"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(523, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "State Tax"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(529, 285)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Net Pay"
        '
        'TextBoxGross
        '
        Me.TextBoxGross.Location = New System.Drawing.Point(498, 88)
        Me.TextBoxGross.Name = "TextBoxGross"
        Me.TextBoxGross.ReadOnly = True
        Me.TextBoxGross.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxGross.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(522, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Gross Pay"
        '
        'TextBoxSalary
        '
        Me.TextBoxSalary.Location = New System.Drawing.Point(268, 88)
        Me.TextBoxSalary.Name = "TextBoxSalary"
        Me.TextBoxSalary.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxSalary.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(212, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Salary"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(47, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Employees"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetupToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(661, 24)
        Me.MenuStrip1.TabIndex = 23
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SetupToolStripMenuItem
        '
        Me.SetupToolStripMenuItem.Name = "SetupToolStripMenuItem"
        Me.SetupToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SetupToolStripMenuItem.Text = "Setup"
        '
        'Load_Employees
        '
        Me.Load_Employees.Location = New System.Drawing.Point(47, 318)
        Me.Load_Employees.Name = "Load_Employees"
        Me.Load_Employees.Size = New System.Drawing.Size(144, 23)
        Me.Load_Employees.TabIndex = 31
        Me.Load_Employees.Text = "Load Employee List"
        Me.Load_Employees.UseVisualStyleBackColor = True
        '
        'Payroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 404)
        Me.Controls.Add(Me.Load_Employees)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBoxSalary)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxGross)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxNet)
        Me.Controls.Add(Me.TextBoxState)
        Me.Controls.Add(Me.TextBoxFederal)
        Me.Controls.Add(Me.TextBoxFICA)
        Me.Controls.Add(Me.ButtonCalculate)
        Me.Controls.Add(Me.TextBoxHoursWorked)
        Me.Controls.Add(Me.ListBoxEmployee)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Payroll"
        Me.Text = "Payroll"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxEmployee As ListBox
    Friend WithEvents TextBoxHoursWorked As TextBox
    Friend WithEvents ButtonCalculate As Button
    Friend WithEvents TextBoxFICA As TextBox
    Friend WithEvents TextBoxFederal As TextBox
    Friend WithEvents TextBoxState As TextBox
    Friend WithEvents TextBoxNet As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxGross As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxSalary As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SetupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Load_Employees As Button
End Class
