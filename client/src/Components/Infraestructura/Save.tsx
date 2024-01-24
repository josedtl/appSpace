import React, { useEffect, useState } from 'react';
import { SaveFilled, ExclamationCircleOutlined } from '@ant-design/icons';
import { message, Select, Button, Col, Row, Typography, Modal, Spin, Input } from 'antd';
import { CategoriaEntity } from '../../Models/CategoriaEntity';
import MDCategoria from '../Categoria/ModalItem';
import type { InputStatus } from 'antd/lib/_util/statusUtils'
import { useParams } from 'react-router-dom';
import { ButtonAddMain } from '../../Styles/Button'
import { ImfraestructuraEntity } from '../../Models/InfraestructuraEntity';
import { InfraListaModel } from '../../Models/InfraListaEntity';
import InfraListaService from '../../Service/InfraListaService';

const Save = () => {

  // ****************************************************VARIABLES GLOBALES**********************************************************
  const { Id } = useParams();
  const idNumero = Number(Id?.toString());
  const sInfraListaService = new InfraListaService();
  const initialInfraestructura = new ImfraestructuraEntity();
  const [Ent, setEnt] = useState<ImfraestructuraEntity>(initialInfraestructura);
  const { Title } = Typography;
  const [CargarPage, setCargarPage] = React.useState(false)


  // *******************REGION LOAD***********************************************************************************************
  useEffect(() => {


  }, []);
  // *******************END REGION LOAD*******************************************************************************************


  // ******************REGION SUCURAL COMBO LIKE *********************************************************************************

  // ---Variables de sucursal
  const [ValSucursal, setValSucursal] = useState<InputStatus>('');
  const [selectedSucursal, setSelectedSucursal] = useState<number | undefined>(undefined);
  const [optionsSucursal, setOptionsSucural] = useState<InfraListaModel[]>([]);

  // ---Variables de TipoInfraestructura
  const [ValTipoInfraestructura, setValTipoInfraestructura] = useState<InputStatus>('');
  const [selectedTipoInfraestructura, setSelectedTipoInfraestructura] = useState<number | undefined>(undefined);
  const [optionsTipoInfraestructura, setOptionsTipoInfraestructura] = useState<InfraListaModel[]>([]);
  
  // ---Variables de InfraestructuraDimension
  const [ValInfraestructuraDimension, setValInfraestructuraDimension] = useState<InputStatus>('');
  const [selectedInfraestructuraDimension, setSelectedInfraestructuraDimension] = useState<number | undefined>(undefined);
  const [optionsInfraestructuraDimension, setOptionsInfraestructuraDimension] = useState<InfraListaModel[]>([]);
  
    // ---Variables de Piso
    const [ValPiso, setValPiso] = useState<InputStatus>('');
    const [selectedPiso, setSelectedPiso] = useState<number | undefined>(undefined);
    const [optionsPiso, setOptionsPiso] = useState<InfraListaModel[]>([]);
  

  // ---Traer por el servicio las sucurales
  const Buscar_Sucursal = async (value: string) => {
    try {
      const responseSucursal = await sInfraListaService.getInfraListaLike('0001', value);
      setOptionsSucural(responseSucursal);
    } catch (error) {
      console.error('Error al buscar Sucursal:', error);
    }
  };

    // ---Traer por el servicio TipoInfraestructura
  const Buscar_TipoInfraestructura = async (value: string) => {
    try {
      const responseTipoInfraestructura = await sInfraListaService.getInfraListaLike('0006', value);
      setOptionsTipoInfraestructura(responseTipoInfraestructura);
    } catch (error) {
      console.error('Error al buscar Tipo de Infraestructura:', error);
    }
  };

  
  // ---Traer por el servicio InfraestructuraDimension
  const Buscar_InfraestructuraDimension = async (value: string) => {
    try {
      const responseInfraestructuraDimension = await sInfraListaService.getInfraListaLike('0007', value);
      setOptionsInfraestructuraDimension(responseInfraestructuraDimension);
    } catch (error) {
      console.error('Error al buscar Infraestructura Dimension:', error);
    }
  };

// ---Traer por el servicio Piso
const Buscar_Piso = async (value: string) => {
  try {
    const responsePiso = await sInfraListaService.getInfraListaLike('0009', value);
    setOptionsPiso(responsePiso);
  } catch (error) {
    console.error('Error al buscar Piso:', error);
  }
};


  // --- Seleccioonar el valor 
  const onChangeSucursal = async (value: number) => {
    setValSucursal('');
    Ent.SucursalId = value;
    setSelectedSucursal(value)
  };
  
    // --- Seleccioonar el valor 
  const onChangTipoInfraestructura = async (value: number) => {
    setValTipoInfraestructura('');
    Ent.TipoInfraestructuraId = value;
    setSelectedTipoInfraestructura(value)
  };

  // --- Seleccioonar el valor 
  const onChangInfraestructuraDimension = async (value: number) => {
    setValInfraestructuraDimension('');
    Ent.InfraestructuraDimensionId = value;
    setSelectedInfraestructuraDimension(value)
  };

   // --- Seleccioonar el valor 
   const onChangPiso = async (value: number) => {
    setValPiso('');
    Ent.PisoId = value;
    setSelectedPiso(value)
  };

  // ******************END REGION SUCURAL COMBO LIKE ****************************************************************************












  const onChangeText = (e: React.ChangeEvent<HTMLInputElement>) => {

    setEnt({
      ...Ent,
      [e.target.name]: e.target.value.toUpperCase()
    });

  };
  const [ValCodigo, setValCodigo] = useState<InputStatus>('');



  const [modal, contextHolder] = Modal.useModal();
  const [messageAdd, contextHolderAdd] = message.useMessage();



  const Guardar_Total = async (e: React.MouseEvent<HTMLButtonElement>) => {
    e.preventDefault();
    selectedSucursal;


    modal.confirm({
      title: 'Mensaje del Sistema',
      icon: <ExclamationCircleOutlined />,
      content: '¿Desea guardar el registro?',
      okText: 'Si',
      okType: 'danger',
      cancelText: 'No',
      onOk() {
        // Ent.CodUsuario = "adm";
        // Ent.FechaRegistro = new Date();
        // Ent.EstadoRegistro = true
        // Ent.Action = Ent.ProductoId == 0 ? 1 : 3;
        // AddProducto();
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
          <Title level={3}> {Ent.InfraestructuraId > 0 ? 'Infraestructura' : 'Infraestructura'}</Title>
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
              <label>Sucursal</label>
            </Col>
            <Col span={24}>
              <Select
                status={ValSucursal}
                showSearch
                style={{ width: '85%', marginTop: '5px', marginBottom: '10px' }}
                defaultActiveFirstOption={false}
                filterOption={false}
                onSearch={Buscar_Sucursal}
                value={Ent.SucursalId === 0 ? null : Ent.SucursalId}
                key={Ent.SucursalId}
                onChange={onChangeSucursal}
              >
                {optionsSucursal.map((SucursalItem) => (
                  <Select.Option key={SucursalItem.ListaId} value={SucursalItem.ListaId}>
                    {SucursalItem.Nombre}
                  </Select.Option>
                ))}
              </Select>
              {/* <MDCategoria buttonLabel="Enlace"
                item={new CategoriaEntity()} /> */}
            </Col>
          </Row>

          <Row>
            <Col span={24}>
              <label>CodigoSistema</label>
            </Col>
            <Col span={24}>
              <Input
                status={ValCodigo}
                type="text"
                name="CodigoSistema"
                style={{ marginTop: '5px', marginBottom: '10px' }}
                onChange={onChangeText}
              />
            </Col>
          </Row>

          <Row>
            <Col span={24}>
              <label>CodigoInterno</label>
            </Col>
            <Col span={24}>
              <Input
                status={ValCodigo}
                type="text"
                name="CodigoInterno"
                style={{ marginTop: '5px', marginBottom: '10px' }}
                onChange={onChangeText}
              />
            </Col>
          </Row>

          <Row>
            <Col span={24}>
              <label>Descripcion</label>
            </Col>
            <Col span={24}>
              <Input
                status={ValCodigo}
                type="text"
                name="Descripcion"
                style={{ marginTop: '5px', marginBottom: '10px' }}
                onChange={onChangeText}
              />
            </Col>
          </Row>


          <Row>
            <Col span={24}>
              <label>Tipo Infraestructura</label>
            </Col>
            <Col span={24}>
              <Select
                status={ValTipoInfraestructura}
                showSearch
                style={{ width: '85%', marginTop: '5px', marginBottom: '10px' }}
                defaultActiveFirstOption={false}
                filterOption={false}
                onSearch={Buscar_TipoInfraestructura}
                value={Ent.TipoInfraestructuraId === 0 ? null : Ent.TipoInfraestructuraId}
                key={Ent.TipoInfraestructuraId}
                onChange={onChangTipoInfraestructura}
              >
                {optionsTipoInfraestructura.map((TipoInfraestructuraItem) => (
                  <Select.Option key={TipoInfraestructuraItem.ListaId} value={TipoInfraestructuraItem.ListaId}>
                    {TipoInfraestructuraItem.Nombre}
                  </Select.Option>
                ))}
              </Select>
              {/* <MDCategoria buttonLabel="Enlace"
                item={new CategoriaEntity()} /> */}
            </Col>
          </Row>

          <Row>
            <Col span={24}>
              <label>Infraestructura Dimension</label>
            </Col>
            <Col span={24}>
              <Select
                status={ValInfraestructuraDimension}
                showSearch
                style={{ width: '85%', marginTop: '5px', marginBottom: '10px' }}
                defaultActiveFirstOption={false}
                filterOption={false}
                onSearch={Buscar_InfraestructuraDimension}
                value={Ent.InfraestructuraDimensionId === 0 ? null : Ent.InfraestructuraDimensionId}
                key={Ent.InfraestructuraDimensionId}
                onChange={onChangInfraestructuraDimension}
              >
                {optionsInfraestructuraDimension.map((InfraestructuraDimensionItem) => (
                  <Select.Option key={InfraestructuraDimensionItem.ListaId} value={InfraestructuraDimensionItem.ListaId}>
                    {InfraestructuraDimensionItem.Nombre}
                  </Select.Option>
                ))}
              </Select>
              {/* <MDCategoria buttonLabel="Enlace"
                item={new CategoriaEntity()} /> */}
            </Col>
          </Row>




          <Row>
            <Col span={24}>
              <label>Aforo</label>
            </Col>
            <Col span={24}>
              <Input
                type="number"
                name="Aforo"
                style={{ marginTop: '5px', marginBottom: '10px' }}
                onChange={onChangeText}
              />
            </Col>
          </Row>

          <Row>
            <Col span={24}>
              <label>Piso</label>
            </Col>
            <Col span={24}>
              <Select
                status={ValPiso}
                showSearch
                style={{ width: '85%', marginTop: '5px', marginBottom: '10px' }}
                defaultActiveFirstOption={false}
                filterOption={false}
                onSearch={Buscar_Piso}
                value={Ent.PisoId === 0 ? null : Ent.PisoId}
                key={Ent.PisoId}
                onChange={onChangPiso}
              >
                {optionsPiso.map((PisoItem) => (
                  <Select.Option key={PisoItem.ListaId} value={PisoItem.ListaId}>
                    {PisoItem.Nombre}
                  </Select.Option>
                ))}
              </Select>
              {/* <MDCategoria buttonLabel="Enlace"
                item={new CategoriaEntity()} /> */}
            </Col>
          </Row>


        </Col>

        {/* <Col xs={24} sm={14} md={16} lg={17} xl={18}>
          <Tabs
            style={{ marginLeft: '20px' }}
            type="line" items={TabsItems} />
        </Col> */}
      </Row>
    </Spin>
  );
};


export default Save;