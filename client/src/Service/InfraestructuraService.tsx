
import { apiLg } from './axios-config';
import {InfraestructuraMainModel} from '../Models/InfraestructuraEntity'

class InfraestructuraService {


  async getItems(): Promise<InfraestructuraMainModel[]> {
    try {
      const response = await apiLg.get(`api/Infraestructura/GetInfraestructuraMain`);
      return response.data;

    } catch (error) {
      throw error;
    }
  }


}

export default InfraestructuraService;