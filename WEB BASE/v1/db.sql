-- phpMyAdmin SQL Dump
-- version 4.0.10.20
-- https://www.phpmyadmin.net
--
-- Inang: localhost
-- Waktu pembuatan: 28 Jun 2019 pada 16.11
-- Versi Server: 5.1.73
-- Versi PHP: 5.3.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Basis data: `erwinscadav2`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `erwinproject`
--

CREATE TABLE IF NOT EXISTS `erwinproject` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `token` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data untuk tabel `erwinproject`
--

INSERT INTO `erwinproject` (`id`, `username`, `password`, `email`, `token`) VALUES
(1, 'erwinproject', 'surabay@123', 'erwinproject.id@gmail.com', '07d95caa0305eef83b47ec1fb6ccf69a');

-- --------------------------------------------------------

--
-- Struktur dari tabel `record_beban`
--

CREATE TABLE IF NOT EXISTS `record_beban` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `token` varchar(100) NOT NULL,
  `tegangan` varchar(100) NOT NULL,
  `arus` varchar(100) NOT NULL,
  `daya` varchar(100) NOT NULL,
  `statusrelay` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Struktur dari tabel `record_panel`
--

CREATE TABLE IF NOT EXISTS `record_panel` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `token` varchar(100) NOT NULL,
  `date` varchar(100) NOT NULL,
  `tegangan` varchar(100) NOT NULL,
  `arus` varchar(100) NOT NULL,
  `daya` varchar(100) NOT NULL,
  `statusalat` varchar(100) NOT NULL,
  `statusrelay` varchar(100) NOT NULL,
  `persenaki` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Struktur dari tabel `setting_beban`
--

CREATE TABLE IF NOT EXISTS `setting_beban` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `token` varchar(100) DEFAULT NULL,
  `tegangan` varchar(100) NOT NULL,
  `arus` varchar(100) NOT NULL,
  `statusalat` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data untuk tabel `setting_beban`
--

INSERT INTO `setting_beban` (`id`, `token`, `tegangan`, `arus`, `statusalat`) VALUES
(1, '07d95caa0305eef83b47ec1fb6ccf69a', '240', '650', 'Off');

-- --------------------------------------------------------

--
-- Struktur dari tabel `setting_panel`
--

CREATE TABLE IF NOT EXISTS `setting_panel` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `token` varchar(100) NOT NULL,
  `tegangan` varchar(100) NOT NULL,
  `arus` varchar(100) NOT NULL,
  `control` varchar(100) NOT NULL,
  `settimea` varchar(100) NOT NULL,
  `settimeb` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data untuk tabel `setting_panel`
--

INSERT INTO `setting_panel` (`id`, `token`, `tegangan`, `arus`, `control`, `settimea`, `settimeb`) VALUES
(1, '07d95caa0305eef83b47ec1fb6ccf69a', '14.9', '2500', 'Auto', '10', '15');

-- --------------------------------------------------------

--
-- Struktur dari tabel `update_beban`
--

CREATE TABLE IF NOT EXISTS `update_beban` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `token` varchar(100) NOT NULL,
  `tegangan` varchar(100) NOT NULL,
  `arus` varchar(100) NOT NULL,
  `daya` varchar(100) NOT NULL,
  `statusrelay` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data untuk tabel `update_beban`
--

INSERT INTO `update_beban` (`id`, `date`, `token`, `tegangan`, `arus`, `daya`, `statusrelay`) VALUES
(1, '0000-00-00 00:00:00', '07d95caa0305eef83b47ec1fb6ccf69a', '0', '0', '0', 'Idle');

-- --------------------------------------------------------

--
-- Struktur dari tabel `update_panel`
--

CREATE TABLE IF NOT EXISTS `update_panel` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `token` varchar(100) DEFAULT NULL,
  `date` varchar(100) NOT NULL,
  `tegangan` varchar(100) NOT NULL,
  `arus` varchar(100) NOT NULL,
  `daya` varchar(100) NOT NULL,
  `statusalat` varchar(100) NOT NULL,
  `statusrelay` varchar(100) NOT NULL,
  `persenaki` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data untuk tabel `update_panel`
--

INSERT INTO `update_panel` (`id`, `token`, `date`, `tegangan`, `arus`, `daya`, `statusalat`, `statusrelay`, `persenaki`) VALUES
(1, '07d95caa0305eef83b47ec1fb6ccf69a', '28.06.2019-14:06:26', '13.05', '0.00', '0.00', 'Not Charging', 'Idle', '96.50');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
