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
        Me.EmployeeListBox = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PayrollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(288, 69)
        Me.AddButton.Margin = New System.Windows.Forms.Padding(2)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(110, 24)
        Me.AddButton.TabIndex = 3
        Me.AddButton.Text = "Add Item"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'Load
        '
        Me.Load.Location = New System.Drawing.Point(345, 258)
        Me.Load.Margin = New System.Windows.Forms.Padding(2)
        Me.Load.Name = "Load"
        Me.Load.Size = New System.Drawing.Size(110, 24)
        Me.Load.TabIndex = 8
        Me.Load.Text = "Load Items"
        Me.Load.UseVisualStyleBackColor = True
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(345, 213)
        Me.Save.Margin = New System.Windows.Forms.Padding(2)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(110, 24)
        Me.Save.TabIndex = 7
        Me.Save.Text = "Save Items"
        Me.Save.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Location = New System.Drawing.Point(345, 168)
        Me.Delete.Margin = New System.Windows.Forms.Padding(2)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(110, 24)
        Me.Delete.TabIndex = 6
        Me.Delete.Text = "Delete Selected Item"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'EmployeeListBox
        '
        Me.EmployeeListBox.FormattingEnabled = True
        Me.EmployeeListBox.Location = New System.Drawing.Point(24, 23)
        Me.EmployeeListBox.Margin = New System.Windows.Forms.Padding(2)
        Me.EmployeeListBox.Name = "EmployeeListBox"
        Me.EmployeeListBox.Size = New System.Drawing.Size(144, 225)
        Me.EmployeeListBox.TabIndex = 9
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PayrollToolStripMenuItem, Me.SetupToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.PayrollToolStripMenuItem
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PayrollToolStripMenuItem
        '
        Me.PayrollToolStripMenuItem.Name = "PayrollToolStripMenuItem"
        Me.PayrollToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.PayrollToolStripMenuItem.Text = "Payroll"
        '
        'SetupToolStripMenuItem
        '
        Me.SetupToolStripMenuItem.Name = "SetupToolStripMenuItem"
        Me.SetupToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SetupToolStripMenuItem.Text = "Setup"
        '
        'Setup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.EmployeeListBox)
        Me.Controls.Add(Me.Load)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Setup"
        Me.Text = "Setup"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddButton As Button
    Friend WithEvents Load As Button
    Friend WithEvents Save As Button
    Friend WithEvents Delete As Button
    Friend WithEvents EmployeeListBox As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PayrollToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SetupToolStripMenuItem As ToolStripMenuItem
End Class
