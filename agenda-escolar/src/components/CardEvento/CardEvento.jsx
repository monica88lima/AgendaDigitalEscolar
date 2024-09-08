import React from 'react';
import { CalendarOutlined, ClockCircleOutlined } from '@ant-design/icons';
import './CardEvento.css';

const CardEvento = () => {
  return (
    <div className="card-evento-container">
      {/* Texto em negrito e data */}
      <div className="card-header">
        <p className="evento-texto">Título do Evento</p>
        <p className="evento-data">12/Setembro</p>
      </div>

      {/* Ícone e data */}
      <div className="card-subheader">
      <img src="images/calendario.png" alt="Imagem" className="evento-imagem" />
        {/* <CalendarOutlined className="icon-left" /> */}
        <p className="evento-hora">14:00</p>
      </div>

      {/* Imagem e texto */}
      <div className="card-content">
        <img src="images/relogio.png" alt="Imagem 1" className="evento-imagem" />
        <p className="evento-descricao">Descrição do evento relacionado à imagem 1.</p>
      </div>

      {/* Outra imagem e texto */}
      <div className="card-content">
        <img src="images/localizacao.png" alt="Imagem 2" className="evento-imagem" />
        <p className="evento-descricao">Descrição do evento relacionado à imagem 2.</p>
      </div>

      {/* Ícone à direita */}
      <div className="card-footer">
        <ClockCircleOutlined className="icon-right" />
      </div>
    </div>
  );
};

export default CardEvento;
