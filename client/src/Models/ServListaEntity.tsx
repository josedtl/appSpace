export class ServListaModel {
    ListaId: number;
    Nombre: string;

    constructor() {
        this.ListaId = 0;
        this.Nombre = '';
    }

}


export class ServListaMainModel {
    Cont: number;
    ListaId: number;
    CampoId: number;
    Codigo: string;
    Nombre: string;
    Descripcion: string;
    FechaRegistro: Date;
    CodUsuario: string;
    EstadoRegistro: boolean
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
    }

}

export class ServListaSaveModel {

    ListaId: number;
    CodigoCampo: string;
    Codigo: string;
    Nombre: string;
    Descripcion: string;
    FechaRegistro: Date;
    CodUsuario: string;
    EstadoRegistro: boolean;
    constructor() {

        this.ListaId = 0;
        this.CodigoCampo = "";
        this.Codigo = "";
        this.Nombre = "";
        this.Descripcion = "";
        this.FechaRegistro = new Date();
        this.CodUsuario = "";
        this.EstadoRegistro = true;
    }
}