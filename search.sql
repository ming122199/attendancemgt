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

/* Procedure structure for procedure `prcAddEmployee` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcAddEmployee` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcAddEmployee`(fname varchar(45),
                                                  lname varchar(45),
                                                  bdate varchar(100),
                                                  address varchar(100),
                                                  gender varchar(50),
                                                  dept varchar(100),
                                                  datehired varchar(100),
                                                  contact varchar(50))
BEGIN

 DECLARE d INTEGER;


 SET d = (Select id from tbl_department where name=dept);





	insert into tbl_employee(id, f_name, l_name, address, birthdate,
                                        date_hired, gender, dept_id,
                                         contactno)
	values(default, fname, lname, address, bdate, datehired, gender, d, contact );



END */$$
DELIMITER ;

/* Procedure structure for procedure `prcDeleteEmployee` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcDeleteEmployee` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcDeleteEmployee`(emp_id integer)
BEGIN
       delete from tbl_employee where id=emp_id;

END */$$
DELIMITER ;

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

/* Procedure structure for procedure `prcDisplayEmployees` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcDisplayEmployees` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcDisplayEmployees`()
BEGIN

SELECT id, dept_id,  f_name, l_name, address, birthdate,  gender, date_hired, contactno  FROM tbl_employee;

END */$$
DELIMITER ;

/* Procedure structure for procedure `prcDisplayEmployeeTimeIn` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcDisplayEmployeeTimeIn` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcDisplayEmployeeTimeIn`()
BEGIN
  
END */$$
DELIMITER ;

/* Procedure structure for procedure `prcDisplayEmployeeTimeRecord` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcDisplayEmployeeTimeRecord` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcDisplayEmployeeTimeRecord`(emp_id integer)
BEGIN
           select *  from tbl_employee where id=emp_id;
END */$$
DELIMITER ;

/* Procedure structure for procedure `prcEdit` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcEdit` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcEdit`(emp_id INTEGER(10),
                                                                        fname VARCHAR(50),
                                                                        lname VARCHAR (50),
                                                                        address VARCHAR (100),
                                                                        bdate VARCHAR(50),
                                                                        datehired VARCHAR(50),
                                                                        gender VARCHAR(50),
                                                                        dept VARCHAR(100),
                                                                        contact VARCHAR(50))
BEGIN
	 DECLARE d INTEGER;


 SET d = (SELECT id FROM tbl_department WHERE id=emp_id);

UPDATE tbl_employee SET id=emp_id,
                                   f_name=fname,
                                   l_name=lname,
                                   address=address,
                                   birthdate=bdate,
                                   date_hired=datehired,
                                   gender=gender,
                                   dept_id=d,
                                   contactno=contact;


	END */$$
DELIMITER ;

/* Procedure structure for procedure `prcEditEmployee` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcEditEmployee` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcEditEmployee`(emp_id integer(10),
                                                                        fname varchar(50),
                                                                        lname varchar (50),
                                                                        address varchar (100),
                                                                        bdate varchar(50),
                                                                        datehired varchar(50),
                                                                        gender varchar(50),
                                                                        dept varchar(100),
                                                                        contact varchar(50))
BEGIN

DECLARE d INTEGER;


 SET d = (Select id from tbl_department where name=dept);

UPDATE tbl_employee SET id=emp_id,
                                   f_name=fname,
                                   l_name=lname,
                                   address=address,
                                   birthdate=bdate,
                                   date_hired=datehired,
                                   gender=gender,
                                   dept_id=d,
                                   contactno=contact;


END */$$
DELIMITER ;

/* Procedure structure for procedure `prcLogin` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcLogin` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcLogin`()
BEGIN
  
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

/* Procedure structure for procedure `prcSelectUsers` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcSelectUsers` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcSelectUsers`()
BEGIN

select * from tbl_user;

END */$$
DELIMITER ;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
