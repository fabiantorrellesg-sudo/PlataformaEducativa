-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 20-05-2026 a las 01:22:34
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `peducativa`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `modulos`
--

CREATE TABLE `modulos` (
  `id` int(11) NOT NULL,
  `nombre_es` varchar(50) NOT NULL,
  `name_en` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `modulos`
--

INSERT INTO `modulos` (`id`, `nombre_es`, `name_en`) VALUES
(1, 'Arquitectura del Computador', 'Computer Architecture'),
(2, 'Cálculo', 'Calculus'),
(3, 'Antropología Filosófica', 'Philosophical Anthropology'),
(4, 'Educación Física', 'Physical Education');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `preguntas`
--

CREATE TABLE `preguntas` (
  `id` int(11) NOT NULL,
  `id_modulo` int(11) NOT NULL,
  `pregunta_es` text NOT NULL,
  `pregunta_en` text NOT NULL,
  `opcion_a_es` varchar(255) NOT NULL,
  `opcion_a_en` varchar(255) NOT NULL,
  `opcion_b_es` varchar(255) NOT NULL,
  `opcion_b_en` varchar(255) NOT NULL,
  `opcion_c_es` varchar(255) NOT NULL,
  `opcion_c_en` varchar(255) NOT NULL,
  `opcion_d_es` varchar(255) NOT NULL,
  `opcion_d_en` varchar(255) NOT NULL,
  `letra_correcta` char(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `preguntas`
--

INSERT INTO `preguntas` (`id`, `id_modulo`, `pregunta_es`, `pregunta_en`, `opcion_a_es`, `opcion_a_en`, `opcion_b_es`, `opcion_b_en`, `opcion_c_es`, `opcion_c_en`, `opcion_d_es`, `opcion_d_en`, `letra_correcta`) VALUES
(1, 1, '¿Cuál es el objeto de estudio principal de la Antropología Filosófica?', 'What is the primary object of study of Philosophical Anthropology?', 'La variabilidad cultural y las estructuras de parentesco en las sociedades humanas', 'Cultural variability and kinship structures in human societies', 'La esencia, especificidad ontológica y el puesto del ser humano en el cosmos', 'The essence, ontological specificity, and the place of the human being in the cosmos', 'El origen evolutivo de las capacidades cognitivas del Homo sapiens', 'The evolutionary origin of cognitive capacities in Homo sapiens', 'La determinación ético-política de las conductas en la civilización occidental', 'The ethical-political determination of behaviors in Western civilization', 'B'),
(2, 1, '¿Qué filósofo definió al hombre como un \"animal político\" (zoon politikon)?', 'Which philosopher defined man as a \"political animal\" (zoon politikon)?', 'Platón', 'Plato', 'Aristóteles', 'Aristotle', 'Cicerón', 'Cicero', 'Thomas Hobbes', 'Thomas Hobbes', 'B'),
(3, 1, 'El concepto de \"Dasein\" (ser-en-el-mundo) fue propuesto por:', 'The concept of \"Dasein\" (being-in-the-world) was proposed by:', 'Martin Heidegger', 'Martin Heidegger', 'Jean-Paul Sartre', 'Jean-Paul Sartre', 'Edmund Husserl', 'Edmund Husserl', 'Søren Kierkegaard', 'Søren Kierkegaard', 'A'),
(4, 1, '¿Qué corriente afirma que \"la existencia precede a la esencia\"?', 'Which current claims that \"existence precedes essence\"?', 'El Idealismo Trascendental', 'Transcendental Idealism', 'El Existencialismo', 'Existentialism', 'El Vitalismo Irracionalista', 'Irrationalist Vitalism', 'El Materialismo Histórico', 'Historical Materialism', 'B'),
(5, 1, '¿Qué significa el término \"Antropocentrismo\"?', 'What does the term \"Anthropocentrism\" mean?', 'La tesis de que la evolución biológica converge necesariamente en la especie humana', 'The thesis that biological evolution necessarily converges on the human species', 'El giro epistemológico y ético donde el ser humano es el fundamento de inteligibilidad y medida de la realidad', 'The epistemological and ethical turn where the human being is the foundation of intelligibility and measure of reality', 'La corriente que limita el conocimiento filosófico a las capacidades psicológicas del sujeto', 'The current that limits philosophical knowledge to the psychological capacities of the subject', 'La doctrina que defiende la primacía de los derechos humanos sobre las leyes estatales', 'The doctrine that defends the primacy of human rights over state laws', 'B'),
(6, 1, 'Para Max Scheler, lo que diferencia al hombre del animal es:', 'For Max Scheler, what differentiates man from animal is:', 'La inteligencia técnica y el uso de herramientas', 'Technical intelligence and the use of tools', 'La autoconciencia psicológica de los estados internos', 'Psychological self-awareness of internal states', 'El espíritu (Geist), que otorga la capacidad de objetivar el entorno', 'The spirit (Geist), which grants the capacity to objectify the environment', 'La capacidad comunicativa mediante signos abstractos', 'The communicative capacity through abstract signs', 'C'),
(7, 1, '¿Qué es la \"Hominización\"?', 'What is \"Hominization\"?', 'El desarrollo de las estructuras simbólicas, el lenguaje complejo y la cultura', 'The development of symbolic structures, complex language, and culture', 'El proceso morfobiológico y evolutivo que conduce a la configuración anatómica de la especie humana', 'The morphobiological and evolutionary process that leads to the anatomical configuration of the human species', 'El proceso de asimilación de un individuo a las normas e ideales de su sociedad', 'The process of assimilation of an individual to the norms and ideals of their society', 'La humanización de las relaciones jurídicas y el reconocimiento de la dignidad universal', 'The humanization of legal relations and the recognition of universal dignity', 'B'),
(8, 1, '¿Cuál de estos autores es un referente de la antropología filosófica moderna?', 'Which of these authors is a reference of modern philosophical anthropology?', 'Immanuel Kant', 'Immanuel Kant', 'Helmuth Plessner', 'Helmuth Plessner', 'Wilhelm Dilthey', 'Wilhelm Dilthey', 'Claude Lévi-Strauss', 'Claude Lévi-Strauss', 'B'),
(9, 1, 'El dualismo antropológico (cuerpo y alma como sustancias separadas) es característico de:', 'Anthropological dualism (body and soul as separate substances) is characteristic of:', 'René Descartes', 'René Descartes', 'Baruch Spinoza', 'Baruch Spinoza', 'Thomas Hobbes', 'Thomas Hobbes', 'Gottfried Leibniz', 'Gottfried Leibniz', 'A'),
(10, 1, '¿A qué se refiere la \"Apertura al mundo\" en el ser humano?', 'What does \"Openness to the world\" refer to in the human being?', 'A la indeterminación biológica que le permite superar el cerco instintivo y configurar libremente su entorno', 'To the biological indeterminacy that allows him to overcome the instinctive enclosure and freely configure his environment', 'A la necesidad transcultural de migrar y poblar diversos nichos ecológicos', 'To the transcultural need to migrate and populate diverse ecological niches', 'A la capacidad racional de asimilar la totalidad de las verdades metafísicas', 'To the rational capacity to assimilate the totality of metaphysical truths', 'Al proceso histórico de globalización e intercambio de las producciones simbólicas', 'To the historical process of globalization and exchange of symbolic productions', 'A'),
(11, 2, '¿En qué país se originaron los Juegos Olímpicos de la Antigüedad?', 'In which country did the Ancient Olympic Games originate?', 'Italia', 'Italy', 'Grecia', 'Greece', 'Egipto', 'Egypt', 'Francia', 'France', 'B'),
(12, 2, '¿Cuántos jugadores por equipo participan en un partido de baloncesto en cancha?', 'How many players per team participate in a basketball game on court?', '11', '11', '7', '7', '5', '5', '6', '6', 'C'),
(13, 2, '¿Cuál es la distancia de una carrera de Maratón oficial?', 'What is the distance of an official Marathon race?', '10 km', '10 km', '21 km', '21 km', '42.195 km', '42.195 km', '50 km', '50 km', 'C'),
(14, 2, '¿Qué significa la sigla FIFA?', 'What does the acronym FIFA stand for?', 'Fútbol Internacional de Formación Atlética', 'International Football for Athletic Training', 'Fédération Internationale de Football Association', 'Fédération Internationale de Football Association', 'Federación Independiente de Fútbol Amateur', 'Independent Amateur Football Federation', 'Formación Integral de Fútbol Asociado', 'Comprehensive Association Football Training', 'B'),
(15, 2, '¿En qué deporte se utiliza el término \"Home Run\"?', 'In what sport is the term \"Home Run\" used?', 'Tenis', 'Tennis', 'Béisbol', 'Baseball', 'Voleibol', 'Volleyball', 'Natación', 'Swimming', 'B'),
(16, 2, '¿Cuánto dura un set de tenis si no hay \"tie-break\"?', 'How long does a tennis set last if there is no \"tie-break\"?', '10 puntos', '10 points', 'Al primero que gane 6 juegos con diferencia de 2', 'First to win 6 games with a 2-game difference', '45 minutos', '45 minutes', '3 periodos', '3 periods', 'B'),
(17, 2, '¿Cuál es el estilo de natación más rápido?', 'What is the fastest swimming style?', 'Pecho', 'Breaststroke', 'Mariposa', 'Butterfly', 'Crol (Libre)', 'Crawl (Freestyle)', 'Espalda', 'Backstroke', 'C'),
(18, 2, '¿Cuántos puntos vale un \"Try\" en el Rugby Union?', 'How many points is a \"Try\" worth in Rugby Union?', '3', '3', '5', '5', '7', '7', '2', '2', 'B'),
(19, 2, '¿En qué deporte se compite por la \"Copa Davis\"?', 'In what sport do athletes compete for the \"Davis Cup\"?', 'Golf', 'Golf', 'Tenis', 'Tennis', 'Ciclismo', 'Cycling', 'Esgrima', 'Fencing', 'B'),
(20, 2, '¿Quién ostenta el récord mundial de los 100 metros planos?', 'Who holds the world record for the 100-meter dash?', 'Michael Phelps', 'Michael Phelps', 'Usain Bolt', 'Usain Bolt', 'Cristiano Ronaldo', 'Cristiano Ronaldo', 'Carl Lewis', 'Carl Lewis', 'B'),
(21, 3, '¿Qué es el dominio de una función real?', 'What is the domain of a real function?', 'El conjunto de todos los valores de salida o imágenes que la función puede proyectar', 'The set of all output values or images that the function can project', 'El conjunto de valores de entrada independientes para los cuales la función está matemáticamente definida', 'The set of independent input values for which the function is mathematically defined', 'El intervalo cerrado en el cual la función presenta un comportamiento estrictamente creciente', 'The closed interval in which the function shows a strictly increasing behavior', 'El valor límite al que se aproximan las variables dependientes', 'The limit value approached by dependent variables', 'B'),
(22, 3, 'Si f(x) = x^2 - 1, ¿cuánto es f(3)?', 'If f(x) = x^2 - 1, what is f(3)?', '5', '5', '8', '8', '9', '9', '6', '6', 'B'),
(23, 3, '¿Cuál es el valor del límite cuando x tiende a 2 de la función f(x) = 3x + 1?', 'What is the value of the limit as x approaches 2 of the function f(x) = 3x + 1?', '5', '5', '7', '7', '6', '6', 'No existe, porque la función no presenta una discontinuidad', 'Does not exist, because the function has no discontinuity', 'B'),
(24, 3, 'La regla de la cadena es un teorema fundamental que se utiliza específicamente para calcular la derivada de:', 'The chain rule is a fundamental theorem used specifically to calculate the derivative of:', 'El producto de dos funciones algebraicas de distinta naturaleza', 'The product of two algebraic functions of different nature', 'Funciones compuestas, donde una función actúa como el argumento de otra', 'Composite functions, where one function acts as the argument of another', 'Funciones racionales cuando el denominador tiende dinámicamente a cero', 'Rational functions when the denominator dynamically approaches zero', 'La inversa de una función trigonométrica en un intervalo abierto', 'The inverse of a trigonometric function in an open interval', 'B'),
(25, 3, '¿Cuál es la derivada de sen(x) con respecto a x?', 'What is the derivative of sin(x) with respect to x?', '-cos(x)', '-cos(x)', 'cos(x)', 'cos(x)', '-sen(x)', '-sin(x)', 'sec^2(x)', 'sec^2(x)', 'B'),
(26, 3, '¿Qué propiedad geométrica de la función indica analíticamente una derivada segunda negativa (f\'\'(x) < 0)?', 'What geometric property of the function analytically indicates a negative second derivative (f\'\'(x) < 0)?', 'Que la función es cóncava hacia arriba, indicando la presencia de un extremo mínimo', 'That the function is concave upward, indicating the presence of a local minimum extreme', 'Que la función es cóncava hacia abajo, confirmando la existencia de un extremo máximo', 'That the function is concave downward, confirming the existence of a local maximum extreme', 'Que la gráfica interseca a su asíntota horizontal', 'That the graph intersects its horizontal asymptote', 'Que la función ha alcanzado un punto de inflexión', 'That the function has reached an inflection point', 'B'),
(27, 3, '¿Cuál es el resultado de aplicar la regla de la potencia para derivar la expresión 5x^3?', 'What is the result of applying the power rule to differentiate the expression 5x^3?', '15x^3', '15x^3', '15x^2', '15x^2', '5x^2', '5x^2', '15x', '15x', 'B'),
(28, 3, 'Un límite que al ser evaluado por sustitución directa resulta en la forma 0/0 se define matemáticamente como:', 'A limit that when evaluated by direct substitution results in the form 0/0 is mathematically defined as:', 'Una asíntota vertical infranqueable donde el límite diverge al infinito', 'An impassable vertical asymptote where the limit diverges to infinity', 'Una indeterminación, lo que exige reescribir algebraicamente la función', 'An indeterminacy, which requires algebraically rewriting the function', 'Un valor inexistente o indefinido que anula automáticamente cualquier análisis', 'A non-existent or undefined value that automatically voids any further analysis', 'Un punto de discontinuidad esencial que equivale estrictamente al valor cero', 'A point of essential discontinuity that strictly equates to the value zero', 'B'),
(29, 3, '¿Qué nombre recibe el teorema que establece que la derivación y la integración son operaciones inversas?', 'What is the name of the theorem that states that differentiation and integration are inverse operations?', 'Teorema del Valor Medio para el cálculo diferencial', 'Mean Value Theorem for differential calculus', 'Teorema Fundamental del Cálculo', 'Fundamental Theorem of Calculus', 'Teorema de la Convergencia Monótona', 'Monotone Convergence Theorem', 'Teorema de Taylor y Maclaurin', 'Taylor and Maclaurin Theorem', 'B'),
(30, 3, 'La derivada de una suma de funciones (f + g)\' es igual a:', 'The derivative of a sum of functions (f + g)\' is equal to:', 'f\' * g + f * g\'', 'f\' * g + f * g\'', 'f\' + g\'', 'f\' + g\'', 'f\' * g\'', 'f\' * g\'', '(f\' + g\') / (f + g)', '(f\' + g\') / (f + g)', 'B'),
(31, 4, 'Dentro de la clasificación del software, ¿en qué categoría se ubica un programa como un Antivirus?', 'Within the software classification, in what category is an Antivirus located?', 'Software de desarrollo', 'Development software', 'Software de sistemas', 'Systems software', 'Software de utilidad', 'Utility software', 'Software de aplicación', 'Application software', 'C'),
(32, 4, 'Durante el proceso de arranque de la computadora, ¿cuál es la función exacta del POST?', 'During the computer boot process, what is the exact function of the POST?', 'Cargar el sector de arranque desde el disco duro', 'Load the boot sector from the hard drive', 'Realizar una prueba de diagnóstico del hardware clave', 'Perform a diagnostic test of key hardware', 'Ofrecer una interfaz gráfica para elegir el OS', 'Offer a graphical interface to choose the OS', 'Mantener actualizados los drivers de la tarjeta madre', 'Keep motherboard drivers updated', 'B'),
(33, 4, '¿Qué componente interno de la CPU almacena la dirección de memoria de la PRÓXIMA instrucción?', 'Which internal component of the CPU stores the memory address of the NEXT instruction?', 'El Registro de Instrucción (RI)', 'The Instruction Register (IR)', 'El Contador de Programa (PC)', 'The Program Counter (PC)', 'La Unidad Aritmético Lógica (ALU)', 'The Arithmetic Logic Unit (ALU)', 'El registro acumulador de datos', 'The data accumulator register', 'B'),
(34, 4, 'Si convertimos el número decimal 45 a su notación binaria, el resultado correcto es:', 'If we convert the decimal number 45 to its binary notation, the correct result is:', '101101', '101101', '110011', '110011', '101010', '101010', '111001', '111001', 'A'),
(35, 4, 'Al ensamblar una computadora, ¿qué determina el \"Factor de Forma\"?', 'When assembling a computer, what determines the \"Form Factor\"?', 'La capacidad de almacenamiento y la velocidad', 'Storage capacity and speed', 'Los requisitos de software y compatibilidad', 'Software requirements and compatibility', 'Las dimensiones físicas, la geometría y conectores', 'Physical dimensions, geometry, and connectors', 'El voltaje máximo que puede recibir', 'The maximum voltage it can receive', 'C'),
(36, 4, '¿Qué tipo de memoria RAM mantiene los datos intactos sin necesidad de refresco constante?', 'What type of RAM keeps data intact without constant refreshing?', 'DRAM', 'DRAM', 'SRAM', 'SRAM', 'EPROM', 'EPROM', 'RDRAM', 'RDRAM', 'B'),
(37, 4, '¿En qué consiste la técnica de administración de memoria llamada \"Swapping\"?', 'What does the memory management technique called \"Swapping\" consist of?', 'Mover procesos entre RAM y el disco duro', 'Moving processes between RAM and hard drive', 'Dividir un programa en bloques de tamaño fijo', 'Dividing a program into fixed-size blocks', 'Compartir recursos entre la tarjeta de video y CPU', 'Sharing resources between video card and CPU', 'Duplicar la información en la memoria secundaria', 'Duplicating information in secondary memory', 'A'),
(38, 4, 'En la gestión de memoria virtual, ¿cuál es la diferencia entre \"Paginación\" y \"Segmentación\"?', 'In virtual memory management, what is the difference between \"Paging\" and \"Segmentation\"?', 'La paginación la decide el disco y la segmentación el CPU', 'Paging is decided by the disk and segmentation by CPU', 'La paginación usa bloques de tamaño fijo, la segmentación tamaño variable', 'Paging uses fixed-size blocks, segmentation uses variable-size blocks', 'La paginación guarda datos temporales, segmentación permanentes', 'Paging stores temporary data, segmentation permanent', 'La paginación elimina virus, segmentación organiza carpetas', 'Paging removes viruses, segmentation organizes folders', 'B'),
(39, 4, '¿Cuál es la principal ventaja que ofrece la interfaz UEFI frente a la BIOS tradicional?', 'What is the main advantage offered by the UEFI interface over traditional BIOS?', 'Reemplaza la necesidad de un sistema operativo', 'Replaces the need for an operating system', 'Soporta discos duros mayores, arranque más rápido e interfaz gráfica', 'Supports larger hard drives, faster boot and graphical interface', 'Permite que la RAM funcione sin tarjeta madre', 'Allows RAM to work without motherboard', 'Evita fallas de hardware por electricidad', 'Prevents hardware failures due to electricity', 'B'),
(40, 4, 'Si una empresa necesita un servidor altamente escalable pagando por recursos en tiempo real, debe elegir:', 'If a company needs a highly scalable server paying for real-time resources, they should choose:', 'Servidor compartido local', 'Local shared server', 'Servidor en la nube (Cloud Server)', 'Cloud Server', 'Servidor dedicado físico', 'Physical dedicated server', 'Servidor analógico segmentado', 'Segmented analog server', 'B');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `id` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `clave` varchar(50) NOT NULL,
  `rol` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`id`, `nombre`, `clave`, `rol`) VALUES
(1, 'Gabriel Corobo', '12345678', 0),
(2, 'Laura Vargas', '12345678', 1),
(3, 'Zeze Crespo', '12345678', 1),
(4, 'Rebeca Granoble', '12345678', 1),
(5, 'Fabian Torrelles', '12345678', 1),
(6, 'Marlys Flores', '12345678', 0);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `modulos`
--
ALTER TABLE `modulos`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `preguntas`
--
ALTER TABLE `preguntas`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_modulo` (`id_modulo`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `modulos`
--
ALTER TABLE `modulos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de la tabla `preguntas`
--
ALTER TABLE `preguntas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=41;

--
-- AUTO_INCREMENT de la tabla `usuario`
--
ALTER TABLE `usuario`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `preguntas`
--
ALTER TABLE `preguntas`
  ADD CONSTRAINT `preguntas_ibfk_1` FOREIGN KEY (`id_modulo`) REFERENCES `modulos` (`id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
