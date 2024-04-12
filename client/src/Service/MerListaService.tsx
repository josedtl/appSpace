import { EntidadLikeModel } from '../Models/EntidadLikeModel';
import { MerListaEntity, MerListaTituloModel } from '../Models/MerListaEntity';
import { apiLg } from './axios-config';

class MerListaService {

  async getItems(Codigo :string): Promise<MerListaEntity[]> {
    try {
      const response = await apiLg.get(`api/InfraLista/GetInfraLista_Main/${Codigo}`);
      return response.data.Value;

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


  async saveItem(item: MerListaEntity): Promise<MerListaEntity | null> {
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

  async getItemLike(codigo: string, value: string): Promise<MerListaEntity[]> {
    try {

      const EntLike = new EntidadLikeModel();
      const response = await apiLg.post(`api/InfraLista/GetItemLike`, EntLike, {
        headers: {
          'Content-Type': 'application/json',
        },
      });
      return response.data.Value;
    } catch (error) {
      throw error;
    }
  }


  async getItem(Id: number): Promise<MerListaEntity[]> {
    try {
      const response = await apiLg.get(`api/InfraLista/GetItem/${Id}`);
      return response.data.Value;
    } catch (error) {
      throw error;
    }
  }


  async GetItemTitulo(Codigo :string): Promise<MerListaTituloModel[]> {
    try {
      const response = await apiLg.get(`api/MerLista/GetItemTitulo/${Codigo}`);
      return response.data.Value;

    } catch (error) {
      throw error;
    }
  }
}

export default MerListaService;