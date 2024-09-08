
import React from 'react';
import { Select, Input } from 'antd';
import './Agenda.css';
import PaginaPadrao from '../PaginaPadao/PaginaPadrao';

const { Option } = Select;

const Agenda = () => {
  return (
    <div>
      <PaginaPadrao >
      <div className='container-principal-agenda'>

        <div className="agenda-container">
          <h1 className="agenda-title">Agenda</h1>
        
          <div className="agenda-content">
            <div className="left-side">
              <p className="school-message">Recado da Escola</p>
            </div>
            <div className="right-side">
              <img src="images/calendario.png" alt="Imagem" className="agenda-image" />
              <p className="date-text">12/Setembro</p>
            </div>
          </div>
        
          <hr className="divider" />

          <div className="section">
            <label className="label">Refeição</label>
            <Select className="select" defaultValue="Boa">
              <Option value="Muito Boa">Muito Boa</Option>
              <Option value="Boa">Boa</Option>
              <Option value="Ruim">Ruim</Option>
            </Select>
          </div>

          <hr className="divider" />

          <div className="section">
            <label className="label">Sono</label>
            <Select className="select" defaultValue="Boa">
              <Option value="Muito Boa">Muito Boa</Option>
              <Option value="Boa">Boa</Option>
              <Option value="Ruim">Ruim</Option>
            </Select>
          </div>

          <hr className="divider" />

          <div className="section">
            <label className="label">Atividades</label>
            <Input.TextArea className="textarea" rows={4} placeholder="Descreva as atividades do dia" />
          </div>

          <hr className="divider" />

          <div className="images-agenda-container">
            <img src="images/message.png" alt="Imagem 1" className="agenda-image" />
            <img src="images/check.png" alt="Imagem 2" className="agenda-image" />
          </div>
        </div>
        </div>
      </PaginaPadrao>
    </div>
  )
}

export default Agenda