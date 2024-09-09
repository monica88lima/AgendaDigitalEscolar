import React, { useEffect, useState } from 'react';
import './DetalhesAtividade.css';
import PaginaPadrao from '../PaginaPadao/PaginaPadrao';
import { useNavigate, useParams } from 'react-router-dom';
import axios from 'axios';
import { format, parseISO } from 'date-fns';
import { ptBR } from 'date-fns/locale';

const DetalhesAtividade = () => {

    const { id } = useParams(); // Pega o ID da URL
    const [atividade, setAtividade] = useState(null);
    const navigate = useNavigate(); // Hook para redirecionar
  
  
    useEffect(() => {
      const fetchComunicado = async () => {
        try {
          const response = await axios.get(`https://localhost:7145/api/Atividades/${id}`);
          console.log('#####@ Dados recebidos:', response.data);
          setAtividade(response.data);
        } catch (error) {
          console.error('Erro ao buscar os detalhes do comunicado:', error);
        }
      };
  
      fetchComunicado();
    }, [id]);
  
    if (!atividade) {
      return <div>Carregando...</div>;
    }
  
    const confirmLido = () => {
      navigate(`/comunicados`);
    }

    const formatarData = (data) => {
        try {
          const date = parseISO(data);
          return format(date, 'dd/MMM', { locale: ptBR });
        } catch (error) {
          return data;
        }
      };

      const atividadeLida = async () => {
        try {
          const response = await axios.put(`https://localhost:7145/marcar_atividade_lido/${id}`);
          console.log('#####@ Dados recebidos:', response.data);
          setAtividade(response.data);
        } catch (error) {
          console.error('Erro ao buscar os detalhes do comunicado:', error);
        }
        // Redireciona para a página de detalhes
        navigate(`/atividades`);
      };
    return (
        <div className='container-principal-detalhes-atividade'>
            <PaginaPadrao>
             <div className="container-atividade">

                    <h1 className="atividade-title">{atividade.titulo}</h1>                    
                    <div className="info-section-atividade">
                        <div className='container-data-entrega'>
                            <label className='label-data-entrega'>Data de Entrega:</label>
                        </div>
                        <div className="container-info-section">
                                <img src="/images/calendario.png" alt="Data de Entrega" className="small-image" />
                                <label>{formatarData(atividade.dataEntrega)}</label>
                        </div>
                    </div>
                    <hr className="line-atividade" />
                        <label>Informações:</label>
                        <hr className="line-atividade" />
                        <p className="text-atividade">
                        {atividade.descricao}
                        </p>
            
                    <div>
                        <label>Material Necessário:</label>
                        <hr className="line-atividade" />
                        <p className="text-atividade">
                        {atividade.material}
                        </p>
            
                    </div>
                        <hr className="line-atividade" />
                    
                    <div className="info-section-atividade right-aligned-atividade">
                    
                            <img src="/images/check.png" alt="Material Necessário" className="  " onClick={() => atividadeLida()}/>
    
                    </div>

                </div>
            </PaginaPadrao>
        </div>
    );
  };

export default DetalhesAtividade