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