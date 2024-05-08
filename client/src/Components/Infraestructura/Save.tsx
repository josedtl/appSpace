// Librerias
import React, { useEffect, useState } from 'react';
import { SaveFilled, ExclamationCircleOutlined } from '@ant-design/icons';
import { message, Select, Button, Col, Row, Typography, Modal, Spin, Input } from 'antd';
import type { InputStatus } from 'antd/lib/_util/statusUtils'
import { useParams } from 'react-router-dom';

// Importacion de servicios
import InfraListaService from '../../Service/InfraListaService';
import InfraestructuraService from '../../Service/InfraestructuraService';

// Importacion de componentes
import MDSucursal from './Enlace/InfraLista/ModalItem';
import MDTipoInfraestructura from './Enlace/InfraLista/ModalItem';
import MDClasificacion from './Enlace/InfraLista/ModalItem';
import MDInfraestructuraDimension from './Enlace/InfraLista/ModalItem';
import MDPiso from './Enlace/InfraLista/ModalItem';
import { ButtonAddMain } from '../../Styles/Button'

// Importacion de Entidades
import { InfraestructuraSaveModel } from '../../Models/InfraestructuraEntity';
import { InfraListaModel } from '../../Models/InfraListaEntity';



const Save = () => {

  // Variables de Servicios
  const sInfraestructura = new InfraestructuraService();
  const sInfraLista = new InfraListaService();

  // Instancia de Entidades
  const initialProducto = new InfraestructuraSaveModel();

  // Variables Globales
  const { Id } = useParams();
  const idNumero = Number(Id?.toString());
  const [Ent, setEnt] = useState<InfraestructuraSaveModel>(initialProducto);
  const { Title } = Typography;
  const { TextArea } = Input;
  const [CargarPage, setCargarPage] = React.useState(true);

  const [optionsSucursal, setOptionsSucursal] = useState<InfraListaModel[]>([]);
  const [optionsTipoInfraestructura, setOptionsTipoInfraestructura] = useState<InfraListaModel[]>([]);
  const [optionsClasificacion, setOptionsClasificacion] = useState<InfraListaModel[]>([]);
  const [optionsInfraestructuraDimension, setOptionsInfraestructuraDimension] = useState<InfraListaModel[]>([]);
  const [optionsPiso, setOptionsPiso] = useState<InfraListaModel[]>([]);

  const [selectedSucursal, setSelectedSucursal] = useState<number | undefined>(undefined);
  const [selectedTipoInfraestructura, setSelectedTipoInfraestructura] = useState<number | undefined>(undefined);
  const [selectedClasificacion, setSelectedClasificacion] = useState<number | undefined>(undefined);
  const [selectedInfraestructuraDimension, setSelectedInfraestructuraDimension] = useState<number | undefined>(undefined);
  const [selectedPiso, setSelectedPiso] = useState<number | undefined>(undefined);

  const [ValCodigoInterno, setValCodigoInterno] = useState<InputStatus>('');
  const [ValCodigoSistema, setValCodigoSistema] = useState<InputStatus>('');
  const [ValSucursal, setValSucursal] = useState<InputStatus>('');
  const [ValTipoInfraestructura, setValTipoInfraestructura] = useState<InputStatus>('');
  const [ValClasificacion, setValClasificacion] = useState<InputStatus>('');
  const [ValInfraestructuraDimension, setValInfraestructuraDimension] = useState<InputStatus>('');
  const [ValNombre, setValNombre] = useState<InputStatus>('');
  const [ValDescripcion, setValDescripcion] = useState<InputStatus>('');
  const [ValPiso, setValPiso] = useState<InputStatus>('');

  const [modal, contextHolder] = Modal.useModal();
  const [messageAdd, contextHolderAdd] = message.useMessage();


  // Load

  useEffect(() => {
    async function cargarItem() {
      setCargarPage(true);
      await getCargarDatos();
    }
    cargarItem();

  }, []);
  const getCargarDatos = async () => {

    if (idNumero > 0) {

      const Resp_Producto = await sInfraestructura.GetInfraestructuraItem(idNumero);

      const Resp_Sucursal = await sInfraLista.ObtenerItem(Resp_Producto[0].SucursalId);
      const Resp_TipoInfraestructura = await sInfraLista.ObtenerItem(Resp_Producto[0].TipoInfraestructuraId);
      const Resp_InfraestructuraDimension = await sInfraLista.ObtenerItem(Resp_Producto[0].InfraestructuraDimensionId);
      const Resp_Clasificacion = await sInfraLista.ObtenerItem(Resp_Producto[0].ClasificacionId);
      const Resp_Piso = await sInfraLista.ObtenerItem(Resp_Producto[0].PisoId);

      setOptionsTipoInfraestructura(Resp_TipoInfraestructura);
      setOptionsClasificacion(Resp_Clasificacion);
      setOptionsInfraestructuraDimension(Resp_InfraestructuraDimension);
      setOptionsSucursal(Resp_Sucursal);
      setOptionsPiso(Resp_Piso);

      setEnt(Resp_Producto[0]);

    }

    setCargarPage(false);
  };


  // Metodos


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
    Ent.PisoId = Resp_Piso[0].ListaId;

  };


  
  const onSearchSucursal = async (value: string) => {
    try {
      const responseSucursal = await sInfraLista.BuscarItemCodigo("0001", value);
      setOptionsSucursal(responseSucursal);
    } catch (error) {
      console.error('Error :', error);
    }
  };

  const onSearchTipoInfraestructura = async (value: string) => {
    try {
      const responseTipoInfraestructura = await sInfraLista.BuscarItemCodigo("0006", value);
      setOptionsTipoInfraestructura(responseTipoInfraestructura);
    } catch (error) {
      console.error('Error al buscar categorías:', error);
    }
  };

  const onSearchClasificacion = async (value: string) => {
    try {
      const responseClasificacion = await sInfraLista.BuscarItemCodigo("0013", value);
      setOptionsClasificacion(responseClasificacion);
    } catch (error) {
      console.error('Error al buscar categorías:', error);
    }
  };

  const onSearchInfraestructuraDimension = async (value: string) => {
    try {
      const responseInfraestructuraDimension = await sInfraLista.BuscarItemCodigo("0007", value);
      setOptionsInfraestructuraDimension(responseInfraestructuraDimension);
    } catch (error) {
      console.error('Error al buscar categorías:', error);
    }
  };

  const onSearchPiso = async (value: string) => {
    try {
      const responsePiso = await sInfraLista.BuscarItemCodigo("0009", value);
      setOptionsPiso(responsePiso);
    } catch (error) {
      console.error('Error al buscar categorías:', error);
    }
  };



  const onChangeText = (e: React.ChangeEvent<HTMLInputElement>) => {

    setValCodigoInterno('');
    setValCodigoSistema('');
    setValNombre('');
    setValDescripcion('');
    setValPiso('');
    setEnt({
      ...Ent,
      [e.target.name]: e.target.value.toUpperCase()
    });

  };
  const onChange = (e: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement>) => {
    setValCodigoInterno('');
    setValCodigoSistema('');
    setValNombre('');
    setValDescripcion('');
    setValPiso('');
    setEnt({
      ...Ent,
      [e.target.name]: e.target.value.toUpperCase()
    });
  };


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

  const MetodoRegistrar = async () => {

    const savedItem = await sInfraestructura.Registrar(Ent);
    if (savedItem) {
      console.log(savedItem);
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
    selectedPiso;
    ValDescripcion;
    ValNombre;
    if (Ent.CodigoInterno.trimEnd() === '') {
      setValCodigoInterno('error');
      messageAdd.open({ type: 'error', content: 'Ingrese Codigo Interno .', });
      return;
    }

    if (Ent.SucursalId === 0) {
      setValSucursal('error');
      messageAdd.open({ type: 'error', content: 'Seleccione una Sucursal.', });
      return;
    }

    if (Ent.TipoInfraestructuraId === 0) {
      setValTipoInfraestructura('error');
      messageAdd.open({ type: 'error', content: 'Seleccione una tipo de producto.', });
      return;
    }

    if (Ent.ClasificacionId === 0) {
      setValClasificacion('error');
      messageAdd.open({ type: 'error', content: 'Seleccione una Clasificacion.', });
      return;
    }

    if (Ent.InfraestructuraDimensionId === 0) {
      setValInfraestructuraDimension('error');
      messageAdd.open({ type: 'error', content: 'Seleccione un InfraestructuraDimension.', });
      return;
    }

    if (Ent.Descripcion === '') {
      setValDescripcion('error');
      messageAdd.open({ type: 'error', content: 'Ingrese un Nombre.', });
      return;
    }

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
        Ent.Action = Ent.InfraestructuraId == 0 ? 1 : 3;
        MetodoRegistrar();
      },
      onCancel() {
        console.log('Cancel');
      },
    });

  };



  return (
    <Spin spinning={CargarPage} tip="Cargando" size="large">

      {contextHolder}
      {contextHolderAdd}
      <Row>
        <Col xs={24} sm={24} md={12} lg={12} xl={12}>
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
                status={ValCodigoSistema}
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
                status={ValCodigoInterno}
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
                onSearch={onSearchSucursal}
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
                CodigoTabla={'0001'}
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
                onSearch={onSearchTipoInfraestructura}
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
                CodigoTabla={'0006'}
                title={"Tipo de Infraestructura"} />

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
                onSearch={onSearchClasificacion}
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
                CodigoTabla={'0013'}
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
                onSearch={onSearchInfraestructuraDimension}
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
                CodigoTabla={'0007'}
                title={"Dimension"} />

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
                onSearch={onSearchPiso}
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
              <MDPiso buttonLabel="Enlace"
                addItemToState={addItemToStatePiso}
                item={new InfraListaModel()}
                CodigoTabla={'0009'}
                title={"Piso"} />
            </Col>
          </Row>


          <Row>
            <Col span={24}>
              <label>Descripcion</label>
            </Col>
            <Col span={24}>
              {/* <Input
                type="TextArea"

                name="Descripcion"
                status={ValDescripcion}
                style={{ marginTop: '5px', marginBottom: '10px' }}
                onChange={onChangeText}
                value={Ent.Descripcion === null ? "" : Ent.Descripcion}
              /> */}
              <TextArea
                showCount
                name="Descripcion"
                maxLength={200}
                onChange={onChange}
                placeholder=""
                value={Ent.Descripcion === null ? "" : Ent.Descripcion}
                style={{ height: 120, resize: 'none' }}
              />
            </Col>
          </Row>
        </Col>

        <Col xs={24} sm={14} md={16} lg={17} xl={18}>
          {/* <Tabs
            style={{ marginLeft: '20px' }}
            type="line" items={TabsItems} /> */}
        </Col>
      </Row>
    </Spin>
  );
};


export default Save;