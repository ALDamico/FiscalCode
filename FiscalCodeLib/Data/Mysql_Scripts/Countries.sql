CREATE TABLE Foreign_Countries
(
    id                   INTEGER
        PRIMARY KEY AUTO_INCREMENT,
    fk_continent_id      INTEGER
        REFERENCES Continents,
    foreign_country_name TEXT,
    code                 TEXT
);


INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (1, 1, 'Albania', 'Z100');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (2, 1, 'Andorra', 'Z101');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (3, 1, 'Austria', 'Z102');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (4, 1, 'Belgio', 'Z103');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (5, 1, 'Bulgaria', 'Z104');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (6, 1, 'Città del Vaticano', 'Z106');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (7, 1, 'Danimarca', 'Z107');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (8, 1, 'Isole Faer Oer', 'Z108');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (9, 1, 'Finlandia', 'Z109');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (10, 1, 'Francia', 'Z110');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (11, 1, 'Germania', 'Z112');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (12, 1, 'Gibilterra', 'Z113');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (13, 1, 'Regno Unito', 'Z114');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (14, 1, 'Grecia', 'Z115');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (15, 1, 'Irlanda', 'Z116');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (16, 1, 'Islanda', 'Z117');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (17, 1, 'Liechtenstein', 'Z119');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (18, 1, 'Lussemburgo', 'Z120');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (19, 1, 'Malta', 'Z121');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (20, 1, 'Isola di Man', 'Z122');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (21, 1, 'Monaco', 'Z123');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (22, 1, 'Normanne (Isole) o Isole del Canale', 'Z124');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (23, 1, 'Norvegia', 'Z125');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (24, 1, 'Paesi Bassi', 'Z126');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (25, 1, 'Polonia', 'Z127');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (26, 1, 'Portogallo', 'Z128');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (27, 1, 'Romania', 'Z129');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (28, 1, 'San Marino', 'Z130');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (29, 1, 'Spagna', 'Z131');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (30, 1, 'Svezia', 'Z132');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (31, 1, 'Svizzera', 'Z133');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (32, 1, 'Ungheria', 'Z134');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (33, 1, 'Ucraina', 'Z138');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (34, 1, 'Bielorussia', 'Z139');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (35, 1, 'Moldova', 'Z140');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (36, 1, 'Estonia', 'Z144');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (37, 1, 'Lettonia', 'Z145');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (38, 1, 'Lituania', 'Z146');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (39, 1, 'Macedonia', 'Z148');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (40, 1, 'Croazia', 'Z149');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (41, 1, 'Slovenia', 'Z150');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (42, 1, 'Bosnia-Erzegovina', 'Z153');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (43, 1, 'Federazione Russa', 'Z154');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (44, 1, 'Slovacchia', 'Z155');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (45, 1, 'Repubblica Ceca', 'Z156');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (46, 1, 'Serbia', 'Z158');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (47, 1, 'Montenegro', 'Z159');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (48, 1, 'Kosovo', 'Z160');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (49, 5, 'Territori dell''Autonomia Palestinese', 'Z161');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (50, 5, 'Afghanistan', 'Z200');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (51, 5, 'Arabia Saudita', 'Z203');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (52, 5, 'Bahrein', 'Z204');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (53, 5, 'Bhutan', 'Z205');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (54, 5, 'Myanmar', 'Z206');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (55, 5, 'Brunei', 'Z207');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (56, 5, 'Cambogia', 'Z208');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (57, 5, 'Sri Lanka', 'Z209');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (58, 5, 'Repubblica Popolare Cinese', 'Z210');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (59, 5, 'Cipro', 'Z211');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (60, 5, 'Cocos (Isole)', 'Z212');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (61, 5, 'Repubblica di Corea', 'Z213');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (62, 5, 'Repubblica Popolare Democratica di Corea', 'Z214');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (63, 5, 'Emirati Arabi Uniti', 'Z215');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (64, 5, 'Filippine', 'Z216');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (65, 5, 'Taiwan', 'Z217');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (66, 5, 'Gaza (Territorio di)', 'Z218');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (67, 5, 'Giappone', 'Z219');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (68, 5, 'Giordania', 'Z220');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (69, 5, 'India', 'Z222');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (70, 5, 'Indonesia', 'Z223');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (71, 5, 'Iran', 'Z224');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (72, 5, 'Iraq', 'Z225');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (73, 5, 'Israele', 'Z226');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (74, 5, 'Kuwait', 'Z227');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (75, 5, 'Laos', 'Z228');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (76, 5, 'Libano', 'Z229');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (77, 5, 'Macao', 'Z231');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (78, 5, 'Maldive', 'Z232');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (79, 5, 'Mongolia', 'Z233');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (80, 5, 'Nepal', 'Z234');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (81, 5, 'Oman', 'Z235');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (82, 5, 'Pakistan', 'Z236');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (83, 5, 'Qatar', 'Z237');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (84, 5, 'Siria', 'Z240');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (85, 5, 'Thailandia', 'Z241');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (86, 5, 'Timor Orientale', 'Z242');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (87, 5, 'Turchia', 'Z243');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (88, 5, 'Yemen', 'Z246');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (89, 5, 'Malaysia', 'Z247');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (90, 5, 'Singapore', 'Z248');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (91, 5, 'Bangladesh', 'Z249');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (92, 5, 'Vietnam', 'Z251');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (93, 5, 'Armenia', 'Z252');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (94, 5, 'Azerbaigian', 'Z253');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (95, 5, 'Georgia', 'Z254');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (96, 5, 'Kazakhstan', 'Z255');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (97, 5, 'Kirghizistan', 'Z256');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (98, 5, 'Tagikistan', 'Z257');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (99, 5, 'Turkmenistan', 'Z258');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (100, 5, 'Uzbekistan', 'Z259');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (101, 6, 'Namibia', 'Z300');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (102, 6, 'Algeria', 'Z301');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (103, 6, 'Angola', 'Z302');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (104, 6, 'Burundi', 'Z305');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (105, 6, 'Camerun', 'Z306');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (106, 6, 'Capo Verde', 'Z307');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (107, 6, 'Repubblica Centrafricana', 'Z308');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (108, 6, 'Ciad', 'Z309');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (109, 6, 'Comore', 'Z310');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (110, 6, 'Congo', 'Z311');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (111, 6, 'Repubblica Democratica Del Congo', 'Z312');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (112, 6, 'Costa D''Avorio', 'Z313');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (113, 6, 'Benin', 'Z314');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (114, 6, 'Etiopia', 'Z315');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (115, 6, 'Gabon', 'Z316');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (116, 6, 'Gambia', 'Z317');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (117, 6, 'Ghana', 'Z318');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (118, 6, 'Guinea', 'Z319');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (119, 6, 'Guinea Bissau', 'Z320');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (120, 6, 'Guinea Equatoriale', 'Z321');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (121, 6, 'Kenya', 'Z322');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (122, 6, 'La Reunion (Isola)', 'Z324');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (123, 6, 'Liberia', 'Z325');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (124, 6, 'Libia', 'Z326');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (125, 6, 'Madagascar', 'Z327');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (126, 6, 'Malawi', 'Z328');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (127, 6, 'Mali', 'Z329');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (128, 6, 'Marocco', 'Z330');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (129, 6, 'Mauritania', 'Z331');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (130, 6, 'Mauritius', 'Z332');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (131, 6, 'Mozambico', 'Z333');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (132, 6, 'Niger', 'Z334');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (133, 6, 'Nigeria', 'Z335');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (134, 6, 'Egitto', 'Z336');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (135, 6, 'Zimbabwe', 'Z337');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (136, 6, 'Ruanda', 'Z338');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (137, 6, 'Sant''Elena', 'Z340');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (138, 6, 'Sao Tome'' e Principe', 'Z341');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (139, 6, 'Seychelles', 'Z342');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (140, 6, 'Senegal', 'Z343');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (141, 6, 'Sierra Leone', 'Z344');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (142, 6, 'Somalia', 'Z345');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (143, 6, 'Sud Africa', 'Z347');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (144, 6, 'Sudan', 'Z348');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (145, 6, 'Swaziland', 'Z349');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (146, 6, 'Togo', 'Z351');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (147, 6, 'Tunisia', 'Z352');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (148, 6, 'Uganda', 'Z353');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (149, 6, 'Burkina Faso', 'Z354');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (150, 6, 'Zambia', 'Z355');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (151, 6, 'Tanzania', 'Z357');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (152, 6, 'Botswana', 'Z358');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (153, 6, 'Lesotho', 'Z359');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (154, 6, 'Mayotte', 'Z360');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (155, 6, 'Gibuti', 'Z361');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (156, 6, 'Eritrea', 'Z368');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (157, 2, 'Bermuda (Isole)', 'Z400');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (158, 2, 'Canada', 'Z401');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (159, 2, 'Groenlandia', 'Z402');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (160, 2, 'Saint Pierre e Miquelon', 'Z403');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (161, 2, 'Stati Uniti d''America', 'Z404');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (162, 3, 'Antille Olandesi', 'Z501');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (163, 3, 'Bahamas', 'Z502');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (164, 3, 'Costa Rica', 'Z503');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (165, 3, 'Cuba', 'Z504');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (166, 3, 'Repubblica Dominicana', 'Z505');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (167, 3, 'El Salvador', 'Z506');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (168, 3, 'Giamaica', 'Z507');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (169, 3, 'Guadalupa', 'Z508');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (170, 3, 'Guatemala', 'Z509');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (171, 3, 'Haiti', 'Z510');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (172, 3, 'Honduras', 'Z511');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (173, 3, 'Belize', 'Z512');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (174, 3, 'Martinica', 'Z513');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (175, 3, 'Messico', 'Z514');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (176, 3, 'Nicaragua', 'Z515');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (177, 3, 'Panama', 'Z516');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (178, 3, 'Panama Zona del Canale', 'Z517');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (179, 3, 'Puerto Rico', 'Z518');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (180, 3, 'Isole Turks E Caicos', 'Z519');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (181, 3, 'Vergini Americane (Isole)', 'Z520');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (182, 3, 'Barbados', 'Z522');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (183, 3, 'Grenada', 'Z524');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (184, 3, 'Isole Vergini Britanniche', 'Z525');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (185, 3, 'Dominica', 'Z526');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (186, 3, 'Saint Lucia', 'Z527');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (187, 3, 'Saint Vincent e Grenadine', 'Z528');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (188, 3, 'Anguilla (Isola)', 'Z529');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (189, 3, 'Isole Cayman', 'Z530');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (190, 3, 'Montserrat', 'Z531');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (191, 3, 'Antigua e Barbuda', 'Z532');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (192, 3, 'Saint Kitts e Nevis', 'Z533');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (193, 4, 'Argentina', 'Z600');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (194, 4, 'Bolivia', 'Z601');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (195, 4, 'Brasile', 'Z602');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (196, 4, 'Cile', 'Z603');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (197, 4, 'Colombia', 'Z604');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (198, 4, 'Ecuador', 'Z605');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (199, 4, 'Guyana', 'Z606');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (200, 4, 'Guyana Francese', 'Z607');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (201, 4, 'Suriname', 'Z608');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (202, 4, 'Malvine O Falkland (Isole)', 'Z609');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (203, 4, 'Paraguay', 'Z610');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (204, 4, 'Peru''', 'Z611');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (205, 4, 'Trinidad E Tobago', 'Z612');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (206, 4, 'Uruguay', 'Z613');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (207, 4, 'Venezuela', 'Z614');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (208, 7, 'Australia', 'Z700');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (209, 7, 'Christmas (Isola)', 'Z702');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (210, 7, 'Isole Cook', 'Z703');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (211, 7, 'Figi', 'Z704');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (212, 7, 'Guam (Isola)', 'Z706');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (213, 7, 'Irian Occidentale', 'Z707');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (214, 7, 'Macquarie (Isole)', 'Z708');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (215, 7, 'Marianne (Isole)', 'Z710');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (216, 7, 'Isole Marshall', 'Z711');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (217, 7, 'Midway (Isole)', 'Z712');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (218, 7, 'Nauru', 'Z713');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (219, 7, 'Niue o Savage (Isole)', 'Z714');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (220, 7, 'Norfolk (Isole e Isole del Mar dei Coralli)', 'Z715');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (221, 7, 'Nuova Caledonia (Isole e Dipendenze)', 'Z716');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (222, 7, 'Nuova Zelanda', 'Z719');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (223, 7, 'Isole Cilene (Pasqua E Sala Y Gomez)', 'Z721');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (224, 7, 'Pitcairn (e dipendenze)', 'Z722');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (225, 7, 'Polinesia Francese (Isole)', 'Z723');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (226, 7, 'Isole Salomone', 'Z724');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (227, 7, 'Samoa Americane (Isole)', 'Z725');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (228, 7, 'Samoa', 'Z726');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (229, 7, 'Tokelau O Isole Dell''Unione', 'Z727');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (230, 7, 'Tonga', 'Z728');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (231, 7, 'Isole Wallis E Futuna', 'Z729');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (232, 7, 'Papua Nuova Guinea', 'Z730');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (233, 7, 'Kiribati', 'Z731');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (234, 7, 'Tuvalu', 'Z732');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (235, 7, 'Vanuatu', 'Z733');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (236, 7, 'Palau', 'Z734');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (237, 7, 'Stati Federati Di Micronesia', 'Z735');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (238, 8, 'Dipendenze canadesi', 'Z800');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (239, 8, 'Dipendenze norvegesi artiche', 'Z801');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (240, 8, 'Dipendenze russe', 'Z802');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (241, 9, 'Dipendenze australiane', 'Z900');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (242, 9, 'Dipendenze britanniche', 'Z901');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (243, 9, 'Dipendenze francesi', 'Z902');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (244, 9, 'Dipendenze neozelandesi', 'Z903');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (245, 9, 'Dipendenze norvegesi Antartiche', 'Z904');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (246, 9, 'Dipendenze statunitensi', 'Z905');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (247, 9, 'Dipendenze sudafricane', 'Z906');
INSERT INTO Foreign_Countries (id, fk_continent_id, foreign_country_name, code)
VALUES (248, 6, 'Sud Sudan', 'Z907');