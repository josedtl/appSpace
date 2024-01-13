import React, { useState, useEffect } from "react";

import DR_Text from '../../ControlUi/DR_Text';
import Input from '../../Components/ui/Input';
import LabelDR from '../../Components/ui/LabelDR';
import TButtonPrimary from '../../Components/ui/Button/TButtonPrimary'
import TableMain from "../../Components/ui/Table/TableMain";

class PersonaEntity {
    Nombres: string = "";
    ApellidoPaterno: string = "";
    ApellidoMaterno: string = "";
}

function PersonaSave() {

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

export default PersonaSave;