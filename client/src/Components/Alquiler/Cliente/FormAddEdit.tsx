import React, { useState, useEffect } from "react";
import { Form, Select } from 'antd';
import { Button, Col, Row, Input } from 'antd';
import type { InputStatus } from 'antd/lib/_util/statusUtils'
import { PropsModel } from '../../../Lib/PropsItem'
import { ButtonAcceptModel } from '../../../Styles/Button'

//SERVICE
import MerListaService from '../../../Service/MerListaService';
import EntListaService from '../../../Service/EntListaService';
import GeneralService from '../../../Service/GeneralService';

//ENTITY
import { MerListaEntity } from '../../../Models/MerListaEntity'
import { EntListaModel } from '../../../Models/EntListaEntity';
import { EmpresaEntity } from '../../../Models/EmpresaEntity'
import { AlquilerEntity } from '../../../Models/AlquilerEntity';
import { PersonaNaturalMainModel, PersonaNaturalSaveModel } from '../../../Models/PersonaNaturalEntity';
import { TipoEntidadItemModel } from '../../../Models/GeneralEntity'

const AddEditForm: React.FC<PropsModel> = (props) => {
    const sMerLista = new MerListaService();
    const sGeneralService = new GeneralService();

    const sEntLista = new EntListaService();
    const initialMerLista = new MerListaEntity();
    const [Ent, setEnt] = useState<MerListaEntity>(initialMerLista);
    const [FlaState, setFlaState] = useState<Boolean>(false);
    const [form] = Form.useForm();
    const [ValDato, setValDato] = useState<InputStatus>('');
    const initialProducto = new PersonaNaturalSaveModel();
    const [EntPer, setEntPer] = useState<PersonaNaturalSaveModel>(initialProducto);
    const initialTipoEntidad = new TipoEntidadItemModel();
    const [EntTipoEnt, setTipoEnt] = useState<TipoEntidadItemModel>(initialTipoEntidad);

    const initialEntidad = new EmpresaEntity();
    const [EntEnt, setEntEnt] = useState<EmpresaEntity>(initialEntidad);

    const [EstadoRegistrochecked, setEstadoRegistrochecked] = useState(true);

    const [item, setItem] = useState<PersonaNaturalMainModel[]>([]);

    const [ValCodigo, setValCodigo] = useState<InputStatus>('');
    const [ValEntidad] = useState<InputStatus>('');
    const [ValNumDocumento] = useState<InputStatus>('');
    const [ValNombres] = useState<InputStatus>('');
    const [ValApellidoPaterno] = useState<InputStatus>('');
    const [ValApellidoMaterno] = useState<InputStatus>('');
    const [ValTipoEnt, setValTipoEnt] = useState<InputStatus>('');
    const [ValTipoDocuemntoIdentidad, setValTipoDocuemntoIdentidad] = useState<InputStatus>('');
    const [selectedTipoEnt, setSelectedTipoEnt] = useState<number | undefined>(undefined);
    const [selectedTipoDocuemntoIdentidad, setSelectedTipoDocuemntoIdentidad] = useState<number | undefined>(undefined);
    const [optionsTipoEnt, setOptionsTipoEnt] = useState<TipoEntidadItemModel[]>([]);
    const [optionsTipoDocumentoIdentidad, setOptionsTipoDocumentoIdentidad] = useState<EntListaModel[]>([]);

    const onChangeTipoDocuemntoIdentidad = async (value: number) => {
        ValCodigo;
        setValTipoDocuemntoIdentidad('');
        EntPer.TipoDocumentoIdentidadId = value;
        setSelectedTipoDocuemntoIdentidad(value)
        console.log(value)
    };

    const onChangeTipoEnt = async (value: number) => {
        ValCodigo;
        setValTipoEnt('');
        EntTipoEnt.TipoEntidadId = value;
        setSelectedTipoEnt(value)
        console.log(value)
    };


    const onChangeText = (e: React.ChangeEvent<HTMLInputElement>) => {

        setValCodigo('');
        setEnt({
            ...Ent,
            [e.target.name]: e.target.value.toUpperCase()
        });

    };

    const [CargarPage, setCargarPage] = React.useState(true);

    const toggle = () => {
        setDisabled(!disabled);
    };




    const onChanger = (e: React.ChangeEvent<HTMLInputElement>) => {
        setValDato('');
        setEnt({
            ...Ent,
            [e.target.name]: e.target.value.toUpperCase()
        });

    };



    const [items, setItems] = useState<AlquilerEntity[]>([]);
    const [disabled, setDisabled] = useState(false);
    const [Busqueda, setBusqueda] = useState<string>('');



    const onChange = (e: React.ChangeEvent<HTMLInputElement>) => {
        setBusqueda(e.target.value.toUpperCase());
    };


    const submitFormAdd = async (e: React.MouseEvent<HTMLButtonElement>) => {
        e.preventDefault();

        Ent.FechaRegistro = new Date();
        Ent.CodUsuario = 'adm';
        Ent.EstadoRegistro = EstadoRegistrochecked;
        Ent.CodigoTabla = props.CodigoTabla;
        console.log(Ent)
        const savedItem = await sMerLista.saveItem(Ent);
        if (savedItem) {
            if (FlaState) {
                props.updateState(savedItem);
            }
            else {
                props.addItemToState(savedItem);
            }
            props.toggle();
            setEnt(new MerListaEntity());
        }
    };

    const label = EstadoRegistrochecked ? 'Registro habilitado' : 'Registro deshabilitar';



    const getCargarDatos = async () => {

        const Resp_TipoEnt = await sGeneralService.GetTipoEntidadObtenerItems();
        setOptionsTipoEnt(Resp_TipoEnt);

        const Resp_T = await sEntLista.getItems('C0012');

        setOptionsTipoDocumentoIdentidad(Resp_T);



        setCargarPage(false);
    };


    useEffect(() => {
        async function cargarItem() {

            setCargarPage(true);
            await getCargarDatos();
        }


        cargarItem();
    }, []);

    const TipoEntidad = () => {
        if (EntTipoEnt.TipoEntidadId == 1) {

            return (
                <>
                    <Row>
                        <Col xs={24} sm={24} md={12} lg={12} xl={12}>
                            <h2>CLIENTE</h2>
                        </Col>
                    </Row>
                    <Row>
                        <Col xs={24} >
                            <Row>
                                <Col span={12}>
                                    <Col span={24}>
                                        <label>Tipo Entidad</label>
                                    </Col>
                                    <Col span={24}>
                                        <Select
                                            status={ValTipoEnt}
                                            allowClear
                                            style={{ width: '100%', marginTop: '5px', marginBottom: '10px' }}
                                            defaultActiveFirstOption={false}
                                            filterOption={false}
                                            optionFilterProp="children"
                                            value={EntTipoEnt.TipoEntidadId === 1 ? null : EntTipoEnt.TipoEntidadId}
                                            key={EntTipoEnt.TipoEntidadId}
                                            onChange={onChangeTipoEnt}
                                        >
                                            {optionsTipoEnt.map((row) => (
                                                <Select.Option key={row.TipoEntidadId} value={row.TipoEntidadId}>
                                                    {row.Nombre}
                                                </Select.Option>
                                            ))}
                                        </Select>

                                    </Col>
                                </Col>
                            </Row>

                            <Row>
                                <Col span={12}>
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
                                            value={EntPer.TipoDocumentoIdentidadId === 0 ? null : EntPer.TipoDocumentoIdentidadId}
                                            key={EntPer.TipoDocumentoIdentidadId}
                                            onChange={onChangeTipoDocuemntoIdentidad}
                                        >
                                            {optionsTipoDocumentoIdentidad.map((row) => (
                                                <Select.Option key={row.ListaId} value={row.ListaId}>
                                                    {row.Nombre}
                                                </Select.Option>
                                            ))}
                                        </Select>

                                    </Col>

                                </Col>
                            </Row>

                            <Row>
                                <Col span={12}>
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
                                            value={EntPer.NumDocumento === null ? "" : EntPer.NumDocumento}
                                        />
                                    </Col>
                                </Col>
                            </Row>

                            <Col span={12}>
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
                                            value={EntPer.Nombres === null ? "" : EntPer.Nombres}
                                        />
                                    </Col>
                                </Row>
                            </Col>

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
                                            value={EntPer.ApellidoPaterno === null ? "" : EntPer.ApellidoPaterno}
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
                                            value={EntPer.ApellidoMaterno === null ? "" : EntPer.ApellidoMaterno}
                                        />
                                    </Col>
                                </Row>
                            </Col>


                        </Col>
                        <Col xs={18} >
                            <Row style={{ height: '50px', alignContent: "flex-end", }}>

                                <Col span={24} style={{ alignContent: "center" }}>

                                    <Button
                                        onClick={submitFormAdd}
                                        style={ButtonAcceptModel}>
                                        Aceptar
                                    </Button>
                                </Col>
                            </Row>
                        </Col>
                    </Row>
                </>
            )
        } else {
            return (
                <>
                    <Row>
                        <Col xs={24} sm={24} md={12} lg={12} xl={12}>
                            <h2>CLIENTE</h2>
                        </Col>
                    </Row>
                    <Row>
                        <Col xs={24} >
                            <Row>
                                <Col span={12}>
                                    <Col span={24}>
                                        <label>Tipo Entidad</label>
                                    </Col>
                                    <Col span={24}>
                                        <Select
                                            status={ValTipoEnt}
                                            allowClear
                                            style={{ width: '100%', marginTop: '5px', marginBottom: '10px' }}
                                            defaultActiveFirstOption={false}
                                            filterOption={false}
                                            optionFilterProp="children"
                                            value={EntTipoEnt.TipoEntidadId === 1 ? null : EntTipoEnt.TipoEntidadId}
                                            key={EntTipoEnt.TipoEntidadId}
                                            onChange={onChangeTipoEnt}
                                        >
                                            {optionsTipoEnt.map((row) => (
                                                <Select.Option key={row.TipoEntidadId} value={row.TipoEntidadId}>
                                                    {row.Nombre}
                                                </Select.Option>
                                            ))}
                                        </Select>

                                    </Col>
                                </Col>
                            </Row>

                            <Row>
                                <Col span={12}>
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
                                            value={EntEnt.TipoDocumentoIdentidadId === 0 ? null : EntEnt.TipoDocumentoIdentidadId}
                                            key={EntEnt.TipoDocumentoIdentidadId}
                                            onChange={onChangeTipoDocuemntoIdentidad}
                                        >
                                            {optionsTipoDocumentoIdentidad.map((row) => (
                                                <Select.Option key={row.ListaId} value={row.ListaId}>
                                                    {row.Nombre}
                                                </Select.Option>
                                            ))}
                                        </Select>

                                    </Col>

                                </Col>
                            </Row>

                            <Row>
                                <Col span={12}>
                                    <Col span={24}>
                                        <label>Numero Documento</label>
                                    </Col>
                                    <Col span={24}>
                                        <Input
                                            status={ValNumDocumento}
                                            type="text"
                                            name="NumDocumento"
                                            style={{ marginTop: '5px', marginBottom: '10px' }}
                                            onChange={onChangeText}
                                            value={EntEnt.NumDocumento === null ? "" : EntEnt.NumDocumento}
                                        />
                                    </Col>
                                </Col>
                            </Row>

                            <Col span={12}>
                                <Row>
                                    <Col span={24}>
                                        <label>Nombre Comercial</label>
                                    </Col>
                                    <Col span={24}>
                                        <Input
                                            status={ValNombres}
                                            type="text"
                                            name="NombreComercial"
                                            style={{ marginTop: '5px', marginBottom: '10px' }}
                                            onChange={onChangeText}
                                            value={EntEnt.NombreComercial === null ? "" : EntEnt.NombreComercial}
                                        />
                                    </Col>
                                </Row>
                            </Col>

                        </Col>
                        <Col xs={18} >
                            <Row style={{ height: '50px', alignContent: "flex-end", }}>

                                <Col span={24} style={{ alignContent: "center" }}>

                                    <Button
                                        onClick={submitFormAdd}
                                        style={ButtonAcceptModel}>
                                        Aceptar
                                    </Button>
                                </Col>
                            </Row>
                        </Col>
                    </Row>

                </>
            )
        }
    }




    return (
        <>

            <div>

                {TipoEntidad()}
            </div>

        </>

    );

}

export default AddEditForm;




