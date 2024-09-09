import React from 'react';
import './CardDetalhes.css'; // Importe o arquivo CSS

const CardDetalhes = ({ titulo, data, subtitulo, descricao, lido, observacao,assinaturaCriador, icone
}) => {
  return (
      <div className="card-detalhes-container">
      {/* <div> */}
        <div className="card-detalhes-header">
          <div className="card-detalhes-titulo">{titulo ? titulo : ''}</div>
          <div className="card-detalhes-data">{data? data : ''}</div>
        </div>
        <div className="card-detalhes-subtitulo">{subtitulo ? subtitulo : ''}</div>
        <div className="card-detalhes-descricao"><p>{descricao ? descricao : ''}</p></div>
        <div className="card-detalhes-descricao"><p>{observacao ? observacao : ''}</p></div>
        <div className="card-detalhes-descricao"><p>{assinaturaCriador ? assinaturaCriador : ''}</p></div>
        <div className="card-detalhes-icone">
          {icone ?  
               <img 
                   src={lido ? 'images/ok.png' : '/images/alerta.png'} 
                   alt={lido ? 'Lido' : 'Não Lido'} 
                 />
                : ''}
        </div>
      </div>
  );
};

export default CardDetalhes;
