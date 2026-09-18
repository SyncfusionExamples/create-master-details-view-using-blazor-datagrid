# Blazor DataGrid - Custom Adaptor as Component with CRUD, Sorting, and Filtering

## Overview

This sample demonstrates how to bind a Syncfusion Blazor DataGrid using a custom adaptor implemented as a Blazor component. The custom adaptor is created by extending `OwningComponentBase` and uses the `DataAdaptor` base class to process DataGrid requests. The sample supports Create, Read, Update, and Delete (CRUD) operations together with sorting and filtering, enabling complete control over how grid data is retrieved, modified, and persisted. This approach is useful when applications require custom business logic, service-based data access, or advanced server-side processing that extends beyond the functionality provided by built-in adaptors.

## Key Features

- Implements a custom DataGrid adaptor using the `DataAdaptor` base class.
- Extends `OwningComponentBase` to create the adaptor as a Blazor component.
- Supports Create, Read, Update, and Delete (CRUD) operations.
- Processes DataGrid sorting requests through custom adaptor logic.
- Processes DataGrid filtering requests through custom adaptor logic.
- Demonstrates custom server-side data binding for Syncfusion Blazor DataGrid.
- Uses a database-backed data source based on the Northwind sample database.
- Shows how services can be consumed within a component-based adaptor implementation.
- Demonstrates handling DataManager requests through custom business logic.
- Provides a reusable foundation for implementing custom data access and persistence workflows.
- Uses custom data-processing logic instead of built-in DataManager adaptors.

## Prerequisites

- Visual Studio 2022 or Visual Studio Code
- .NET SDK compatible with the project's target framework
- Microsoft SQL Server LocalDB or a compatible SQL Server installation hosting the Northwind database
- Ensure to modify the path of `NORTHWIND.MDF` in `OrderContext.cs` based on your local path before running the sample.

## How to Run the Project

**Visual Studio 2022**

1. Clone or download this repository.
2. Open the solution file: `CustomAdaptorSortFilter/CustomAdaptorSortFilter.sln`
3. Restore all NuGet packages.
4. Update the `NORTHWIND.MDF` database path in `OrderContext.cs`.
5. Set the startup project to:   `CustomAdaptorSortFilter`
6. Build the solution.
7. Run the application using `Ctrl+F5`.
8. Open the local URL displayed by the application after startup.
9. Verify CRUD, sorting, and filtering operations in the DataGrid.

**Visual Studio Code**

1. Open the repository folder in Visual Studio Code.
2. Open the integrated terminal.
3. Navigate to the project directory.

```bash
cd CustomAdaptorSortFilter
dotnet restore
dotnet run
```

4. Update the `NORTHWIND.MDF` database path in `OrderContext.cs`.
5. Open the local URL displayed after application startup.
6. Test CRUD, sorting, and filtering functionality through the DataGrid interface.

## Project Structure

`CustomAdaptorSortFilter/Pages/` — contains the page that hosts the Syncfusion DataGrid and connects it to the custom adaptor component.

`CustomAdaptorSortFilter/Data/` — contains the custom adaptor implementation, entity models, business logic, and supporting data-processing services.

`CustomAdaptorSortFilter/Data/OrderContext.cs` — configures database access and contains the Northwind database path required by the sample.

`CustomAdaptorSortFilter/Program.cs` — registers services and dependency injection configuration consumed by the custom adaptor component.

## Support and Feedback

- For general product questions, visit the [Syncfusion Community Forum](https://www.syncfusion.com/forums) or [Syncfusion Support](https://www.syncfusion.com/support).
- To report an issue specific to this sample, open a GitHub issue in this repository.
- For official documentation related to custom adaptor data binding, visit https://help.syncfusion.com/grid-sdk/blazor/data-grid/connecting-to-adaptors/custom-adaptor

## License

This is a Syncfusion sample project provided to demonstrate product usage. Review the [Syncfusion license terms](https://www.syncfusion.com/sales/pricing?category=ui-components) before using Syncfusion components in your own applications.