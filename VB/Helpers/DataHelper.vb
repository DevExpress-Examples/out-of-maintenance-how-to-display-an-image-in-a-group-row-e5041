Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace dxExample
	Public Class DataHelper
		Public Shared Sub InitData(ByVal dataTable As System.Data.DataTable)
			Dim flag = False
			For i = 0 To 3
				dataTable.Rows.Add(i, String.Format("Subject {0}", i),If(flag, 0, 1))
				flag = Not flag
			Next i
		End Sub
	End Class
End Namespace
