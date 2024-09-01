-- Script Criação Banco de Dados
-- Agenda Digital
-- 
-- MySQL 

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema AgendaDigital
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema AgendaDigital
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `AgendaDigital` DEFAULT CHARACTER SET utf8 ;
USE `AgendaDigital` ;

-- -----------------------------------------------------
-- Table `AgendaDigital`.`Permissao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `AgendaDigital`.`Permissao` (
  `permissao_id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(100)  NOT NULL,
  PRIMARY KEY (`permissao_id`)
)ENGINE = InnoDB;

CREATE UNIQUE INDEX `nome_UNIQUE` ON `AgendaDigital`.`Permissao` (`nome` ASC);


-- -----------------------------------------------------
-- Table `AgendaDigital`.`Escola`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `AgendaDigital`.`Escola` (
  `escola_id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(100) NOT NULL,
  `telefone` VARCHAR(10) NOT NULL,
  `endereco` VARCHAR(100) NOT NULL,
  `criadoEm` DATETIME NOT NULL DEFAULT NOW(),
  `alteradoEm` DATETIME NULL,
  PRIMARY KEY (`escola_id`))
ENGINE = InnoDB;

CREATE UNIQUE INDEX `escola_id_UNIQUE` ON `AgendaDigital`.`Escola` (`escola_id` ASC) ;


-- -----------------------------------------------------
-- Table `AgendaDigital`.`Usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `AgendaDigital`.`Usuario` (
  `usuario_id` INT NOT NULL AUTO_INCREMENT,
  `nomeCompleto` VARCHAR(100) NOT NULL,
  `email` VARCHAR(100) NOT NULL,
  `senha` VARCHAR(100) NOT NULL,
  `permissao_id` INT NOT NULL,
  `escola_id` INT NOT NULL,
  `criadoEm` DATETIME NOT NULL DEFAULT now(),
  `alteradoEm` DATETIME NULL,
  PRIMARY KEY (`usuario_id`),
  CONSTRAINT `permissao_id`
    FOREIGN KEY (`permissao_id`)
    REFERENCES `AgendaDigital`.`Permissao` (`permissao_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `escola_id`
    FOREIGN KEY (`escola_id`)
    REFERENCES `AgendaDigital`.`Escola` (`escola_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

 CREATE UNIQUE INDEX `email_UNIQUE` ON `AgendaDigital`.`Usuario` (`email` ASC) ;


-- -----------------------------------------------------
-- Table `AgendaDigital`.`Professor`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `AgendaDigital`.`Professor` (
  `professorId` INT NOT NULL AUTO_INCREMENT,
  `usuario_id` INT NOT NULL,
  `nomeCompleto` VARCHAR(100) NOT NULL,
  `criadoEm` DATETIME NOT NULL DEFAULT NOW(),
  `alteradoEm` DATETIME NULL,
  PRIMARY KEY (`professorId`),
  CONSTRAINT `usuario_id`
    FOREIGN KEY (`usuario_id`)
    REFERENCES `AgendaDigital`.`Usuario` (`usuario_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `AgendaDigital`.`Turmas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `AgendaDigital`.`Turmas` (
  `turma_id` INT NOT NULL AUTO_INCREMENT,
  `anoTurma` INT NOT NULL,
  `escola_id` INT NOT NULL,
  `professor_id` INT NULL,
  `grauTurma` INT NOT NULL,
  `periodoTurma` INT NOT NULL,
   PRIMARY KEY (`turma_id`),
  CONSTRAINT `fk_escola_id`
    FOREIGN KEY (`escola_id`)
    REFERENCES `AgendaDigital`.`Escola` (`escola_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `professor_id`
    FOREIGN KEY (`professor_id`)
    REFERENCES `AgendaDigital`.`Professor` (`professorId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `AgendaDigital`.`Estudante`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `AgendaDigital`.`Estudante` (
  `estudante_id` INT NOT NULL AUTO_INCREMENT,
  `nomeCompleto` VARCHAR(100) NOT NULL,
  `turma_id` INT NOT NULL,
  `matricula` INT NOT NULL,
  `criadoEm` DATETIME NOT NULL DEFAULT Now(),
  `alteradoEm` DATETIME NULL,
  PRIMARY KEY (`estudante_id`),
  CONSTRAINT `turma_id`
    FOREIGN KEY (`turma_id`)
    REFERENCES `AgendaDigital`.`Turmas` (`turma_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

CREATE UNIQUE INDEX `matricula_UNIQUE` ON `AgendaDigital`.`Estudante` (`matricula` ASC) ;


-- -----------------------------------------------------
-- Table `AgendaDigital`.`Responsaveis`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `AgendaDigital`.`Responsaveis` (
  `responsaveis_id` INT NOT NULL AUTO_INCREMENT,
  `nomeCompleto` VARCHAR(100) NOT NULL,
  `telefone` VARCHAR(10) NOT NULL,
  `criadoEm` DATETIME NOT NULL,
  `alteradoEm` DATETIME NULL,
  `usuario_id` INT NOT NULL,
  PRIMARY KEY (`responsaveis_id`),
  CONSTRAINT `fk_usuario_id`
    FOREIGN KEY (`usuario_id`)
    REFERENCES `AgendaDigital`.`Usuario` (`usuario_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `AgendaDigital`.`Comunicados`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `AgendaDigital`.`Comunicados` (
  `comunicado_id` INT NOT NULL AUTO_INCREMENT,
  `descricao` VARCHAR(300) NOT NULL,
  `titulo` VARCHAR(100) NOT NULL,
  `criadoEm` DATETIME NOT NULL,
  `professor_id` INT NOT NULL,
  `assinaturaCriador` VARCHAR(100) NOT NULL,
  `observacao` VARCHAR(100) NULL,
  `lido` TINYINT NOT NULL,
  PRIMARY KEY (`comunicado_id`),
  CONSTRAINT `fk_professor_id`
    FOREIGN KEY (`professor_id`)
    REFERENCES `AgendaDigital`.`Professor` (`professorid`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `AgendaDigital`.`Eventos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `AgendaDigital`.`Eventos` (
  `evento_id` INT NOT NULL AUTO_INCREMENT,
  `titulo` VARCHAR(100) NOT NULL,
  `descricao` VARCHAR(300) NOT NULL,
  `dataEvento` DATETIME NOT NULL,
  `hora` VARCHAR(4) NOT NULL,
  `local` VARCHAR(100) NOT NULL,
  `criadoEm` DATETIME NOT NULL DEFAULT NOW(),
  `escola_id` INT NOT NULL,
  `lido` TINYINT NOT NULL,
  PRIMARY KEY (`evento_id`),
  CONSTRAINT `fk_escola_id_Ev`
    FOREIGN KEY (`escola_id`)
    REFERENCES `AgendaDigital`.`Escola` (`escola_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `AgendaDigital`.`Estudante_Responsavel`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `AgendaDigital`.`Estudante_Responsavel` (
   `estudante_id` INT NOT NULL,
   `responsavel_id` INT NOT NULL,
   PRIMARY KEY (`estudante_id`, `responsavel_id`),  -- Chave primária composta
   CONSTRAINT `fk_estudante_id`
     FOREIGN KEY (`estudante_id`)
     REFERENCES `AgendaDigital`.`Estudante` (`estudante_id`)
     ON DELETE NO ACTION
     ON UPDATE NO ACTION,
   CONSTRAINT `fk_responsavel_id`
     FOREIGN KEY (`responsavel_id`)
     REFERENCES `AgendaDigital`.`Responsaveis` (`responsaveis_id`)
     ON DELETE NO ACTION
     ON UPDATE NO ACTION
) ENGINE = InnoDB;

 CREATE INDEX `estudante_id_idx` ON `AgendaDigital`.`Estudante_Responsavel` (`estudante_id` ASC, `responsavel_id` ASC) ;

 CREATE INDEX `responsavel_id_idx` ON `AgendaDigital`.`Estudante_Responsavel` (`responsavel_id` ASC) ;


-- -----------------------------------------------------
-- Table `AgendaDigital`.`AgendaDiaria`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `AgendaDigital`.`AgendaDiaria` (
  `agendaDiaria_id` INT NOT NULL AUTO_INCREMENT,
  `estudante_id` INT NOT NULL,
  `data` DATETIME NULL,
  `refeicao_status` INT NULL,
  `sono_status` INT NULL,
  `higiene_status` INT NULL,
  `atividades` VARCHAR(300) NULL,
  `criadoEm` DATETIME NOT NULL DEFAULT Now(),
  `alteradoEm` DATETIME NULL,
  `lido` TINYINT NOT NULL,
  PRIMARY KEY (`agendaDiaria_id`),
  CONSTRAINT `estudante_id`
    FOREIGN KEY (`estudante_id`)
    REFERENCES `AgendaDigital`.`Estudante` (`estudante_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `AgendaDigital`.`comunicado_turmas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `AgendaDigital`.`comunicado_turmas` (
  `comunicado_turmas_id` INT NOT NULL AUTO_INCREMENT,
  `comunicado_id` INT NOT NULL,
  `turma_id` INT NOT NULL,
  PRIMARY KEY (`comunicado_turmas_id`),
  CONSTRAINT `fkcomunicado_id`
    FOREIGN KEY (`comunicado_id`)
    REFERENCES `AgendaDigital`.`Comunicados` (`comunicado_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fkturma_id`
    FOREIGN KEY (`turma_id`)
    REFERENCES `AgendaDigital`.`Turmas` (`turma_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `AgendaDigital`.`Eventos_Turmas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `AgendaDigital`.`Eventos_Turmas` (
  `eventosEscola_id` INT NOT NULL AUTO_INCREMENT,
  `evento_id` INT NOT NULL,
  `turma_id` INT NOT NULL,
  PRIMARY KEY (`eventosEscola_id`),
  CONSTRAINT `evento_id`
    FOREIGN KEY (`evento_id`)
    REFERENCES `AgendaDigital`.`Eventos` (`evento_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk-turma_id`
    FOREIGN KEY (`turma_id`)
    REFERENCES `AgendaDigital`.`Turmas` (`turma_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `AgendaDigital`.`Atividades`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `AgendaDigital`.`Atividades` (
  `atividade_id` INT NOT NULL AUTO_INCREMENT,
  `titulo` VARCHAR(100) NOT NULL,
  `descricao` VARCHAR(300) NOT NULL,
  `material` VARCHAR(300) NOT NULL,
  `dataEntrega` DATETIME NOT NULL,
  `criadoEm` DATETIME NOT NULL DEFAULT NOW(),
  `turma_id` INT NOT NULL,
  `professor_id` INT NOT NULL,
  `lido` TINYINT NOT NULL,
  PRIMARY KEY (`atividade_id`),
  CONSTRAINT `fk-professor_id`
    FOREIGN KEY (`professor_id`)
    REFERENCES `AgendaDigital`.`Professor` (`professorId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk-turma_id-atv`
    FOREIGN KEY (`turma_id`)
    REFERENCES `AgendaDigital`.`Turmas` (`turma_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `AgendaDigital`.`Financeiro`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `AgendaDigital`.`Financeiro` (
  `idFinanceiro` INT NOT NULL AUTO_INCREMENT,
  `estudante_id` INT NOT NULL,
  `mes` INT NOT NULL,
  `pago` TINYINT NOT NULL,
  PRIMARY KEY (`idFinanceiro`),
  CONSTRAINT `fk-estudante_id-fin`
    FOREIGN KEY (`estudante_id`)
    REFERENCES `AgendaDigital`.`Estudante` (`estudante_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

 CREATE INDEX `estudante_id_idx` ON `AgendaDigital`.`Financeiro` (`estudante_id` ASC) ;


-- -----------------------------------------------------
-- Table `AgendaDigital`.`Mensagem`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `AgendaDigital`.`Mensagem` (
  `mensagem_id` INT NOT NULL AUTO_INCREMENT,
  `conteudo` VARCHAR(300) NOT NULL,
  `estudante_id` INT NOT NULL,
  `professor_id` INT NOT NULL,
  `perfilDisparo` INT NOT NULL,
  `dataEnvio` DATETIME NOT NULL,
  `lida` TINYINT NOT NULL,
  PRIMARY KEY (`mensagem_id`),
  CONSTRAINT `fk-professor_id-msg`
    FOREIGN KEY (`professor_id`)
    REFERENCES `AgendaDigital`.`Professor` (`professorId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk-estudante_id-msg`
    FOREIGN KEY (`estudante_id`)
    REFERENCES `AgendaDigital`.`Estudante` (`estudante_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

CREATE INDEX `estudante_id_idx` ON `AgendaDigital`.`Mensagem` (`estudante_id` ASC) ;

CREATE INDEX `professor_id_idx` ON `AgendaDigital`.`Mensagem` (`professor_id` ASC);


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;