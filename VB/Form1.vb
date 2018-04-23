Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms

Namespace dxExample
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
		  '  
			InitializeComponent()
			gridView1.Columns("Status").GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			gridView1.Columns("Status").GroupFormat.FormatString = "n3"
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			InitGridControl()
		End Sub
		Private Sub InitGridControl()
			DataHelper.InitData(dataTable1)
		End Sub
		Private Sub gridView1_CustomDrawGroupRow(ByVal sender As Object, ByVal e As RowObjectCustomDrawEventArgs) Handles gridView1.CustomDrawGroupRow
		   DrawGroupRow(e)
		End Sub
		Private Sub DrawGroupRow(ByVal e As RowObjectCustomDrawEventArgs)
			Dim info = TryCast(e.Info, GridGroupRowInfo)
			If Not(info.Column.FieldName = "ID") Then
				Return
			End If
		   GroupRowPaintHelper.CustomDrawSubjectColumnGroupRow(e, gridView1, gridControl1.LookAndFeel, imageList1)
			e.Handled = True
		End Sub
		Private Sub gridView1_CustomColumnDisplayText(ByVal sender As Object, ByVal e As CustomColumnDisplayTextEventArgs) Handles gridView1.CustomColumnDisplayText
			If e.Column.FieldName = "Subject" Then
				e.DisplayText = GetCustomColumnDisplayText(e.Value.ToString(), e.ListSourceRowIndex)
			End If
		End Sub
		Private Function GetCustomColumnDisplayText(ByVal groupValueText As String, ByVal imgIndex As Integer) As String
			Dim imgName As String
			Try
				imgName = imageCollection1.Images.InnerImages(imgIndex).Name
			Catch
				imgName = imageCollection1.Images.InnerImages(0).Name
			End Try
			Dim groupText = String.Format("<image={0}> {1}", imgName, groupValueText)
			Return groupText
		End Function
	End Class
End Namespace
