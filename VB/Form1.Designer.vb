Namespace dxExample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.dataSet1 = New System.Data.DataSet()
			Me.dataTable1 = New System.Data.DataTable()
			Me.dataColumn1 = New System.Data.DataColumn()
			Me.dataColumn2 = New System.Data.DataColumn()
			Me.dataColumn3 = New System.Data.DataColumn()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colSubject = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
			Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
			Me.repositoryItemImageComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dataSet1
			' 
			Me.dataSet1.DataSetName = "NewDataSet"
			Me.dataSet1.Tables.AddRange(New System.Data.DataTable() { Me.dataTable1})
			' 
			' dataTable1
			' 
			Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1, Me.dataColumn2, Me.dataColumn3})
			Me.dataTable1.TableName = "Table1"
			' 
			' dataColumn1
			' 
			Me.dataColumn1.ColumnName = "ID"
			' 
			' dataColumn2
			' 
			Me.dataColumn2.ColumnName = "Subject"
			' 
			' dataColumn3
			' 
			Me.dataColumn3.ColumnName = "Status"
			Me.dataColumn3.DataType = GetType(Integer)
			' 
			' gridControl1
			' 
			Me.gridControl1.DataMember = "Table1"
			Me.gridControl1.DataSource = Me.dataSet1
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemImageComboBox1, Me.repositoryItemImageComboBox2, Me.repositoryItemButtonEdit1})
			Me.gridControl1.Size = New System.Drawing.Size(430, 341)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colID, Me.colSubject, Me.colStatus})
			Me.gridView1.CustomizationFormBounds = New System.Drawing.Rectangle(256, 354, 210, 179)
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.HtmlImages = Me.imageCollection1
			Me.gridView1.Name = "gridView1"
'			Me.gridView1.CustomDrawGroupRow += New DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(Me.gridView1_CustomDrawGroupRow)
'			Me.gridView1.CustomColumnDisplayText += New DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(Me.gridView1_CustomColumnDisplayText)
			' 
			' colID
			' 
			Me.colID.Caption = "ID [custom draw]"
			Me.colID.FieldName = "ID"
			Me.colID.Name = "colID"
			Me.colID.Visible = True
			Me.colID.VisibleIndex = 0
			' 
			' colSubject
			' 
			Me.colSubject.Caption = "Subject [HTML text]"
			Me.colSubject.ColumnEdit = Me.repositoryItemButtonEdit1
			Me.colSubject.FieldName = "Subject"
			Me.colSubject.Name = "colSubject"
			Me.colSubject.Visible = True
			Me.colSubject.VisibleIndex = 1
			' 
			' repositoryItemButtonEdit1
			' 
			Me.repositoryItemButtonEdit1.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True
			Me.repositoryItemButtonEdit1.AutoHeight = False
			Me.repositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1"
			Me.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			' 
			' colStatus
			' 
			Me.colStatus.Caption = "Status [ImageComboBox]"
			Me.colStatus.ColumnEdit = Me.repositoryItemImageComboBox1
			Me.colStatus.FieldName = "Status"
			Me.colStatus.Name = "colStatus"
			Me.colStatus.Visible = True
			Me.colStatus.VisibleIndex = 2
			' 
			' repositoryItemImageComboBox1
			' 
			Me.repositoryItemImageComboBox1.AutoHeight = False
			Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemImageComboBox1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { _
				New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Read", 1, 0), _
				New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Unread", 0, 1) _
			})
			Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
			Me.repositoryItemImageComboBox1.SmallImages = Me.imageCollection1
			' 
			' imageCollection1
			' 
			Me.imageCollection1.ImageStream = (CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.imageCollection1.Images.SetKeyName(0, "read.bmp")
			Me.imageCollection1.Images.SetKeyName(1, "unread.bmp")
			Me.imageCollection1.Images.SetKeyName(2, "1.png")
			Me.imageCollection1.Images.SetKeyName(3, "2.png")
			Me.imageCollection1.Images.SetKeyName(4, "3.png")
			Me.imageCollection1.Images.SetKeyName(5, "5.jpg")
			Me.imageCollection1.Images.SetKeyName(6, "6.jpg")
			Me.imageCollection1.Images.SetKeyName(7, "7.jpg")
			Me.imageCollection1.Images.SetKeyName(8, "8.jpg")
			Me.imageCollection1.Images.SetKeyName(9, "printIcon.png")
			' 
			' repositoryItemImageComboBox2
			' 
			Me.repositoryItemImageComboBox2.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True
			Me.repositoryItemImageComboBox2.AutoHeight = False
			Me.repositoryItemImageComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2"
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "1.png")
			Me.imageList1.Images.SetKeyName(1, "2.png")
			Me.imageList1.Images.SetKeyName(2, "3.png")
			Me.imageList1.Images.SetKeyName(3, "5.jpg")
			Me.imageList1.Images.SetKeyName(4, "6.jpg")
			Me.imageList1.Images.SetKeyName(5, "7.jpg")
			Me.imageList1.Images.SetKeyName(6, "8.jpg")
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(430, 341)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private dataSet1 As System.Data.DataSet
		Private dataTable1 As System.Data.DataTable
		Private dataColumn1 As System.Data.DataColumn
		Private dataColumn2 As System.Data.DataColumn
		Private dataColumn3 As System.Data.DataColumn
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private colID As DevExpress.XtraGrid.Columns.GridColumn
		Private colSubject As DevExpress.XtraGrid.Columns.GridColumn
		Private colStatus As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private imageCollection1 As DevExpress.Utils.ImageCollection
		Private repositoryItemImageComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private imageList1 As System.Windows.Forms.ImageList
		Private repositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
	End Class
End Namespace

