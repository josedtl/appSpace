import { InfraListaEntity, InfraListaModel } from '../Models/InfraListaEntity'
import { ParametroItemModel } from '../Models/ParametroItemModel';
import { apiLg } from './axios-config';

class InfraListaService {

  async getInfraLista(item: InfraListaEntity): Promise<InfraListaEntity | null> {
    try {
      const response = await apiLg.post(`GetInFraLista_Codigo/{codigo}`, item, {
        headers: {
          'Content-Type': 'application/json',
        },
      });
      return response.data.Value;
    } catch (error) {
      throw error;
    }
  }
  async getInfraListaLike(m_Codigo: string, m_Nombre: string): Promise<InfraListaModel[]> {
    try {

      const ItemParametro: ParametroItemModel = new ParametroItemModel();
      ItemParametro.Codigo = m_Codigo;
      ItemParametro.Nombre = m_Nombre;

      const response = await apiLg.post(`api/InfraLista/GetInfraListaLike`, ItemParametro, {
        headers: {
          'Content-Type': 'application/json',
        },
      });
      return response.data;
    } catch (error) {
      throw error;
    }
  }


  // async getInfraListaLike(ItemParametro: ParametroItemModel): Promise<InfraListaModel | null> {
  //   try {
  //     const response = await apiLg.post(`api/InfraLista/GetInfraListaLike`, ItemParametro, {
  //       headers: {
  //         'Content-Type': 'application/json',
  //       },
  //     });
  //     return response.data.Value;
  //   } catch (error) {
  //     throw error;
  //   }
  // }
}
export default InfraListaService;