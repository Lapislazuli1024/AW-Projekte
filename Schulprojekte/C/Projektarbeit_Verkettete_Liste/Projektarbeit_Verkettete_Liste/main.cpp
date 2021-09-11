#include <stdlib.h>
#include <stdio.h>
#include <string.h>
#include <conio.h> 
#include <time.h>

#define ANZ_BEZ 3

typedef struct Data {
	char Bez[50];
	double Preis;
} struDataElm;

typedef struct Elm {
	Elm* pNext;
	struct Data* pData;
} struListElm;

//Suche nach Datenstruktur mit kleinstem Preis
struListElm* MinPosPreis(struListElm* pMinStart) {
	struListElm* pMin = pMinStart;
	for (struListElm* pIndex = pMinStart->pNext; pIndex != NULL; pIndex = pIndex->pNext) {
		if (pIndex->pData->Preis < pMin->pData->Preis)pMin = pIndex;
	}
	return pMin;
}

//Suche nach Datenstruktur mit grösstem Preis
struListElm* MaxPosPreis(struListElm* pMaxStart) {
	struListElm* pMax = pMaxStart;
	for (struListElm* pIndex = pMaxStart->pNext; pIndex != NULL; pIndex = pIndex->pNext) {
		if (pIndex->pData->Preis > pMax->pData->Preis)pMax = pIndex;
	}
	return pMax;
}

//Suche nach Datenstruktur mit kleinster Bezeichnung
struListElm* MinPosBez(struListElm* pMinStart) {
	struListElm* pMin = pMinStart;
	char* pStr1 = NULL;
	char* pStr2 = NULL;
	for (struListElm* pIndex = pMinStart->pNext; pIndex != NULL; pIndex = pIndex->pNext) {
		pStr1 = pIndex->pData->Bez;
		pStr2 = pMin->pData->Bez;

		while (1) {
			if (*pStr1 != *pStr2) {
				if (*pStr1 < *pStr2) {
					pMin = pIndex;
					break;
				}
				break;
			}
			else if (*pStr1 == '\0') {
				if (pIndex->pData->Preis < pMin->pData->Preis) {
					pMin = pIndex;
				}
				break;
			}
			pStr1++; pStr2++;
		}
	}
	return pMin;
}

//Suche nach Datenstruktur mit grösster Bezeichnung
struListElm* MaxPosBez(struListElm* pMinStart) {
	struListElm* pMax = pMinStart;
	char* pStr1 = NULL;
	char* pStr2 = NULL;
	for (struListElm* pIndex = pMinStart->pNext; pIndex != NULL; pIndex = pIndex->pNext) {
		pStr1 = pIndex->pData->Bez;
		pStr2 = pMax->pData->Bez;

		while (1) {
			if (*pStr1 != *pStr2) {
				if (*pStr1 > * pStr2) {
					pMax = pIndex;
					break;
				}
				break;
			}
			else if (*pStr1 == '\0') {
				if (pIndex->pData->Preis < pMax->pData->Preis) {
					pMax = pIndex;
				}
				break;
			}
			pStr1++; pStr2++;
		}
	}
	return pMax;
}

//Umhängen/Austauschen von Datenstruktur an Verketteter Liste
int SwapData(struListElm* pSwap, struListElm* pIndex) {
	struDataElm* pTempDataElm = pSwap->pData;
	pSwap->pData = pIndex->pData;
	pIndex->pData = pTempDataElm;
	return 0;
}

