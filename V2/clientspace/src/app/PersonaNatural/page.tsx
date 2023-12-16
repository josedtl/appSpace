"use client"
import React, { useState, useEffect } from "react";

import DR_Text from '@/ControlUi/DR_Text';
import { Input } from '@/Components/ui/Input';
import LabelDR from '@/Components/ui/LabelDR';

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
            <div className="grid grid-cols-12">
                <div className="col-span-3">

                    <div >
                        <LabelDR>
                            Nombres
                        </LabelDR>
                        <Input
                            name="Nombres"
                            onChange={onChange}
                            value={Ent.Nombres === null ? "" : Ent.Nombres}
                        />
                    </div>+
                    <div >
                        <LabelDR>
                            Apellidos
                        </LabelDR>
                        <Input
                            name="ApellidoPaterno"
                            onChange={onChange}
                            value={Ent.Nombres === null ? "" : Ent.Nombres}
                        />
                    </div>
                    <div >
                        <DR_Text
                            name="ApellidoMaterno"
                            header="Apellido Paterno"
                            onChange={onChange}
                            value={Ent.ApellidoMaterno === null ? "" : Ent.ApellidoMaterno}
                        />
                    </div>

                </div>
                <div className="col-span-9 bg-blue-200">



                </div>



            </div>




        </>
    )
}

export default Page;