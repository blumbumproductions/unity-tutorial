using UnityEngine;

/// <summary>
/// Mit dieser Art von Klasse können wir Einfluss auf das nehmen, dass in der Engine passieren soll. Also was in unserem
/// Spiel passieren soll.
/// </summary>
public class MbTest : MonoBehaviour
{
    /// <summary>
    /// Diese Funktion ist eine grundlegende Funktion, die immer am Start des programms ausgeführt wird.
    /// Das ist nur die halbe Wahrheit, aber für euch erstmal so in Ordnung als Erklärung.
    /// </summary>
    void Start()
    {
        /*
         * Damit ihr mal etwas sehen könnt, was wirklich etwas auslöst, geben wir mal etwas Text in der Console aus.
         * Dafür müssen wir nur diese einfache Zeile schreiben. Sie besteht aus der Klasse Debug und von der nutzen wir
         * die Funktion Log. In diese Funktion geben wir unseren Text in Gänsefüßchen. Der erscheint dann in der Konsole,
         * wenn wir das Programm starten. Allerdings nur, wenn ihr vorher nicht vergessen habt, dass man ja dieses Script,
         * wie im Tutorial gesagt an ein GameObject hängen muss.
         */
        Debug.Log("Hallo Welt"); // Das schreibt dinge in die console
    }

    /// <summary>
    /// Diese Funktion wird in jedem vom Computer berechneten Frame ausgeführt (Also, wenn ihr mit 200Fps spielt 200 Mal in der Sekunde)
    /// Da das etwas oft ist, nutzen wir diese Funktion erst einmal nicht.
    /// </summary>
    void Update()
    {
        
    }
}
