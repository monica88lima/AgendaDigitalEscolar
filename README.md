# Projeto Senac - Agenda Escolar Digital

<h1 align="center">:book: Serviço de Agenda Escolar Online :computer:</h1>

## Descrição do Projeto :heavy_check_mark:

Este projeto consiste em uma aplicação desenvolvida em C# e React para gerenciamento escolar, destinada a facilitar a comunicação e a organização entre professores, alunos e responsáveis. 
A Agenda Digital permite que os usuários realizem atividades como agendar eventos, consultar comunicados, acompanhar o progresso de tarefas e gerenciar informações escolares de forma conveniente.
O sistema oferece uma interface amigável que visa melhorar a experiência educacional e a colaboração entre todos os envolvidos no ambiente escolar.

### Funcionalidades Principais
1. **Cadastro de Usuários:** Permitir que novos usuários (professores, alunos e responsáveis) se cadastrem na plataforma, garantindo que todos possam acessar as funcionalidades disponíveis.
2. **Gerenciamento de Turmas:** Facilitar o cadastro e a gestão de turmas, incluindo informações como ano, grau e professores responsáveis.
3. **Agendamento de Atividades::** Permitir que os professores agendem atividades, definindo prazos de entrega e materiais necessários.
4. **Comunicados e Avisos:** Oferecer um sistema para que os professores enviem comunicados e avisos importantes para alunos e responsáveis, com notificações automáticas.


### Pré-requisitos
- Visual Studio instalado
- Visual Studio Code instalado
- Node.js
- Conexão com banco de dados configurada (SQL Server, MySQL, etc.)
  
### Tecnologia :computer:

