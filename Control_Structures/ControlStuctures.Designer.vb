<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlStructures
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
        Me.IncrementButton = New System.Windows.Forms.Button()
        Me.OutputLabel = New System.Windows.Forms.Label()
        Me.DoUntilLabel = New System.Windows.Forms.Label()
        Me.DoWhileLabel = New System.Windows.Forms.Label()
        Me.OutputLabel2 = New System.Windows.Forms.Label()
        Me.DoLoopWhileLabel = New System.Windows.Forms.Label()
        Me.OutputLabel3 = New System.Windows.Forms.Label()
        Me.ForNextLabel = New System.Windows.Forms.Label()
        Me.OutputLabel4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'IncrementButton
        '
        Me.IncrementButton.Location = New System.Drawing.Point(12, 63)
        Me.IncrementButton.Name = "IncrementButton"
        Me.IncrementButton.Size = New System.Drawing.Size(75, 34)
        Me.IncrementButton.TabIndex = 0
        Me.IncrementButton.Text = "Increment"
        Me.IncrementButton.UseVisualStyleBackColor = True
        '
        'OutputLabel
        '
        Me.OutputLabel.AutoSize = True
        Me.OutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.OutputLabel.Location = New System.Drawing.Point(12, 40)
        Me.OutputLabel.Name = "OutputLabel"
        Me.OutputLabel.Size = New System.Drawing.Size(2, 15)
        Me.OutputLabel.TabIndex = 2
        '
        'DoUntilLabel
        '
        Me.DoUntilLabel.AutoSize = True
        Me.DoUntilLabel.Location = New System.Drawing.Point(12, 13)
        Me.DoUntilLabel.Name = "DoUntilLabel"
        Me.DoUntilLabel.Size = New System.Drawing.Size(45, 13)
        Me.DoUntilLabel.TabIndex = 3
        Me.DoUntilLabel.Text = "Do Until"
        '
        'DoWhileLabel
        '
        Me.DoWhileLabel.AutoSize = True
        Me.DoWhileLabel.Location = New System.Drawing.Point(137, 13)
        Me.DoWhileLabel.Name = "DoWhileLabel"
        Me.DoWhileLabel.Size = New System.Drawing.Size(51, 13)
        Me.DoWhileLabel.TabIndex = 5
        Me.DoWhileLabel.Text = "Do While"
        '
        'OutputLabel2
        '
        Me.OutputLabel2.AutoSize = True
        Me.OutputLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.OutputLabel2.Location = New System.Drawing.Point(137, 40)
        Me.OutputLabel2.Name = "OutputLabel2"
        Me.OutputLabel2.Size = New System.Drawing.Size(2, 15)
        Me.OutputLabel2.TabIndex = 4
        '
        'DoLoopWhileLabel
        '
        Me.DoLoopWhileLabel.AutoSize = True
        Me.DoLoopWhileLabel.Location = New System.Drawing.Point(12, 110)
        Me.DoLoopWhileLabel.Name = "DoLoopWhileLabel"
        Me.DoLoopWhileLabel.Size = New System.Drawing.Size(78, 13)
        Me.DoLoopWhileLabel.TabIndex = 7
        Me.DoLoopWhileLabel.Text = "Do Loop While"
        '
        'OutputLabel3
        '
        Me.OutputLabel3.AutoSize = True
        Me.OutputLabel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.OutputLabel3.Location = New System.Drawing.Point(12, 137)
        Me.OutputLabel3.Name = "OutputLabel3"
        Me.OutputLabel3.Size = New System.Drawing.Size(2, 15)
        Me.OutputLabel3.TabIndex = 6
        '
        'ForNextLabel
        '
        Me.ForNextLabel.AutoSize = True
        Me.ForNextLabel.Location = New System.Drawing.Point(137, 110)
        Me.ForNextLabel.Name = "ForNextLabel"
        Me.ForNextLabel.Size = New System.Drawing.Size(47, 13)
        Me.ForNextLabel.TabIndex = 9
        Me.ForNextLabel.Text = "For Next"
        '
        'OutputLabel4
        '
        Me.OutputLabel4.AutoSize = True
        Me.OutputLabel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.OutputLabel4.Location = New System.Drawing.Point(137, 137)
        Me.OutputLabel4.Name = "OutputLabel4"
        Me.OutputLabel4.Size = New System.Drawing.Size(2, 15)
        Me.OutputLabel4.TabIndex = 8
        '
        'ControlStructures
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.ForNextLabel)
        Me.Controls.Add(Me.OutputLabel4)
        Me.Controls.Add(Me.DoLoopWhileLabel)
        Me.Controls.Add(Me.OutputLabel3)
        Me.Controls.Add(Me.DoWhileLabel)
        Me.Controls.Add(Me.OutputLabel2)
        Me.Controls.Add(Me.DoUntilLabel)
        Me.Controls.Add(Me.OutputLabel)
        Me.Controls.Add(Me.IncrementButton)
        Me.Name = "ControlStructures"
        Me.Text = "Control Structures"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IncrementButton As System.Windows.Forms.Button
    Friend WithEvents OutputLabel As System.Windows.Forms.Label
    Friend WithEvents DoUntilLabel As System.Windows.Forms.Label
    Friend WithEvents DoWhileLabel As System.Windows.Forms.Label
    Friend WithEvents OutputLabel2 As System.Windows.Forms.Label
    Friend WithEvents DoLoopWhileLabel As System.Windows.Forms.Label
    Friend WithEvents OutputLabel3 As System.Windows.Forms.Label
    Friend WithEvents ForNextLabel As System.Windows.Forms.Label
    Friend WithEvents OutputLabel4 As System.Windows.Forms.Label

End Class
