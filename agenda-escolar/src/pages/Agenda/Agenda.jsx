
// import React, { useEffect, useState } from 'react';
// import { Select, Input } from 'antd';
// import './Agenda.css';
// import PaginaPadrao from '../PaginaPadao/PaginaPadrao';
// import axios from 'axios';

// const { Option } = Select;

// const Agenda = () => {

//    const [agendaDiaria, setAgendaDiaria] = useState([]);

//    const fetchAgendaDiaria = async () => {
//      try {
//        const response = await axios.get('https://localhost:7145/api/AgendaDiaria');
//        console.log('###########@ ', response.data);
//        setAgendaDiaria(response.data);
//      } catch (error) {
//        console.error('Erro ao buscar os comunicados:', error);
//      }
//    };

//    useEffect(() => {
//     fetchAgendaDiaria();
//    }, []);
  
//   return (
//     <div>
//       <PaginaPadrao >
//       <div className='container-principal-agenda'>

//         <div className="agenda-container">
//           <h1 className="agenda-title">Agenda</h1>
        
//           <div className="agenda-content">
//             <div className="left-side">
//               <p className="school-message">Recado da Escola</p>
//             </div>
//             <div className="right-side">
//               <img src="images/calendario.png" alt="Imagem" className="agenda-image" />
//               <p className="date-text">12/Setembro</p>
//             </div>
//           </div>
        
//           <hr className="divider" />

//           <div className="section">
//             <label className="label">Refeição</label>
//             <Select className="select" defaultValue="Boa">
//                {agendaDiaria[0].refeicaoStatus === 1 ? <Option value="Muito Boa">Muito Boa</Option> : ''}
//               {agendaDiaria[0].refeicaoStatus === 2 ? <Option value="Boa">Muito Boa</Option> : ''}
//               {agendaDiaria[0].refeicaoStatus === 3 ? <Option value="Ruim">Muito Boa</Option> : ''} 
            
//             </Select>
//           </div>

//           <hr className="divider" />

//           <div className="section">
//             <label className="label">Sono</label>
//             <Select className="select" defaultValue="Boa">
//               <Option value="Muito Boa">Muito Boa</Option>
//               <Option value="Boa">Boa</Option>
//               <Option value="Ruim">Ruim</Option>
//             </Select>
//           </div>

//           <hr className="divider" />

//           <div className="section">
//             <label className="label">Atividades</label>
//             <Input.TextArea className="textarea" rows={4} placeholder="Descreva as atividades do dia" />
//           </div>

//           <hr className="divider" />

//           <div className="images-agenda-container">
//             <img src="images/message.png" alt="Imagem 1" className="agenda-image" />
//             <img src="images/check.png" alt="Imagem 2" className="agenda-image" />
//           </div>
//         </div>
//         </div>
//       </PaginaPadrao>
//     </div>
//   )
// }

// export default Agenda

import React, { useEffect, useState } from 'react';
import { Select, Input } from 'antd';
import './Agenda.css';
import PaginaPadrao from '../PaginaPadao/PaginaPadrao';
import axios from 'axios';
import { useNavigate } from 'react-router-dom';

const { Option } = Select;

const Agenda = () => {
   const [agendaDiaria, setAgendaDiaria] = useState([]);
   const navigate = useNavigate(); 

   const fetchAgendaDiaria = async () => {
     try {
       const response = await axios.get('https://localhost:7145/api/AgendaDiaria');
       console.log('###########@ ', response.data);
       setAgendaDiaria(response.data);
     } catch (error) {
       console.error('Erro ao buscar os comunicados:', error);
     }
   };

   useEffect(() => {
    fetchAgendaDiaria();
   }, []);
  
   if (!agendaDiaria.length) {
     return <div>Carregando...</div>;
   }

   const AgendaLida = async () => {
    try {
      const response = await axios.put(`https://localhost:7145/marcar_agenda_lido/1`);
      setAgendaDiaria(response.data);
    } catch (error) {
      console.error('Erro ao buscar os detalhes do comunicado:', error);
    }
    // Redireciona para a página de detalhes
    navigate(`/home`);
  };

  return (
    <div>
      <PaginaPadrao>
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
              <label className="label">Refeição: </label>
              {agendaDiaria[0].refeicaoStatus === 1 && <label className="label">{agendaDiaria[0].refeicaoStatusString}</label>}
              {agendaDiaria[0].refeicaoStatus === 2 && <label className="label">{agendaDiaria[0].refeicaoStatusString}</label>}
              {agendaDiaria[0].refeicaoStatus === 3 && <label className="label">{agendaDiaria[0].refeicaoStatusString}</label>}
            </div>

            <hr className="divider" />

            <div className="section">
              <label className="label">Sono: </label>
              {agendaDiaria[0].sonoStatus === 1 && <label className="label">{agendaDiaria[0].sonoStatusString}</label>}
              {agendaDiaria[0].sonoStatus === 2 && <label className="label">{agendaDiaria[0].sonoStatusString}</label>}
              {agendaDiaria[0].sonoStatus === 3 && <label className="label">{agendaDiaria[0].sonoStatusString}</label>}
            </div>

            <hr className="divider" />

            <div className="section">
              <label className="label">Atividades: </label>
              <label className="label">{agendaDiaria[0].atividades} </label>
            </div>

            <hr className="divider" />

            <div className="images-agenda-container">
              <img src="images/message.png" alt="Imagem 1" className="agenda-image" />
              <img src="images/check.png" alt="Imagem 2" className="agenda-image" onClick={() => AgendaLida()}/>
            </div>
          </div>
        </div>
      </PaginaPadrao>
    </div>
  )
}

export default Agenda;
