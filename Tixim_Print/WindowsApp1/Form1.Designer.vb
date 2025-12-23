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
        Me.SpinEdit1 = New DevExpress.XtraEditors.SpinEdit()
        Me.SpinEdit2 = New DevExpress.XtraEditors.SpinEdit()
        Me.SpinEdit3 = New DevExpress.XtraEditors.SpinEdit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(87, 131)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SpinEdit1
        '
        Me.SpinEdit1.EditValue = New Decimal(New Integer() {144, 0, 0, 0})
        Me.SpinEdit1.Location = New System.Drawing.Point(108, 40)
        Me.SpinEdit1.Name = "SpinEdit1"
        Me.SpinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit1.Size = New System.Drawing.Size(100, 20)
        Me.SpinEdit1.TabIndex = 1
        '
        'SpinEdit2
        '
        Me.SpinEdit2.EditValue = New Decimal(New Integer() {2, 0, 0, 0})
        Me.SpinEdit2.Location = New System.Drawing.Point(108, 66)
        Me.SpinEdit2.Name = "SpinEdit2"
        Me.SpinEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit2.Size = New System.Drawing.Size(100, 20)
        Me.SpinEdit2.TabIndex = 2
        '
        'SpinEdit3
        '
        Me.SpinEdit3.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SpinEdit3.Location = New System.Drawing.Point(108, 92)
        Me.SpinEdit3.Name = "SpinEdit3"
        Me.SpinEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit3.Size = New System.Drawing.Size(100, 20)
        Me.SpinEdit3.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.SpinEdit3)
        Me.Controls.Add(Me.SpinEdit2)
        Me.Controls.Add(Me.SpinEdit1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents SpinEdit1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SpinEdit2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SpinEdit3 As DevExpress.XtraEditors.SpinEdit
End Class
