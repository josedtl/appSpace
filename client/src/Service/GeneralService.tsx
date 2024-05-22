import { UnidadMedidaModel } from '../Models/UnidadMedidaEntity';
import { TipoDocumentoIdentidadEntity } from '../Models/TipoDocumentoIdentidadEntity';
import { UbigeoEntity } from '../Models/UbigeoEntity';
import { PersonaNaturalEntity } from '../Models/PersonaNaturalEntity';
import { apiLg } from './axios-config';
import { TipoEntidadItemModel } from '../Models/GeneralEntity';
import { EntidadLikeModel } from '../Models/EntidadLikeModel';
import { MonedaModel } from '../Models/MonedaModel';
import { EntidadEntity } from '../Models/EntidadEntity';
class GeneralService {

  ServiceName: string = 'General';

  async ObtenerMonedaItems(): Promise<MonedaModel[]> {
    try {
      const response = await apiLg.get(`api/${this.ServiceName}/ObtenerMonedaItems`);
      return response.status === 200 ? response.data.Value : [];
    } catch (err) {
      return [];
    }
  }

  async ObtenerUnidadMedidaItems(): Promise<UnidadMedidaModel[]> {
    try {
      const response = await apiLg.get(`api/${this.ServiceName}/ObtenerUnidadMedidaItems`);
      return response.status === 200 ? response.data.Value : [];
    } catch (err) {
      return [];
    }
  }


  async GetUbigeoApiItem(Id: number): Promise<UbigeoEntity[]> {
    try {
      const response = await apiLg.get(`api/Ubigeo/GetItem/${Id}`);
      return response.data.Value;
    } catch (error) {
      throw error;
    }
  }

  async GetPersonaBuscardocumento(NumDocumento: string): Promise<PersonaNaturalEntity[]> {
    try {
      const response = await apiLg.get(`api/General/GetBuscardocumento/${NumDocumento}/`);
      return response.data.Value;
    } catch (error) {
      throw error;
    }
  }


  async GetTipoDocumentoIdentidadPorEstadoItems(): Promise<TipoDocumentoIdentidadEntity[]> {
    try {
      const response = await apiLg.get(`api/General/GetTipoDocumentoIdentidadPorEstadoItems`);
      return response.data.Value;
    } catch (error) {
      throw error;
    }
  }




  async GetUbigeoItemLikeApi(codigo: string): Promise<UbigeoEntity[]> {
    try {

      const EntLike = new EntidadLikeModel();
      EntLike.srtValor1 = codigo;
      const response = await apiLg.post(`api/General/BuscarUbigeoItem`, EntLike, {
        headers: {
          'Content-Type': 'application/json',
        },
      });
      return response.data.Value;
    } catch (error) {
      throw error;
    }
  }

  async GetUbigeoItemApi(Value: number): Promise<UbigeoEntity[]> {
    try {
      const response = await apiLg.get(`api/General/ObtenerUbigeoItem/${Value}`);
      return response.status === 200 ? response.data.Value : [];
    } catch (error) {
      throw error;
    }
  }

  async GetEntidadBuscarItem(NombreCompleto: string): Promise<EntidadEntity[]> {
    try {

      const EntLike = new EntidadLikeModel();
      EntLike.srtValor1 = NombreCompleto;
      const response = await apiLg.post(`api/General/GetEntidadBuscarItem`, EntLike, {
        headers: {
          'Content-Type': 'application/json',
        },
      });
      return response.data.Value;
    } catch (error) {
      throw error;
    }
  }

  async GetTipoEntidadObtenerItems(): Promise<TipoEntidadItemModel[]> {
    try {
      const response = await apiLg.get(`api/General/TipoEntidadObtenerItems`);
      return response.data.Value;
    } catch (error) {
      throw error;
    }
  }


}

export default GeneralService;