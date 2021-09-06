<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128648712/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2154)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Window1.xaml](./CS/DXGrid_ConditionalFormatting/Window1.xaml) (VB: [Window1.xaml](./VB/DXGrid_ConditionalFormatting/Window1.xaml))
* **[Window1.xaml.cs](./CS/DXGrid_ConditionalFormatting/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/DXGrid_ConditionalFormatting/Window1.xaml.vb))**
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


