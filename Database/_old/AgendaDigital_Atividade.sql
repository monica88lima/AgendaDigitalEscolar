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
  CONSTRAINT `fk-professor_id` FOREIGN KEY (`professor_id`) REFERENCES `Professor` (`professor_id`),
  CONSTRAINT `fk-turma_id-atv` FOREIGN KEY (`turma_id`) REFERENCES `Turma` (`turma_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Atividade`
--

LOCK TABLES `Atividade` WRITE;
/*!40000 ALTER TABLE `Atividade` DISABLE KEYS */;
INSERT INTO `Atividade` VALUES (1,'Construir Brinquedo','Construir um brinquedo com Materiais reciclavéis','Caixas de papelão, garrafas pet, cola, tesoura, lapis de colorir','2024-09-28 00:00:00','2024-09-03 02:28:15',1,3,0,NULL);
/*!40000 ALTER TABLE `Atividade` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-09-02 23:58:16
