
export class AlquilerEntity {
    Item:number;
    AlquilerId: number;
    TipoTablaAlquilerId: number;
    TarifaId: number;
    Codigo: string;
    ClienteId: number;
    PrecioUnitario: number;

    constructor() {
        this.Item=0;
        this.AlquilerId = 0;
        this.TipoTablaAlquilerId = 0;
        this.TarifaId = 0;
        this.Codigo = "";
        this.ClienteId = 0;
        this.PrecioUnitario = 0;
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
