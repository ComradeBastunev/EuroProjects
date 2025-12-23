<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormContract
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
        Me.RichEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.UndoItem1 = New DevExpress.XtraRichEdit.UI.UndoItem()
        Me.RedoItem1 = New DevExpress.XtraRichEdit.UI.RedoItem()
        Me.FileNewItem1 = New DevExpress.XtraRichEdit.UI.FileNewItem()
        Me.FileOpenItem1 = New DevExpress.XtraRichEdit.UI.FileOpenItem()
        Me.FileSaveItem1 = New DevExpress.XtraRichEdit.UI.FileSaveItem()
        Me.FileSaveAsItem1 = New DevExpress.XtraRichEdit.UI.FileSaveAsItem()
        Me.QuickPrintItem1 = New DevExpress.XtraRichEdit.UI.QuickPrintItem()
        Me.PrintItem1 = New DevExpress.XtraRichEdit.UI.PrintItem()
        Me.PrintPreviewItem1 = New DevExpress.XtraRichEdit.UI.PrintPreviewItem()
        Me.InsertMergeFieldItem1 = New DevExpress.XtraRichEdit.UI.InsertMergeFieldItem()
        Me.ShowAllFieldCodesItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem()
        Me.ShowAllFieldResultsItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem()
        Me.ToggleViewMergedDataItem1 = New DevExpress.XtraRichEdit.UI.ToggleViewMergedDataItem()
        Me.FileRibbonPage1 = New DevExpress.XtraRichEdit.UI.FileRibbonPage()
        Me.CommonRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup()
        Me.MailingsRibbonPage1 = New DevExpress.XtraRichEdit.UI.MailingsRibbonPage()
        Me.MailMergeRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.MailMergeRibbonPageGroup()
        Me.RichEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController()
        Me.RichEditControl2 = New DevExpress.XtraRichEdit.RichEditControl()
        Me.SpreadsheetControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
        Me.Rep_Offer_Print_ContractTableAdapter1 = New DataSet1TableAdapters.Rep_Offer_Print_ContractTableAdapter()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RichEditBarController1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'RichEditControl1
        '
        Me.RichEditControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichEditControl1.Location = New System.Drawing.Point(0, 141)
        Me.RichEditControl1.MenuManager = Me.RibbonControl1
        Me.RichEditControl1.Name = "RichEditControl1"
        Me.RichEditControl1.Size = New System.Drawing.Size(872, 424)
        Me.RichEditControl1.TabIndex = 0
        Me.RichEditControl1.Text = "RichEditControl1"
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.UndoItem1, Me.RedoItem1, Me.FileNewItem1, Me.FileOpenItem1, Me.FileSaveItem1, Me.FileSaveAsItem1, Me.QuickPrintItem1, Me.PrintItem1, Me.PrintPreviewItem1, Me.InsertMergeFieldItem1, Me.ShowAllFieldCodesItem1, Me.ShowAllFieldResultsItem1, Me.ToggleViewMergedDataItem1})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 14
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.FileRibbonPage1, Me.MailingsRibbonPage1})
        Me.RibbonControl1.Size = New System.Drawing.Size(872, 141)
        '
        'UndoItem1
        '
        Me.UndoItem1.Id = 1
        Me.UndoItem1.Name = "UndoItem1"
        '
        'RedoItem1
        '
        Me.RedoItem1.Id = 2
        Me.RedoItem1.Name = "RedoItem1"
        '
        'FileNewItem1
        '
        Me.FileNewItem1.Id = 3
        Me.FileNewItem1.Name = "FileNewItem1"
        '
        'FileOpenItem1
        '
        Me.FileOpenItem1.Id = 4
        Me.FileOpenItem1.Name = "FileOpenItem1"
        '
        'FileSaveItem1
        '
        Me.FileSaveItem1.Id = 5
        Me.FileSaveItem1.Name = "FileSaveItem1"
        '
        'FileSaveAsItem1
        '
        Me.FileSaveAsItem1.Id = 6
        Me.FileSaveAsItem1.Name = "FileSaveAsItem1"
        '
        'QuickPrintItem1
        '
        Me.QuickPrintItem1.Id = 7
        Me.QuickPrintItem1.Name = "QuickPrintItem1"
        '
        'PrintItem1
        '
        Me.PrintItem1.Id = 8
        Me.PrintItem1.Name = "PrintItem1"
        '
        'PrintPreviewItem1
        '
        Me.PrintPreviewItem1.Id = 9
        Me.PrintPreviewItem1.Name = "PrintPreviewItem1"
        '
        'InsertMergeFieldItem1
        '
        Me.InsertMergeFieldItem1.Id = 10
        Me.InsertMergeFieldItem1.Name = "InsertMergeFieldItem1"
        '
        'ShowAllFieldCodesItem1
        '
        Me.ShowAllFieldCodesItem1.Id = 11
        Me.ShowAllFieldCodesItem1.Name = "ShowAllFieldCodesItem1"
        '
        'ShowAllFieldResultsItem1
        '
        Me.ShowAllFieldResultsItem1.Id = 12
        Me.ShowAllFieldResultsItem1.Name = "ShowAllFieldResultsItem1"
        '
        'ToggleViewMergedDataItem1
        '
        Me.ToggleViewMergedDataItem1.Id = 13
        Me.ToggleViewMergedDataItem1.Name = "ToggleViewMergedDataItem1"
        '
        'FileRibbonPage1
        '
        Me.FileRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.CommonRibbonPageGroup1})
        Me.FileRibbonPage1.Name = "FileRibbonPage1"
        '
        'CommonRibbonPageGroup1
        '
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.UndoItem1)
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.RedoItem1)
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.FileNewItem1, "N")
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.FileOpenItem1, "O")
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.FileSaveItem1, "S")
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.FileSaveAsItem1, "A")
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.QuickPrintItem1)
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.PrintItem1, "P")
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.PrintPreviewItem1)
        Me.CommonRibbonPageGroup1.Name = "CommonRibbonPageGroup1"
        '
        'MailingsRibbonPage1
        '
        Me.MailingsRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.MailMergeRibbonPageGroup1})
        Me.MailingsRibbonPage1.Name = "MailingsRibbonPage1"
        Me.MailingsRibbonPage1.Visible = False
        '
        'MailMergeRibbonPageGroup1
        '
        Me.MailMergeRibbonPageGroup1.ItemLinks.Add(Me.InsertMergeFieldItem1)
        Me.MailMergeRibbonPageGroup1.ItemLinks.Add(Me.ShowAllFieldCodesItem1)
        Me.MailMergeRibbonPageGroup1.ItemLinks.Add(Me.ShowAllFieldResultsItem1)
        Me.MailMergeRibbonPageGroup1.ItemLinks.Add(Me.ToggleViewMergedDataItem1, "P")
        Me.MailMergeRibbonPageGroup1.Name = "MailMergeRibbonPageGroup1"
        '
        'RichEditBarController1
        '
        Me.RichEditBarController1.BarItems.Add(Me.UndoItem1)
        Me.RichEditBarController1.BarItems.Add(Me.RedoItem1)
        Me.RichEditBarController1.BarItems.Add(Me.FileNewItem1)
        Me.RichEditBarController1.BarItems.Add(Me.FileOpenItem1)
        Me.RichEditBarController1.BarItems.Add(Me.FileSaveItem1)
        Me.RichEditBarController1.BarItems.Add(Me.FileSaveAsItem1)
        Me.RichEditBarController1.BarItems.Add(Me.QuickPrintItem1)
        Me.RichEditBarController1.BarItems.Add(Me.PrintItem1)
        Me.RichEditBarController1.BarItems.Add(Me.PrintPreviewItem1)
        Me.RichEditBarController1.BarItems.Add(Me.InsertMergeFieldItem1)
        Me.RichEditBarController1.BarItems.Add(Me.ShowAllFieldCodesItem1)
        Me.RichEditBarController1.BarItems.Add(Me.ShowAllFieldResultsItem1)
        Me.RichEditBarController1.BarItems.Add(Me.ToggleViewMergedDataItem1)
        Me.RichEditBarController1.Control = Me.RichEditControl1
        '
        'RichEditControl2
        '
        Me.RichEditControl2.Location = New System.Drawing.Point(455, 274)
        Me.RichEditControl2.MenuManager = Me.RibbonControl1
        Me.RichEditControl2.Name = "RichEditControl2"
        Me.RichEditControl2.Size = New System.Drawing.Size(305, 224)
        Me.RichEditControl2.TabIndex = 2
        Me.RichEditControl2.Text = "RichEditControl2"
        Me.RichEditControl2.Visible = False
        '
        'SpreadsheetControl1
        '
        Me.SpreadsheetControl1.Location = New System.Drawing.Point(0, 0)
        Me.SpreadsheetControl1.MenuManager = Me.RibbonControl1
        Me.SpreadsheetControl1.Name = "SpreadsheetControl1"
        Me.SpreadsheetControl1.Size = New System.Drawing.Size(400, 200)
        Me.SpreadsheetControl1.TabIndex = 0
        Me.SpreadsheetControl1.Text = "SpreadsheetControl1"
        '
        'Rep_Offer_Print_ContractTableAdapter1
        '
        Me.Rep_Offer_Print_ContractTableAdapter1.ClearBeforeFill = True
        '
        'FormContract
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 565)
        Me.Controls.Add(Me.RichEditControl2)
        Me.Controls.Add(Me.RichEditControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "FormContract"
        Me.Text = "FormContract"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RichEditBarController1, System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(False)
        Me.PerformLayout

    End Sub
    Friend WithEvents RichEditControl1 As DevExpress.XtraRichEdit.RichEditControl
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents UndoItem1 As DevExpress.XtraRichEdit.UI.UndoItem
    Friend WithEvents RedoItem1 As DevExpress.XtraRichEdit.UI.RedoItem
    Friend WithEvents FileNewItem1 As DevExpress.XtraRichEdit.UI.FileNewItem
    Friend WithEvents FileOpenItem1 As DevExpress.XtraRichEdit.UI.FileOpenItem
    Friend WithEvents FileSaveItem1 As DevExpress.XtraRichEdit.UI.FileSaveItem
    Friend WithEvents FileSaveAsItem1 As DevExpress.XtraRichEdit.UI.FileSaveAsItem
    Friend WithEvents QuickPrintItem1 As DevExpress.XtraRichEdit.UI.QuickPrintItem
    Friend WithEvents PrintItem1 As DevExpress.XtraRichEdit.UI.PrintItem
    Friend WithEvents PrintPreviewItem1 As DevExpress.XtraRichEdit.UI.PrintPreviewItem
    Friend WithEvents FileRibbonPage1 As DevExpress.XtraRichEdit.UI.FileRibbonPage
    Friend WithEvents CommonRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup
    Friend WithEvents RichEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController
    Friend WithEvents RichEditControl2 As DevExpress.XtraRichEdit.RichEditControl
    Friend WithEvents InsertMergeFieldItem1 As DevExpress.XtraRichEdit.UI.InsertMergeFieldItem
    Friend WithEvents ShowAllFieldCodesItem1 As DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem
    Friend WithEvents ShowAllFieldResultsItem1 As DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem
    Friend WithEvents ToggleViewMergedDataItem1 As DevExpress.XtraRichEdit.UI.ToggleViewMergedDataItem
    Friend WithEvents MailingsRibbonPage1 As DevExpress.XtraRichEdit.UI.MailingsRibbonPage
    Friend WithEvents MailMergeRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.MailMergeRibbonPageGroup
    Friend WithEvents SpreadsheetControl1 As DevExpress.XtraSpreadsheet.SpreadsheetControl
    Friend WithEvents Rep_Offer_Print_ContractTableAdapter1 As DataSet1TableAdapters.Rep_Offer_Print_ContractTableAdapter
End Class
