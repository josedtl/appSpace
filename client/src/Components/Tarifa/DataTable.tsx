
import React from 'react';
import { PropsTable } from '../../Lib/PropsItem'
import type { SizeType } from 'antd/es/config-provider/SizeContext';
import type { ColumnsType } from 'antd/es/table';
import { DataType } from '../../Lib/ResourceModel/DataTableType'
import { TarifaMainEntity} from '../../Models/TarifaEntity';
import moment from 'moment';
import { Card, Col, Row, Button, Table } from 'antd';
import { Link } from 'react-router-dom';
import { EditFilled } from '@ant-design/icons';

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
            title: 'Nombre',
            dataIndex: 'NomComercial',
            key: 'NomComercial',
        },
       
        {
            title: 'UM',
            dataIndex: 'CodigoUnidad',
            key: 'CodigoUnidad',
        },
        {
            title: 'Moneda',
            dataIndex: 'SimboloMoneda',
            key: 'SimboloMoneda',
        },
        {
            title: 'CostoTarifa',
            dataIndex: 'CostoTarifa',
            key: 'CostoTarifa',
        },
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
            render: (record: TarifaMainEntity) => (
                <span>

                    <Link to=''>
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

 
    return (

      <>
        <Table
                    columns={columns}
                    dataSource={props.DataList}
                    size="small"
                    scroll={{ x: 'calc(700px + 50%)', y: '100%' }}
                />
      </>

    );
}

 export default DataTable;