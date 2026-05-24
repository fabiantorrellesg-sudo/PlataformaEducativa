-- =============================================
-- Base de datos: peducativa
-- Plataforma Educativa
-- =============================================

CREATE DATABASE IF NOT EXISTS peducativa CHARACTER SET utf8mb4 COLLATE utf8mb4_spanish_ci;
USE peducativa;

-- Tabla de usuarios (admin y jugadores)
CREATE TABLE IF NOT EXISTS usuario (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL UNIQUE,
    clave VARCHAR(100) NOT NULL,
    rol INT NOT NULL COMMENT '0 = admin, 1 = jugador'
);

CREATE TABLE IF NOT EXISTS modulos (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre_es VARCHAR(100) NOT NULL,
    name_en VARCHAR(100) NOT NULL
);

CREATE TABLE IF NOT EXISTS preguntas (
    id INT AUTO_INCREMENT PRIMARY KEY,
    id_modulo INT NOT NULL,
    pregunta_es TEXT NOT NULL,
    pregunta_en TEXT NOT NULL,
    opcion_a_es VARCHAR(255) NOT NULL,
    opcion_a_en VARCHAR(255) NOT NULL,
    opcion_b_es VARCHAR(255) NOT NULL,
    opcion_b_en VARCHAR(255) NOT NULL,
    opcion_c_es VARCHAR(255) NOT NULL,
    opcion_c_en VARCHAR(255) NOT NULL,
    opcion_d_es VARCHAR(255) NOT NULL,
    opcion_d_en VARCHAR(255) NOT NULL,
    letra_correcta CHAR(1) NOT NULL,
    FOREIGN KEY (id_modulo) REFERENCES modulos(id)
);

CREATE TABLE IF NOT EXISTS historial (
    id INT AUTO_INCREMENT PRIMARY KEY,
    id_usuario INT NOT NULL,
    id_modulo INT NOT NULL,
    puntuacion INT NOT NULL,
    fecha DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (id_usuario) REFERENCES usuario(id),
    FOREIGN KEY (id_modulo) REFERENCES modulos(id)
);

-- =============================================
-- Datos de prueba - Usuarios
-- =============================================

INSERT INTO usuario (nombre, clave, rol) VALUES
('admin', 'admin123', 0),
('jugador1', 'jugador123', 1),
('jugador2', 'jugador456', 1);

INSERT INTO modulos (nombre_es, name_en) VALUES
('Arquitectura y estructura del computador', 'Computer Architecture and Structure'),
('Cálculo', 'Calculus'),
('Antropología filosófica', 'Philosophical Anthropology'),
('Deporte', 'Sports');

INSERT INTO preguntas (id_modulo, pregunta_es, pregunta_en, opcion_a_es, opcion_a_en, opcion_b_es, opcion_b_en, opcion_c_es, opcion_c_en, opcion_d_es, opcion_d_en, letra_correcta) VALUES
(3, '¿Qué estudia la Antropología filosófica?', 'What does Philosophical Anthropology study?', 'Los animales', 'Animals', 'El ser humano como totalidad', 'The human being as a whole', 'Las plantas', 'Plants', 'El universo', 'The universe', 'B'),
(3, '¿Quién planteó que el hombre es un ser racional?', 'Who stated that man is a rational being?', 'Darwin', 'Darwin', 'Aristóteles', 'Aristotle', 'Newton', 'Newton', 'Freud', 'Freud', 'B'),
(3, '¿Qué distingue al ser humano de los animales según la filosofía?', 'What distinguishes humans from animals according to philosophy?', 'La fuerza', 'Strength', 'La velocidad', 'Speed', 'La razón y el lenguaje', 'Reason and language', 'El tamaño', 'Size', 'C'),
(3, '¿Qué es la conciencia según la antropología filosófica?', 'What is consciousness according to philosophical anthropology?', 'Un órgano del cuerpo', 'A body organ', 'La capacidad de conocerse a sí mismo', 'The ability to know oneself', 'Un tipo de emoción', 'A type of emotion', 'Una enfermedad', 'A disease', 'B'),
(3, '¿Cuál filósofo escribió sobre la condición humana?', 'Which philosopher wrote about the human condition?', 'Hannah Arendt', 'Hannah Arendt', 'Albert Einstein', 'Albert Einstein', 'Isaac Newton', 'Isaac Newton', 'Charles Darwin', 'Charles Darwin', 'A'),

