// /src/App.js
import React from 'react';
import { SafeAreaView } from 'react-native';
import CategoryList from './components/CategoryList';  // CategoryList bileşenini içeri aktarıyoruz

const App = () => {
  return (
    <SafeAreaView style={{ flex: 1 }}>
      <CategoryList />  {/* Kategorileri göster */}
    </SafeAreaView>
  );
};

export default App;
