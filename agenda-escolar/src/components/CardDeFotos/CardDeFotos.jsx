import React from 'react'
import './CardDeFotos.css'

const CardDeFotos = ({ texto, data }) => {
  return (
    <div className="mural-card">
            <img src='images/foto.png' alt="Foto" className="mural-foto" />
            <div className="mural-texto">
                <p>{texto}</p>
            </div>
            <div className="mural-data">
                <span>{data}</span>
            </div>
        </div>
  )
}

export default CardDeFotos