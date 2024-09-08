import React, { useEffect, useState } from 'react';
import PaginaPadrao from '../PaginaPadao/PaginaPadrao';
import Comunicado from '../../components/CardPadrao/CardPadrao';
import { BellOutlined, CalendarOutlined, CheckCircleOutlined, ExclamationCircleOutlined, InfoCircleOutlined, LockOutlined, MailOutlined, PhoneOutlined, UserOutlined, WarningOutlined } from '@ant-design/icons';
import './Comunicados.css';
import axios from 'axios';
import { format, parseISO } from 'date-fns';
import { ptBR } from 'date-fns/locale';

const Comunicados = () => {
  // Função para formatar a data
function formatarData(data) {
  // Exemplo simples de formatação no formato DD/MM/AAAA
  const date = new Date(data);
  const day = String(date.getDate()).padStart(2, '0');
  const month = String(date.getMonth() + 1).padStart(2, '0'); // Janeiro é 0!
  const year = date.getFullYear();
  return `${day}/${month}/${year}`;
}

// Criar array de 10 objetos de comunicados
const comunicados = Array.from({ length: 10 }, (_, index) => ({
  key: `comunicado-${index + 1}`, // Substitua pelo ID real se disponível
  titulo: `Título ${index + 1}`,  // Substitua pelo valor real se disponível
  data: formatarData(new Date()), // Substitua por comunicado.criadoEm
  subtitulo: `Subtítulo ${index + 1}`, // Substitua pelo valor real se disponível
  descricao: `Descrição ${index + 1}`, // Substitua pelo valor real se disponível
  lido: false, // Substitua pelo valor real se disponível
  icone: true
}));
  // const [comunicados, setComunicados] = useState([]);

  // const fetchComunicados = async () => {
  //   try {
  //     const response = await axios.get('https://localhost:7145/api/Comunicados');
  //     console.log('###########@ Dados recebidos:', response.data);
  //     setComunicados(response.data);
  //   } catch (error) {
  //     console.error('Erro ao buscar os comunicados:', error);
  //   }
  // };

  // useEffect(() => {
  //   fetchComunicados();
  // }, []);

  // // Função para formatar a data
  // const formatarData = (data) => {
  //   try {
  //     const date = parseISO(data); // Converte a string para um objeto Date
  //     return format(date, 'dd/MMM', { locale: ptBR }); // Formata a data como "01/Ago"
  //   } catch (error) {
  //     return data; // Retorna a data original em caso de erro
  //   }
  // };

  return (
    <div className='container-principal-comunicado'>
      <PaginaPadrao>
        <div className='title-container'>
          <h1 className='title'>Comunicados</h1>
        </div>
        <div className='comunicado-container2'>
          {comunicados.map((comunicado) => (
            <Comunicado
              key={comunicado.comunicadoId}
              titulo={comunicado.titulo}
              data={formatarData(comunicado.criadoEm)}
              subtitulo={comunicado.subtitulo}
              descricao={comunicado.descricao}
              lido={comunicado.lido}
              icone={true}
            />
          ))}
        </div>
      </PaginaPadrao>
    </div>
  );
};

export default Comunicados;
