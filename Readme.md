<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E901)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [XtraReport1.cs](./CS/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/XtraReport1.vb))
<!-- default file list end -->
# How to make a report element occupy the entire page's width


<p>This example demonstrates how to make a label occupy the entire page's width.</p><p>For this, we insert some long text into the XRLabel control placed in the <strong>ReportHeader</strong> band. Note that the label's <strong>CanGrow</strong> property must be set to <i>True</i> (the default value), so that the label's height is automatically adjusted to display all the text it contains.</p><p>The <strong>CanGrow</strong> property does not affect a control's width.  If you want the <strong>XRLabel</strong> to change its size when page margins change, you should handle the <strong>XRLabel.BeforePrint</strong> event and set the label's <strong>Width</strong> property. The available page size - the total page size minus margins - can be obtained from the <strong>PrintingSystem.PageSettings.UsablePageSize</strong> property.</p>

<br/>


