<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game
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
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.picMonster = New System.Windows.Forms.PictureBox()
        Me.tmrGameLoop = New System.Windows.Forms.Timer(Me.components)
        Me.prgHealth = New System.Windows.Forms.ProgressBar()
        Me.picHealth = New System.Windows.Forms.PictureBox()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMonster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHealth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPlayer
        '
        Me.picPlayer.BackColor = System.Drawing.Color.Green
        Me.picPlayer.Enabled = False
        Me.picPlayer.Location = New System.Drawing.Point(117, 99)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(75, 75)
        Me.picPlayer.TabIndex = 0
        Me.picPlayer.TabStop = False
        '
        'picMonster
        '
        Me.picMonster.BackColor = System.Drawing.Color.Red
        Me.picMonster.Enabled = False
        Me.picMonster.Location = New System.Drawing.Point(258, 298)
        Me.picMonster.Name = "picMonster"
        Me.picMonster.Size = New System.Drawing.Size(100, 100)
        Me.picMonster.TabIndex = 1
        Me.picMonster.TabStop = False
        '
        'tmrGameLoop
        '
        Me.tmrGameLoop.Enabled = True
        Me.tmrGameLoop.Interval = 10
        '
        'prgHealth
        '
        Me.prgHealth.Location = New System.Drawing.Point(12, 520)
        Me.prgHealth.Name = "prgHealth"
        Me.prgHealth.Size = New System.Drawing.Size(987, 23)
        Me.prgHealth.TabIndex = 2
        Me.prgHealth.Value = 100
        '
        'picHealth
        '
        Me.picHealth.BackColor = System.Drawing.Color.Blue
        Me.picHealth.Location = New System.Drawing.Point(443, 231)
        Me.picHealth.Name = "picHealth"
        Me.picHealth.Size = New System.Drawing.Size(50, 50)
        Me.picHealth.TabIndex = 3
        Me.picHealth.TabStop = False
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1011, 555)
        Me.Controls.Add(Me.picHealth)
        Me.Controls.Add(Me.prgHealth)
        Me.Controls.Add(Me.picMonster)
        Me.Controls.Add(Me.picPlayer)
        Me.Name = "Game"
        Me.Text = "Monster Munch"
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMonster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHealth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picPlayer As PictureBox
    Friend WithEvents picMonster As PictureBox
    Friend WithEvents tmrGameLoop As Timer
    Friend WithEvents prgHealth As ProgressBar
    Friend WithEvents picHealth As PictureBox
End Class
