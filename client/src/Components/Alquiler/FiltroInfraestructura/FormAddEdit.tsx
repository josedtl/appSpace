import React, { useState, useEffect } from "react";
import { MerListaEntity } from '../../../Models/MerListaEntity'
import MerListaService from '../../../Service/MerListaService';
import { Form, Select, Card } from 'antd';
import { Button, Col, Row } from 'antd';
import InfraListaService from '../../../Service/InfraListaService';
import type { RadioChangeEvent } from 'antd';
import type { InputStatus } from 'antd/lib/_util/statusUtils'
import { PropsModel } from '../../../Lib/PropsItem'
import { ButtonAcceptModel } from '../../../Styles/Button'
import type { CheckboxProps } from 'antd';
import DataTable from '../DataTable';
import { IconTabla, IconCard } from '../../../Styles/Icons'
import { ButtonMainSecondaryLeft } from '../../../Styles/Button'
import { SizeMainButtonSecondary } from '../../../Styles/Type'
import { AlquilerEntity } from '../../../Models/AlquilerEntity';
import { InfraestructuraSaveModel } from '../../../Models/InfraestructuraEntity';
import { InfraListaModel } from '../../../Models/InfraListaEntity';
const AddEditForm: React.FC<PropsModel> = (props) => {
    const sMerLista = new MerListaService();
    const sInfraLista = new InfraListaService();
    const initialMerLista = new MerListaEntity();
    const [Ent, setEnt] = useState<MerListaEntity>(initialMerLista);
    const [FlaState, setFlaState] = useState<Boolean>(false);
    const [form] = Form.useForm();
    const [ValDato, setValDato] = useState<InputStatus>('');
    const initialProducto = new InfraestructuraSaveModel();
    const [EntInf, setEntInf] = useState<InfraestructuraSaveModel>(initialProducto);

    const [EstadoRegistrochecked, setEstadoRegistrochecked] = useState(true);
    const [FlaNumero, setNumeroState] = useState<number>(0);
    const [ValPiso, setValPiso] = useState<InputStatus>('');
    const [optionsPiso, setOptionsPiso] = useState<InfraListaModel[]>([]);
    const [selectedPiso, setSelectedPiso] = useState<number | undefined>(undefined);
    const [optionsClasificacion, setOptionsClasificacion] = useState<InfraListaModel[]>([]);
    const [ValClasificacion, setValClasificacion] = useState<InputStatus>('');
    const [selectedClasificacion, setSelectedClasificacion] = useState<number | undefined>(undefined);




    const toggle = () => {
        setDisabled(!disabled);
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
    };

    const onChanger = (e: React.ChangeEvent<HTMLInputElement>) => {
        setValDato('');
        setEnt({
            ...Ent,
            [e.target.name]: e.target.value.toUpperCase()
        });

    };

    const onChangePiso = async (value: number) => {
        setValPiso('');
        EntInf.PisoId = value;
        setSelectedPiso(value)
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
    const filterItems = items.filter(fdata =>
        fdata.Codigo.toLowerCase().includes(Busqueda.toLowerCase())
    );

    const [activeTabKey1, setActiveTabKey1] = useState<string>('Servicio');
    const onTab1Change = (key: string) => {
        setActiveTabKey1(key);
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
    
    useEffect(() => {
        const updatedPerson = props.item;
        updatedPerson.Action = updatedPerson.ListaId > 0 ? 3 : 1;
        setFlaState(updatedPerson.ListaId > 0);
        setEnt(updatedPerson);
        setEstadoRegistrochecked(updatedPerson.EstadoRegistro)
        console.log(props.CodigoTabla)
    }, []);

    return (
        <>


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
                                    //status={ValClasificacion}
                                    style={{ width: '85%', marginTop: '5px', marginBottom: '10px' }}
                                    defaultActiveFirstOption={false}
                                    filterOption={false}
                                //  onSearch={handleSearchClasificacion}
                                //value={Ent.ClasificacionId === 0 ? null : Ent.ClasificacionId}
                                // key={Ent.ClasificacionId}
                                // onChange={onChangeClasificacion}
                                >
                                    {/* {optionsClasificacion.map((Clasificacion) => (
                  <Select.Option key={Clasificacion.ListaId} value={Clasificacion.ListaId}>
                    {Clasificacion.Nombre}
                  </Select.Option>
                ))} */}
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
                                    onSearch={handleSearchPiso}
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
                <Card
                    style={{ width: '100%' }}
                    tabList={tabList}
                    activeTabKey={activeTabKey1}
                    onTabChange={onTab1Change}
                >

                    <DataTable DataList={filterItems} EsTabla={disabled} />

                    {contentList[activeTabKey1]}
                </Card>
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