//Sortieren von Verketteter Liste
int SortList(struListElm* pStart, const unsigned char* Sortparam, const unsigned char* Sortkrit) {

	//Sortierung

	//Bezeichnung
	if (*Sortparam == 1) {

		struListElm* pPosBez = NULL;

		//Aufsteigend
		if (*Sortkrit == 1) {
			for (struListElm* pIndex = pStart; pIndex != NULL; pIndex = pIndex->pNext) {
				pPosBez = MinPosBez(pIndex);
				if (pPosBez != pIndex) SwapData(pPosBez, pIndex);
			}
		}
		//Absteigend
		else {
			for (struListElm* pIndex = pStart; pIndex != NULL; pIndex = pIndex->pNext) {
				pPosBez = MaxPosBez(pIndex);
				if (pPosBez != pIndex) SwapData(pPosBez, pIndex);
			}
		}
	}
	//Preis
	else {
		struListElm* pPosPreis = NULL;

		//Aufsteigend
		if (*Sortkrit == 1) {
			for (struListElm* pIndex = pStart; pIndex != NULL; pIndex = pIndex->pNext) {
				pPosPreis = MinPosPreis(pIndex);
				if (pPosPreis != pIndex) SwapData(pPosPreis, pIndex);
			}
		}
		//Absteigend
		else {
			for (struListElm* pIndex = pStart; pIndex != NULL; pIndex = pIndex->pNext) {
				pPosPreis = MaxPosPreis(pIndex);
				if (pPosPreis != pIndex) SwapData(pPosPreis, pIndex);
			}
		}
	}
	return 0;
}

//Einlesen von Sortierungskriterien (Bezeichnung/Preis) & (Aufsteigend/Absteigend)
int ReadSortKrit(struListElm* pSrtStart, double* sortTime) {

	//Variablen für Sortierkriterien
	unsigned char Sortparam = '\0';
	unsigned char Sortkrit = '\0';

	system("cls");

	//Sortiermenü Eingabe Dialog
	printf("|-----------------------------------------------------------------------|\n");
	printf("|                   Sortierung von verketteter Liste                    |\n");
	printf("|-----------------------------------------------------------------------|\n");

	printf("\n  Nach welchem Wert soll sortiert werden?: \n");

	printf("\t-> 1. Bezeichnung\n");
	printf("\t-> 2. Preis      \n");

	printf("\n\n  Option ausw\x84hlen: ");
	//Einlesen von ausgewälter Option minus 0 um ASCII Umrechnung zu löschen 
	//z.b Eingabe 2(50) - 0(48) => 2
	(!_kbhit()); Sortparam = (int)_getch() - '0';

	//Abfangen von ungültigen Optionen
	if (Sortparam == 1 || Sortparam == 2) {

		//Ausgabe von Eingabe für schönere Ansicht
		printf("%hhu", Sortparam);

		printf("\n\n--------------------------------------\n");

		printf("\n  In welcher Reihenfolge soll sortiert werden?: \n");

		printf("\t-> 1. Aufsteigend\n");
		printf("\t-> 2. Absteigend \n");

		printf("\n\n  Option ausw\x84hlen: ");
		//Einlesen von ausgewälter Option minus 0 um ASCII Umrechnung zu löschen 
		//z.b Eingabe 2(50) - 0(48) => 2
		(!_kbhit()); Sortkrit = (int)_getch() - '0';

		if (Sortkrit == 1 || Sortkrit == 2) {
			//Ausgabe von Eingabe für schönere Ansicht
			printf("%hhu\n", Sortkrit);

			printf("\n\n  Sortiere...\n");

			// Startzeit merken
			clock_t StartZeit = clock();

			//Sortierung mit eingegebenen Parameter starten
			SortList(pSrtStart, &Sortparam, &Sortkrit);

			// Endzeit merken
			clock_t EndZeit = clock();

			//Dauer der Sortierung aus Differenz berechnen 
			*sortTime = ((double)EndZeit - (double)StartZeit) / (double)CLOCKS_PER_SEC;

		}
		else {
			//Falsche Eingabe
			printf("%d", 0);
			printf("\n\n  -> Fehler! \n     Das ist keine g\x81ltige Option!\n");
			return 1;
		}
	}
	else {
		//Falsche Eingabe
		printf("%d", 0);
		printf("\n\n  -> Fehler! \n     Das ist keine g\x81ltige Option!\n");
		return 1;
	}
	return 0;
}

//Hier sieht man das Startfenster des Programmes
//von hier aus kann man aus weiter in die "erstellen", "sortieren", "ausgeben"
void ProgrammStart() {

	printf("\xDA\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xBF\n");
	printf("\xB3                    Projektarbeit von Giuliano und Ameo!                     \xB3\n");
	printf("\xC0\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xc4\xD9\n");

	printf("\n  Mit diesem Programm l\x84sst sich eine einfache verkettete Liste verwalten!\n");
	printf("\t-> erstellen\n");
	printf("\t-> sortieren\n");
	printf("\t-> ausgeben\n");
	printf("\t-> l\x94schen\n");

	printf("\n\n  Weiter zum Programm ..."); while (!_kbhit()); _getch();
	printf("\n\n");
}

