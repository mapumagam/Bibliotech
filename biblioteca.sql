-- MySQL dump 10.13  Distrib 5.6.24, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: biblioteca_enrjga
-- ------------------------------------------------------
-- Server version	5.6.26

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `catalogos`
--

DROP TABLE IF EXISTS `catalogos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `catalogos` (
  `id_catalogo` int(10) unsigned NOT NULL AUTO_INCREMENT COMMENT 'Identificador de catálogos.',
  `descripcion` varchar(255) NOT NULL COMMENT 'Nombre del catálogo.',
  `tipo` varchar(2) NOT NULL COMMENT 'Tipo de catálogo:  AR- áreas, AU - autores y ED - editoriales. ',
  `estado` bit(1) NOT NULL DEFAULT b'1' COMMENT 'Estado del catálogo, determina si el catálogo está activo o inactivo.',
  PRIMARY KEY (`id_catalogo`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 COMMENT='Esta tabla almacena los catalogos de la aplicacion: AR- áreas, AU - autores y ED - editoriales. ';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `catalogos`
--

LOCK TABLES `catalogos` WRITE;
/*!40000 ALTER TABLE `catalogos` DISABLE KEYS */;
INSERT INTO `catalogos` VALUES (1,'Carlos Fuentes','AU',''),(2,'Grijalvo','ED',''),(3,'Cuentos','AR',''),(4,'José Rubén Romero','AU',''),(5,'Mexicana','ED','');
/*!40000 ALTER TABLE `catalogos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `libros`
--

