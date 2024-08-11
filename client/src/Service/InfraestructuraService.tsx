import { InfraestructuraMainModel, InfraestructuraSaveModel, InfraestructuraFiltroModel } from '../Models/InfraestructuraEntity';
import { apiLg } from './axios-config';

class InfraestructuraService {



    async GetInfraestructuraMain(): Promise<InfraestructuraMainModel[]> {
        try {
            const response = await apiLg.get(`api/Infraestructura/ObtenerMain`);
            return response.status === 200 ? response.data.Value : [];
        } catch (err) {
            console.log(err);
            return [];
        }
    }

    async Registrar(item: InfraestructuraSaveModel): Promise<InfraestructuraSaveModel> {
        try {
            console.log(item);
            const response = await apiLg.post(`api/Infraestructura/Registrar`, item, {
                headers: { 'Content-Type': 'application/json', },
            });
            return response.data.Value;
        } catch (error) {
            console.log(error);
            return new InfraestructuraSaveModel();
        }
    }

    async Actualizar(item: InfraestructuraSaveModel): Promise<InfraestructuraSaveModel> {
        try {

            const response = await apiLg.post(`api/Infraestructura/Actualizar`, item, {
                headers: { 'Content-Type': 'application/json', },
            });

            return response.status === 200 ? response.data.Value : [];
        } catch (error) {
            console.log(error);
            return new InfraestructuraSaveModel();
        }
    }

    async GetInfraestructuraItem(Id: number): Promise<InfraestructuraSaveModel[]> {
        try {
            const response = await apiLg.get(`api/Infraestructura/ObtenerItem/${Id}`);
            console.log(response.status);
            return response.status === 200 ? response.data.Value : [];
        } catch (err) {
            console.log(err);
            return [];
        }
    }

    async GetInfraestructuraObtenerFiltro(): Promise<InfraestructuraFiltroModel[]> {
        try {
            const response = await apiLg.get(`api/Infraestructura/ObtenerFiltroAlquiler`);
            return response.status === 200 ? response.data.Value : [];
        } catch (err) {
            console.log(err);
            return [];
        }
    }

}

export default InfraestructuraService;