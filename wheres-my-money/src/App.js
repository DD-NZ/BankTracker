import React, {useState} from 'react';
import './App.scss';
import Header from './components/header/header'
import { createMuiTheme, ThemeProvider } from '@material-ui/core/styles';
import orange from '@material-ui/core/colors/orange';



const theme = createMuiTheme({
  palette: {
    type: 'dark',
    primary:orange

  },
  typography: {
    htmlFontSize: 12,
  }
});

function App() {
  return (
    <div class="App">
      <ThemeProvider theme={theme}>
        <Header/>
      </ThemeProvider>
    </div>
  );
}

export default App;
