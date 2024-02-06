import "ag-grid-community/styles/ag-grid.css";
import "ag-grid-community/styles/ag-theme-quartz.css";
import { ColDef } from "ag-grid-community";
import { AgGridReact } from "ag-grid-react";
import { useState, useEffect } from "react";

// Create new GridExample component
export const QuestionFour = () => {
  // Row Data: The data to be displayed.
  const [rowData, setRowData] = useState([
    {
      Date: "01-05-2024",
      Account: "59+ chequing",
      Description: "External Withdrawal from Rogers",
      AccountNo: "1100102456519380",
      Amount: -65.0,
    },
    {
      Date: "01-05-2024",
      Account: "59+ chequing",
      Description: "External Deposit from Climate Incentive",
      AccountNo: "1100102456519380",
      Amount: 9.5,
    },
    {
      Date: "01-23-2024",
      Account: "59+ savings",
      Description: "External Withdrawal from Apple Polo park",
      AccountNo: "1100102456224918",
      Amount: -33.0,
    },
    {
      Date: "01-31-2024",
      Account: "59+ savings",
      Description: "External Withdrawal from Manitoba Hydro",
      AccountNo: "1100102456224918",
      Amount: -338.0,
    },
    {
      Date: "01-30-2024",
      Account: "TFSA Savings",
      Description: "External Deposit from CPP Pension CANADA",
      AccountNo: "1100102321510839",
      Amount: 529.6,
    },
  ]);
  // Column Definitions: Defines & controls grid columns.
  const [colDefs] = useState<ColDef[]>([
    { field: "Date", sort: "desc" },
    { field: "Account" },
    { field: "AccountNo", headerName: "Account Number" },
    { field: "Description" },
    {
      field: "Amount",
      valueFormatter: (params) => {
        const formattedValue = parseFloat(params.value).toFixed(2);
        const numericValue = parseFloat(formattedValue); // Convert to number
        return numericValue < 0
          ? `($${Math.abs(numericValue).toFixed(2)})`
          : `$${formattedValue}`;
      },
    },
  ]);

  // Fetch data from server
  //   useEffect(() => {
  //     fetch("https://www.ag-grid.com/example-assets/space-mission-data.json")
  //       .then((result) => result.json()) // Convert to JSON
  //       .then((rowData) => {
  //         console.log(rowData);
  //         setRowData(rowData);
  //       }); // Update state of `rowData`
  //   }, []);

  // Container: Defines the grid's theme & dimensions.
  return (
    <div
      className={"ag-theme-quartz"}
      style={{ width: "100%", height: "262px" }}
    >
      <AgGridReact rowData={rowData} columnDefs={colDefs} />
    </div>
  );
};
