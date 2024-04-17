import { Row, Col, Typography, Button, Select, Input, DatePicker, Radio, InputNumber, InputNumberProps } from 'antd';
import { SaveFilled } from '@ant-design/icons';
import { ButtonAddMain } from '../../Styles/Button';
import React, { useEffect, useState } from 'react';
import { ServicioMainEntity, ServicioSaveEntity, ServicioEntity } from '../../Models/ServicioEntity';
import type { InputStatus } from 'antd/lib/_util/statusUtils'
import { ServListaMainEntity, ServListaSaveEntity, ServListaEntity } from '../../Models/ServListaEntity';
import ServListaService from '../../Service/ServListaService';

import ServicioService from '../../Service/ServicioService';

const Save = () => {

    const [value, setValue] = useState(1);
    const sServLista = new ServListaService();
    const sServicio = new ServicioService();

    const initialServicioSave = new ServicioSaveEntity();
    const [Ent, setEnt] = useState<ServicioSaveEntity>(initialServicioSave);


    const [selectedServLista, setSelectedServLista] = useState<number | undefined>(undefined);
    const [ValServLista, setValServLista] = useState<InputStatus>('');
    const [ValCodigo, setValCodigo] = useState<InputStatus>('');
    const [ValCosto] = useState<InputStatus>('');
    const [optionsServListaMain, setOptionsServListaMain] = useState<ServListaEntity[]>([]);

    const onChangeServLista = async (value: number) => {
        ValCodigo;
        setValServLista('');
        Ent.TipoServicioId = value;
        setSelectedServLista(value)
        console.log(value)
    };

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

        getCargarDatos();
    }, []);

    async function getCargarDatos() {
        const sltServLista = await sServLista.ObtenerMain();

        setOptionsServListaMain(sltServLista);
    }
    const { Title } = Typography;
    return (
        <>
            <Row>
                <Col xs={24} sm={24} md={12} lg={12} xl={12}>
                    {/* <Title level={3}> PersonaNatural  {params.Id}</Title> */}
                    <Title level={3}>Servicio</Title>
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

                    {/* <Row>
                        <Col span={24}>
                            <label>Buscar</label>
                        </Col>
                        <Col span={24}>
                            <Select className="custom-select"
                                status={ValRecurso}
                                showSearch
                                style={{ width: '100%', marginTop: '5px', marginBottom: '10px' }}
                                defaultActiveFirstOption={false}
                                filterOption={false}
                                onSearch={handleSearchBuscarRecurso}
                                value={Ent.ObjetoReferenciaId === 0 ? null : Ent.ObjetoReferenciaId}
                                key={Ent.ObjetoReferenciaId}
                                onChange={onChangeRecurso}

                            >{OptionRecurso.map((row) => (
                                <Select.Option className="custom-option" key={row.ObjetoReferenciaId} value={row.ObjetoReferenciaId}>
                                    {row.NomCompleto}
                                </Select.Option>
                            ))}
                            </Select>

                        </Col>
                    </Row> */}

                    <Row>
                        <Col span={24}>
                            <label>Servicio</label>
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




                </Col>

                <Col xs={24} sm={14} md={16} lg={17} xl={18}>

                </Col>
            </Row>

        </>

    )
};


export default Save;