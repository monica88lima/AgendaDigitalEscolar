import React, { useEffect, useState } from 'react'
import PaginaPadrao from '../PaginaPadao/PaginaPadrao'
import Comunicado from '../../components/CardPadrao/CardPadrao'
import { BellOutlined, CalendarOutlined, CheckCircleOutlined, ExclamationCircleOutlined, InfoCircleOutlined, LockOutlined, MailOutlined, PhoneOutlined, UserOutlined, WarningOutlined } from '@ant-design/icons';
import './DetalhesComunicado.css';
import axios from 'axios';
import { useNavigate, useParams } from 'react-router-dom';
import CardDetalhes from '../../components/CardDetalhes/CardDetalhes';

const DetalhesComunicado = () => {

  const { id } = useParams(); // Pega o ID da URL
  const [comunicado, setComunicado] = useState(null);
  const navigate = useNavigate(); // Hook para redirecionar


  useEffect(() => {
    const fetchComunicado = async () => {
      try {
        const response = await axios.get(`https://localhost:7145/api/Comunicados/${id}`);
        console.log('#####@ Dados recebidos:', response.data);
        setComunicado(response.data);
      } catch (error) {
        console.error('Erro ao buscar os detalhes do comunicado:', error);
      }
    };

    fetchComunicado();
  }, [id]);

  if (!comunicado) {
    return <div>Carregando...</div>;
  }

  const confirmLido = async () => {
    try {
      const response = await axios.put(`https://localhost:7145/marcar_comunicado_lido/${id}`);
      console.log('#####@ Dados recebidos:', response.data);
      setComunicado(response.data);
    } catch (error) {
      console.error('Erro ao buscar os detalhes do comunicado:', error);
    }
    navigate(`/comunicados`);
  }

  return (
    <div className='container-principal-detalhes-comunicado'>
        <PaginaPadrao >
            <div className='title-container'>
                <h1 className='title'>Comunicados</h1>
            </div>
            <div className='comunicado-container2'>
                    <CardDetalhes
                        key={comunicado.id}
                        titulo={comunicado.titulo}
                        data={comunicado.data}
                        subtitulo={comunicado.subtitulo}
                        descricao={comunicado.descricao}
                        observacao={comunicado.observacao}
                        assinaturaCriador={comunicado.assinaturaCriador}
                    />
            </div>
            <div className='images-container'>
              <img src="/images/check.png" alt="Imagem 2" className="small-detalhes-image" onClick={() => confirmLido()}/>
            </div>
        </PaginaPadrao>
    </div>
  )
}

export default DetalhesComunicado