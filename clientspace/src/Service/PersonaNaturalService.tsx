import { PersonaNaturalEntity } from '../Models/PersonaNaturalEntity';
import { apiSpace } from './axios-config';

class PersonaNaturalService {

  async getItems(): Promise<PersonaNaturalEntity[]> {
    try {
      const response = await apiSpace.get(`api/PersonaNatural/GetItems`);
      return response.data.Value;

    } catch (error) {
      throw error;
    }
  }

  async deleteItem(PersonaNaturalId: number): Promise<boolean> {
    try {
      const response = await apiSpace.delete(`api/PersonaNatural/Delete/${PersonaNaturalId}`);
      return response.data.Value;
    } catch (error) {
      throw error;
    }
  }


  async saveItem(item: PersonaNaturalEntity): Promise<PersonaNaturalEntity | null> {
    try {
      const response = await apiSpace.post(`api/PersonaNatural/Save`, item, {
        headers: {
          'Content-Type': 'application/json',
        },
      });
      return response.data.Value;
    } catch (error) {
      throw error;
    }
  }

  async getItemLike(Nombre: string): Promise<PersonaNaturalEntity[]> {
    try {
      const response = await apiSpace.get(`api/PersonaNatural/GetItemLike/${Nombre}`);
      return response.data.Value;
    } catch (error) {
      throw error;
    }
  }


  async getItem(Id: number): Promise<PersonaNaturalEntity[]> {
    try {
      const response = await apiSpace.get(`api/PersonaNatural/GetItem/${Id}`);
      return response.data.Value;
    } catch (error) {
      throw error;
    }
  }

}

export default PersonaNaturalService;