import { BrowserRouter, Route, Routes } from 'react-router-dom';
import './App.css';
import Login from './pages/Login/Login';
import PaginaIncial from './pages/PaginaIncial/PaginaIncial';

function App() {
  return (
    <div className="App">
      <BrowserRouter>
        <Routes>
          <Route path="/login" element={<Login/>} />
          <Route path="/home" element={<PaginaIncial/>} />
        </Routes>
      </BrowserRouter>
    </div>
  );
}

export default App;
