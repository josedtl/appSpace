import React, { useEffect, useState } from 'react';
import DataTable from './DataTable';
import { MercaderiaMainModel } from '../../Models/MercaderiaEntity';
import MercaderiaService from '../../Service/MercaderiaService';
import { Col, Row, Typography, Card, Button, Spin, Input } from 'antd';
import { ButtonMainSecondaryLeft, ButtonMainSecondaryRight, InputSearchMain , ButtonAddMain} from '../../Styles/Button'
import { SizeMainButtonSecondary ,SizeButtonPrimary} from '../../Styles/Type'
import { IconLoad, IconTabla, IconCard, IconReport, IconFiltro, IconAdd } from '../../Styles/Icons'
import { Link } from "react-router-dom";
function Main() {
  useEffect(() => {
    getItems();
  }, []);
  const sMercaderia = new MercaderiaService();

  const [items, setItems] = useState<MercaderiaMainModel[]>([]);
  const [CargarPage, setCargarPage] = React.useState(true);
  const [disabled, setDisabled] = useState(false);
  const [Busqueda, setBusqueda] = useState<string>('');
  const toggle = () => {
    setDisabled(!disabled);
  };

  const updateState = (item: MercaderiaMainModel) => {
    const itemIndex = items.findIndex((data) => data.MercaderiaId === item.MercaderiaId);
    const newArray = [...items.slice(0, itemIndex), item, ...items.slice(itemIndex + 1)];
    setItems(newArray);
  };

  const deleteItemFromState = (id: number) => {
    const updatedItems = items.filter((item) => item.MercaderiaId !== id);
    setItems(updatedItems);
  };

  const getItems = async () => {
    const itemsg = await sMercaderia.getItems();
    setItems(itemsg);
    console.log(itemsg);
    setCargarPage(false);

  };
  const onChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    setBusqueda(e.target.value.toUpperCase());
  };
  const filterItems = items.filter(fdata =>
    fdata.Descripcion.toLowerCase().includes(Busqueda.toLowerCase())
  );

  const { Title } = Typography;
  return (
    <Spin spinning={CargarPage} tip="Cargando" size="large">
      <Row>

      <Col xs={18} sm={18} md={12} lg={12} xl={12}>
          <Title level={2}> Producto</Title>
        </Col>

        <Col xs={6} sm={6} md={12} lg={12} xl={12}>
          <Link to={`/ProductoSave/0`}>
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

      </Row>
      <Card>
        <DataTable DataList={filterItems}  EsTabla={disabled} />
      </Card>

    </Spin>

  );
}

export default Main;




