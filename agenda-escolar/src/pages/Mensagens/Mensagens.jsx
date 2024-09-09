import React, { useState } from 'react'
import PaginaPadrao from '../PaginaPadao/PaginaPadrao'
// import './Mensagens.css';
// import CardMensagem from '../../components/CardMensagem/CardMensagem';
import axios from 'axios';
import CardPadrao from '../../components/CardPadrao/CardPadrao';

const Mensagens = () => {

     const atividades = [
         {
           titulo: "Importante",
           descricao: "Esta é uma descrição detalhada do comunicado. Aqui você pode adicionar informações adicionais sobre o que está sendo comunicado.",
         },
         {
           titulo: "Informativo",
           descricao: "Aqui está uma atualização importante que você deve saber.",
         },
         {
           titulo: "Alerta",
           descricao: "Este é um alerta sobre uma situação que pode precisar de sua atenção imediata.",
         },
         {
           titulo: "Confirmação",
           descricao: "Você recebeu uma confirmação sobre o status de sua solicitação.",
         },
         {
           titulo: "Urgente",
           descricao: "Esta é uma mensagem urgente que requer uma ação imediata.",
         },
         {
           titulo: "Contato",
           descricao: "Aqui estão os detalhes de contato para suporte adicional.",
         },
         {
           titulo: "Correio",
           descricao: "Você recebeu um novo e-mail que precisa ser lido.",
         },
         {
           titulo: "Agendamento",
           descricao: "Há um novo agendamento ou evento para o qual você está inscrito.",
         },
         {
           titulo: "Perfil",
           descricao: "Atualize suas informações de perfil para manter seus dados atualizados.",
         },
         {
           titulo: "Segurança",
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
                <h1 className='title'>Mensagems</h1>
            </div>
            <div className='comunicado-container2'>
                {atividades.map((atividade, index) => (
                    <CardPadrao
                        key={index}
                        titulo={atividade.titulo}
                        // data={atividade.data}
                        subtitulo={atividade.subtitulo}
                        descricao={atividade.descricao}
                        // icone={atividade.icone}
                    />
                ))}
            </div>
        </PaginaPadrao>
    </div>
  )
}

export default Mensagens