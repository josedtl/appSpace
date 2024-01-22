import { ListaRelacionEntity } from '../Models/ListaSaveModel';
import { apiLg } from './axios-config';

class ListaRelacionService {

  async getItems(Codigo: string): Promise<ListaRelacionEntity[]> {
    try {
      const response = await apiLg.get(`api/ListaRelacion/GetListaRelacion_Main/${Codigo}`);
      return response.data;

    } catch (error) {
      throw error;
    }
  }

  async deleteItem(MarcaId: number): Promise<boolean> {
    try {
      const response = await apiLg.delete(`api/Marca/Delete/${MarcaId}`);
      return response.data.Value;
    } catch (error) {
      throw error;
    }
  }


  async saveItem(item: ListaRelacionEntity): Promise<ListaRelacionEntity | null> {
    try {
      const response = await apiLg.post(`api/ListaRelacion/Registrar/`, item, {
        headers: {
          'Content-Type': 'application/json',
        },
      });
      return response.data;
    } catch (error) {
      throw error;
    }
  }

  // async getItemLike(Nombre: string): Promise<MarcaEntity[]> {
  //   try {
  //     const response = await apiLg.get(`api/Marca/GetItemLike/${Nombre}`);
  //     return response.data.Value;
  //   } catch (error) {
  //     throw error;
  //   }
  // }


  // async getItem(Id: number): Promise<MarcaEntity[]> {
  //   try {
  //     const response = await apiLg.get(`api/Marca/GetItem/${Id}`);
  //     return response.data.Value;
  //   } catch (error) {
  //     throw error;
  //   }
  // }

}

export default ListaRelacionService;