// Generiert zufällige Daten
int GenDataElm(struDataElm* Data)
{
	//Random Generierung von Bez
	for (int i = 0; i < ANZ_BEZ; i++) {
		Data->Bez[i] = 65 + (rand() % 26);
	}
	Data->Bez[ANZ_BEZ] = '\0';
	//Random Generierung von Preis
	Data->Preis = (double)((int)rand() % 9901 / 10.0) + 10.0;
	return 0;
}

// Löscht die gesammte Liste iterativ
int DeleteList(struListElm* pStart) {
	struListElm* pAfter = NULL;
	for (struListElm* pCurrent = pStart; pCurrent != NULL; pCurrent = pAfter)
	{
		pAfter = pCurrent->pNext;
		free(pCurrent->pData);
		free(pCurrent);
	}
	return 0;
}

// Ausgeben der gesammte Liste
void ListOut(struListElm* pListStart, int* AnzElm) {

	int AnzahlElm = 0;

	//Eingabe
	printf("  Maximale Anzahl von Elementen: %d\n", *AnzElm);
	printf("  Anzahl Elmente welche ausgegeben werden sollen (0 = alle): ");
	int ScanfFehler = scanf_s("%d", &AnzahlElm);

	//Prüfung
	if (ScanfFehler != 0 && AnzahlElm <= *AnzElm)
	{
		//Hilfscounter
		int index = 1;
		//Tabellenkopf Ausgabe
		printf("\n  +---------------+----------------+---------------+\n");
		printf("  |     Index     |    Datentyp    |     Preis     |\n");
		printf("  +---------------+----------------+---------------+\n");

		//Ausgabe
		if (AnzahlElm == 0)
		{
			for (struListElm* pOut = pListStart; pOut != NULL; pOut = pOut->pNext)
			{
				printf("  |    %6.i     |      %s       |    %6.1lf     |\n", index, pOut->pData->Bez, pOut->pData->Preis);
				index++;
			}
		}
		else
		{
			for (struListElm* pOut = pListStart; index <= AnzahlElm; pOut = pOut->pNext)
			{
				printf("  |    %6.i     |      %s       |    %6.1lf     |\n", index, pOut->pData->Bez, pOut->pData->Preis);
				index++;
			}
		}

		printf("  +---------------+----------------+---------------+\n");
	}
	else
	{
		printf("Ung\x81ltiger Wert eingegeben!");
	}
}

// Erstellen einer verketteten Liste
int CreateList(struListElm** ppStart, int* AnzElm) {

	struListElm* pLast = NULL;
	int Anzahl = 0;

	printf("  Anzahl Objekte eingeben: ");

	if ((scanf_s("%d", &Anzahl) != 0) && Anzahl > 0)
	{
		//Speichern von Anzahl Elemente
		*AnzElm = Anzahl;

		for (int i = 0; i < Anzahl; i++) {

			struListElm* pNewListElm = (struListElm*)malloc(sizeof(struListElm));
			//kein Arbeitsspeicher
			if (pNewListElm == NULL) return 1;

			pNewListElm->pNext = NULL;

			struDataElm* pNewDataElm = (struDataElm*)malloc(sizeof(struDataElm));
			//kein Arbeitsspeicher
			if (pNewDataElm == NULL) return 1;

			//Datenstruktur füllen
			GenDataElm(pNewDataElm);

			//Datenstruktur anhängen 
			pNewListElm->pData = pNewDataElm;

			if (*ppStart == NULL) *ppStart = pNewListElm;
			if (pLast != NULL) pLast->pNext = pNewListElm;

			pLast = pNewListElm;
		}
	}
	else
	{
		printf("\n  Ung\x81ltiger Wert eingegeben!\n");
		return 1;
	}
	return 0;
}

