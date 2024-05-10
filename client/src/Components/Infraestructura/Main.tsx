import React, { useEffect, useState } from 'react';
import DataTable from './DataTable';
import { InfraestructuraMainModel } from '../../Models/InfraestructuraEntity';
import InfraestructuraService from '../../Service/InfraestructuraService';
import { Col, Row, Typography, Card, Button, Spin, Input, Select } from 'antd';
import { ButtonMainSecondaryLeft, ButtonMainSecondaryRight, InputSearchMain, ButtonAddMain } from '../../Styles/Button'
import { SizeMainButtonSecondary, SizeButtonPrimary } from '../../Styles/Type'
import { IconLoad, IconTabla, IconCard, IconReport, IconFiltro, IconAdd } from '../../Styles/Icons'
import { Link } from "react-router-dom";
import InfraListaService from '../../Service/InfraListaService';
import { InfraListaModel } from '../../Models/InfraListaEntity';
import type { InputStatus } from 'antd/lib/_util/statusUtils'

function Main() {
  useEffect(() => {
    getItems();
  }, []);
  const sInfraestructura = new InfraestructuraService();
  const sInfraLista = new InfraListaService();
  const [optionsPiso, setOptionsPiso] = useState<InfraListaModel[]>([]);
  const [selectedPiso, setSelectedPiso] = useState<number | undefined>(undefined);
  const [optionsClasificacion, setOptionsClasificacion] = useState<InfraListaModel[]>([]);
  const [ValPiso, setValPiso] = useState<InputStatus>('');
  const [fPiso, setfPiso] = useState<number>(0);
  const [fClasificacion, setfClasificacion] = useState<number>(0);
  const [items, setItems] = useState<InfraestructuraMainModel[]>([]);
  const [CargarPage, setCargarPage] = React.useState(true);
  const [disabled, setDisabled] = useState(false);
  const [Busqueda, setBusqueda] = useState<string>('');
  const [ValClasificacion, setValClasificacion] = useState<InputStatus>('');
  const [selectedClasificacion, setSelectedClasificacion] = useState<number | undefined>(undefined);
  const toggle = () => {
    setDisabled(!disabled);
  };

  const updateState = (item: InfraestructuraMainModel) => {
    const itemIndex = items.findIndex((data) => data.InfraestructuraId === item.InfraestructuraId);
    const newArray = [...items.slice(0, itemIndex), item, ...items.slice(itemIndex + 1)];
    setItems(newArray);
  };

  const deleteItemFromState = (id: number) => {
    const updatedItems = items.filter((item) => item.InfraestructuraId !== id);
    setItems(updatedItems);
  };

  const getItems = async () => {
    const itemsg = await sInfraestructura.GetInfraestructuraMain();
    setItems(itemsg);
    console.log(itemsg);
    setCargarPage(false);

  };
  const onChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    setBusqueda(e.target.value.toUpperCase());
  };



  const filterItemsPiso = fPiso == 0 ? items : items.filter(fdata => fdata.PisoId == fPiso);
  const filterItemsclasificacion = fClasificacion == 0 ? filterItemsPiso : filterItemsPiso.filter(fdata => fdata.ClasificacionId == fClasificacion);
  const filterItems = filterItemsclasificacion.filter(fdata => fdata.CodigoInterno.toLowerCase().includes(Busqueda.toLowerCase()));

  const onSearchPiso = async (value: string) => {
    try {
      const responsePiso = await sInfraLista.BuscarItemCodigo("0009", value);
      setOptionsPiso(responsePiso);
    } catch (error) {
      console.error('Error al buscar categorías:', error);
    }
  };
  const onChangePiso = async (value: number) => {
    setValPiso('');
    setfPiso(value);
    setSelectedPiso(value)
  };


  const onSearchClasificacion = async (value: string) => {
    try {
      const responseClasificacion = await sInfraLista.BuscarItemCodigo("0013", value);
      setOptionsClasificacion(responseClasificacion);
    } catch (error) {
      console.error('Error al buscar categorías:', error);
    }
  };

  
  const onChangeClasificacion = async (value: number) => {
    setValClasificacion('');
    setfClasificacion(value);
    setSelectedClasificacion(value)
  };

  const { Title } = Typography;
  return (
    <Spin spinning={CargarPage} tip="Cargando" size="large">
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


        <Col xs={12} sm={12} md={6} lg={6} xl={6}>

          <Input
            placeholder='Buscar Codigo Interno'
            type="text"
            name="Nombre"
            onChange={onChange}
            value={Busqueda === null ? "" : Busqueda}
            style={InputSearchMain}
            size={SizeMainButtonSecondary}
          />
        </Col>
        <Col xs={12} sm={12} md={6} lg={6} xl={6}>
          <Select
            showSearch
            status={ValPiso}

            defaultActiveFirstOption={false}
            filterOption={false}
            onSearch={onSearchPiso}
            value={fPiso === 0 ? null : fPiso}
            key={fPiso}
            placeholder='Filtrar por piso'
            onChange={onChangePiso}
          >
            {optionsPiso.map((PisoItem) => (
              <Select.Option key={PisoItem.ListaId} value={PisoItem.ListaId}>
                {PisoItem.Nombre}
              </Select.Option>
            ))}
          </Select>
          <Select
                showSearch
                status={ValClasificacion}
                style={{ width: '85%', marginTop: '5px', marginBottom: '10px' }}
                defaultActiveFirstOption={false}
                filterOption={false}
                onSearch={onSearchClasificacion}
                value={fClasificacion=== 0 ? null : fClasificacion}
                key="KCLaso"
                placeholder='Filtrar por clasificacion'
                onChange={onChangeClasificacion}
              >
                {optionsClasificacion.map((Clasificacion) => (
                  <Select.Option key={Clasificacion.ListaId} value={Clasificacion.ListaId}>
                    {Clasificacion.Nombre}
                  </Select.Option>
                ))}
              </Select>
        </Col>

      </Row>
      <Card>
        <DataTable DataList={filterItems} EsTabla={disabled} />
      </Card>

    </Spin>

  );
}

export default Main;




