import { OrdenPedidoDetalleEntity } from "../Models/OrdenPedidoDetalleEntity";
import { AlquilerEntity } from "../Models/AlquilerEntity";



export type PropsModel = {
    buttonLabel?: string;
    item?: any;
    updateState?: any;
    addItemToState?: any;
    toggle?: any;
    CodigoTabla?: any;
    title?: any;
    keyItem?: any;
}


export type PropsTable = {
    DataList: any[];
    updateState?: any;
    deleteItemFromState?: any;
    EsTabla?: boolean;
    CodigoTabla?: string;
    title?: string;
    keyItem?: any;
}

export type PropsModelDetalle = {
    buttonLabel?: string;
    item: OrdenPedidoDetalleEntity;
    updateState?: any;
    addItemToState?: any;
    toggle?: any
}
export type PropsTableDetalle = {
    DataList: OrdenPedidoDetalleEntity[];
    updateState: any;
    deleteItemFromState: any;
    EsTabla: boolean
}

export type PropsModelDetalles = {
    buttonLabel?: string;
    item: AlquilerEntity;
    updateState?: any;
    addItemToState?: any;
    toggle?: any
}
