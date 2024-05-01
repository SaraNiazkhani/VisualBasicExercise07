<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        OutputLabel = New Label()
        RunButton = New Button()
        ExitButton = New Button()
        SuspendLayout()
        ' 
        ' OutputLabel
        ' 
        OutputLabel.AutoSize = True
        OutputLabel.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        OutputLabel.Location = New Point(193, 81)
        OutputLabel.Name = "OutputLabel"
        OutputLabel.Size = New Size(0, 20)
        OutputLabel.TabIndex = 0
        ' 
        ' RunButton
        ' 
        RunButton.BackColor = Color.Cyan
        RunButton.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        RunButton.Location = New Point(153, 211)
        RunButton.Name = "RunButton"
        RunButton.Size = New Size(93, 33)
        RunButton.TabIndex = 1
        RunButton.Text = "اجرا"
        RunButton.UseVisualStyleBackColor = False
        ' 
        ' ExitButton
        ' 
        ExitButton.BackColor = Color.DarkSlateBlue
        ExitButton.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ExitButton.Location = New Point(304, 285)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(98, 42)
        ExitButton.TabIndex = 2
        ExitButton.Text = "خروج"
        ExitButton.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(414, 339)
        Controls.Add(ExitButton)
        Controls.Add(RunButton)
        Controls.Add(OutputLabel)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents OutputLabel As Label
    Friend WithEvents RunButton As Button
    Friend WithEvents ExitButton As Button
End Class
