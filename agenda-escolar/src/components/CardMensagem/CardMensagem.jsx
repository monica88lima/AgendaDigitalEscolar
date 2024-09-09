import React from 'react';
import './CardMensagem.css'; // Importe o arquivo CSS

const CardMensagem = ({ titulo, data, subtitulo, descricao, lido, observacao,assinaturaCriador, icone
}) => {
  return (
      <div className="card-mensagem-container">
      {/* <div> */}
        <div className="card-mensagem-header">
          <div className="card-mensagem-titulo">{titulo ? titulo : ''}</div>
          <div className="card-mensagem-data">{data? data : ''}</div>
        </div>
        <div className="card-mensagem-subtitulo">{subtitulo ? subtitulo : ''}</div>
        <div className="card-mensagem-descricao"><p>{descricao ? descricao : ''}</p></div>
        <div className="card-mensagem-icone">
          {lido ?  
               <img 
                   src={'/images/visto.png'} 
                   alt={'Lido'} 
                   className='icone-mesage'
                 />
                : ''}
        </div>
      </div>
  );
};

export default CardMensagem;
