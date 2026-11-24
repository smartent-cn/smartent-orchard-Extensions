# Quick start

> Index: [README.md](README.md) · Gateway: [../README.md](../README.md)

You can find a sample module with a commented walkthrough in this repository. Check it out [here](Smartent.Orchard.DataTables.Samples/Readme.md)!

### Static Content With Tag Helper

In the most basic form you can use [DOM sourced data](https://datatables.net/examples/data_sources/dom.html) with the `<datatable>` tag helper.

### Asynchronous Content With a Custom Provider

The `Smartent_Orchard_DataTables_DataTable` shape can display sortable, searchable, paginated data, but you must make your own data provider by extending `DataTableDataProviderBase` or either of the abstract base classes provided by us (`JsonResultDataTableDataProvider`, `IndexBasedDataTableDataProvider`). The latter is for complex database queries that would take a long time to calculate on demand, are tied to one or more content items and can be indexed ahead of time.

Once you have your data provider, it must be registered using `services.AddDataTableDataProvider<TProvider>()`, or if it's index-based then using `services.AddIndexBasedDataTableProvider<TIndex, TGenerator, TMigration, TProvider>()`.

If you need an admin page with just one data table you don't need to define a view, just link to `/Admin/DataTable/{providerName}/{queryId?}`.

You can find an example using [LinqToDb](https://gitee.com/smartent/smartent-orchard-Extensions) queries do display a table of deleted content items at [DeletedContentItemDataTableDataProvider.cs](Smartent.Orchard.DataTables/Services/DeletedContentItemDataTableDataProvider.cs).

If you want a display a table of deleted content items, we already happen to have a provider for that called [`DeletedContentItemDataTableDataProvider`](Smartent.Orchard.DataTables/Services/DeletedContentItemDataTableDataProvider.cs).
