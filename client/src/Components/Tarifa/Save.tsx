import { Row, Col, Typography, Button, Select, Input, DatePicker, Radio, InputNumber } from 'antd';
import { SaveFilled } from '@ant-design/icons';
import { ButtonAddMain } from '../../Styles/Button'
import type { RadioChangeEvent } from 'antd';
import React, { useState } from 'react';
import { TarifaMainEntity } from '../../Models/TarifaEntity';

const Save = () => {
    const [value, setValue] = useState(1);

    const initialTarifaMain = new TarifaMainEntity();
    const [Ent, setEnt] = useState<TarifaMainEntity>(initialTarifaMain);
    const [FlaNumero, setNumeroState] = useState<number>(0);

    const onChange = (e: RadioChangeEvent) => {
        setNumeroState(e.target.value);

    };


    const onChangeText = (e: React.ChangeEvent<HTMLInputElement>) => {
        setEnt({
            ...Ent,
            [e.target.name]: e.target.value.toUpperCase()
        });

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
                                    <Radio value={1} onChange={onChange}   >Infraestructura</Radio>
                                    <Radio value={2} onChange={onChange}   >Servicio</Radio>
                                    <Radio value={3} onChange={onChange}  >Producto</Radio>
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
                                showSearch
                                style={{ width: '100%', marginTop: '5px', marginBottom: '10px' }}
                                defaultActiveFirstOption={false}
                                filterOption={false}
                            >
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
                                name="NombreComercial"
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
                        <Col span={12}>
                            <Row>
                                <Col span={24}>
                                    <label>Unidad de Medida</label>
                                </Col>
                                <Col span={24}>
                                    <Select
                                        allowClear
                                        style={{ width: '100%', marginTop: '5px', marginBottom: '10px' }}
                                        defaultActiveFirstOption={false}
                                        filterOption={false}
                                    >
                                    </Select>
                                </Col>
                            </Row>
                        </Col>

                        <Col span={12}>
                            <Row>
                                <Col span={24}>
                                    <label>Moneda</label>
                                </Col>
                                <Col span={24}>
                                    <InputNumber
                                        style={{ width: '100%', marginTop: '5px', marginBottom: '10px' }}
                                        min={1} max={10} defaultValue={1} />
                                </Col>
                            </Row>
                        </Col>

                    </Row>
                    <Row>
                        <Col span={24}>
                            <Row>
                                <Col span={24}>
                                    <label>Costo</label>
                                </Col>
                                <Col span={24}>

                                    <InputNumber<string>
                                        style={{ width: 200 }}
                                        defaultValue="1"
                                        min="0"
                                        max="100"
                                        step="0.50"
                                        stringMode
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