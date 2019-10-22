SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";

DROP TABLE IF EXISTS `Entrate`;
CREATE TABLE `Entrate` (
  `id` int(11) NOT NULL,
  `ID_Conto` text NOT NULL,
  `ID_Transazione` text NOT NULL,
  `Ammontare` float NOT NULL,
  `Causale` text NOT NULL,
  `Giorno` text NOT NULL,
  `Mese` text NOT NULL,
  `Anno` text NOT NULL,
  `Ora` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

DROP TABLE IF EXISTS `Uscite`;
CREATE TABLE `Uscite` (
  `id` int(11) NOT NULL,
  `ID_Conto` text NOT NULL,
  `ID_Transazione` text NOT NULL,
  `Ammontare` float NOT NULL,
  `Causale` text NOT NULL,
  `Giorno` text NOT NULL,
  `Mese` text NOT NULL,
  `Anno` text NOT NULL,
  `Ora` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

DROP TABLE IF EXISTS `Conti`;
CREATE TABLE `Conti` (
  `id` int(11) NOT NULL,
  `ID_Conto` text NOT NULL,
  `ID_Utente` text NOT NULL,
  `IBAN` text NOT NULL,
  `Tipologia` int NOT NULL,
  `Saldo` float NOT NULL,
  `Spese` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

DROP TABLE IF EXISTS `Utenti`;
CREATE TABLE `Utenti` (
  `id` int(11) NOT NULL,
  `ID_Utente` text NOT NULL,
  `Nome` text NOT NULL,
  `Cognome` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

ALTER TABLE `Entrate`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `Uscite`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `Conti`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `Utenti`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `Entrate`
  MODIFY `id` int(1) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1;COMMIT;

ALTER TABLE `Uscite`
  MODIFY `id` int(1) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1;COMMIT;

ALTER TABLE `Conti`
  MODIFY `id` int(1) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1;COMMIT;

ALTER TABLE `Utenti`
  MODIFY `id` int(1) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1;COMMIT;