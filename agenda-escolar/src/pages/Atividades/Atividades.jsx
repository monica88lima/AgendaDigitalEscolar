import React, { useEffect, useState } from 'react'
import PaginaPadrao from '../PaginaPadao/PaginaPadrao'
import Comunicado from '../../components/CardPadrao/CardPadrao'
import { BellOutlined, CalendarOutlined, CheckCircleOutlined, ExclamationCircleOutlined, InfoCircleOutlined, LockOutlined, MailOutlined, PhoneOutlined, UserOutlined, WarningOutlined } from '@ant-design/icons';
import './Atividades.css';
import axios from 'axios';
import { useNavigate } from 'react-router-dom';

const Atividades = () => {
  const [atividades, setAtividades] = useState([]);
  const navigate = useNavigate(); // Hook para redirecionar

   const fetchComunicados = async () => {
     try {
       const response = await axios.get('https://localhost:7145/api/Atividades');
       console.log('###########@ Dados recebidos:', response.data);
       setAtividades(response.data);
     } catch (error) {
       console.error('Erro ao buscar os comunicados:', error);
     }
   };

   useEffect(() => {
     fetchComunicados();
   }, []);

   const handleAtividadeClick = (atividadeId) => {
    localStorage.setItem('selectedComunicadoId', atividadeId);
    
    // Redireciona para a página de detalhes
    navigate(`/detalhes-atividade/${atividadeId}`);
  };

  return (
    <div className='container-principal-atividades'>
        <PaginaPadrao >
            <div className='title-container'>
                <h1 className='title'>Atividades</h1>
            </div>
            <div className='comunicado-container2'>
                {atividades.map((atividade, index) => (
                  <button
                  className='button-atividade' 
                  onClick={() => handleAtividadeClick(atividade.atividadeId)} // Passando o ID ao clicar
                >
                    <Comunicado
                        key={index}
                        titulo={atividade.titulo}
                        data={atividade.data}
                        subtitulo={atividade.subtitulo}
                        descricao={atividade.descricao}
                        icone={true}
                        lido={atividade.lido}
                    />
                  </button>
                ))}
            </div>
        </PaginaPadrao>
    </div>
  )
}

export default Atividades