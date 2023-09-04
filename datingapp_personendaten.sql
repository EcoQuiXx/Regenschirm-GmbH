-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: localhost    Database: datingapp
-- ------------------------------------------------------
-- Server version	8.0.32

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
-- Table structure for table `personendaten`
--

DROP TABLE IF EXISTS `personendaten`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `personendaten` (
  `pd_id` int NOT NULL AUTO_INCREMENT,
  `pd_vorname` varchar(45) DEFAULT NULL,
  `pd_nachname` varchar(45) DEFAULT NULL,
  `pd_geschlecht` varchar(45) DEFAULT NULL,
  `pd_geburtsdatum` date DEFAULT NULL,
  `pd_ortschaft` varchar(45) DEFAULT NULL,
  `pd_postleitzahl` varchar(16) DEFAULT NULL,
  `pd_straße` varchar(45) DEFAULT NULL,
  `pd_hausnummer` varchar(45) DEFAULT NULL,
  `pd_lieblingstier` varchar(45) DEFAULT NULL,
  `pd_lieblingsfilm` varchar(45) DEFAULT NULL,
  `pd_raucher` tinyint(1) DEFAULT NULL,
  `pd_alkohol` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pd_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `personendaten`
--

LOCK TABLES `personendaten` WRITE;
/*!40000 ALTER TABLE `personendaten` DISABLE KEYS */;
INSERT INTO `personendaten` VALUES (1,'Ben','Gornik','Männlich','2004-03-10','Bergisch Gladbach','51429','Klein Hohn','28','Hund','Interstellar',0,0),(2,'Justin','Kreutz','Männlich','2004-05-31','Bergisch Gladbach','51467','Mutzerstraße','84','Katze','Interstellar',0,1),(3,'Ricardo','Petro','Männlich','2002-01-26','Bergisch Gladbach','51465','Lohplatz','18','Hund','Suzume',0,0);
/*!40000 ALTER TABLE `personendaten` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-09-04 14:20:33
