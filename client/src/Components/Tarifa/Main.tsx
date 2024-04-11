import React, { useEffect, useState } from 'react';
import { Button, Col, Row, Typography, Input, Card } from "antd";
import { Link } from "react-router-dom";
import { ButtonAddMain, ButtonMainSecondaryLeft, ButtonMainSecondaryRight, InputSearchMain } from '../../Styles/Button'
import { SizeButtonPrimary, SizeMainButtonSecondary } from "../../Styles/Type";
import { IconAdd, IconLoad, IconTabla, IconCard, IconFiltro, IconReport } from "../../Styles/Icons";
import DateTable from './DataTable';
import TarifaService from '../../Service/TarifaService';
import { TarifaMainEntity } from '../../Models/TarifaEntity';

function Main() {
    const [disabled, setDisabled] = useState<boolean>(false);
    const { Title } = Typography;
    const sTarifa = new TarifaService();
    const [ListaMain, setListaMain] = useState<TarifaMainEntity[]>([]);

    useEffect(() => {
        GetMainTarifa();

    }, []);



    const GetMainTarifa = async () => {

        const data =await sTarifa.getItems();
        setListaMain(data);


    }

    return (
        <>
            <Row>
                <Col xs={18} sm={18} md={12} lg={12} xl={12}>
                    <Title level={2}>   Tarifa</Title>
                </Col>

                <Col xs={6} sm={6} md={12} lg={12} xl={12}>
                    <Link to={`/TarifaSave/0`}>
                        <Button
                            style={ButtonAddMain}
                            size={SizeButtonPrimary}
                            icon={IconAdd}
                        ></Button>



                    </Link>
                </Col>

                <Col xs={24} sm={24} md={12} lg={12} xl={12}>
                    <Button
                        style={ButtonMainSecondaryLeft}
                        size={SizeMainButtonSecondary}
                        icon={IconLoad}
                    />
                    <Button
                        style={ButtonMainSecondaryLeft}
                        size={SizeMainButtonSecondary}
                        icon={disabled ? IconTabla : IconCard}
                    />

                    <Button
                        style={ButtonMainSecondaryLeft}
                        size={SizeMainButtonSecondary}
                        icon={IconReport}
                    />
                    <Button
                        style={ButtonMainSecondaryRight}
                        size={SizeMainButtonSecondary}
                        icon={IconFiltro}
                    />

                </Col>

                <Col xs={24} sm={24} md={12} lg={12} xl={12}>

                    <Input
                        placeholder='Buscar Tarifa'
                        type="text"
                        name="Nombre"
                        style={InputSearchMain}
                        size={SizeMainButtonSecondary}
                    />
                </Col>
            </Row>
            <Card>
                <DateTable DataList={ListaMain} />
            </Card>

        </>

    )

}


export default Main;
