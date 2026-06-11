# Master-Details View with Blazor DataGrid

A Blazor server application that demonstrates how to build a hierarchical master-details view using the [Blazor DataGrid](https://www.syncfusion.com/blazor-components/blazor-datagrid) component.

## Overview

This project provides a complete example of implementing a master-details relationship using two synchronized Blazor DataGrid components. When you select a customer from the master grid, the details grid automatically updates to show all orders associated with that customer. This pattern is commonly used in business applications to display hierarchical data in an intuitive, interactive way.

## Features

- **Master-details relationship** — Select a customer in the master grid to view their orders
- **Event-driven synchronization** — Real-time binding between grids using row selection events
- **Sample data** — Pre-populated with customer and order information
- **Responsive design** — Clean layout with Bootstrap styling
- **Blazor Server** — Full server-side rendering with interactive components

## Prerequisites

* [.NET SDK 10.0](https://dotnet.microsoft.com/en-us/download/dotnet/10.0) or later
* [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or later
* [Visual Studio Code](https://code.visualstudio.com/)

## Getting Started

### Clone the Repository

```bash
git clone https://github.com/SyncfusionExamples/create-master-details-view-using-blazor-datagrid.git
cd create-master-details-view-using-blazor-datagrid
```

### Run with Visual Studio

1. Open the solution file using Visual Studio 2022 or later.
2. Restore the NuGet packages by rebuilding the solution.
3. Build the project to ensure there are no compilation errors.
4. Run the project.

### Run with .NET CLI

```bash
# Restore dependencies
dotnet restore

# Run the project
dotnet run
```

## References

**Online example**: https://blazor.syncfusion.com/demos/datagrid/master-details?theme=fluent2