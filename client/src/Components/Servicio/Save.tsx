import { Row, Col, Typography, Button, Select, Input, DatePicker, Radio, InputNumber, InputNumberProps,Modal,message } from 'antd';
import { SaveFilled } from '@ant-design/icons';
import { ButtonAddMain } from '../../Styles/Button';
import React, { useEffect, useState } from 'react';
import { ServicioMainEntity, ServicioSaveEntity, ServicioEntity } from '../../Models/ServicioEntity';
import type { InputStatus } from 'antd/lib/_util/statusUtils'
import { ServListaMainModel, ServListaSaveModel, ServListaModel } from '../../Models/ServListaEntity';
import ServListaService from '../../Service/ServListaService';
import { useParams } from 'react-router-dom';
import ServicioService from '../../Service/ServicioService';
import moment from 'moment';
const Save = () => {

    const [value, setValue] = useState(1);
    const { Id } = useParams();
    const idNumero = Number(Id?.toString());
    const sServLista = new ServListaService();
    const sServicio = new ServicioService();
    const initialServicioSave = new ServicioSaveEntity();
    const [Ent, setEnt] = useState<ServicioSaveEntity>(initialServicioSave);
    const [FechaRegistroItem, setFechaNacimientoItem] = useState<string>(moment(Ent.FechaRegistro).format('DD/MM/YYYY hh:mm'));
    const dateFormat = 'YYYY/MM/DD';
    const [CargarPage, setCargarPage] = React.useState(true);

    const [selectedServLista, setSelectedServLista] = useState<number | undefined>(undefined);
    const [ValServLista, setValServLista] = useState<InputStatus>('');
    const [ValCodigo, setValCodigo] = useState<InputStatus>('');
    const [ValCosto] = useState<InputStatus>('');
    const [optionsServListaMain, setOptionsServListaMain] = useState<ServListaModel[]>([]);

    const onChangeServLista = async (value: number) => {
        ValCodigo;
        setValServLista('');
        Ent.TipoServicioId = value;
        setSelectedServLista(value)
        console.log(value)
    };
    const [modal, contextHolder] = Modal.useModal();
    const [messageAdd, contextHolderAdd] = message.useMessage();


    const onChangeText = (e: React.ChangeEvent<HTMLInputElement>) => {
        setEnt({
            ...Ent,
            [e.target.name]: e.target.value.toUpperCase()
        });

    };
    const Guardar_Total = async (e: React.MouseEvent<HTMLButtonElement>) => {

        e.preventDefault();
        selectedServLista;

        console.log(Ent);
        const response = sServicio.Registrar(Ent);
        console.log(response);

    };
    useEffect(() => {

        // console.log(idNumero);
        getCargarDatos();

    }, []);

    async function getCargarDatos() {
        setCargarPage(true);

        const sltTipoServicio = await sServLista.ObtenerItemCodigo('C004');
        setOptionsServListaMain(sltTipoServicio);

        if (idNumero > 0) {
            const ItemCabecera = await sServicio.ObtenerItem(idNumero);
            setEnt(ItemCabecera[0]);

            const dateFNC = moment(ItemCabecera[0].FechaRegistro).format('YYYY-MM-DD')
            setFechaNacimientoItem(dateFNC);

        }
        


        setCargarPage(false);
    }
    const { Title } = Typography;
    return (
        <>
       
      {contextHolder}
      {contextHolderAdd}
            <Row>
                <Col xs={24} sm={24} md={12} lg={12} xl={12}>
                    <Title level={3}> {Ent.ServicioId > 0 ? 'Servicio' : 'Agregar Servicio'}</Title>
                </Col>
                <Col xs={24} sm={24} md={12} lg={12} xl={12}>
                    <Button
                        style={ButtonAddMain}
                        size={"large"}
                        icon={<SaveFilled />}
                        onClick={Guardar_Total}
                    />

                </Col>
            </Row>

            <Row>
                <Col xs={24} sm={10} md={8} lg={7} xl={6}>

                    <Row>
                        <Col span={24}>
                            <Row>
                                <Col span={24}>
                                    <label>Tipo de Servicio</label>
                                </Col>
                                <Col span={24}>
                                    <Select
                                        status={ValServLista}
                                        allowClear
                                        style={{ width: '100%', marginTop: '5px', marginBottom: '10px' }}
                                        defaultActiveFirstOption={false}
                                        filterOption={false}
                                        value={Ent.TipoServicioId === 0 ? null : Ent.TipoServicioId}
                                        key={Ent.TipoServicioId}
                                        onChange={onChangeServLista}
                                    >

                                        {optionsServListaMain.map((row) => (
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
                            <label>Nombre</label>
                        </Col>
                        <Col span={24}>
                            <Input
                                type="text"
                                name="Nombre"
                                style={{ marginTop: '5px', marginBottom: '10px' }}
                                onChange={onChangeText}
                                value={Ent.Nombre === null ? "" : Ent.Nombre}
                            />
                        </Col>
                    </Row>
                    <Row>
                        <Col span={24}>
                            <label>Descripcion</label>
                        </Col>
                        <Col span={24}>
                            <Input
                                type="text"
                                name="Descripcion"
                                style={{ marginTop: '5px', marginBottom: '10px' }}
                                onChange={onChangeText}
                                value={Ent.Descripcion === null ? "" : Ent.Descripcion}
                            />
                        </Col>
                    </Row>




                </Col>

                <Col xs={24} sm={14} md={16} lg={17} xl={18}>

                </Col>
            </Row>

        </>

    )
};


export default Save;