-- auto-generated definition
CREATE TABLE Validation_Messages
(
    id           INTEGER PRIMARY KEY AUTO_INCREMENT,
    message_name TEXT,
    message      TEXT,
    language     NVARCHAR(5),
    result       BOOLEAN
);

INSERT INTO Validation_Messages (id, message_name, message, language, result)
VALUES (1, 'msg_length_temporary',
        'A valid fiscal code is 16 characters in length. However, temporary fiscal codes are numeric and 11 characters long. This version of the library doesn''t support validating temporary fiscal codes, so this validation result is inconclusive',
        'en-US', null);
INSERT INTO Validation_Messages (id, message_name, message, language, result)
VALUES (2, 'msg_length_temporary',
        'I codici fiscali validi hanno una lunghezza di 16 caratteri. Tuttavia, i codici fiscali temporanei sono codici numerici di 11 caratteri. Questa versione della libreria non supporta la convalida dei codici fiscali temporanei, dunque il risultato della convalida è inconcludente.',
        'it-IT', null);
INSERT INTO Validation_Messages (id, message_name, message, language, result)
VALUES (3, 'msg_length_wrong',
        'A valid fiscal code is 16 characters in length. However, the one provided is {0} characters.', 'en-US', FALSE);
INSERT INTO Validation_Messages (id, message_name, message, language, result)
VALUES (4, 'msg_length_wrong',
        'I codici fiscali validi hanno una lunghezza di 16 caratteri. Quello fornito ha una lunghezza di {0} caratteri.',
        'it-IT', FALSE);
INSERT INTO Validation_Messages (id, message_name, message, language, result)
VALUES (5, 'msg_length_ok', 'Valid fiscal codes are 16 characters in length.', 'en-US', TRUE);
INSERT INTO Validation_Messages (id, message_name, message, language, result)
VALUES (6, 'msg_length_ok', 'I codici fiscali validi hanno una lunghezza di 16 caratteri.', 'it-IT', TRUE);
INSERT INTO Validation_Messages (id, message_name, message, language, result)
VALUES (7, 'msg_surname_triplet_ok',
        'The surname triplet in the provided fiscal code matches the surname for the person you''re trying to validate.',
        'en-US', TRUE);
INSERT INTO Validation_Messages (id, message_name, message, language, result)
VALUES (8, 'msg_surname_triplet_ok',
        'La rappresentazione del cognome del codice fiscale corrisponde a quella della persona da convalidare.',
        'it-IT', TRUE);
