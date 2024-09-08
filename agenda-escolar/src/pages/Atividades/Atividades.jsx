import React, { useEffect, useState } from 'react'
import PaginaPadrao from '../PaginaPadao/PaginaPadrao'
import Comunicado from '../../components/CardPadrao/CardPadrao'
import { BellOutlined, CalendarOutlined, CheckCircleOutlined, ExclamationCircleOutlined, InfoCircleOutlined, LockOutlined, MailOutlined, PhoneOutlined, UserOutlined, WarningOutlined } from '@ant-design/icons';
import './Atividades.css';
import axios from 'axios';

const Atividades = () => {
  // const [atividades, setAtividades] = useState([]);

  const atividades = Array.from({ length: 10 }, (_, index) => ({
    key: index,
    titulo: `Título ${index + 1}`, // Substitua por atividade.titulo conforme necessário
    data: `Data ${index + 1}`,    // Substitua por atividade.data conforme necessário
    subtitulo: `Subtítulo ${index + 1}`, // Substitua por atividade.subtitulo conforme necessário
    descricao: `Descrição ${index + 1}`,  // Substitua por atividade.descricao conforme necessário
    icone: true
  }));

  // const fetchComunicados = async () => {
  //   try {
  //     const response = await axios.get('https://localhost:7145/api/Atividades');
  //     console.log('###########@ Dados recebidos:', response.data);
  //     setAtividades(response.data);
  //   } catch (error) {
  //     console.error('Erro ao buscar os comunicados:', error);
  //   }
  // };

  // useEffect(() => {
  //   fetchComunicados();
  // }, []);

  return (
    <div className='container-principal-atividades'>
        <PaginaPadrao >
            <div className='title-container'>
                <h1 className='title'>Atividades</h1>
            </div>
            <div className='comunicado-container2'>
                {atividades.map((atividade, index) => (
                    <Comunicado
                        key={index}
                        titulo={atividade.titulo}
                        data={atividade.data}
                        subtitulo={atividade.subtitulo}
                        descricao={atividade.descricao}
                        icone={true}
                    />
                ))}
            </div>
        </PaginaPadrao>
    </div>
  )
}

export default Atividades