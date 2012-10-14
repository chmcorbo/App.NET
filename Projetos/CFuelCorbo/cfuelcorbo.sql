# MySQL-Front 5.1  (Build 4.13)

/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE */;
/*!40101 SET SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES */;
/*!40103 SET SQL_NOTES='ON' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS */;
/*!40014 SET FOREIGN_KEY_CHECKS=0 */;


# Host: 127.0.0.1    Database: cfuelcorbo
# ------------------------------------------------------
# Server version 5.1.51-community

#
# Source for table tb_abastecimento
#

DROP TABLE IF EXISTS `tb_abastecimento`;
CREATE TABLE `tb_abastecimento` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `ID_VEICULO` int(11) DEFAULT NULL,
  `ID_POSTO` int(11) DEFAULT NULL,
  `ID_COMBUSTIVEL` int(11) DEFAULT NULL,
  `DATA_ABASTEC` date DEFAULT NULL,
  `HORA_ABASTEC` time DEFAULT NULL,
  `KM` int(11) DEFAULT NULL,
  `LITRAGEM` double DEFAULT NULL,
  `KM_LITRO` double DEFAULT NULL,
  `VALOR_UNIT` double DEFAULT NULL,
  `VALOR_TOTAL` double DEFAULT NULL,
  `OBSERVACAO` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Dumping data for table tb_abastecimento
#

LOCK TABLES `tb_abastecimento` WRITE;
/*!40000 ALTER TABLE `tb_abastecimento` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_abastecimento` ENABLE KEYS */;
UNLOCK TABLES;

#
# Source for table tb_combustivel
#

DROP TABLE IF EXISTS `tb_combustivel`;
CREATE TABLE `tb_combustivel` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `DESCRICAO` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

#
# Dumping data for table tb_combustivel
#

LOCK TABLES `tb_combustivel` WRITE;
/*!40000 ALTER TABLE `tb_combustivel` DISABLE KEYS */;
INSERT INTO `tb_combustivel` VALUES (1,'ETANOL COMUM');
INSERT INTO `tb_combustivel` VALUES (2,'ETANOL ADITIVADO');
INSERT INTO `tb_combustivel` VALUES (3,'GASOLINA COMUM');
INSERT INTO `tb_combustivel` VALUES (4,'GASOLINA ADITIVADA');
/*!40000 ALTER TABLE `tb_combustivel` ENABLE KEYS */;
UNLOCK TABLES;

#
# Source for table tb_posto
#

DROP TABLE IF EXISTS `tb_posto`;
CREATE TABLE `tb_posto` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `NOME` varchar(30) DEFAULT NULL,
  `BAIRRO` varchar(20) DEFAULT NULL,
  `CIDADE` varchar(20) DEFAULT NULL,
  `UF` varchar(2) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

#
# Dumping data for table tb_posto
#

LOCK TABLES `tb_posto` WRITE;
/*!40000 ALTER TABLE `tb_posto` DISABLE KEYS */;
INSERT INTO `tb_posto` VALUES (1,'POSTO SENDAS','VENDA VELHA','SÃO JOÃO DE MERITI','RJ');
INSERT INTO `tb_posto` VALUES (2,'POSTO CARINHOSO','CENTRO','SÃO JOÃO DE MERITI','RJ');
/*!40000 ALTER TABLE `tb_posto` ENABLE KEYS */;
UNLOCK TABLES;

#
# Source for table tb_usuario
#

DROP TABLE IF EXISTS `tb_usuario`;
CREATE TABLE `tb_usuario` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `LOGIN` varchar(10) DEFAULT NULL,
  `NOME` varchar(50) DEFAULT NULL,
  `SENHA` varchar(10) DEFAULT NULL,
  `ADMINISTRADOR` char(1) DEFAULT 'N',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

#
# Dumping data for table tb_usuario
#

LOCK TABLES `tb_usuario` WRITE;
/*!40000 ALTER TABLE `tb_usuario` DISABLE KEYS */;
INSERT INTO `tb_usuario` VALUES (1,'ADMIN','ADMINISTRADOR','123','S');
/*!40000 ALTER TABLE `tb_usuario` ENABLE KEYS */;
UNLOCK TABLES;

#
# Source for table tb_veiculo
#

DROP TABLE IF EXISTS `tb_veiculo`;
CREATE TABLE `tb_veiculo` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `PLACA` varchar(10) DEFAULT NULL,
  `MARCA` varchar(20) DEFAULT NULL,
  `MODELO` varchar(20) DEFAULT NULL,
  `COR` varchar(20) DEFAULT NULL,
  `RENAVAM` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

#
# Dumping data for table tb_veiculo
#

LOCK TABLES `tb_veiculo` WRITE;
/*!40000 ALTER TABLE `tb_veiculo` DISABLE KEYS */;
INSERT INTO `tb_veiculo` VALUES (1,'KYV2206','GM','CORSA PREMIUM','VERMELHO',NULL);
/*!40000 ALTER TABLE `tb_veiculo` ENABLE KEYS */;
UNLOCK TABLES;

/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
