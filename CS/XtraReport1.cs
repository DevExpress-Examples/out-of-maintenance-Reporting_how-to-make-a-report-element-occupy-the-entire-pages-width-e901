using System;
// ...

namespace PageWidth {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private void xrLabel1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            xrLabel1.Width = Convert.ToInt32(PrintingSystem.PageSettings.UsablePageSize.Width) - 1;
        }

    }
}
