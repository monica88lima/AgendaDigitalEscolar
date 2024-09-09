import React from 'react'
import PaginaPadrao from '../PaginaPadao/PaginaPadrao'
import CardFoto from '../../components/CardFoto/CardFoto'
import './Fotos.css';

const Fotos = () => {
    const photos = [
        {
          imageUrl: 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRDhh4mwkMig8IYiyuzZS1wP4aGH8mVgc-e4A&s',
          imageAlt: 'Foto 1'
        },
        {
          imageUrl: 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRnjvO2pkRkzJaLfVPVKg4TcR48Mq2ss6KaMg0E7uXR7wsS1wnUSLbmRuGxb-L6z29wdP4&usqp=CAU',
          imageAlt: 'Foto 2'
        },
        {
          imageUrl: 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT5hgUrk2xOce-rU9dR68J4LAQB2okNZXVq9oEA-hwBniPTG2iFCfQXxly66L44LYXmuz0&usqp=CAU',
          imageAlt: 'Foto 3'
        },
        {
          imageUrl: 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRYhaZ6Zw2qWzLWLghNDYKiHtX2CBk9AmAmO0KHjJdzf-wag4jCv0-hLyeCLmOyu8ybMIk&usqp=CAU',
          imageAlt: 'Foto 4'
        }
      ];
  return (
    <div className='container-principal-fotos'>
        <PaginaPadrao>
            <div className='container-fotos'>
                <div className="header-container">
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
                </div>
                <div className="container-roda-pe">
                <div className="imagem-container-roda-pe">
                  <img src="/images/instagram.png" alt="Descrição da imagem" />
                </div>
                <div className="texto-container-roda-pe">
                  <p>Visite nosso instagram @EscolaFlorescer</p>
                </div>
              </div>
            </div>
        </PaginaPadrao>
    </div>
  )
}

export default Fotos