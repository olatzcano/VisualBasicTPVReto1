<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Guna2vSeparator1 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.PanelMenuLateral = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btGestion = New Guna.UI2.WinForms.Guna2Button()
        Me.PanelMenuLateral.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2vSeparator1
        '
        Me.Guna2vSeparator1.Location = New System.Drawing.Point(299, 43)
        Me.Guna2vSeparator1.Name = "Guna2vSeparator1"
        Me.Guna2vSeparator1.Size = New System.Drawing.Size(33, 571)
        Me.Guna2vSeparator1.TabIndex = 0
        '
        'PanelMenuLateral
        '
        Me.PanelMenuLateral.Controls.Add(Me.Panel1)
        Me.PanelMenuLateral.Controls.Add(Me.btGestion)
        Me.PanelMenuLateral.FillColor = System.Drawing.Color.LightGray
        Me.PanelMenuLateral.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelMenuLateral.FillColor3 = System.Drawing.Color.SkyBlue
        Me.PanelMenuLateral.Location = New System.Drawing.Point(30, 43)
        Me.PanelMenuLateral.Name = "PanelMenuLateral"
        Me.PanelMenuLateral.Size = New System.Drawing.Size(263, 571)
        Me.PanelMenuLateral.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Location = New System.Drawing.Point(12, 99)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(236, 125)
        Me.Panel1.TabIndex = 3
        '
        'btGestion
        '
        Me.btGestion.BackColor = System.Drawing.Color.Transparent
        Me.btGestion.BorderThickness = 2
        Me.btGestion.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btGestion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btGestion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btGestion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btGestion.FillColor = System.Drawing.Color.Transparent
        Me.btGestion.FocusedColor = System.Drawing.Color.Transparent
        Me.btGestion.Font = New System.Drawing.Font("Cascadia Code", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btGestion.ForeColor = System.Drawing.Color.Black
        Me.btGestion.HoverState.FillColor = System.Drawing.Color.MintCream
        Me.btGestion.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btGestion.Image = Global.mazeTPV.My.Resources.Resources.user_1
        Me.btGestion.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btGestion.ImageSize = New System.Drawing.Size(30, 30)
        Me.btGestion.Location = New System.Drawing.Point(12, 52)
        Me.btGestion.Name = "btGestion"
        Me.btGestion.Size = New System.Drawing.Size(236, 41)
        Me.btGestion.TabIndex = 2
        Me.btGestion.Text = "Gestion"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(1150, 671)
        Me.Controls.Add(Me.Guna2vSeparator1)
        Me.Controls.Add(Me.PanelMenuLateral)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.PanelMenuLateral.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2vSeparator1 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents PanelMenuLateral As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btGestion As Guna.UI2.WinForms.Guna2Button
End Class
