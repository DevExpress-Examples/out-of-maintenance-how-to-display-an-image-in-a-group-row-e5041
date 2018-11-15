<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [DataHelper.cs](./CS/Helpers/DataHelper.cs) (VB: [DataHelper.vb](./VB/Helpers/DataHelper.vb))
* [GroupRowPaintHelper.cs](./CS/Helpers/GroupRowPaintHelper.cs) (VB: [GroupRowPaintHelper.vb](./VB/Helpers/GroupRowPaintHelper.vb))
<!-- default file list end -->
# How to display an image in a group row


<p>This example demonstrates how to display an image in a group row.</p><p>In this project a column's group row is painted using different approaches:<br />
<i>The ID column</i><i>:<br />
</i><i>T</i>he CustomDrawGroupRow event is handled in order to perform custom group row painting.<br />
<i>The Subject column</i><i>:</i><i><br />
</i>Handle the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsBaseColumnView_CustomColumnDisplayTexttopic"><u>GridView.CustomColumnDisplayText</u></a> event in order to specify e.DisplayText with an HTML image tag. An image can be accessed either from a bound image collection or from project resources. <br />
<i>The Status column </i><i><br />
</i>An in-place <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsImageComboBoxEditMembersTopicAll"><u>ImageComboBoxEdit</u></a> is used as a column edit and its SmallImages is set to an image collection.</p><p>For more information refer to <a href="https://www.devexpress.com/Support/Center/p/KA18890">How to display an image in a group row</a><u>.</u></p>

<br/>


