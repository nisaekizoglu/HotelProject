import api from './api';  // api.js'den axios örneğini içeri alıyoruz.

// Kategorileri listele
const getCategories = async () => {
  try {
    const response = await api.get('/');
    return response.data;  // Kategori listesi
  } catch (error) {
    throw new Error('Kategoriler alınırken hata oluştu');
  }
};

// Yeni kategori ekle
const addCategory = async (category) => {
  try {
    const response = await api.post('/', category);
    return response.data;  // Yeni kategori verisi
  } catch (error) {
    throw new Error('Kategori eklenirken hata oluştu');
  }
};

// Kategori sil
const deleteCategory = async (id) => {
  try {
    await api.delete(`/${id}`);
  } catch (error) {
    throw new Error('Kategori silinirken hata oluştu');
  }
};

// Kategori güncelle
const updateCategory = async (category) => {
  try {
    const response = await api.put(`/${category.id}`, category);
    return response.data;  // Güncellenmiş kategori verisi
  } catch (error) {
    throw new Error('Kategori güncellenirken hata oluştu');
  }
};

export default {
  getCategories,
  addCategory,
  deleteCategory,
  updateCategory,
};
