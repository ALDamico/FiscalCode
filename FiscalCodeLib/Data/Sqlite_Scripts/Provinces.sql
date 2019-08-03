CREATE TABLE Italian_Provinces
(
    id                        INTEGER PRIMARY KEY AUTOINCREMENT,
    province_abbr             TEXT,
    province_name             TEXT,
    province_name_alternative TEXT,
    fk_id_italian_region      INTEGER REFERENCES Italian_Regions (id)
);

INSERT INTO Italian_Provinces(fk_id_italian_region, province_abbr, province_name)
VALUES (15, 'AG', 'Agrigento')
     , (12, 'AL', 'Alessandria')
     , (10, 'AN', 'Ancona')
     , (19, 'AO', 'Aosta')
     , (16, 'AR', 'Arezzo')
     , (10, 'AP', 'Ascoli Piceno')
     , (12, 'AT', 'Asti')
     , (4, 'AV', 'Avellino')
     , (13, 'BA', 'Bari')
     , (20, 'BL', 'Belluno')
     , (4, 'BN', 'Benevento')
     , (9, 'BG', 'Bergamo')
     , (12, 'BI', 'Biella')
     , (5, 'BO', 'Bologna')
     , (17, 'BZ', 'Bolzano')
     , (9, 'BS', 'Brescia')
     , (13, 'BR', 'Brindisi')
     , (14, 'CA', 'Cagliari')
     , (15, 'CL', 'Caltanissetta')
     , (11, 'CB', 'Campobasso')
     , (4, 'CE', 'Caserta')
     , (15, 'CT', 'Catania')
     , (3, 'CZ', 'Catanzaro')
     , (1, 'CH', 'Chieti')
     , (9, 'CO', 'Como')
     , (3, 'CS', 'Cosenza')
     , (9, 'CR', 'Cremona')
     , (3, 'KR', 'Crotone')
     , (12, 'CN', 'Cuneo')
     , (15, 'EN', 'Enna')
     , (5, 'FE', 'Ferrara')
     , (10, 'FM', 'Fermo')
     , (16, 'FI', 'Firenze')
     , (13, 'FG', 'Foggia')
     , (5, 'FO', 'Forlì-Cesena')
     , (7, 'FR', 'Frosinone')
     , (8, 'GE', 'Genova')
     , (6, 'GO', 'Gorizia')
     , (16, 'GR', 'Grosseto')
     , (8, 'IM', 'Imperia')
     , (11, 'IS', 'Isernia')
     , (8, 'SP', 'La Spezia')
     , (1, 'AQ', 'L''Aquila')
     , (7, 'LT', 'Latina')
     , (13, 'LE', 'Lecce')
     , (9, 'LC', 'Lecco')
     , (16, 'LI', 'Livorno')
     , (9, 'LO', 'Lodi')
     , (16, 'LU', 'Lucca')
     , (10, 'MC', 'Macerata')
     , (9, 'MN', 'Mantova')
     , (16, 'MS', 'Massa-Carrara')
     , (2, 'MT', 'Matera')
     , (15, 'ME', 'Messina')
     , (9, 'MI', 'Milano')
     , (5, 'MO', 'Modena')
     , (4, 'NA', 'Napoli')
     , (12, 'NO', 'Novara')
     , (14, 'NU', 'Nuoro')
     , (14, 'OR', 'Oristano')
     , (20, 'PD', 'Padova')
     , (15, 'PA', 'Palermo')
     , (5, 'PR', 'Parma')
     , (9, 'PV', 'Pavia')
     , (18, 'PG', 'Perugia')
     , (10, 'PS', 'Pesaro e Urbino')
     , (1, 'PE', 'Pescara')
     , (5, 'PC', 'Piacenza')
     , (16, 'PI', 'Pisa')
     , (16, 'PT', 'Pistoia')
     , (6, 'PN', 'Pordenone')
     , (2, 'PZ', 'Potenza')
     , (16, 'PO', 'Prato')
     , (15, 'RG', 'Ragusa')
     , (5, 'RA', 'Ravenna')
     , (3, 'RC', 'Reggio di Calabria')
     , (5, 'RE', 'Reggio nell''Emilia')
     , (7, 'RI', 'Rieti')
     , (5, 'RN', 'Rimini')
     , (7, 'RM', 'Roma')
     , (20, 'RO', 'Rovigo')
     , (4, 'SA', 'Salerno')
     , (14, 'SS', 'Sassari')
     , (8, 'SV', 'Savona')
     , (16, 'SI', 'Siena')
     , (15, 'SR', 'Siracusa')
     , (9, 'SO', 'Sondrio')
     , (14, 'SU', 'Sud Sardegna')
     , (13, 'TA', 'Taranto')
     , (1, 'TE', 'Teramo')
     , (18, 'TR', 'Terni')
     , (12, 'TO', 'Torino')
     , (15, 'TP', 'Trapani')
     , (17, 'TN', 'Trento')
     , (20, 'TV', 'Treviso')
     , (6, 'TS', 'Trieste')
     , (6, 'UD', 'Udine')
     , (9, 'VA', 'Varese')
     , (20, 'VE', 'Venezia')
     , (12, 'VB', 'Verbano-Cusio-Ossola')
     , (12, 'VC', 'Vercelli')
     , (20, 'VR', 'Verona')
     , (3, 'VV', 'Vibo Valentia')
     , (20, 'VI', 'Vicenza')
     , (7, 'VT', 'Viterbo')
     , (9, 'MB', 'Monza e della Brianza')
     , (13, 'BT', 'Barletta-Andria-Trani');

UPDATE Italian_Provinces
SET province_name_alternative = 'Bozen'
WHERE province_name = 'Bolzano';

UPDATE Italian_Provinces
SET province_name_alternative = 'Monza e Brianza'
WHERE province_name = 'Monza e della Brianza';

UPDATE Italian_Provinces
SET province_name_alternative = 'Verbania'
WHERE province_name = 'Verbano-Cusio-Ossola';

UPDATE Italian_Provinces
SET province_name_alternative = 'Reggio Emilia'
WHERE province_name = 'Reggio nell''Emilia';

UPDATE Italian_Provinces
SET province_name_alternative = 'Reggio Calabria'
WHERE province_name = 'Reggio di Calabria';

UPDATE Italian_Provinces
SET province_name_alternative = 'Barletta'
WHERE province_name = 'Barletta-Andria-Trani';

UPDATE Italian_Provinces
SET province_name_alternative = 'Aoste'
WHERE province_name = 'Aosta';