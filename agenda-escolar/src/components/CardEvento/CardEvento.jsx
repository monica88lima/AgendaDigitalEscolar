import React from 'react';
import { CalendarOutlined, ClockCircleOutlined } from '@ant-design/icons';
import './CardEvento.css';
import { format, parseISO } from 'date-fns';
import { ptBR } from 'date-fns/locale';

const CardEvento = ({titulo,  hora, dataEvento, local, lido}) => {
  const formatarData = (data) => {
    try {
      const date = parseISO(data);
      return format(date, 'dd/MMM', { locale: ptBR });
    } catch (error) {
      return data;
    }
  };

  const formatarData2 = (data) => {
    try {
      const date = parseISO(data);
      return format(date, 'dd/MM/yyyy', { locale: ptBR });
    } catch (error) {
      return data;
    }
  };

  return (
    <div className="card-evento-container">
      <div className="card-header">
        <p className="evento-texto">{titulo}</p>
        <p className="evento-data">{formatarData(dataEvento)}</p>
      </div>

      <div className="card-content">
      {/* <div className="card-content"> */}
        <img src="images/calendario.png" alt="Imagem" className="evento-imagem" />
        <p className="evento-data2">{formatarData2(dataEvento)}</p>
      </div>

      {/* Imagem e texto */}
      <div className="card-content">
        <img src="images/relogio.png" alt="Imagem 1" className="evento-imagem" />
        <p className="evento-descricao">{hora}.</p>
      </div>

      {/* Outra imagem e texto */}
      <div className="card-content">
        <img src="images/localizacao.png" alt="Imagem 2" className="evento-imagem" />
        <p className="evento-descricao">{local}</p>
      </div>

      <div className="card-footer">
      <img 
          src={lido ? '/images/ok.png' : '/images/alerta.png'} 
          alt={lido ? 'Lido' : 'Não Lido'} 
        />
      </div>
    </div>
  );
};

export default CardEvento;
