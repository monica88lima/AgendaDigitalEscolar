import React from 'react';
import './DetalhesAtividade.css';
import PaginaPadrao from '../PaginaPadao/PaginaPadrao';

const DetalhesAtividade = () => {
    return (
        <div className='container-principal-detalhes-atividade'>
            <PaginaPadrao>
             <div className="container-atividade">

                    <h1 className="atividade-title">Atividade</h1>
                {/* <div className="container-atividade"> */}
                    
                    <div className="info-section-atividade">
                        <div className='container-data-entrega'>
                            <label className='label-data-entrega'>Data de Entrega:</label>
                        </div>
                        <div className="container-info-section">
                            <div>
                                <img src="/images/calendario.png" alt="Data de Entrega" className="small-image" />
                            </div>
                            <div>
                                <label>01/setembro</label>
                            </div>
                        </div>
                    </div>
                    <hr className="line-atividade" />
                    
            
                    {/* <div> */}
                        <label>Informações:</label>
                        <hr className="line-atividade" />
                        <p className="text-atividade">
                        Aqui você pode adicionar as informações relevantes sobre a atividade. Descreva
                        o que precisa ser feito, os requisitos e qualquer outra informação importante.
                        </p>
                    {/* </div> */}
            
                    {/* <div> */}
                    <div>
                        <label>Material Necessário:</label>
                        <hr className="line-atividade" />
                        <p className="text-atividade">
                        Aqui você pode listar os materiais necessários para completar a atividade.
                        Inclua todos os itens que serão úteis.
                        </p>
            
                    </div>
                        <hr className="line-atividade" />
                        {/* </div> */}
                    
                    <div className="info-section-atividade right-aligned-atividade">
                    <img src="/images/check.png" alt="Material Necessário" className="  " />
                    </div>
                    {/* </div> */}

                </div>
            </PaginaPadrao>
        </div>
    );
  };

export default DetalhesAtividade