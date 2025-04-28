import axios from 'axios';

// API URL'ini buraya ekleyin
const API_URL = 'http://192.168.66.206:7237/api/Category';

// axios örneği
const api = axios.create({
  baseURL: API_URL,
  headers: {
    'Content-Type': 'application/json',
  },
});

export default api;
