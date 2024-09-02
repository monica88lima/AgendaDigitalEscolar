import React from 'react';
import './InfoEscola.css'; // Importe o arquivo CSS

const InfoEscola = ({ nome, telefone, imagem }) => {
  return (
    <div className="info-escola-container">
      <img src={imagem} alt="Escola" className="info-escola-imagem" />
      <div className="info-escola-text">
        <div className="info-escola-nome">{nome}</div>
        <div>{telefone}</div>
      </div>
    </div>
  );
};

export default InfoEscola;
