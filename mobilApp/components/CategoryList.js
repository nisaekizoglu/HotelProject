import React, { useEffect, useState } from 'react';
import { View, Text, FlatList, StyleSheet, Button } from 'react-native';
import CategoryService from '../services/CategoryService';  // CategoryService'yi içeri alıyoruz

const CategoryList = () => {
  const [categories, setCategories] = useState([]);

  // Kategorileri listele
  const fetchCategories = async () => {
    try {
      const categoryData = await CategoryService.getCategories();
      setCategories(categoryData);
    } catch (error) {
      console.error('Kategori listeleme hatası:', error);
    }
  };

  // Kategori silme
  const handleDeleteCategory = async (id) => {
    try {
      await CategoryService.deleteCategory(id);
      fetchCategories();  // Listeyi tekrar güncelle
    } catch (error) {
      console.error('Kategori silme hatası:', error);
    }
  };

  // İlk render'da kategorileri çek
  useEffect(() => {
    fetchCategories();
  }, []);

  return (
    <View style={styles.container}>
      <Text style={styles.title}>Kategoriler</Text>
      <FlatList
        data={categories}
        keyExtractor={(item) => item.id.toString()}
        renderItem={({ item }) => (
          <View style={styles.itemContainer}>
            <Text style={styles.itemText}>{item.name}</Text>
            <Button title="Sil" onPress={() => handleDeleteCategory(item.id)} />
          </View>
        )}
      />
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
    padding: 20,
  },
  title: {
    fontSize: 24,
    marginBottom: 20,
    textAlign: 'center',
  },
  itemContainer: {
    padding: 10,
    borderBottomWidth: 1,
    borderColor: '#ccc',
  },
  itemText: {
    fontSize: 18,
  },
});

export default CategoryList;
