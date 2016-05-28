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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "MM/DD/YYYY"
        Me.DateTimePicker1.Location = New System.Drawing.Point(12, 37)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(206, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.BackColor = System.Drawing.SystemColors.Control
        Me.CheckedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(12, 106)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(206, 510)
        Me.CheckedListBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "To Do"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 638)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(206, 51)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Add Item"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "You have 0 things to do."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 106)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(206, 288)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(230, 690)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Location = New System.Drawing.Point(1120, 0)
        Me.MaximumSize = New System.Drawing.Size(246, 728)
        Me.MinimumSize = New System.Drawing.Size(246, 726)
        Me.Name = "Form1"
        Me.Text = "To Do"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
