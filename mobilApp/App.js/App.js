import React from 'react';
import { SafeAreaView } from 'react-native';
import CategoryList from './components/CategoryList';  // CategoryList'i içeri alıyoruz

const App = () => {
  return (
    <SafeAreaView style={{ flex: 1 }}>
      <CategoryList />  {/* CategoryList bileşenini buraya ekliyoruz */}
    </SafeAreaView>
  );
};

export default App;
