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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SpinEditOrderNo = New DevExpress.XtraEditors.SpinEdit()
        Me.SpinEditService = New DevExpress.XtraEditors.SpinEdit()
        CType(Me.SpinEditOrderNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEditService.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(39, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Поръчка"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(39, 41)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Работна карта"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(39, 70)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(128, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Документ изписване"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(39, 99)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(128, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Фактура"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(39, 207)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(128, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Поръчка 2022"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'SpinEditOrderNo
        '
        Me.SpinEditOrderNo.EditValue = New Decimal(New Integer() {100081, 0, 0, 0})
        Me.SpinEditOrderNo.Location = New System.Drawing.Point(39, 129)
        Me.SpinEditOrderNo.Name = "SpinEditOrderNo"
        Me.SpinEditOrderNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEditOrderNo.Size = New System.Drawing.Size(100, 20)
        Me.SpinEditOrderNo.TabIndex = 5
        '
        'SpinEditService
        '
        Me.SpinEditService.EditValue = New Decimal(New Integer() {8, 0, 0, 0})
        Me.SpinEditService.Location = New System.Drawing.Point(39, 155)
        Me.SpinEditService.Name = "SpinEditService"
        Me.SpinEditService.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEditService.Size = New System.Drawing.Size(100, 20)
        Me.SpinEditService.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(245, 242)
        Me.Controls.Add(Me.SpinEditService)
        Me.Controls.Add(Me.SpinEditOrderNo)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.SpinEditOrderNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEditService.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents SpinEditOrderNo As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SpinEditService As DevExpress.XtraEditors.SpinEdit
End Class
