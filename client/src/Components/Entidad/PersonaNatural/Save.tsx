import React, { useEffect, useState } from 'react';
import { SaveFilled, ExclamationCircleOutlined } from '@ant-design/icons';
import { message, Select, Button, Col, Row, Typography, Modal, Spin, Input, DatePicker } from 'antd';
import { PersonaNaturalSaveModel } from '../../../Models/PersonaNaturalEntity';
import PersonaNaturalService from '../../../Service/PersonaNaturalService';
import type { InputStatus } from 'antd/lib/_util/statusUtils'
import { useParams } from 'react-router-dom';
import { ButtonAddMain } from '../../../Styles/Button'
import type { DatePickerProps } from 'antd';
import moment from 'moment';
import 'moment/locale/es';
import dayjs from 'dayjs';
import { ProcessActionEnum } from '../../../Lib/ResourceModel/Enum'
import EntListaService from '../../../Service/EntListaService';
import { EntListaModel } from '../../../Models/EntListaEntity';
import GeneralService from '../../../Service/GeneralService';
import { UbigeoEntity } from '../../../Models/UbigeoEntity';
const Save = () => {
  const { Id } = useParams();
  const idNumero = Number(Id?.toString());
  const sEntLista = new EntListaService();
  const sGeneralService = new GeneralService();
  const sPersonaNatural = new PersonaNaturalService();
  const initialPersonaNatural = new PersonaNaturalSaveModel();
  const [Ent, setEnt] = useState<PersonaNaturalSaveModel>(initialPersonaNatural);
  const { Title } = Typography;
  const [CargarPage, setCargarPage] = React.useState(true);
  const [FechaNacimientoItem, setFechaNacimientoItem] = useState<string>(moment(Ent.FechaNacimiento).format('DD/MM/YYYY hh:mm'));
  const dateFormat = 'YYYY/MM/DD';





  const [optionsTipoDocumentoIdentidad, setOptionsTipoDocumentoIdentidad] = useState<EntListaModel[]>([]);
  const [optionsSexo, setOptionsSexo] = useState<EntListaModel[]>([]);
  const [optionsEstadoCivil, setOptionsEstadoCivil] = useState<EntListaModel[]>([]);
  const [optionsUbigeo, setOptionsUbigeo] = useState<UbigeoEntity[]>([]);


  const handleSearchUbigeo = async (value: string) => {
    try {
      const response = await sGeneralService.GetUbigeoItemLikeApi(value);
      setOptionsUbigeo(response);
      console.log(response)
    } catch (error) {
      console.error('Error al buscar Ubigeo:', error);
    }
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

  const onChangeDate: DatePickerProps['onChange'] = (date, dateString) => {
    date;
    setFechaNacimientoItem(dateString);
  };
  const [selectedTipoDocuemntoIdentidad, setSelectedTipoDocuemntoIdentidad] = useState<number | undefined>(undefined);
  const [selectedSexo, setSelectedSexo] = useState<number | undefined>(undefined);
  const [selectedEstadoCivil, setSelectedEstadoCivil] = useState<number | undefined>(undefined);
  const [selectedUbigeo, setselectedUbigeo] = useState<number | undefined>(undefined);

  const [ValTipoDocuemntoIdentidad, setValTipoDocuemntoIdentidad] = useState<InputStatus>('');
  const [ValNumDocumento] = useState<InputStatus>('');
  const [ValNombres] = useState<InputStatus>('');
  const [ValApellidoPaterno] = useState<InputStatus>('');
  const [ValApellidoMaterno] = useState<InputStatus>('');
  const [ValCodigo, setValCodigo] = useState<InputStatus>('');
  const [ValUbigeo, setValUbigeo] = useState<InputStatus>('');
  const [ValDireccion] = useState<InputStatus>('');
  const [ValTelefono] = useState<InputStatus>('');
  const [ValCorreo] = useState<InputStatus>('');
  const [ValSexo, setValSexo] = useState<InputStatus>('');
  const [ValEstadoCivil, setValEstadoCivil] = useState<InputStatus>('');

  const onChangeTipoDocuemntoIdentidad = async (value: number) => {
    ValCodigo;
    setValTipoDocuemntoIdentidad('');
    Ent.TipoDocumentoIdentidadId = value;
    setSelectedTipoDocuemntoIdentidad(value)
    console.log(value)
  };

  const onChangeSexo = async (value: number) => {
    setValSexo('');
    Ent.SexoId = value;
    setSelectedSexo(value)
  };


  const onChangeEstadoCivil = async (value: number) => {
    setValEstadoCivil('');
    Ent.EstadoCivilId = value;
    setSelectedEstadoCivil(value)
  };


  const onChangeUbigeo = async (value: number) => {
    setValUbigeo('');
    Ent.UbigeoId = value;
    setselectedUbigeo(value)
  };






  const [modal, contextHolder] = Modal.useModal();
  const [messageAdd, contextHolderAdd] = message.useMessage();
  const AddPersonaNatural = async () => {
    const savedItem = await sPersonaNatural.Registrar(Ent);
    console.log(savedItem);
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
    selectedTipoDocuemntoIdentidad;
    selectedSexo;
    selectedEstadoCivil;
    selectedUbigeo;

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

        const fecha: Date = new Date(FechaNacimientoItem + "T00:00:00");
        Ent.FechaNacimiento = new Date(fecha);
        Ent.CodUsuario = "adm";
        Ent.FechaRegistro = new Date();

        Ent.Action = Ent.PersonaNaturalId == 0 ? 1 : 3;

        AddPersonaNatural();

      },
      onCancel() {
        console.log('Cancel');
      },
    });

  };


  const getCargarDatos = async () => {


    const Resp_UM = await sEntLista.getItems('C0012');
    const Resp_Sexo = await sEntLista.getItems('C0008');
    const Resp_EC = await sEntLista.getItems('C0009');

    setOptionsTipoDocumentoIdentidad(Resp_UM);
    setOptionsSexo(Resp_Sexo);
    setOptionsEstadoCivil(Resp_EC);

    const dateFN = moment(new Date()).format('YYYY-MM-DD')
    setFechaNacimientoItem(dateFN);
    
    console.log(idNumero)
    if (idNumero > 0) {

      const Resp_PersonaNatural = await sPersonaNatural.ObtenerItem(idNumero);
      setEnt(Resp_PersonaNatural[0]);


      if (Resp_PersonaNatural[0].UbigeoId != null) {
        const Resp_Ubigeo = await sGeneralService.GetUbigeoItemApi(Resp_PersonaNatural[0].UbigeoId);

        setOptionsUbigeo(Resp_Ubigeo);
      }
      if (Resp_PersonaNatural[0].FechaNacimiento != null) {

        const dateFNC = moment(Resp_PersonaNatural[0].FechaNacimiento).format('YYYY-MM-DD')
        setFechaNacimientoItem(dateFNC);
      }




    }

    setCargarPage(false);
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
          {/* <Title level={3}> PersonaNatural  {params.Id}</Title> */}
          <Title level={3}> {Ent.PersonaNaturalId > 0 ? 'PersonaNatural' : 'Agregar PersonaNatural'}</Title>
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
            <Col span={12}>
              <Row>
                <Col span={24}>
                  <label>Tipo Documento</label>
                </Col>
                <Col span={24}>
                  <Select
                    status={ValTipoDocuemntoIdentidad}
                    allowClear
                    style={{ width: '100%', marginTop: '5px', marginBottom: '10px' }}
                    defaultActiveFirstOption={false}
                    filterOption={false}
                    optionFilterProp="children"
                    value={Ent.TipoDocumentoIdentidadId === 0 ? null : Ent.TipoDocumentoIdentidadId}
                    key={Ent.TipoDocumentoIdentidadId}
                    onChange={onChangeTipoDocuemntoIdentidad}
                  >
                    {optionsTipoDocumentoIdentidad.map((row) => (
                      <Select.Option key={row.ListaId} value={row.ListaId}>
                        {row.Nombre}
                      </Select.Option>
                    ))}
                  </Select>

                </Col>
              </Row>

            </Col>
            <Col span={12}>
              <Row>
                <Col span={24}>
                  <label>Numero</label>
                </Col>
                <Col span={24}>
                  <Input
                    status={ValNumDocumento}
                    type="text"
                    name="NumDocumento"
                    style={{ marginTop: '5px', marginBottom: '10px' }}
                    onChange={onChangeText}
                    value={Ent.NumDocumento === null ? "" : Ent.NumDocumento}
                  />
                </Col>
              </Row>
            </Col>
          </Row>

          <Row>
            <Col span={24}>
              <label>Nombres</label>
            </Col>
            <Col span={24}>
              <Input
                status={ValNombres}
                type="text"
                name="Nombres"
                style={{ marginTop: '5px', marginBottom: '10px' }}
                onChange={onChangeText}
                value={Ent.Nombres === null ? "" : Ent.Nombres}
              />
            </Col>
          </Row>







          <Row>
            <Col span={12}>
              <Row>
                <Col span={24}>
                  <label>Apellido Paterno</label>
                </Col>
                <Col span={24}>
                  <Input
                    status={ValApellidoPaterno}
                    type="text"
                    name="ApellidoPaterno"
                    style={{ marginTop: '5px', marginBottom: '10px' }}
                    onChange={onChangeText}
                    value={Ent.ApellidoPaterno === null ? "" : Ent.ApellidoPaterno}
                  />
                </Col>
              </Row>

            </Col>
            <Col span={12}>
              <Row>
                <Col span={24}>
                  <label>Apellido Materno</label>
                </Col>
                <Col span={24}>
                  <Input
                    status={ValApellidoMaterno}
                    type="text"
                    name="ApellidoMaterno"
                    style={{ marginTop: '5px', marginBottom: '10px' }}
                    onChange={onChangeText}
                    value={Ent.ApellidoMaterno === null ? "" : Ent.ApellidoMaterno}
                  />
                </Col>
              </Row>
            </Col>
          </Row>












          <Row>
            <Col span={12}>
              <Row>
                <Col span={24}>
                  <label>Fecha de Nacimiento</label>
                </Col>
                <Col span={24}>
                  <DatePicker
                    onChange={onChangeDate}
                    value={dayjs(FechaNacimientoItem, dateFormat)}
                    // defaultValue={dayjs(FechaEmisionItem, dateFormat)}
                    style={{ marginTop: '5px', marginBottom: '10px', width: '100%' }}
                  />

                </Col>
              </Row>

            </Col>



            <Col span={12}>
              <Row>
                <Col span={24}>
                  <label>Telefono</label>
                </Col>
                <Col span={24}>
                  <Input
                    type="text"
                    name="Telefono"
                    status={ValTelefono}
                    style={{ marginTop: '5px', marginBottom: '10px' }}
                    onChange={onChangeText}
                    value={Ent.Telefono === null ? "" : Ent.Telefono}
                  />

                </Col>
              </Row>

            </Col>
          </Row>




          <Row>
            <Col span={24}>
              <label>Correo</label>
            </Col>
            <Col span={24}>
              <Input
                type="text"
                name="Correo"
                status={ValCorreo}
                style={{ marginTop: '5px', marginBottom: '10px' }}
                onChange={onChangeText}
                value={Ent.Correo === null ? "" : Ent.Correo}
              />

            </Col>
          </Row>





          <Row>
            <Col span={12}>
              <Row>
                <Col span={24}>
                  <label>Sexo</label>
                </Col>
                <Col span={24}>
                  <Select
                    status={ValSexo}
                    allowClear
                    style={{ width: '100%', marginTop: '5px', marginBottom: '10px' }}
                    defaultActiveFirstOption={false}
                    filterOption={false}
                    value={Ent.SexoId === 0 ? null : Ent.SexoId}
                    key={Ent.SexoId}
                    onChange={onChangeSexo}
                  >
                    {optionsSexo.map((row) => (
                      <Select.Option key={row.ListaId} value={row.ListaId}>
                        {row.Nombre}
                      </Select.Option>
                    ))}
                  </Select>

                </Col>
              </Row>
            </Col>
            <Col span={12}>
              <Row>
                <Col span={24}>
                  <label>Estado Civil</label>
                </Col>
                <Col span={24}>
                  <Select
                    status={ValEstadoCivil}
                    allowClear
                    style={{ width: '100%', marginTop: '5px', marginBottom: '10px' }}
                    defaultActiveFirstOption={false}
                    filterOption={false}
                    value={Ent.EstadoCivilId === 0 ? null : Ent.EstadoCivilId}
                    key={Ent.EstadoCivilId}
                    onChange={onChangeEstadoCivil}
                  >
                    {optionsEstadoCivil.map((row) => (
                      <Select.Option key={row.ListaId} value={row.ListaId}>
                        {row.Nombre}
                      </Select.Option>
                    ))}
                  </Select>

                </Col>
              </Row>
            </Col>
          </Row>





          <Row>
            <Col span={24}>
              <label>Ubigeo</label>
            </Col>
            <Col span={24}>
              <Select className="custom-select"
                status={ValUbigeo}
                showSearch
                style={{ width: '100%', marginTop: '5px', marginBottom: '10px' }}
                defaultActiveFirstOption={false}
                filterOption={false}
                onSearch={handleSearchUbigeo}
                value={Ent.UbigeoId === 0 ? null : Ent.UbigeoId}
                key={Ent.UbigeoId}
                onChange={onChangeUbigeo}
              >
                {optionsUbigeo.map((row) => (
                  <Select.Option className="custom-option" key={row.UbigeoId} value={row.UbigeoId}>
                    {row.DesUbigeo}
                  </Select.Option>
                ))}
              </Select>

            </Col>
          </Row>


          <Row>
            <Col span={24}>
              <label>Dirección</label>
            </Col>
            <Col span={24}>
              <Input
                type="text"
                name="Direccion"
                status={ValDireccion}
                style={{ marginTop: '5px', marginBottom: '10px' }}
                onChange={onChangeText}
                value={Ent.Direccion === null ? "" : Ent.Direccion}
              />
            </Col>
          </Row>





        </Col>

        <Col xs={24} sm={14} md={16} lg={17} xl={18}>

        </Col>
      </Row>
    </Spin>
  );
};


export default Save;