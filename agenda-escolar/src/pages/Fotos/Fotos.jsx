import React from 'react'
import PaginaPadrao from '../PaginaPadao/PaginaPadrao'
import CardFoto from '../../components/CardFoto/CardFoto'
import './Fotos.css';

const Fotos = () => {
    const photos = [
        {
          imageUrl: 'https://via.placeholder.com/300?text=Foto+1',
          imageAlt: 'Foto 1'
        },
        {
          imageUrl: 'https://via.placeholder.com/300?text=Foto+2',
          imageAlt: 'Foto 2'
        },
        {
          imageUrl: 'https://via.placeholder.com/300?text=Foto+3',
          imageAlt: 'Foto 3'
        },
        {
          imageUrl: 'https://via.placeholder.com/300?text=Foto+4',
          imageAlt: 'Foto 4'
        },
        {
          imageUrl: 'https://via.placeholder.com/300?text=Foto+5',
          imageAlt: 'Foto 5'
        },
        {
          imageUrl: 'https://via.placeholder.com/300?text=Foto+6',
          imageAlt: 'Foto 6'
        },
        {
          imageUrl: 'https://via.placeholder.com/300?text=Foto+7',
          imageAlt: 'Foto 7'
        },
        {
          imageUrl: 'https://via.placeholder.com/300?text=Foto+8',
          imageAlt: 'Foto 8'
        },
        {
          imageUrl: 'https://via.placeholder.com/300?text=Foto+9',
          imageAlt: 'Foto 9'
        },
        {
          imageUrl: 'https://via.placeholder.com/300?text=Foto+10',
          imageAlt: 'Foto 10'
        }
      ];
  return (
    <div className='container-principal-fotos'>
        <PaginaPadrao>
            <div className='container-fotos'>
                <div className="fotos-container">
                    <img className="fotos-image" alt="Imagem" src='images/foto.png' />
                    <div className="fotos-text">Dia dos pais</div>
                    <div className="fotos-date">agosto/2024</div>
                </div>
                <div>
                    {photos.map((photo, index) => (
                        <CardFoto
                            key={index}
                            imageUrl={photo.imageUrl}
                            imageAlt={photo.imageAlt}
                        />
                    ))}
                    {/* <CardFoto

                    />   */}
                </div>
            </div>
        </PaginaPadrao>
    </div>
  )
}

export default Fotos