(1, '¿Cuál es la unidad básica de información en un computador?', 'What is the basic unit of information in a computer?', 'Byte', 'Byte', 'Bit', 'Bit', 'Nibble', 'Nibble', 'Pixel', 'Pixel', 'B'),
(1, '¿Qué significa CPU?', 'What does CPU stand for?', 'Unidad Central de Procesamiento', 'Central Processing Unit', 'Control de Pantalla Universal', 'Universal Screen Control', 'Circuito de Potencia Única', 'Single Power Circuit', 'Centro de Procesamiento Unix', 'Unix Processing Center', 'A'),
(1, '¿Qué tipo de memoria pierde su contenido al apagar el computador?', 'What type of memory loses its content when the computer is turned off?', 'ROM', 'ROM', 'Disco duro', 'Hard drive', 'RAM', 'RAM', 'Flash', 'Flash', 'C'),
(1, '¿Cuántos bits tiene un byte?', 'How many bits are in a byte?', '4', '4', '16', '16', '8', '8', '32', '32', 'C'),
(1, '¿Qué componente conecta todos los dispositivos del computador?', 'Which component connects all computer devices?', 'RAM', 'RAM', 'Tarjeta de video', 'Video card', 'Placa madre', 'Motherboard', 'Fuente de poder', 'Power supply', 'C'),

(2, '¿Cuál es la derivada de x²?', 'What is the derivative of x²?', 'x', 'x', '2x', '2x', 'x²', 'x²', '2', '2', 'B'),
(2, '¿Qué representa una integral definida?', 'What does a definite integral represent?', 'La pendiente de una curva', 'The slope of a curve', 'El área bajo una curva', 'The area under a curve', 'La longitud de una función', 'The length of a function', 'El valor máximo', 'The maximum value', 'B'),
(2, '¿Cuál es el límite de 1/x cuando x tiende a infinito?', 'What is the limit of 1/x as x approaches infinity?', '1', '1', 'Infinito', 'Infinity', '0', '0', '-1', '-1', 'C'),
(2, '¿Qué es una derivada?', 'What is a derivative?', 'El área bajo la curva', 'The area under the curve', 'La tasa de cambio instantánea', 'The instantaneous rate of change', 'El valor promedio', 'The average value', 'La suma de términos', 'The sum of terms', 'B'),
(2, '¿Cuál es la derivada de una constante?', 'What is the derivative of a constant?', 'La misma constante', 'The same constant', 'Infinito', 'Infinity', '1', '1', '0', '0', 'D'),

(4, '¿Cuántos jugadores tiene un equipo de fútbol?', 'How many players are on a soccer team?', '9', '9', '10', '10', '11', '11', '12', '12', 'C'),
(4, '¿Cada cuántos años se celebra el Mundial de Fútbol?', 'How often is the FIFA World Cup held?', '2', '2', '3', '3', '4', '4', '5', '5', 'C'),
(4, '¿En qué deporte se usa una raqueta y una red?', 'In which sport is a racket and a net used?', 'Fútbol', 'Soccer', 'Tenis', 'Tennis', 'Natación', 'Swimming', 'Atletismo', 'Athletics', 'B'),
(4, '¿Cuántos sets gana quien triunfa en Wimbledon (hombres)?', 'How many sets does the winner of Wimbledon (men) win?', '2 de 3', '2 out of 3', '3 de 5', '3 out of 5', '4 de 7', '4 out of 7', '2 de 4', '2 out of 4', 'B'),
(4, '¿En qué país se originaron los Juegos Olímpicos?', 'In which country did the Olympic Games originate?', 'Roma', 'Rome', 'Egipto', 'Egypt', 'Grecia', 'Greece', 'China', 'China', 'C');
