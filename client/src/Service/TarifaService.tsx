import { TarifaMainEntity } from '../Models/TarifaEntity';
import { apiLg } from './axios-config';

class TarifaService {

  ServiceName: string = 'Tarifa';

  async getItems(): Promise<TarifaMainEntity[]> {
    try {
      const response = await apiLg.get(`api/${this.ServiceName}/ObtenerMain`);
      return response.status === 200 ? response.data.Value : [];
    } catch (err) {
      return [];
    }
  }


  

}

export default TarifaService;