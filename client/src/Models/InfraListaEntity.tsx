

export class InfraListaEntity {
    Cont: number;
    ListaId: number;
    CampoId: number;
    Codigo: string;
    Nombre: string;
    Descripcion: string
    FechaRegistro: Date;
    CodUsuario: string;;
    EstadoRegistro: boolean;
    CodigoCampo: string
    constructor() {
        this.Cont = 0;
        this.ListaId = 0;
        this.CampoId = 0;
        this.Codigo = '';
        this.Nombre = '';
        this.Descripcion = '';
        this.FechaRegistro = new Date();
        this.CodUsuario = '';
        this.EstadoRegistro = false;
        this.CodigoCampo = '';
    }
}

export class InfraCampoTituloModel {
    Titulo: string;
    constructor() {
        this.Titulo = '';
    }
}


export class InfraListaModel {
    ListaId: number;
    Nombre: string;
    constructor() {
        this.ListaId = 0;
        this.Nombre = '';
    }
}
