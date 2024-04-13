import { InfraCampoTituloModel, InfraListaEntity } from '../Models/InfraListaEntity';
import { apiLg } from './axios-config';

class InfraListaService {

  async getItems(Codigo :string): Promise<InfraListaEntity[]> {
    try {
      const response = await apiLg.get(`api/InfraLista/GetInfraLista_Main/${Codigo}`);
      return response.data;

    } catch (error) {
      throw error;
    }
  }

  async deleteItem(CategoriaId: number): Promise<boolean> {
    try {
      const response = await apiLg.delete(`api/InfraLista/Delete/${CategoriaId}`);
      return response.data.Value;
    } catch (error) {
      throw error;
    }
  }


  async saveItem(item: InfraListaEntity): Promise<InfraListaEntity | null> {
    try {
      const response = await apiLg.post(`api/InfraLista/Save`, item, {
        headers: {
          'Content-Type': 'application/json',
        },
      });

      return response.data.Value;
    } catch (error) {
      throw error;
    }
  }

  // async getItemLike(codigo: string, value: string): Promise<InfraListaEntity[]> {
  //   try {

  //     const EntLike = new EntidadLikeModel();
  //     EntLike.Valor1 = codigo;
  //     EntLike.Valor2 = value;
  //     const response = await apiLg.post(`api/MerLista/GetItemLike`, EntLike, {
  //       headers: {
  //         'Content-Type': 'application/json',
  //       },
  //     });
  //     return response.data.Value;
  //   } catch (error) {
  //     throw error;
  //   }
  // }


  async getItem(Id: number): Promise<InfraListaEntity[]> {
    try {
      const response = await apiLg.get(`api/InfraLista/GetItem/${Id}`);
      return response.data.Value;
    } catch (error) {
      throw error;
    }
  }


  async GetItemTitulo(Codigo :string): Promise<InfraCampoTituloModel[]> {
    try {
      const response = await apiLg.get(`api/General/GetInfraCampoTitulo/${Codigo}`);
      return response.data;

    } catch (error) {
      throw error;
    }
  }
}

export default InfraListaService;