import React from 'react'
import PaginaPadrao from '../PaginaPadao/PaginaPadrao'
import Comunicado from '../../components/CardPadrao/CardPadrao'
import { BellOutlined, CalendarOutlined, CheckCircleOutlined, ExclamationCircleOutlined, InfoCircleOutlined, LockOutlined, MailOutlined, PhoneOutlined, UserOutlined, WarningOutlined } from '@ant-design/icons';
import './DetalhesEvento.css';

const DetalhesEvento = () => {

    const comunicado = 
        {
          id: 1,
          titulo: "Importante",
          data: "02 de Setembro, 2024",
          subtitulo: "Notificação",
          descricao: "Esta é uma descrição detalhada do comunicado. Aqui você pode adicionar informações adicionais sobre o que está sendo comunicado.",
        };

  return (
    <div className='container-principal-detalhes-evento'>
        <PaginaPadrao >
            <div className='title-container'>
                <h1 className='title'>Evento</h1>
            </div>
            <div className='comunicado-container2'>
                    <Comunicado
                        key={comunicado.id}
                        titulo={comunicado.titulo}
                        data={comunicado.data}
                        subtitulo={comunicado.subtitulo}
                        descricao={comunicado.descricao}
                        className='detalhe-evento'
                    />
            </div>
            <div className='images-container'>
              <img src="images/check.png" alt="Imagem 2" className="small-detalhe-evento-image" />
            </div>
        </PaginaPadrao>
    </div>
  )
}

export default DetalhesEvento