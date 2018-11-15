<!-- default file list -->
*Files to look at*:

* **[Window1.xaml](./CS/DXGrid_ConditionalFormatting/Window1.xaml) (VB: [Window1.xaml.vb](./VB/DXGrid_ConditionalFormatting/Window1.xaml.vb))**
* [Window1.xaml.cs](./CS/DXGrid_ConditionalFormatting/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/DXGrid_ConditionalFormatting/Window1.xaml.vb))
<!-- default file list end -->
# How to: Change cell appearance based on its column and row index


<p>It's possible to pass any value to the converter. In the Convert method the value of the property is passed, to which the Setter Value property was bound. To bind to the RowHandle.Value, use the following style:</p>
<p><Style x:Key="customCellStyle" TargetType="dxg:CellContentPresenter"><br />    <Setter Property="Background"<br />            Value="{Binding Path= Data.RowHandle.Value,<br />            Converter={local:YourConverter}}"/><br /> </Style></p>
<p>Note the data context of the cell style for the View is the RowData (<a href="http://documentation.devexpress.com/#WPF/DevExpressWpfGridRowDataMembersTopicAll"><u>RowData Members </u></a>)<br /> However, it's possible to bind to properties of the CellContentPresenter itself (<a href="http://documentation.devexpress.com/#WPF/DevExpressWpfGridCellContentPresenterMembersTopicAll"><u>CellContentPresenter Members </u></a>).</p>
<p>To bind to the GridColumn.VisibleIndex, write the following style:</p>
<p><Style x:Key="customCellStyle" TargetType="dxg:CellContentPresenter"><br />    <Setter Property="Background"<br />            Value="{Binding Path= Column.VisibleIndex, RelativeSource={RelativeSource Self},<br />            Converter={local:YourConverter}}"/><br /> </Style></p>
<p>Use multi binding, to pass two values to the converter. The sample illustrates how to use multi binding.<br /><br /></p>
<p><strong>Update: Take special note of our </strong><a href="https://documentation.devexpress.com/#WPF/CustomDocument17130"><strong>Conditional Formatting</strong></a><strong> as well.</strong></p>

<br/>


