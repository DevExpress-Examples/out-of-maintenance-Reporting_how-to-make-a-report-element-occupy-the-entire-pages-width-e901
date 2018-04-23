# How to make a report element occupy the entire page's width


<p>This example demonstrates how to make a label occupy the entire page's width.</p><p>For this, we insert some long text into the XRLabel control placed in the <strong>ReportHeader</strong> band. Note that the label's <strong>CanGrow</strong> property must be set to <i>True</i> (the default value), so that the label's height is automatically adjusted to display all the text it contains.</p><p>The <strong>CanGrow</strong> property does not affect a control's width.  If you want the <strong>XRLabel</strong> to change its size when page margins change, you should handle the <strong>XRLabel.BeforePrint</strong> event and set the label's <strong>Width</strong> property. The available page size - the total page size minus margins - can be obtained from the <strong>PrintingSystem.PageSettings.UsablePageSize</strong> property.</p>

<br/>