// Hauptmenü 
int main()
{
	//Initialisierung von Rand das wir nicht immer die gleichen rand() Werte bekommen
	srand((unsigned)time(NULL));

	//Variablen
	struListElm* pStart = NULL; 
	double SortTime = 0.0;
	unsigned char Fehler = 0; //Gewinnung von 3 Bytes
	unsigned char Input = 0;
	unsigned char ListIsCreated = 0; //Boolean 
	int AnzElm = 0;

	//Anzeigen von Startdialog
	ProgrammStart();

	//Start des Hauptmenü mit Optionen
	do
	{
		//Hauptmenü
		system("cls");
		printf("|-----------------------------------------------------------------------|\n");
		printf("|               Hauptmen\x81 von Listenverwaltungs Programm                |\n");
		printf("|-----------------------------------------------------------------------|\n");

		printf("\n  Optionen: \n");

		printf("\t-> 1. Liste erstellen     %s\n", ListIsCreated ? "(Nicht Verf\x81gbar)" : "");
		printf("\t-> 2. Liste sortieren     %s\n", ListIsCreated ? "" : "(Nicht Verf\x81gbar)");
		printf("\t-> 3. Liste ausgeben      %s\n", ListIsCreated ? "" : "(Nicht Verf\x81gbar)");
		printf("\t-> 4. Liste l\x94schen       %s\n", ListIsCreated ? "" : "(Nicht Verf\x81gbar)");
		printf("\t-> 5. Programm beenden!\n");

		printf("\n\n  Option ausw\x84hlen: ");
		//Einlesen von ausgewälter Option minus 0 um ASCII Umrechnung zu löschen 
		//Verschiebung von Skala, 48-57 zu 0-9
		//z.b Eingabe 2(50) - 0(48) => 2 
		(!_kbhit()); Input = (int)_getch() - '0';

		//Abfangen von ungültigen Optionen
		if (Input >= 1 && Input <= 5) {
			//Ausgabe von Eingabe für schönere Ansicht
			printf("%d\n", Input);

			//Liste Erstellen
			if (Input == 1 && ListIsCreated == 0) {
				printf("\n\n  -> Men\x81punkt 1 (Liste Erstellen)\n\n");
				//Erstellen
				Fehler = CreateList(&pStart, &AnzElm);

				printf("\n  Das erstellen war %s", Fehler ? "nicht erfolgreich! -> Fehler !" : "erfolgreich!");
				if (!Fehler) ListIsCreated = 1;
			}
			//Liste Sortieren
			else if (Input == 2 && ListIsCreated) {
				//Sortieren
				Fehler = ReadSortKrit(pStart, &SortTime);
				printf("\n\n  Das Sortieren war %s", Fehler ? "nicht erfolgreich! -> Fehler !" : "erfolgreich!");

				printf("\n\n  Die Sortierung von %d Elemente ben\x94tigte %.3lf Sekunden", AnzElm, SortTime);
			}
			//Liste Ausgeben
			else if (Input == 3 && ListIsCreated) {
				printf("\n  -> Men\x81punkt 3 (Liste Ausgeben)\n\n");
				ListOut(pStart, &AnzElm);
			}
			//Liste Löschen
			else if (Input == 4 && ListIsCreated) {
				printf("\n\n  -> Men\x81punkt 4 (Liste L\x94schen)\n\n");

				//Bestätigung von User
				printf("  Wollen Sie die Liste wirklich l\x94schen? (j/n): ");
				while (!_kbhit());
				if (_getch() == 'j') {
					DeleteList(pStart);
					pStart = NULL;
					ListIsCreated = 0;

					printf("\n\n  Die Liste wurde erfolgreich gel\x94scht");
				}
				else {
					printf("\nL\x94schung der Liste Abgebrochen!");
				}
			}
			//Programm beenden
			else if (Input == 5) {
				system("cls");
				printf("\n  Programm wirklich beenden? (j/n): ");
				while (!_kbhit());
				if (_getch() == 'j') {

					//Liste Löschen -> Speicher freigeben
					if (ListIsCreated)
						DeleteList(pStart);
					return 0;
				}
			}
			else {
				printf("\n  -> Fehler!\n  Diese Option ist nicht Verf\x81gbar");
			}
		}
		else {
			printf("%d", 0);
			printf("\n\n  -> Fehler! \n     Das ist keine g\x81ltige Option!\n");
		}
		//Abfragen von Tastendruck zum Weitermachen
		printf("\n\nWeiter..."); while (!_kbhit()); _getch();
	} while (true);

	return 0;
}