import axios from 'axios';

const api = axios.create({
    baseUrl: 'https://localhost:7054/api'
})

export default api;