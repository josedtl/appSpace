import axios from 'axios';

const URL = process.env.NEXT_PUBLIC_SERVER_API_BASE_URL;
const apiSpace = axios.create({
    baseURL: URL,
});

const apiGeneral = axios.create({
    baseURL: URL,
});

// Interceptores de errores globales para api1
apiSpace.interceptors.response.use(
    (response) => {
        return response;
    },
    (error) => {
        console.error('Error en la solicitud de la primera API:', error);
        return Promise.reject(error);
    }
);

// Interceptores de errores globales para apiGeneral
apiGeneral.interceptors.response.use(
    (response) => {
        return response;
    },
    (error) => {
        console.error('Error en la solicitud de la segunda API:', error);
        return Promise.reject(error);
    }
);

// Función para establecer el token de autorización en las solicitudes
const setAuthorizationToken = (token: string) => {
    apiSpace.defaults.headers.common['Authorization'] = `Bearer ${token}`;
    apiGeneral.defaults.headers.common['Authorization'] = `Bearer ${token}`;
};




export { apiSpace, apiGeneral, setAuthorizationToken };