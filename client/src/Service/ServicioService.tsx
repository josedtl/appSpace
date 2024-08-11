
import {ServicioMainEntity,ServicioSaveEntity } from '../Models/ServicioEntity';
import { apiLg } from './axios-config';

class ServicioService {

    ServiceName: string = 'Servicio';

    async ObtenerMain(): Promise<ServicioMainEntity[]> {
        try {
          const response = await apiLg.get(`api/${this.ServiceName}/ObtenerMain`);
          return response.status === 200 ? response.data.Value : [];
        } catch (err) {
          return [];
        }
      }
    
      async Registrar(item: ServicioSaveEntity): Promise<ServicioSaveEntity> {
        try {
    
          const response = await apiLg.post(`api/${this.ServiceName}/Registrar`, item, {
            headers: { 'Content-Type': 'application/json', },
          });
          return response.status === 200 ? response.data.Value : [];
        } catch (error) {
          console.log(error);
          return new ServicioSaveEntity();
        }
      }
      async Actualizar(item: ServicioSaveEntity): Promise<ServicioSaveEntity> {
        try {
    
          const response = await apiLg.post(`api/${this.ServiceName}/Actualizar`, item, {
            headers: { 'Content-Type': 'application/json', },
          });
    
          return response.status === 200 ? response.data.Value : [];
        } catch (error) {
          console.log(error);
          return new ServicioSaveEntity();
        }
      }
      async ObtenerItem(Id: number): Promise<ServicioSaveEntity[]> {
        try {
          const response = await apiLg.get(`api/${this.ServiceName}/ObtenerItem/${Id}`);
          console.log(response.status);
          return response.status === 200 ? response.data.Value : [];
        } catch (err) {
          console.log(err);
          return [];
        }
      }
     

}

export default ServicioService;