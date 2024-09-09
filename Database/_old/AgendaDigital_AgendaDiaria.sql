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
  `atividades` varchar(1024) DEFAULT NULL,
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
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-09-02 23:58:17
