import React, { useState, useEffect } from "react";
import { MerListaEntity } from '../../../Models/MerListaEntity'
import MerListaService from '../../../Service/MerListaService';
import { Form, Select, Card } from 'antd';
import { Button, Col, Row, Input } from 'antd';
import InfraListaService from '../../../Service/InfraListaService';
import type { RadioChangeEvent } from 'antd';
import type { InputStatus } from 'antd/lib/_util/statusUtils'
import { PropsModel } from '../../../Lib/PropsItem'
import { ButtonAcceptModel, InputSearchMain } from '../../../Styles/Button'
import type { CheckboxProps } from 'antd';
import DataTable from './DataTable';
import { IconTabla, IconCard } from '../../../Styles/Icons'
import { ButtonMainSecondaryLeft } from '../../../Styles/Button'
import { SizeMainButtonSecondary } from '../../../Styles/Type'
import { AlquilerEntity } from '../../../Models/AlquilerEntity';
import { InfraestructuraSaveModel, InfraestructuraFiltroModel } from '../../../Models/InfraestructuraEntity';
import { InfraListaModel } from '../../../Models/InfraListaEntity';
import InfraestructuraService from '../../../Service/InfraestructuraService';
const AddEditForm: React.FC<PropsModel> = (props) => {
    const sMerLista = new MerListaService();
    const sInfraLista = new InfraListaService();
    const sInfraestructura = new InfraestructuraService();
    const initialMerLista = new MerListaEntity();
    const [Ent, setEnt] = useState<MerListaEntity>(initialMerLista);
    const [FlaState, setFlaState] = useState<Boolean>(false);
    const [form] = Form.useForm();
    const [ValDato, setValDato] = useState<InputStatus>('');
    const initialProducto = new InfraestructuraSaveModel();
    const [EntInf, setEntInf] = useState<InfraestructuraSaveModel>(initialProducto);

    const [EstadoRegistrochecked, setEstadoRegistrochecked] = useState(true);
    const [selectedPiso, setSelectedPiso] = useState<number | undefined>(undefined);
    const [selectedClasificacion, setSelectedClasificacion] = useState<number | undefined>(undefined);
    const [optionsPiso, setOptionsPiso] = useState<InfraListaModel[]>([]);
    const [optionsClasificacion, setOptionsClasificacion] = useState<InfraListaModel[]>([]);
    const [ValClasificacion, setValClasificacion] = useState<InputStatus>('');
    const [ValPiso, setValPiso] = useState<InputStatus>('');

    const [optionsInfraestructuraFiltro, setOptionsInfraestructuraFiltro] = useState<InfraListaModel[]>([]);
    const [ValEstado, setValEstado] = useState<InputStatus>('');
    const [selectedEstado, setSelectedEstado] = useState<number | undefined>(undefined);
    const [item, setItem] = useState<InfraestructuraFiltroModel[]>([]);


    const [CargarPage, setCargarPage] = React.useState(true);

    const toggle = () => {
        setDisabled(!disabled);
    };

    const [fPiso, setfPiso] = useState<number>(0);
    const [fClasificacion, setfClasificacion] = useState<number>(0);
    const [fEstadoAdministrativo, setfEstadoAdministrativo] = useState<number>(0);

    const filterItemsPiso = fPiso == 0 ? item : item.filter(fdata => fdata.PisoId == fPiso);
    const filterItemsclasificacion = fClasificacion == 0 ? filterItemsPiso : filterItemsPiso.filter(fdata => fdata.ClasificacionId == fClasificacion);
    const filterItems = fEstadoAdministrativo == 0 ? filterItemsclasificacion : filterItemsclasificacion.filter(fdata => fdata.EstadoAdministrativoId == fEstadoAdministrativo);

    //Estado
    const handleSearchEstado = async (value: string) => {
        try {
            const responseEstado = await sInfraLista.BuscarItemCodigo('0014', value);
            setOptionsInfraestructuraFiltro(responseEstado);

        } catch (error) {
            console.error('Error al buscar Estado:', error);
        }
    };
    const onChangeEstado = async (value: number) => {
        setValEstado('');
        EntInf.EstadoAdministrativoId = value;
        setSelectedEstado(value)
        setfEstadoAdministrativo(value);
    };

    //Piso
    const handleSearchPiso = async (value: string) => {
        try {
            const responsePiso = await sInfraLista.BuscarItemCodigo("0009", value);
            setOptionsPiso(responsePiso);
        } catch (error) {
            console.error('Error al buscar categorías:', error);
        }
    };

    const onSearchPiso = async (value: string) => {
        try {
            const responsePiso = await sInfraLista.BuscarItemCodigo("0009", value);
            setOptionsPiso(responsePiso);
        } catch (error) {
            console.error('Error al buscar categorías:', error);
        }
    };

    const onChangePiso = async (value: number) => {
        setValPiso('');
        EntInf.PisoId = value;
        setSelectedPiso(value)
        setfPiso(value);
    };

    // Clasificación
    const onSearchClasificacion = async (value: string) => {
        try {
            const responseClasificacion = await sInfraLista.BuscarItemCodigo("0013", value);
            setOptionsClasificacion(responseClasificacion);
        } catch (error) {
            console.error('Error al buscar categorías:', error);
        }
    };

    const onChangeClasificacion = async (value: number) => {
        setValClasificacion('');
        EntInf.ClasificacionId = value;
        setSelectedClasificacion(value)
        setfClasificacion(value);
    };

    const onChanger = (e: React.ChangeEvent<HTMLInputElement>) => {
        setValDato('');
        setEnt({
            ...Ent,
            [e.target.name]: e.target.value.toUpperCase()
        });

    };



    const tabList = [
        {
            key: 'Servicio',
            tab: 'Servicio',
        }
    ];
    const contentList: Record<string, React.ReactNode> = {
        Servicio: <p>content1</p>,
        Venta: <p>content2</p>,
    };

    const [items, setItems] = useState<AlquilerEntity[]>([]);
    const [disabled, setDisabled] = useState(false);
    const [Busqueda, setBusqueda] = useState<string>('');

    const filterItem = items.filter(fdata =>
        fdata.Codigo.toLowerCase().includes(Busqueda.toLowerCase())
    );

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

    const onChangechk: CheckboxProps['onChange'] = (e) => {
        console.log('checked = ', e.target.checked);
        setEstadoRegistrochecked(e.target.checked);
    };


    const getItems = async () => {
        const itemsg = await sInfraestructura.GetInfraestructuraObtenerFiltro();

        setItem(itemsg);
        console.log(itemsg);
        setCargarPage(false);

    };

    useEffect(() => {
        const updatedPerson = props.item;
        updatedPerson.Action = updatedPerson.ListaId > 0 ? 3 : 1;
        setFlaState(updatedPerson.ListaId > 0);
        setEnt(updatedPerson);
        setEstadoRegistrochecked(updatedPerson.EstadoRegistro)
        console.log(props.CodigoTabla)
        console.log("Abriendo VCentana");
        getItems();
    }, []);

    return (
        <>

            <Row>
                <Col xs={24} sm={24} md={12} lg={12} xl={12}>
                    <h2>Filtro</h2>
                </Col>
            </Row>

            <Col xs={24}>
                <Row>

                    <Col span={8}>
                        <Row>
                            <Col span={24}>
                                <label>Estado</label>
                            </Col>
                            <Col span={24}>
                                <Select
                                    showSearch
                                    status={ValEstado}
                                    style={{ width: '85%', marginTop: '5px', marginBottom: '10px' }}
                                    defaultActiveFirstOption={false}
                                    filterOption={false}
                                    onSearch={handleSearchEstado}
                                    value={EntInf.EstadoAdministrativoId === 0 ? null : EntInf.EstadoAdministrativoId}
                                    key={EntInf.EstadoAdministrativoId}
                                    onChange={onChangeEstado}
                                >
                                    {optionsInfraestructuraFiltro.map((EstadoAdministrativo) => (
                                        <Select.Option key={EstadoAdministrativo.ListaId} value={EstadoAdministrativo.ListaId}>
                                            {EstadoAdministrativo.Nombre}
                                        </Select.Option>
                                    ))}
                                </Select>
                            </Col>
                        </Row>
                    </Col>


                    <Col span={8}>
                        <Row>
                            <Col span={24}>
                                <label>Piso</label>
                            </Col>
                            <Col span={24}>
                                <Select
                                    showSearch
                                    status={ValPiso}
                                    style={{ width: '85%', marginTop: '5px', marginBottom: '10px' }}
                                    defaultActiveFirstOption={false}
                                    filterOption={false}
                                    onSearch={onSearchPiso}
                                    value={EntInf.PisoId === 0 ? null : EntInf.PisoId}
                                    key={EntInf.PisoId}
                                    onChange={onChangePiso}
                                >
                                    {optionsPiso.map((PisoItem) => (
                                        <Select.Option key={PisoItem.ListaId} value={PisoItem.ListaId}>
                                            {PisoItem.Nombre}
                                        </Select.Option>
                                    ))}
                                </Select>
                            </Col>
                        </Row>

                    </Col>

                    <Col span={8}>
                        <Row>
                            <Col span={24}>
                                <label>Clasificación</label>
                            </Col>
                            <Col span={24}>
                                <Select
                                    showSearch
                                    status={ValClasificacion}
                                    style={{ width: '85%', marginTop: '5px', marginBottom: '10px' }}
                                    defaultActiveFirstOption={false}
                                    filterOption={false}
                                    onSearch={onSearchClasificacion}
                                    value={EntInf.ClasificacionId === 0 ? null : EntInf.ClasificacionId}
                                    key={EntInf.ClasificacionId}
                                    onChange={onChangeClasificacion}
                                >
                                    {optionsClasificacion.map((Clasificacion) => (
                                        <Select.Option key={Clasificacion.ListaId} value={Clasificacion.ListaId}>
                                            {Clasificacion.Nombre}
                                        </Select.Option>
                                    ))}
                                </Select>
                            </Col>
                        </Row>
                    </Col>
                </Row>

            </Col>
            <Button
                onClick={toggle}
                style={ButtonMainSecondaryLeft}
                size={SizeMainButtonSecondary}
                icon={disabled ? IconTabla : IconCard}
            />

            <Col xs={24} >


                <DataTable DataList={filterItems} EsTabla={disabled} />
                <br />
                <br />

            </Col>

            <Row style={{ height: '50px', alignContent: "flex-end", }}>

                <Col span={24} style={{ alignContent: "center" }}>

                    <Button
                        onClick={submitFormAdd}
                        style={ButtonAcceptModel}>
                        Aceptar
                    </Button>
                </Col>
            </Row>
        </>

    );
}

export default AddEditForm;




