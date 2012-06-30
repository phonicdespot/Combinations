<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Combinations
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Combinations))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Cols = New System.Windows.Forms.NumericUpDown()
        Me.Min = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Max = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.Cols, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Max, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(249, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 25)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Execute"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Cols
        '
        Me.Cols.Location = New System.Drawing.Point(167, 25)
        Me.Cols.Name = "Cols"
        Me.Cols.Size = New System.Drawing.Size(76, 20)
        Me.Cols.TabIndex = 1
        Me.Cols.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'Min
        '
        Me.Min.Location = New System.Drawing.Point(15, 25)
        Me.Min.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.Min.Name = "Min"
        Me.Min.Size = New System.Drawing.Size(59, 20)
        Me.Min.TabIndex = 3
        Me.Min.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(164, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Columns:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "to"
        '
        'Max
        '
        Me.Max.Location = New System.Drawing.Point(102, 25)
        Me.Max.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.Max.Name = "Max"
        Me.Max.Size = New System.Drawing.Size(59, 20)
        Me.Max.TabIndex = 6
        Me.Max.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Range:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(214, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "See Immediate Window (Ctrl + G) for output."
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(15, 97)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(59, 25)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Execute"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Combinations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 369)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Max)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Min)
        Me.Controls.Add(Me.Cols)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Combinations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Combinations"
        CType(Me.Cols, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Max, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Cols As System.Windows.Forms.NumericUpDown
    Friend WithEvents Min As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Max As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
