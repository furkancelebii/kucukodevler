/****************************************************************************
**					SAKARYA ÜNÝVERSÝTESÝ
**			         BÝLGÝSAYAR VE BÝLÝÞÝM BÝLÝMLERÝ FAKÜLTESÝ
**				    BÝLGÝSAYAR MÜHENDÝSLÝÐÝ BÖLÜMÜ
**				          PROGRAMLAMAYA GÝRÝÞÝ DERSÝ
**	
**				ÖDEV NUMARASI…...:2. Ödev	
**				ÖÐRENCÝ ADI...............:Mazhar Furkan ÇELLEBÝ
**				ÖÐRENCÝ NUMARASI.:G191210033
**				DERS GRUBU…………:C
****************************************************************************/
#include<iostream>
#include<Windows.h>

using namespace std;
// X ve Y koordinatlarý için gerekli fonksiyon.
void gotoxy(int x, int y)
{
	COORD coord;
	coord.X = x;
	coord.Y = y;
	SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), coord);
}
// Ev sýnýfý tanýmladým.
class ev {
public:
	// Ev sýnýfý içinde çatý sýnýfý tasarladým.
	class cati {
	public:
		int catiyukseklik;
		void cati_yukseklik() {
			cout << "Lutfen cati yuksekligini giriniz:";
			cin >> catiyukseklik;
		}
	};
	// Ev sýnýfý içinde kat sýnýfý tasarladým.
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
	// Ev sýnýfý içinde kapý sýnýfý tasarladým.
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
	// Ev sýnýfý içinde konumlar için gerekli sýnýfý tasarladým.
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
		//Ev çizimi için ekraný temizledim.
		system("cls");
		char a = 219;
		int bosluksayisi;
		int yildizsayisi;
		yildizsayisi = kat1.katgenis - ((cati1.catiyukseklik - 1) * 2);
		bosluksayisi = cati1.catiyukseklik - 1;
		//Çatý çizimi için gerekli döngüyü tanýmlayýp Çatýyý ekrana yazdýrdým.
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
		// Katýn üst tarafýný çatýnýn hemen altýndaki noktadan baþlatýp ekrana yazdýrdým.
		for (int i = 0;i < kat1.katgenis;i++) {
			cout << a;
			Sleep(30);
		}
		// Katýn sað tarafýný ekrana yazdýrdým.
		for (int i = 0;i < kat1.katyuksek;i++) {
			gotoxy(evkonum1.konumx + kat1.katgenis - 1, i + evkonum1.konumy+ cati1.catiyukseklik);
			cout << a;
			Sleep(30);
		}
		// Katýn alt tarafýný ekrana yazdýrdým.
		for (int i = 0;i < kat1.katgenis;i++) {
			gotoxy(evkonum1.konumx + kat1.katgenis - i - 1, kat1.katyuksek + evkonum1.konumy - 1 + cati1.catiyukseklik);
			cout << a;
			Sleep(30);
		}
		// Katýn sol tarafýný ekrana yazdýrdým.
		for (int i = 0;i < kat1.katyuksek;i++) {
			gotoxy(evkonum1.konumx, kat1.katyuksek + evkonum1.konumy - i - 1 + cati1.catiyukseklik);
			cout << a;
			Sleep(30);
		}
		// Kapýyý katýn alt ksýmýndaki bi noktadan baþlatýp yazdýrdým.
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



