using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DictManager : MonoBehaviour
{
    public Text textDescription, mainTitle, EnTitle;
    public Image movement;
    string[] descs = new string[8];
    string[] title1 = new string[8];
    string[] title2 = new string[8];
    Sprite[] images = new Sprite[8];
    public GameObject canvasView;

    private void Start()
    {
        descs[0] = "Czy ch�op, si�� zaci�gni�ty do wojska po przegranej bitwie pod Rente�l odpowiada za decyzje swoich dow�dc�w? Czy odpowiedzialno�� zbiorowa to jeszcze sprawiedliwo��? Oczywi�cie to pytania retoryczne. Taki ch�op jest tylko i wy��cznie mi�sem, kt�rego jak zginie od pierwszego ciosu, op�akiwa� nikt nie b�dzie.";
        descs[1] = "Ciii� s�yszysz? Ja te� nie. To mo�e tylko oznacza� �e gdzie� w pobli�u s� zwiadowcy. Je�li nie b�dziemy si� rusza� mo�e zabij� nas szybko. Je�li natomiast zaczniemy biec - ich strza�y przerobi� nasze cia�a w dziurawy ser.";
        descs[2] = "Szybki niczym rumak. Dok�adny niczym Lord Laroy, planuj�cy inwazj� na kr�lestwa p�nocy. Waleczny niczym lew. I co najgorsze - by�y �o�nierz Kr�la Vertiego, maszyna do zabijania bez skrupu��w.";
        descs[3] = "Wie�e obl�nicze mia�y za zadanie dostarcza� wojska atakuj�ce w pobli�e mur�w, i u�atwi� im dostanie si� na nie. Natomiast wie�e braci Chevalier to taran, mog�cy porusza� si� z olbrzymi� pr�dko�ci� - niszcz�c wszystko na swojej drodze.";
        descs[4] = "Sprytny, bezlitosny i szybki. Go�ce nie brn� na o�lep do przodu. Go�ce lubi� si� bawi� swoj� ofiar�. Je�li zobaczysz go�ca, okr��aj�cego ci� - mo�esz zacz�� si� modli� o szybk� �mier� - tylko ona mo�e ci� wybawi� od b�lu, zadawanego przez Go�ca.";
        descs[5] = "Na przedzie upiornego orszaku braci Chevalier gnaj� ogary, niczym lodowy py� ci�gn�cy si� za komet�. Pono� czasami gubi� drog� i schodz� z nocnego nieba na ziemi�, przynosz�c ze sob� zimno i �mier�.";
        descs[6] = "Z�ote dziecko, kt�re wyros�o na zbrodniarza. Tak mo�na opisa� ka�dego z dow�dc�w, kt�rzy rywalizuj� ze sob� od malca. Pewnego razu aby udowodni�, kt�ry jest silniejszy wymordowali osiem wiosek. Nawet Samson Chevalier czu� niekiedy przera�enie, patrz�c w ich puste, ch�ci mordu oczodo�y.";
        descs[7] = "Samson czy Albert? To tak jakby wybiera� mi�dzy z�em a z�em. Przekl�ci, kt�rzy musieli wraz ze swoim wojskiem sta� si� swoj� w�asn� gr�. Pami�taj, �e ich zab�jcy bowiem podziel� los wielkich braci Chevalier.";

        title1[0] = "Pion";
        title1[1] = "Zwiadowca";
        title1[2] = "�ucznik";
        title1[3] = "Wie�a";
        title1[4] = "Goniec";
        title1[5] = "Skoczek";
        title1[6] = "Hetman";
        title1[7] = "Przekl�ty";

        title2[0] = "Pawn";
        title2[1] = "Scout";
        title2[2] = "Archer";
        title2[3] = "Rook";
        title2[4] = "Bishop";
        title2[5] = "Knight";
        title2[6] = "Queen";
        title2[7] = "Cursed";

        images[0] = Resources.Load<Sprite>("PawnMv");
        images[1] = Resources.Load<Sprite>("ScoutMv");
        images[2] = Resources.Load<Sprite>("ArcherMv");
        images[3] = Resources.Load<Sprite>("RookMv");
        images[4] = Resources.Load<Sprite>("BishopMv");
        images[5] = Resources.Load<Sprite>("KnightMv");
        images[6] = Resources.Load<Sprite>("QueenMv");
        images[7] = Resources.Load<Sprite>("CursedMv");
    }

    public void Pawn()
    {
        textDescription.text = descs[0];
        mainTitle.text = title1[0];
        EnTitle.text = title2[0];
        movement.sprite = images[0];
    }

    public void Scout()
    {
        textDescription.text = descs[1];
        mainTitle.text = title1[1];
        EnTitle.text = title2[1];
        movement.sprite = images[1];
    }

    public void Archer()
    {
        textDescription.text = descs[2];
        mainTitle.text = title1[2];
        EnTitle.text = title2[2];
        movement.sprite = images[2];
    }

    public void Rook()
    {
        textDescription.text = descs[3];
        mainTitle.text = title1[3];
        EnTitle.text = title2[3];
        movement.sprite = images[3];
    }

    public void Bishop()
    {
        textDescription.text = descs[4];
        mainTitle.text = title1[4];
        EnTitle.text = title2[4];
        movement.sprite = images[4];
    }

    public void Knight()
    {
        textDescription.text = descs[5];
        mainTitle.text = title1[5];
        EnTitle.text = title2[5];
        movement.sprite = images[5];
    }

    public void Queen()
    {
        textDescription.text = descs[6];
        mainTitle.text = title1[6];
        EnTitle.text = title2[6];
        movement.sprite = images[6];
    }

    public void Cursed()
    {
        textDescription.text = descs[7];
        mainTitle.text = title1[7];
        EnTitle.text = title2[7];
        movement.sprite = images[7];
    }

    public void CanvasView()
    {
        canvasView.SetActive(false);
    }
}
