import React, { useEffect, useState } from 'react'
import PaginaPadrao from '../PaginaPadao/PaginaPadrao'
import Comunicado from '../../components/CardPadrao/CardPadrao'
import { BellOutlined, CalendarOutlined, CheckCircleOutlined, ExclamationCircleOutlined, InfoCircleOutlined, LockOutlined, MailOutlined, PhoneOutlined, UserOutlined, WarningOutlined } from '@ant-design/icons';
import './DetalhesEvento.css';
import { useNavigate, useParams } from 'react-router-dom';
import axios from 'axios';
import { format, parseISO } from 'date-fns';
import { ptBR } from 'date-fns/locale';
import CardDetalhes from '../../components/CardDetalhes/CardDetalhes';

const DetalhesEvento = () => {

    // const comunicado = 
    //     {
    //       id: 1,
    //       titulo: "Importante",
    //       data: "02 de Setembro, 2024",
    //       subtitulo: "Notificação",
    //       descricao: "Esta é uma descrição detalhada do comunicado. Aqui você pode adicionar informações adicionais sobre o que está sendo comunicado.",
    //     };

    const { id } = useParams(); // Pega o ID da URL
    const [evento, setEvento] = useState(null);
    const navigate = useNavigate(); // Hook para redirecionar


    useEffect(() => {
      const fetchComunicado = async () => {
        try {
          const response = await axios.get(`https://localhost:7145/api/Eventos/${id}`);
          console.log('#####@ Dados recebidos:', response.data);
          setEvento(response.data);
        } catch (error) {
          console.error('Erro ao buscar os detalhes do comunicado:', error);
        }
      };

      fetchComunicado();
    }, [id]);

    if (!evento) {
      return <div>Carregando...</div>;
    }

    const eventoLido = async () => {
      try {
        const response = await axios.put(`https://localhost:7145/marcar_evento_lido/${id}`);
        console.log('#####@ Dados recebidos:', response.data);
        setEvento(response.data);
      } catch (error) {
        console.error('Erro ao buscar os detalhes do comunicado:', error);
      }
      navigate(`/eventos`);
    }

  return (
    <div className='container-principal-detalhes-evento'>
        <PaginaPadrao >
            <div className='title-container'>
                <h1 className='title'>Evento</h1>
            </div>
            <div className='comunicado-container2'>
                    <CardDetalhes
                        key={evento.id}
                        titulo={evento.titulo}
                        data={evento.data}
                        subtitulo={evento.subtitulo}
                        descricao={evento.descricao}
                        observacao={evento.local}
                    />
            </div>
            <div className='images-container'>
              <img 
                src="/images/check.png"
                alt="Imagem 2"
                className="small-detalhe-evento-image"  
                onClick={() => eventoLido()}/>
            </div>
        </PaginaPadrao>
    </div>
  )
}

export default DetalhesEvento