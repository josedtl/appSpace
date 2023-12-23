"use client"
import React, { useState, useEffect } from "react";

import DR_Text from '@/ControlUi/DR_Text';
import Input from '@/Components/ui/Input';
import LabelDR from '@/Components/ui/LabelDR';
import TButtonPrimary from '@/Components/ui/Button/TButtonPrimary'
import TableMain from "@/Components/ui/Table/TableMain";

class PersonaEntity {
    Nombres: string = "";
    ApellidoPaterno: string = "";
    ApellidoMaterno: string = "";
}

function Page() {

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
                <div className=" col-span-10 px-10 py-1 ">
                    Persona Natural MAIN
                </div>
                <div className=" col-span-2 px-2 py-2 bg-right">
                    <TButtonPrimary>
                        Aceptar
                    </TButtonPrimary>
                    <TButtonPrimary>
                        Cancelar
                    </TButtonPrimary>
                </div>
            </div>



            <div className="relative overflow-x-auto shadow-md sm:rounded-lg px-5">
                <TableMain/>

            </div>

        </>
    )
}

export default Page;