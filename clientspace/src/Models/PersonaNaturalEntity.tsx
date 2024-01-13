
export class PersonaNaturalEntity {
    EntidadId: number;
    TipoEntidadId: number;
    TipoDocumentoIdentidadId: number;
    NumDocumento: string;
    FechaRegistro: Date;
    CodUsuario: string;
    UbigeoId: number | null;
    Nombres: string;
    ApellidoPaterno: string;
    ApellidoMaterno: string;
    FechaNacimiento:Date;
    Direccion: string;
    Telefono: string;
    Correo: string;
    SexoId: number | null;
    EstadoCivilId: number | null;

    constructor() {
        this.EntidadId = 0;
        this.TipoEntidadId = 0;
        this.TipoDocumentoIdentidadId = 0;
        this.NumDocumento = '';
        this.FechaRegistro = new Date();
        this.CodUsuario = '';
        this.UbigeoId =0;
        this.Nombres ='';
        this.ApellidoPaterno='';
        this.ApellidoMaterno='';
        this.FechaNacimiento=new Date();
        this.Direccion = '';
        this.Telefono ='';
        this.Correo='';
        this.SexoId=0;
        this.EstadoCivilId=0;
    }
}