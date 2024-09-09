ALTER TABLE `AgendaDigital`.`Atividades` 
RENAME TO  `AgendaDigital`.`Atividade` ;

ALTER TABLE `AgendaDigital`.`Turmas` 
RENAME TO  `AgendaDigital`.`Turma` ;

INSERT INTO `Escola` VALUES (1,'Escola ABC','1234-5678','Rua das Flores, 123','2024-09-01 16:49:27',NULL),(2,'Colégio XYZ','2345-6789','Avenida Central, 456','2024-09-01 16:49:27',NULL),(3,'Instituto Educar','3456-7890','Rua do Saber, 789','2024-09-01 16:49:27',NULL),(4,'Escola Nova Era','4567-8901','Rua da Paz, 101','2024-09-01 16:49:27',NULL);
INSERT INTO `Permissao` VALUES (1,'Admin'),(2,'Diretoria'),(3,'Professor'),(4,'Responsavel');
INSERT INTO `Usuario` VALUES (10,'Maria Rosa','mariarosa@example.com','123456',3,1,'0001-01-01 00:00:00',NULL),(11,'Simone Souza','simone.s@gmail.com','87654321',4,1,'2024-09-03 02:34:33',NULL);
INSERT INTO `Professor` VALUES (3,10,'Maria Rosa','0001-01-01 00:00:00',NULL);
INSERT INTO `AgendaDiaria` VALUES (1,1,'2024-09-03 01:33:56','1','1','1','Musicalização e Artes','0001-01-01 00:00:00',NULL,0),(2,1,'2024-09-01 01:47:07','1','2','1','Numerais','0001-01-01 00:00:00',NULL,0);
ALTER TABLE `Turma`
ADD COLUMN `criadoEm` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
ADD COLUMN `alteradoEm` DATETIME DEFAULT NULL;
INSERT INTO `Turma` VALUES (1,5,1,3,1,0,'0001-01-01 00:00:00',NULL);
ALTER TABLE `AgendaDigital`.`Responsaveis` 
RENAME TO  `AgendaDigital`.`Responsavel` ;
INSERT INTO `Responsavel` VALUES (2,'Simone Souza','987635849','2024-09-03 02:48:49',NULL,11);
INSERT INTO `Estudante` VALUES (1,'Patricia Gomes',1,78956,'0001-01-01 00:00:00',NULL);
INSERT INTO `Estudante_Responsavel` VALUES (1,2);

ALTER TABLE `Comunicados`
ADD COLUMN `alteradoEm` DATETIME DEFAULT NULL;

ALTER TABLE `AgendaDigital`.`Comunicados` 
CHANGE COLUMN `descricao` `descricao` VARCHAR(1024) NOT NULL ;

INSERT INTO `AgendaDigital`.`Comunicados`
(`comunicado_id`,
`descricao`,
`titulo`,
`criadoEm`,
`professor_id`,
`assinaturaCriador`,
`observacao`,
`lido`,
`alteradoEm`)
VALUES
(2,
'Aos responsáveis e alunos, a partir do dia 01/08/2024, o uso do uniforme escolar será obrigatório para todos os estudantes.O uniforme é essencial para a identidade e segurança escolar, promovendo igualdade e disciplina. Pedimos a colaboração de todos para que os alunos estejam devidamente uniformizados a partir dessa data. O não cumprimento poderá resultar em medidas administrativas.',
'Uniforme Escolar',
'0001-01-01',
3,
'Agradecemos a compreensão e a colaboração de todos. Atenciosamente, Escola Florescer','Venda e Informações: Rose (11) 3567-9865',
0,
'0001-01-01 00:00:00');

ALTER TABLE `AgendaDigital`.`comunicado_turmas` 
RENAME TO  `AgendaDigital`.`Comunicado_turmas` ;
INSERT INTO `Comunicado_turmas` VALUES (5,2,1),(8,2,1);

INSERT INTO `AgendaDigital`.`Atividade`
(`atividade_id`,
`titulo`,
`descricao`,
`material`,
`dataEntrega`,
`criadoEm`,
`turma_id`,
`professor_id`,
`lido`)
VALUES
(1,
'Construir Brinquedo',
'Construir um brinquedo com Materiais reciclavéis',
'Caixas de papelão, garrafas pet, cola, tesoura, lapis de colorir',
'2024-09-28 00:00:00',
'2024-09-03 02:28:15',
1,
3,
0);

ALTER TABLE `Eventos`
ADD COLUMN `alteradoEm` DATETIME DEFAULT NULL;

ALTER TABLE `AgendaDigital`.`Eventos` 
CHANGE COLUMN `descricao` `descricao` VARCHAR(1000) NOT NULL ;

ALTER TABLE `Eventos` MODIFY `hora` TIME;

INSERT INTO `Eventos` VALUES 
(1,
'Reunião de Pais',
'Prezados responsáveis,Convidamos todos para a reunião de pais.Esta é uma oportunidade importante para discutirmos o desenvolvimento dos alunos, compartilhar informações sobre o calendário escolar e esclarecer dúvidas.Sua presença é fundamental para acompanharmos juntos o progresso de nossos estudantes e fortalecermos a parceria entre escola e família.',
'2024-09-09 00:00:00',
'10:00',
'Rua doze, 1024',
'2024-09-03 02:42:40',
1,
0,
NULL);

INSERT INTO `Eventos_Turmas` VALUES (1,1,1);

