import React, { useEffect, useState } from 'react';
import { SaveFilled, ExclamationCircleOutlined } from '@ant-design/icons';
import { message, Select, Button, Col, Row, Typography, Modal, Spin, Input, DatePicker, Card, Tabs, Segmented, Avatar, AutoComplete } from 'antd';
import DataTable from './DataTable';
import type { InputStatus } from 'antd/lib/_util/statusUtils'
import { useParams } from 'react-router-dom';
import type { DatePickerProps } from 'antd';
import moment from 'moment';
import 'moment/locale/es';
import dayjs from 'dayjs';
import MDFiltro from './FiltroInfraestructura/ModalItem';
import MDCliente from './Cliente/ModalItem';

import ModalItem from '../Alquiler/ModalItem';

//SERVICES
import GeneralService from '../../Service/GeneralService';
import { TarifaBuscarItem, TarifaSaveModel } from '../../Models/TarifaEntity';
import TarifaService from '../../Service/TarifaService';

//ENTITY
import { AlquilerEntity } from '../../Models/AlquilerEntity';
import { EntidadEntity } from '../../Models/EntidadEntity';
import { UnidadMedidaModel } from '../../Models/UnidadMedidaEntity';
import { MonedaModel } from '../../Models/MonedaModel';

import { OrdenPedidoDetalleEntity } from '../../Models/OrdenPedidoDetalleEntity';

