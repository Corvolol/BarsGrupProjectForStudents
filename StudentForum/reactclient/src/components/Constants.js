const API_BASE_URL_DEVELOPMENT = "https://localhost:7191";
const API_BASE_URL_PRODUCTION = "https://appname.azurestaticapps.net";

const ENDPOINTS = {
    REGISTRATION: 'registration',
    LOGIN: 'login',
    USER: 'user',
    TEACHER: 'teacher',
    GET_ALL_TEACHERS: 'get-all-teachers',
    ADD_TEACHER: 'add-teacher',
    DELETE_TEACHER: 'delete-teacher',
    UPDATE_TEACHER: 'update-teacher'
};

const constants = {
    API_URL_REGISTRATION: `${API_BASE_URL_DEVELOPMENT}/${ENDPOINTS.REGISTRATION}`,
    API_URL_LOGIN: `${API_BASE_URL_DEVELOPMENT}/${ENDPOINTS.LOGIN}`,
    API_URL_USER: `${API_BASE_URL_DEVELOPMENT}/${ENDPOINTS.USER}`,
    API_URL_TEACHER: `${API_BASE_URL_DEVELOPMENT}/${ENDPOINTS.TEACHER}`,
    API_URL_GET_ALL_TEACHERS: `${API_BASE_URL_DEVELOPMENT}/${ENDPOINTS.GET_ALL_TEACHERS}`,
    API_URL_ADD_TEACHER: `${API_BASE_URL_DEVELOPMENT}/${ENDPOINTS.ADD_TEACHER}`,
    API_URL_DELETE_TEACHER: `${API_BASE_URL_DEVELOPMENT}/${ENDPOINTS.DELETE_TEACHER}`,
    API_URL_UPDATE_TEACHER: `${API_BASE_URL_DEVELOPMENT}/${ENDPOINTS.UPDATE_TEACHER}`
}

export default constants;