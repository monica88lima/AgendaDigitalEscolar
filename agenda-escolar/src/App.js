import { BrowserRouter, Navigate, Route, Routes } from 'react-router-dom';
import './App.css';
import Login from './pages/Login/Login';
import PaginaIncial from './pages/PaginaIncial/PaginaIncial';
import Comunicados from './pages/Comunicados/Comunicados';
import Agenda from './pages/Agenda/Agenda';
import Eventos from './pages/Eventos/Eventos';
import MuralDeFotos from './pages/MuralDeFotos/MuralDeFotos';
import Financeiro from './pages/Financeiro/Financeiro';
import Atividades from './pages/Atividades/Atividades';
import Mensagens from './pages/Mensagens/Mensagens';
import DetalhesComunicado from './pages/DetalhesComunicado/DetalhesComunicado';
import DetalhesEvento from './pages/DetalhesEvento/DetalhesEvento';
import Perfil from './pages/Perfil/Perfil';
import Atividade from './pages/DetalhesAtividade/DetalhesAtividade';
import Mensagem from './pages/Mensagem/Mensagem';
import RedefinirSenha from './pages/RedefinirSenha/RedefinirSenha';
import Fotos from './pages/Fotos/Fotos';
import { useEffect, useState } from 'react';

function App() {
  const [isLoggedIn, setIsLoggedIn] = useState(localStorage.getItem('isLoggedIn') === 'true');
  
  // useEffecr(() => {
  //   // Monitora alterações no localStorage e atualiza o estado carFound
  //   const handleStorageChange = () => {
  //     const storedCarFound = localStorage.getItem('carFound') === 'true';
  //     setCarFound(storedCarFound);
  //   };

  //   window.addEventListener('storage', handleStorageChange);

  //   // Limpa o evento de escuta ao desmontar o componente
  //   return () => {
  //     window.removeEventListener('storage', handleStorageChange);
  //   };
  // }, []);
  useEffect(() => {
    // Monitora alterações no localStorage e atualiza o estado isLoggedIn
    const handleStorageChange = () => {
      const storedIsLoggedIn = localStorage.getItem('isLoggedIn') === 'true';
      setIsLoggedIn(storedIsLoggedIn);
    };

    window.addEventListener('storage', handleStorageChange);

    // Limpa o evento de escuta ao desmontar o componente
    return () => {
      window.removeEventListener('storage', handleStorageChange);
    };
  }, []);
  return (
    <div className="app">
      <BrowserRouter>
        <Routes>
          <Route path="/" element={!isLoggedIn === false ? <Login /> : <Navigate to="/home" />} />
          <Route path="/home" element={isLoggedIn ? <PaginaIncial/> : <Login />} />
          <Route path="/comunicados" element={isLoggedIn ? <Comunicados/> : <Login />} />
          <Route path="/agenda" element={isLoggedIn ? <Agenda/> : <Login />} />
          <Route path="/eventos" element={isLoggedIn ? <Eventos/> : <Login />} />
          <Route path="/mural-de-fotos" element={isLoggedIn ? <MuralDeFotos/> : <Login />} />
          <Route path="/financeiro" element={isLoggedIn ? <Financeiro/> : <Login />} />
          <Route path="/atividades" element={isLoggedIn ? <Atividades/> : <Login />} />
          <Route path="/mensagens" element={isLoggedIn ? <Mensagens/> : <Login />} />
          <Route path="/mensagem" element={isLoggedIn ? <Mensagem/> : <Login />} />
          <Route path="/detalhes-comunicado/:id" element={isLoggedIn ? <DetalhesComunicado/> : <Login />} />
          <Route path="/detalhes-evento/:id" element={isLoggedIn ? <DetalhesEvento/> : <Login />} />
          <Route path="/perfil" element={isLoggedIn ? <Perfil/> : <Login />} />
          <Route path="/detalhes-atividade/:id" element={isLoggedIn ? <Atividade/> : <Login />} />
          <Route path="/redefinir-senha" element={isLoggedIn ? <RedefinirSenha/> : <Login />} />
          <Route path="/fotos" element={isLoggedIn ? <Fotos/> : <Login />} />
        </Routes>
      </BrowserRouter>
    </div>
  );
}

export default App;
