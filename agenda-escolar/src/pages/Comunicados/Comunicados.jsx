import React, { useEffect, useState } from 'react';
import { useNavigate } from 'react-router-dom'; // Para redirecionamento
import PaginaPadrao from '../PaginaPadao/PaginaPadrao';
import Comunicado from '../../components/CardPadrao/CardPadrao'; // Certifique-se de que o caminho está correto
import './Comunicados.css';
import axios from 'axios';
import { format, parseISO } from 'date-fns';
import { ptBR } from 'date-fns/locale';

const Comunicados = () => {
  const [comunicados, setComunicados] = useState([]);
  const navigate = useNavigate(); // Hook para redirecionar

  // Função para buscar os comunicados
  const fetchComunicados = async () => {
    try {
      const response = await axios.get('https://localhost:7145/api/Comunicados');
      console.log('Dados recebidos:', response.data);
      setComunicados(response.data);
    } catch (error) {
      console.error('Erro ao buscar os comunicados:', error);
    }
  };

  useEffect(() => {
    fetchComunicados();
  }, []);

  const formatarData = (data) => {
    try {
      const date = parseISO(data);
      return format(date, 'dd/MMM', { locale: ptBR });
    } catch (error) {
      return data;
    }
  };
  const handleComunicadoClick = (comunicadoId) => {
    localStorage.setItem('selectedComunicadoId', comunicadoId);
    
    // Redireciona para a página de detalhes
    navigate(`/detalhes-comunicado/${comunicadoId}`);
  };

  return (
    <div className='container-principal-comunicado'>
      <PaginaPadrao>
        <div className='title-container'>
          <h1 className='title'>Comunicados</h1>
        </div>
        <div className='comunicado-container2'>
          {comunicados.map((comunicado) => (
            <button
              className='button-comunicado' 
              onClick={() => handleComunicadoClick(comunicado.comunicadoId)} // Passando o ID ao clicar
            >
            <Comunicado
              key={comunicado.comunicadoId}
              titulo={comunicado.titulo}
              data={formatarData(comunicado.criadoEm)}
              subtitulo={comunicado.subtitulo}
              descricao={comunicado.descricao}
              lido={comunicado.lido}
              icone={true}
            />
            </button>
          ))}
        </div>
      </PaginaPadrao>
    </div>
  );
};

export default Comunicados;
