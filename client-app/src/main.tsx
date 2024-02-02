import React from "react";
import ReactDOM from "react-dom/client";
import Root from "./routes/root.tsx";
import Profile from "./routes/profile.tsx";
import { createBrowserRouter, RouterProvider } from "react-router-dom";
import Header from "./components/Header.tsx";
import "./index.css";
import ErrorPage from "./error-page.tsx";

const router = createBrowserRouter([
  {
    path: "/",
    element: <Root />,
    errorElement: <ErrorPage />,
  },
  {
    path: "profile/:memberId",
    element: <Profile />,
  },
]);
ReactDOM.createRoot(document.getElementById("root")!).render(
  <React.StrictMode>
    <Header />
    <RouterProvider router={router} />
  </React.StrictMode>
);
