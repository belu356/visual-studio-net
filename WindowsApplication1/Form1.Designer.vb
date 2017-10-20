<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_suma = New System.Windows.Forms.TextBox()
        Me.btn_suma = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_suma
        '
        Me.txt_suma.Location = New System.Drawing.Point(133, 62)
        Me.txt_suma.Name = "txt_suma"
        Me.txt_suma.Size = New System.Drawing.Size(118, 20)
        Me.txt_suma.TabIndex = 0
        '
        'btn_suma
        '
        Me.btn_suma.Location = New System.Drawing.Point(12, 62)
        Me.btn_suma.Name = "btn_suma"
        Me.btn_suma.Size = New System.Drawing.Size(115, 21)
        Me.btn_suma.TabIndex = 2
        Me.btn_suma.Text = "Suma"
        Me.btn_suma.UseVisualStyleBackColor = True
        '
        'Frm_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 270)
        Me.Controls.Add(Me.btn_suma)
        Me.Controls.Add(Me.txt_suma)
        Me.Name = "Frm_principal"
        Me.Text = "Formulario principal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_suma As TextBox
    Friend WithEvents btn_suma As Button
End Class
