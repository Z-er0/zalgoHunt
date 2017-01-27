<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmZalgoHunt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmZalgoHunt))
        Me.grpScore = New System.Windows.Forms.GroupBox()
        Me.lblReload = New System.Windows.Forms.Label()
        Me.lblSubReload = New System.Windows.Forms.Label()
        Me.lblMunitions = New System.Windows.Forms.Label()
        Me.lblSubMunitions = New System.Windows.Forms.Label()
        Me.lblSouls = New System.Windows.Forms.Label()
        Me.lblSubSouls = New System.Windows.Forms.Label()
        Me.lblAttempts = New System.Windows.Forms.Label()
        Me.lblSubAttempts = New System.Windows.Forms.Label()
        Me.lblSlain = New System.Windows.Forms.Label()
        Me.lblSubScore = New System.Windows.Forms.Label()
        Me.tmrCthulhuMovement = New System.Windows.Forms.Timer(Me.components)
        Me.picLesser6 = New System.Windows.Forms.PictureBox()
        Me.picLesser5 = New System.Windows.Forms.PictureBox()
        Me.picLesser4 = New System.Windows.Forms.PictureBox()
        Me.picLesser3 = New System.Windows.Forms.PictureBox()
        Me.picLesser2 = New System.Windows.Forms.PictureBox()
        Me.picLesser1 = New System.Windows.Forms.PictureBox()
        Me.tmrReload = New System.Windows.Forms.Timer(Me.components)
        Me.lblSubTime = New System.Windows.Forms.Label()
        Me.lblTimeLeft = New System.Windows.Forms.Label()
        Me.lblColon = New System.Windows.Forms.Label()
        Me.tmrCountdown = New System.Windows.Forms.Timer(Me.components)
        Me.grpScore.SuspendLayout()
        CType(Me.picLesser6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLesser5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLesser4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLesser3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLesser2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLesser1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpScore
        '
        Me.grpScore.BackColor = System.Drawing.SystemColors.ControlText
        Me.grpScore.Controls.Add(Me.lblColon)
        Me.grpScore.Controls.Add(Me.lblTimeLeft)
        Me.grpScore.Controls.Add(Me.lblSubTime)
        Me.grpScore.Controls.Add(Me.lblReload)
        Me.grpScore.Controls.Add(Me.lblSubReload)
        Me.grpScore.Controls.Add(Me.lblMunitions)
        Me.grpScore.Controls.Add(Me.lblSubMunitions)
        Me.grpScore.Controls.Add(Me.lblSouls)
        Me.grpScore.Controls.Add(Me.lblSubSouls)
        Me.grpScore.Controls.Add(Me.lblAttempts)
        Me.grpScore.Controls.Add(Me.lblSubAttempts)
        Me.grpScore.Controls.Add(Me.lblSlain)
        Me.grpScore.Controls.Add(Me.lblSubScore)
        Me.grpScore.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grpScore.Location = New System.Drawing.Point(0, 389)
        Me.grpScore.Name = "grpScore"
        Me.grpScore.Size = New System.Drawing.Size(832, 73)
        Me.grpScore.TabIndex = 0
        Me.grpScore.TabStop = False
        Me.grpScore.Text = resources.GetString("grpScore.Text")
        '
        'lblReload
        '
        Me.lblReload.AutoSize = True
        Me.lblReload.Location = New System.Drawing.Point(779, 30)
        Me.lblReload.Name = "lblReload"
        Me.lblReload.Size = New System.Drawing.Size(13, 13)
        Me.lblReload.TabIndex = 9
        Me.lblReload.Text = "5"
        '
        'lblSubReload
        '
        Me.lblSubReload.AutoSize = True
        Me.lblSubReload.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubReload.Location = New System.Drawing.Point(769, 0)
        Me.lblSubReload.Name = "lblSubReload"
        Me.lblSubReload.Size = New System.Drawing.Size(40, 15)
        Me.lblSubReload.TabIndex = 8
        Me.lblSubReload.Text = "R͉͙̬͖̼̰̖̳̝͓̆ͥ͐͒e̳͙̝͚̦͋͊̔͋ͩ̇̑ͪ͒̐͛͗ͪ̐̀̚̚l̫̝͇͔̖̰̳ͤͥ̂̔̔ͩ̍̈́ͦ̔̐ŏ̩͇̩̥̫͈̝̹͇ͫ͒̌ͨ̏ͅa̍́̉̃͋̓" &
    "̫̲̖̽ͩd̩͔͖̟̣͙̤̱͕͔̱ͯ͗͊̃̑ͥͥ̈̀͂̾̈́̀ͩͣ͛̃̒"
        '
        'lblMunitions
        '
        Me.lblMunitions.AutoSize = True
        Me.lblMunitions.Location = New System.Drawing.Point(661, 30)
        Me.lblMunitions.Name = "lblMunitions"
        Me.lblMunitions.Size = New System.Drawing.Size(13, 13)
        Me.lblMunitions.TabIndex = 7
        Me.lblMunitions.Text = "5"
        '
        'lblSubMunitions
        '
        Me.lblSubMunitions.AutoSize = True
        Me.lblSubMunitions.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubMunitions.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSubMunitions.Location = New System.Drawing.Point(603, 0)
        Me.lblSubMunitions.Name = "lblSubMunitions"
        Me.lblSubMunitions.Size = New System.Drawing.Size(122, 15)
        Me.lblSubMunitions.TabIndex = 6
        Me.lblSubMunitions.Text = resources.GetString("lblSubMunitions.Text")
        '
        'lblSouls
        '
        Me.lblSouls.AutoSize = True
        Me.lblSouls.Location = New System.Drawing.Point(496, 30)
        Me.lblSouls.Name = "lblSouls"
        Me.lblSouls.Size = New System.Drawing.Size(19, 13)
        Me.lblSouls.TabIndex = 5
        Me.lblSouls.Text = "10"
        '
        'lblSubSouls
        '
        Me.lblSubSouls.AutoSize = True
        Me.lblSubSouls.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubSouls.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSubSouls.Location = New System.Drawing.Point(456, 0)
        Me.lblSubSouls.Name = "lblSubSouls"
        Me.lblSubSouls.Size = New System.Drawing.Size(96, 15)
        Me.lblSubSouls.TabIndex = 4
        Me.lblSubSouls.Text = resources.GetString("lblSubSouls.Text")
        '
        'lblAttempts
        '
        Me.lblAttempts.AutoSize = True
        Me.lblAttempts.Location = New System.Drawing.Point(327, 30)
        Me.lblAttempts.Name = "lblAttempts"
        Me.lblAttempts.Size = New System.Drawing.Size(13, 13)
        Me.lblAttempts.TabIndex = 3
        Me.lblAttempts.Text = "0"
        '
        'lblSubAttempts
        '
        Me.lblSubAttempts.AutoSize = True
        Me.lblSubAttempts.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubAttempts.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSubAttempts.Location = New System.Drawing.Point(287, 0)
        Me.lblSubAttempts.Name = "lblSubAttempts"
        Me.lblSubAttempts.Size = New System.Drawing.Size(91, 15)
        Me.lblSubAttempts.TabIndex = 2
        Me.lblSubAttempts.Text = resources.GetString("lblSubAttempts.Text")
        '
        'lblSlain
        '
        Me.lblSlain.AutoSize = True
        Me.lblSlain.Location = New System.Drawing.Point(143, 30)
        Me.lblSlain.Name = "lblSlain"
        Me.lblSlain.Size = New System.Drawing.Size(13, 13)
        Me.lblSlain.TabIndex = 1
        Me.lblSlain.Text = "0"
        '
        'lblSubScore
        '
        Me.lblSubScore.AutoSize = True
        Me.lblSubScore.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubScore.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSubScore.Location = New System.Drawing.Point(92, 0)
        Me.lblSubScore.Name = "lblSubScore"
        Me.lblSubScore.Size = New System.Drawing.Size(117, 15)
        Me.lblSubScore.TabIndex = 0
        Me.lblSubScore.Text = resources.GetString("lblSubScore.Text")
        '
        'tmrCthulhuMovement
        '
        Me.tmrCthulhuMovement.Enabled = True
        Me.tmrCthulhuMovement.Interval = 10
        '
        'picLesser6
        '
        Me.picLesser6.BackColor = System.Drawing.Color.Transparent
        Me.picLesser6.Image = Global.duckShoot.My.Resources.Resources.flap_copy2
        Me.picLesser6.Location = New System.Drawing.Point(774, 293)
        Me.picLesser6.Name = "picLesser6"
        Me.picLesser6.Size = New System.Drawing.Size(50, 50)
        Me.picLesser6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLesser6.TabIndex = 7
        Me.picLesser6.TabStop = False
        '
        'picLesser5
        '
        Me.picLesser5.BackColor = System.Drawing.Color.Transparent
        Me.picLesser5.Image = Global.duckShoot.My.Resources.Resources.flap_copy2
        Me.picLesser5.Location = New System.Drawing.Point(774, 185)
        Me.picLesser5.Name = "picLesser5"
        Me.picLesser5.Size = New System.Drawing.Size(50, 50)
        Me.picLesser5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLesser5.TabIndex = 6
        Me.picLesser5.TabStop = False
        '
        'picLesser4
        '
        Me.picLesser4.BackColor = System.Drawing.Color.Transparent
        Me.picLesser4.Image = Global.duckShoot.My.Resources.Resources.flap_copy2
        Me.picLesser4.Location = New System.Drawing.Point(774, 58)
        Me.picLesser4.Name = "picLesser4"
        Me.picLesser4.Size = New System.Drawing.Size(50, 50)
        Me.picLesser4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLesser4.TabIndex = 5
        Me.picLesser4.TabStop = False
        '
        'picLesser3
        '
        Me.picLesser3.BackColor = System.Drawing.Color.Transparent
        Me.picLesser3.Image = CType(resources.GetObject("picLesser3.Image"), System.Drawing.Image)
        Me.picLesser3.Location = New System.Drawing.Point(12, 234)
        Me.picLesser3.Name = "picLesser3"
        Me.picLesser3.Size = New System.Drawing.Size(50, 50)
        Me.picLesser3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLesser3.TabIndex = 4
        Me.picLesser3.TabStop = False
        '
        'picLesser2
        '
        Me.picLesser2.BackColor = System.Drawing.Color.Transparent
        Me.picLesser2.Image = CType(resources.GetObject("picLesser2.Image"), System.Drawing.Image)
        Me.picLesser2.Location = New System.Drawing.Point(12, 124)
        Me.picLesser2.Name = "picLesser2"
        Me.picLesser2.Size = New System.Drawing.Size(50, 50)
        Me.picLesser2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLesser2.TabIndex = 3
        Me.picLesser2.TabStop = False
        '
        'picLesser1
        '
        Me.picLesser1.BackColor = System.Drawing.Color.Transparent
        Me.picLesser1.Image = Global.duckShoot.My.Resources.Resources.flap_copy
        Me.picLesser1.Location = New System.Drawing.Point(12, 12)
        Me.picLesser1.Name = "picLesser1"
        Me.picLesser1.Size = New System.Drawing.Size(50, 50)
        Me.picLesser1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLesser1.TabIndex = 2
        Me.picLesser1.TabStop = False
        '
        'tmrReload
        '
        '
        'lblSubTime
        '
        Me.lblSubTime.AutoSize = True
        Me.lblSubTime.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTime.Location = New System.Drawing.Point(6, 49)
        Me.lblSubTime.Name = "lblSubTime"
        Me.lblSubTime.Size = New System.Drawing.Size(55, 15)
        Me.lblSubTime.TabIndex = 10
        Me.lblSubTime.Text = "T͖̬͞i̶͔̤͚m̳͔̝̫͇e ͎̜͉̤̤̼͘L͍͚̭e҉f͍̣͉̲̺͚t̺̦̗̤̪"
        '
        'lblTimeLeft
        '
        Me.lblTimeLeft.AutoSize = True
        Me.lblTimeLeft.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeLeft.Location = New System.Drawing.Point(81, 49)
        Me.lblTimeLeft.Name = "lblTimeLeft"
        Me.lblTimeLeft.Size = New System.Drawing.Size(19, 15)
        Me.lblTimeLeft.TabIndex = 11
        Me.lblTimeLeft.Text = "60"
        '
        'lblColon
        '
        Me.lblColon.AutoSize = True
        Me.lblColon.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColon.Location = New System.Drawing.Point(67, 49)
        Me.lblColon.Name = "lblColon"
        Me.lblColon.Size = New System.Drawing.Size(10, 15)
        Me.lblColon.TabIndex = 12
        Me.lblColon.Text = ":"
        '
        'tmrCountdown
        '
        Me.tmrCountdown.Enabled = True
        Me.tmrCountdown.Interval = 1000
        '
        'frmZalgoHunt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(831, 462)
        Me.Controls.Add(Me.picLesser6)
        Me.Controls.Add(Me.picLesser5)
        Me.Controls.Add(Me.picLesser4)
        Me.Controls.Add(Me.picLesser3)
        Me.Controls.Add(Me.picLesser2)
        Me.Controls.Add(Me.picLesser1)
        Me.Controls.Add(Me.grpScore)
        Me.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz
        Me.Name = "frmZalgoHunt"
        Me.Text = resources.GetString("$this.Text")
        Me.grpScore.ResumeLayout(False)
        Me.grpScore.PerformLayout()
        CType(Me.picLesser6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLesser5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLesser4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLesser3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLesser2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLesser1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpScore As GroupBox
    Friend WithEvents lblSlain As Label
    Friend WithEvents lblSubScore As Label
    Friend WithEvents lblSouls As Label
    Friend WithEvents lblSubSouls As Label
    Friend WithEvents lblAttempts As Label
    Friend WithEvents lblSubAttempts As Label
    Friend WithEvents picLesser1 As PictureBox
    Friend WithEvents picLesser2 As PictureBox
    Friend WithEvents picLesser3 As PictureBox
    Friend WithEvents picLesser4 As PictureBox
    Friend WithEvents picLesser5 As PictureBox
    Friend WithEvents picLesser6 As PictureBox
    Friend WithEvents tmrCthulhuMovement As Timer
    Friend WithEvents lblSubMunitions As Label
    Friend WithEvents lblMunitions As Label
    Friend WithEvents lblReload As Label
    Friend WithEvents lblSubReload As Label
    Friend WithEvents tmrReload As Timer
    Friend WithEvents lblColon As Label
    Friend WithEvents lblTimeLeft As Label
    Friend WithEvents lblSubTime As Label
    Friend WithEvents tmrCountdown As Timer
End Class
