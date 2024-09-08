import React from 'react'
import PaginaPadrao from '../PaginaPadao/PaginaPadrao'
import Card from '../../components/Card/Card'
import './PaginaIncial.css'
import { Col } from 'antd'

const PaginaIncial = () => {

  const dataSourceCards = [
    {
      imgCard: "images/ResumoDoDia.png",
      title: "Resumo do dia",
    },
    {
      imgCard: "images/LicaoDeCasa.png",
      title: "Lição de casa",
    },
    {
      imgCard: "images/Comunicados.png",
      title: "Comunicados",
    },
    {
      imgCard: "images/Eventos.png",
      title: "Eventos",
    },
    {
      imgCard: "images/Financeiro.png",
      title: "Financeiro",
    },
    {
      imgCard: "images/MuralDeFotos.png",
      title: "Murais de fotos",
    }
  ]
  return (
    <div className='container-pagina-principal'>
      <PaginaPadrao>
        <div >
          <div className='container-info-escola-container'>
            {/* <InfoEscola
              nome="Escola Exemplo"
              telefone="(11) 1234-5678"
              imagem="https://via.placeholder.com/150"
            /> */}
          </div>
          <div className='card-container'>
            {
              dataSourceCards.map((card, index) => {
                return <Col span={12} className="card-col" gap>
                          <Card key={index} title={card.title} imgCard={card.imgCard} />
                        </Col>
              })
            }
          </div>
        </div>
      </PaginaPadrao>
    </div>
  )
}

export default PaginaIncial