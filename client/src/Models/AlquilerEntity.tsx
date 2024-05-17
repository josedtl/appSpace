
export class AlquilerEntity {
    Item: number;
    AlquilerId: number;
    TarifaId: number;
    ClienteId: number;
    Cantidad: number;
    Codigo: string;
    FechaInicio: Date;
    FechaTermino: Date;
    FechaCreacion: Date;
    FechaModifica: Date;
    UnidadMedidaId: number;
    NomMoneda: string;
    Precio: number;
    PrecioNeto: number;
    CodUsuario : string;
    constructor() {
        this.Item = 0;
        this.AlquilerId = 0;
        this.Cantidad = 0;
        this.TarifaId = 0;
        this.Codigo = "";
        this.ClienteId = 0;
        this.FechaInicio = new Date();
        this.FechaTermino = new Date();
        this.FechaCreacion = new Date();
        this.FechaModifica = new Date();
        this.UnidadMedidaId = 0;
        this.NomMoneda = '';
        this.Precio = 0;
        this.PrecioNeto = 0 ;
        this.CodUsuario = '';
    }
}

export class AlquilerMainEntity {
    AlquilerId: number;
    TipoTablaAlquilerId: number;
    TarifaId: number;
    Codigo: string;
    ClienteId: number;
    PrecioUnitario: number;

    constructor() {
        this.AlquilerId = 0;
        this.TipoTablaAlquilerId = 0;
        this.TarifaId = 0;
        this.Codigo = "";
        this.ClienteId = 0;
        this.PrecioUnitario = 0;
    }
}