- C#
- MySQL
- React
- [Figma](https://www.figma.com/design/y5QHefUMT6CJC8SrieLqJW/AgendaEscolar?node-id=0-1&node-type=CANVAS&t=jpd28BBVrq9D6AnL-0)

### Recursos :pushpin:

- Visual Studio Code
- Visual Studio Community 2022
- Node.js

### Sobre :triangular_flag_on_post:

O Aplicativo Agenda Escolar Digital foi desenvolvido para torna a comunicação entre escola e responsáveis mais rápida, eficiente e acessível, eliminando a necessidade de recados físicos na mochila das crianças.

### Principais Pontos:

- **Controle e Transparência:** Nosso aplicativo permite um maior controle sobre o envio e a visualização de mensagens, fornecendo relatórios de visualização que podem ajudar a escola a garantir que os comunicados estejam sendo vistos pelos responsáveis..

- **Tecnologias Utilizadas:** O aplicativo é construído utilizando C# e React, garantindo eficiência e desempenho. A base de dados é MySQL.


## DoD

- Tela de Login
   - [x] Tela com campos de Email e Senha
   - [x] Validação de e-mail e Senha
   - [x] Redefinir Senha

- Tela Comunicados
   - [x] Componentes com Ícones de pendente ou lido
   - [x] Lista de comunicados
   - [x] Botão de confirmação de leitura e mensagem
   
- Tela Agenda
   - [x] Informação de Recado, data e Atividades
   - [x] Informação de Refeição e sono preenchidos conforme cadastro
   - [x] Botão de confirmação de leitura e mensagem

- Tela Eventos
   - [x] Componentes com Ícones de pendente ou lido
   - [x] Lista de Eventos
   - [x] Descrição do Eventos 
   
- Tela Atividades
   - [x] Componentes com Ícones de pendente ou lido
   - [x] Lista de Atividades
   - [x] Descrição resumida
 
- Tela Albuns de Fotos
   - [x] Exibição de álbuns de fotos por evento 
         
- Tela Financeiro
   - [x] Listagem com informações dos meses e o status de pagamento
   

  
  ### Vídeo de Demonstração 🎦

https://github.com/user-attachments/assets/3b8a0119-05cd-4c2b-8fd7-43166ed80888


## Como Usar :file_folder:

### Instalação e Configuração
1. Clone o repositório: `git clone []`
2. Configure a conexão com o banco de dados no arquivo de configuração `appsettings.json`, do *AgendaDigitalEscolar*.
3. Execute o script SQL fornecido para criar as tabelas necessárias no banco de dados.

### Executando o Projeto
1. Abra e execute o projeto *AgendaDigitalEscolar* no Visual Studio.
2. Abra o projeto *agenda-escolar*, com Visual Studio Code
3. No Visual Studio Code, clique na aba `Terminal`
4. Acesse no terminal a pasta **
5. Execute o comando `npm install`, para baixar as dependencias do projeto
6. Execute o comando  `npm run star`

### Licença
A licença do projeto é MIT License.

### Contato

## Perfis no LinkedIn

- [Monica Lima](https://www.linkedin.com/in/monicalima/)
- [Roberto Pacheco](https://www.linkedin.com/in/roberto-pacheco-527920238/)
- [Cinara Farias](https://www.linkedin.com/in/cinarafarias/)
- LARISSA LIMA DE ANDRADE
- DENIS HENRIQUE DE PAIVA
- JONATHAN CARLETTO JESUS
- GUSTAVO BARBOSA SANTOS
  
### Criando Banco de Dados
 ```
CREATE DATABASE  IF NOT EXISTS `AgendaDigital` /*!40100 DEFAULT CHARACTER SET utf8mb3 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `AgendaDigital`;
-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: AgendaDigital
-- ------------------------------------------------------
-- Server version	8.1.0

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `AgendaDiaria`
--

DROP TABLE IF EXISTS `AgendaDiaria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `AgendaDiaria` (
  `agendaDiaria_id` int NOT NULL AUTO_INCREMENT,
  `estudante_id` int NOT NULL,
  `data` datetime DEFAULT NULL,
  `refeicao_status` varchar(300) DEFAULT NULL,
  `sono_status` varchar(300) DEFAULT NULL,
  `higiene_status` varchar(300) DEFAULT NULL,
  `atividades` varchar(300) DEFAULT NULL,
  `criadoEm` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `alteradoEm` datetime DEFAULT NULL,
  `lido` tinyint NOT NULL,
  PRIMARY KEY (`agendaDiaria_id`),
  KEY `estudante_id` (`estudante_id`),
  CONSTRAINT `estudante_id` FOREIGN KEY (`estudante_id`) REFERENCES `Estudante` (`estudante_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `AgendaDiaria`
--

LOCK TABLES `AgendaDiaria` WRITE;
/*!40000 ALTER TABLE `AgendaDiaria` DISABLE KEYS */;
INSERT INTO `AgendaDiaria` VALUES (1,1,'2024-09-03 01:33:56','1','1','1','Musicalização e Artes','0001-01-01 00:00:00',NULL,0),(2,1,'2024-09-01 01:47:07','1','2','1','Numerais','0001-01-01 00:00:00',NULL,0);
/*!40000 ALTER TABLE `AgendaDiaria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Atividade`
--

DROP TABLE IF EXISTS `Atividade`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Atividade` (
  `atividade_id` int NOT NULL AUTO_INCREMENT,
  `titulo` varchar(100) NOT NULL,
  `descricao` varchar(300) NOT NULL,
  `material` varchar(300) NOT NULL,
  `dataEntrega` datetime NOT NULL,
  `criadoEm` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `turma_id` int NOT NULL,
  `professor_id` int NOT NULL,
  `lido` tinyint NOT NULL,
  `alteradoEm` datetime DEFAULT NULL,
  PRIMARY KEY (`atividade_id`),
  KEY `fk-professor_id` (`professor_id`),
  KEY `fk-turma_id-atv` (`turma_id`),
  CONSTRAINT `fk-professor_id` FOREIGN KEY (`professor_id`) REFERENCES `Professor` (`professorId`),
  CONSTRAINT `fk-turma_id-atv` FOREIGN KEY (`turma_id`) REFERENCES `Turma` (`turma_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Atividade`
--

LOCK TABLES `Atividade` WRITE;
/*!40000 ALTER TABLE `Atividade` DISABLE KEYS */;
INSERT INTO `Atividade` VALUES (1,'Construir Brinquedo','Construir um brinquedo com Materiais reciclavéis','Caixas de papelão, garrafas pet, cola, tesoura, lapis de colorir','2024-09-28 00:00:00','2024-09-03 02:28:15',1,3,0,NULL),(2,'Lição de Casa - Matemática','Resolver os exercícios do Caderno','Caderno de Matemática','2024-09-12 02:51:09','0001-01-01 00:00:00',1,3,0,NULL),(3,'Revisão de PortuguÊs','Realizar a leitura das paginas 12,13 e 14 e resolver os exercicios da página 15.','Apostila ','2024-09-14 02:55:35','0001-01-01 00:00:00',1,3,0,NULL);
/*!40000 ALTER TABLE `Atividade` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Comunicado_turmas`
--

DROP TABLE IF EXISTS `Comunicado_turmas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Comunicado_turmas` (
  `comunicado_turmas_id` int NOT NULL AUTO_INCREMENT,
  `comunicado_id` int NOT NULL,
  `turma_id` int NOT NULL,
  PRIMARY KEY (`comunicado_turmas_id`),
  KEY `fkcomunicado_id` (`comunicado_id`),
  KEY `fkturma_id` (`turma_id`),
  CONSTRAINT `fkcomunicado_id` FOREIGN KEY (`comunicado_id`) REFERENCES `Comunicados` (`comunicado_id`),
  CONSTRAINT `fkturma_id` FOREIGN KEY (`turma_id`) REFERENCES `Turma` (`turma_id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Comunicado_turmas`
--

LOCK TABLES `Comunicado_turmas` WRITE;
/*!40000 ALTER TABLE `Comunicado_turmas` DISABLE KEYS */;
INSERT INTO `Comunicado_turmas` VALUES (5,2,1),(8,2,1);
/*!40000 ALTER TABLE `Comunicado_turmas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Comunicados`
--

DROP TABLE IF EXISTS `Comunicados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Comunicados` (
  `comunicado_id` int NOT NULL AUTO_INCREMENT,
  `descricao` varchar(1024) NOT NULL,
  `titulo` varchar(100) NOT NULL,
  `criadoEm` datetime NOT NULL,
  `professor_id` int NOT NULL,
  `assinaturaCriador` varchar(100) NOT NULL,
  `observacao` varchar(100) DEFAULT NULL,
  `lido` tinyint NOT NULL,
  `alteradoEm` datetime DEFAULT NULL,
  PRIMARY KEY (`comunicado_id`),
  KEY `fk_professor_id` (`professor_id`),
  CONSTRAINT `fk_professor_id` FOREIGN KEY (`professor_id`) REFERENCES `Professor` (`professorId`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Comunicados`
--

LOCK TABLES `Comunicados` WRITE;
/*!40000 ALTER TABLE `Comunicados` DISABLE KEYS */;
INSERT INTO `Comunicados` VALUES (2,'Aos responsáveis e alunos, a partir do dia 01/08/2024, o uso do uniforme escolar será obrigatório para todos os estudantes.O uniforme é essencial para a identidade e segurança escolar, promovendo igualdade e disciplina. Pedimos a colaboração de todos para que os alunos estejam devidamente uniformizados a partir dessa data. O não cumprimento poderá resultar em medidas administrativas.','Uniforme Escolar','0001-01-01 00:00:00',3,'Agradecemos a compreensão e a colaboração de todos. Atenciosamente, Escola Florescer','Venda e Informações: Rose (11) 3567-9865',0,'0001-01-01 00:00:00');
/*!40000 ALTER TABLE `Comunicados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Escola`
--

DROP TABLE IF EXISTS `Escola`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Escola` (
  `escola_id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  `telefone` varchar(10) NOT NULL,
  `endereco` varchar(100) NOT NULL,
  `criadoEm` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `alteradoEm` datetime DEFAULT NULL,
  PRIMARY KEY (`escola_id`),
  UNIQUE KEY `escola_id_UNIQUE` (`escola_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Escola`
--

LOCK TABLES `Escola` WRITE;
/*!40000 ALTER TABLE `Escola` DISABLE KEYS */;
INSERT INTO `Escola` VALUES (1,'Escola ABC','1234-5678','Rua das Flores, 123','2024-09-01 16:49:27',NULL),(2,'Colégio XYZ','2345-6789','Avenida Central, 456','2024-09-01 16:49:27',NULL),(3,'Instituto Educar','3456-7890','Rua do Saber, 789','2024-09-01 16:49:27',NULL),(4,'Escola Nova Era','4567-8901','Rua da Paz, 101','2024-09-01 16:49:27',NULL);
/*!40000 ALTER TABLE `Escola` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Estudante`
--

DROP TABLE IF EXISTS `Estudante`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Estudante` (
  `estudante_id` int NOT NULL AUTO_INCREMENT,
  `nomeCompleto` varchar(100) NOT NULL,
  `turma_id` int NOT NULL,
  `matricula` int NOT NULL,
  `criadoEm` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `alteradoEm` datetime DEFAULT NULL,
  PRIMARY KEY (`estudante_id`),
  UNIQUE KEY `matricula_UNIQUE` (`matricula`),
  KEY `turma_id` (`turma_id`),
  CONSTRAINT `turma_id` FOREIGN KEY (`turma_id`) REFERENCES `Turma` (`turma_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Estudante`
--

LOCK TABLES `Estudante` WRITE;
/*!40000 ALTER TABLE `Estudante` DISABLE KEYS */;
INSERT INTO `Estudante` VALUES (1,'Patricia Gomes',1,78956,'0001-01-01 00:00:00',NULL);
/*!40000 ALTER TABLE `Estudante` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Estudante_Responsavel`
--

DROP TABLE IF EXISTS `Estudante_Responsavel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Estudante_Responsavel` (
  `estudante_id` int NOT NULL,
  `responsavel_id` int NOT NULL,
  PRIMARY KEY (`estudante_id`,`responsavel_id`),
  KEY `estudante_id_idx` (`estudante_id`,`responsavel_id`),
  KEY `responsavel_id_idx` (`responsavel_id`),
  CONSTRAINT `fk_estudante_id` FOREIGN KEY (`estudante_id`) REFERENCES `Estudante` (`estudante_id`),
  CONSTRAINT `fk_responsavel_id` FOREIGN KEY (`responsavel_id`) REFERENCES `Responsavel` (`responsaveis_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Estudante_Responsavel`
--

LOCK TABLES `Estudante_Responsavel` WRITE;
/*!40000 ALTER TABLE `Estudante_Responsavel` DISABLE KEYS */;
INSERT INTO `Estudante_Responsavel` VALUES (1,2);
/*!40000 ALTER TABLE `Estudante_Responsavel` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Eventos`
--

DROP TABLE IF EXISTS `Eventos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Eventos` (
  `evento_id` int NOT NULL AUTO_INCREMENT,
  `titulo` varchar(100) NOT NULL,
  `descricao` varchar(1000) NOT NULL,
  `dataEvento` datetime NOT NULL,
  `hora` varchar(300) DEFAULT NULL,
  `local` varchar(100) NOT NULL,
  `criadoEm` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `escola_id` int NOT NULL,
  `lido` tinyint NOT NULL,
  `alteradoEm` datetime DEFAULT NULL,
  PRIMARY KEY (`evento_id`),
  KEY `fk_escola_id_Ev` (`escola_id`),
  CONSTRAINT `fk_escola_id_Ev` FOREIGN KEY (`escola_id`) REFERENCES `Escola` (`escola_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Eventos`
--

LOCK TABLES `Eventos` WRITE;
/*!40000 ALTER TABLE `Eventos` DISABLE KEYS */;
INSERT INTO `Eventos` VALUES (1,'Reunião de Pais','Prezados responsáveis,Convidamos todos para a reunião de pais.Esta é uma oportunidade importante para discutirmos o desenvolvimento dos alunos, compartilhar informações sobre o calendário escolar e esclarecer dúvidas.Sua presença é fundamental para acompanharmos juntos o progresso de nossos estudantes e fortalecermos a parceria entre escola e família.','2024-09-09 00:00:00','10:00:00','Rua doze, 1024','2024-09-03 02:42:40',1,0,NULL);
/*!40000 ALTER TABLE `Eventos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Eventos_Turmas`
--

DROP TABLE IF EXISTS `Eventos_Turmas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Eventos_Turmas` (
  `eventosEscola_id` int NOT NULL AUTO_INCREMENT,
  `evento_id` int NOT NULL,
  `turma_id` int NOT NULL,
  PRIMARY KEY (`eventosEscola_id`),
  KEY `evento_id` (`evento_id`),
  KEY `fk-turma_id` (`turma_id`),
  CONSTRAINT `evento_id` FOREIGN KEY (`evento_id`) REFERENCES `Eventos` (`evento_id`),
  CONSTRAINT `fk-turma_id` FOREIGN KEY (`turma_id`) REFERENCES `Turma` (`turma_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Eventos_Turmas`
--

LOCK TABLES `Eventos_Turmas` WRITE;
/*!40000 ALTER TABLE `Eventos_Turmas` DISABLE KEYS */;
INSERT INTO `Eventos_Turmas` VALUES (1,1,1);
/*!40000 ALTER TABLE `Eventos_Turmas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Financeiro`
--

DROP TABLE IF EXISTS `Financeiro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Financeiro` (
  `idFinanceiro` int NOT NULL AUTO_INCREMENT,
  `estudante_id` int NOT NULL,
  `mes` int NOT NULL,
  `pago` tinyint NOT NULL,
  PRIMARY KEY (`idFinanceiro`),
  KEY `estudante_id_idx` (`estudante_id`),
  CONSTRAINT `fk-estudante_id-fin` FOREIGN KEY (`estudante_id`) REFERENCES `Estudante` (`estudante_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Financeiro`
--

LOCK TABLES `Financeiro` WRITE;
/*!40000 ALTER TABLE `Financeiro` DISABLE KEYS */;
/*!40000 ALTER TABLE `Financeiro` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Mensagem`
--

DROP TABLE IF EXISTS `Mensagem`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Mensagem` (
  `mensagem_id` int NOT NULL AUTO_INCREMENT,
  `conteudo` varchar(300) NOT NULL,
  `estudante_id` int NOT NULL,
  `professor_id` int NOT NULL,
  `perfilDisparo` int NOT NULL,
  `dataEnvio` datetime NOT NULL,
  `lida` tinyint NOT NULL,
  PRIMARY KEY (`mensagem_id`),
  KEY `estudante_id_idx` (`estudante_id`),
  KEY `professor_id_idx` (`professor_id`),
  CONSTRAINT `fk-estudante_id-msg` FOREIGN KEY (`estudante_id`) REFERENCES `Estudante` (`estudante_id`),
  CONSTRAINT `fk-professor_id-msg` FOREIGN KEY (`professor_id`) REFERENCES `Professor` (`professorId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Mensagem`
--

LOCK TABLES `Mensagem` WRITE;
/*!40000 ALTER TABLE `Mensagem` DISABLE KEYS */;
/*!40000 ALTER TABLE `Mensagem` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Permissao`
--

DROP TABLE IF EXISTS `Permissao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Permissao` (
  `permissao_id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  PRIMARY KEY (`permissao_id`),
  UNIQUE KEY `nome_UNIQUE` (`nome`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Permissao`
--

LOCK TABLES `Permissao` WRITE;
/*!40000 ALTER TABLE `Permissao` DISABLE KEYS */;
INSERT INTO `Permissao` VALUES (1,'Admin'),(2,'Diretoria'),(3,'Professor'),(4,'Responsavel');
/*!40000 ALTER TABLE `Permissao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Professor`
--

DROP TABLE IF EXISTS `Professor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Professor` (
  `professorId` int NOT NULL AUTO_INCREMENT,
  `usuario_id` int NOT NULL,
  `nomeCompleto` varchar(100) NOT NULL,
  `criadoEm` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `alteradoEm` datetime DEFAULT NULL,
  PRIMARY KEY (`professorId`),
  KEY `usuario_id` (`usuario_id`),
  CONSTRAINT `usuario_id` FOREIGN KEY (`usuario_id`) REFERENCES `Usuario` (`usuario_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Professor`
--

LOCK TABLES `Professor` WRITE;
/*!40000 ALTER TABLE `Professor` DISABLE KEYS */;
INSERT INTO `Professor` VALUES (3,10,'Maria Rosa','0001-01-01 00:00:00',NULL);
/*!40000 ALTER TABLE `Professor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Responsavel`
--

DROP TABLE IF EXISTS `Responsavel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Responsavel` (
  `responsaveis_id` int NOT NULL AUTO_INCREMENT,
  `nomeCompleto` varchar(100) NOT NULL,
  `telefone` varchar(10) NOT NULL,
  `criadoEm` datetime NOT NULL,
  `alteradoEm` datetime DEFAULT NULL,
  `usuario_id` int NOT NULL,
  PRIMARY KEY (`responsaveis_id`),
  KEY `fk_usuario_id` (`usuario_id`),
  CONSTRAINT `fk_usuario_id` FOREIGN KEY (`usuario_id`) REFERENCES `Usuario` (`usuario_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Responsavel`
--

LOCK TABLES `Responsavel` WRITE;
/*!40000 ALTER TABLE `Responsavel` DISABLE KEYS */;
INSERT INTO `Responsavel` VALUES (2,'Simone Souza','987635849','2024-09-03 02:48:49',NULL,11);
/*!40000 ALTER TABLE `Responsavel` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Turma`
--

DROP TABLE IF EXISTS `Turma`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Turma` (
  `turma_id` int NOT NULL AUTO_INCREMENT,
  `anoTurma` int NOT NULL,
  `escola_id` int NOT NULL,
  `professor_id` int DEFAULT NULL,
  `grauTurma` int NOT NULL,
  `periodoTurma` int NOT NULL,
  `criadoEm` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `alteradoEm` datetime DEFAULT NULL,
  PRIMARY KEY (`turma_id`),
  KEY `fk_escola_id` (`escola_id`),
  KEY `professor_id` (`professor_id`),
  CONSTRAINT `fk_escola_id` FOREIGN KEY (`escola_id`) REFERENCES `Escola` (`escola_id`),
  CONSTRAINT `professor_id` FOREIGN KEY (`professor_id`) REFERENCES `Professor` (`professorId`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Turma`
--

LOCK TABLES `Turma` WRITE;
/*!40000 ALTER TABLE `Turma` DISABLE KEYS */;
INSERT INTO `Turma` VALUES (1,5,1,3,1,0,'0001-01-01 00:00:00',NULL);
/*!40000 ALTER TABLE `Turma` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Usuario`
--

DROP TABLE IF EXISTS `Usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Usuario` (
  `usuario_id` int NOT NULL AUTO_INCREMENT,
  `nomeCompleto` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `senha` varchar(100) NOT NULL,
  `permissao_id` int NOT NULL,
  `escola_id` int NOT NULL,
  `criadoEm` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `alteradoEm` datetime DEFAULT NULL,
  PRIMARY KEY (`usuario_id`),
  UNIQUE KEY `email_UNIQUE` (`email`),
  KEY `permissao_id` (`permissao_id`),
  KEY `escola_id` (`escola_id`),
  CONSTRAINT `escola_id` FOREIGN KEY (`escola_id`) REFERENCES `Escola` (`escola_id`),
  CONSTRAINT `permissao_id` FOREIGN KEY (`permissao_id`) REFERENCES `Permissao` (`permissao_id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Usuario`
--

LOCK TABLES `Usuario` WRITE;
/*!40000 ALTER TABLE `Usuario` DISABLE KEYS */;
INSERT INTO `Usuario` VALUES (10,'Maria Rosa','mariarosa@example.com','123456',3,1,'0001-01-01 00:00:00',NULL),(11,'Simone Souza','simone.s@gmail.com','87654321',4,1,'2024-09-03 02:34:33',NULL);
/*!40000 ALTER TABLE `Usuario` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-09-09  8:07:49

    
   ```

### Pacotes e Bibliotecas :triangular_flag_on_post:

- .NET 7.0
- AutoMapper (13.0.1)
- Pomelo.EntityFrameworkCore.MySql (7.0.0)
- Microsoft.EntityFrameworkCore.Tools (7.0.2)
- Microsoft.EntityFrameworkCore.Design (7.0.2)