const Save = () => {
  const { Id } = useParams();
  const idNumero = Number(Id?.toString());
  const sGeneralService = new GeneralService();
  const sTarifa = new TarifaService();
  const initialAlquiler = new AlquilerEntity();
  const [Ent, setEnt] = useState<AlquilerEntity>(initialAlquiler);
  const [FechaInicioItem, setFechaInicioItem] = useState<string>(moment(Ent.FechaInicio).format('DD/MM/YYYY hh:mm'));
  const dateFormat = 'YYYY/MM/DD';
  const [FechaTerminoItem, setFechaTerminoItem] = useState<string>(moment(Ent.FechaTermino).format('DD/MM/YYYY hh:mm'));
  const dateFormatFin = 'YYYY/MM/DD';

  const { Title } = Typography;
  const [CargarPage, setCargarPage] = React.useState(true);
  const [ValCodigo, setValCodigo] = useState<InputStatus>('');
  const [ValUnidadMedida, setValUnidadMedida] = useState<InputStatus>('');
  const [optionsEntidad, setOptionsEntidad] = useState<EntidadEntity[]>([]);
  const [OptionTarifaBuscarItem, setOptionsTarifaBuscarItem] = useState<TarifaBuscarItem[]>([]);

  const [optionsUnidadMedida, setOptionsUnidadMedida] = useState<UnidadMedidaModel[]>([]);
  const [selectedUnidadMedida, setSelectedUnidadMedida] = useState<number | undefined>(undefined);

  const [ValMoneda, setValMoneda] = useState<InputStatus>('');
  const [OptionMoneda, setOptionsMoneda] = useState<MonedaModel[]>([]);


  const handleSearchEntidad = async (value: string) => {
    try {
      const response = await sGeneralService.GetEntidadBuscarItem(value);
      setOptionsEntidad(response);
      console.log(response)
    } catch (error) {
      console.error('Error al buscar Ubigeo:', error);
    }
  };

  const handleSearchTarifa = async (value: string) => {
    try {
      const response = await sTarifa.GetTarifaBuscarItem(value);
      setOptionsTarifaBuscarItem(response);
      console.log(response)
    } catch (error) {
      console.error('Error al buscar Tarifa:', error);
    }
  };




  const onChangeDateInicio: DatePickerProps['onChange'] = (date, dateString) => {
    date;
    setFechaInicioItem(dateString);
  };

  const onChangeDateTermino: DatePickerProps['onChange'] = (date, dateString) => {
    date;
    setFechaTerminoItem(dateString);
  };


  const tabList = [
    {
      key: 'Detalle',
      tab: 'Detalle',
    }
  ];

  const contentList: Record<string, React.ReactNode> = {
    Detalle: <p></p>,

  };


  const [activeTabKey1, setActiveTabKey1] = useState<string>('Detalle');
  const onTab1Change = (key: string) => {
    setActiveTabKey1(key);
  };


  const onChangeText = (e: React.ChangeEvent<HTMLInputElement>) => {

    setValCodigo('');
    // setValNombre('');
    // setValDescripcion('');
    setEnt({
      ...Ent,
      [e.target.name]: e.target.value.toUpperCase()
    });

  };

  const [selectedCliente, setSelectedCliente] = useState<number | undefined>(undefined);
  const [selectedTarifa, setSelectedTarifa] = useState<number | undefined>(undefined);
  const [selectedTablaAlquiler, setSelectedTablaAlquiler] = useState<number | undefined>(undefined);
  const [ValCliente, setValCliente] = useState<InputStatus>('');
  const [ValTarifa, setTarifa] = useState<InputStatus>('');

  const onChangeCliente = async (value: number) => {
    ValCliente;
    setValCliente('');
    Ent.ClienteId = value;
    setSelectedCliente(value)
    console.log(value)
  };

  const onChangeTarifaId = async (value: number) => {
    setTarifa('');
    Ent.TarifaId = value;
    setSelectedTarifa(value)
  };


  const onChangeUnidadMedida = async (value: number) => {
    ValCodigo;
    setValUnidadMedida('');
    Ent.UnidadMedidaId = value;
    setSelectedUnidadMedida(value)
    console.log(value)
  };

  const addItemToState = (item: AlquilerEntity) => {

    const itemIndex = items.findIndex((data) => data.Codigo === item.Codigo);


  };

  const [modal, contextHolder] = Modal.useModal();
  const [messageAdd, contextHolderAdd] = message.useMessage();

  const AddAlquiler = async () => {
    // console.log(Ent);
    // const savedItem = await sAlquiler.Registrar(Ent);
    // if (savedItem) {

    //   messageAdd.open({
    //     type: 'success',
    //     content: 'Se guardó correctamente.',
    //   });
    // } else {
    // }
  }
  const updateAlquiler = async () => {
    // console.log(Ent);
    // const savedItem = await sAlquiler.Actualizar(Ent);
    // if (savedItem) {

    //   messageAdd.open({
    //     type: 'success',
    //     content: 'Se Actualizo correctamente.',
    //   });
    // } else {
    // }
  }


  const Guardar_Total = async (e: React.MouseEvent<HTMLButtonElement>) => {
    e.preventDefault();
    selectedCliente;
    selectedTablaAlquiler;
    selectedTarifa;

    // if (Ent.Codigo === '') {
    //   setValCodigo('error');
    //   messageAdd.open({ type: 'error', content: 'Ingrese Codigo.', });
    //   return;
    // }
    // if (Ent.CategoriaId === 0) {
    //   setValCategoria('error');
    //   messageAdd.open({ type: 'error', content: 'Seleccione una categoria.', });
    //   return;
    // }
    // if (Ent.TipoPersonaNaturalId === 0) {
    //   setValTipoPersonaNatural('error');
    //   messageAdd.open({ type: 'error', content: 'Seleccione una tipo de personanatural.', });
    //   return;
    // }

    // if (Ent.MarcaId === 0) {
    //   setValMarca('error');
    //   messageAdd.open({ type: 'error', content: 'Seleccione una marca.', });
    //   return;
    // }


    // if (Ent.ModeloId === 0) {
    //   setValModelo('error');
    //   messageAdd.open({ type: 'error', content: 'Seleccione un Modelo.', });
    //   return;
    // }

    // if (Ent.Nombre === '') {
    //   setValNombre('error');
    //   messageAdd.open({ type: 'error', content: 'Ingrese un Nombre.', });
    //   return;
    // }

    // if (Ent.Descripcion === '') {
    //   setValDescripcion('error');
    //   messageAdd.open({ type: 'error', content: 'Ingrese un Nombre.', });
    //   return;
    // }

    // if (Ent.UnidadMedidaId === 0) {
    //   setValUnidadMedida('error');
    //   messageAdd.open({ type: 'error', content: 'Seleccione una unidad de medida.', });
    //   return;
    // }


    modal.confirm({
      title: 'Mensaje del Sistema',
      icon: <ExclamationCircleOutlined />,
      content: '¿Desea guardar el registro?',
      okText: 'Si',
      okType: 'danger',
      cancelText: 'No',
      onOk() {


        if (Ent.AlquilerId == 0) {

          AddAlquiler();

        } else {
          updateAlquiler();

        }

      },
      onCancel() {
        console.log('Cancel');
      },
    });

  };


  async function getCargarDatos() {

    setSelectedTablaAlquiler
    setBusqueda
    setItems
    setDisabled


    setCargarPage(true);
    // const Resp_UM = await sEntLista.getItems('C0012');
    // setOptionsEstadoCivil(Resp_UM);

    // const Resp_Sexo = await sEntLista.getItems('C0008');
    // setOptionsSexo(Resp_Sexo);

    // const Resp_EC = await sEntLista.getItems('C0009');
    // setOptionsEstadoCivil(Resp_EC);

    const sltUnidadMedida = await sGeneralService.ObtenerUnidadMedidaItems();
    setOptionsUnidadMedida(sltUnidadMedida);
    const sltMoneda = await sGeneralService.ObtenerMonedaItems();
    setOptionsMoneda(sltMoneda);


    console.log(idNumero)
    // if (idNumero > 0) {

    //   const Resp_PersonaNatural = await sAlquiler.ObtenerItem(idNumero);
    //   setEnt(Resp_PersonaNatural[0]);
    //   console.log(Resp_PersonaNatural[0]);


    //   if (Resp_PersonaNatural[0].UbigeoId != null) {
    //     const Resp_Ubigeo = await sGeneralService.GetUbigeoItemApi(Resp_PersonaNatural[0].UbigeoId);

    //     setOptionsUbigeo(Resp_Ubigeo);
    //   }




    // }

    setCargarPage(false);
  };
  useEffect(() => {

    getCargarDatos();
  }, []);


  const [items, setItems] = useState<AlquilerEntity[]>([]);
  const [disabled, setDisabled] = useState(false);

  const [Busqueda, setBusqueda] = useState<string>('');

  const filterItems = items.filter(fdata =>
    fdata.Codigo.toLowerCase().includes(Busqueda.toLowerCase())
  );

  const operations = <ModalItem buttonLabel="" addItemToState={addItemToState} item={new OrdenPedidoDetalleEntity()} keyItem={''} />
  return (

    <Spin spinning={CargarPage} tip="Cargando" size="large">

      {contextHolder}
      {contextHolderAdd}
      <Row>
        <Col xs={24} sm={24} md={12} lg={12} xl={12}>

          <Title level={3}> {Ent.AlquilerId > 0 ? 'Alquiler' : 'Agregar Alquiler'}</Title>

        </Col>
        <Col xs={24} sm={24} md={12} lg={12} xl={12}>
          <Col style={{ float: "right" }} span={8}>
            <Row>
              <Col span={24}>
                <label>Codigo</label>
              </Col>
              <Col span={24}>
                <Input
                  type="text"
                  name="Codigo"
                  style={{ marginTop: '5px', marginBottom: '10px' }}
                  onChange={onChangeText}
                  value={Ent.Codigo === null ? "" : Ent.Codigo}
                />
              </Col>
            </Row>

          </Col>
          {/* 
          <Button
            style={ButtonAddMain}
            onClick={Guardar_Total}
            size={"large"}
            icon={<SaveFilled />}
          /> */}

        </Col>
      </Row>


      <Row>

        <Col xs={24}>
          <Row>

            <Col span={12}>
              <Row>
                <Col span={24}>
                  <label>Cliente</label>
                </Col>
                <Col span={24}>
                  <Row>
                    <Select className="custom-select"
                      status={ValCliente}
                      showSearch
                      style={{ width: '94%', marginTop: '5px', marginBottom: '10px' }}
                      defaultActiveFirstOption={false}
                      filterOption={false}
                      onSearch={handleSearchEntidad}
                      value={Ent.ClienteId === 0 ? null : Ent.ClienteId}
                      key={Ent.ClienteId}
                      onChange={onChangeCliente}
                    >
                      {optionsEntidad.map((row) => (
                        <Select.Option className="custom-option" key={row.EntidadId} value={row.EntidadId}>
                          {row.NombreCompleto}
                        </Select.Option>
                      ))}
                    </Select>


                    <MDCliente buttonLabel="dsdsd"
                      addItemToState={[]}
                      item={[]}
                      CodigoTabla={'M002'}
                      title={"Sucursal"} />
                  </Row>
                </Col>
              </Row>

            </Col>
            <Col span={3}>
              <Row>
                <Col span={24}>
                  <label>Unidad de Medida</label>
                </Col>
                <Col span={24}>
                  <Select
                    status={ValUnidadMedida}
                    allowClear
                    style={{ width: '100%', marginTop: '5px', marginBottom: '10px' }}
                    defaultActiveFirstOption={false}
                    filterOption={false}
                    value={Ent.UnidadMedidaId === 0 ? null : Ent.UnidadMedidaId}
                    key={Ent.UnidadMedidaId}
                    onChange={onChangeUnidadMedida}
                  >

                    {optionsUnidadMedida.map((row) => (
                      <Select.Option key={row.UnidadMedidaId} value={row.UnidadMedidaId}>
                        {row.Nombre}
                      </Select.Option>
                    ))}
                  </Select>
                </Col>
              </Row>
            </Col>

            <Col span={3}>
              <Row>
                <Col span={24}>
                  <label>Fecha Inicio</label>
                </Col>
                <Col span={24}>
                  <DatePicker
                    onChange={onChangeDateInicio}
                    value={dayjs(FechaInicioItem, dateFormat)}
                    // defaultValue={dayjs(FechaEmisionItem, dateFormat)}
                    style={{ marginTop: '5px', marginBottom: '10px', width: '100%' }}
                  />

                </Col>
              </Row>
            </Col>


            <Col span={3}>
              <Row>
                <Col span={24}>
                  <label>Cantidad</label>
                </Col>
                <Col span={24}>
                  <Input
                    type="number"
                    name="Cantidad"
                    style={{ marginTop: '5px', marginBottom: '10px' }}
                    onChange={onChangeText}
                  // value={Ent.c === null ? "" : Ent.PrecioUnitario}
                  />
                </Col>
              </Row>

            </Col>


            <Col span={3}>
              <Row>
                <Col span={24}>
                  <label>Fecha Termino</label>
                </Col>
                <Col span={24}>
                  <DatePicker
                    onChange={onChangeDateTermino}
                    value={dayjs(FechaTerminoItem, dateFormatFin)}
                    // defaultValue={dayjs(FechaEmisionItem, dateFormat)}
                    style={{ marginTop: '5px', marginBottom: '10px', width: '100%' }}
                  />

                </Col>
              </Row>
            </Col>

          </Row>

        </Col>


        <Col xs={24}>
          <Row>
            <Col span={12}>
              <Row>
                <Col span={24}>
                  <label>Tarifa</label>
                </Col>
                <Col span={24}>
                  <Row>

                    <Select className="custom-select"
                      status={ValTarifa}
                      showSearch
                      style={{ width: '94%', marginTop: '5px', marginBottom: '10px' }}
                      defaultActiveFirstOption={false}
                      filterOption={false}
                      onSearch={handleSearchTarifa}
                      value={Ent.TarifaId === 0 ? null : Ent.TarifaId}
                      key={Ent.TarifaId}
                      onChange={onChangeTarifaId}
                    >
                      {OptionTarifaBuscarItem.map((row) => (
                        <Select.Option className="custom-option" key={row.TarifaId} value={row.TarifaId}>
                          {row.NomComercial}
                        </Select.Option>
                      ))}
                    </Select>

                    <MDFiltro buttonLabel="dsdsd"
                      addItemToState={[]}
                      item={[]}
                      CodigoTabla={'M002'}
                      title={"Sucursal"} />
                  </Row>
                </Col>
              </Row>
            </Col>

            <Col span={6}>
              <Row>
                <Col span={24}>
                  <label>Moneda</label>
                </Col>
                <Col span={24}>
                  <Select
                    status={ValMoneda}
                    allowClear
                    style={{ width: '100%', marginTop: '5px', marginBottom: '10px' }}
                    defaultActiveFirstOption={false}
                    filterOption={false}
                  // value={Ent.MonedaId === 0 ? null : Ent.MonedaId}
                  // key={Ent.MonedaId}
                  // onChange={onChangeMoneda}
                  >
                    {OptionMoneda.map((row) => (
                      <Select.Option key={row.MonedaId} value={row.MonedaId}>
                        {row.Nombre}
                      </Select.Option>
                    ))}
                  </Select>
                </Col>
              </Row>
            </Col>

            <Col span={3}>
              <Row>
                <Col span={24}>
                  <label>Precio</label>
                </Col>
                <Col span={24}>
                  <Input
                    type="number"
                    name="Precio"
                    style={{ marginTop: '5px', marginBottom: '10px' }}
                    onChange={onChangeText}
                  // value={Ent.c === null ? "" : Ent.PrecioUnitario}
                  />
                </Col>
              </Row>

            </Col>


            <Col span={3}>
              <Row>
                <Col span={24}>
                  <label>Precio Neto</label>
                </Col>
                <Col span={24}>
                  <Input
                    type="number"
                    name="PrecioNeto"
                    style={{ marginTop: '5px', marginBottom: '10px' }}
                    onChange={onChangeText}
                  // value={Ent.c === null ? "" : Ent.PrecioUnitario}
                  />
                </Col>
              </Row>

            </Col>

          </Row>
        </Col>



        <Col span={24}>
          <Row>
            {/* <Col xs={24} >
              <Col span={8} style={{ float: "right" }}>
                <Button size={"large"} >Agregar</Button>

              </Col>
            </Col> */}

            <Col xs={24} >

              {/* <DataTable DataList={filterItems} EsTabla={disabled} /> */}

              <Card
                style={{ width: '100%' }}
                tabList={tabList}
                activeTabKey={activeTabKey1}
                onTabChange={onTab1Change}
                tabBarExtraContent={operations}
              >

                <DataTable DataList={filterItems} EsTabla={disabled} />

                {contentList[activeTabKey1]}
              </Card>
              <br />
              <br />

            </Col>

          </Row>

        </Col>

      </Row>



      <Row>
        <Col span={2}>
          <Row>
            <label>Usuario :</label>
          </Row>
        </Col>
        <Col span={3}>
          <Row>
            <label > </label>
          </Row>
        </Col>
      </Row>


      <Row>
        <Col span={2}>
          <Row>
            <label>Fecha Creación :</label>
          </Row>
        </Col>
        <Col span={3}>
          <Row>
            <label > </label>
          </Row>
        </Col>
      </Row>


      <Row>
        <Col span={2}>
          <Row>
            <label>Fecha Modifica :</label>
          </Row>
        </Col>
        <Col span={3}>
          <Row>
            <label> </label>

          </Row>
        </Col>
      </Row>


      <Col span={24} style={{ float: "right" }} >
        <Row>
          <Col span={6}>
            <Row>
              <label>Total S/ </label>
            </Row>
          </Col>
          <Col span={6}>
            <label>---------</label>
          </Col>
          <Col span={6}>
            <Row>
              <label>Total S/ </label>
            </Row>
          </Col>
          <Col span={6}>
            <label>---------</label>

          </Col>

        </Row>
      </Col>

      {/* <Col span={8} style={{ float: "right" }}>

        <Button
          style={ButtonAddMain}
          onClick={Guardar_Total}
          size={"large"}
          icon={<SaveFilled />}
        /> </Col> */}

    </Spin>
  );
};



export default Save;