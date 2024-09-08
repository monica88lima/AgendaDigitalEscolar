import React, { useState } from 'react'
import PaginaPadrao from '../PaginaPadao/PaginaPadrao'
import './Mensagem.css';
import CardMensagem from '../../components/CardMensagem/CardMensagem';
import axios from 'axios';

const Mensagem = () => {

     const atividades = [
         {
           titulo: "Importante",
           subtitulo: "Notificação",
           descricao: "Esta é uma descrição detalhada do comunicado. Aqui você pode adicionar informações adicionais sobre o que está sendo comunicado.",
         },
         {
           titulo: "Informativo",
           subtitulo: "Atualização",
           descricao: "Aqui está uma atualização importante que você deve saber.",
         },
         {
           titulo: "Alerta",
           subtitulo: "Aviso",
           descricao: "Este é um alerta sobre uma situação que pode precisar de sua atenção imediata.",
         },
         {
           titulo: "Confirmação",
           subtitulo: "Verificação",
           descricao: "Você recebeu uma confirmação sobre o status de sua solicitação.",
         },
         {
           titulo: "Urgente",
           subtitulo: "Ação Necessária",
           descricao: "Esta é uma mensagem urgente que requer uma ação imediata.",
         },
         {
           titulo: "Contato",
           subtitulo: "Telefone",
           descricao: "Aqui estão os detalhes de contato para suporte adicional.",
         },
         {
           titulo: "Correio",
           subtitulo: "Mensagem",
           descricao: "Você recebeu um novo e-mail que precisa ser lido.",
         },
         {
           titulo: "Agendamento",
           subtitulo: "Data e Hora",
           descricao: "Há um novo agendamento ou evento para o qual você está inscrito.",
         },
         {
           titulo: "Perfil",
           subtitulo: "Informações",
           descricao: "Atualize suas informações de perfil para manter seus dados atualizados.",
         },
         {
           titulo: "Segurança",
           subtitulo: "Proteção",
           descricao: "Uma atualização importante sobre a segurança da sua conta.",
         }
       ];
/*
  const [mensagens, setMensagens] = useState([]);

  const fetchComunicados = async () => {
    try {
      const response = await axios.get('https://localhost:7145/api/Atividades');
      console.log('###########@ Dados recebidos:', response.data);
      setMensagens(response.data);
    } catch (error) {
      console.error('Erro ao buscar os comunicados:', error);
    }
  };

  useEffect(() => {
    fetchComunicados();
  }, []);
*/
  return (
    <div className='container-principal-mensagens'>
        <PaginaPadrao >
            <div className='title-container'>
                <h1 className='title'>Chat - Simone</h1>
            </div>
            <div className='comunicado-container2'>
                {atividades.map((atividade, index) => (
                    <CardMensagem
                        key={index}
                        titulo={atividade.titulo}
                        // data={atividade.data}
                        subtitulo={atividade.subtitulo}
                        descricao={atividade.descricao}
                        lido={false}
                        icone={true}
                    />
                ))}
            </div>
        </PaginaPadrao>
    </div>
  )
}

export default Mensagem