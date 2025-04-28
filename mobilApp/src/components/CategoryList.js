import React, { useState, useEffect } from 'react';
import { View, Text, FlatList, StyleSheet } from 'react-native';
import axios from 'axios';
import Category from './models/Category';  // Modeli içeri aktar

const CategoryList = () => {
  const [categories, setCategories] = useState([]);

  const fetchCategories = async () => {
    try {
      const response = await axios.get('http://localhost:7237/api/Category');
      // API'den gelen veriyi modelle eşle
      const fetchedCategories = response.data.map(
        (item) => new Category(item.categoryId, item.categoryName)  // Model ile eşle
      );
      setCategories(fetchedCategories);
    } catch (error) {
      console.error('Kategori listeleme hatası:', error);
    }
  };

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
