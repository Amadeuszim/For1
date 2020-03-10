<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnpar = New System.Windows.Forms.Button()
        Me.btnvoltar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnpar
        '
        Me.btnpar.Location = New System.Drawing.Point(40, 48)
        Me.btnpar.Name = "btnpar"
        Me.btnpar.Size = New System.Drawing.Size(191, 23)
        Me.btnpar.TabIndex = 0
        Me.btnpar.Text = "Mostrar números pares até 10"
        Me.btnpar.UseVisualStyleBackColor = True
        '
        'btnvoltar
        '
        Me.btnvoltar.Location = New System.Drawing.Point(40, 101)
        Me.btnvoltar.Name = "btnvoltar"
        Me.btnvoltar.Size = New System.Drawing.Size(191, 23)
        Me.btnvoltar.TabIndex = 1
        Me.btnvoltar.Text = "Decrementando"
        Me.btnvoltar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 162)
        Me.Controls.Add(Me.btnvoltar)
        Me.Controls.Add(Me.btnpar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnpar As System.Windows.Forms.Button
    Friend WithEvents btnvoltar As System.Windows.Forms.Button

End Class
