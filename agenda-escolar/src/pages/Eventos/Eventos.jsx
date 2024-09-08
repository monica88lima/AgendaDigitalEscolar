import React from 'react'
import PaginaPadrao from '../PaginaPadao/PaginaPadrao'
import CardEvento from '../../components/CardEvento/CardEvento'
import './Eventos.css';

const Eventos = () => {

    const eventos = [
        {
          titulo: "Reunião de Equipe",
          dataDaMsg: "05 de Setembro, 2024",
          horario: "14:00",
          endereco: "Rua das Flores, 123, São Paulo, SP"
        },
        {
          titulo: "Treinamento de Segurança",
          dataDaMsg: "06 de Setembro, 2024",
          horario: "09:00",
          endereco: "Avenida Paulista, 456, São Paulo, SP"
        },
        {
          titulo: "Workshop de Tecnologia",
          dataDaMsg: "07 de Setembro, 2024",
          horario: "10:30",
          endereco: "Rua Augusta, 789, São Paulo, SP"
        },
        {
          titulo: "Encontro de Networking",
          dataDaMsg: "08 de Setembro, 2024",
          horario: "18:00",
          endereco: "Rua dos Pinheiros, 101, São Paulo, SP"
        },
        {
          titulo: "Palestra Motivacional",
          dataDaMsg: "09 de Setembro, 2024",
          horario: "15:00",
          endereco: "Avenida Faria Lima, 202, São Paulo, SP"
        },
        {
          titulo: "Conferência Anual",
          dataDaMsg: "10 de Setembro, 2024",
          horario: "08:00",
          endereco: "Rua Vergueiro, 303, São Paulo, SP"
        },
        {
          titulo: "Apresentação de Projeto",
          dataDaMsg: "11 de Setembro, 2024",
          horario: "11:00",
          endereco: "Avenida Ibirapuera, 404, São Paulo, SP"
        },
        {
          titulo: "Reunião com Clientes",
          dataDaMsg: "12 de Setembro, 2024",
          horario: "16:00",
          endereco: "Rua da Consolação, 505, São Paulo, SP"
        },
        {
          titulo: "Sessão de Brainstorming",
          dataDaMsg: "13 de Setembro, 2024",
          horario: "13:00",
          endereco: "Rua Bela Cintra, 606, São Paulo, SP"
        },
        {
          titulo: "Seminário de Inovação",
          dataDaMsg: "14 de Setembro, 2024",
          horario: "17:00",
          endereco: "Avenida Rebouças, 707, São Paulo, SP"
        }
      ];
      
  return (
    <div className='container-principal-evento'>
        <PaginaPadrao>
            <div className='container-title'>
                <h1 className='title'>Eventos</h1>
            </div>
            <div >
                {eventos.map(evento => (
                    <CardEvento className='card-evento1'/>
                ))}
            </div>
            
        </PaginaPadrao>
    </div>
  )
}

export default Eventos