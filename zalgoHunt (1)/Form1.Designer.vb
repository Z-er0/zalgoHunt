<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTitleScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTitleScreen))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblEnter = New System.Windows.Forms.Label()
        Me.tmrWordFlash = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblTitle.Location = New System.Drawing.Point(13, -75)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(529, 266)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = resources.GetString("lblTitle.Text")
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEnter
        '
        Me.lblEnter.BackColor = System.Drawing.Color.Transparent
        Me.lblEnter.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblEnter.Location = New System.Drawing.Point(211, 252)
        Me.lblEnter.Name = "lblEnter"
        Me.lblEnter.Size = New System.Drawing.Size(140, 15)
        Me.lblEnter.TabIndex = 1
        Me.lblEnter.Text = resources.GetString("lblEnter.Text")
        Me.lblEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrWordFlash
        '
        Me.tmrWordFlash.Enabled = True
        '
        'frmTitleScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.duckShoot.My.Resources.Resources.Call_of_Cthulhu_The_Wasted_Land_Background_The_Face_of_the_End
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(558, 370)
        Me.Controls.Add(Me.lblEnter)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmTitleScreen"
        Me.Text = resources.GetString("$this.Text")
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblEnter As Label
    Friend WithEvents tmrWordFlash As Timer
End Class
