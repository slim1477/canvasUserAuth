import "ag-grid-community/styles/ag-grid.css";
import "ag-grid-community/styles/ag-theme-quartz.css";
import { ColDef } from "ag-grid-community";
import { AgGridReact } from "ag-grid-react";
import { useState, useEffect } from "react";

// Create new GridExample component
export const QuestionOne = () => {
  // Row Data: The data to be displayed.
  const [rowData, setRowData] = useState([
    { Account: "59+ chequing", Type: "CHEQ", Amount: 64950 },
    { Account: "59+ savings", Type: "SAVN", Amount: 33850 },
    { Account: "TFSA Savings", Type: "SAVN", Amount: 29600 },
  ]);
  // Column Definitions: Defines & controls grid columns.
  const [colDefs] = useState<ColDef[]>([
    { field: "Account" },
    { field: "Type" },
    {
      field: "Amount",
      valueFormatter: (params) => {
        return "$" + params.value.toLocaleString();
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
      style={{ width: "100%", height: "200px" }}
    >
      <AgGridReact rowData={rowData} columnDefs={colDefs} />
    </div>
  );
};
