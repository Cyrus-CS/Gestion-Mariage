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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.reference = New System.Windows.Forms.TextBox()
        Me.temMariee = New System.Windows.Forms.TextBox()
        Me.temMarier = New System.Windows.Forms.TextBox()
        Me.epoux = New System.Windows.Forms.TextBox()
        Me.commune = New System.Windows.Forms.TextBox()
        Me.epouse = New System.Windows.Forms.TextBox()
        Me.dateMariage = New System.Windows.Forms.DateTimePicker()
        Me.officier = New System.Windows.Forms.TextBox()
        Me.save = New System.Windows.Forms.Button()
        Me.quitter = New System.Windows.Forms.Button()
        Me.supprimer = New System.Windows.Forms.Button()
        Me.modifier = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(343, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(330, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gestion des Mariages"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(46, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Reference"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(600, 270)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Officier"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(600, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Temoin marier"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(600, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Temoin mariée"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(600, 326)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 21)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Date mariage"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(46, 322)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 21)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Commune"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(46, 257)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 21)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Epouse"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(46, 192)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 21)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Epoux"
        '
        'reference
        '
        Me.reference.Location = New System.Drawing.Point(171, 126)
        Me.reference.Name = "reference"
        Me.reference.Size = New System.Drawing.Size(272, 23)
        Me.reference.TabIndex = 10
        '
        'temMariee
        '
        Me.temMariee.Location = New System.Drawing.Point(749, 190)
        Me.temMariee.Name = "temMariee"
        Me.temMariee.Size = New System.Drawing.Size(246, 23)
        Me.temMariee.TabIndex = 11
        '
        'temMarier
        '
        Me.temMarier.Location = New System.Drawing.Point(749, 126)
        Me.temMarier.Name = "temMarier"
        Me.temMarier.Size = New System.Drawing.Size(246, 23)
        Me.temMarier.TabIndex = 12
        '
        'epoux
        '
        Me.epoux.Location = New System.Drawing.Point(171, 193)
        Me.epoux.Name = "epoux"
        Me.epoux.Size = New System.Drawing.Size(272, 23)
        Me.epoux.TabIndex = 13
        '
        'commune
        '
        Me.commune.Location = New System.Drawing.Point(171, 322)
        Me.commune.Name = "commune"
        Me.commune.Size = New System.Drawing.Size(272, 23)
        Me.commune.TabIndex = 14
        '
        'epouse
        '
        Me.epouse.Location = New System.Drawing.Point(171, 258)
        Me.epouse.Name = "epouse"
        Me.epouse.Size = New System.Drawing.Size(272, 23)
        Me.epouse.TabIndex = 16
        '
        'dateMariage
        '
        Me.dateMariage.Location = New System.Drawing.Point(760, 324)
        Me.dateMariage.Name = "dateMariage"
        Me.dateMariage.Size = New System.Drawing.Size(200, 23)
        Me.dateMariage.TabIndex = 17
        '
        'officier
        '
        Me.officier.Location = New System.Drawing.Point(714, 271)
        Me.officier.Name = "officier"
        Me.officier.Size = New System.Drawing.Size(246, 23)
        Me.officier.TabIndex = 18
        '
        'save
        '
        Me.save.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.save.Location = New System.Drawing.Point(46, 405)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(151, 44)
        Me.save.TabIndex = 19
        Me.save.Text = "Enregistrer"
        Me.save.UseVisualStyleBackColor = False
        '
        'quitter
        '
        Me.quitter.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.quitter.Location = New System.Drawing.Point(830, 405)
        Me.quitter.Name = "quitter"
        Me.quitter.Size = New System.Drawing.Size(151, 44)
        Me.quitter.TabIndex = 20
        Me.quitter.Text = "Quiiter"
        Me.quitter.UseVisualStyleBackColor = False
        '
        'supprimer
        '
        Me.supprimer.BackColor = System.Drawing.Color.Red
        Me.supprimer.Location = New System.Drawing.Point(600, 405)
        Me.supprimer.Name = "supprimer"
        Me.supprimer.Size = New System.Drawing.Size(151, 44)
        Me.supprimer.TabIndex = 21
        Me.supprimer.Text = "Suprimer"
        Me.supprimer.UseVisualStyleBackColor = False
        '
        'modifier
        '
        Me.modifier.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.modifier.Location = New System.Drawing.Point(315, 405)
        Me.modifier.Name = "modifier"
        Me.modifier.Size = New System.Drawing.Size(151, 44)
        Me.modifier.TabIndex = 22
        Me.modifier.Text = "Modifier"
        Me.modifier.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1019, 503)
        Me.Controls.Add(Me.modifier)
        Me.Controls.Add(Me.supprimer)
        Me.Controls.Add(Me.quitter)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.officier)
        Me.Controls.Add(Me.dateMariage)
        Me.Controls.Add(Me.epouse)
        Me.Controls.Add(Me.commune)
        Me.Controls.Add(Me.epoux)
        Me.Controls.Add(Me.temMarier)
        Me.Controls.Add(Me.temMariee)
        Me.Controls.Add(Me.reference)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents reference As TextBox
    Friend WithEvents temMariee As TextBox
    Friend WithEvents temMarier As TextBox
    Friend WithEvents epoux As TextBox
    Friend WithEvents commune As TextBox
    Friend WithEvents epouse As TextBox
    Friend WithEvents dateMariage As DateTimePicker
    Friend WithEvents officier As TextBox
    Friend WithEvents save As Button
    Friend WithEvents quitter As Button
    Friend WithEvents supprimer As Button
    Friend WithEvents modifier As Button
End Class
