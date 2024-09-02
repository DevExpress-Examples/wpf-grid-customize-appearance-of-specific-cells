<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128648712/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2154)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF Data Grid - Customize appearance settings of cells based on column and row index

> **Note**:
> Use [Conditional Formatting](https://docs.devexpress.com/WPF/17130/controls-and-libraries/data-grid/conditional-formatting) to easily highlight cells or rows based on specified criteria without writing a single line of code.

This example creates `ColumnRowIndexesCellValueConverter` and uses multi-binding to customize the appearance of cells based on column and row indices:

```xaml
<dxg:GridControl x:Name="grid">
    <dxg:GridControl.Resources>
        <Style x:Key="customCellStyle"  BasedOn="{StaticResource {dxgt:GridRowThemeKey ResourceKey=LightweightCellStyle}}" TargetType="{x:Type dxg:LightweightCellEditor}">
            <Setter Property="Background">
                <Setter.Value>
                    <MultiBinding>
                        <MultiBinding.Converter>
                            <local:ColumnRowIndexesCellValueConverter />
                        </MultiBinding.Converter>
                        <Binding Path="Column" RelativeSource="{RelativeSource Self}" />
                        <Binding Path="Data.RowHandle.Value" />
                    </MultiBinding>
                </Setter.Value>
            </Setter>
        </Style>
    </dxg:GridControl.Resources>
    <dxg:GridControl.View>
        <dxg:TableView AutoWidth="True" CellStyle="{StaticResource customCellStyle}" />
    </dxg:GridControl.View>
    <dxg:GridControl.Columns>
        ...
    </dxg:GridControl.Columns>
</dxg:GridControl>
```


## Files to Review

* [Window1.xaml](./CS/DXGrid_ConditionalFormatting/Window1.xaml) (VB: [Window1.xaml](./VB/DXGrid_ConditionalFormatting/Window1.xaml))
* [Window1.xaml.cs](./CS/DXGrid_ConditionalFormatting/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/DXGrid_ConditionalFormatting/Window1.xaml.vb))


## Documentation

* [WPF Data Grid - Appearance Customization](https://docs.devexpress.com/WPF/6152/controls-and-libraries/data-grid/appearance-customization)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-grid-customize-appearance-of-specific-cells&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-grid-customize-appearance-of-specific-cells&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
