import React, { useState, useEffect } from "react";
import { ListaSaveModel } from '../../Models/ListaSaveModel'
import ListaRelacionService from '../../Service/ListaRelacionService';
import { Button, Form, Input, Row, Col } from 'antd';
import type { InputStatus } from 'antd/lib/_util/statusUtils'
import { PropsModel } from '../../Lib/PropsItem'
import { ButtonAcceptModel } from '../../Styles/Button'

const AddEditForm: React.FC<PropsModel> = (props) => {
    const sMarca = new ListaRelacionService();

    const initialMarca = new ListaSaveModel();
    const [Ent, setEnt] = useState<ListaSaveModel>(initialMarca);
    const [FlaState, setFlaState] = useState<Boolean>(false);
    const [form] = Form.useForm();
    const [ValDato, setValDato] = useState<InputStatus>('');
    const onChange = (e: React.ChangeEvent<HTMLInputElement>) => {
        setValDato('');
        setEnt({
            ...Ent,
            [e.target.name]: e.target.value.toUpperCase()
        });

    };

    const submitFormAdd = async (e: React.MouseEvent<HTMLButtonElement>) => {
        e.preventDefault();
        if (Ent.Nombre === '') {
            setValDato('error');
            return;
        }
        Ent.FechaRegistro = new Date();
        const savedItem = await sMarca.saveItem(Ent);
        if (savedItem) {
            if (FlaState) {
                props.updateState(savedItem);
            }
            else {
                props.addItemToState(savedItem);
            }
            props.toggle();
        }
    };

    useEffect(() => {
        const updatedPerson = props.item;
        updatedPerson.Action = updatedPerson.MarcaId > 0 ? 3 : 1;
        setFlaState(updatedPerson.MarcaId > 0);
        setEnt(updatedPerson);
    }, []);

    return (

        <Form form={form} name="formItem" layout="vertical" autoComplete="off">
            <Row>
                <Col span={24}>
                    <label>Codigo</label>
                </Col>
                <Col span={24}>
                    <Input
                        status={ValDato}
                        type="text"
                        name="Codigo"
                        style={{ marginTop: '5px', marginBottom: '10px' }}
                        onChange={onChange}
                        value={Ent.Codigo === null ? "" : Ent.Codigo}
                    />
                </Col>
            </Row>
            <Row>
                <Col span={24}>
                    <label>Nombres</label>
                </Col>
                <Col span={24}>
                    <Input
                        status={ValDato}
                        type="text"
                        name="Nombre"
                        style={{ marginTop: '5px', marginBottom: '10px' }}
                        onChange={onChange}
                        value={Ent.Nombre === null ? "" : Ent.Nombre}
                    />
                </Col>
            </Row>
            <Row>
                <Col span={24}>
                    <label>Descripcion</label>
                </Col>
                <Col span={24}>
                    <Input
                        status={ValDato}
                        type="text"
                        name="Descripcion"
                        style={{ marginTop: '5px', marginBottom: '10px' }}
                        onChange={onChange}
                        value={Ent.Descripcion === null ? "" : Ent.Descripcion}
                    />
                </Col>
            </Row>

            <Form.Item>
                <Button
                    onClick={submitFormAdd}
                    style={ButtonAcceptModel}>
                    Aceptar
                </Button>
            </Form.Item>
        </Form>
    );
}

export default AddEditForm;




