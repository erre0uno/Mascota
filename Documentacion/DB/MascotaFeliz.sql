/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     1/09/2022 5:52:51 p. m.                      */
/*==============================================================*/


alter table HISTORIA 
   drop foreign key FK_HISTORIA_ABRE_MASCOTA;

alter table MASCOTA 
   drop foreign key FK_MASCOTA_ASIGNA_MEDICO;

alter table MASCOTA 
   drop foreign key FK_MASCOTA_TIENE_DUENO;

alter table VISITA 
   drop foreign key FK_VISITA_COMPONE_HISTORIA;

alter table VISITA 
   drop foreign key FK_VISITA_REALIZA_MEDICO;

drop table if exists DUENO;


alter table HISTORIA 
   drop foreign key FK_HISTORIA_ABRE_MASCOTA;

drop table if exists HISTORIA;


alter table MASCOTA 
   drop foreign key FK_MASCOTA_TIENE_DUENO;

alter table MASCOTA 
   drop foreign key FK_MASCOTA_ASIGNA_MEDICO;

drop table if exists MASCOTA;

drop table if exists MEDICO;


alter table VISITA 
   drop foreign key FK_VISITA_COMPONE_HISTORIA;

alter table VISITA 
   drop foreign key FK_VISITA_REALIZA_MEDICO;

drop table if exists VISITA;

/*==============================================================*/
/* Table: DUENO                                                 */
/*==============================================================*/
create table DUENO
(
   IDDUENO              int not null  comment '',
   NOMBREDUENO          varchar(50) not null  comment '',
   APELLIDODUENO        varchar(50) not null  comment '',
   DIRECCIONDUENO       varchar(80) not null  comment '',
   CORREO               varchar(65) not null  comment '',
   primary key (IDDUENO)
);

/*==============================================================*/
/* Table: HISTORIA                                              */
/*==============================================================*/
create table HISTORIA
(
   IDHISTORIA           int not null  comment '',
   IDMASCOTA            int not null  comment '',
   FECHA                date not null  comment '',
   DIAGNOSTICO          varchar(60)  comment '',
   MEDICAMENTOS         varchar(200)  comment '',
   primary key (IDHISTORIA)
);

/*==============================================================*/
/* Table: MASCOTA                                               */
/*==============================================================*/
create table MASCOTA
(
   IDMASCOTA            int not null  comment '',
   IDDUENO              int not null  comment '',
   IDMEDICO             int not null  comment '',
   NOMBRE               varchar(50) not null  comment '',
   COLOR                varchar(50) not null  comment '',
   ESPACIE              varchar(50) not null  comment '',
   RAZA                 varchar(50)  comment '',
   primary key (IDMASCOTA)
);

/*==============================================================*/
/* Table: MEDICO                                                */
/*==============================================================*/
create table MEDICO
(
   IDMEDICO             int not null  comment '',
   NOMBREMEDICO         varchar(50) not null  comment '',
   APELLIDOMEDICO       varchar(50) not null  comment '',
   DIRECCIONMEDICO      varchar(80) not null  comment '',
   TARJETA              varchar(10) not null  comment '',
   primary key (IDMEDICO)
);

/*==============================================================*/
/* Table: VISITA                                                */
/*==============================================================*/
create table VISITA
(
   IDVISITA             int not null  comment '',
   IDHISTORIA           int not null  comment '',
   IDMEDICO             int not null  comment '',
   FECHA                date not null  comment '',
   TEMPERATURA          real not null  comment '',
   PESO                 real not null  comment '',
   FRECUENCIACARDIACA   int not null  comment '',
   FRECUENCIARESPIRATORIA int not null  comment '',
   ESTADOANIMO          varchar(50) not null  comment '',
   RECOMENDACION        varchar(100)  comment '',
   primary key (IDVISITA)
);

alter table HISTORIA add constraint FK_HISTORIA_ABRE_MASCOTA foreign key (IDMASCOTA)
      references MASCOTA (IDMASCOTA) on delete restrict on update restrict;

alter table MASCOTA add constraint FK_MASCOTA_ASIGNA_MEDICO foreign key (IDMEDICO)
      references MEDICO (IDMEDICO) on delete restrict on update restrict;

alter table MASCOTA add constraint FK_MASCOTA_TIENE_DUENO foreign key (IDDUENO)
      references DUENO (IDDUENO) on delete restrict on update restrict;

alter table VISITA add constraint FK_VISITA_COMPONE_HISTORIA foreign key (IDHISTORIA)
      references HISTORIA (IDHISTORIA) on delete restrict on update restrict;

alter table VISITA add constraint FK_VISITA_REALIZA_MEDICO foreign key (IDMEDICO)
      references MEDICO (IDMEDICO) on delete restrict on update restrict;

