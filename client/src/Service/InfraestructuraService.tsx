
import { apiLg } from './axios-config';
import {InfraestructuraMainModel} from '../Models/InfraestructuraEntity'
import {InfraestructuraSaveModel} from '../Models/InfraestructuraEntity'
class InfraestructuraService {


  async getItems(): Promise<InfraestructuraMainModel[]> {
    try {
      const response = await apiLg.get(`api/Infraestructura/GetInfraestructuraMain`);
      return response.data;

    } catch (error) {
      throw error;
    }
  }
  async saveItem(item: InfraestructuraSaveModel): Promise<InfraestructuraSaveModel | null> {
    try {
      const response = await apiLg.post(`api/Infraestructura/Registrar/`, item, {
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

export default InfraestructuraService;