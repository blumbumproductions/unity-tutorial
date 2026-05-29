using UnityEngine;

public class MbVariablenTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
         * Wir nutzen wieder mal die Startfunktion, um direkt beim Starten des Spiels eine Ausgabe in der Console zu bekommen,
         * wie wir das auch schon beim letzten Tutorial gemacht haben.
         */
        
        // Zuerst erstellen wir eine Variable.
        int äpfel = 10; // Wir haben also 10 Äpfel

        int kinder = 4; // Wir haben 4 Kinder
        
        /*
         * Jetzt ist die Frage, wie viele Äpfel bekommt jedes Kind, wenn wir sie gerecht aufteilen wollen?
         * Dafür verwenden wir Rechenoperatoren. Diese sind genauso wie auch beim Taschenrechner:
         * + = Addition (Plus)
         * - = Subtraktion (Minus)
         * * = Multiplikation (Mal)
         * / = Division (Durch)
         */
        
        int äpfelFürJedesKind = äpfel / kinder; // Jetzt müssen wir also die Äpfel durch die Kinder Teilen und geben das Ergebnis einer neuen Variable.
        
        Debug.Log(äpfelFürJedesKind.ToString()); // Dann geben wir das ergebnis, ohne es selbst berechnet zu haben einfach in der console aus.
        
        /*
         * Hier kommt als Ergebnis in der Console raus: 2. Aber wieso? Ganz einfach 10 / 4 = 2,5 aber da wir das Ergebnis
         * einer Variable vom Typ int übergeben haben, ist es nur in der Lage einen int auszugeben und wir wissen ja schon
         * ein int enthält keine Kommazahlen. Also wird das Komma hinten abgeschnitten und raus kommt eine 2.
         */
        
        /*
         * Ein eher interessanteres Beispiel für Spieleentwickler ist natürlich:
         */

        int leben = 100; // Leben des Charakters

        int angriff = 14; // Angriff des Gegners

        int lebenNachDemAngriff = leben - angriff; // Neuer wert des Lebens des Charakters.
        
        Debug.Log(lebenNachDemAngriff); // Und wieder in der Console ausgeben.

        /*
         * Wie wir auch mit Kommazahlen und so weiter umgehen können, zeige ich euch beim nächsten Mal.
         */
    }
    
}
