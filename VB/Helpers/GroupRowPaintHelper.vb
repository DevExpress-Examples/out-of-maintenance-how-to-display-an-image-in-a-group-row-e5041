Imports Microsoft.VisualBasic
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Linq
Imports System.Windows.Forms

Namespace dxExample
	Public Class GroupRowPaintHelper
		Public Shared Sub CustomDrawSubjectColumnGroupRow(ByVal e As RowObjectCustomDrawEventArgs, ByVal view As GridView, ByVal lookAndFeel As DevExpress.LookAndFeel.UserLookAndFeel, ByVal imgList As ImageList)
			Dim info = TryCast(e.Info, GridGroupRowInfo)
			DrawGradientBackground(e, info)
			DrawExpandButton(e, info, view, lookAndFeel)
			Dim textPos = DrawGroupRowCustomImage(e, info, view, imgList)
			DrawFormattedString(info, textPos)
		End Sub
		Private Shared Sub DrawGradientBackground(ByVal e As RowObjectCustomDrawEventArgs, ByVal info As GridGroupRowInfo)
			Dim linGrBrush = New LinearGradientBrush(info.DataBounds, Color.FromArgb(&HFF, &HFF, &H99), Color.FromArgb(&H00, &HCC, &H00), 45)
			e.Graphics.FillRectangle(linGrBrush, info.DataBounds)
		End Sub
		Private Shared Sub DrawExpandButton(ByVal e As RowObjectCustomDrawEventArgs, ByVal info As GridGroupRowInfo, ByVal view As GridView, ByVal lookAndFeel As DevExpress.LookAndFeel.UserLookAndFeel)
			Dim img As Image = GetExpandButtonImage(e, view, lookAndFeel)
			If img Is Nothing Then
				Return
			End If
			info.Graphics.DrawImage(img, info.ButtonBounds)
		End Sub
		Private Shared Function GetExpandButtonImage(ByVal e As RowObjectCustomDrawEventArgs, ByVal view As GridView, ByVal lookAndFeel As DevExpress.LookAndFeel.UserLookAndFeel) As Image
			Dim currentSkin = GridSkins.GetSkin(lookAndFeel)
			Dim plusMinusButton = currentSkin(GridSkins.SkinPlusMinus)
			Dim images = plusMinusButton.Image.GetImages()
			Dim rowExpanded = view.GetRowExpanded(e.RowHandle)
			Dim imgIndex = If(rowExpanded, 1, 0)
			Dim img = images.Images(imgIndex)
			Return img
		End Function
		Private Shared Sub DrawFormattedString(ByVal info As GridGroupRowInfo, ByVal textPos As Point)
			Dim text = GetCustomDisplayText(info.GroupValueText)
			Dim textFont = New Font(info.Appearance.Font, FontStyle.Italic Or FontStyle.Bold)
			Dim textBrush = New SolidBrush(Color.FromArgb(&H00, &H66, &H00))
			info.Graphics.DrawString(text, textFont, textBrush, textPos)
		End Sub
		Private Shared Function GetCustomDisplayText(ByVal groupValueText As String) As String
			Return String.Format("Group row custom caption: {0}", groupValueText)
		End Function
		Private Shared Function DrawGroupRowCustomImage(ByVal e As RowObjectCustomDrawEventArgs, ByVal info As GridGroupRowInfo, ByVal view As GridView, ByVal imgList As ImageList) As Point
			Dim imgIndex = view.GetDataSourceRowIndex(e.RowHandle)
			Dim img As Image
			img = GetGroupRowCustomImage(imgList, imgIndex)
			Dim imgPos = CalcImgPosition(e, info)
			If img Is Nothing Then
				Return imgPos
			End If
			info.Graphics.DrawImage(img, imgPos)
			Dim imageRightBottomCorner As New Point(imgPos.X + img.Width, imgPos.Y)
			Return imageRightBottomCorner
		End Function
		Private Shared Function GetGroupRowCustomImage(ByVal imgList As ImageList, ByVal imgIndex As Integer) As Image
			Dim img As Image
			Try
				img = imgList.Images(Math.Abs(imgIndex))
			Catch
				Dim defaultImg = imgList.Images(0)
				img = defaultImg
			End Try
			Return img
		End Function
		Private Shared Function CalcImgPosition(ByVal e As RowObjectCustomDrawEventArgs, ByVal info As GridGroupRowInfo) As Point
			Return New Point(info.ButtonBounds.Right, info.ButtonBounds.Y)
		End Function
	End Class
End Namespace
