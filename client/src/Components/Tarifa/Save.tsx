import { Row, Col, Typography, Button, Select, Input, Radio } from 'antd';
import { SaveFilled } from '@ant-design/icons';
import { ButtonAddMain } from '../../Styles/Button'
import type { RadioChangeEvent } from 'antd';
import React, { useEffect, useState } from 'react';
import { TarifaSaveModel, TarifaBuscarRecursoModel} from '../../Models/TarifaEntity';
import type { InputStatus } from 'antd/lib/_util/statusUtils'
import { UnidadMedidaModel } from '../../Models/UnidadMedidaEntity';
import { MonedaModel } from '../../Models/MonedaModel';
import GeneralService from '../../Service/GeneralService';

import TarifaService from '../../Service/TarifaService';


const Save = () => {
    const [value, setValue] = useState(1);
    const sGeneral = new GeneralService();
    const sTarifa = new TarifaService();

    const initialTarifaMain = new TarifaSaveModel();
    const [Ent, setEnt] = useState<TarifaSaveModel>(initialTarifaMain);
    const [FlaNumero, setNumeroState] = useState<number>(0);
    const [selectedUnidadMedida, setSelectedUnidadMedida] = useState<number | undefined>(undefined);
    const [ValUnidadMedida, setValUnidadMedida] = useState<InputStatus>('');
    const [selectedMoneda, setSelectedMoneda] = useState<number | undefined>(undefined);
    const [ValMoneda, setValMoneda] = useState<InputStatus>('');

    const [ValCodigo, setValCodigo] = useState<InputStatus>('');
    const [ValCosto] = useState<InputStatus>('');

    const [OptionMoneda, setOptionsMoneda] = useState<MonedaModel[]>([]);
    const [optionsUnidadMedida, setOptionsUnidadMedida] = useState<UnidadMedidaModel[]>([]);

    const [ValRecurso, setValRecurso] = useState<InputStatus>('');
    const [selectedRecurso, setSelectedRecurso] = useState<number | undefined>(undefined);
    const [OptionRecurso, setOptionsRecurso] = useState<TarifaBuscarRecursoModel[]>([]);

    const onChange = (e: RadioChangeEvent) => {
        setNumeroState(e.target.value);

    };

    const onChangeRecurso = async (value: number) => {
        setValRecurso('');
        Ent.ObjetoReferenciaId = value;
        setSelectedRecurso(value)
    };


    const onChangeUnidadMedida = async (value: number) => {
        ValCodigo;
        setValUnidadMedida('');
        Ent.UnidadMedidaId = value;
        setSelectedUnidadMedida(value)
        console.log(value)
    };
    const onChangeMoneda = async (value: number) => {
        ValCodigo;
        setValMoneda('');
        Ent.MonedaId = value;
        setSelectedMoneda(value)
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
        selectedUnidadMedida;

        console.log(Ent);
        const response = sTarifa.Registrar(Ent);
        console.log(response);


    };

    useEffect(() => {

        getCargarDatos();
    }, []);

    async function getCargarDatos() {
        const sltUnidadMedida = await sGeneral.ObtenerUnidadMedidaItems();
        const sltMoneda = await sGeneral.ObtenerMonedaItems();

        setOptionsMoneda(sltMoneda);

        setOptionsUnidadMedida(sltUnidadMedida);
        console.log(sltUnidadMedida);
    }

    const handleSearchBuscarRecurso = async (value: string) => {
        try {
            const response = await sTarifa.BuscarRecurso(value, FlaNumero);
            setOptionsRecurso(response);
            console.log(response)
        } catch (error) {
            console.error('Error al buscar Ubigeo:', error);
        }
    };


    const { Title } = Typography;
    return (
        <>
            <Row>
                <Col xs={24} sm={24} md={12} lg={12} xl={12}>
                    {/* <Title level={3}> PersonaNatural  {params.Id}</Title> */}
                    <Title level={3}>Tarifa</Title>
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

                                <Radio.Group
                                    style={{ marginTop: '5px', marginBottom: '10px' }}>
                                    <Radio value={0} onChange={onChange}   >Servicio</Radio>
                                    <Radio value={1} onChange={onChange}   >Infraestructura</Radio>
                                </Radio.Group>


                            </Row>
                        </Col>

                    </Row>


                    <Row>
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
                    </Row>

                    <Row>
                        <Col span={24}>
                            <label>Nombre Comercial</label>
                        </Col>
                        <Col span={24}>
                            <Input
                                type="text"
                                name="NomComercial"
                                style={{ marginTop: '5px', marginBottom: '10px' }}
                                onChange={onChangeText}
                                value={Ent.NomComercial === null ? "" : Ent.NomComercial}
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
                    </Row>
                    <Row>
                        <Col span={12}>
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
                                        value={Ent.MonedaId === 0 ? null : Ent.MonedaId}
                                        key={Ent.MonedaId}
                                        onChange={onChangeMoneda}
                                    >
                                        {OptionMoneda.map((row) => (
                                            <Select.Option key={row.MonedaId} value={row.MonedaId}>
                                                {row.Simbolo}
                                            </Select.Option>
                                        ))}
                                    </Select>
                                </Col>
                            </Row>
                        </Col>
                        <Col span={12}>
                            <Row>
                                <Col span={24}>
                                    <label>Costo</label>
                                </Col>
                                <Col span={24}>
                                    <Input
                                        status={ValCosto}
                                        type="Number"
                                        name="CostoTarifa"
                                        min="0"
                                        style={{ marginTop: '5px', marginBottom: '10px' }}
                                        onChange={onChangeText}
                                        value={Ent.CostoTarifa === null ? "" : Ent.CostoTarifa}
                                    />
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




}
export default Save;