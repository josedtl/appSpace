import {InfraListaEntity}from '../Models/InfraListaEntity'
import { apiLg } from './axios-config';

class InfraListaService{

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

}
export default InfraListaService;