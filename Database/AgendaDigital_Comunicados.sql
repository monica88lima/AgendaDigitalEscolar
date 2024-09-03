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
-- Table structure for table `Comunicados`
--

DROP TABLE IF EXISTS `Comunicados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Comunicados` (
  `comunicado_id` int NOT NULL AUTO_INCREMENT,
  `descricao` varchar(1024) NOT NULL,
  `titulo` varchar(100) NOT NULL,
  `professor_id` int NOT NULL,
  `assinaturaCriador` varchar(100) NOT NULL,
  `observacao` varchar(100) DEFAULT NULL,
  `lido` tinyint NOT NULL,
  `criadoEm` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `alteradoEm` datetime DEFAULT NULL,
  PRIMARY KEY (`comunicado_id`),
  KEY `fk_professor_id` (`professor_id`),
  CONSTRAINT `fk_professor_id` FOREIGN KEY (`professor_id`) REFERENCES `Professor` (`professor_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Comunicados`
--

LOCK TABLES `Comunicados` WRITE;
/*!40000 ALTER TABLE `Comunicados` DISABLE KEYS */;
INSERT INTO `Comunicados` VALUES (1,'string','string',1,'string','string',1,'0001-01-01 00:00:00',NULL),(2,'Aos responsáveis e alunos, a partir do dia 01/08/2024, o uso do uniforme escolar será obrigatório para todos os estudantes.O uniforme é essencial para a identidade e segurança escolar, promovendo igualdade e disciplina. Pedimos a colaboração de todos para que os alunos estejam devidamente uniformizados a partir dessa data. O não cumprimento poderá resultar em medidas administrativas.','Uniforme Escolar',3,'Agradecemos a compreensão e a colaboração de todos. Atenciosamente, Escola Florescer','Venda e Informações: Rose (11) 3567-9865',0,'0001-01-01 00:00:00',NULL);
/*!40000 ALTER TABLE `Comunicados` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-09-02 23:58:15
