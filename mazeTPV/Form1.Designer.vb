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
        Me.pbMaze = New System.Windows.Forms.PictureBox()
        Me.Guna2DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2ImageButton1 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btIniciar = New Guna.UI2.WinForms.Guna2GradientButton()
        CType(Me.pbMaze, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbMaze
        '
        Me.pbMaze.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbMaze.Image = Global.mazeTPV.My.Resources.Resources.LogoCompleto
        Me.pbMaze.Location = New System.Drawing.Point(350, 137)
        Me.pbMaze.Name = "pbMaze"
        Me.pbMaze.Size = New System.Drawing.Size(475, 168)
        Me.pbMaze.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbMaze.TabIndex = 0
        Me.pbMaze.TabStop = False
        '
        'Guna2DateTimePicker1
        '
        Me.Guna2DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2DateTimePicker1.Checked = True
        Me.Guna2DateTimePicker1.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2DateTimePicker1.Font = New System.Drawing.Font("Cascadia Code", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Guna2DateTimePicker1.Location = New System.Drawing.Point(410, 322)
        Me.Guna2DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.MaximumSize = New System.Drawing.Size(369, 45)
        Me.Guna2DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.Name = "Guna2DateTimePicker1"
        Me.Guna2DateTimePicker1.Size = New System.Drawing.Size(369, 45)
        Me.Guna2DateTimePicker1.TabIndex = 2
        Me.Guna2DateTimePicker1.Value = New Date(2022, 10, 23, 12, 55, 50, 431)
        '
        'Guna2ImageButton1
        '
        Me.Guna2ImageButton1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ImageButton1.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton1.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton1.Image = Global.mazeTPV.My.Resources.Resources.exit_1
        Me.Guna2ImageButton1.ImageOffset = New System.Drawing.Point(0, 0)
        Me.Guna2ImageButton1.ImageRotate = 0!
        Me.Guna2ImageButton1.Location = New System.Drawing.Point(548, 496)
        Me.Guna2ImageButton1.Name = "Guna2ImageButton1"
        Me.Guna2ImageButton1.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton1.Size = New System.Drawing.Size(80, 68)
        Me.Guna2ImageButton1.TabIndex = 3
        '
        'btIniciar
        '
        Me.btIniciar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btIniciar.BorderRadius = 20
        Me.btIniciar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btIniciar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btIniciar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btIniciar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btIniciar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btIniciar.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btIniciar.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btIniciar.FocusedColor = System.Drawing.Color.DarkSlateGray
        Me.btIniciar.Font = New System.Drawing.Font("Cascadia Code", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btIniciar.ForeColor = System.Drawing.Color.Black
        Me.btIniciar.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btIniciar.Location = New System.Drawing.Point(476, 402)
        Me.btIniciar.MaximumSize = New System.Drawing.Size(225, 56)
        Me.btIniciar.Name = "btIniciar"
        Me.btIniciar.Size = New System.Drawing.Size(225, 56)
        Me.btIniciar.TabIndex = 1
        Me.btIniciar.Text = "INICIAR"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(1130, 597)
        Me.Controls.Add(Me.Guna2ImageButton1)
        Me.Controls.Add(Me.Guna2DateTimePicker1)
        Me.Controls.Add(Me.btIniciar)
        Me.Controls.Add(Me.pbMaze)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pbMaze, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbMaze As PictureBox
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2ImageButton1 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btIniciar As Guna.UI2.WinForms.Guna2GradientButton
End Class
