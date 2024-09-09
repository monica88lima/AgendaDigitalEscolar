import React from 'react';
import { Button } from 'antd';
import './CardFoto.css';

const CardFoto = ({ imageUrl, imageAlt }) => {
  const handleDownload = () => {
    const link = document.createElement('a');
    link.href = imageUrl;
    link.download = imageAlt;
    link.click();
  };

  const handleShare = () => {
    if (navigator.share) {
      navigator.share({
        title: imageAlt,
        url: imageUrl,
      }).catch((error) => console.error('Erro ao compartilhar', error));
    } else {
      console.log('Compartilhamento não suportado');
    }
  };

  return (
    <div className="card-foto">
      <img alt={imageAlt} src={imageUrl} />
      <div className="card-foto-actions">
        <div className='container-baixar'>
          <img src="/images/baixar.png" alt="Baixar" className="card-foto-button-icon" onClick={handleDownload}/>    
        </div>
        <div className='container-compartilhar'>
        <img src="/images/compartilhar.jpeg" alt="Compartilhar" className="card-foto-button-icon2" nClick={handleShare}/>
        </div>
      </div>
    </div>
  );
};

export default CardFoto;
