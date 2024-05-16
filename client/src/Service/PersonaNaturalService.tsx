import { PersonaNaturalMainModel, PersonaNaturalSaveModel } from '../Models/PersonaNaturalEntity';
import { apiLg } from './axios-config';

class PersonaNaturalService {

  ServiceName: string = 'PersonaNatural';

  async ObtenerMain(): Promise<PersonaNaturalMainModel[]> {
    try {
      const response = await apiLg.get(`api/${this.ServiceName}/ObtenerMain`);
      return response.status === 200 ? response.data.Value : [];
    } catch (err) {
      return [];
    }
  }



  async Registrar(item: PersonaNaturalSaveModel): Promise<PersonaNaturalSaveModel> {
    try {

      const response = await apiLg.post(`api/${this.ServiceName}/Registrar`, item, {
        headers: { 'Content-Type': 'application/json', },
      });
      return response.data.Value;
    } catch (error) {
      console.log(error);
      return new PersonaNaturalSaveModel();
    }
  }



  async ObtenerItem(Id: number): Promise<PersonaNaturalSaveModel[]> {
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

export default PersonaNaturalService;