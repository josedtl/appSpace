import React, { useEffect, useState } from 'react';
import { Row, Col, Typography, Card, Spin,Button,Input } from 'antd';
import InfraestructuraService from '../../Service/InfraestructuraService';
import DataTable from './DataTable';
import { InfraestructuraMainModel } from '../../Models/InfraestructuraEntity'
import { SizeMainButtonSecondary, SizeButtonPrimary } from '../../Styles/Type'
import { ButtonMainSecondaryLeft, ButtonMainSecondaryRight, InputSearchMain, ButtonAddMain } from '../../Styles/Button'
import { IconLoad, IconTabla, IconCard, IconReport, IconFiltro, IconAdd } from '../../Styles/Icons'
import { Link } from "react-router-dom";
function Main() {
    const { Title } = Typography;
    const sInfraestructura = new InfraestructuraService();
    const [disabled, setDisabled] = useState(false);
    const [Items, SetItems] = useState<InfraestructuraMainModel[]>([])
    const [Busqueda, setBusqueda] = useState<string>('');

    const toggle = () => {
        setDisabled(!disabled);
      };
    useEffect(() => {

        getItems();


    }, []);


    const getItems = async () => {

        const itemsg = await sInfraestructura.getItems();

        SetItems(itemsg);

    };const onChange = (e: React.ChangeEvent<HTMLInputElement>) => {
        setBusqueda(e.target.value.toUpperCase());
      };



    return (<>
        <Spin spinning={false} tip="Cargando" size="large">

            <Row>
                <Col xs={18} sm={18} md={12} lg={12} xl={12}>
                    <Title level={2}> Infraestructura</Title>
                </Col>



                <Col xs={6} sm={6} md={12} lg={12} xl={12}>
                    <Link to={`/InfraestructuraSave/0`}>
                        <Button
                            style={ButtonAddMain}
                            size={SizeButtonPrimary}
                            icon={IconAdd}
                        />


                    </Link>
                </Col>

                <Col xs={24} sm={24} md={12} lg={12} xl={12}>
          <Button
            onClick={getItems}
            style={ButtonMainSecondaryLeft}
            size={SizeMainButtonSecondary}
            icon={IconLoad}
          />
          <Button
            onClick={toggle}
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
  placeholder='Buscar Categoria'
  type="text"
  name="Nombre"
  onChange={onChange}
  value={Busqueda === null ? "" : Busqueda}
  style={InputSearchMain}
  size={SizeMainButtonSecondary}
/>
</Col>



                <Card>
                    <DataTable DataList={Items} EsTabla={false} />
                </Card>



            </Row>



        </Spin>



    </>)

    }



export default Main;
