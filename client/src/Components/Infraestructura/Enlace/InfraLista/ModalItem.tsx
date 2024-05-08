import * as React from 'react';
import AddEditForm from "./FormAddEdit";
import { Button, Modal } from 'antd';
import { EditOutlined, PlusOutlined } from '@ant-design/icons';
import { ButtonAddMain, ButtonDetalleEdit, ButtonEnlace, ButtonEnlaceCard } from '../../../../Styles/Button'
import { SizeButtonPrimary, SizeButtonDetalle, SizeButtonEnlace } from '../../../../Styles/Type'
import { PropsModel } from '../../../../Lib/PropsItem'
import { IconEditTable, IconEnlace } from '../../../../Styles/Icons'


const ModalItem: React.FC<PropsModel> = (props) => {
  const [modal, setModal] = React.useState(false);
  const toggle = () => {
    setModal(!modal);
  };
  let button: any = "";
  let title = "";
  const label = props.buttonLabel;

  if (label === "Edit") {
    button = (

      <Button
        onClick={toggle}
        type='dashed'
        style={ButtonDetalleEdit}
        size={SizeButtonDetalle}
        icon={IconEditTable}
      />
    );
    title = "Editar " + props.title;
  } else if (label === "Enlace") {
    props.item.Action = 1;
    button = (
      <Button
        onClick={toggle}
        style={ButtonEnlace}
        icon={IconEnlace}
        size={SizeButtonEnlace}
      />
    );

    title = "Agregar " + props.title;;


  } else if (label === "EnlaceCard") {

    button = (
      <EditOutlined
        onClick={toggle}
        style={ButtonEnlaceCard}
      />
    );

    title = "Editar " + props.title;;


  } else {
    button = (

      <Button
        onClick={toggle}
        style={ButtonAddMain}
        size={SizeButtonPrimary}
        icon={<PlusOutlined />}
      />
    );
    title = "Agregar " + props.title;;
  }

  return (
    <React.Fragment>
      {button}
      <Modal title={title} open={modal} onOk={toggle}
        width={370}
        onCancel={toggle}

        footer={[
        ]}
      >
        <AddEditForm
          item={props.item}
          addItemToState={props.addItemToState}
          updateState={props.updateState}
          toggle={toggle}
          CodigoTabla={props.CodigoTabla}
        />
      </Modal>
    </React.Fragment>
  );
}

export default ModalItem;
