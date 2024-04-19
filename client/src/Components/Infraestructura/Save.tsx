import React, { useEffect, useState } from 'react';
import { SaveFilled, ExclamationCircleOutlined } from '@ant-design/icons';
import { Tabs, Table, message, Select, Button, Col, Row, Typography, Modal, Spin, Input } from 'antd';
import InfraListaService from '../../Service/InfraListaService';
import MDSucursal from './Enlace/InfraLista/ModalItem';
import MDTipoInfraestructura from './Enlace/InfraLista/ModalItem';
import MDClasificacion from './Enlace/InfraLista/ModalItem';
import MDInfraestructuraDimension from './Enlace/InfraLista/ModalItem';

import type { InputStatus } from 'antd/lib/_util/statusUtils'
import { useParams } from 'react-router-dom';
import { ButtonAddMain } from '../../Styles/Button'
import InfraestructuraService from '../../Service/InfraestructuraService';
import { InfraestructuraSaveModel } from '../../Models/InfraestructuraEntity';
import GeneralService from '../../Service/GeneralService';
import { UnidadMedidaEntity } from '../../Models/UnidadMedidaEntity';
import { InfraListaModel } from '../../Models/InfraListaEntity';
const Save = () => {
  const { Id } = useParams();
  const idNumero = Number(Id?.toString());
  const sInfraLista = new InfraListaService();
  const sInfraestructura = new InfraestructuraService();
  const sGeneralService = new GeneralService();
  const initialProducto = new InfraestructuraSaveModel();
  const [Ent, setEnt] = useState<InfraestructuraSaveModel>(initialProducto);
  const { Title } = Typography;
  const [CargarPage, setCargarPage] = React.useState(true);

  const addItemToStateSucursal = async (item: InfraListaModel) => {
    const Resp_Sucursal = await sInfraLista.ObtenerItem(item.ListaId);
    setOptionsSucursal(Resp_Sucursal);
    Ent.SucursalId = Resp_Sucursal[0].ListaId;

  };

  const addItemToStateClasificacion = async (item: InfraListaModel) => {
    const Resp_Clasificacion = await sInfraLista.ObtenerItem(item.ListaId);
    setOptionsClasificacion(Resp_Clasificacion);
    Ent.ClasificacionId = Resp_Clasificacion[0].ListaId;

  };

  const addItemToStateInfraestructuraDimension = async (item: InfraListaModel) => {
    const Resp_InfraestructuraDimension = await sInfraLista.ObtenerItem(item.ListaId);
    setOptionsInfraestructuraDimension(Resp_InfraestructuraDimension);
    Ent.InfraestructuraDimensionId = Resp_InfraestructuraDimension[0].ListaId;
  };

  const addItemToStateTipoInfraestructura = async (item: InfraListaModel) => {
    const Resp_TipoInfraestructura = await sInfraLista.ObtenerItem(item.ListaId);
    setOptionsTipoInfraestructura(Resp_TipoInfraestructura);
    Ent.TipoInfraestructuraId = Resp_TipoInfraestructura[0].ListaId;
  };

  const addItemToStatePiso = async (item: InfraListaModel) => {
    const Resp_Piso = await sInfraLista.ObtenerItem(item.ListaId);
    setOptionsPiso(Resp_Piso);
    Ent.TipoInfraestructuraId = Resp_Piso[0].ListaId;

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


  const [optionsSucursal, setOptionsSucursal] = useState<InfraListaModel[]>([]);
  const [optionsTipoInfraestructura, setOptionsTipoInfraestructura] = useState<InfraListaModel[]>([]);
  const [optionsClasificacion, setOptionsClasificacion] = useState<InfraListaModel[]>([]);
  const [optionsInfraestructuraDimension, setOptionsInfraestructuraDimension] = useState<InfraListaModel[]>([]);
  const [optionsPiso, setOptionsPiso] = useState<InfraListaModel[]>([]);



  const handleSearchSucursal = async (value: string) => {
    try {
      const responseSucursal = await sInfraLista.BuscarItemCodigo("0001", value);
      console.log(responseSucursal);
      // setOptionsSucursal(responseSucursal);

    } catch (error) {
      console.error('Error al buscar categorías:', error);
    }
  };

  const handleSearchTipoInfraestructura = async (value: string) => {
    try {
      const responseTipoInfraestructura = await sInfraLista.BuscarItemCodigo("0006", value);
      setOptionsTipoInfraestructura(responseTipoInfraestructura);
    } catch (error) {
      console.error('Error al buscar categorías:', error);
    }
  };



  const handleSearchClasificacion = async (value: string) => {
    try {
      const responseClasificacion = await sInfraLista.BuscarItemCodigo("0013", value);
      setOptionsClasificacion(responseClasificacion);
    } catch (error) {
      console.error('Error al buscar categorías:', error);
    }
  };

  const handleSearchInfraestructuraDimension = async (value: string) => {
    try {
      const responseInfraestructuraDimension = await sInfraLista.BuscarItemCodigo("0007", value);
      setOptionsInfraestructuraDimension(responseInfraestructuraDimension);
    } catch (error) {
      console.error('Error al buscar categorías:', error);
    }
  };

  const handleSearchPiso = async (value: string) => {
    try {
      const responsePiso = await sInfraLista.BuscarItemCodigo("0009", value);
      setOptionsPiso(responsePiso);
    } catch (error) {
      console.error('Error al buscar categorías:', error);
    }
  };

  const getCargarDatos = async () => {

    if (idNumero > 0) {

      const Resp_Producto = await sInfraestructura.GetInfraestructuraItem(idNumero);

      const Resp_Sucursal = await sInfraLista.ObtenerItemEnlace(Resp_Producto[0].SucursalId);
      const Resp_TipoInfraestructura = await sInfraLista.ObtenerItemEnlace(Resp_Producto[0].TipoInfraestructuraId);
      const Resp_InfraestructuraDimension = await sInfraLista.ObtenerItemEnlace(Resp_Producto[0].InfraestructuraDimensionId);
      const Resp_Clasificacion = await sInfraLista.ObtenerItemEnlace(Resp_Producto[0].ClasificacionId);
      const Resp_Piso = await sInfraLista.ObtenerItemEnlace(Resp_Producto[0].PisoId);

      setOptionsTipoInfraestructura(Resp_TipoInfraestructura);
      setOptionsClasificacion(Resp_Clasificacion);
      setOptionsInfraestructuraDimension(Resp_InfraestructuraDimension);
      setOptionsSucursal(Resp_Sucursal);
      setOptionsPiso(Resp_Piso);

      setEnt(Resp_Producto[0]);
    }

    setCargarPage(false);
  };

  const onChangeText = (e: React.ChangeEvent<HTMLInputElement>) => {

    setValCodigo('');
    setValNombre('');
    setValDescripcion('');
    setValPiso('');
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
  const [selectedPiso, setSelectedPiso] = useState<number | undefined>(undefined);


  const [ValCodigo, setValCodigo] = useState<InputStatus>('');

  const [ValSucursal, setValSucursal] = useState<InputStatus>('');
  const [ValTipoInfraestructura, setValTipoInfraestructura] = useState<InputStatus>('');
  const [ValClasificacion, setValClasificacion] = useState<InputStatus>('');
  const [ValInfraestructuraDimension, setValInfraestructuraDimension] = useState<InputStatus>('');
  const [ValNombre, setValNombre] = useState<InputStatus>('');
  const [ValDescripcion, setValDescripcion] = useState<InputStatus>('');
  const [ValUnidadMedida, setValUnidadMedida] = useState<InputStatus>('');
  const [ValPiso, setValPiso] = useState<InputStatus>('');



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


  const onChangePiso = async (value: number) => {
    setValPiso('');
    Ent.PisoId = value;
    setSelectedPiso(value)
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
    selectedPiso;
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
                item={new InfraListaModel()}
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
                item={new InfraListaModel()}
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
                item={new InfraListaModel()}
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
                item={new InfraListaModel()}
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
                status={ValPiso}
                style={{ width: '85%', marginTop: '5px', marginBottom: '10px' }}
                defaultActiveFirstOption={false}
                filterOption={false}
                onSearch={handleSearchPiso}
                value={Ent.PisoId === 0 ? null : Ent.PisoId}
                key={Ent.PisoId}
                onChange={onChangePiso}
              >
                {optionsPiso.map((PisoItem) => (
                  <Select.Option key={PisoItem.ListaId} value={PisoItem.ListaId}>
                    {PisoItem.Nombre}
                  </Select.Option>
                ))}
              </Select>
              <MDInfraestructuraDimension buttonLabel="Enlace"
                addItemToState={addItemToStateInfraestructuraDimension}
                item={new InfraListaModel()}
                CodigoTabla={'M009'}
                title={"Piso"} />



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