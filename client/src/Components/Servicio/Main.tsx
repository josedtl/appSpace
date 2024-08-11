
import DateTable from './DataTable';
import ServicioService from '../../Service/ServicioService';
import { ServicioEntity, ServicioMainEntity } from '../../Models/ServicioEntity';
import { Button, Col, Row, Typography, Input, Card } from "antd";
import React, { useEffect, useState } from 'react';
import { ButtonAddMain, ButtonMainSecondaryLeft, ButtonMainSecondaryRight, InputSearchMain } from '../../Styles/Button'
import { SizeButtonPrimary, SizeMainButtonSecondary } from "../../Styles/Type";
import { IconAdd, IconLoad, IconTabla, IconCard, IconFiltro, IconReport } from "../../Styles/Icons";
import { Link } from "react-router-dom";

function Main() {
    const [disabled, setDisabled] = useState<boolean>(false);
    const { Title } = Typography;
    const sTarifa = new ServicioService();
    const [ListaMain, setListaMain] = useState<ServicioMainEntity[]>([]);

    const [items, setItems] = useState<ServicioMainEntity[]>([]);
    useEffect(() => {
        GetMainServicio();

    }, []);

    const GetMainServicio = async () => {

        const data =await sTarifa.ObtenerMain();
        setListaMain(data);
    }

    
  const updateState = (item: ServicioMainEntity) => {
    const itemIndex = items.findIndex((data) => data.ServicioId === item.ServicioId);
    const newArray = [...items.slice(0, itemIndex), item, ...items.slice(itemIndex + 1)];
    setItems(newArray);
  };
  const deleteItemFromState = (id: number) => {
    const updatedItems = items.filter((item) => item.ServicioId !== id);
    setItems(updatedItems);
  };



    return (
        <>

        
            <Row>
                <Col xs={18} sm={18} md={12} lg={12} xl={12}>
                    <Title level={2}>Servicio</Title>
                </Col>

                <Col xs={6} sm={6} md={12} lg={12} xl={12}>
                    <Link to={`/ServicioSave/0`}>
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
                        placeholder='Buscar Servicio'
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
