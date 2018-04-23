using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace dxExample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            gridView1.Columns["Status"].GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView1.Columns["Status"].GroupFormat.FormatString = "n3";
        }
        private void Form1_Load(object sender, EventArgs e) {
            InitGridControl();
        }
        private void InitGridControl() {
            DataHelper.InitData(dataTable1);
        }
        private void gridView1_CustomDrawGroupRow(object sender, RowObjectCustomDrawEventArgs e) {
            DrawGroupRow(e);
        }
        private void DrawGroupRow(RowObjectCustomDrawEventArgs e) {
            var info = e.Info as GridGroupRowInfo;
            if (!(info.Column.FieldName == "ID")) {
                return;
            }
            GroupRowPaintHelper.CustomDrawSubjectColumnGroupRow(e, gridView1, gridControl1.LookAndFeel, imageList1);
            e.Handled = true;
        }
        private void gridView1_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e) {
            if(e.Column.FieldName == "Subject")
                e.DisplayText = GetCustomColumnDisplayText(e.Value.ToString(), e.ListSourceRowIndex);
        }
        private string GetCustomColumnDisplayText(string groupValueText, int imgIndex) {
            string imgName;
            try {
                imgName = imageCollection1.Images.InnerImages[imgIndex].Name;
            } catch {
                imgName = imageCollection1.Images.InnerImages[0].Name;
            }
            var groupText = string.Format("<image={0}> {1}", imgName, groupValueText);
            return groupText;
        }
    }
}
