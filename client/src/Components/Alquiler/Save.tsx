import React, { useEffect, useState } from 'react';
import { SaveFilled, ExclamationCircleOutlined } from '@ant-design/icons';
import { message, Select, Button, Col, Row, Typography, Modal, Spin, Input, DatePicker, Card, Segmented, Avatar, AutoComplete } from 'antd';
import { PersonaNaturalSaveModel } from '../../Models/PersonaNaturalEntity';
import PersonaNaturalService from '../../Service/PersonaNaturalService';
import DataTable from './DataTable';
import type { InputStatus } from 'antd/lib/_util/statusUtils'
import { useParams } from 'react-router-dom';
import { ButtonAddMain } from '../../Styles/Button'
import type { DatePickerProps } from 'antd';
import moment from 'moment';
import 'moment/locale/es';
import dayjs from 'dayjs';
import MDFiltro from './FiltroInfraestructura/ModalItem';
import { ProcessActionEnum } from '../../Lib/ResourceModel/Enum'
import EntListaService from '../../Service/EntListaService';
import { EntListaModel } from '../../Models/EntListaEntity';
import GeneralService from '../../Service/GeneralService';
import { UbigeoEntity } from '../../Models/UbigeoEntity';
import { AlquilerEntity } from '../../Models/AlquilerEntity';
import { EntidadEntity } from '../../Models/EntidadEntity';
import AlquilerService from '../../Service/AlquilerService';
import { TarifaBuscarItem } from '../../Models/TarifaEntity';
import TarifaService from '../../Service/TarifaService';

const Save = () => {
  const { Id } = useParams();
  const idNumero = Number(Id?.toString());
  const sEntLista = new EntListaService();
  const sGeneralService = new GeneralService();
  const sAlquiler = new AlquilerService();
  const sTarifa = new TarifaService();
  const initialAlquiler = new AlquilerEntity();
  const [Ent, setEnt] = useState<AlquilerEntity>(initialAlquiler);

  const { Title } = Typography;
  const [CargarPage, setCargarPage] = React.useState(true);
  const [ValCodigo, setValCodigo] = useState<InputStatus>('');
  const [ValEntidad, setValEntidad] = useState<InputStatus>('');
  const [optionsTipoDocumentoIdentidad, setOptionsTipoDocumentoIdentidad] = useState<EntListaModel[]>([]);
  const [optionsCliente, setOptionsCliente] = useState<EntListaModel[]>([]);
  const [optionsTarifa, setOptionsTarifa] = useState<EntListaModel[]>([]);
  const [optionsTablaAlquiler, setOptionsTablaAlquiler] = useState<UbigeoEntity[]>([]);
  const [optionsEntidad, setOptionsEntidad] = useState<EntidadEntity[]>([]);
  const [OptionTarifaBuscarItem, setOptionsTarifaBuscarItem] = useState<TarifaBuscarItem[]>([]);

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


  const handleSearchUbigeo = async (value: string) => {
    try {
      const response = await sGeneralService.GetUbigeoItemLikeApi(value);
      setOptionsTablaAlquiler(response);
      console.log(response)
    } catch (error) {
      console.error('Error al buscar Ubigeo:', error);
    }
  };





  const tabList = [
    {
      key: 'Servicio',
      tab: 'Servicio',
    },
    {
      key: 'Venta',
      tab: 'Venta',
    },
  ];

  const contentList: Record<string, React.ReactNode> = {
    Servicio: <p>content1</p>,
    Venta: <p>content2</p>,
  };
  const tabListNoTitle = [
    {
      key: 'article',
      label: 'article',
    },
    {
      key: 'app',
      label: 'app',
    },
    {
      key: 'project',
      label: 'project',
    },
  ];


  const contentListNoTitle: Record<string, React.ReactNode> = {
    article: <p>article content</p>,
    app: <p>app content</p>,
    project: <p>project content</p>,
  };

  const [activeTabKey1, setActiveTabKey1] = useState<string>('Servicio');
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
  const [ValTablaAlquiler, setValTablaAlquiler] = useState<InputStatus>('');

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


  const onChangeTablaAlquiler = async (value: number) => {
    setValTablaAlquiler('');
    Ent.TipoTablaAlquilerId = value;
    setSelectedTablaAlquiler(value)
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


    setCargarPage(true);
    // const Resp_UM = await sEntLista.getItems('C0012');
    // setOptionsEstadoCivil(Resp_UM);

    // const Resp_Sexo = await sEntLista.getItems('C0008');
    // setOptionsSexo(Resp_Sexo);

    // const Resp_EC = await sEntLista.getItems('C0009');
    // setOptionsEstadoCivil(Resp_EC);

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

  const getItems = async () => {

  };

  const [items, setItems] = useState<AlquilerEntity[]>([]);
  const [disabled, setDisabled] = useState(false);

  const [Busqueda, setBusqueda] = useState<string>('');
  const toggle = () => {
    setDisabled(!disabled);
  };
  const filterItems = items.filter(fdata =>
    fdata.Codigo.toLowerCase().includes(Busqueda.toLowerCase())
  );


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

          <Col span={6}>
              <Row>
                <Col span={24}>
                  <label>Tarifa</label>
                </Col>
                <Col span={24}>
                  <Select className="custom-select"
                    status={ValTarifa}
                    showSearch
                    style={{ width: '100%', marginTop: '5px', marginBottom: '10px' }}
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
                </Col>
              </Row>

            </Col>

            <Col span={12}>
              <Row>
                <Col span={24}>
                  <label>Cliente</label>
                </Col>
                <Col span={24}>
                  <Select className="custom-select"
                    status={ValCliente}
                    showSearch
                    style={{ width: '100%', marginTop: '5px', marginBottom: '10px' }}
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

                </Col>
              </Row>

            </Col>

            
            <Col span={4}>
              <Row>
                <Col span={24}>
                  <label>Precio Unitario</label>
                </Col>
                <Col span={24}>
                  <Input
                    type="number"
                    name="PrecioUnitario"
                    style={{ marginTop: '5px', marginBottom: '10px' }}
                    onChange={onChangeText}
                    value={Ent.PrecioUnitario === null ? "" : Ent.PrecioUnitario}
                  />
                </Col>
              </Row>

            </Col>

          </Row>

        </Col>

        <Col xs={24} >
          <Col span={8} style={{ float: "left" }}>

            <Button size={"large"}>Detalle</Button>

          </Col>
          <Col span={8} style={{ float: "right" }}>
            <Button size={"large"} >Agregar</Button>

          </Col>
        </Col>

        <Col xs={24} >
          <Card
            style={{ width: '100%' }}
            tabList={tabList}
            activeTabKey={activeTabKey1}
            onTabChange={onTab1Change}
          >

            <DataTable DataList={filterItems} EsTabla={disabled} />

            {contentList[activeTabKey1]}
          </Card>
          <br />
          <br />

        </Col>
      </Row>



      <Col span={2}>

        <Row>
          <Col span={24}>
            <label>Fecha Registro</label>
          </Col>
          <Col span={24}>
            <Input
              type="string"
              name="FechaRegistro"
              style={{ marginTop: '5px', marginBottom: '10px' }}
              readOnly={true}
              value={moment().format('DD/MM/YYYY hh:mm')}
            />
          </Col>
        </Row>


      </Col>

      <Col span={8} style={{ float: "right" }}>

        <Button
          style={ButtonAddMain}
          onClick={Guardar_Total}
          size={"large"}
          icon={<SaveFilled />}
        /> </Col>

    </Spin>
  );
};



export default Save;