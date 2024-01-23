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
  // ---Traerpor el servicio las sucurales
  const Buscar_Sucursal = async (value: string) => {
    try {
      const responseSucursal = await sInfraListaService.getInfraListaLike('0001', value);
      setOptionsSucural(responseSucursal);
    } catch (error) {
      console.error('Error al buscar categorías:', error);
    }
  };

  // --- Seleccioonar el valor 
  const onChangeSucursal = async (value: number) => {
    setValSucursal('');
    Ent.SucursalId = value;
    setSelectedSucursal(value)
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
                name="InfraestructuraId"
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
                name="InfraestructuraId"
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
                name="InfraestructuraId"
                style={{ marginTop: '5px', marginBottom: '10px' }}
                onChange={onChangeText}
              />
            </Col>
          </Row>


          <Row>
            <Col span={24}>
              <label>TipoInfraestructuraId</label>
            </Col>
            <Col span={24}>
              <Select
                showSearch
                style={{ width: '85%', marginTop: '5px', marginBottom: '10px' }}
                defaultActiveFirstOption={false}
                filterOption={false}
              >

              </Select>
              <MDCategoria buttonLabel="Enlace"
                item={new CategoriaEntity()} />
            </Col>
          </Row>

          <Row>
            <Col span={24}>
              <label>InfraestructuraDimendonId</label>
            </Col>
            <Col span={24}>
              <Select
                showSearch
                style={{ width: '85%', marginTop: '5px', marginBottom: '10px' }}
                defaultActiveFirstOption={false}
                filterOption={false}
              >

              </Select>
              <MDCategoria buttonLabel="Enlace"
                item={new CategoriaEntity()} />
            </Col>
          </Row>


          <Row>
            <Col span={24}>
              <label>Aforo</label>
            </Col>
            <Col span={24}>
              <Input
                type="number"
                name="Reserva"
                style={{ marginTop: '5px', marginBottom: '10px' }}
                onChange={onChangeText}
              />
            </Col>
          </Row>

          <Row>
            <Col span={24}>
              <label>PisoId</label>
            </Col>
            <Col span={24}>
              <Select
                showSearch
                style={{ width: '85%', marginTop: '5px', marginBottom: '10px' }}
                defaultActiveFirstOption={false}
                filterOption={false}
              >

              </Select>
              <MDCategoria buttonLabel="Enlace"
                item={new CategoriaEntity()} />
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