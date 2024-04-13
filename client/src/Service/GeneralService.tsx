import { CategoriaEntity } from '../Models/CategoriaEntity';
import { TipoProductoEntity } from '../Models/TipoProductoEntity';
import { MarcaEntity } from '../Models/MarcaEntity';
import { ModeloEntity } from '../Models/ModeloEntity';
import { UnidadMedidaEntity, UnidadMedidaModel } from '../Models/UnidadMedidaEntity';
import { SexoEntity } from '../Models/SexoEntity';
import { EstadoCivilEntity } from '../Models/EstadoCivilEntity';
import { TipoDocumentoIdentidadEntity } from '../Models/TipoDocumentoIdentidadEntity';
import { UbigeoEntity } from '../Models/UbigeoEntity';
import { PersonaNaturalEntity } from '../Models/PersonaNaturalEntity';
import { apiLg } from './axios-config';
import { ProductoEntity } from '../Models/ProductoEntity';
import { EstadoProcesoEntity, TipoProcesoEntity } from '../Models/GeneralEntity';
import { EmpresaEntity } from '../Models/EmpresaEntity';
import { EntidadLikeModel } from '../Models/EntidadLikeModel';
import { MonedaModel } from '../Models/MonedaModel';

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

  async GetEmpresaBuscaDocumento(NumDocumento: string): Promise<EmpresaEntity[]> {
    try {
      const response = await apiLg.get(`api/General/GetEmpresaBuscaDocumento/${NumDocumento}/`);
      return response.data.Value;
    } catch (error) {
      throw error;
    }
  }


  async GetUbigeoItemLikeApi(codigo: string): Promise<UbigeoEntity[]> {
    try {

      const EntLike = new EntidadLikeModel();
      EntLike.srtValor1 = codigo;
      const response = await apiLg.post(`api/General/GetUbigeoBuscarLike`, EntLike, {
        headers: {
          'Content-Type': 'application/json',
        },
      });
      return response.data ;
    } catch (error) {
      throw error;
    }
  }

  async GetUbigeoItemApi(Value: number): Promise<UbigeoEntity[]> {
    try {
      const response = await apiLg.get(`api/General/GetUbigeoItem/${Value}`);
      return response.data;
    } catch (error) {
      throw error;
    }
  }

}

export default GeneralService;