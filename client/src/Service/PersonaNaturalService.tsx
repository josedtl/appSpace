import axios from 'axios';
import { PersonaNaturalEntity } from '../Models/PersonaNaturalEntity';
import { apiLg } from './axios-config';

const URL = import.meta.env.VITE_SOME_KEY;
class PersonaNaturalService {



  async getItems(): Promise<PersonaNaturalEntity[]> {
    try {
      const response = await axios.get(`${URL}/api/PersonaNatural/GetItems/`);
      console.log(response.status);
      if (response.status === 200 && response.data.Value != null) {
        return response.data.Value;
      }
      return [];
    } catch (err) {
      console.log(err);
      return [];
    }
  }
  async deleteItem(PersonaNaturalId: number): Promise<boolean> {
    try {
      const response = await axios.delete(`${URL}/api/PersonaNatural/Delete/${PersonaNaturalId}`);
      return response.status === 200;
    } catch (error) {
      console.log(error);
      return false;
    }
  }


  async saveItem(item: PersonaNaturalEntity): Promise<PersonaNaturalEntity | null> {
    try {

      const response = await apiLg.post(`api/PersonaNatural/Registrar`, item, {
        headers: {
          'Content-Type': 'application/json',
        },
      });

      if (response.status === 200) {
        return response.data;
      } else {
        console.log('Save operation failed');
        return null;
      }
    } catch (error) {
      console.log(error);
      return null;
    }
  }

  async UpdateItem(item: PersonaNaturalEntity): Promise<PersonaNaturalEntity | null> {
    try {

      const response = await apiLg.post(`api/PersonaNatural/Actualizar`, item, {
        headers: {
          'Content-Type': 'application/json',
        },
      });

      if (response.status === 200) {
        return response.data;
      } else {
        console.log('Save operation failed');
        return null;
      }
    } catch (error) {
      console.log(error);
      return null;
    }
  }

  async getItem(Id :number): Promise<PersonaNaturalEntity[]> {
    try {
      const response = await axios.get(`${URL}/api/PersonaNatural/GetItem/${Id}`);
      console.log(response.status);
      if (response.status === 200 && response.data.Value != null) {
        return response.data.Value;
      }
      return [];
    } catch (err) {
      console.log(err);
      return [];
    }
  }


  async getMainItems(): Promise<PersonaNaturalEntity[]> {
    try {
      const response = await apiLg.get(`api/PersonaNatural/GetPersonaNaturalMain`);
      return response.data;

    } catch (error) {
      throw error;
    }
  }

  async GetCabeceraItem(Id: number): Promise<PersonaNaturalEntity[]> {
    try {
      const response = await apiLg.get(`api/PersonaNatural/GetPersonaNaturalItem/${Id}`);
      return response.data;
    } catch (error) {
      throw error;
    }
  }

}

export default PersonaNaturalService;