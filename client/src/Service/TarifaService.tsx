import { EntidadLikeModel } from '../Models/EntidadLikeModel';
import { TarifaBuscarRecursoModel, TarifaMainEntity, TarifaSaveModel, TarifaBuscarItem } from '../Models/TarifaEntity';
import { apiLg } from './axios-config';

class TarifaService {

  ServiceName: string = 'Tarifa';

  async ObtenerMain(): Promise<TarifaMainEntity[]> {
    try {
      const response = await apiLg.get(`api/${this.ServiceName}/ObtenerMain`);
      return response.status === 200 ? response.data.Value : [];
    } catch (err) {
      return [];
    }
  }



  async Registrar(item: TarifaSaveModel): Promise<TarifaSaveModel> {
    try {

      const response = await apiLg.post(`api/${this.ServiceName}/Registrar`, item, {
        headers: { 'Content-Type': 'application/json', },
      });
      return response.status === 200 ? response.data.Value : [];
    } catch (error) {
      console.log(error);
      return new TarifaSaveModel();
    }
  }

  async Actualizar(item: TarifaSaveModel): Promise<TarifaSaveModel> {
    try {

      const response = await apiLg.post(`api/${this.ServiceName}/Actualizar`, item, {
        headers: { 'Content-Type': 'application/json', },
      });

      return response.status === 200 ? response.data.Value : [];
    } catch (error) {
      console.log(error);
      return new TarifaSaveModel();
    }
  }

  async ObtenerItem(Id: number): Promise<TarifaSaveModel[]> {
    try {
      const response = await apiLg.get(`api/${this.ServiceName}/ObtenerItem/${Id}`);
      console.log(response.status);
      return response.status === 200 ? response.data.Value : [];
    } catch (err) {
      console.log(err);
      return [];
    }
  }

  async BuscarRecurso(Nombre: string, Tipo: number): Promise<TarifaBuscarRecursoModel[]> {
    try {

      const EntLike = new EntidadLikeModel();
      EntLike.srtValor1 = Nombre;
      EntLike.intValor1 = Tipo;
      const response = await apiLg.post(`api/${this.ServiceName}/BuscarRecurso`, EntLike, {
        headers: {
          'Content-Type': 'application/json',
        },
      });
      return response.data.Value;
    } catch (error) {
      throw error;
    }
  }

  async GetTarifaBuscarItem(NomComercial: string): Promise<TarifaBuscarItem[]> {
    try {
      const EntLike = new TarifaBuscarItem();
      EntLike.NomComercial =  NomComercial ; 
      const response = await apiLg.post(`api/${this.ServiceName}/GetTarifaBuscarItem`, EntLike, {
        headers: {
          'Content-Type': 'application/json',
        },
      });
      return response.data.Value;
    } catch (error) {
      throw error;
    }
  }


}

export default TarifaService;