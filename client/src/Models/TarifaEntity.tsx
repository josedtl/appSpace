import { ProcessActionEnum } from '../Lib/ResourceModel/Enum'

export class TarifaMainEntity {
    TarifaId: number;
    Correlativo: string;
    NomTarifa: string;
    NomComercial: string;
    Descripcion: string;
    FechaRegistro: Date;
    CodUsuario: string;
    EstadoRegistro: boolean;
    CodigoUnidad: string;
    SimboloMoneda: string;
    TipoTarifaEnum: number;
    CostoTarifa: number;

    constructor() {

        this.TarifaId = 0;
        this.Correlativo = "";
        this.NomTarifa = "";
        this.NomComercial = "";
        this.Descripcion = "";
        this.FechaRegistro = new Date();
        this.CodUsuario = "";
        this.EstadoRegistro = true;
        this.CodigoUnidad = "";
        this.SimboloMoneda = "";
        this.TipoTarifaEnum = 0;
        this.CostoTarifa = 0;
    }
}


export class TarifaSaveModel {
    TarifaId: number;
    ObjetoReferenciaId: number;
    Correlativo: string;
    NomTarifa: string;
    NomComercial: string;
    Descripcion: string;
    FechaRegistro: Date;
    CodUsuario: string;
    EstadoRegistro: boolean;
    TipoTarifaEnum: number;
    CostoTarifa: number;
    MonedaId: number;
    UnidadMedidaId: number;
    NomCompleto: string;

    constructor() {
        this.TarifaId = 0;
        this.ObjetoReferenciaId = 0;
        this.Correlativo = "";
        this.NomTarifa = "";
        this.NomComercial = "";
        this.Descripcion = "";
        this.FechaRegistro = new Date();
        this.CodUsuario = "";
        this.EstadoRegistro = true;
        this.TipoTarifaEnum = 0;
        this.CostoTarifa = 0;
        this.MonedaId = 0;
        this.UnidadMedidaId = 0;
        this.NomCompleto = "";
    }
}


export class TarifaBuscarRecursoModel {
    ObjetoReferenciaId: number;
    NomCompleto: string;
    TipoTarifaEnum: number;

    constructor() {
        this.ObjetoReferenciaId = 0;
        this.NomCompleto = '';
        this.TipoTarifaEnum = 0;
    }
}


export class TarifaBuscarItem {
    TarifaId: number;
    NomComercial: string;
    TipoTarifaEnum: number;

    constructor() {
        this.TarifaId = 0;
        this.NomComercial = '';
        this.TipoTarifaEnum = 0;
    }
}

