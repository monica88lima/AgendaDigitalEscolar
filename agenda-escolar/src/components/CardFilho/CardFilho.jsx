import React from 'react';
import './CardFilho.css';

const CardFilho = ({ nome, turma, professor }) => {
  return (
      <div className="comunicado-container">
      {/* <div> */}
        <div className="comunicado-header">
          <div className="comunicado-titulo">{nome ? nome : ''}</div>
          <div className="comunicado-data">{turma? turma : ''}</div>
        </div>
        <div className="comunicado-subtitulo">{professor ? professor : ''}</div>
      </div>
  );
};

export default CardFilho;
