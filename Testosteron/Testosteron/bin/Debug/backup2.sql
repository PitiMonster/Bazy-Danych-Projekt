-- MySqlBackup.NET 2.3.1
-- Dump Time: 2020-01-14 01:28:31
-- --------------------------------------
-- Server version 8.0.18 MySQL Community Server - GPL


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 
-- Definition of akcesoria
-- 

DROP TABLE IF EXISTS `akcesoria`;
CREATE TABLE IF NOT EXISTS `akcesoria` (
  `produkt_id` int(11) NOT NULL,
  `typ` enum('Shaker','Ubranie','Inne') NOT NULL,
  `nazwa` varchar(75) NOT NULL,
  `opis` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`produkt_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table akcesoria
-- 

/*!40000 ALTER TABLE `akcesoria` DISABLE KEYS */;
INSERT INTO `akcesoria`(`produkt_id`,`typ`,`nazwa`,`opis`) VALUES
(10,'Shaker','xdddd','xddd'),
(12,'Shaker','abc','xd'),
(34,'Shaker','1','2'),
(35,'Ubranie','1','2'),
(36,'Inne','1','2');
/*!40000 ALTER TABLE `akcesoria` ENABLE KEYS */;

-- 
-- Definition of białko
-- 

DROP TABLE IF EXISTS `białko`;
CREATE TABLE IF NOT EXISTS `białko` (
  `produkt_id` int(11) NOT NULL,
  `typ` enum('WPC','WPI','WPH') NOT NULL,
  `smak` varchar(50) NOT NULL,
  `opis` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`produkt_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table białko
-- 

/*!40000 ALTER TABLE `białko` DISABLE KEYS */;
INSERT INTO `białko`(`produkt_id`,`typ`,`smak`,`opis`) VALUES
(2,'WPC','xd','xd'),
(3,'WPC','xd','xdddddd'),
(4,'WPH','zielony','cos'),
(15,'WPC','abc','xd'),
(17,'WPC','xd','xd2'),
(18,'WPC','xd','1'),
(23,'WPC','1','2'),
(27,'WPC','1','2'),
(37,'WPC','xddd1','1'),
(38,'WPI','1','2'),
(39,'WPI','3','1'),
(40,'WPH','111','111111111111111'),
(41,'WPI','xd','12'),
(47,'WPI','lolz','xd'),
(50,'WPC','xdd12','1'),
(51,'WPH','1','1');
/*!40000 ALTER TABLE `białko` ENABLE KEYS */;

-- 
-- Definition of dostawcy
-- 

DROP TABLE IF EXISTS `dostawcy`;
CREATE TABLE IF NOT EXISTS `dostawcy` (
  `dostawca_id` int(11) NOT NULL AUTO_INCREMENT,
  `nazwa` varchar(20) NOT NULL,
  `NIP` varchar(13) NOT NULL,
  `adres` varchar(30) NOT NULL,
  PRIMARY KEY (`dostawca_id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table dostawcy
-- 

/*!40000 ALTER TABLE `dostawcy` DISABLE KEYS */;
INSERT INTO `dostawcy`(`dostawca_id`,`nazwa`,`NIP`,`adres`) VALUES
(9,'xd','99070409176','aaa'),
(10,'przechuj','99090504552','axd');
/*!40000 ALTER TABLE `dostawcy` ENABLE KEYS */;

-- 
-- Definition of dostawy
-- 

DROP TABLE IF EXISTS `dostawy`;
CREATE TABLE IF NOT EXISTS `dostawy` (
  `dostawa_id` int(11) NOT NULL AUTO_INCREMENT,
  `data` date NOT NULL,
  `dostawca_id` int(11) NOT NULL,
  `sukces` tinyint(1) NOT NULL DEFAULT (false),
  PRIMARY KEY (`dostawa_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table dostawy
-- 

/*!40000 ALTER TABLE `dostawy` DISABLE KEYS */;

/*!40000 ALTER TABLE `dostawy` ENABLE KEYS */;

-- 
-- Definition of klienci
-- 

DROP TABLE IF EXISTS `klienci`;
CREATE TABLE IF NOT EXISTS `klienci` (
  `klient_id` int(11) NOT NULL AUTO_INCREMENT,
  `nazwa` varchar(20) NOT NULL,
  `NIP` varchar(13) NOT NULL,
  `adres` varchar(30) NOT NULL,
  PRIMARY KEY (`klient_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table klienci
-- 

/*!40000 ALTER TABLE `klienci` DISABLE KEYS */;
INSERT INTO `klienci`(`klient_id`,`nazwa`,`NIP`,`adres`) VALUES
(1,'xd','99070409176','xd');
/*!40000 ALTER TABLE `klienci` ENABLE KEYS */;

-- 
-- Definition of odżywki
-- 

DROP TABLE IF EXISTS `odżywki`;
CREATE TABLE IF NOT EXISTS `odżywki` (
  `produkt_id` int(11) NOT NULL,
  `typ` enum('Przedtreningowa','Gainer','Potreningowa','Inna') NOT NULL,
  `nazwa` varchar(75) NOT NULL,
  `opis` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`produkt_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table odżywki
-- 

/*!40000 ALTER TABLE `odżywki` DISABLE KEYS */;
INSERT INTO `odżywki`(`produkt_id`,`typ`,`nazwa`,`opis`) VALUES
(11,'Gainer','abc','xd'),
(24,'Gainer','1','2'),
(29,'Przedtreningowa','1','2'),
(31,'Gainer','1','2'),
(32,'Potreningowa','1','2'),
(33,'Inna','1','2'),
(49,'Przedtreningowa','xd','1');
/*!40000 ALTER TABLE `odżywki` ENABLE KEYS */;

-- 
-- Definition of produkty
-- 

DROP TABLE IF EXISTS `produkty`;
CREATE TABLE IF NOT EXISTS `produkty` (
  `produkt_id` int(11) NOT NULL AUTO_INCREMENT,
  `typ` enum('białko','akcesoria','suplementy','odżywki') NOT NULL,
  `cena` int(11) NOT NULL,
  `ilość` int(11) NOT NULL,
  PRIMARY KEY (`produkt_id`)
) ENGINE=InnoDB AUTO_INCREMENT=53 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table produkty
-- 

/*!40000 ALTER TABLE `produkty` DISABLE KEYS */;
INSERT INTO `produkty`(`produkt_id`,`typ`,`cena`,`ilość`) VALUES
(1,'białko',10,1000),
(2,'białko',10,1000),
(3,'białko',10,1000),
(4,'białko',12,1000),
(5,'białko',124,10000),
(6,'suplementy',15,1000),
(7,'suplementy',15,1000),
(8,'suplementy',15,1000),
(9,'suplementy',15,1000),
(10,'akcesoria',25,1000),
(11,'odżywki',256,1000),
(12,'akcesoria',256,1000),
(13,'suplementy',256,1000),
(14,'białko',256,45),
(15,'białko',256,45),
(16,'białko',15,15),
(17,'białko',10,10),
(18,'białko',1,1),
(20,'suplementy',10,10),
(21,'suplementy',10,10),
(22,'suplementy',10,10),
(23,'białko',3,4),
(24,'odżywki',3,4),
(25,'suplementy',10,4),
(26,'suplementy',10,4),
(27,'białko',3,4),
(28,'suplementy',10,4),
(30,'odżywki',3,4),
(31,'odżywki',3,4),
(32,'odżywki',3,4),
(33,'odżywki',3,4),
(34,'akcesoria',3,4),
(35,'akcesoria',3,4),
(36,'akcesoria',34,4),
(37,'białko',23,23),
(38,'białko',3,4),
(39,'białko',2,1),
(40,'białko',3,1111),
(41,'białko',1,1),
(43,'suplementy',2,3),
(45,'suplementy',1,1),
(46,'suplementy',10,10),
(47,'białko',1,2),
(48,'suplementy',10,10),
(49,'odżywki',1,1),
(50,'białko',1,1),
(51,'białko',1,1),
(52,'suplementy',-4,-4);
/*!40000 ALTER TABLE `produkty` ENABLE KEYS */;

-- 
-- Definition of sprzedaże
-- 

DROP TABLE IF EXISTS `sprzedaże`;
CREATE TABLE IF NOT EXISTS `sprzedaże` (
  `sprzedaż_id` int(11) NOT NULL AUTO_INCREMENT,
  `data` date NOT NULL,
  `klient_id` int(11) NOT NULL,
  `sukces` tinyint(1) NOT NULL DEFAULT (false),
  PRIMARY KEY (`sprzedaż_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table sprzedaże
-- 

/*!40000 ALTER TABLE `sprzedaże` DISABLE KEYS */;

/*!40000 ALTER TABLE `sprzedaże` ENABLE KEYS */;

-- 
-- Definition of suplementy
-- 

DROP TABLE IF EXISTS `suplementy`;
CREATE TABLE IF NOT EXISTS `suplementy` (
  `produkt_id` int(11) NOT NULL,
  `typ` enum('Kreatyna','Aminokwasy','Inne') NOT NULL,
  `nazwa` varchar(75) NOT NULL,
  `opis` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`produkt_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table suplementy
-- 

/*!40000 ALTER TABLE `suplementy` DISABLE KEYS */;
INSERT INTO `suplementy`(`produkt_id`,`typ`,`nazwa`,`opis`) VALUES
(6,'Kreatyna','xd','xd'),
(7,'Kreatyna','xd','xd'),
(9,'Kreatyna','xd','xd'),
(13,'Inne','abc','xd'),
(21,'Inne','xd','xd2'),
(22,'Inne','xd','xd2'),
(25,'Inne','xd','xd2'),
(26,'Inne','xd','xd2'),
(28,'Inne','xd','xd2'),
(42,'Kreatyna','xd','1'),
(44,'Aminokwasy','xd123','1'),
(46,'Inne','xd','xd2'),
(48,'Inne','xd','xd2'),
(52,'Aminokwasy','bialko ekstra','KURWA');
/*!40000 ALTER TABLE `suplementy` ENABLE KEYS */;

-- 
-- Definition of szczegóły_dostawy
-- 

DROP TABLE IF EXISTS `szczegóły_dostawy`;
CREATE TABLE IF NOT EXISTS `szczegóły_dostawy` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `produkt_id` int(11) NOT NULL,
  `dostawa` int(11) NOT NULL,
  `ilość` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table szczegóły_dostawy
-- 

/*!40000 ALTER TABLE `szczegóły_dostawy` DISABLE KEYS */;

/*!40000 ALTER TABLE `szczegóły_dostawy` ENABLE KEYS */;

-- 
-- Definition of szczegóły_sprzedaży
-- 

DROP TABLE IF EXISTS `szczegóły_sprzedaży`;
CREATE TABLE IF NOT EXISTS `szczegóły_sprzedaży` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `produkt_id` int(11) NOT NULL,
  `sprzedaż` int(11) NOT NULL,
  `ilość` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table szczegóły_sprzedaży
-- 

/*!40000 ALTER TABLE `szczegóły_sprzedaży` DISABLE KEYS */;

/*!40000 ALTER TABLE `szczegóły_sprzedaży` ENABLE KEYS */;

-- 
-- Definition of użytkownicy
-- 

DROP TABLE IF EXISTS `użytkownicy`;
CREATE TABLE IF NOT EXISTS `użytkownicy` (
  `login` varchar(20) NOT NULL,
  `hasło_sha2` varchar(64) NOT NULL,
  `typ` enum('admin','menedżer','pracownik') NOT NULL DEFAULT (_utf8mb4'pracownik'),
  PRIMARY KEY (`login`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table użytkownicy
-- 

/*!40000 ALTER TABLE `użytkownicy` DISABLE KEYS */;
INSERT INTO `użytkownicy`(`login`,`hasło_sha2`) VALUES
('a','3e23e8160039594a33894f6564e1b1348bbd7a0088d42c4acb73eeaed59c009d'),
('abcd','88d4266fd4e6338d13b845fcf289579d209c897823b9217da3e161936f031589'),
('abcde','88d4266fd4e6338d13b845fcf289579d209c897823b9217da3e161936f031589'),
('abcdef','88d4266fd4e6338d13b845fcf289579d209c897823b9217da3e161936f031589'),
('abcdg','88d4266fd4e6338d13b845fcf289579d209c897823b9217da3e161936f031589'),
('admin','8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918'),
('test','test'),
('test2','test'),
('test3','test'),
('testujemy','9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08'),
('testujemy2','9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08');
/*!40000 ALTER TABLE `użytkownicy` ENABLE KEYS */;

-- 
-- Dumping functions
-- 

-- 
-- Dumping procedures
-- 


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2020-01-14 01:28:31
-- Total time: 0:0:0:0:141 (d:h:m:s:ms)
