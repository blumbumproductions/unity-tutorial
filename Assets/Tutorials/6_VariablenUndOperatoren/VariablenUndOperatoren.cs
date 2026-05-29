/// <summary>
/// In diesem Tutorial geht es um Variablen und wie wir sie verwenden können. Variablen sind neben Funktionen die
/// wichtigsten Komponenten der Programmierung. Ohne Variablen geht gar nichts.
/// </summary>
public class VariablenUndOperatoren
{
    
    /*
     * In C# gibt es 3 Grundelemente Klassen, Funktionen und Variablen.
     * Klassen haben wir ja oben schon besprochen, sind Beschreibungen von Dingen (Objekten oder Lebewesen). Sie können
     * auch noch andere Funktionen einnehmen, aber die beachten wir für den Anfang nicht. Wenn wir uns jetzt diese
     * Beschreibung anschauen, sehen wir, dass die Katze (aus dem Beispiel oben) 4 Pfoten hat. Diese 4 Pfoten würden wir
     * als Variablen in einer Klasse beschreiben. Variablen kennt ihr sicher aus dem Matheunterricht. Da sind es immer
     * nur x und y (oder andere Buchstaben), aber hier können Variablen etwas komplexere Namen annehmen. Wir können und
     * sollten sogar den Variablen, die wir in unseren Programmen verwenden, ordentliche Namen geben. Variablen in C# haben
     * meistens auch einen sogenannten Datentyp. Ein Datentyp könnt ihr euch als eine Art Festlegung vorstellen, damit
     * der Programmier und auch der Computer weis, was genau in diese Variable reinkommen kann. 
    */
    
    // Hier mal ein Beispiel für eine Variable:
    int x = 1;
    
    /*
     * Das ist übrigens ein sehr schlechtes Beispiel, denn wie ich schon sagte, benennt eure Variablen ordentlich.
     * Dennoch seht ihr hier eine interessante Zeile Code. Sie besteht aus dem Wörtchen "int" danach dem Variablennamen,
     * einem "=" und einer "1". Dahinter ist ein ";" das kommt einfach hinter jede Zeile.
     * Nun zur Erklärung. Das "int" ist der Datentyp und bedeutet, dass die Variable jede Zahl von -2.147.483.648 bis
     * 2.147.483.647 an nehmen kann. Das klingt etwas komisch, ergibt aber Sinn, wenn man sich etwas mit Computern auskennt.
     *
     * [Exkurs] (Das ist nur für Leute die es interessiert.)
     * Das "int" in C# ist ein 32-bit integer. Das bedeutet, dass es einen Speicherplatz von 2 hoch 32 einnehmen kann.
     * also für alle die nicht so gut in Mathematik waren: 2*2*2*...*2 und das mit 32 Mal der 2. Das ergibt 4.294.967.296.
     * Jetzt denkt ihr euch sicher: "Aber die Zahl ist ja anders, als das was du vorher geschrieben hast!" Ja, ist sie und
     * das ist auch richtig so. Denn wir wollen mit einem "int" positive und negative Zahlen abdecken. Dafür nehmen wir
     * den ganzen Speicherplatz, den wir haben und teilen ihn durch 2. Die eine Häfte wird positiv und die andere negativ.
     * Jetzt werdet ihr natürlich auf das kleine Problem stoßen, dass die negativen Zahlen um eins kleiner sind, als die
     * positiven. Das liegt einfach daran, dass auch die 0 einen Speicherplatz braucht. Deswegen wurde bei den negativen
     * Zahlen eine weggenommen und die 0 ist auch darstellbar. So kommt es zu diesem verrückten Zahlenraum.
     *
     * Jetzt fragt ihr euch sicher noch, wieso das jetzt genau 2 hoch 32 ist. Ja gut das liegt wiederum daran, dass in einem
     * Computer mit dem Binärsystem gearbeitet wird. Es besteht aus zwei Zuständen der 0 und der 1. Die werden einfach
     * aneinander gereiht und daraus ergeben sich neue Zahlen.
     *
     * Zum Beispiel als 4-bit (also 4 Mal eine 1 oder 0)
     * 0000 = 0
     * 0001 = 1
     * 0010 = 2
     * 0011 = 3
     * 0100 = 4
     * 0101 = 5
     *  ...
     * 1111 = 15
     *
     * → 2 hoch 4 = 16 Zeichen können dargestellt werden.
     *
     * So geht das Binärsystem immer weiter und die Menge der darstellbaren Zeichen oder Zahlen entspricht 2 hoch der
     * Menge an Stellen, die genutzt wurden.
     *
     * Genau so arbeiten die Datentypen in C#. Sie nutzen einen vorgegebenen Speicherplatz, der durch den Datentyp bestimmt
     * wird.
     * [Exkurs Ende]
     *
     * Auf jeden Fall habt ihr jetzt verstanden, was ein "int" ist. Jetzt kommen wir zum Variablennamen. Der kam so ziemlich
     * alles sein. Ihr könnt eure Variable x oder y nennen, aber auch Pups oder Furz oder
     * "Rindfleischetikettierungsüberwachungsaufgabenübertragungsgesetz"
     */

