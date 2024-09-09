import React from 'react';
import './MuralDeFotos.css';
import PaginaPadrao from '../PaginaPadao/PaginaPadrao';
import CardDeFotos from '../../components/CardDeFotos/CardDeFotos';

const MuralDeFotos = () => {

    const fotos = [
        {
          titulo: "Passeio no Parque",
          data: "01 de Setembro, 2024"
        },
        {
          titulo: "Reunião de Amigos",
          data: "02 de Setembro, 2024"
        },
        {
          titulo: "Aniversário de João",
          data: "03 de Setembro, 2024"
        },
        {
          titulo: "Viagem à Praia",
          data: "04 de Setembro, 2024"
        },
        {
          titulo: "Almoço em Família",
          data: "05 de Setembro, 2024"
        },
        {
          titulo: "Passeio de Bicicleta",
          data: "06 de Setembro, 2024"
        },
        {
          titulo: "Show de Música",
          data: "07 de Setembro, 2024"
        },
        {
          titulo: "Cinema com Amigos",
          data: "08 de Setembro, 2024"
        },
        {
          titulo: "Piquenique",
          data: "09 de Setembro, 2024"
        },
        {
          titulo: "Visita ao Museu",
          data: "10 de Setembro, 2024"
        }
      ];
      
    return (
        <div className='container-principal-mural-fotos'>
            <PaginaPadrao >
                <div className='container-card-foto-evento'>
                    {fotos.map((foto, index) => (
                        <CardDeFotos 
                            key={index} 
                            texto={foto.titulo} 
                            data={foto.data} 
                        />
                    ))}
                </div>
            </PaginaPadrao>
        </div>
    );
};

export default MuralDeFotos;
