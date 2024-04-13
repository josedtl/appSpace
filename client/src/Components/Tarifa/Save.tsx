import { Row, Col, Typography, Button, Select, Input, DatePicker,Radio } from 'antd';
import { SaveFilled } from '@ant-design/icons';
import { ButtonAddMain } from '../../Styles/Button'

const Save = () => {
    const { Title } = Typography;
    return (
        <>

            <Row>
                <Col xs={24} sm={24} md={12} lg={12} xl={12}>
                    {/* <Title level={3}> PersonaNatural  {params.Id}</Title> */}
                    <Title level={3}> </Title>
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
                        <Col span={8}>
                            <Row>
                                {/* <Col span={24}>
                                </Col> */}
                                <Col span={24}>
                               
                                <Radio>Infraestructura</Radio>
                                
                                </Col>
                            </Row>
                        </Col>
                        <Col span={8}>
                            <Row>
                                {/* <Col span={24}>
                                </Col> */}
                                <Col span={24}>
                                    
                                    <Radio>Servicio</Radio>
                                </Col>
                            </Row>
                        </Col>
                        <Col span={8}>
                            <Row>
                                {/* <Col span={24}>
                                </Col> */}
                                <Col span={24}>
                             
                                <Radio>Producto</Radio>
                                </Col>
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
                            />
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
                    </Row>
                   
                </Col>

                <Col xs={24} sm={14} md={16} lg={17} xl={18}>

                </Col>
            </Row>

        </>

    )



}
export default Save;