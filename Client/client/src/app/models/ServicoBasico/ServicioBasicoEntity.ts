export interface ServicioBasicoEntity {
    Item: number,
    ServicioBasicoId: number,
    Codigo?:String,
    Nombre?: string,
    Descripcion?: string,
    FechaRegistro?: Date,
    CodUsuario?: string,
    EstadoRegistro?: boolean,
    Action?: number,
    Seleccion:boolean
};