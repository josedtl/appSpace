

export class UnidadMedidaEntity {
    UnidadMedidaId: number;
    Nombre: string;
    constructor() {
        this.UnidadMedidaId = 0;
        this.Nombre = '';
    }
}




export class UnidadMedidaModel {
    UnidadMedidaId: number;
    Codigo: string;
    CodigoComercial: string;
    Nombre: string;
    FechaRegistro: Date;
    CodUsuario: string;
    EstadoRegistro: boolean;
    constructor() {
        this.UnidadMedidaId = 0;
        this.Codigo = "";
        this.CodigoComercial = "";
        this.Nombre = "";
        this.FechaRegistro = new Date();
        this.CodUsuario = "";
        this.EstadoRegistro = true;
    }
}

