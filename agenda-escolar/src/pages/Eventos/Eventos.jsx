import React, { useEffect, useState } from 'react'
import PaginaPadrao from '../PaginaPadao/PaginaPadrao'
import CardEvento from '../../components/CardEvento/CardEvento'
import './Eventos.css';
import axios from 'axios';
import { useNavigate } from 'react-router-dom';
import { format, parseISO } from 'date-fns';
import { ptBR } from 'date-fns/locale';

const Eventos = () => {
    const [eventos, setEventos] = useState([]);
    const navigate = useNavigate(); // Hook para redirecionar
    const fetchEventos = async () => {
      try {
        const response = await axios.get('https://localhost:7145/api/Eventos');
        console.log('###########@ Dados recebidos:', response.data);
        setEventos(response.data);
      } catch (error) {
        console.error('Erro ao buscar os comunicados:', error);
      }
    };
 
    useEffect(() => {
      fetchEventos();
    }, []);
      
    const handleEventoClick = (eventoId) => {
      localStorage.setItem('selectedeventoId', eventoId);
      navigate(`/detalhes-evento/${eventoId}`);
    };

    
    
  return (
    <div className='container-principal-evento'>
        <PaginaPadrao>
            <div className='container-title'>
                <h1 className='title'>Eventos</h1>
            </div>
            <div >
                {eventos.map(evento => (
                  <button
                    className='button-comunicado' 
                    onClick={() => handleEventoClick(evento.eventoId)} // Passando o ID ao clicar
                  >
                    <CardEvento
                    titulo={evento.titulo}
                    data={evento.data}
                    hora={evento.hora} 
                    dataEvento={ evento.dataEvento} 
                    decricao={evento.descricao}	
                    local={evento.local}
                    className='card-evento1'
                    lido={evento.lido}
                    />
                  </button>
                ))}
            </div>
            
        </PaginaPadrao>
    </div>
  )
}

export default Eventos