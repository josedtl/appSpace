"use client"
import React from 'react';
import { AlquilerEntity } from '../../Models/AlquilerEntity';
import { EditFilled } from '@ant-design/icons';
import type { SizeType } from 'antd/es/config-provider/SizeContext';
import { Link } from 'react-router-dom';
import { PropsTable } from '../../Lib/PropsItem'
import { Card, Col, Row, Button, Table } from 'antd';
import type { ColumnsType } from 'antd/es/table';
import moment from 'moment';
import 'moment/locale/es';
import { DataType } from '../../Lib/ResourceModel/DataTableType'

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
            title: 'TipoTablaAlquilerId',
            dataIndex: 'TipoTablaAlquilerId',
            key: 'TipoTablaAlquilerId',
        },
        {
            title: 'TarifaId',
            dataIndex: 'TarifaId',
            key: 'TarifaId',
        },
        {
            title: 'Codigo',
            dataIndex: 'Codigo',
            key: 'Codigo',
        },
        {
            title: 'ClienteId',
            dataIndex: 'ClienteId',
            key: 'ClienteId',
        },
        {
            title: 'PrecioUnitario',
            dataIndex: 'PrecioUnitario',
            key: 'PrecioUnitario',
        },
         {
            title: 'Action',
            fixed: 'right',
            width: 70,
            key: 'action',
            render: (record: AlquilerEntity) => (
                <span>

                    <Link to={`/PersonaNaturalSave/${record.AlquilerId}`}>
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

    const dataWithKeys = props.DataList.sort((a, b) => b.AlquilerId - a.AlquilerId).map((item, zIndex) => {
        return {
            ...item,
            key: item.AlquilerId,
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
                                        <Link to={`/AlquilerSave/${row.AlquilerId}`}>
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

