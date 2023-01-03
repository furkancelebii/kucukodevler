/****************************************************************************
**					SAKARYA �N�VERS�TES�
**			         B�LG�SAYAR VE B�L���M B�L�MLER� FAK�LTES�
**				    B�LG�SAYAR M�HEND�SL��� B�L�M�
**				          PROGRAMLAMAYA G�R��� DERS�
**	
**				�DEV NUMARASI�...:2. �dev	
**				��RENC� ADI...............:Mazhar Furkan �ELLEB�
**				��RENC� NUMARASI.:G191210033
**				DERS GRUBU����:C
****************************************************************************/
#include<iostream>
#include<Windows.h>

using namespace std;
// X ve Y koordinatlar� i�in gerekli fonksiyon.
void gotoxy(int x, int y)
{
	COORD coord;
	coord.X = x;
	coord.Y = y;
	SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), coord);
}
// Ev s�n�f� tan�mlad�m.
class ev {
public:
	// Ev s�n�f� i�inde �at� s�n�f� tasarlad�m.
	class cati {
	public:
		int catiyukseklik;
		void cati_yukseklik() {
			cout << "Lutfen cati yuksekligini giriniz:";
			cin >> catiyukseklik;
		}
	};
	// Ev s�n�f� i�inde kat s�n�f� tasarlad�m.
	class kat {
	public:
		int katgenis;
		int katyuksek;
		void katfunction() {
			cout << "Lutfen evin genisligini giriniz:";
			cin >> katgenis;
			cout << "Lutfen evin yuksekligini giriniz:";
			cin >> katyuksek;
		}

	};
	// Ev s�n�f� i�inde kap� s�n�f� tasarlad�m.
	class kapi {
	public:
		int kapigenis;
		int kapiyuksek;
		void kapifunction() {
			cout << "Lutfen kapi genisligini giriniz:";
			cin >> kapigenis;
			cout << "Lutfen kapi yuksekligini giriniz:";
			cin >> kapiyuksek;
		}
	};
	// Ev s�n�f� i�inde konumlar i�in gerekli s�n�f� tasarlad�m.
	class evkonum {
	public:
		int konumx;
		int konumy;
		void evfunction() {
			cout << "Lutfen x konumunu giriniz:";
			cin >> konumx;
			cout << "Lutfen y konumunu giriniz:";
			cin >> konumy;
		}
	};
	cati cati1;
	kapi kapi1;
	evkonum evkonum1;
	kat kat1;

	void evciz() {
		cati1.cati_yukseklik();
		kat1.katfunction();
		kapi1.kapifunction();
		evkonum1.evfunction();
		//Ev �izimi i�in ekran� temizledim.
		system("cls");
		char a = 219;
		int bosluksayisi;
		int yildizsayisi;
		yildizsayisi = kat1.katgenis - ((cati1.catiyukseklik - 1) * 2);
		bosluksayisi = cati1.catiyukseklik - 1;
		//�at� �izimi i�in gerekli d�ng�y� tan�mlay�p �at�y� ekrana yazd�rd�m.
		for (int i = 0;i < cati1.catiyukseklik;i++) {
			gotoxy(evkonum1.konumx, evkonum1.konumy + i);
			for (int j = 0;j < bosluksayisi;j++) {
				cout << " ";
				Sleep(30);
			}
			for (int j = 0;j < yildizsayisi;j++) {
				cout << "*";
				Sleep(30);
			}
			cout << endl;
			bosluksayisi--;
			yildizsayisi += 2;
		}
		gotoxy(evkonum1.konumx, evkonum1.konumy + cati1.catiyukseklik);
		// Kat�n �st taraf�n� �at�n�n hemen alt�ndaki noktadan ba�lat�p ekrana yazd�rd�m.
		for (int i = 0;i < kat1.katgenis;i++) {
			cout << a;
			Sleep(30);
		}
		// Kat�n sa� taraf�n� ekrana yazd�rd�m.
		for (int i = 0;i < kat1.katyuksek;i++) {
			gotoxy(evkonum1.konumx + kat1.katgenis - 1, i + evkonum1.konumy+ cati1.catiyukseklik);
			cout << a;
			Sleep(30);
		}
		// Kat�n alt taraf�n� ekrana yazd�rd�m.
		for (int i = 0;i < kat1.katgenis;i++) {
			gotoxy(evkonum1.konumx + kat1.katgenis - i - 1, kat1.katyuksek + evkonum1.konumy - 1 + cati1.catiyukseklik);
			cout << a;
			Sleep(30);
		}
		// Kat�n sol taraf�n� ekrana yazd�rd�m.
		for (int i = 0;i < kat1.katyuksek;i++) {
			gotoxy(evkonum1.konumx, kat1.katyuksek + evkonum1.konumy - i - 1 + cati1.catiyukseklik);
			cout << a;
			Sleep(30);
		}
		// Kap�y� kat�n alt ks�m�ndaki bi noktadan ba�lat�p yazd�rd�m.
		for (int j = 0;j < kapi1.kapiyuksek;j++) {
			for (int i = 0;i < kapi1.kapigenis;i++) {
				gotoxy(evkonum1.konumx + kat1.katgenis - i - 3, kat1.katyuksek + evkonum1.konumy - 1 + cati1.catiyukseklik - j);
				cout << "#";
				Sleep(30);
			}
		}
		gotoxy(evkonum1.konumx + kat1.katgenis + kat1.katyuksek - 1, evkonum1.konumy + kat1.katgenis + kat1.katyuksek + 1);
		system("pause");
	}
};

int main() {
	ev ev1;
	ev1.evciz();


}



