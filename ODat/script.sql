-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 ;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`Doctors`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Doctors` (
  `Id` INT NOT NULL,
  `Name` VARCHAR(255) NOT NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`ClientAppointments`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`ClientAppointments` (
  `Id` INT NOT NULL,
  `DoctorId` INT NULL,
  `Comments` VARCHAR(45) NULL,
  PRIMARY KEY (`Id`),
  INDEX `FK_ClientAppointments_Doctors_Id_idx` (`DoctorId` ASC) VISIBLE,
  CONSTRAINT `FK_ClientAppointments_Doctors_Id`
    FOREIGN KEY (`DoctorId`)
    REFERENCES `mydb`.`Doctors` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

-- -----------------------------------------------------
-- Data for table `mydb`.`Doctors`
-- -----------------------------------------------------
START TRANSACTION;
USE `mydb`;
INSERT INTO `mydb`.`Doctors` (`Id`, `Name`) VALUES (1, 'Doctor1');

COMMIT;


-- -----------------------------------------------------
-- Data for table `mydb`.`ClientAppointments`
-- -----------------------------------------------------
START TRANSACTION;
USE `mydb`;
INSERT INTO `mydb`.`ClientAppointments` (`Id`, `DoctorId`, `Comments`) VALUES (1, 1, 'Doctor1');
INSERT INTO `mydb`.`ClientAppointments` (`Id`, `DoctorId`, `Comments`) VALUES (2, NULL, 'No doctor');

COMMIT;

