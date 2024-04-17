import { EntidadLikeModel } from '../Models/EntidadLikeModel';
import { ServListaMainModel, ServListaModel, ServListaSaveModel } from '../Models/ServListaEntity';
import { apiLg } from './axios-config';

class ServListaService {

  ServiceName: string = 'ServLista';

  async ObtenerMain(Codigo :string): Promise<ServListaMainModel[]> {
    try {
      const response = await apiLg.get(`api/${this.ServiceName}/ObtenerMain/${Codigo}`);
      return response.status === 200 ? response.data.Value : [];
    } catch (err) {
      return [];
    }
  }



  async Registrar(item: ServListaSaveModel): Promise<ServListaSaveModel> {
    try {

      const response = await apiLg.post(`api/${this.ServiceName}/Registrar`, item, {
        headers: { 'Content-Type': 'application/json', },
      });
      return response.status === 200 ? response.data.Value : [];
    } catch (error) {
      console.log(error);
      return new ServListaSaveModel();
    }
  }

  async Actualizar(item: ServListaSaveModel): Promise<ServListaSaveModel> {
    try {

      const response = await apiLg.post(`api/${this.ServiceName}/Actualizar`, item, {
        headers: { 'Content-Type': 'application/json', },
      });

      return response.status === 200 ? response.data.Value : [];
    } catch (error) {
      console.log(error);
      return new ServListaSaveModel();
    }
  }

  async ObtenerItem(Id: number): Promise<ServListaSaveModel[]> {
    try {
      const response = await apiLg.get(`api/${this.ServiceName}/ObtenerItem/${Id}`);
      console.log(response.status);
      return response.status === 200 ? response.data.Value : [];
    } catch (err) {
      console.log(err);
      return [];
    }
  }

  async BuscarRecurso(Nombre: string, Tipo: number): Promise<ServListaModel[]> {
    try {

      const EntLike = new EntidadLikeModel();
      EntLike.srtValor1 = Nombre;
      EntLike.intValor1 = Tipo;
      const response = await apiLg.post(`api/${this.ServiceName}/BuscarServLista`, EntLike, {
        headers: {
          'Content-Type': 'application/json',
        },
      });
      return response.data.Value;
    } catch (error) {
      throw error;
    }
  }
  async ObtenerItemCodigo(Codigo :string): Promise<ServListaMainModel[]> {
    try {
      const response = await apiLg.get(`api/${this.ServiceName}/ObtenerServListaCodigo/${Codigo}`);
      return response.status === 200 ? response.data.Value : [];
    } catch (err) {
      return [];
    }
  }


}

export default ServListaService;