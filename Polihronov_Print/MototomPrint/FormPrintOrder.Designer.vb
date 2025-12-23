<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrintOrder
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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.SimpleButtonbodyCheck = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButtonOrder = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButtonPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.CheckEditBodyCheck = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEditOrder = New DevExpress.XtraEditors.CheckEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.CheckEditBodyCheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEditOrder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.SimpleButtonbodyCheck)
        Me.LayoutControl1.Controls.Add(Me.SimpleButtonOrder)
        Me.LayoutControl1.Controls.Add(Me.SimpleButtonPrint)
        Me.LayoutControl1.Controls.Add(Me.CheckEditBodyCheck)
        Me.LayoutControl1.Controls.Add(Me.CheckEditOrder)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(284, 261)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'SimpleButtonbodyCheck
        '
        Me.SimpleButtonbodyCheck.Location = New System.Drawing.Point(174, 38)
        Me.SimpleButtonbodyCheck.Name = "SimpleButtonbodyCheck"
        Me.SimpleButtonbodyCheck.Size = New System.Drawing.Size(98, 22)
        Me.SimpleButtonbodyCheck.StyleController = Me.LayoutControl1
        Me.SimpleButtonbodyCheck.TabIndex = 8
        Me.SimpleButtonbodyCheck.Text = "Печат"
        '
        'SimpleButtonOrder
        '
        Me.SimpleButtonOrder.Location = New System.Drawing.Point(174, 12)
        Me.SimpleButtonOrder.Name = "SimpleButtonOrder"
        Me.SimpleButtonOrder.Size = New System.Drawing.Size(98, 22)
        Me.SimpleButtonOrder.StyleController = Me.LayoutControl1
        Me.SimpleButtonOrder.TabIndex = 7
        Me.SimpleButtonOrder.Text = "Печат"
        '
        'SimpleButtonPrint
        '
        Me.SimpleButtonPrint.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SimpleButtonPrint.Appearance.Options.UseFont = True
        Me.SimpleButtonPrint.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopRight
        Me.SimpleButtonPrint.Location = New System.Drawing.Point(12, 227)
        Me.SimpleButtonPrint.Name = "SimpleButtonPrint"
        Me.SimpleButtonPrint.Size = New System.Drawing.Size(260, 22)
        Me.SimpleButtonPrint.StyleController = Me.LayoutControl1
        Me.SimpleButtonPrint.TabIndex = 6
        Me.SimpleButtonPrint.Text = "Печат избрани"
        '
        'CheckEditBodyCheck
        '
        Me.CheckEditBodyCheck.Location = New System.Drawing.Point(12, 38)
        Me.CheckEditBodyCheck.Name = "CheckEditBodyCheck"
        Me.CheckEditBodyCheck.Properties.Caption = "Протокол Body Check"
        Me.CheckEditBodyCheck.Size = New System.Drawing.Size(158, 19)
        Me.CheckEditBodyCheck.StyleController = Me.LayoutControl1
        Me.CheckEditBodyCheck.TabIndex = 5
        '
        'CheckEditOrder
        '
        Me.CheckEditOrder.EditValue = True
        Me.CheckEditOrder.Location = New System.Drawing.Point(12, 12)
        Me.CheckEditOrder.Name = "CheckEditOrder"
        Me.CheckEditOrder.Properties.Caption = "Поръчка"
        Me.CheckEditOrder.Size = New System.Drawing.Size(158, 19)
        Me.CheckEditOrder.StyleController = Me.LayoutControl1
        Me.CheckEditOrder.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(284, 261)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.CheckEditOrder
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(162, 26)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 52)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(264, 163)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.CheckEditBodyCheck
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(162, 26)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.SimpleButtonPrint
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 215)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(264, 26)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.SimpleButtonOrder
        Me.LayoutControlItem4.Location = New System.Drawing.Point(162, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(102, 26)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.SimpleButtonbodyCheck
        Me.LayoutControlItem5.Location = New System.Drawing.Point(162, 26)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(102, 26)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'FormPrintOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "FormPrintOrder"
        Me.Text = "Печат поръчка"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.CheckEditBodyCheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEditOrder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents SimpleButtonPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CheckEditBodyCheck As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEditOrder As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButtonbodyCheck As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButtonOrder As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
End Class
