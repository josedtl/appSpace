export class InfraestructuraSaveModel {
    InfraestructuraId: number;
    SucursalId: number;
    Estado: number;
    CodigoSistema: string;
    CodigoInterno: string;
    Descripcion: string;
    TipoInfraestructuraId: number;
    ClasificacionId: number;
    InfraestructuraDimensionId: number;
    Aforo: number;
    PisoId: number;
    FechaRegistro: Date;
    CodUsuario: string;
    EstadoRegistro: boolean;
    Action: number;
    EstadoAdministrativoId:number;
    constructor() {
        this.InfraestructuraId = 0;
        this.SucursalId = 0;
        this.Estado = 0;
        this.CodigoSistema = '';
        this.CodigoInterno = '';
        this.Descripcion = '';
        this.TipoInfraestructuraId = 0;
        this.ClasificacionId = 0;
        this.InfraestructuraDimensionId = 0;
        this.Aforo = 0;
        this.PisoId = 0;
        this.FechaRegistro = new Date();
        this.CodUsuario = '';
        this.EstadoRegistro = true;
        this.Action = 0;
        this.EstadoAdministrativoId=0;
    }
}

export class InfraestructuraMainModel {
    Cont: number;
    InfraestructuraId: number;
    Sucursal: string;
    CodigoSistema: string;
    CodigoInterno: string;
    Descripcion: string;
    TipoInfraestructura: string;
    Clasificacion: string;
    InfraestructuraDimension: string;
    Aforo: number;
    Piso: string;
    FechaRegistro: Date;
    CodUsuario: string;
    EstadoRegistro: boolean;
    EstadoAdministrativoId:0;
    PisoId: number;
    ClasificacionId: number;
    constructor() {
        this.Cont = 0;
        this.InfraestructuraId = 0;
        this.Sucursal = '';
        this.CodigoSistema = '';
        this.CodigoInterno = '';
        this.Descripcion = '';
        this.TipoInfraestructura = '';
        this.Clasificacion = '';
        this.InfraestructuraDimension = '';
        this.Aforo = 0;
        this.Piso = '';
        this.FechaRegistro = new Date();
        this.CodUsuario = '';
        this.EstadoRegistro = false;
        this.EstadoAdministrativoId=0;
        this.PisoId = 0;
        this.ClasificacionId = 0;
    }
}

export class InfraestructuraFiltroModel{

    Cont: number;
    InfraestructuraId: number;
    ClasificacionId:number;
    PisoId:number;
    EstadoAdministrativoId:number;
    Clasificacion: string;
    Piso: string;
    EstadoAdministrativo:string;
    CodigoInterno: string;
    TipoInfraestructura: string;
    TipoInfraestructuraId: number;

    constructor() {
        this.Cont = 0;
        this.InfraestructuraId = 0;
        this.ClasificacionId=0;
        this.PisoId =0;
        this.EstadoAdministrativoId=0;
        this.Clasificacion = '';
        this.Piso = '';
        this.EstadoAdministrativo='';
        this.CodigoInterno='';
        this.TipoInfraestructura='';
        this.TipoInfraestructuraId=0;
    }
}
