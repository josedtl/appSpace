import { EntidadLikeModel } from '../Models/EntidadLikeModel';
import {AlquilerEntity } from '../Models/AlquilerEntity';
import { apiLg } from './axios-config';

class AlquilerService {

  ServiceName: string = 'Alquiler';

  async ObtenerMain(): Promise<AlquilerEntity[]> {
    try {
      const response = await apiLg.get(`api/${this.ServiceName}/ObtenerMain`);
      return response.status === 200 ? response.data.Value : [];
    } catch (err) {
      return [];
    }
  }


}

export default AlquilerService;