import React, { useState, useEffect } from "react";

import { Button } from 'primereact/button';
import { DataTable } from 'primereact/datatable';
import { Column } from 'primereact/column';
class PersonaEntity {
    Nombres: string = "";
    ApellidoPaterno: string = "";
    ApellidoMaterno: string = "";
}

function PersonaMain() {

    const [FlaState, setFlaState] = useState<string>("d");
    const [Ent, setEnt] = useState<PersonaEntity>(new PersonaEntity());


    const onChange = (e: React.ChangeEvent<HTMLInputElement>) => {
        console.log("Ejecutado")
        setEnt({
            ...Ent,
            [e.target.name]: e.target.value.toUpperCase()
        });

    };

    const Cargar = () => {

        console.log(FlaState);

    };
    return (

        <>
            <div className="grid grid-cols-12 px-2 py-5" >
                <div className=" col-span-10 px-5 py-1 ">
                    Persona Natural MAIN dd
                </div>
                <div className=" col-span-1 px-1 py-1 bg-right">

                    <Button
                        className="middle none center mr-4 
                     flex items-center justify-center rounded-lg bg-gradient-to-tr 
                     bg-DRgreen hover:bg-DRgreenOscuro
                     p-3 font-sans text-xs font-bold uppercase 
                     text-white shadow-md  transition-all hover:shadow-lg             
                     disabled:shadow-none"
                        label="Agregar" />
                </div>


            </div>

            <div className="relative overflow-x-auto shadow-md sm:rounded-lg px-5">
                <DataTable tableStyle={{ minWidth: '50rem' }}>
                    <Column field="code" header="Code"></Column>
                    <Column field="name" header="Name"></Column>
                    <Column field="category" header="Category"></Column>
                    <Column field="quantity" header="Quantity"></Column>
                </DataTable>
            </div>



        </>
    )
}

export default PersonaMain;