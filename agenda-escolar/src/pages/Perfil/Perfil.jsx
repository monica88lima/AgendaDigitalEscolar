import React from 'react';
import './Perfil.css';
import PaginaPadrao from '../PaginaPadao/PaginaPadrao';
import CardFilho from '../../components/CardFilho/CardFilho';

const Perfil = () => {
    const filhos = [
        {
          nome: 'João Silva',
          turma: '3° ano Fund.I - Turma A  Manhã',
          professor: 'Professor Carlos'
        },
        {
          nome: 'Maria Oliveira',
          turma: '3° ano Fund.I - Turma A  Manhã',
          professor: 'Professora Ana'
        },
        {
          nome: 'Pedro Santos',
          turma: '3° ano Fund.I - Turma A  Manhã',
          professor: 'Professor João'
        }
      ];
      
  return (
    <div className='container-principal-perfil'>
        <PaginaPadrao>
            <div className="perfil-container">
                <h1 className="title">Perfil</h1>
                <div className="info-container">
                    <div className="info-row">
                        <label>Nome:</label>
                            
                        </div>
                        <div className="info-row">
                            <label>Perfil:</label>
                            <span>Familiar responsável</span>
                        </div>
                        <div className="info-row">
                            <label>Email:</label>
                            <span>email@email.com</span>
                        </div>
                        <div className="info-filhos-row">
                            <label>Filhos</label>       
                        <span>-</span>
                    </div>
                    {filhos.map((atividade, index) => (
                    <CardFilho
                        key={index}
                        nome={atividade.nome}
                        // data={atividade.data}
                        turma={atividade.turma}
                        professor={atividade.professor}
                        // icone={atividade.icone}
                    />
                    ))}
                </div>
            </div>
        </PaginaPadrao>
    </div>
  );
};

export default Perfil;
