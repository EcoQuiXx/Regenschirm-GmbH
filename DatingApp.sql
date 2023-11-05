#############################
# DATENBANK DATING APP 2023 #
#############################

# IMPORTANT NOTE #
# Create an user called "datingappadmin" 
# with the password "123456789!?" 
# and assign it the DBManager permission on the permissions tab

# Löschung der Datenbank zur Aktualisierung. Hierfür das # bei Drop database entfernen #
#Drop database DatingApp;
# Erstellung und Zugriff auf die Datenbank #
Create database DatingApp;
Use DatingApp;

######################
# DATENBANK TABELLEN #
######################

Create table konten(
kd_id int primary key not null auto_increment, kd_username varchar(16), kd_password varchar(64), kd_email varchar(45), kd_question varchar(45));

Create table personendaten(
pd_id int primary key not null auto_increment, pd_vorname varchar(45), pd_nachname varchar(45), pd_geschlecht varchar(45), pd_geburtsdatum date, pd_ortschaft varchar(45), pd_postleitzahl varchar(16), pd_straße varchar(45), pd_hausnummer varchar(45), pd_lieblingstier varchar(45),pd_lieblingsfilm varchar(45),pd_raucher bool, pd_alkohol bool);

Create table hobbies(
hb_id int primary key not null auto_increment, hb_name varchar(45), hb_kategorie varchar(45));

Create table sprachen(
sp_id int primary key not null auto_increment, sp_name varchar(45));

# Zwischentabellen für die Beziehungen #
Create table personenhobbies(
phb_id int primary key not null auto_increment, hb_id int, pd_id int);

create table personensprachen(
psp_id int primary key not null auto_increment, sp_id int, pd_id int);

###############
# Beziehungen #
###############

# Personen & Hobbies #
ALTER TABLE `datingapp`.`personenhobbies` 
ADD INDEX `fk_ph_hb_idx` (`hb_id` ASC) VISIBLE,
ADD INDEX `fk_ph_pd_idx` (`pd_id` ASC) VISIBLE;
ALTER TABLE `datingapp`.`personenhobbies` 
ADD CONSTRAINT `fk_ph_hb`
  FOREIGN KEY (`hb_id`)
  REFERENCES `datingapp`.`hobbies` (`hb_id`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION,
ADD CONSTRAINT `fk_ph_pd`
  FOREIGN KEY (`pd_id`)
  REFERENCES `datingapp`.`personendaten` (`pd_id`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;
  
# Personen & Sprachen #
ALTER TABLE `datingapp`.`personensprachen` 
ADD INDEX `fk_psp_sp_idx` (`sp_id` ASC) VISIBLE,
ADD INDEX `fk_psp_pd_idx` (`pd_id` ASC) VISIBLE;
ALTER TABLE `datingapp`.`personensprachen` 
ADD CONSTRAINT `fk_psp_sp`
  FOREIGN KEY (`sp_id`)
  REFERENCES `datingapp`.`sprachen` (`sp_id`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION,
ADD CONSTRAINT `fk_psp_pd`
  FOREIGN KEY (`pd_id`)
  REFERENCES `datingapp`.`personendaten` (`pd_id`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;

####################
# Daten einpflegen #
####################

INSERT INTO `datingapp`.`konten` (`kd_id`, `kd_username`, `kd_password`, `kd_email`, `kd_question`) VALUES ('1', 'admin', '', 'admin@admin', '');
INSERT INTO `datingapp`.`konten` (`kd_id`, `kd_username`, `kd_password`, `kd_email`, `kd_question`) VALUES ('2', 'Letsdarkfighter', '123456789!', 'Letsdarkfighter@gmail.com', 'Paula');
INSERT INTO `datingapp`.`konten` (`kd_id`, `kd_username`, `kd_password`, `kd_email`, `kd_question`) VALUES ('3', 'Nocxei', '123456789!', 'kreutz.justin@list.ru', 'Lilly');
INSERT INTO `datingapp`.`konten` (`kd_id`, `kd_username`, `kd_password`, `kd_email`, `kd_question`) VALUES ('4', 'Ricardo', '123456789!', 'ricardo@gmail.com', 'Harald');

INSERT INTO `datingapp`.`personendaten` (`pd_id`, `pd_vorname`, `pd_nachname`, `pd_geschlecht`, `pd_geburtsdatum`, `pd_ortschaft`, `pd_postleitzahl`, `pd_straße`, `pd_hausnummer`, `pd_lieblingstier`, `pd_lieblingsfilm`, `pd_raucher`, `pd_alkohol`) VALUES ('1', 'Admin', 'istrator', 'root', '0101-01-01', 'localhost', 'localhost', 'localhost', 'localhost', 'bits', 'bits', '0', '0');
INSERT INTO `datingapp`.`personendaten` (`pd_id`, `pd_vorname`, `pd_nachname`, `pd_geschlecht`, `pd_geburtsdatum`, `pd_ortschaft`, `pd_postleitzahl`, `pd_straße`, `pd_hausnummer`, `pd_lieblingstier`, `pd_lieblingsfilm`, `pd_raucher`, `pd_alkohol`) VALUES ('2', 'Ben', 'Gornik', 'Männlich', '2004-03-10', 'Bergisch Gladbach', '51429', 'Klein Hohn', '28', 'Hund', 'Interstellar', '0', '0');
INSERT INTO `datingapp`.`personendaten` (`pd_id`, `pd_vorname`, `pd_nachname`, `pd_geschlecht`, `pd_geburtsdatum`, `pd_ortschaft`, `pd_postleitzahl`, `pd_straße`, `pd_hausnummer`, `pd_lieblingstier`, `pd_lieblingsfilm`, `pd_raucher`, `pd_alkohol`) VALUES ('3', 'Justin', 'Kreutz', 'Männlich', '2004-05-31', 'Bergisch Gladbach', '51467', 'Mutzerstraße', '84', 'Katze', 'Interstellar', '0', '1');
INSERT INTO `datingapp`.`personendaten` (`pd_id`, `pd_vorname`, `pd_nachname`, `pd_geschlecht`, `pd_geburtsdatum`, `pd_ortschaft`, `pd_postleitzahl`, `pd_straße`, `pd_hausnummer`, `pd_lieblingstier`, `pd_lieblingsfilm`, `pd_raucher`, `pd_alkohol`) VALUES ('4', 'Ricardo', 'Petro', 'Männlich', '2002-01-26', 'Bergisch Gladbach', '51465', 'Lohplatz', '18', 'Hund', 'Suzume', '0', '0');

INSERT INTO `datingapp`.`hobbies` (`hb_id`, `hb_name`, `hb_kategorie`) VALUES ('1', 'Fahrrad fahren', 'Sport');
INSERT INTO `datingapp`.`hobbies` (`hb_id`, `hb_name`, `hb_kategorie`) VALUES ('2', 'Gassi gehen', 'Freizeit');

INSERT INTO `datingapp`.`personenhobbies` (`phb_id`, `hb_id`, `pd_id`) VALUES ('1', '1', '1');
INSERT INTO `datingapp`.`personenhobbies` (`phb_id`, `hb_id`, `pd_id`) VALUES ('2', '2', '1');

####################
# LIST OF TRIGGERS #
####################

Create Trigger SignUp before insert on konten for each row insert into personendaten(pd_id) values(new.kd_id);

######################
# DATENBANK ABFRAGEN #
######################