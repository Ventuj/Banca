SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";

DROP TABLE IF EXISTS `Transazioni`;
CREATE TABLE `Transazioni` (
  `id` int(11) NOT NULL,
  `ID_Conto` text NOT NULL,
  `ID_Transazione` text NOT NULL,
  `Ammontare` text NOT NULL,
  `Causale` text NOT NULL,
  `Giorno` text NOT NULL,
  `Mese` text NOT NULL,
  `Anno` text NOT NULL,
  `Ora` text NOT NULL,
  `Type` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

ALTER TABLE `Transazioni`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `Transazioni`
  MODIFY `id` int(1) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1;COMMIT;

DROP TABLE IF EXISTS `Conti`;
CREATE TABLE `Conti` (
  `id` int(11) NOT NULL,
  `ID_Conto` text NOT NULL,
  `ID_Utente` text NOT NULL,
  `IBAN` text NOT NULL,
  `Nome_Conto` text NOT NULL, 
  `Tipologia` text NOT NULL,
  `Saldo` text NOT NULL,
  `Spese` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


ALTER TABLE `Conti`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `Conti`
  MODIFY `id` int(1) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1;COMMIT;

DROP TABLE IF EXISTS `Utenti`;
CREATE TABLE `Utenti` (
  `id` int(11) NOT NULL,
  `ID_Utente` text NOT NULL,
  `Nome` text NOT NULL,
  `Cognome` text NOT NULL,
  `Password` text NOT NULL,
  `NData` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

ALTER TABLE `Utenti`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `Utenti`
  MODIFY `id` int(1) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1;COMMIT;