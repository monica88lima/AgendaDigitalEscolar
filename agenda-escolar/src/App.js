import { BrowserRouter, Route, Routes } from 'react-router-dom';
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

function App() {
  return (
    <div className="app">
      <BrowserRouter>
        <Routes>
          <Route path="/login" element={<Login/>} />
          <Route path="/home" element={<PaginaIncial/>} />
          <Route path="/comunicados" element={<Comunicados/>} />
          <Route path="/agenda" element={<Agenda/>} />
          <Route path="/eventos" element={<Eventos/>} />
          <Route path="/mural-de-fotos" element={<MuralDeFotos/>} />
          <Route path="/financeiro" element={<Financeiro/>} />
          <Route path="/atividades" element={<Atividades/>} />
          <Route path="/mensagens" element={<Mensagens/>} />
          <Route path="/mensagem" element={<Mensagem/>} />
          <Route path="/detalhes-comunicado" element={<DetalhesComunicado/>} />
          <Route path="/detalhes-evento" element={<DetalhesEvento/>} />
          <Route path="/perfil" element={<Perfil/>} />
          <Route path="/detalhes-atividade" element={<Atividade/>} />
          <Route path="/redefinir-senha" element={<RedefinirSenha/>} />
          <Route path="/fotos" element={<Fotos/>} />
        </Routes>
      </BrowserRouter>
    </div>
  );
}

export default App;
