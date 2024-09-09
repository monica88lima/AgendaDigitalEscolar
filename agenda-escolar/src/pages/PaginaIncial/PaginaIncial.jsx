import React, { useEffect, useState } from 'react'
import PaginaPadrao from '../PaginaPadao/PaginaPadrao'
import Card from '../../components/Card/Card'
import './PaginaIncial.css'
import { Col } from 'antd'
import InfoEscola from '../../components/InfoEscola/InfoEscola'
import axios from 'axios'

const PaginaIncial = () => {
  const [escola, setEscola] = useState(null);

  useEffect(() => {
    const fetchComunicado = async () => {
      try {
        const response = await axios.get(`https://localhost:7145/api/Escolas/1`);
        console.log('#####@ Dados recebidos:', response.data);
        setEscola(response.data);
      } catch (error) {
        console.error('Erro ao buscar os detalhes do comunicado:', error);
      }
    };

    fetchComunicado();
  }, []);

  return (
    <div >
      <PaginaPadrao>
        <div className='container-pagina-inicial'>
          <div className='container-info-escola-container'>
               <InfoEscola
              nome={escola?.nome}
              telefone={escola?.telefone}
              imagem="/images/escola-florecer.jpeg"
            />
          </div>
          <div className='pagina-principal'>
          <div className='pagina-principal-card-container'>
              <a href={"/agenda"}>
                <Card title='Resumo do dia' imgCard='images/ResumoDoDia.png' />
              </a>
              <a href={"/atividades"}>
                <Card title='Lição de casa' imgCard='images/LicaoDeCasa.png' />
              </a>
            </div>
            <div className='pagina-principal-card-container'>
              <a href={"/comunicados"}>
                <Card title='Comunicados' imgCard='images/Comunicados.png' />
              </a>
              <a href={"/eventos"}>
                <Card title='Eventos' imgCard='images/Eventos.png' />
              </a>
              </div>
              <div className='pagina-principal-card-container'>
                <a href={"/financeiro"}>
                  <Card title='Financeiro' imgCard='images/Financeiro.png' />
                </a>
                <a href={"/fotos"}>
                  <Card title='Murais de fotos' imgCard='images/MuralDeFotos.png' />
                </a>
            </div>
          </div>
        </div>
      </PaginaPadrao>
    </div>
  )
}

export default PaginaIncial