export class ImfraestructuraEntity {
    InfraestructuraId: number;
    SucursalId: number;
    Estado: boolean;
    CodigoSistema: string;
    CodigoInterno: string;
    Descripcion: string;
    TipoInfraestructuraId: number;
    InfraestructuraDimensionId: number;
    Aforo: number;
    PisoId: number;
    FechaRegistro: Date;
    CodUsuario: string;
    EstadoRegistro: boolean;
    constructor() {
        this.InfraestructuraId = 0;
        this.SucursalId = 0;
        this.Estado = true;
        this.CodigoSistema = "";
        this.CodigoInterno = "";
        this.Descripcion = "";
        this.TipoInfraestructuraId = 0;
        this.InfraestructuraDimensionId = 0;
        this.Aforo = 0;
        this.PisoId = 0;
        this.FechaRegistro = new Date();
        this.CodUsuario = "";
        this.EstadoRegistro = true;
    }
}


export class InfraestructuraMainModel {
    Item:number;
    InfraestructuraId: number;
    Sucursal: string;
    Estado: boolean;
    CodigoSistema: string;
    CodigoInterno: string;
    Descripcion: string;
    TipoInfraestructura: string;
    InfraestructuraDimension: string;
    Aforo: number;
    Piso: string;
    FechaRegistro: Date;
    CodUsuario: string;
    EstadoRegistro: boolean;
    constructor() {
        this.Item=0;
        this.InfraestructuraId = 0;
        this.Sucursal = "";
        this.Estado = true;
        this.CodigoSistema = "";
        this.CodigoInterno = "";
        this.Descripcion = "";
        this.TipoInfraestructura = "";
        this.InfraestructuraDimension = "";
        this.Aforo = 0;
        this.Piso = "";
        this.FechaRegistro = new Date();
        this.CodUsuario = "";
        this.EstadoRegistro = true;
    }
}