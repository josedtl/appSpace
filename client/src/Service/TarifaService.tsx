import { TarifaMainEntity } from '../Models/TarifaEntity';
import { apiLg } from './axios-config';

class TarifaService {


  async getItems(): Promise<TarifaMainEntity[]> {
    try {

      const response = await apiLg.get(`api/Tarifa/GetTarifaMain`);
      console.log(response);
      return response.data.value;

    } catch (error) {
      throw error;
    }
  }

}

export default TarifaService;