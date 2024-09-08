import React from 'react';
import PaginaPadrao from '../PaginaPadao/PaginaPadrao';
import './Financeiro.css';

const Financeiro = () => {
  const mensalidades = [
    { data: 'Janeiro', status: 'Pago' },
    { data: 'Fevereiro', status: 'Pago' },
    { data: 'Março', status: 'Pago' },
    { data: 'Abril', status: 'Pendente' },
    { data: 'Maio', status: 'Pendente' },
    { data: 'Junho', status: 'Pago' },
    { data: 'Julho', status: 'Pago' },
    { data: 'Agosto', status: 'Pago' },
    { data: 'Setembro', status: 'Pendente' },
    { data: 'Outubro', status: 'Pago' },
    { data: 'Novembro', status: 'Pago' },
    { data: 'Dezembro', status: 'Pendente' },
  ];

  return (
    <div className="container-financeiro">
      <PaginaPadrao>
        <div className="financeiro-container">
          {/* Título centralizado */}
          <h1 className="financeiro-title">Financeiro</h1>

          {/* Texto "Mensalidade" e data */}
          <div className="mensalidade-section">
            <span className="mensalidade-text">Mensalidade</span>
            <span className="mensalidade-date">05 de Setembro, 2024</span>
          </div>

          {/* Risco horizontal */}
          <hr className="divider" />

          {/* Texto "Mês" e "Status" */}
          <div className="mes-status-section">
            <span className="mes-text">Mês</span>
            <span className="status-text">Status</span>
          </div>

          {/* Círculo e textos ao lado de Mês e Status */}
          {mensalidades.map((mensalidade, index) => (
            <div key={index} className="mes-status-content">
              <div className="mes-content">
                <div className="circle"></div>
                <div className="mes-info">{mensalidade.data}</div>
              </div>
              <div className="status-content">
                <div className="status-info">{mensalidade.status}</div>
              </div>
            </div>
          ))}

          {/* Risco horizontal */}
          {/* <hr className="divider" /> */}
        </div>
      </PaginaPadrao>
    </div>
  );
};

export default Financeiro;
