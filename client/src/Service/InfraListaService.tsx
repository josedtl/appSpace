import { InfraCampoTituloModel, InfraListaModel,InfraListaEntity } from '../Models/InfraListaEntity';
import { ItemLikeModel } from '../Models/Utiladades/ItemLikeModel';
import { apiLg } from './axios-config';

class InfraListaService {

  ServiceName: string = 'InfraLista';

  async ObtenerMain(Codigo: string): Promise<InfraListaEntity[]> {
    try {
      const response = await apiLg.get(`api/${this.ServiceName}/ObtenerMain/${Codigo}`);
      return response.data.Value;

    } catch (error) {
      throw error;
    }
  }

  async Delete(CategoriaId: number): Promise<boolean> {
    try {
      const response = await apiLg.delete(`api/${this.ServiceName}/Delete/${CategoriaId}`);
      return response.data.Value;
    } catch (error) {
      throw error;
    }
  }


  async Registrar(item: InfraListaEntity): Promise<InfraListaEntity | null> {
    try {
      const response = await apiLg.post(`api/${this.ServiceName}/Registrar`, item, {
        headers: {
          'Content-Type': 'application/json',
        },
      });

      return response.data.Value;
    } catch (error) {
      throw error;
    }
  }




  async BuscarItemCodigo(codigo: string, value: string): Promise<InfraListaModel[]> {
    try {

      const EntLike = new ItemLikeModel();
      EntLike.srtValor1 = codigo;
      EntLike.srtValor2 = value;
      const response = await apiLg.post(`api/${this.ServiceName}/Buscar`, EntLike, {
        headers: {
          'Content-Type': 'application/json',
        },
      });
      return response.data.Value;
    } catch (error) {
      throw error;
    }
  }


  async ObtenerItem(Id: number): Promise<InfraListaModel[]> {
    try {
      const response = await apiLg.get(`api/${this.ServiceName}/ObtenerItem/${Id}`);
      console.log(response);
      return response.status === 200 && response.data.State == true ? response.data.Value : [];
    } catch (error) {
      throw error;
    }
  }
  async ObtenerItemEnlace(Id: number): Promise<InfraListaModel[]> {
    try {
      const response = await apiLg.get(`api/${this.ServiceName}/ObtenerItemEnlace/${Id}`);
    
      return response.status === 200 && response.data.State == true ? response.data.Value : [];
    } catch (error) {
      throw error;
    }
  }

  async GetItemTitulo(Codigo: string): Promise<InfraCampoTituloModel[]> {
    try {
      console.log(Codigo);
      const response = await apiLg.get(`api/${this.ServiceName}/ObtenerTitulo/${Codigo}`);
      console.log(response);
      return response.status === 200 && response.data.State == true ? response.data.Value : [];

    } catch (error) {
      throw error;
    }
  }
}

export default InfraListaService;