import { ProcessActionEnum } from '../Lib/ResourceModel/Enum'

export class PersonaNaturalEntity {
    PersonaNaturalId: number;
    TipoDocumentoIdentidadId: number;
    NumDocumento: string;
    Nombres: string;
    ApellidoPaterno: string;
    ApellidoMaterno: string;
    FechaNacimiento: Date;
    UbigeoId: number | null;
    Direccion: string;
    Telefono: string;
    Correo: string;
    SexoId: number | null;
    EstadoCivilId: number | null;
    FechaRegistro: Date;
    CodUsuario: string;
    Action: ProcessActionEnum
    TipoDocumento: string;
    constructor() {
        this.PersonaNaturalId = 0;
        this.TipoDocumentoIdentidadId = 0;
        this.NumDocumento = '';
        this.Nombres = '';
        this.ApellidoPaterno = '';
        this.ApellidoMaterno = '';
        this.FechaNacimiento = new Date();
        this.UbigeoId = 0;
        this.Direccion = '';
        this.Telefono = '';
        this.Correo = '';
        this.SexoId = 0;
        this.EstadoCivilId = 0;
        this.FechaRegistro = new Date();
        this.CodUsuario = '';
        this.Action = ProcessActionEnum.Add;
        this.TipoDocumento = '';
    }
}


export class PersonaNaturalMainModel {
    PersonaNaturalId: number;
    TipoDocumento: string;
    NumDocumento: string;
    Nombres: string;
    ApellidoPaterno: string;
    ApellidoMaterno: string;
    FechaRegistro: Date;
    CodUsuario: string;

    constructor() {
        this.PersonaNaturalId = 0;
        this.TipoDocumento = "";
        this.NumDocumento = "";
        this.Nombres = "";
        this.ApellidoPaterno = "";
        this.ApellidoMaterno = "";
        this.FechaRegistro = new Date();
        this.CodUsuario = "";
    }
}



export class PersonaNaturalSaveModel {
    PersonaNaturalId: number;
    TipoDocumentoIdentidadId: number;
    NumDocumento: string;
    FechaRegistro: Date;
    CodUsuario: string;
    UbigeoId: number;
    Nombres: string;
    ApellidoPaterno: string;
    ApellidoMaterno: string;
    FechaNacimiento: Date;
    Direccion: string;
    Telefono: string;
    Correo: string;
    SexoId: number;
    EstadoCivilId: number;
    Action: number;

    constructor() {
        this.PersonaNaturalId = 0;
        this.TipoDocumentoIdentidadId = 0;
        this.NumDocumento = "";
        this.FechaRegistro = new Date();
        this.CodUsuario = "";
        this.UbigeoId = 0;
        this.Nombres = "";
        this.ApellidoPaterno = "";
        this.ApellidoMaterno = "";
        this.FechaNacimiento = new Date();
        this.Direccion = "";
        this.Telefono = "";
        this.Correo = "";
        this.SexoId = 0;
        this.EstadoCivilId = 0;
        this.Action = 0;
    }
}



export class PersonaNaturalEnlaceModel {
    PersonaNaturalId: number;
    TipoDocumentoIdentidadId: number;
    NumDocumento: string;
    Nombres: string;
    ApellidoPaterno: string;
    ApellidoMaterno: string;
    Action: number;
    FechaRegistro: Date;
    CodUsuario: string;

    constructor() {
        this.PersonaNaturalId = 0;
        this.TipoDocumentoIdentidadId = 0;
        this.NumDocumento = "";
        this.Nombres = "";
        this.ApellidoPaterno = "";
        this.ApellidoMaterno = "";
        this.FechaRegistro = new Date();
        this.CodUsuario = "";
        this.Action = 0;
    }
}
