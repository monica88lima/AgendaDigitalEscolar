import React from 'react';
import { Button } from 'antd';
import { DownloadOutlined, ShareAltOutlined } from '@ant-design/icons';
import './CardFoto.css'; // Importando o arquivo CSS

const CardFoto = ({ imageUrl, imageAlt }) => {
  // Função para baixar a imagem
  const handleDownload = () => {
    const link = document.createElement('a');
    link.href = imageUrl;
    link.download = imageAlt; // Nome do arquivo a ser baixado
    link.click();
  };

  // Função para compartilhar a imagem
  const handleShare = () => {
    if (navigator.share) {
      navigator.share({
        title: imageAlt,
        url: imageUrl,
      }).catch((error) => console.error('Erro ao compartilhar', error));
    } else {
      // Fallback para navegadores que não suportam a API de compartilhamento
      console.log('Compartilhamento não suportado');
    }
  };

  return (
    <div className="card-foto">
      <img alt={imageAlt} src={imageUrl} />
      <div className="card-foto-actions">
        <Button key="download" onClick={handleDownload} className="button-baixar">
            <img src="/images/baixar.png" alt="Baixar" className="card-foto-button-icon" />
        </Button>
        <Button key="share"  onClick={handleShare}>
          Compartilhar
        </Button>
      </div>
    </div>
  );
};

export default CardFoto;
