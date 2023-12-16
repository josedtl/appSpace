"use client"
import React, { useState, useEffect } from "react";

import DR_Text from '@/ControlUi/DR_Text';
import Input from '@/Components/ui/Input';
import LabelDR from '@/Components/ui/LabelDR';
import TButtonPrimary from '@/Components/ui/Button/TButtonPrimary'

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
                <div className="col-span-2">
                    1
                </div>

                <div>
                    2
                </div>
                <div>
                    3
                </div>
                <div>
                    4
                </div>
                <div>
                    5
                </div>
                <div>
                    6
                </div>
                <div>
                    7
                </div>
                <div>
                    8
                </div>
                <div>
                    9
                </div>
                <div>
                    10
                </div>
                <div>
                    11
                </div>
                <div>
                    12
                </div>
                <div>
                    13
                </div>

            </div>

            <div className="grid grid-cols-12 bg-yellow-200 px-5 py-5"  >
                
                
                <div className="col-span-3 bg-red-200" >
                    <div className="px-2" >
                        <LabelDR>
                            Nombres
                        </LabelDR>
                        <Input
                            name="Nombres"
                            onChange={onChange}
                            value={Ent.Nombres === null ? "" : Ent.Nombres}
                        />
                    </div>
                    <div className="px-2" >
                        <LabelDR>
                            Apellido Paterno
                        </LabelDR>
                        <Input
                            name="ApellidoPaterno"
                            onChange={onChange}
                            value={Ent.Nombres === null ? "" : Ent.Nombres}
                        />
                    </div>
                    <div className="px-2" >
                        <LabelDR>
                            Apellido Materno
                        </LabelDR>
                        <Input
                            name="ApellidoMaterno"
                            onChange={onChange}
                            value={Ent.Nombres === null ? "" : Ent.Nombres}
                        />
                    </div>
                </div>

                <div className="col-span-9 bg-blue-200">
                    <TButtonPrimary>
                        Aceptar
                    </TButtonPrimary>
                    <TButtonPrimary>
                        Cancelar
                    </TButtonPrimary>

                </div>
            </div>

        </>
    )
}

export default Page;