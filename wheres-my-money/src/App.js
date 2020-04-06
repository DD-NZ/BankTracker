import React from 'react';
import './App.scss';
import Header from './components/header/header'
import Data from './components/data/data'
import ToolBar from './components/toolbar/toolbar'

function App() {
  return (
    <div class="App">
      <Header/>
      <div class="body">
        <ToolBar/>
        <Data/>
      </div>
    </div>
  );
}

export default App;
