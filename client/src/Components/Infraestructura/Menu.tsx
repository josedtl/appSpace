import React, { useEffect, useState } from 'react';
import { GoldOutlined, BookOutlined, UserOutlined } from '@ant-design/icons';
import { Avatar } from 'antd';
import { Col, Row, Typography, Card, Button, Spin, Input, Flex, Segmented } from 'antd';
import { Link } from "react-router-dom";

function Menu() {
    const [CargarPage, setCargarPage] = React.useState(true);
    const { Title } = Typography;
    useEffect(() => {
        setCargarPage(false);
    }, []);
    return (
        <Spin spinning={CargarPage} tip="Cargando" size="large">
            <Row>

                <Col xs={24}>
                    <Title level={2}> Recurso</Title>
                </Col>


                <Col xs={24}>
                    <Flex gap="small" align="flex-start" vertical>
                        <Segmented
                            options={[
                                {
                                    label: (
                                        <div style={{ padding: 4 }}>
                                            <Link to={`/Infraestructura`}>
                                                <Avatar
                                                    style={{ backgroundColor: '#f56a00' }}
                                                    size={170}
                                                    icon={<GoldOutlined />}
                                                />
                                            </Link>
                                            <div>InfraEstructura</div>
                                        </div>
                                    ),
                                    value: 'user1',
                                },
                                // {
                                //     label: (
                                //         <div style={{ padding: 4 }}>
                                //             <Avatar style={{ backgroundColor: '#f56a00' }}>K</Avatar>
                                //             <div>User 2</div>
                                //         </div>
                                //     ),
                                //     value: 'user2',
                                // },
                                // {
                                //     label: (
                                //         <div style={{ padding: 4 }}>
                                //             <Avatar style={{ backgroundColor: '#87d068' }} icon={<UserOutlined />} />
                                //             <div>User 3</div>
                                //         </div>
                                //     ),
                                //     value: 'user3',
                                // },
                            ]}
                        />

                    </Flex>

                </Col>
                <Col xs={24}>
                    <Title level={3}> Enlace</Title>
                </Col>
                <Col xs={24}>
                    <Flex gap="small" align="flex-start" vertical>
                        <Segmented
                            options={[
                                {
                                    label: (
                                        <div style={{ padding: 4 }}>

                                            <Link to={`/Infraestructura/Enlace/0001`}>
                                                <Avatar
                                                    style={{ backgroundColor: '#f56a00' }}
                                                    size={150}
                                                    icon={<BookOutlined />}
                                                />
                                            </Link>
                                            <div>Sucursal</div>
                                        </div>
                                    ),
                                    value: 'Categoria',
                                },
                                {
                                    label: (
                                        <div style={{ padding: 4 }}>

                                            <Link to={`/Infraestructura/Enlace/0006`}>
                                                <Avatar
                                                    size={150}
                                                    style={{ backgroundColor: '#f56a00' }}
                                                    icon={<BookOutlined />}
                                                />
                                            </Link>
                                            <div>Tipo de Infraestructura</div>
                                        </div>
                                    ),
                                    value: 'TipoInfraestructura',
                                },
                                {
                                    label: (
                                        <div style={{ padding: 4 }}>

                                            <Link to={`/Infraestructura/Enlace/0007`}>
                                                <Avatar
                                                    size={150}
                                                    style={{ backgroundColor: '#f56a00' }}
                                                    icon={<BookOutlined />}
                                                />
                                            </Link>
                                            <div>Dimension</div>
                                        </div>
                                    ),
                                    value: 'Dimension',
                                },
                                {
                                    label: (
                                        <div style={{ padding: 4 }}>

                                            <Link to={`/Infraestructura/Enlace/0013`}>
                                                <Avatar
                                                    size={150}
                                                    style={{ backgroundColor: '#f56a00' }}
                                                    icon={<BookOutlined />}
                                                />
                                            </Link>
                                            <div>Clasificación</div>
                                        </div>
                                    ),
                                    value: 'Clasificacion',
                                },
                                {
                                    label: (
                                        <div style={{ padding: 4 }}>

                                            <Link to={`/Infraestructura/Enlace/0009`}>
                                                <Avatar
                                                    size={150}
                                                    style={{ backgroundColor: '#f56a00' }}
                                                    icon={<BookOutlined />}
                                                />
                                            </Link>
                                            <div>Piso</div>
                                        </div>
                                    ),
                                    value: 'Piso',
                                },
                            ]}
                        />

                    </Flex>



                </Col>

            </Row>

        </Spin>


    )
}

export default Menu;