DROP TABLE IF EXISTS `libros`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `libros` (
  `id_libro` int(10) unsigned NOT NULL AUTO_INCREMENT COMMENT 'Identificador de libros.',
  `clave` varchar(20) DEFAULT NULL COMMENT 'Clave del libro.',
  `id_area` int(10) unsigned NOT NULL COMMENT 'Llave foránea de la tabla catálogos para el tipo de dato: AR.',
  `id_autor` int(10) unsigned DEFAULT NULL COMMENT 'Llave foránea de la tabla catálogos para el tipo de dato: AU.',
  `id_editorial` int(10) unsigned DEFAULT NULL COMMENT 'Llave foránea de la tabla catálogos para el tipo de dato: ED.',
  `titulo` varchar(255) NOT NULL COMMENT 'Título del libro.',
  `edicion` varchar(5) DEFAULT NULL COMMENT 'Número de edición correspondiente al libro, en formato: 1a, 2a, etc.',
  `anio` varchar(4) DEFAULT NULL COMMENT 'Año de emisión de la edición del libro.',
  `no_ejemplares` int(10) unsigned NOT NULL COMMENT 'Número de ejemplares en existencia de la biblioteca.',
  PRIMARY KEY (`id_libro`),
  KEY `fk_area_idx` (`id_area`),
  KEY `fk_autor_idx` (`id_autor`),
  KEY `fk_editorial_idx` (`id_editorial`),
  CONSTRAINT `fk_area` FOREIGN KEY (`id_area`) REFERENCES `catalogos` (`id_catalogo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_autor` FOREIGN KEY (`id_autor`) REFERENCES `catalogos` (`id_catalogo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_editorial` FOREIGN KEY (`id_editorial`) REFERENCES `catalogos` (`id_catalogo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COMMENT='Esta tabla almacena los libros de la aplicación.';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `libros`
--

LOCK TABLES `libros` WRITE;
/*!40000 ALTER TABLE `libros` DISABLE KEYS */;
INSERT INTO `libros` VALUES (1,'Libro1',3,1,2,'Aura','1','1990',2),(2,'Libro2',3,4,5,'La vida inútil de Pito Pérez','2','1945',3),(3,'Libro3',3,4,5,'Otro Libro','1','1950',2),(4,'Libro4',3,1,2,'Tremesco','3','1987',1);
/*!40000 ALTER TABLE `libros` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `perdidos`
--

DROP TABLE IF EXISTS `perdidos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `perdidos` (
  `id_registro` int(10) unsigned NOT NULL AUTO_INCREMENT COMMENT 'Identificador del registro de libro perdido.',
  `id_libro` int(10) unsigned NOT NULL COMMENT 'Identificador de libros.',
  `fecha_perdida` date NOT NULL COMMENT 'Fecha en la que se perdió el ejemplar del libro.',
  `matricula` varchar(10) NOT NULL COMMENT 'Identificador del usuario que perdió el ejemplar del libro.',
  PRIMARY KEY (`id_registro`),
  UNIQUE KEY `id_registro_UNIQUE` (`id_registro`),
  KEY `fk_libro_idx` (`id_libro`),
  KEY `fk_usuario_idx` (`matricula`),
  CONSTRAINT `fk_libro` FOREIGN KEY (`id_libro`) REFERENCES `libros` (`id_libro`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_usuario` FOREIGN KEY (`matricula`) REFERENCES `usuarios` (`matricula`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Esta tabla almacena un registro de los libros que se han perdido de la biblioteca.';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `perdidos`
--

LOCK TABLES `perdidos` WRITE;
/*!40000 ALTER TABLE `perdidos` DISABLE KEYS */;
/*!40000 ALTER TABLE `perdidos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prestamos`
--

DROP TABLE IF EXISTS `prestamos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prestamos` (
  `id_prestamo` int(10) unsigned NOT NULL COMMENT 'Identificador de registro del préstamo.',
  `matricula` varchar(10) NOT NULL COMMENT 'Identificador del usuario de la biblioteca.',
  `fecha_prestamo` date NOT NULL COMMENT 'Fecha en la que se realizó el préstamo.',
  `fecha_entrega_sugerida` date NOT NULL COMMENT 'Fecha de entrega sugerida, fijada cuando se realizó el préstamo.',
  `fecha_entrega_real` date DEFAULT NULL COMMENT 'Fecha de entrega real.',
  `id_usuario_app` int(10) unsigned NOT NULL COMMENT 'Identificador del usuario de la aplicación que realizó el préstamo.',
  `id_libro` int(10) unsigned NOT NULL COMMENT 'Identificador del libro prestado',
  PRIMARY KEY (`id_prestamo`),
  UNIQUE KEY `id_prestamo_UNIQUE` (`id_prestamo`),
  KEY `fk_usuario_idx` (`matricula`),
  KEY `fk_usuario_app_idx` (`id_usuario_app`),
  KEY `fk_usuario_prestamo_idx` (`matricula`),
  KEY `fk_usuario_app_prestamo_idx` (`id_usuario_app`),
  KEY `fk_libro_prestado_idx` (`id_libro`),
  CONSTRAINT `fk_libro_prestado` FOREIGN KEY (`id_libro`) REFERENCES `libros` (`id_libro`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_usuario_app_prestamo` FOREIGN KEY (`id_usuario_app`) REFERENCES `usuarios_app` (`id_usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_usuario_prestamo` FOREIGN KEY (`matricula`) REFERENCES `usuarios` (`matricula`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prestamos`
--

LOCK TABLES `prestamos` WRITE;
/*!40000 ALTER TABLE `prestamos` DISABLE KEYS */;
INSERT INTO `prestamos` VALUES (0,'1','2016-07-11','2016-07-13',NULL,1,2),(1,'1','2016-07-10','2016-07-13',NULL,1,1);
/*!40000 ALTER TABLE `prestamos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuarios` (
  `matricula` varchar(10) NOT NULL COMMENT 'Identificador de los usuarios de la biblioteca.',
  `primer_nombre` varchar(80) NOT NULL COMMENT 'primer nombre del usuario.',
  `segundo_nombre` varchar(80) DEFAULT NULL COMMENT 'Segundo nombre del usuario.',
  `apellido_paterno` varchar(80) DEFAULT NULL COMMENT 'Apellido paterno del usuario.',
  `apellido_materno` varchar(80) NOT NULL COMMENT 'Apellido materno del usuario.',
  `tipo_usuario` varchar(2) NOT NULL COMMENT 'Tipo de usuario: AL - Alumno, PR - Profesor y NI - No Identificado.',
  PRIMARY KEY (`matricula`),
  UNIQUE KEY `matricula_UNIQUE` (`matricula`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Esta tabla almacena los usuarios de la biblioteca.';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES ('1','Guillermo',NULL,'Alvarado','Montañez','AL'),('2','Marisol',NULL,'Martinez','Pulgarin','PR'),('3','Benjamin','Cocoliso','','Rodarte','OT');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios_app`
--

DROP TABLE IF EXISTS `usuarios_app`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuarios_app` (
  `id_usuario` int(10) unsigned NOT NULL COMMENT 'Identificador de usuarios de la aplicación.',
  `nombre_usuario` varchar(15) NOT NULL COMMENT 'Nombre de usuario de la aplicación.',
  `contrasenia` varchar(10) NOT NULL COMMENT 'Contraseña del usuario de la aplicación.',
  `estado` bit(1) NOT NULL DEFAULT b'1' COMMENT 'Estado del usuario: 1 - Activo, 0 - Inactivo.',
  `nombre_completo` varchar(255) NOT NULL COMMENT 'Nombre completo del usuario.',
  PRIMARY KEY (`id_usuario`),
  UNIQUE KEY `id_usuario_UNIQUE` (`id_usuario`),
  UNIQUE KEY `nombre_usuario_UNIQUE` (`nombre_usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Esta almacena los usuarios de la aplicación.';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios_app`
--

LOCK TABLES `usuarios_app` WRITE;
/*!40000 ALTER TABLE `usuarios_app` DISABLE KEYS */;
INSERT INTO `usuarios_app` VALUES (1,'EL benjas','12345','','Benjamin Cocoliso Rodarte Blas');
/*!40000 ALTER TABLE `usuarios_app` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-07-16 14:18:05
