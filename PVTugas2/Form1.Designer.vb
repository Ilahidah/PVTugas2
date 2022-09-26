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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnQuittingAForLoop = New System.Windows.Forms.Button()
        Me.btnNestedLoop = New System.Windows.Forms.Button()
        Me.btnDoWhileLoop = New System.Windows.Forms.Button()
        Me.btnDoUntillLoop = New System.Windows.Forms.Button()
        Me.btnForBackwardLoop = New System.Windows.Forms.Button()
        Me.btnEachLoop = New System.Windows.Forms.Button()
        Me.btnForNextLoopStep = New System.Windows.Forms.Button()
        Me.btnForNextLoop = New System.Windows.Forms.Button()
        Me.lstData = New System.Windows.Forms.ListBox()
        Me.btnQuittingADoLoop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(89, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(345, 74)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CHAPTER 4 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CONTROLLING THE FLOW"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(122, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "(Especially for Loop and the next sub till end chap)"
        '
        'btnQuittingAForLoop
        '
        Me.btnQuittingAForLoop.Location = New System.Drawing.Point(293, 382)
        Me.btnQuittingAForLoop.Name = "btnQuittingAForLoop"
        Me.btnQuittingAForLoop.Size = New System.Drawing.Size(151, 23)
        Me.btnQuittingAForLoop.TabIndex = 19
        Me.btnQuittingAForLoop.Text = "Quitting A For Loop"
        Me.btnQuittingAForLoop.UseVisualStyleBackColor = True
        '
        'btnNestedLoop
        '
        Me.btnNestedLoop.Location = New System.Drawing.Point(293, 353)
        Me.btnNestedLoop.Name = "btnNestedLoop"
        Me.btnNestedLoop.Size = New System.Drawing.Size(151, 23)
        Me.btnNestedLoop.TabIndex = 18
        Me.btnNestedLoop.Text = "Nested Loop"
        Me.btnNestedLoop.UseVisualStyleBackColor = True
        '
        'btnDoWhileLoop
        '
        Me.btnDoWhileLoop.Location = New System.Drawing.Point(293, 324)
        Me.btnDoWhileLoop.Name = "btnDoWhileLoop"
        Me.btnDoWhileLoop.Size = New System.Drawing.Size(151, 23)
        Me.btnDoWhileLoop.TabIndex = 17
        Me.btnDoWhileLoop.Text = "Do While Loop"
        Me.btnDoWhileLoop.UseVisualStyleBackColor = True
        '
        'btnDoUntillLoop
        '
        Me.btnDoUntillLoop.Location = New System.Drawing.Point(293, 295)
        Me.btnDoUntillLoop.Name = "btnDoUntillLoop"
        Me.btnDoUntillLoop.Size = New System.Drawing.Size(151, 23)
        Me.btnDoUntillLoop.TabIndex = 16
        Me.btnDoUntillLoop.Text = "Do Until Loop"
        Me.btnDoUntillLoop.UseVisualStyleBackColor = True
        '
        'btnForBackwardLoop
        '
        Me.btnForBackwardLoop.Location = New System.Drawing.Point(293, 236)
        Me.btnForBackwardLoop.Name = "btnForBackwardLoop"
        Me.btnForBackwardLoop.Size = New System.Drawing.Size(151, 23)
        Me.btnForBackwardLoop.TabIndex = 15
        Me.btnForBackwardLoop.Text = "For Backward Loop"
        Me.btnForBackwardLoop.UseVisualStyleBackColor = True
        '
        'btnEachLoop
        '
        Me.btnEachLoop.Location = New System.Drawing.Point(293, 265)
        Me.btnEachLoop.Name = "btnEachLoop"
        Me.btnEachLoop.Size = New System.Drawing.Size(151, 24)
        Me.btnEachLoop.TabIndex = 14
        Me.btnEachLoop.Text = "For Each Loop"
        Me.btnEachLoop.UseVisualStyleBackColor = True
        '
        'btnForNextLoopStep
        '
        Me.btnForNextLoopStep.Location = New System.Drawing.Point(293, 207)
        Me.btnForNextLoopStep.Name = "btnForNextLoopStep"
        Me.btnForNextLoopStep.Size = New System.Drawing.Size(151, 23)
        Me.btnForNextLoopStep.TabIndex = 13
        Me.btnForNextLoopStep.Text = "For next loop step"
        Me.btnForNextLoopStep.UseVisualStyleBackColor = True
        '
        'btnForNextLoop
        '
        Me.btnForNextLoop.Location = New System.Drawing.Point(293, 178)
        Me.btnForNextLoop.Name = "btnForNextLoop"
        Me.btnForNextLoop.Size = New System.Drawing.Size(151, 23)
        Me.btnForNextLoop.TabIndex = 12
        Me.btnForNextLoop.Text = "For Next Loop"
        Me.btnForNextLoop.UseVisualStyleBackColor = True
        '
        'lstData
        '
        Me.lstData.FormattingEnabled = True
        Me.lstData.IntegralHeight = False
        Me.lstData.ItemHeight = 15
        Me.lstData.Location = New System.Drawing.Point(74, 178)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(183, 256)
        Me.lstData.TabIndex = 11
        '
        'btnQuittingADoLoop
        '
        Me.btnQuittingADoLoop.Location = New System.Drawing.Point(293, 411)
        Me.btnQuittingADoLoop.Name = "btnQuittingADoLoop"
        Me.btnQuittingADoLoop.Size = New System.Drawing.Size(151, 23)
        Me.btnQuittingADoLoop.TabIndex = 20
        Me.btnQuittingADoLoop.Text = "Quitting A Do Loop"
        Me.btnQuittingADoLoop.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(518, 495)
        Me.Controls.Add(Me.btnQuittingADoLoop)
        Me.Controls.Add(Me.btnQuittingAForLoop)
        Me.Controls.Add(Me.btnNestedLoop)
        Me.Controls.Add(Me.btnDoWhileLoop)
        Me.Controls.Add(Me.btnDoUntillLoop)
        Me.Controls.Add(Me.btnForBackwardLoop)
        Me.Controls.Add(Me.btnEachLoop)
        Me.Controls.Add(Me.btnForNextLoopStep)
        Me.Controls.Add(Me.btnForNextLoop)
        Me.Controls.Add(Me.lstData)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BAB 4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnQuittingAForLoop As Button
    Friend WithEvents btnNestedLoop As Button
    Friend WithEvents btnDoWhileLoop As Button
    Friend WithEvents btnDoUntillLoop As Button
    Friend WithEvents btnForBackwardLoop As Button
    Friend WithEvents btnEachLoop As Button
    Friend WithEvents btnForNextLoopStep As Button
    Friend WithEvents btnForNextLoop As Button
    Friend WithEvents lstData As ListBox
    Friend WithEvents btnQuittingADoLoop As Button
End Class
