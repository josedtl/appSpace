"use client"
import React from 'react';
import { EditFilled } from '@ant-design/icons';
import type { SizeType } from 'antd/es/config-provider/SizeContext';
import { Link } from 'react-router-dom';
import { PropsTable } from '../../Lib/PropsItem'
import { Card, Col, Row, Button, Table } from 'antd';
import type { ColumnsType } from 'antd/es/table';
import moment from 'moment';
import 'moment/locale/es';
import { DataType } from '../../Lib/ResourceModel/DataTableType'
import { InfraestructuraMainModel } from '../../Models/InfraestructuraEntity';

const DataTable: React.FC<PropsTable> = (props) => {
    const [size] = React.useState<SizeType>('middle');
    const columns: ColumnsType<DataType> = [
        {
            title: 'Nº',
            dataIndex: 'Cont',
            width: '50px',
            key: 'Cont',
        },
        {
            title: 'CodigoSistema',
            dataIndex: 'CodigoSistema',
            key: 'CodigoSistema',
            width: 150
        },
        {
            title: 'CodigoInterno',
            dataIndex: 'CodigoInterno',
            key: 'CodigoInterno',
            width: 150
        },

        {
            title: 'TipoInfraestructura',
            dataIndex: 'TipoInfraestructura',
            key: 'TipoInfraestructura',
            width: 150
        },
        {
            title: 'Clasificacion',
            dataIndex: 'Clasificacion',
            key: 'Clasificacion',
            width: 150
        },
        {
            title: 'InfraestructuraDimension',
            dataIndex: 'InfraestructuraDimension',
            key: 'InfraestructuraDimension',
            width: 150
        },
        {
            title: 'Aforo',
            dataIndex: 'Aforo',
            key: 'Aforo',
            width: 150
        },
        {
            title: 'Piso',
            dataIndex: 'Piso',
            key: 'Piso',
            width: 150
        },
        // {
        //     title: 'Descripcion',
        //     dataIndex: 'Descripcion',
        //     key: 'Descripcion',
        //     width: 300
        // },
        {
            title: 'Fecha de registro',
            dataIndex: 'FechaRegistro',
            width: '150px',
            key: 'FechaRegistro',
            render: (date: string) => moment(date).format('DD/MM/YYYY hh:mm'),

        },
        {
            title: 'Usuario',
            dataIndex: 'CodUsuario',
            width: '100px',
            key: 'CodUsuario',
        }, {
            title: 'Action',
            fixed: 'right',
            width: 70,
            key: 'action',
            render: (record: InfraestructuraMainModel) => (
                <span>

                    <Link to={`/InfraestructuraSave/${record.InfraestructuraId}`}>
                        <Button
                            type='dashed'
                            style={{ float: "right", marginRight: "10px", color: "#BB9B32", backgroundColor: "white", borderColor: "#BB9B32" }}
                            size={size}
                            icon={<EditFilled />}
                        >


                        </Button>
                    </Link>


                </span>
            ),
        },

    ];

    const dataWithKeys = props.DataList.sort((a, b) => b.InfraestructuraId - a.InfraestructuraId).map((item, zIndex) => {
        return {
            ...item,
            key: item.InfraestructuraId,
            Cont: (zIndex + 1)
        };
    });



    const ListaCard = () => {
        if (props.EsTabla) {

            return (
                <>
                    <Row gutter={16} style={{ backgroundColor: '#FAFAFA' }} >
                        {dataWithKeys.map(row => (

                            <Col key={row.Cont} xs={24} md={12} lg={8} xl={6} xxl={4}>
                                <Card hoverable={true}

                                    style={{ marginTop: '10Px', }}
                                    actions={[
                                        <Link to={`/ProductoSave/${row.ProductoId}`}>
                                            <EditFilled
                                                style={{ color: "#BB9B32" }}
                                            />
                                        </Link>
                                    ]}
                                    bordered={false}>
                                    {row.Cont + ".  "}   {row.Nombre}
                                </Card>

                            </Col>


                        ))}
                    </Row>

                </>
            )
        } else {
            return (
                <Table
                    columns={columns}
                    dataSource={dataWithKeys}
                    size="small"
                    scroll={{ x: 'calc(700px + 50%)', y: '100%' }}
                />
            )
        }

    }
    return (

        <div>

            {ListaCard()}
        </div>

    );
}

export default DataTable;

