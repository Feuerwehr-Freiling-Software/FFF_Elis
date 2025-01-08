namespace EPAS.BusinessLogic.Helper;

public class ColorHelper
{
    public static string GetColorForOperationName(string operationName)
    {
        switch (operationName)
        {
                // Brand
            
                case "Brandmeldealarm":
                case "Brandmeldealarm im Feuerwehrhaus":
                case "Brandmeldetaste gedrückt":
                case "Brand im Freien":
                case "Brand Abfall im Freien":
                case "Brand Abfallcontainer":
                case "Brand Container im Freien":
                case "Brand Kübel im Freien":
                case "Brand Bahndamm":
                case "Brand Elektroanlage im Freien":
                case "Brand Feld":
                case "Brand Fluren":
                case "Brand Wiese":
                case "Brand Stroh im Freien":
                case "Brand Gebüsch":
                case "Brand Baum":
                case "Brand PKW mit Elektroantrieb im Freien":
                case "Brand PKW mit Gasantrieb im Freien":
                case "Brand PKW im Freien":
                case "Brand Zweirad im Freien":
                case "Brand Kamin":
                case "Brandverdacht":
                case "Brand unklare Lage":
                case "Brand Anhänger im Freien":
                case "Brand Straßenbahn im Freien":
                case "Brand Traktor im Freien":
                case "Brand Baumaschine im Freien":
                case "Brand LKW im Freien":
                case "Brand Autobus im Freien":
                case "Brand Kleinbus im Freien":
                case "Brand Großfahrzeug mit Elektroantrieb im Freien":
                case "Brand Großfahrzeug mit Gasantrieb im Freien":
                case "Brand Großfahrzeug mit Gefahrstoffen":
                case "Brand kleines Luftfahrzeug":
                case "Absturz kleines Luftfahrzeug":
                case "Brand kleines Wasserfahrzeug":
                case "Brand Zug":
                case "Brand Gebäude":
                case "Brand Tankstelle":
                case "Brand Elektroanlage in Gebäude":
                case "Brand Carport":
                case "Brand Fahrzeug in Gebäude":
                case "Brand im Dachbereich":
                case "Brand Hochhaus":
                case "Brand Industrie":
                case "Brand Kleingebäude":
                case "Brand Schuppen":
                case "Brand Hütte":
                case "Brand Gartenhütte":
                case "Brand landwirtschaftliches Objekt":
                case "Brand Gebäude mehrstöckig":
                case "Brand Gebäude mit Menschenansammlung":
                case "Brand Tiefgarage":
                case "Brand Gas":
                case "Brand mit radioaktiven Stoffen":
                case "Brand Schadstoff":
                case "Brand Wald":
                case "Brand großes Luftfahrzeug":
                case "Absturz großes Luftfahrzeug":
                case "Brand großes Wasserfahrzeug":
                case "Brand Tunnel": return "#de4019";
                
                // TE
                
                case "Bergung Kleinfahrzeug":
                case "Bergung PKW":
                case "Bergung Traktor":
                case "Bergung Baumaschine":
                case "Bergung Kleinbus":
                case "Bergung Zweirad":
                case "Bergung Anhänger":
                case "Bergung Boot":
                case "Bergung auf Gewässer":
                case "Gleisbereich blockiert":
                case "Freimachen von Verkehrswegen":
                case "Türöffnung versperrtes KFZ":
                case "Aufzugsdefekt":
                case "Eingeschlossene Person in Lift":
                case "Ölaustritt Kleinmenge":
                case "Ölspur":
                case "Absturzdrohende Gegenstände":
                case "Baum droht umzustürzen":
                case "Baum ist umgestürzt":
                case "Sicherungsdienst Bombe":
                case "Dachsicherung":
                case "Sicherungsdienst Damm":
                case "Sicherungsdienst Gebäude":
                case "Gegenstände sichern":
                case "Eisstau":
                case "Sicherungsdienst Gewässer":
                case "Verklausung":
                case "Sicherungsdienst Hochwasser":
                case "Gebäude droht überflutet zu werden":
                case "Leitung / Mast sichern":
                case "Sicherungsdienst Vermurung - Rutschung":
                case "Vermurung":
                case "Rutschung":
                case "Sicherungsarbeiten":
                case "Türe sichern/verschließen":
                case "Absichern Verkehrsweg":
                case "Sonstiger Einsatz":
                case "Notstromversorgung":
                case "Gebäude überflutet":
                case "Keller überflutet":
                case "Kanalverstopfung":
                case "Wasserschaden":
                case "Unterführung überflutet":
                case "Überflutete Fahrbahn":
                case "Überfluteter Weg":
                case "Tragehilfe":
                case "Unwettererkundung":
                case "Kran droht umzustürzen":
                case "Kran ist umgestürzt":
                case "Türöffnung Herd eingeschalten":
                case "Türöffnung Menschenrettung":
                case "Türöffnung Unfallverdacht":
                case "Ölaustritt Gewässer":
                case "Ölaustritt groß":
                case "Person eingeklemmt":
                case "Personenrettung Einsturz":
                case "Personenevakuierung":
                case "Personenrettung Gewässer":
                case "Personenrettung hoch (über 10m)":
                case "Personenrettung hoch":
                case "Person droht zu springen":
                case "Personenrettung Stromunfall":
                case "Personensuche":
                case "Person Suizidverdacht":
                case "Personenrettung tief (über 10m)":
                case "Personenrettung tief":
                case "Personenrettung unwegsames Gelände":
                case "Person verschüttet":
                case "Person eingesunken":
                case "Beleuchtung":
                case "Dammbruch":
                case "Taucheinsatz":
                case "Rettung Großtier":
                case "Unterstützung Rettungsdienst":
                case "Kleines Wasserfahrzeug in Notlage":
                case "Bergung Großfahrzeug":
                case "Bergung Autobus":
                case "Bergung LKW":
                case "Bergung Luftfahrzeug":
                case "Ölaustritt Gewässer groß":
                case "Flugnotfall Linz-Airport":
                case "Großes Wasserfahrzeug in Notlage":
                case "Lawine": return "#0080ff";

                // VU
                
                case "Verkehrsunfall Aufräumarbeiten":
                case "Personenrettung Verkehrsunfall PKW":
                case "Person unter Fahrzeug – Maschine":
                case "Person unter Schienenfahrzeug":
                case "Personenrettung Verkehrsunfall Autobus":
                case "Personenrettung Verkehrsunfall LKW":
                case "Personenrettung Verkehrsunfall Zug":
                case "Zugszusammenstoß": return "#ffb400";

                // ABC
                
                case "Ammoniakaustritt":
                case "Chlorgasaustritt":
                case "Explosion - Explosionsgefahr":
                case "Gasaustritt":
                case "Gasgeruch wahrnehmbar":
                case "Kohlenmonoxidaustritt":
                case "Vergiftungsalarm ausgelöst":
                case "Schadstoffeinsatz Gewässer":
                case "Schadstoff Kleinmenge":
                case "Schadstoffeinsatz Radioaktiv":
                case "Schadstoffeinsatz":
                case "Schadstoff Dekontamination":
                case "Schadstoffeinsatz groß":
                case "Chlorgasalarm": return "#ff6e01";
                
                case "Bergung von Gegenständen":
                case "Bergung von Toten":
                case "Bergung totes Kleintier":
                case "Bergung totes Großtier":
                case "Brandnachschau":
                case "Brandwache":
                case "Reinigungsarbeiten":
                case "Entlaufenes Tier":
                case "Rettung Kleintier":
                case "Kleinalarm technisch":
                case "Insekteneinsatz":
                case "Reptilieneinsatz":
                case "Türöffnung ohne Gefahr":
                case "Untersuchung":
                case "undefinierbarer Geruch":
                case "Wassertransport": return "#7e848a";
                
                // FKAT
                
                case "F-KAT-Einsatz Bezirkswarnstelle":
                case "F-KAT-Einsatz Einsatzführungsunterstützung":
                case "F-KAT-Einsatz Hochwasserzug":
                case "F-KAT-Einsatz Klassischer Zug":
                case "F-KAT-Einsatz Personalzug":
                case "F-KAT-Einsatz Pumpenzug":
                case "F-KAT-Einsatz Schadstoffzug":
                case "F-KAT-Einsatz Stab-Groß":
                case "F-KAT-Einsatz Stab-Klein":
                case "F-KAT-Einsatz Technischer Zug":
                case "F-KAT-Einsatz TLF-Zug":
                case "F-KAT-Einsatz Vollschutzzug":
                case "F-KAT-Einsatz Wasserzug":
                case "F-KAT-Einsatz F-KAT-OÖ": return "#471e69";
                
                // ÖWR
                
                case "ÖWR-Einsatz - Boot angeschwemmt":
                case "ÖWR Einsatz - Boot gekentert":
                case "ÖWR Einsatz - Boot sichern":
                case "ÖWR Einsatz - Boot Sinkt, vermutlich keine Personen am Boot":
                case "ÖWR Einsatz - Boot treibt auf Gewässer":
                case "ÖWR Einsatz - Boot verhängt":
                case "ÖWR Einsatz - Defektes Boot auf Gewässer":
                case "ÖWR Einsatz - Herrenloses Boot auf Gewässer":
                case "ÖWR Einsatz - Einsatstorno Gewässereinsatz, kein Einsatz mehr erforderlich":
                case "ÖWR Einsatz - Boot in Not":
                case "ÖWR Einsatz - Boot sinkt, Personenrettung":
                case "ÖWR Einsatz - Lichtzeichen auf Gewässer wahrnehmbar":
                case "ÖWR Einsatz - Notsignal auf Gewässer wahrnehmbar":
                case "ÖWR Einsatz - Paragleiter in Gewässer gestürzt":
                case "ÖWR Einsatz - Person auf Gewässer vermisst":
                case "ÖWR Einsatz - Person in Not auf Gewässer":
                case "ÖWR Einsatz - Person treibt auf Gewässer":
                case "ÖWR Einsatz - Taucher in Gewässer vermisst":
                case "ÖWR Einsatz - Tauchunfall":
                case "ÖWR Einsatz - Undefinierbare Beobachtung auf Gewässer":
                case "ÖWR Einsatz - Vermisstes Boot auf Gewässer":
                case "ÖWR Einsatz - Abgängige Person nahe Gewässer":
                case "ÖWR Einsatz - Einsatz":
                case "ÖWR Einsatz - Bereitschaftsalarm":
                case "ÖWR Einsatz - Tierbergung":
                case "ÖWR Einsatz - Tierrettung":
                case "ÖWR Einsatz - Wildwassereinsatz": return "#004b94";
                
                // Sirenenprogramm
                
                case "Sirenenprogramm FEUER von FW ausgelöst":
                case "Sirenenprogramm Seveso CPL ausgelöst":
                case "Brandmeldetaste Gedrückt": return "";

                // Probe
                
                case "Brandmeldeanlagentest":
                case "Probealarm Bezirkswarnstelle Ried":
                case "Probealarm Bezirkswarnstelle Wels":
                case "Probealarm Landeswarnzentrale":
                case "Probealarm Schulung für Feuerwehr":
                case "Technische Probe für Feuerwehr":
                case "Übungsalarm Brandeinsatz für Feuerwehr":
                case "Übungsalarm Technischer Einsatz für Feuerwehr":
                case "Probealarm Oö. Ferngas":
                case "Probealarm Sirenen Oö.":
                case "Probealarm Wasserrettung":
                case "Probealarm Rufbereite Land und BH":
                case "Probealarm Sturmwarnanlagen":
                case "Probealarm Berufsfeuerwehr Linz": return "#734e28";

            default:
                return "#7e848a";
        }
    }
}