INSERT INTO Validation_Messages (id, message_name, message, language, result)
VALUES (9, 'msg_surname_triplet_wrong', 'The surname triplet in the provided fiscal code doesn''t match the personal information you''ve provided.
Reason: The surname triplet is composed of the first, second and third consonant. If the surname does not contain enough consonants, vowels are appended to it in the order they appear. If the resulting string is still two characters in length, an X is appended.
Expected: {0}
Actual: {1}', 'en-US', FALSE);
INSERT INTO Validation_Messages (id, message_name, message, language, result)
VALUES (10, 'msg_surname_triplet_wrong', 'La rappresentazione del cognome nel codice fiscale fornito non corrisponde alle informazioni personali fornite.
Motivo: Il cognome nel codice fiscale si rappresenta con la prima, la seconda e la terza consonante. Se nel cognome non sono presenti abbastanza consonanti, si prendono le vocali nell''ordine in cui appaiono. Se la stringa così formata è di due caratteri, si aggiunge la lettera X in coda.
Previsto: {0}
Effettivo: {1}', 'it-IT', FALSE);
INSERT INTO Validation_Messages (id, message_name, message, language, result)
VALUES (11, 'msg_name_triplet_wrong', 'The name triplet in the provided fiscal code doesn''t match the personal information you''ve provided.
Reason: The name triplet is composed of the first, second and third consonant. If the surname does not contain enough consonants, vowels are appended to it in the order they appear. If the resulting string is still two characters in length, an X is appended.
Expected: {0}
Actual: {1}', 'en-US', FALSE);
INSERT INTO Validation_Messages (id, message_name, message, language, result)
VALUES (12, 'msg_name_triplet_wrong', 'La rappresentazione del nome nel codice fiscale fornito non corrisponde alle informazioni personali fornite.
Motivo: Il nome nel codice fiscale si rappresenta con la prima, la seconda e la terza consonante. Se nel cognome non sono presenti abbastanza consonanti, si prendono le vocali nell''ordine in cui appaiono. Se la stringa così formata è di due caratteri, si aggiunge la lettera X in coda.
Previsto: {0}
Effettivo: {1}', 'it-IT', FALSE);
INSERT INTO Validation_Messages (id, message_name, message, language, result)
VALUES (13, 'msg_name_triplet_ok',
        'The name triplet in the provided fiscal code matches the one for the person you''re trying to validate.',
        'en-US', TRUE);
INSERT INTO Validation_Messages (id, message_name, message, language, result)
VALUES (14, 'msg_name_triplet_ok',
        'La rappresentazione del nome nel codice fiscale che si vuole convalidare corrisponde ai dati personali.',
        'it-IT', TRUE);
INSERT INTO Validation_Messages (id, message_name, message, language, result)
VALUES (15, 'msg_year_main_ok',
        'The year of birth representation in the fiscal code you''re trying to validate matches the one of the main fiscal code.',
        'en-US', TRUE);
INSERT INTO Validation_Messages (id, message_name, message, language, result)
VALUES (16, 'msg_year_main_ok',
        'La rappresentazione dell''anno di nascita del codice fiscale che si vuole convalidare coincide con quella del codice fiscale principale.',
        'it-IT', TRUE);
INSERT INTO Validation_Messages (id, message_name, message, language, result)
VALUES (17, 'msg_year_omocode_ok',
        'The year of birth representation in the fiscal code you''re trying to validate matches one of its omocodes.',
        'en-US', TRUE);
INSERT INTO Validation_Messages (id, message_name, message, language, result)
VALUES (18, 'msg_year_omocode_ok',
        'La rappresentazione dell''anno di nascita del codice fiscale che si vuole convalidare coincide con quella di un codice omocodico.',
        'it-IT', TRUE);
INSERT INTO Validation_Messages (id, message_name, message, language, result)
VALUES (19, 'msg_year_wrong', 'The year of birth representation for the fiscal code you''re trying to validate does not match neither the main fiscal code, nor any of its omocodes.
Expected: {0}
Actual: {1}', 'en-US', FALSE);
INSERT INTO Validation_Messages (id, message_name, message, language, result)
VALUES (20, 'msg_year_wrong', 'La rappresentazione dell''anno di nascita del codice fiscale che si vuole convalidare non coincide né con quella del codice fiscale principale, né con quella degli omocodi.
Expected: {0}
Actual: {1}', 'it-IT', FALSE);
INSERT INTO Validation_Messages (id, message_name, message, language, result)
VALUES (21, 'msg_month_wrong', 'The month representation for the fiscal code you''re trying to validate doesn''t match the personal info.
Expected: {0}
Actual: {1}', 'en-US', FALSE);
INSERT INTO Validation_Messages (id, message_name, message, language, result)
VALUES (22, 'msg_month_wrong', 'La rappresentazione del mese nel codice fiscale che si vuole convalidare non coincide con le informazioni personali.
Previsto: {0}
Effettivo: {1}', 'it-IT', FALSE);
INSERT INTO Validation_Messages (id, message_name, message, language, result)
VALUES (23, 'msg_month_ok',
        'The month representation for the fiscal code you''re trying to validate matches the personal info.', 'en-US',
        TRUE);
INSERT INTO Validation_Messages (id, message_name, message, language, result)
VALUES (24, 'msg_month_ok',
        'La rappresentazione del mese del codice fiscale che si vuole convalidare coincide con le informazioni personali fornite.',
        'it-IT', TRUE);
INSERT INTO Validation_Messages (id, message_name, message, language, result)
VALUES (25, 'msg_day_gender_wrong', 'The day of birth and gender representation for the fiscal code you''re trying to validate does not match the provided personal info.
Expected: {0}
Actual: {1}', 'en-US', FALSE);
INSERT INTO Validation_Messages (id, message_name, message, language, result)
VALUES (26, 'msg_day_gender_wrong', 'La rappresentazione del giorno di nascita e del sesso del codice fiscale che si intende convalidare non coincide con le informazioni personali fornite.
Previsto: {0}
Effettivo: {1}', 'it-IT', FALSE);
INSERT INTO Validation_Messages (id, message_name, message, language, result)
VALUES (27, 'msg_day_gender_main_ok',
        'The day of birth and gender representation for the fiscal code you''re trying to validate matches the main fiscal code based on the provided personal info.',
        'en-US', TRUE);
INSERT INTO Validation_Messages (id, message_name, message, language, result)
VALUES (28, 'msg_day_gender_main_ok',
        'La rappresentazione del giorno di nascita e del sesso del codice fiscale che si intende convalidare coincide con quella del codice fiscale principale.',
        'it-IT', TRUE);
INSERT INTO Validation_Messages (id, message_name, message, language, result)
VALUES (29, 'msg_day_gender_omocode_ok',
        'The day of birth and gender representation for the fiscal code you''re trying to validate matches one of the omocodes',
        'en-US', TRUE);
INSERT INTO Validation_Messages (id, message_name, message, language, result)
VALUES (30, 'msg_day_gender_omocode_ok',
        'La rappresentazione del giorno di nascita e del sesso del codice fiscale che si intende convalidare coincide con quella di uno degli omocodi',
        'it-IT', TRUE);
INSERT INTO Validation_Messages (id, message_name, message, language, result)
VALUES (31, 'msg_place_code_wrong', 'The place of birth representation in the fiscal code you''re trying to validate doesn''t match nor the main fiscal code, neither any of its omocodes.
Expected: {0}
Actual: {1}', 'en-US', FALSE);
INSERT INTO Validation_Messages (id, message_name, message, language, result)
VALUES (32, 'msg_place_code_wrong', 'La rappresentazione del luogo di nascita del codice fiscale che si vuole convalidare non coincide né con il codice fiscale principale, né con i suoi omocodi.
Previsto: {0}
Effettivo: {1}', 'it-IT', FALSE);
INSERT INTO Validation_Messages (id, message_name, message, language, result)
VALUES (33, 'msg_place_code_main_ok',
        'The place of birth representation for the fiscal code you''re trying to validate matches the one for the main fiscal code.',
        'en-US', TRUE);
INSERT INTO Validation_Messages (id, message_name, message, language, result)
VALUES (34, 'msg_place_code_main_ok',
        'La rappresentazione del luogo di nascita del codice fiscale che si vuole convalidare coincide con quella del codice fiscale principale.',
        'it-IT', TRUE);
INSERT INTO Validation_Messages (id, message_name, message, language, result)
VALUES (35, 'msg_place_code_omocode_ok',
        'The place of birth representation for the fiscal code you''re trying to validate matches one of its omocodes',
        'en-US', TRUE);
INSERT INTO Validation_Messages (id, message_name, message, language, result)
VALUES (36, 'msg_place_code_omocode_ok',
        'La rappresentazione del luogo di nascita del codice fiscale che si vuole convalidare coincide con quella di uno dei suoi omocodi.',
        'it-IT', TRUE);
INSERT INTO Validation_Messages (id, message_name, message, language, result)
VALUES (37, 'msg_checkdigit_wrong', 'The check digit in the fiscal code you''re trying to validate isn''t valid.
Expected: {0}
Actual: {1}', 'en-US', FALSE);
INSERT INTO Validation_Messages (id, message_name, message, language, result)
VALUES (38, 'msg_checkdigit_wrong', 'La check digit del codice fiscale che si sta tentando di convalidare non è valido.
Prevista: {0}
Effettiva: {1}', 'it-IT', FALSE);
INSERT INTO Validation_Messages (id, message_name, message, language, result)
VALUES (39, 'msg_checkdigit_ok', 'The check digit in the fiscal code you''re trying to validate is valid.', 'en-US',
        TRUE);
INSERT INTO Validation_Messages (id, message_name, message, language, result)
VALUES (40, 'msg_checkdigit_ok', 'La check digit del codice fiscale che si sta tentando di convalidare è valido.',
        'it-IT', TRUE);



create index idx_messages
    on Validation_Messages (message_name(50));

create index idx_messages_languages
    on Validation_Messages (language);
