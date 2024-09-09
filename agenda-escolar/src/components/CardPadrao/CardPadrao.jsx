import React from 'react';
import './CardPadrao.css'; // Importe o arquivo CSS
import { InfoCircleOutlined } from '@ant-design/icons'; // Exemplo de ícone do Ant Design

const CardPadrao = ({ titulo, data, subtitulo, descricao, lido, observacao,assinaturaCriador, icone,
}) => {
  return (
      <div className="card-padrao-container">
      {/* <div> */}
        <div className="card-padrao-header">
          <div className="card-padrao-titulo">{titulo ? titulo : ''}</div>
          <div className="card-padrao-data">{data? data : ''}</div>
        </div>
        <div className="card-padrao-subtitulo">{subtitulo ? subtitulo : ''}</div>
        <div className="card-padrao-descricao"><p>{descricao ? descricao : ''}</p></div>
        <div className="card-padrao-icone">
          {icone ?  
               <img 
                   src={lido ? '/images/ok.png' : '/images/alerta.png'} 
                   alt={lido ? 'Lido' : 'Não Lido'} 
                 />
                : ''}
        </div>
      </div>
  );
};

export default CardPadrao;
