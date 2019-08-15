CREATE TABLE Italian_Regions
(
    id                      INTEGER PRIMARY KEY AUTO_INCREMENT,
    region_name             TEXT,
    region_name_alternative TEXT
);

INSERT INTO Italian_Regions(region_name, region_name_alternative)
VALUES ('Abruzzo', NULL)
     , ('Basilicata', NULL)
     , ('Calabria', NULL)
     , ('Campania', NULL)
     , ('Emilia-Romagna', NULL)
     , ('Friuli-Venezia Giulia', NULL)
     , ('Lazio', NULL)
     , ('Liguria', NULL)
     , ('Lombardia', NULL)
     , ('Marche', NULL)
     , ('Molise', NULL)
     , ('Piemonte', NULL)
     , ('Puglia', NULL)
     , ('Sardegna', NULL)
     , ('Sicilia', NULL)
     , ('Toscana', NULL)
     , ('Trentino-Alto Adige', 'Südtirol')
     , ('Umbria', NULL)
     , ('Valle d''Aosta', 'Vallée d''Aoste')
     , ('Veneto', NULL); 