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

-- Tabla de preguntas del quiz
CREATE TABLE IF NOT EXISTS pregunta (
    id INT AUTO_INCREMENT PRIMARY KEY,
    enunciado TEXT NOT NULL,
    opcion_a VARCHAR(255) NOT NULL,
    opcion_b VARCHAR(255) NOT NULL,
    opcion_c VARCHAR(255) NOT NULL,
    opcion_d VARCHAR(255) NOT NULL,
    respuesta_correcta CHAR(1) NOT NULL COMMENT 'A, B, C o D',
    materia VARCHAR(100) NOT NULL
);

-- =============================================
-- Datos de prueba - Usuarios
-- =============================================

INSERT INTO usuario (nombre, clave, rol) VALUES
('admin', 'admin123', 0),
('jugador1', 'jugador123', 1),
('jugador2', 'jugador456', 1);

-- =============================================
-- Datos de prueba - Preguntas de Antropología filosófica
-- =============================================

INSERT INTO pregunta (enunciado, opcion_a, opcion_b, opcion_c, opcion_d, respuesta_correcta, materia) VALUES
('¿Qué estudia la Antropología filosófica?', 'Los animales', 'El ser humano como totalidad', 'Las plantas', 'El universo', 'B', 'Antropología filosófica'),
('¿Quién planteó que el hombre es un ser racional?', 'Darwin', 'Aristóteles', 'Newton', 'Freud', 'B', 'Antropología filosófica'),
('¿Qué distingue al ser humano de los animales según la filosofía?', 'La fuerza', 'La velocidad', 'La razón y el lenguaje', 'El tamaño', 'C', 'Antropología filosófica'),
('¿Qué es la conciencia según la antropología filosófica?', 'Un órgano del cuerpo', 'La capacidad de conocerse a sí mismo', 'Un tipo de emoción', 'Una enfermedad', 'B', 'Antropología filosófica'),
('¿Cuál filósofo escribió sobre la condición humana?', 'Hannah Arendt', 'Albert Einstein', 'Isaac Newton', 'Charles Darwin', 'A', 'Antropología filosófica');

-- =============================================
-- Datos de prueba - Preguntas de Arquitectura y estructura del computador
-- =============================================

INSERT INTO pregunta (enunciado, opcion_a, opcion_b, opcion_c, opcion_d, respuesta_correcta, materia) VALUES
('¿Cuál es la unidad básica de información en un computador?', 'Byte', 'Bit', 'Nibble', 'Pixel', 'B', 'Arquitectura y estructura del computador'),
('¿Qué significa CPU?', 'Unidad Central de Procesamiento', 'Control de Pantalla Universal', 'Circuito de Potencia Única', 'Centro de Procesamiento Unix', 'A', 'Arquitectura y estructura del computador'),
('¿Qué tipo de memoria pierde su contenido al apagar el computador?', 'ROM', 'Disco duro', 'RAM', 'Flash', 'C', 'Arquitectura y estructura del computador'),
('¿Cuántos bits tiene un byte?', '4', '16', '8', '32', 'C', 'Arquitectura y estructura del computador'),
('¿Qué componente conecta todos los dispositivos del computador?', 'RAM', 'Tarjeta de video', 'Placa madre', 'Fuente de poder', 'C', 'Arquitectura y estructura del computador');

-- =============================================
-- Datos de prueba - Preguntas de Cálculo
-- =============================================

INSERT INTO pregunta (enunciado, opcion_a, opcion_b, opcion_c, opcion_d, respuesta_correcta, materia) VALUES
('¿Cuál es la derivada de x²?', 'x', '2x', 'x²', '2', 'B', 'Cálculo'),
('¿Qué representa una integral definida?', 'La pendiente de una curva', 'El área bajo una curva', 'La longitud de una función', 'El valor máximo', 'B', 'Cálculo'),
('¿Cuál es el límite de 1/x cuando x tiende a infinito?', '1', 'Infinito', '0', '-1', 'C', 'Cálculo'),
('¿Qué es una derivada?', 'El área bajo la curva', 'La tasa de cambio instantánea', 'El valor promedio', 'La suma de términos', 'B', 'Cálculo'),
('¿Cuál es la derivada de una constante?', 'La misma constante', 'Infinito', '1', '0', 'D', 'Cálculo');

-- =============================================
-- Datos de prueba - Preguntas de Deporte
-- =============================================

INSERT INTO pregunta (enunciado, opcion_a, opcion_b, opcion_c, opcion_d, respuesta_correcta, materia) VALUES
('¿Cuántos jugadores tiene un equipo de fútbol?', '9', '10', '11', '12', 'C', 'Deporte'),
('¿Cada cuántos años se celebra el Mundial de Fútbol?', '2', '3', '4', '5', 'C', 'Deporte'),
('¿En qué deporte se usa una raqueta y una red?', 'Fútbol', 'Tenis', 'Natación', 'Atletismo', 'B', 'Deporte'),
('¿Cuántos sets gana quien triunfa en Wimbledon (hombres)?', '2 de 3', '3 de 5', '4 de 7', '2 de 4', 'B', 'Deporte'),
('¿En qué país se originaron los Juegos Olímpicos?', 'Roma', 'Egipto', 'Grecia', 'China', 'C', 'Deporte');
