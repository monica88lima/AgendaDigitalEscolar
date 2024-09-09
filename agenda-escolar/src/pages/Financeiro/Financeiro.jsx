import React, { useEffect, useState } from 'react';
import PaginaPadrao from '../PaginaPadao/PaginaPadrao';
import './Financeiro.css';
import axios from 'axios';

const Financeiro = () => {
   const mensalidades = [
     { data: 'Dezembro', status: 'Pendente' },
     { data: 'Novembro', status: 'Pago' },
     { data: 'Outubro', status: 'Pago' },
     { data: 'Setembro', status: 'Pago' },
     { data: 'Agosto', status: 'Pago' },
     { data: 'Julho', status: 'Pago' },
     { data: 'Junho', status: 'Pago' },
     { data: 'Maio', status: 'Pago' },
     { data: 'Abril', status: 'Pago' },
     { data: 'Março', status: 'Pago' },
     { data: 'Fevereiro', status: 'Pago' },
     { data: 'Janeiro', status: 'Pago' },
   ];

  // const [mensalidades, setMensalidades] = useState([]);
  //   const fetchEventos = async () => {
  //     try {
  //       const response = await axios.get('https://localhost:7145/api/Eventos');
  //       console.log('###########@ Dados recebidos:', response.data);
  //       setMensalidades(response.data);
  //     } catch (error) {
  //       console.error('Erro ao buscar os comunicados:', error);
  //     }
  //   };
 
  //   useEffect(() => {
  //     fetchEventos();
  //   }, []);

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
                <div className={mensalidade.status === 'Pago' ? "circle-pago" : 'circle-pendente'}></div>
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
