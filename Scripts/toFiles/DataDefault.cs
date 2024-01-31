using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataDefault : MonoBehaviour
{
    //COLOCA DATA POR DEFECTO EN LOS .JSON
    void Start()
    {
        /*
        if (PlayerPrefs.GetInt("FirstInstallation") == 0)
        {
            DataInJson();
            PlayerPrefs.SetInt("FirstInstallation", 1);
        }*/
        DataInJson();
        DiversionJson();
    }


    void DataInJson()
    {
        //PARA CADA TEMA EASY
        List<ObjectTheme> themes_easy = new List<ObjectTheme>();
        themes_easy.Add(new ObjectTheme("inglés", "inglés", "Preguntas de números y colores", new List<ObjectScore>()));
        themes_easy.Add(new ObjectTheme("matemáticas", "matemáticas", "Preguntas para elegir números", new List<ObjectScore>()));
        themes_easy.Add(new ObjectTheme("romanos", "romanos", "Preguntas para escoger números romanos básicos", new List<ObjectScore>()));
        themes_easy.Add(new ObjectTheme("reconoce", "reconoce", "Preguntas para tomar la imagen que representa el texto", new List<ObjectScore>()));
        themes_easy.Add(new ObjectTheme("adivinanzas", "adivinanzas", "Preguntas para elegir la respuesta que se parece al color", new List<ObjectScore>()));

        ObjectThemeContainer containerEasy = new ObjectThemeContainer(themes_easy);
        SaveLoadData.SaveData(containerEasy, "FilesGame/Difficulty/Easy", "themesEasy");

        //INGLES
        List<ObjectData> ingles = new List<ObjectData>();
        /*ingles.Add(new ObjectData("(ɔ◔‿◔)ɔ☀", "(ɔ◔‿◔)ɔ☀☼"));
        ingles.Add(new ObjectData("☀", "S"));*/

        ingles.Add(new ObjectData("Cero", "Zero"));
        ingles.Add(new ObjectData("Uno", "One"));
        ingles.Add(new ObjectData("Dos", "Two"));
        ingles.Add(new ObjectData("Tres", "Three"));
        ingles.Add(new ObjectData("Cuatro", "Four"));
        ingles.Add(new ObjectData("Cinco", "Five"));
        ingles.Add(new ObjectData("Seis", "Six"));
        ingles.Add(new ObjectData("Siete", "Seven"));
        ingles.Add(new ObjectData("Ocho", "Eight"));
        ingles.Add(new ObjectData("Nueve", "Nine"));
        ingles.Add(new ObjectData("Diez", "Ten"));
        ingles.Add(new ObjectData("Verde", "Green"));
        ingles.Add(new ObjectData("Rojo", "Red"));
        ingles.Add(new ObjectData("Amarillo", "Yellow"));
        ingles.Add(new ObjectData("Azul", "Blue"));
        ingles.Add(new ObjectData("Blanco", "White"));
        ingles.Add(new ObjectData("Negro", "Black"));
        ingles.Add(new ObjectData("Morado", "Purple"));
        ingles.Add(new ObjectData("Rosado", "Pink"));
        ingles.Add(new ObjectData("Gris", "Grey"));
        ingles.Add(new ObjectData("Marrón", "Brown"));

        ObjectDataContainer containerIngles = new ObjectDataContainer(ingles);
        SaveLoadData.SaveData(containerIngles, "FilesGame/Difficulty/Easy/Questions", "inglés");


        //MATEMATICAS
        List<ObjectData> matematicas = new List<ObjectData>();
        matematicas.Add(new ObjectData("1", "Uno"));
        matematicas.Add(new ObjectData("2", "Dos"));
        matematicas.Add(new ObjectData("3", "Tres"));
        matematicas.Add(new ObjectData("4", "Cuatro"));
        matematicas.Add(new ObjectData("5", "Cinco"));
        matematicas.Add(new ObjectData("6", "Seis"));
        matematicas.Add(new ObjectData("7", "Siete"));
        matematicas.Add(new ObjectData("8", "Ocho"));
        matematicas.Add(new ObjectData("9", "Nueve"));
        matematicas.Add(new ObjectData("10", "Diez"));
        matematicas.Add(new ObjectData("10", "Diez"));
        matematicas.Add(new ObjectData("20", "Veinte"));
        matematicas.Add(new ObjectData("30", "Treinta"));
        matematicas.Add(new ObjectData("40", "Cuarenta"));
        matematicas.Add(new ObjectData("50", "Cincuenta"));
        matematicas.Add(new ObjectData("60", "Sesenta"));
        matematicas.Add(new ObjectData("70", "Setenta"));
        matematicas.Add(new ObjectData("80", "Ochenta"));
        matematicas.Add(new ObjectData("90", "Noventa"));
        matematicas.Add(new ObjectData("100", "Cien"));

        ObjectDataContainer containerMatematicas = new ObjectDataContainer(matematicas);
        SaveLoadData.SaveData(containerMatematicas, "FilesGame/Difficulty/Easy/Questions", "matemáticas");



        //ROMANOS
        List<ObjectData> romanos = new List<ObjectData>();
        romanos.Add(new ObjectData("1", "I"));
        romanos.Add(new ObjectData("2", "II"));
        romanos.Add(new ObjectData("3", "III"));
        romanos.Add(new ObjectData("4", "IV"));
        romanos.Add(new ObjectData("5", "V"));
        romanos.Add(new ObjectData("6", "VI"));
        romanos.Add(new ObjectData("7", "VII"));
        romanos.Add(new ObjectData("8", "VIII"));
        romanos.Add(new ObjectData("9", "IX"));
        romanos.Add(new ObjectData("10", "X"));
        romanos.Add(new ObjectData("50", "L"));
        romanos.Add(new ObjectData("100", "C"));
        romanos.Add(new ObjectData("500", "D"));
        romanos.Add(new ObjectData("1000", "M"));

        ObjectDataContainer containerRomanos = new ObjectDataContainer(romanos);
        SaveLoadData.SaveData(containerRomanos, "FilesGame/Difficulty/Easy/Questions", "romanos");



        //RECONOCE
        List<ObjectData> reconoce = new List<ObjectData>();
        //reconoce.Add(new ObjectData("Feliz", "1☺"));//
        reconoce.Add(new ObjectData("Triste", "☹"));
        reconoce.Add(new ObjectData("Escribir", "✍"));
        reconoce.Add(new ObjectData("Avión", "✈"));
        reconoce.Add(new ObjectData("Sombrilla", "☂"));
        reconoce.Add(new ObjectData("Peligro", "☠"));
        //reconoce.Add(new ObjectData("Corazón", "7❤"));//
        //reconoce.Add(new ObjectData("Nube", "8☁")); //
        //reconoce.Add(new ObjectData("Sol", "9☀"));//
        reconoce.Add(new ObjectData("Hombre", "♂"));
        reconoce.Add(new ObjectData("Mujer", "♀"));
        //reconoce.Add(new ObjectData("Teléfono", "12☎"));//
        reconoce.Add(new ObjectData("Carta", "✉"));
        reconoce.Add(new ObjectData("Tijeras", "✂"));
        reconoce.Add(new ObjectData("Lápiz", "✏"));
        reconoce.Add(new ObjectData("Estrella", "✩"));
        reconoce.Add(new ObjectData("Flor", "❀"));
        reconoce.Add(new ObjectData("Música", "♫"));
        reconoce.Add(new ObjectData("Caballo", "♞"));
        reconoce.Add(new ObjectData("Árbol", "♧"));

        ObjectDataContainer containerReconoce = new ObjectDataContainer(reconoce);
        SaveLoadData.SaveData(containerReconoce, "FilesGame/Difficulty/Easy/Questions", "reconoce");



        //ADIVINANZA
        List<ObjectData> adivinanza = new List<ObjectData>();
        adivinanza.Add(new ObjectData("Adivina el color;#ffffff", "Blanco;#ffffff"));
        adivinanza.Add(new ObjectData("Adivina el color;#000000", "Negro;#000000"));
        adivinanza.Add(new ObjectData("Adivina el color;#ff0000", "Rojo;#ff0000"));
        adivinanza.Add(new ObjectData("Adivina el color;#00ff00", "Verde;#00ff00"));
        adivinanza.Add(new ObjectData("Adivina el color;#0000ff", "Azul;#0000ff"));
        adivinanza.Add(new ObjectData("Adivina el color;#ffff00", "Amarillo;#ffff00"));
        adivinanza.Add(new ObjectData("Adivina el color;#ffa500", "Naranja;#ffa500"));
        adivinanza.Add(new ObjectData("Adivina el color;#800080", "Morado;#800080"));

        ObjectDataContainer containerAdivinanza = new ObjectDataContainer(adivinanza);
        SaveLoadData.SaveData(containerAdivinanza, "FilesGame/Difficulty/Easy/Questions", "adivinanzas");




        //PARA CADA TEMA MEDIUM
        List<ObjectTheme> themes_medium = new List<ObjectTheme>();
        themes_medium.Add(new ObjectTheme("inglés", "inglés", "Preguntas de animales, ropa y días de la semana", new List<ObjectScore>()));
        themes_medium.Add(new ObjectTheme("matemáticas", "matemáticas", "Preguntas de sumas y restas", new List<ObjectScore>()));
        themes_medium.Add(new ObjectTheme("romanos", "romanos", "Preguntas de números romanos complicados", new List<ObjectScore>()));
        themes_medium.Add(new ObjectTheme("reconoce", "reconoce", "Preguntas para tomar la letra que falta según la imagen", new List<ObjectScore>()));
        themes_medium.Add(new ObjectTheme("adivinanzas", "adivinanzas", "Adivinanzas simples", new List<ObjectScore>()));
        ObjectThemeContainer containerMedium = new ObjectThemeContainer(themes_medium);
        SaveLoadData.SaveData(containerMedium, "FilesGame/Difficulty/Medium", "themesMedium");

        //INGLES
        ingles = new List<ObjectData>();
        ingles.Add(new ObjectData("Perro", "Dog"));
        ingles.Add(new ObjectData("Gato", "Cat"));
        ingles.Add(new ObjectData("Pato", "Duck"));
        ingles.Add(new ObjectData("Sol", "Sun"));
        ingles.Add(new ObjectData("Luna", "Moon"));
        ingles.Add(new ObjectData("Estrella", "Star"));
        ingles.Add(new ObjectData("Manzana", "Apple"));
        ingles.Add(new ObjectData("Pelota", "Ball"));
        ingles.Add(new ObjectData("Zapato", "Shoe"));
        ingles.Add(new ObjectData("Camisa", "Shirt"));
        ingles.Add(new ObjectData("Elefante", "Elephant"));
        ingles.Add(new ObjectData("Jirafa", "Giraffe"));
        ingles.Add(new ObjectData("Mariposa", "Butterfly"));
        ingles.Add(new ObjectData("Tigre", "Tiger"));
        ingles.Add(new ObjectData("Rana", "Frog"));
        ingles.Add(new ObjectData("Pez", "Fish"));
        ingles.Add(new ObjectData("Jueves", "Thursday"));
        ingles.Add(new ObjectData("Viernes", "Friday"));
        ingles.Add(new ObjectData("Sábado", "Saturday"));
        ingles.Add(new ObjectData("Blusa", "Blouse"));
        ingles.Add(new ObjectData("Pantalón", "Pants"));
        ingles.Add(new ObjectData("Sombrero", "Hat"));

        containerIngles = new ObjectDataContainer(ingles);
        SaveLoadData.SaveData(containerIngles, "FilesGame/Difficulty/Medium/Questions", "inglés");



        //MATEMATICAS
        matematicas = new List<ObjectData>();
        matematicas.Add(new ObjectData("6 + 2", "8"));
        matematicas.Add(new ObjectData("9 - 5", "4"));
        matematicas.Add(new ObjectData("4 + 3", "7"));
        matematicas.Add(new ObjectData("7 - 2", "5"));
        matematicas.Add(new ObjectData("8 + 1", "9"));
        matematicas.Add(new ObjectData("6 - 4", "2"));
        matematicas.Add(new ObjectData("3 + 5", "8"));
        matematicas.Add(new ObjectData("2 - 1", "1"));
        matematicas.Add(new ObjectData("9 + 0", "9"));
        matematicas.Add(new ObjectData("7 - 3", "4"));
        matematicas.Add(new ObjectData("5 + 4", "9"));
        matematicas.Add(new ObjectData("8 - 5", "3"));
        matematicas.Add(new ObjectData("2 + 7", "9"));
        matematicas.Add(new ObjectData("6 - 2", "4"));
        matematicas.Add(new ObjectData("1 + 9", "10"));
        matematicas.Add(new ObjectData("10 - 8", "2"));
        matematicas.Add(new ObjectData("4 + 1", "5"));
        matematicas.Add(new ObjectData("7 - 1", "6"));
        matematicas.Add(new ObjectData("5 + 2", "7"));
        matematicas.Add(new ObjectData("9 - 3", "6"));

        containerMatematicas = new ObjectDataContainer(matematicas);
        SaveLoadData.SaveData(containerMatematicas, "FilesGame/Difficulty/Medium/Questions", "matemáticas");



        //ROMANOS
        romanos = new List<ObjectData>();
        romanos.Add(new ObjectData("XI", "11"));
        romanos.Add(new ObjectData("XII", "12"));
        romanos.Add(new ObjectData("XIII", "13"));
        romanos.Add(new ObjectData("XIV", "14"));
        romanos.Add(new ObjectData("XV", "15"));
        romanos.Add(new ObjectData("XX", "20"));
        romanos.Add(new ObjectData("XXV", "25"));
        romanos.Add(new ObjectData("XXX", "30"));
        romanos.Add(new ObjectData("XL", "40"));
        romanos.Add(new ObjectData("L", "50"));
        romanos.Add(new ObjectData("LX", "60"));
        romanos.Add(new ObjectData("LXX", "70"));
        romanos.Add(new ObjectData("LXXX", "80"));
        romanos.Add(new ObjectData("XC", "90"));

        containerRomanos = new ObjectDataContainer(romanos);
        SaveLoadData.SaveData(containerRomanos, "FilesGame/Difficulty/Medium/Questions", "romanos");



        //RECONOCE
        reconoce = new List<ObjectData>();
        reconoce.Add(new ObjectData("♚ COR_NA", "O"));
        reconoce.Add(new ObjectData("● CIRCUL_", "O"));
        reconoce.Add(new ObjectData("＠ ARR_BA", "O"));
        reconoce.Add(new ObjectData("☽ L_NA", "U"));
        reconoce.Add(new ObjectData("▄ C_ADRADRO", "U"));
        reconoce.Add(new ObjectData("✟ CR_Z", "U"));
        reconoce.Add(new ObjectData("❆ NIEV_", "E"));
        reconoce.Add(new ObjectData("∞ INFIN_TO", "I"));
        reconoce.Add(new ObjectData("✚ M_S", "Á"));
        reconoce.Add(new ObjectData("✖ MULTIPL_CACIÓN", "I"));
        reconoce.Add(new ObjectData("✔ V_STO", "I"));
        reconoce.Add(new ObjectData("▲ TRI_NGULO", "Á"));
        reconoce.Add(new ObjectData("← IZQUI_RDA", "E"));
        reconoce.Add(new ObjectData("↑ ARRIB_", "A"));
        reconoce.Add(new ObjectData("→ D_RECHA", "E"));
        reconoce.Add(new ObjectData("❀ FL_R", "O"));
        reconoce.Add(new ObjectData("↓ ABAJ_", "O"));
        reconoce.Add(new ObjectData("➳ FLECH_", "A"));
        reconoce.Add(new ObjectData("▭ RECT_NGULO", "A"));
        reconoce.Add(new ObjectData("☃ MUÑ_CO", "E"));

        containerReconoce = new ObjectDataContainer(reconoce);
        SaveLoadData.SaveData(containerReconoce, "FilesGame/Difficulty/Medium/Questions", "reconoce");



        //ADIVINANZAS
        adivinanza = new List<ObjectData>();
        adivinanza.Add(new ObjectData("Color de la luna", "Blanco"));
        adivinanza.Add(new ObjectData("Te pones antes de usar zapatos", "Medias"));
        adivinanza.Add(new ObjectData("Tiene patas y maúlla mucho", "Gato"));
        adivinanza.Add(new ObjectData("Es redonda y amarilla por fuera, y rica por dentro", "Naranja"));
        adivinanza.Add(new ObjectData("Tiene cuatro patas y ladra", "Perro"));
        adivinanza.Add(new ObjectData("Es blanca, vuela y tiene plumas", "Gaviota"));
        adivinanza.Add(new ObjectData("Es verde, pequeño y salta", "Rana"));
        adivinanza.Add(new ObjectData("Tiene dos orejas largas y salta en el campo", "Conejo"));
        adivinanza.Add(new ObjectData("Es una fruta roja y dulce que se puede hacer mermelada", "Fresa"));
        adivinanza.Add(new ObjectData("Tiene hojas verdes y da sombra", "Árbol"));
        adivinanza.Add(new ObjectData("Es amarillo y brilla en el cielo de noche", "Luna"));
        adivinanza.Add(new ObjectData("Siempre lo vas al amanecer y brilla en el cielo", "Sol"));

        containerAdivinanza = new ObjectDataContainer(adivinanza);
        SaveLoadData.SaveData(containerAdivinanza, "FilesGame/Difficulty/Medium/Questions", "adivinanzas");




















        //PARA CADA TEMA HARD
        List<ObjectTheme> themes_hard = new List<ObjectTheme>();
        themes_hard.Add(new ObjectTheme("inglés", "inglés", "Preguntas de frases en inglés", new List<ObjectScore>()));
        themes_hard.Add(new ObjectTheme("matemáticas", "matemáticas", "Preguntas de suma, resta, multiplicación y división", new List<ObjectScore>()));
        themes_hard.Add(new ObjectTheme("romanos", "romanos", "Preguntas para escoger números romanos dificiles", new List<ObjectScore>()));
        themes_hard.Add(new ObjectTheme("adivinanzas", "adivinanzas", "Adivinanzas dificiles", new List<ObjectScore>()));
        ObjectThemeContainer containerHard = new ObjectThemeContainer(themes_hard);
        SaveLoadData.SaveData(containerHard, "FilesGame/Difficulty/Hard", "themesHard");

        //INGLES
        ingles = new List<ObjectData>();
        ingles.Add(new ObjectData("I am", "Yo soy"));
        ingles.Add(new ObjectData("Hello", "Hola"));
        ingles.Add(new ObjectData("Good morning", "Buenos días"));
        ingles.Add(new ObjectData("Good night", "Buenas noches"));
        ingles.Add(new ObjectData("Thank you", "Gracias"));
        ingles.Add(new ObjectData("Please", "Por favor"));
        ingles.Add(new ObjectData("Yes", "Sí"));
        ingles.Add(new ObjectData("No", "No"));
        ingles.Add(new ObjectData("I love you", "Te quiero"));
        ingles.Add(new ObjectData("How are you?", "¿Cómo estás?"));
        ingles.Add(new ObjectData("What's your name?", "¿Cuál es tu nombre?"));
        ingles.Add(new ObjectData("Goodbye", "Adiós"));
        ingles.Add(new ObjectData("See you later", "Nos vemos luego"));
        ingles.Add(new ObjectData("Excuse me", "Disculpa"));
        ingles.Add(new ObjectData("I'm sorry", "Lo siento"));
        ingles.Add(new ObjectData("Please, help me", "Por favor, ayúdame"));
        ingles.Add(new ObjectData("Where is the bathroom?", "¿Dónde está el baño?"));
        ingles.Add(new ObjectData("It's time to eat", "Es hora de comer"));
        ingles.Add(new ObjectData("I like ice cream", "Me gusta el helado"));
        ingles.Add(new ObjectData("I have a red ball", "Tengo una pelota roja"));
        ingles.Add(new ObjectData("The sun is shining", "El sol está brillando"));

        containerIngles = new ObjectDataContainer(ingles);
        SaveLoadData.SaveData(containerIngles, "FilesGame/Difficulty/Hard/Questions", "inglés");

        //MATEMATICAS
        matematicas = new List<ObjectData>();
        matematicas.Add(new ObjectData("1 x (2 x 4)", "8"));
        matematicas.Add(new ObjectData("5 + 8 - 1", "12"));
        matematicas.Add(new ObjectData("(3 x 4) + 2", "14"));
        matematicas.Add(new ObjectData("9 + 9 -1", "17"));
        matematicas.Add(new ObjectData("3 + 5 + 2", "10"));
        matematicas.Add(new ObjectData("8 - 4 + 1", "5"));
        matematicas.Add(new ObjectData("(2 x 3) + 5", "11"));
        matematicas.Add(new ObjectData("6 + 3 - 2", "7"));
        matematicas.Add(new ObjectData("(4 x 2) - 3", "5"));
        matematicas.Add(new ObjectData("9 - 3 - 1", "5"));
        matematicas.Add(new ObjectData("5 + (6 x 2)", "17"));
        matematicas.Add(new ObjectData("10 - 2 + 3", "11"));
        matematicas.Add(new ObjectData("(3 x 4) - 1", "11"));
        matematicas.Add(new ObjectData("8 + (4 / 2)", "10"));
        matematicas.Add(new ObjectData("12 - (6 / 3)", "10"));
        matematicas.Add(new ObjectData("(7 x 3) - 2", "19"));

        containerMatematicas = new ObjectDataContainer(matematicas);
        SaveLoadData.SaveData(containerMatematicas, "FilesGame/Difficulty/Hard/Questions", "matemáticas");

        //ROMANOS
        romanos = new List<ObjectData>();
        romanos.Add(new ObjectData("LII", "52"));
        romanos.Add(new ObjectData("C", "100"));
        romanos.Add(new ObjectData("CL", "150"));
        romanos.Add(new ObjectData("D", "500"));
        romanos.Add(new ObjectData("DL", "550"));
        romanos.Add(new ObjectData("M", "1000"));
        romanos.Add(new ObjectData("MD", "1500"));
        romanos.Add(new ObjectData("MDLV", "1555"));
        romanos.Add(new ObjectData("CXX", "120"));
        romanos.Add(new ObjectData("CC", "200"));
        romanos.Add(new ObjectData("DCCC", "800"));
        romanos.Add(new ObjectData("MCC", "1200"));
        romanos.Add(new ObjectData("MDC", "1600"));
        romanos.Add(new ObjectData("DCCC", "800"));
        romanos.Add(new ObjectData("CM", "900"));
        romanos.Add(new ObjectData("MCML", "1950"));
        romanos.Add(new ObjectData("MM", "2000"));
        romanos.Add(new ObjectData("MMCC", "2200"));
        romanos.Add(new ObjectData("MMDC", "2600"));
        romanos.Add(new ObjectData("MDLX", "1560"));
        romanos.Add(new ObjectData("CD", "400"));
        romanos.Add(new ObjectData("DCC", "700"));
        romanos.Add(new ObjectData("CMXC", "990"));
        romanos.Add(new ObjectData("MCM", "1900"));
        romanos.Add(new ObjectData("MMCM", "2900"));
        romanos.Add(new ObjectData("MMM", "3000"));

        containerRomanos = new ObjectDataContainer(romanos);
        SaveLoadData.SaveData(containerRomanos, "FilesGame/Difficulty/Hard/Questions", "romanos");




        //ADIVINANZAS
        adivinanza = new List<ObjectData>();
        adivinanza.Add(new ObjectData("Soy redonda como una pelota, pero no rebotas.", "La Luna"));
        adivinanza.Add(new ObjectData("Si me nombras, desaparezco.", "El silencio"));
        adivinanza.Add(new ObjectData("Soy amarillo por fuera, blanco por dentro, y siempre estoy en el medio.", "Un huevo"));
        adivinanza.Add(new ObjectData("Soy blanco como la nieve, dulce como el azúcar, y con un hoyo en el centro.", "Una dona"));
        adivinanza.Add(new ObjectData("Soy verde y pequeño, tengo rayas blancas y salto sin cesar.", "Una rana"));
        adivinanza.Add(new ObjectData("Soy dulce, tengo semillas y crezco en una planta.", "Una sandía"));
        adivinanza.Add(new ObjectData("Tengo agujas pero no coso, y corto pero no soy tijeras.", "Una sierra"));
        adivinanza.Add(new ObjectData("Soy un animal que tiene muchas rayas, pero no soy una cebra.", "Un tigre"));
        adivinanza.Add(new ObjectData("Tiene hojas pero no es un árbol, y marca la fecha pero no es un calendario.", "Un libro"));
        adivinanza.Add(new ObjectData("Tiene cuatro patas pero no puede caminar.", "Una mesa"));
        adivinanza.Add(new ObjectData("Tiene dientes pero no puede morder, envuelve la comida pero no para él.", "Un tenedor"));
        adivinanza.Add(new ObjectData("Vuela sin alas y silba sin boca.", "El viento"));
        adivinanza.Add(new ObjectData("Tiene ciudades pero no tiene edificios, tiene bosques pero no tiene árboles.", "El mapa"));
        adivinanza.Add(new ObjectData("Tiene una cabeza pero no puede pensar, tiene un brazo pero no puede agarrar.", "Un reloj"));
        adivinanza.Add(new ObjectData("Es redonda como una pelota, pero no rebota.", "La Luna"));
        adivinanza.Add(new ObjectData("Tiene una cabeza pero no puede pensar, tiene un cuello pero no puede girar.", "Una botella"));
        adivinanza.Add(new ObjectData("Tiene llave pero no abre puertas, tiene números pero no es una calculadora.", "Un teléfono"));
        adivinanza.Add(new ObjectData("Tiene cuerdas pero no es un instrumento musical, tiene un cuello pero no es una camisa.", "Una guitarra"));
        adivinanza.Add(new ObjectData("Tiene orejas pero no puede oír, tiene boca pero no puede hablar.", "Una taza"));

        containerAdivinanza = new ObjectDataContainer(adivinanza);
        SaveLoadData.SaveData(containerAdivinanza, "FilesGame/Difficulty/Hard/Questions", "adivinanzas");
    }


    void DiversionJson()
    {
        SaveLoadDataDiversion.ResetDataDefault("Diversion", "Diversion_ContraTiempo");
        SaveLoadDataDiversion.ResetDataDefault("Diversion", "Diversion_PistaNivel1");
        SaveLoadDataDiversion.ResetDataDefault("Diversion", "Diversion_PistaNivel2");
        SaveLoadDataDiversion.ResetDataDefault("Diversion", "Diversion_PistaNivel3");
    }



}
