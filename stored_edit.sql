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

/*Table structure for table `tbl_department` */

DROP TABLE IF EXISTS `tbl_department`;

CREATE TABLE `tbl_department` (
  `id` int(10) NOT NULL,
  `dept_ID` int(15) NOT NULL,
  `dept_name` varchar(45) NOT NULL,
  PRIMARY KEY  (`id`,`dept_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbl_department` */

insert  into `tbl_department`(`id`,`dept_ID`,`dept_name`) values 
(1,0,'Plantation'),
(2,0,'Harvesting'),
(3,0,'Fertilizer'),
(4,0,'Office'),
(5,0,'Bagging'),
(6,0,'Bunch Spraying'),
(7,0,'Bud Removal/Debudding'),
(8,0,'Pests and Disease Management');

/* Procedure structure for procedure `prcAddEmployee` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcAddEmployee` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcAddEmployee`( empid integer,fname varchar(45),
                                                  lname varchar(45),
                                                  bdate varchar(100),
                                                  address varchar(100),
                                                  gender varchar(50),
                                                  dept varchar(100),
                                                  datehired varchar(100),
                                                  contact varchar(50))
BEGIN

 DECLARE d INTEGER;


 SET d = (SELECT id FROM tbl_department WHERE dept_name=dept);


	insert into tbl_employee(id,emp_ID, f_name, l_name, address, birthdate,
                                        date_hired, gender, dept_id,
                                         contactno)
	values(default, empid,fname, lname, address, bdate, datehired, gender, d, contact );

END */$$
DELIMITER ;

/* Procedure structure for procedure `prcEditEmployee` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcEditEmployee` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcEditEmployee`( ID integer, emp_id INTEGER,
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


 SET d = (Select dept_ID from tbl_department where dept_name=dept);
        
       Update tbl_employee SET f_name=fname,
                                   l_name=lname,
                                   address=address,
                                   birthdate=bdate,
                                   date_hired=datehired,
                                   gender=gender,
                                   dept_id= d,
                                   contactno=contact where ID = id;
              

END */$$
DELIMITER ;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
