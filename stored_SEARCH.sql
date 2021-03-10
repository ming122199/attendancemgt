/*
SQLyog Community v13.1.6 (64 bit)
MySQL - 5.0.67-community-nt : Database - db_attendance
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`db_attendance` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `db_attendance`;

/* Procedure structure for procedure `prcDisplayByAutoSearch` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcDisplayByAutoSearch` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcDisplayByAutoSearch`(p_searchtype varchar(45), p_value varchar(200))
BEGIN
	if p_searchtype="EMPLOYEE ID" then
	select * from tbl_employee where id like concat(p_value,'%');
	else
	SELECT * FROM tbl_employee WHERE f_name LIKE CONCAT(p_value,'%');
	end if;

	END */$$
DELIMITER ;

/* Procedure structure for procedure `prcSelAllEmployee` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcSelAllEmployee` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcSelAllEmployee`()
BEGIN
       SELECT * FROM tbl_employee ORDER BY f_name;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `prcSelAllEmployeeByAutoComplete` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcSelAllEmployeeByAutoComplete` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcSelAllEmployeeByAutoComplete`(p_searchtype varchar(45), p_value varchar(200))
BEGIN
	if p_searchtype="EMPLOYEE ID" then
	select * from tbl_employee where id like concat(p_value,'%');
	else
	SELECT * FROM tbl_employee WHERE f_name LIKE CONCAT(p_value,'%')  OR  l_name LIKE CONCAT(p_value,'%');
	end if;

	END */$$
DELIMITER ;

/* Procedure structure for procedure `prcSelcEmpbyID` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcSelcEmpbyID` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcSelcEmpbyID`(empID integer)
BEGIN
      SELECT id, dept_id,  f_name, l_name, address, birthdate,  gender, date_hired, contactno
      FROM tbl_employee where id=empID;
END */$$
DELIMITER ;

/* Procedure structure for procedure `prcSelcEmpbyName` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcSelcEmpbyName` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcSelcEmpbyName`(empName varchar(200) )
BEGIN
      SELECT id, dept_id,  f_name, l_name, address, birthdate,  gender, date_hired, contactno
      FROM tbl_employee WHERE f_name=empName or l_name=empName;
	END */$$
DELIMITER ;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
