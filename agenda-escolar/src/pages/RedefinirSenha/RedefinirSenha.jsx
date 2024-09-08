import { Col, Row } from 'antd'
import React, { useState } from 'react'
import Button from '../../components/Button/Button';
import './RedefinirSenha.css';
import PaginaPadrao from '../PaginaPadao/PaginaPadrao';

const RedefinirSenha = () => {

    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');
    const [errorMessage, setErrorMessage] = useState('');
    const [successMessage, setSuccessMessage] = useState('');
    const [messageType, setMessageType] = useState(null);

    const handleSubmit = async (event) => {
        event.preventDefault();
        /*try {
            const response = await axios.post(`https://localhost:7297/api/Login?email=${encodeURIComponent(email)}&password=${encodeURIComponent(password)}`);

            console.log(response.data);
            // Verifique se o acesso foi permitido
            if (response.data === 'Acesso Permitido.') {
                // Defina a flag de login no localStorage
                localStorage.setItem('isLoggedIn', true);
                // Registre o tempo de login
                localStorage.setItem('loginTime', new Date().getTime());
                // Atualize a mensagem de sucesso
                setSuccessMessage('Login efetuado com sucesso.');
                setMessageType('success');
                // Redirecione o usuário para a URL '/'
                window.location.href = '/';
            } else {
                setErrorMessage('Dados inválidos.');
                setMessageType('error');
            }
        } catch (error) {
            console.error('Ocorreu um erro:', error);
            // Se a resposta for um erro 400 (Bad Request), exibe a mensagem de erro
            if (error.response && error.response.status === 400) {
                setErrorMessage('Email ou Senha inválidos.');
                setMessageType('error');
            }
        }
            */
    };
  return (
    <PaginaPadrao>
        <Row className='row'>
            <Col span={24}>
                <div className='container-geral'>
                    <div className='container-img-redefinir-Senha'>
                        <div className='container-img-redefifir-senha'>
                            <img className='img-longin' src="images/redefinirSenha.png" alt="" />
                        </div>
                        <div>
                            <h1>Redefinir senha</h1>    
                        </div>
                    </div>
                        <div className='container-login'>
                            {/* <div className='container'> */}
                            <form onSubmit={handleSubmit} className='form'>
                                <div className='container-inputs'>
                                    <label>
                                        Email:
                                        <input placeholder='Digite seu email' type="email" value={email} onChange={(e) => setEmail(e.target.value)} />
                                    </label>
                                    <label>
                                        Nova Senha:
                                        <input placeholder='Digite sua senha' type="password" value={password} onChange={(e) => setPassword(e.target.value)} />
                                    </label>
                                    <label>
                                        Confirme a senha:
                                        <input placeholder='Digite sua senha' type="password" value={password} onChange={(e) => setPassword(e.target.value)} />
                                    </label>
                                    {messageType === 'success' && <p className="success-message">{successMessage}</p>}
                                    {messageType === 'error' && <p className="error-message">{errorMessage}</p>}
                                </div>
                                <div className='button-container'>
                                    <Button type="submit" children="SALVAR" />
                                </div>
                            </form>
                        </div>
                    </div>
                    {/* </div> */}
                </Col>
            </Row>
        </PaginaPadrao>
  )
}

export default RedefinirSenha