import "ag-grid-community/styles/ag-grid.css";
import "ag-grid-community/styles/ag-theme-quartz.css";
import { ColDef } from "ag-grid-community";
import { AgGridReact } from "ag-grid-react";
import { useState, useEffect } from "react";

// Create new GridExample component
export const QuestionThree = () => {
  // Row Data: The data to be displayed.
  const [rowData, setRowData] = useState([
    {
      Account: "Mortgage",
      Type: "LOAN",
      Balance: 264950,
      desc: "425 test street",
      paymentAmount: 700,
      frequency: "Monthly",
      due: "03-30-2024",
    },
  ]);
  // Column Definitions: Defines & controls grid columns.
  const [colDefs] = useState<ColDef[]>([
    { field: "Account" },
    { field: "Type" },
    {
      field: "Balance",
      valueFormatter: (params) => {
        return "$" + params.value.toLocaleString();
      },
    },
    { field: "desc" },
    {
      field: "paymentAmount",
      valueFormatter: (params) => {
        return "$" + params.value.toLocaleString();
      },
    },
    { field: "frequency" },
    { field: "due" },
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
      style={{ width: "100%", height: "172px" }}
    >
      <AgGridReact rowData={rowData} columnDefs={colDefs} />
    </div>
  );
};
