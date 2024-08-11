import { ProcessActionEnum } from '../Lib/ResourceModel/Enum'

export class ServicioEntity {
    ServicioId: number;
    Estado: number;
    Correlativo: string;
    Nombre: string;
    Descripcion: string;
    TipoServicioId: number;
    FechaRegistro: Date;
    CodUsuario: string;
    EstadoRegistro: boolean;

    constructor() {
        this.ServicioId = 0;
        this.Estado = 0;
        this.Correlativo = "";
        this.Nombre = "";
        this.Descripcion = "";
        this.TipoServicioId = 0;
        this.FechaRegistro = new Date();
        this.CodUsuario = "";
        this.EstadoRegistro = true;
    }

    

}

export class ServicioMainEntity {


    ServicioId : number;
    Correlativo : string;
    Nombre: string;
    Descripcion : string;
    TipoServicio : string;
    FechaRegistro : Date;
    CodUsuario : string;
    EstadoRegistro: boolean;

 constructor() {
        this.ServicioId = 0;
        this.Correlativo = "";
        this.Nombre = "";
        this.Descripcion = "";
        this.TipoServicio = "";
        this.FechaRegistro = new Date();
        this.CodUsuario = "";
        this.EstadoRegistro = true;
    }

}


export class ServicioSaveEntity {


    ServicioId : number;
    Correlativo : string;
    Nombre: string;
    Descripcion : string;
    TipoServicioId : number;
    FechaRegistro : Date;
    CodUsuario : string;
    EstadoRegistro: boolean;


 constructor() {
        this.ServicioId = 0;
        this.Correlativo = "";
        this.Nombre = "";
        this.Descripcion = "";
        this.TipoServicioId = 0;
        this.FechaRegistro = new Date();
        this.CodUsuario = "";
        this.EstadoRegistro = true;
    }

}