    int rindfleischetikettierungsüberwachungsaufgabenübertragungsgesetz = 0;
    
    /*
     * JA, DAS GEHT WIRKLICH!!! Es gibt zur besseren Lesbarkeit noch bestimmte Regeln, die bei der Namensgebung eingehalten
     * werden sollten, damit es einfacher ist deinen Code zu verstehen. Zu diesen Regeln kommen wir aber erst, wenn es so
     * weit ist, das wir sie wirklich befolgen sollten.
     *
     * Nun kommen wir zum "=". Das ist eine sogenannte Zuweisung. Wir sagen, dass die Variable auf der linken Seite,
     * den Wert von dem bekommen soll, was auf der rechten Seite ist. In diesem Fall hier "0". Damit haben wir also unsere
     * ersten 2 Variablen. Sie sind nicht schön, aber selten.
     *
     * Jetzt zurück zu dem Beispiel von vorhin. Wir haben eine Katze mit 4 Pfoten. Wenn wir jetzt also eine Klasse Katze,
     * erstellen wollen und dieser 4 Pfoten geben wollen, dann würden wir das so schreiben:
     */

    private class Katze
    {
     public int Pfoten = 4;
    }
    
    /*
     * Zu dem Wörtern public und private kommen wir zu einem späteren Zeitpunkt.
     *
     * So damit haben wir schon mal die ersten zwei wichtigsten Elemente in C# gesehen und etwas verstanden. Beim nächsten
     * Mal geht es weiter mit Funktionen.
     */
    
    /*
     * Eine Variable hat 2 Zustände die sie erreichen kann. Der erste Zustand ist die sogenannte Deklaration.
     * Durch die Deklaration geben wir unserem Programmcode eine Variable mit einem Namen und mit einem Datentyp.
     * Datentypen gibt es einige, hier mal eine Liste:
     * bool, byte, sbyte, char, decimal, double, float, int, uint, nint, nuint, long, ulong, short, ushort
     */
    
    // Das klingt jetzt erstmal nach recht viel, aber davon brauchen wir eigentlich nur einen Teil.
    
    /*
     * Fangen wir mit bool an, auch Boolean genannt. Das ist ein Wahrheitswert. OK das klingt etwas eigen, aber wartet einfach auf die Erklärung.
     * Ein bool ist ein Datentyp, der nur aus einer 0 oder 1 besteht. Er hat also nur 2 Zustände. Sie werden auch mit
     * Wahr oder falsch (auf Englisch "true" oder "false") für uns als Programmierer übersetzt. Wir können mit ihnen
     * also einfach anzeigen, ob etwas wahr ist oder falsch ist. Also als Beispiel: Es regnet, also ist das Wetter scheiße ->
     * Variable istDasWetterScheiße = true
     */

    bool DasMeerIstBlau = true; // Das hier ist wahr

    bool DasMeerIstRot = false; // Das hier ist falsch
    
    /*
     * Mit diesen Variablen können wir oft Zustände testen, wie zum Beispiel: Hat diese Liste von Daten eine länge von 5?
     * Dies ist eine nicht selten gestellte Frage, wobei die noch häufiger gestellte Frage ist: Ist in der Liste überhaupt was drin?
     * Das ist damit ein sehr wichtiger Datentyp, den wir immer wieder brauchen werden. 
     */
    
    /*
     * Kommen wir jetzt zu einer kleinen praktischen Anwendung für Variablen, sonst wirds ja langweilig und schwer
     * verständlich wofür wir das eigentlich alles brauchen.
     * Dafür gibt es eine neue Datei, die ein MonoBehaviour Script ist.
     */
    
    
    
}
