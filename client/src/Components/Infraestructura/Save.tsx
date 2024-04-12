import React, { useEffect, useState } from 'react';
import { SaveFilled, ExclamationCircleOutlined } from '@ant-design/icons';
import { Tabs, Table, message, Select, Button, Col, Row, Typography, Modal, Spin, Input } from 'antd';
import MerListaService from '../../Service/MerListaService';
import MDSucursal from './Enlace/InfraLista/ModalItem';
import MDTipoInfraestructura from  './Enlace/InfraLista/ModalItem';
import MDClasificacion from  './Enlace/InfraLista/ModalItem';
import MDInfraestructuraDimension from  './Enlace/InfraLista/ModalItem';

import type { InputStatus } from 'antd/lib/_util/statusUtils'
import { useParams } from 'react-router-dom';
import { ButtonAddMain } from '../../Styles/Button'
import InfraestructuraService from '../../Service/InfraestructuraService';
import { InfraestructuraSaveModel } from '../../Models/InfraestructuraEntity';
import GeneralService from '../../Service/GeneralService';
import { UnidadMedidaEntity } from '../../Models/UnidadMedidaEntity';
import { InfraListaEntity } from '../../Models/InfraListaEntity';
const Save = () => {
  const { Id } = useParams();
  const idNumero = Number(Id?.toString());
  const sMerLista = new MerListaService();
  const sInfraestructura = new InfraestructuraService();
  const sGeneralService = new GeneralService();
  const initialProducto = new InfraestructuraSaveModel();
  const [Ent, setEnt] = useState<InfraestructuraSaveModel>(initialProducto);
  const { Title } = Typography;
  const [CargarPage, setCargarPage] = React.useState(true);

  const addItemToStateSucursal = async (item: InfraListaEntity) => {
    const Resp_Sucursal = await sMerLista.getItem(item.ListaId);
    setOptionsSucursal(Resp_Sucursal);
    Ent.SucursalId = Resp_Sucursal[0].ListaId;

  };

  const addItemToStateClasificacion = async (item: InfraListaEntity) => {
    const Resp_Clasificacion = await sMerLista.getItem(item.ListaId);
    setOptionsClasificacion(Resp_Clasificacion);
    Ent.ClasificacionId = Resp_Clasificacion[0].ListaId;

  };
  const addItemToStateInfraestructuraDimension = async (item: InfraListaEntity) => {
    const Resp_InfraestructuraDimension = await sMerLista.getItem(item.ListaId);
    setOptionsInfraestructuraDimension(Resp_InfraestructuraDimension);
    Ent.InfraestructuraDimensionId = Resp_InfraestructuraDimension[0].ListaId;

  };
  const addItemToStateTipoInfraestructura = async (item: InfraListaEntity) => {
    const Resp_TipoInfraestructura = await sMerLista.getItem(item.ListaId);
    setOptionsTipoInfraestructura(Resp_TipoInfraestructura);
    Ent.TipoInfraestructuraId = Resp_TipoInfraestructura[0].ListaId;

  };


  const columns = [
    {
      title: 'Nº',
      dataIndex: 'Cont',
      key: 'Cont',
      width: '50px',
    },
    {
      title: 'UnidadMeida',
      dataIndex: 'UnidadMeida',
      key: 'UnidadMeida',

    },
    {
      title: 'Cantidad ',
      dataIndex: 'Cantidad',
      key: 'Cantidad',
      width: '80px',
    },
    {
      title: 'Moneda',
      dataIndex: 'Moneda',
      key: 'Moneda',
      width: '100px',
    }, {
      title: 'ValorVenta',
      dataIndex: 'ValorVenta',
      key: 'ValorVenta',
      width: '100px',
    }, {
      title: 'ValorCompra',
      dataIndex: 'ValorCompra',
      key: 'ValorCompra',
      width: '100px',
    }, {
      title: 'Fecha Vigencia',
      dataIndex: 'FechaVigencia',
      key: 'FechaVigencia',
      width: '100px',
    }, {
      title: 'Action',
      key: 'action',
      width: '100px'
    },

  ];

  const [TabsItems] = useState<any>([
    {
      label: (
        < >
          {/* <AndroidOutlined /> */}
          <Title style={{ fontSize: '18px' }}>
            Tarifa
          </Title>
        </>
      ),
      key: 1,
      children:
        <span>

          <Row>
            <Col xs={24}>
              <Table
                columns={columns}
                size="small"
                scroll={{ y: '100%' }}
              />
            </Col>
          </Row >
        </span>
    },

  ]);


  const [optionsSucursal, setOptionsSucursal] = useState<InfraListaEntity[]>([]);
  const [optionsTipoInfraestructura, setOptionsTipoInfraestructura] = useState<InfraListaEntity[]>([]);
  const [optionsClasificacion, setOptionsClasificacion] = useState<InfraListaEntity[]>([]);
  const [optionsInfraestructuraDimension, setOptionsInfraestructuraDimension] = useState<InfraListaEntity[]>([]);
  const [optionsPiso, setOptionsPiso] = useState<InfraListaEntity[]>([]);


  const [optionsUM, setOptionsUM] = useState<UnidadMedidaEntity[]>([]);

  const handleSearchSucursal = async (value: string) => {
    try {
      const responseSucursal = await sMerLista.getItemLike("M002", value);
      setOptionsSucursal(responseSucursal);
    } catch (error) {
      console.error('Error al buscar categorías:', error);
    }
  };

  const handleSearchTipoInfraestructura = async (value: string) => {
    try {
      const responseTipoInfraestructura = await sMerLista.getItemLike("M003", value);
      setOptionsTipoInfraestructura(responseTipoInfraestructura);
    } catch (error) {
      console.error('Error al buscar categorías:', error);
    }
  };



  const handleSearchClasificacion = async (value: string) => {
    try {
      const responseClasificacion = await sMerLista.getItemLike("M004", value);
      setOptionsClasificacion(responseClasificacion);
    } catch (error) {
      console.error('Error al buscar categorías:', error);
    }
  };

  const handleSearchInfraestructuraDimension = async (value: string) => {
    try {
      const responseInfraestructuraDimension = await sMerLista.getItemLike("M005", value);
      setOptionsInfraestructuraDimension(responseInfraestructuraDimension);
    } catch (error) {
      console.error('Error al buscar categorías:', error);
    }
  };



  const getCargarDatos = async () => {

    console.log(idNumero)
    if (idNumero > 0) {

      const Resp_Producto = await sInfraestructura.GetInfraestructuraItem(idNumero);
      console.log(Resp_Producto);
      const Resp_Sucursal = await sMerLista.getItem(Resp_Producto[0].SucursalId);
      setOptionsSucursal(Resp_Sucursal);

      const Resp_TipoInfraestructura = await sMerLista.getItem(Resp_Producto[0].TipoInfraestructuraId);
      setOptionsTipoInfraestructura(Resp_TipoInfraestructura);

      const Resp_Clasificacion = await sMerLista.getItem(Resp_Producto[0].ClasificacionId);
      setOptionsClasificacion(Resp_Clasificacion);

      const Resp_InfraestructuraDimension = await sMerLista.getItem(Resp_Producto[0].InfraestructuraDimensionId);
      setOptionsInfraestructuraDimension(Resp_InfraestructuraDimension);


      setEnt(Resp_Producto[0]);
    }

    setCargarPage(false);
  };
  const onChangeText = (e: React.ChangeEvent<HTMLInputElement>) => {

    setValCodigo('');
    setValNombre('');
    setValDescripcion('');
    setEnt({
      ...Ent,
      [e.target.name]: e.target.value.toUpperCase()
    });

  };
  const [selectedSucursal, setSelectedSucursal] = useState<number | undefined>(undefined);
  const [selectedTipoInfraestructura, setSelectedTipoInfraestructura] = useState<number | undefined>(undefined);
  const [selectedClasificacion, setSelectedClasificacion] = useState<number | undefined>(undefined);
  const [selectedInfraestructuraDimension, setSelectedInfraestructuraDimension] = useState<number | undefined>(undefined);
  const [selectedUM, setSelectedUM] = useState<number | undefined>(undefined);

  const [ValCodigo, setValCodigo] = useState<InputStatus>('');

  const [ValSucursal, setValSucursal] = useState<InputStatus>('');
  const [ValTipoInfraestructura, setValTipoInfraestructura] = useState<InputStatus>('');
  const [ValClasificacion, setValClasificacion] = useState<InputStatus>('');
  const [ValInfraestructuraDimension, setValInfraestructuraDimension] = useState<InputStatus>('');
  const [ValNombre, setValNombre] = useState<InputStatus>('');
  const [ValDescripcion, setValDescripcion] = useState<InputStatus>('');
  const [ValUnidadMedida, setValUnidadMedida] = useState<InputStatus>('');



  const onChangeSucursal = async (value: number) => {
    setValSucursal('');
    Ent.SucursalId = value;
    setSelectedSucursal(value)
  };

  const onChangeTipoInfraestructura = async (value: number) => {
    setValTipoInfraestructura('');
    Ent.TipoInfraestructuraId = value;
    setSelectedTipoInfraestructura(value)
  };


  const onChangeClasificacion = async (value: number) => {
    setValClasificacion('');
    Ent.ClasificacionId = value;
    setSelectedClasificacion(value)
  };


  const onChangeInfraestructuraDimension = async (value: number) => {
    setValInfraestructuraDimension('');
    Ent.InfraestructuraDimensionId = value;
    setSelectedInfraestructuraDimension(value)
  };



  const [modal, contextHolder] = Modal.useModal();
  const [messageAdd, contextHolderAdd] = message.useMessage();
  const AddProducto = async () => {

    console.log("HOLA");
    console.log(Ent);
    const savedItem = await sInfraestructura.Registrar(Ent);
    if (savedItem) {

      messageAdd.open({
        type: 'success',
        content: 'Se guardó correctamente.',
      });
    } else {
    }
  }


  const Guardar_Total = async (e: React.MouseEvent<HTMLButtonElement>) => {
    e.preventDefault();

    selectedSucursal;
    selectedTipoInfraestructura;
    selectedClasificacion;
    selectedInfraestructuraDimension;
    selectedUM;
    // if (Ent.Codigo === '') {
    //   setValCodigo('error');
    //   messageAdd.open({ type: 'error', content: 'Ingrese Codigo.', });
    //   return;
    // }
    // if (Ent.SucursalId === 0) {
    //   setValSucursal('error');
    //   messageAdd.open({ type: 'error', content: 'Seleccione una Sucursal.', });
    //   return;
    // }
    // if (Ent.TipoInfraestructuraId === 0) {
    //   setValTipoInfraestructura('error');
    //   messageAdd.open({ type: 'error', content: 'Seleccione una tipo de producto.', });
    //   return;
    // }

    // if (Ent.ClasificacionId === 0) {
    //   setValClasificacion('error');
    //   messageAdd.open({ type: 'error', content: 'Seleccione una Clasificacion.', });
    //   return;
    // }


    // if (Ent.InfraestructuraDimensionId === 0) {
    //   setValInfraestructuraDimension('error');
    //   messageAdd.open({ type: 'error', content: 'Seleccione un InfraestructuraDimension.', });
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




    modal.confirm({
      title: 'Mensaje del Sistema',
      icon: <ExclamationCircleOutlined />,
      content: '¿Desea guardar el registro?',
      okText: 'Si',
      okType: 'danger',
      cancelText: 'No',
      onOk() {
        Ent.CodUsuario = "adm";
        Ent.FechaRegistro = new Date();
        Ent.EstadoRegistro = true

        AddProducto();
      },
      onCancel() {
        console.log('Cancel');
      },
    });

  };


  useEffect(() => {
    async function cargarItem() {

      setCargarPage(true);
      await getCargarDatos();
    }


    cargarItem();


  }, []);

  return (
    <Spin spinning={CargarPage} tip="Cargando" size="large">


      {contextHolder}
      {contextHolderAdd}
      <Row>
        <Col xs={24} sm={24} md={12} lg={12} xl={12}>
          {/* <Title level={3}> Producto  {params.Id}</Title> */}
          <Title level={3}> {Ent.InfraestructuraId > 0 ? 'Infraestructura' : 'Agregar Infraestructura'}</Title>
        </Col>
        <Col xs={24} sm={24} md={12} lg={12} xl={12}>
          <Button
            style={ButtonAddMain}
            onClick={Guardar_Total}
            size={"large"}
            icon={<SaveFilled />}
          />

        </Col>
      </Row>
      <Row>
        <Col xs={24} sm={10} md={8} lg={7} xl={6}>


          <Row>
            <Col span={24}>
              <label>Codigo de sistema</label>
            </Col>
            <Col span={24}>
              <Input
                status={ValCodigo}
                type="text"
                name="CodigoSistema"
                style={{ marginTop: '5px', marginBottom: '10px' }}
                onChange={onChangeText}
                value={Ent.CodigoSistema === null ? "" : Ent.CodigoSistema}
              />
            </Col>
          </Row>
          <Row>
            <Col span={24}>
              <label>Codigo interno</label>
            </Col>
            <Col span={24}>
              <Input
                status={ValCodigo}
                type="text"
                name="CodigoInterno"
                style={{ marginTop: '5px', marginBottom: '10px' }}
                onChange={onChangeText}
                value={Ent.CodigoInterno === null ? "" : Ent.CodigoInterno}
              />
            </Col>
          </Row>
          <Row>
            <Col span={24}>
              <label>Sucursal</label>
            </Col>
            <Col span={24}>
              <Select
                status={ValSucursal}
                showSearch
                style={{ width: '85%', marginTop: '5px', marginBottom: '10px' }}
                defaultActiveFirstOption={false}
                filterOption={false}
                onSearch={handleSearchSucursal}
                value={Ent.SucursalId === 0 ? null : Ent.SucursalId}
                key={Ent.SucursalId}
                onChange={onChangeSucursal}
              >
                {optionsSucursal.map((Sucursal) => (
                  <Select.Option key={Sucursal.ListaId} value={Sucursal.ListaId}>
                    {Sucursal.Nombre}
                  </Select.Option>
                ))}
              </Select>
              <MDSucursal buttonLabel="Enlace"
                addItemToState={addItemToStateSucursal}
                item={new InfraListaEntity()}
                CodigoTabla={'M002'}
                title={"Sucursal"} />
            </Col>
          </Row>




          <Row>
            <Col span={24}>
              <label>Tipo de Infraestructura</label>
            </Col>
            <Col span={24}>
              <Select
                status={ValTipoInfraestructura}
                showSearch
                style={{ width: '85%', marginTop: '5px', marginBottom: '10px' }}
                defaultActiveFirstOption={false}
                filterOption={false}
                onSearch={handleSearchTipoInfraestructura}
                value={Ent.TipoInfraestructuraId === 0 ? null : Ent.TipoInfraestructuraId}
                key={Ent.TipoInfraestructuraId}
                onChange={onChangeTipoInfraestructura}
              >
                {optionsTipoInfraestructura.map((TipoInfraestructura) => (
                  <Select.Option key={TipoInfraestructura.ListaId} value={TipoInfraestructura.ListaId}>
                    {TipoInfraestructura.Nombre}
                  </Select.Option>
                ))}
              </Select>
              <MDTipoInfraestructura buttonLabel="Enlace"
                addItemToState={addItemToStateTipoInfraestructura}
                item={new InfraListaEntity()}
                CodigoTabla={'M003'}
                title={"Tipo Producto"} />




            </Col>
          </Row>



          <Row>
            <Col span={24}>
              <label>Clasificación</label>
            </Col>
            <Col span={24}>
              <Select
                showSearch
                status={ValClasificacion}
                style={{ width: '85%', marginTop: '5px', marginBottom: '10px' }}
                defaultActiveFirstOption={false}
                filterOption={false}
                onSearch={handleSearchClasificacion}
                value={Ent.ClasificacionId === 0 ? null : Ent.ClasificacionId}
                key={Ent.ClasificacionId}
                onChange={onChangeClasificacion}
              >
                {optionsClasificacion.map((Clasificacion) => (
                  <Select.Option key={Clasificacion.ListaId} value={Clasificacion.ListaId}>
                    {Clasificacion.Nombre}
                  </Select.Option>
                ))}
              </Select>

              <MDClasificacion buttonLabel="Enlace"
                addItemToState={addItemToStateClasificacion}
                item={new InfraListaEntity()}
                CodigoTabla={'M004'}
                title={"Clasificacion"} />



            </Col>
          </Row>

          <Row>
            <Col span={24}>
              <label>Dimension</label>
            </Col>
            <Col span={24}>
              <Select
                showSearch
                status={ValInfraestructuraDimension}
                style={{ width: '85%', marginTop: '5px', marginBottom: '10px' }}
                defaultActiveFirstOption={false}
                filterOption={false}
                onSearch={handleSearchInfraestructuraDimension}
                value={Ent.InfraestructuraDimensionId === 0 ? null : Ent.InfraestructuraDimensionId}
                key={Ent.InfraestructuraDimensionId}
                onChange={onChangeInfraestructuraDimension}
              >
                {optionsInfraestructuraDimension.map((InfraestructuraDimension) => (
                  <Select.Option key={InfraestructuraDimension.ListaId} value={InfraestructuraDimension.ListaId}>
                    {InfraestructuraDimension.Nombre}
                  </Select.Option>
                ))}
              </Select>
              <MDInfraestructuraDimension buttonLabel="Enlace"
                addItemToState={addItemToStateInfraestructuraDimension}
                item={new InfraListaEntity()}
                CodigoTabla={'M005'}
                title={"InfraestructuraDimension"} />



            </Col>
          </Row>

          <Row>
            <Col span={24}>
              <label>Piso</label>
            </Col>
            <Col span={24}>
              <Select
                showSearch
                status={ValInfraestructuraDimension}
                style={{ width: '85%', marginTop: '5px', marginBottom: '10px' }}
                defaultActiveFirstOption={false}
                filterOption={false}
                onSearch={handleSearchInfraestructuraDimension}
                value={Ent.PisoId === 0 ? null : Ent.PisoId}
                key={Ent.PisoId}
                onChange={onChangeInfraestructuraDimension}
              >
                {optionsInfraestructuraDimension.map((InfraestructuraDimension) => (
                  <Select.Option key={InfraestructuraDimension.ListaId} value={InfraestructuraDimension.ListaId}>
                    {InfraestructuraDimension.Nombre}
                  </Select.Option>
                ))}
              </Select>
              <MDInfraestructuraDimension buttonLabel="Enlace"
                addItemToState={addItemToStateInfraestructuraDimension}
                item={new InfraListaEntity()}
                CodigoTabla={'M005'}
                title={"InfraestructuraDimension"} />



            </Col>
          </Row>
       

          <Row>
            <Col span={24}>
              <label>Descripcion</label>
            </Col>
            <Col span={24}>
              <Input
                type="TextArea"

                name="Descripcion"
                status={ValDescripcion}
                style={{ marginTop: '5px', marginBottom: '10px' }}
                onChange={onChangeText}
                value={Ent.Descripcion === null ? "" : Ent.Descripcion}
              />

            </Col>
          </Row>



        </Col>

        <Col xs={24} sm={14} md={16} lg={17} xl={18}>
          <Tabs
            style={{ marginLeft: '20px' }}
            type="line" items={TabsItems} />
        </Col>
      </Row>
    </Spin>
  );
};


export default Save;