
import React from 'react'
import ReactDOM from 'react-dom/client'
import Root from "./routes/root";
import {
  createBrowserRouter,
  RouterProvider,
} from "react-router-dom";

import PageOrdenPedido from "./Components/OrdenPedido/Main";
import PageOrdenPedidoSave from "./Components/OrdenPedido/OrdenPedidoDetalle/Save";
import PagePersonaNatural from "./Components/Entidad/PersonaNatural/Main";
import PagePersonaNaturalSave from "./Components/Entidad/PersonaNatural/Save";
import PageEmpresa from "./Components/Entidad/Empresa/Main";
import PageEmpresaSave from "./Components/Entidad/Empresa/Save";
import ProductoEnlace from "./Components/MerLista/Main";
import EntidadMenu from "./Components/Entidad/Menu";
import PageTarifaMain from "./Components/Tarifa/Main"
import PageTarifaSave from "./Components/Tarifa/Save"
import PageServicioMain from "./Components/Servicio/Main"
import PageServicioSave from "./Components/Servicio/Save"
import PageInfraestructuraMenu from "./Components/Infraestructura/Menu";
import PageinfraestructuraMain from "./Components/Infraestructura/Main";
import PageInfraestructuraSave from "./Components/Infraestructura/Save";
import InfraestructuraEnlace from "./Components/Infraestructura/Enlace/InfraLista/Main";
import PageAlquilerMain from "./Components/Alquiler/Main";
import PageAlquilerSave from "./Components/Alquiler/Save";

const router = createBrowserRouter([
  {
    path: "/",
    element: <Root />,
    // errorElement: <ErrorPage />,
    children: [
      { path: "PersonaNatural", element: <PagePersonaNatural />, },
      { path: "PersonaNaturalSave/:Id", element: <PagePersonaNaturalSave />, },
      { path: "OrdenPedido", element: <PageOrdenPedido />, },
      { path: "OrdenPedidoSave/:Id", element: <PageOrdenPedidoSave />, },
      { path: "Empresa", element: <PageEmpresa />, },
      { path: "EmpresaSave/:Id", element: <PageEmpresaSave />, },
      { path: "Producto/Enlace/:Id", element: <ProductoEnlace />, },
      { path: "Entidad", element: <EntidadMenu />, },
      { path: "Tarifa", element: <PageTarifaMain />, },
      { path: "TarifaSave/:Id", element: <PageTarifaSave />, },
      { path: "Infraestrutura/Menu", element: <PageInfraestructuraMenu />, },
      { path: "Infraestructura", element: <PageinfraestructuraMain />, },
      { path: "InfraestructuraSave/:Id", element: <PageInfraestructuraSave />, },
      { path: "Infraestructura/Enlace/:Id", element: <InfraestructuraEnlace />, },
      { path: "Servicio", element: <PageServicioMain />, },
      { path: "ServicioSave/:Id", element: <PageServicioSave />, },
      { path: "Alquiler", element: <PageAlquilerMain />, },
      { path: "AlquilerSave/:Id", element: <PageAlquilerSave />, },
    ],
  },
]);

ReactDOM.createRoot(document.getElementById('root')!).render(
  <React.StrictMode>
    <RouterProvider router={router} />
  </React.StrictMode>,
)
