import { Col, Row } from 'antd'
import React, { useState } from 'react'
import Button from '../../components/Button/Button';
import './Login.css';
import axios from 'axios';

const Login = () => {

    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');
    const [errorMessage, setErrorMessage] = useState('');
    const [successMessage, setSuccessMessage] = useState('');
    const [messageType, setMessageType] = useState(null);

    const handleSubmit = async (event) => {
        event.preventDefault();
        try {
            const response = await axios.post(`https://localhost:7145/login?email=${encodeURIComponent(email)}&password=${encodeURIComponent(password)}`);

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
                window.location.href = '/home';
            } else {
                setErrorMessage('Dados inválidos.');
                setMessageType('error');
            }
            console.log('#####@ email e senha', email, password)
            console.log('#####@ response', response)
        } catch (error) {
            console.error('Ocorreu um erro:', error);
            // Se a resposta for um erro 400 (Bad Request), exibe a mensagem de erro
            if (error.response && error.response.status === 400) {
                setErrorMessage('Email ou Senha inválidos.');
                setMessageType('error');
            }
        }
            
    };
  return (
    <Row className='row'>
        <Col span={24}>
            <div className='content-geral'>
                <div className='content-img-longin'>
                    <img className='img-longin' src="images/tela-login.png" alt="" />
                </div>
                    <div className='content-login'>
                        <form onSubmit={handleSubmit} className='form'>
                            <div className='content-inputs'>
                                <label>
                                    Email:
                                    <input placeholder='Digite seu email' type="email" value={email} onChange={(e) => setEmail(e.target.value)} />
                                </label>
                                <label>
                                    Senha:
                                    <input placeholder='Digite sua senha' type="password" value={password} onChange={(e) => setPassword(e.target.value)} />
                                </label>
                                {messageType === 'success' && <p className="success-message">{successMessage}</p>}
                                {messageType === 'error' && <p className="error-message">{errorMessage}</p>}
                            </div>
                            <div className='button-container'>
                                <Button type="submit" children="ENTRAR" />
                            </div>
                            <div className='esqueci-a-senha-container'>
                                <a href="/register" className='esqueci-a-senha'>Esqueci a senha</a>
                            </div>
                        </form>
                    </div>
                </div>
                {/* </div> */}
            </Col>
        </Row>
  )
}

export default Login