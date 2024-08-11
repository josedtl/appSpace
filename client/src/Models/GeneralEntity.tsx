

export class TipoProcesoEntity {
    TipoProcesoId: number;
    Codigo: string;
    Nombre: string;;
    EstadoRegistro: boolean;

    constructor() {
        this.TipoProcesoId = 0;
        this.Codigo = '';
        this.Nombre = '';
        this.EstadoRegistro = false;
    }
}


export class EstadoProcesoEntity {
    EstadoProcesoId: number;
    Nombre: string;;

    constructor() {
        this.EstadoProcesoId = 0;
        this.Nombre = '';
    }
}


export class TipoEntidadItemModel {
    TipoEntidadId: number;
    Codigo: string;
    Nombre: string;

    constructor() {
        this.TipoEntidadId = 0;
        this.Codigo = '';
        this.Nombre = '';
    }

}
export class DatosClienteItemModel {
    TipoEntidadId: number;
    TipoDocumentoIdentidadId: number;
    NumDocumento: string;
    Nombre: string;
    ApellidoPaterno: string = '';
    ApellidoMaterno: string = '';
    Codigo: string;
    Razonsocial: string;

    constructor() {
        this.TipoEntidadId = 0;
        this.TipoDocumentoIdentidadId = 0;
        this.NumDocumento = '';
        this.Nombre = '';
        this.ApellidoPaterno = '';
        this.ApellidoMaterno = '';
        this.Codigo = '';
        this.Razonsocial = '';
    }

}