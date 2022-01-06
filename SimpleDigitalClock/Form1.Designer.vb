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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelSecond = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelMinute = New System.Windows.Forms.Label()
        Me.LabelHour = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelDay = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(17, 200)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(386, 144)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'LabelSecond
        '
        Me.LabelSecond.AutoSize = True
        Me.LabelSecond.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSecond.Location = New System.Drawing.Point(12, 145)
        Me.LabelSecond.Name = "LabelSecond"
        Me.LabelSecond.Size = New System.Drawing.Size(37, 30)
        Me.LabelSecond.TabIndex = 1
        Me.LabelSecond.Text = "00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 30)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Minute(s)"
        '
        'LabelMinute
        '
        Me.LabelMinute.AutoSize = True
        Me.LabelMinute.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMinute.Location = New System.Drawing.Point(12, 102)
        Me.LabelMinute.Name = "LabelMinute"
        Me.LabelMinute.Size = New System.Drawing.Size(37, 30)
        Me.LabelMinute.TabIndex = 3
        Me.LabelMinute.Text = "00"
        '
        'LabelHour
        '
        Me.LabelHour.AutoSize = True
        Me.LabelHour.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHour.Location = New System.Drawing.Point(12, 54)
        Me.LabelHour.Name = "LabelHour"
        Me.LabelHour.Size = New System.Drawing.Size(37, 30)
        Me.LabelHour.TabIndex = 5
        Me.LabelHour.Text = "00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 30)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Hour(s)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 30)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Second(s)"
        '
        'LabelDay
        '
        Me.LabelDay.AutoSize = True
        Me.LabelDay.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDay.Location = New System.Drawing.Point(12, 9)
        Me.LabelDay.Name = "LabelDay"
        Me.LabelDay.Size = New System.Drawing.Size(37, 30)
        Me.LabelDay.TabIndex = 8
        Me.LabelDay.Text = "00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(64, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 30)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Day(s)"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(238, 9)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(73, 166)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Start"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(330, 9)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(73, 166)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Stop"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 356)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Coded By: Lord Comfy"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(246, 356)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Visit Us On Youtube: Click Here"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 378)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LabelDay)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabelHour)
        Me.Controls.Add(Me.LabelMinute)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelSecond)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(451, 417)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(451, 417)
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Digital Stopwatch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LabelSecond As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelMinute As System.Windows.Forms.Label
    Friend WithEvents LabelHour As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LabelDay As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
