import React from 'react'
import ReactDOM from 'react-dom/client'
import {
  createBrowserRouter,
  RouterProvider,
} from "react-router-dom";
import "primereact/resources/themes/lara-light-cyan/theme.css";
import './index.css'
import PageCliente from "./app/PersonaNatural/PersonaMain.tsx";
import App from './App.tsx';
const router = createBrowserRouter([
  {
    path: "/",
    // errorElement: <ErrorPage />,
    children: [
    
      { path: "Cliente", element: <PageCliente />, },
      { path: "App", element: <App />, },
    ],
  },
]);

ReactDOM.createRoot(document.getElementById('root')!).render(
  <React.StrictMode >
    <RouterProvider router={router} />
  </React.StrictMode>,
)
