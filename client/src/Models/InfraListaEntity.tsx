export class InfraListaEntity {
    ListaId: number;
    CampoId: number;
    Codigo: string;
    Nombre: string;
    Descripcion: string;
    FechaRegistro: Date;
    CodUsuario: string;
    EstadoRegistro: boolean;

    constructor() {
        this.ListaId = 0;
        this.CampoId = 0;
        this.Codigo = "";
        this.Nombre = "";
        this.Descripcion = "";
        this.FechaRegistro = new Date();
        this.CodUsuario = "";
        this.EstadoRegistro = true;
    }
}

export class InfraListaModel {
    ListaId: number;
    Nombre: string;
    
    constructor() {
        this.ListaId = 0;
        this.Nombre = "";
      
    }
}